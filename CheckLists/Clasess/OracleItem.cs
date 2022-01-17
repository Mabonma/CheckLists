using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckLists.Clasess
{
    public class OracleItem : IOracleItem
    {
        int id;
        public int ID { get => id; set => id = value; }

        string author_name;
        public string Author_Name { get => author_name; set => author_name = value; }

        string db_name;
        public string DB_Name { get => db_name; set => db_name = value; }

        string user_name;
        public string User_Name { get => user_name; set => user_name = value; }

        string sql_query_text;
        public string SQL_Query_Text { get => sql_query_text; set => sql_query_text = value; }

        public OracleItem() { }

        public OracleItem(int iD, string author_Name, string dB_Name, string user_Name, string sQL_Query_Text)
        {
            ID = iD;
            Author_Name = author_Name;
            DB_Name = dB_Name;
            User_Name = user_Name;
            SQL_Query_Text = sQL_Query_Text;
        }
    }
}
