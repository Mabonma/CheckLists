using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.DataAccess.Client;
using CheckLists.Clasess;

namespace CheckLists.SQL
{
    public static class Oracle
    {
        private static readonly string BSS17ocs = "Data Source=BSS17; User Id=admin; Password=admin";
        private static readonly string FORPocs = "Data Source=forp; User Id=automat; Password=automat_1";
        private static readonly string ACCENTocs = "Data Source=AWARD; User Id=develop; Password=devpassword";

        public static DateTime GetLastWorkingDay()
        {
            DateTime result = DateTime.Now;
            try
            {
                using (OracleConnection conn = new OracleConnection(FORPocs))
                using (OracleCommand cmd = new OracleCommand())
                {
                    cmd.Connection = conn;
                    conn.Open();

                    cmd.CommandText = @"select CLDR_CODE 
                                        from s_branch_cldr 
                                        where CLDR_CODE between (sysdate-8) AND (sysdate-1) 
                                        AND CLDR_BRANCH = 117 
                                        AND CLDR_WRK = 'Y' 
                                        AND ROWNUM = 1 
                                        ORDER BY CLDR_CODE desc";

                    OracleDataReader dr = cmd.ExecuteReader();

                    if (dr.HasRows) result = Convert.ToDateTime(dr["CLDR_CODE"]);
                }
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message + "\n" + e.StackTrace);
            }
            return result;
        }

        public static DateTime GetNextWorkingDay()
        {
            DateTime result = DateTime.Now;
            try
            {
                using (OracleConnection conn = new OracleConnection(FORPocs))
                using (OracleCommand cmd = new OracleCommand())
                {
                    cmd.Connection = conn;
                    conn.Open();

                    cmd.CommandText = @"select CLDR_CODE 
                                        from s_branch_cldr 
                                        where CLDR_CODE between (sysdate-1) AND (sysdate+6) 
                                        AND CLDR_BRANCH = 117 
                                        AND CLDR_WRK = 'Y' 
                                        AND ROWNUM = 1 
                                        ORDER BY CLDR_CODE";

                    OracleDataReader dr = cmd.ExecuteReader();

                    if (dr.HasRows) result = Convert.ToDateTime(dr["CLDR_CODE"]);
                }
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message + "\n" + e.StackTrace);
            }
            return result;
        }

        public static int GetStatementsCount(DateTime startDate, DateTime finishDate)
        {
            int result = 0;
            try
            {
                using (OracleConnection conn = new OracleConnection(BSS17ocs))
                using (OracleCommand cmd = new OracleCommand())
                {
                    cmd.Connection = conn;
                    conn.Open();

                    cmd.BindByName = true;
                    cmd.CommandText = @"select count(*)  
                                    from statementby t
                                    where t.statementdate = :start_date
                                    and dataactuality between to_date(:start_date || ' 20:00:00', 'dd.mm.yyyy hh24:mi:ss')
                                    and to_date(:end_date || ' 11:30:59', 'dd.mm.yyyy hh24:mi:ss')";
                    cmd.Parameters.Add("start_date", startDate.ToString("dd.MM.yyyy"));
                    cmd.Parameters.Add("end_date", finishDate.ToString("dd.MM.yyyy"));

                    OracleDataReader dr = cmd.ExecuteReader();
                    if (dr.HasRows) result = Convert.ToInt32(dr[0]);
                }
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message + "\n" + e.StackTrace);
            }
            return result;
        }

        public static List<AccentJournalItem> GetAccentJournal(DateTime startDate, bool isOnlyUpload, string partmess)
        {
            List<AccentJournalItem> result = new List<AccentJournalItem>();

            string query;

            if (isOnlyUpload)
            {
                query = @"select * from journal t
                            where t.id_journal >= (select max(journal.id_journal) 
                                from journal 
                                where journal.message like '%Запуск утренней закачки%' 
                                and journal.date_time >= :start_date
                                and journal.date_time <= :end_date)
                            and t.id_journal <= (select max(journal.id_journal) 
                            from journal 
                            where journal.message 
                            like '%Upload databases of branches is completed%'
                            and journal.date_time >= :start_date
                            and journal.date_time <= :end_date)";
            }
            else
            {
                query = @"select * from journal t 
                            where t.date_time >= :start_date
                            and t.date_time <= :end_date
                            and message like '%" + partmess + "%'";
            }

            try
            {
                using (OracleConnection conn = new OracleConnection(ACCENTocs))
                using (OracleCommand cmd = new OracleCommand())
                {
                    cmd.Connection = conn;
                    conn.Open();

                    cmd.BindByName = true;
                    cmd.CommandText = query;
                    cmd.Parameters.Add("start_date", startDate.ToString("dd.MM.yyyy"));
                    cmd.Parameters.Add("end_date", startDate.AddDays(1).ToString("dd.MM.yyyy"));
                    //cmd.Parameters.Add("partmess", partmess);

                    OracleDataReader dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        int id = Convert.ToInt32(dr["id_journal"]);
                        string recordTime = Convert.ToString(dr["date_time"]);
                        string message = Convert.ToString(dr["message"]);

                        result.Add(new AccentJournalItem(id, recordTime, message));
                    }
                }
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message + "\n" + e.StackTrace);
            }
            return result;
        }

        public static List<List<string>> OracleQuery(string query, string dbname, string usname, string pass)
        {
            List<List<string>> result = null;

            OracleConnection conn = new OracleConnection("Data Source=" + dbname + "; User Id=" + usname + "; Password=" + pass);
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            conn.Open();

            cmd.CommandText = query;

            OracleDataReader dr = cmd.ExecuteReader();

            try
            {
                if (!dr.HasRows) return null;
                result = new List<List<string>>();
                dr.Read();
                result.Add(new List<string>());
                result.Add(new List<string>());
                for (int i = 0; i < dr.FieldCount; i++)
                {
                    result[0].Add(dr.GetName(i));
                    result[1].Add(dr[i].ToString());
                }
                while (dr.Read())
                {
                    result.Add(new List<string>());
                    for (int i = 0; i < dr.FieldCount; i++)
                    {
                        result[result.Count - 1].Add(dr[i].ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Ошибка при создании ответа с Oracle\n" + ex.Message + "\n" + ex.StackTrace);
                return new List<List<string>>();
            }
            return result;
        }
    }
}
