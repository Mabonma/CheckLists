using CheckLists.Clasess;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckLists.SQL
{
    /// <summary>
    /// Класс для взаимодействия с SQLite
    /// </summary>
    public static class SQLite
    {
        #region Строки для подключений

        //Строки для сервака
        /// <summary>
        /// путь к папке, в которой хранится БД
        /// </summary>
        public static string DB_DIR = @""; //\\dispodb4\C$\orr\
        /// <summary>
        /// Путь в файлу с БД
        /// </summary>
        public static string DB_PATH = @"\orr.db";
        /// <summary>
        /// Строка подключения
        /// </summary>
        public static string _connectionString = $"Data source={DB_PATH};";

        //Строки для локалки
        /// <summary>
        /// путь к папке, в которой хранится БД
        /// </summary>
        public static string CurDB_DIR = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + @"\DBCheckList\orr\";
        /// <summary>
        /// Путь в файлу с БД
        /// </summary>
        public static string CurDB_PATH = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + @"\DBCheckList\orr\orr.db";
        /// <summary>
        /// Строка подключения
        /// </summary>
        public static readonly string _connectionStringCur = $"Data source={CurDB_PATH};";

        //окончательная строка подключения
        /// <summary>
        /// Путь к БД, чтобы кучу раз не указывать
        /// </summary>
        public static string toconnect = _connectionString;
        
        #endregion

        /// <summary>
        /// Создание БД
        /// </summary>
        /// <param name="type">Тип подклчения. true - локально, false - сервер</param>
        /// <returns></returns>
        public static string CreateDB()
        {
            try
            {
                if (toconnect.Equals(_connectionStringCur))
                {
                    SQLiteConnection.CreateFile(CurDB_PATH);
                }
                else
                {
                    SQLiteConnection.CreateFile(DB_PATH);
                }

                using (SQLiteConnection conn = new SQLiteConnection(toconnect, true))
                {
                    conn.Open();
                    using (SQLiteCommand cmd = new SQLiteCommand(conn))
                    {
                        cmd.CommandText = @"CREATE TABLE 'shifts' (
                                                'id'	INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT UNIQUE,
                                                'index_number'	INTEGER,
                                                'name'	TEXT,
                                                'time_after'	TEXT,
                                                'time_before'	TEXT
                                            );
                                            CREATE TABLE 'shifts_items' (
                                            	'id'	INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT UNIQUE,
                                            	'index_number'	INTEGER,
                                            	'name'	TEXT,
                                            	'description'	TEXT,
                                            	'time_after'	TEXT,
                                            	'time_before'	TEXT,
                                            	'is_active'	INTEGER,
                                            	'shift_id'	INTEGER,
                                            	FOREIGN KEY('shift_id') REFERENCES 'shifts'('id') ON DELETE CASCADE
                                            );
                                            CREATE TABLE 'journal' (
                                                'id'	INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT UNIQUE,
                                                'shift_id'	INTEGER,
                                                'shift_item_id'	INTEGER,
                                                'comment'	TEXT,
                                                'author_name'	TEXT,
                                                'record_time'	TEXT,
                                                FOREIGN KEY('shift_item_id') REFERENCES 'shifts_items'('id') ON DELETE SET NULL,
                                                FOREIGN KEY('shift_id') REFERENCES 'shifts'('id') ON DELETE SET NULL
                                            );
                                            CREATE TABLE 'settings' (
	                                            'id'	INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT UNIQUE,
	                                            'setting_name'	TEXT,
	                                            'setting_value'	TEXT
                                            );
                                            CREATE TABLE 'sql_queries' (
                                                'ID'    INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
                                                'author_name'   TEXT,
	                                            'db_name'   TEXT,
	                                            'user_name' TEXT,
	                                            'sql_query_text'    TEXT
                                            )
                                            insert into settings(setting_name) values('IsidaMessageRecipients');
                                            insert into settings(setting_name) values('HalvaBallFilePath');
                                            insert into settings(setting_name) values('SapZadolgnaFolder');
                                            insert into settings(setting_name) values('SapPrdtsFolder');
                                            insert into settings(setting_name) values('OsedResponseFolder');
                                            insert into settings(setting_name) values('KreditVitrFilePath');
                                            CREATE INDEX 'SortShfIteInd' ON 'shifts_items' ('index_number'  ASC);
                                            CREATE INDEX 'SortTime' ON 'journal' ('record_time'   DESC);";

                        cmd.ExecuteNonQuery();
                    }
                }

                return null;
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }

        public static void LoadPathDB()
        {
            StreamReader read = new StreamReader("path.dat", System.Text.Encoding.GetEncoding(1251));
            string mes = read.ReadLine() + @"\";
            read.Close();
            mes = new string(mes.Where(c => !char.IsControl(c)).ToArray());
            //System.Windows.Forms.MessageBox.Show(mes);
            DB_DIR = mes;
            DB_PATH = DB_DIR + @"orr.db";
            //System.Windows.Forms.MessageBox.Show(DB_PATH);
            if (!Program.local)
            {
                _connectionString = $"Data source={DB_PATH};";
            }
            //System.Windows.Forms.MessageBox.Show(_connectionString);
            //System.Windows.Forms.MessageBox.Show(DB_DIR);
            //SQL.SQLite.DB_DIR = File.ReadLines("path.dat", System.Text.Encoding.GetEncoding(1251)) + @"\";
            //MessageBox.Show(File.ReadAllText("path.dat"));
        }

        /// <summary>
        /// Проверка возможности подключения к БД и запуск создания
        /// </summary>
        /// <param name="type">Тип подклчения. true - локально, false - сервер</param>
        public static void Checks(bool type = false)
        {
            LoadPathDB();
            string path;
            if (type)
            {
                toconnect = _connectionStringCur;
                path = CurDB_DIR;
                if (!Directory.Exists(path)) Directory.CreateDirectory(Path.GetDirectoryName(path));
            }
            else if (!Directory.Exists(DB_DIR))
            {
                System.Windows.Forms.MessageBox.Show("dispodb4 не доступен. Будет использовано локальное хранилище");
                path = CurDB_DIR;
                type = true;
                toconnect = _connectionStringCur;
                if (!Directory.Exists(path)) Directory.CreateDirectory(Path.GetDirectoryName(path));
            }
            else
                toconnect = _connectionString;

            if (type)
            {
                path = CurDB_PATH;
            }
            else
                path = DB_PATH;

            if (!File.Exists(path))
            {
                System.Windows.Forms.MessageBox.Show("Отсутствует база данных. Сейчас будет создана новая БД.");
                string mes = CreateDB();
                if (mes == null)
                {
                    System.Windows.Forms.MessageBox.Show("База Данных успешно создана");
                }
                else
                    System.Windows.Forms.MessageBox.Show("В процессе создания Базы Данных возникли проблемы.\n\nПодробности:\n" + mes);
            }
        }

        /// <summary>
        /// Получение информации из БД для таблицы с чек листами
        /// </summary>
        public static List<CheckListShift> GetCheckList()
        {
            var shifts = new List<CheckListShift>();
            using (var conn = new SQLiteConnection(toconnect, true))
            {
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM shifts ORDER BY index_number";
                    try
                    {
                        conn.Open();
                        var r = cmd.ExecuteReader();

                        DateTime test = DateTime.Now.AddHours(0);

                        while (r.Read())
                        {
                            int shiftID = Convert.ToInt32(r["id"]);
                            int shiftIndexNubmer = Convert.ToInt32(r["index_number"]);
                            string shiftName = Convert.ToString(r["name"]);
                            string shiftTimeAfter = Convert.ToString(r["time_after"]);
                            string shiftTimeBefore = Convert.ToString(r["time_before"]);

                            DateTime lastBeginDate = new DateTime(test.Year, test.Month, test.Day, Int32.Parse(shiftTimeAfter.Substring(0, 2)), Int32.Parse(shiftTimeAfter.Substring(3, 2)), 0).AddDays(-1);
                            DateTime lastEndDate = new DateTime(test.Year, test.Month, test.Day, Int32.Parse(shiftTimeBefore.Substring(0, 2)), Int32.Parse(shiftTimeBefore.Substring(3, 2)), 0).AddDays(-1);
                            bool isLasts = false;

                            DateTime nextBeginDate = lastBeginDate.AddDays(1);
                            DateTime nextEndDate = lastEndDate.AddDays(1);

                            /* Если время начала смены больше конца смены, то
                             это значит, что смена заканчивается в следующем дне.*/
                            if (lastBeginDate > lastEndDate)
                            {
                                lastEndDate = lastEndDate.AddDays(1);
                            }

                            if (nextBeginDate < test)
                            {
                                lastBeginDate = lastBeginDate.AddDays(1);
                                lastEndDate = lastEndDate.AddDays(1);
                                nextBeginDate = nextBeginDate.AddDays(1);
                                nextEndDate = nextBeginDate.AddDays(1);
                            }

                            if (test > lastBeginDate && test < lastEndDate) isLasts = true;

                            var checkListItems = new List<IShiftItem>();

                            using (var _cmd = conn.CreateCommand())
                            {
                                _cmd.CommandText = @"SELECT shifts_items.*,
                                                    journal.record_time
                                                    FROM shifts_items 
                                                    LEFT JOIN journal ON journal.shift_item_id = shifts_items.id
                                                    WHERE journal.record_time = (
                                                            SELECT journal.record_time 
                                                            FROM journal 
                                                            WHERE journal.shift_item_id = shifts_items.id 
                                                            ORDER BY journal.record_time DESC LIMIT 1
                                                        )
                                                      AND shifts_items.shift_id = @shift_id
                                                    UNION ALL
													SELECT shifts_items.*,
                                                    journal.record_time
                                                    FROM shifts_items 
                                                    LEFT JOIN journal ON journal.shift_item_id = shifts_items.id
                                                    WHERE journal.record_time IS NULL
                                                      AND shifts_items.shift_id = @shift_id
                                                    ORDER BY shifts_items.index_number";
                                _cmd.Parameters.AddWithValue("@shift_id", shiftID);

                                var _r = _cmd.ExecuteReader();
                                while (_r.Read())
                                {
                                    if (_r["record_time"] != DBNull.Value)
                                    {
                                        DateTime recordTime = Convert.ToDateTime(_r["record_time"]);
                                        if (recordTime > lastBeginDate && recordTime < nextBeginDate) continue;
                                    }

                                    ShiftItem shiftItem = new ShiftItem(
                                        Convert.ToInt32(_r["id"]), Convert.ToInt32(_r["index_number"]),
                                        Convert.ToString(_r["name"]), Convert.ToString(_r["description"]),
                                        Convert.ToString(_r["time_after"]), Convert.ToString(_r["time_before"]),
                                        Convert.ToBoolean(_r["is_active"]), Convert.ToInt32(_r["shift_id"])
                                        );
                                    checkListItems.Add(new CheckListItem(shiftItem));
                                }
                            }
                            shifts.Add(new CheckListShift(shiftID, shiftIndexNubmer, shiftName, shiftTimeAfter, shiftTimeBefore, checkListItems, isLasts));
                        }
                    }
                    catch (Exception e)
                    {
                        System.Windows.Forms.MessageBox.Show(e.Message);
                    }
                }
            }
            return shifts;
        }

        /// <summary>
        /// Запись в журнал
        /// </summary>
        /// <param name="shiftItemID">ID для атрибута смены</param>
        /// <param name="shiftID">ID смены</param>
        /// <param name="authorName">Учётка отметившего</param>
        /// <param name="comment">Комментарий</param>
        /// <returns></returns>
        public static bool WriteInJournal(int shiftItemID, int shiftID, string authorName, string comment)
        {
            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(toconnect, true))
                {
                    conn.Open();
                    using (SQLiteCommand cmd = new SQLiteCommand(conn))
                    {
                        cmd.CommandText = @"INSERT INTO journal(shift_item_id, shift_id, author_name, record_time, comment)
                                            VALUES (@shift_item_id, @shift_id, @author_name, strftime('%Y-%m-%d %H:%M', datetime('now', 'localtime')), @comment)";
                        cmd.Parameters.AddWithValue("@shift_item_id", shiftItemID);
                        cmd.Parameters.AddWithValue("@shift_id", shiftID);
                        cmd.Parameters.AddWithValue("@author_name", authorName);
                        cmd.Parameters.AddWithValue("@comment", comment);
                        if (cmd.ExecuteNonQuery() == 1)
                            return true;
                        else
                            return false;
                    }
                }
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message);
                return false;
            }
        }

        /// <summary>
        /// Получение информации из БД для таблицы с сменами и работой
        /// </summary>
        /// <param name="state">Необходимые записи</param>
        /// <returns></returns>
        public static List<Shift> GetShifts(ShiftsItemsStates state)
        {
            List<Shift> shifts = new List<Shift>();
            using (var conn = new SQLiteConnection(toconnect, true))
            {
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM shifts ORDER BY index_number";
                    try
                    {
                        conn.Open();
                        var r = cmd.ExecuteReader();
                        while (r.Read())
                        {
                            shifts.Add(
                                new Shift(Convert.ToInt32(r["id"]), Convert.ToInt32(r["index_number"]),
                                Convert.ToString(r["name"]), Convert.ToString(r["time_after"]),
                                Convert.ToString(r["time_before"]),
                                new List<IShiftItem>(GetShiftItems(Convert.ToInt32(r["id"]), state)))
                                );
                        }
                    }
                    catch (Exception e)
                    {
                        System.Windows.Forms.MessageBox.Show(e.Message);
                    }
                }
            }
            return shifts;
        }

        /// <summary>
        /// Получение информации о работе смены
        /// </summary>
        /// <param name="id">ID смены в БД</param>
        /// <param name="state">Необходимые записи</param>
        /// <returns></returns>
        public static List<ShiftItem> GetShiftItems(int id, ShiftsItemsStates state)
        {
            List<ShiftItem> items = new List<ShiftItem>();
            using (var conn = new SQLiteConnection(toconnect, true))
            {
                var cmd = conn.CreateCommand();
                cmd.CommandText = $"SELECT * FROM shifts_items WHERE shift_id = @id AND is_active = @is_active ORDER BY index_number";
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@is_active", (int)state);
                try
                {
                    conn.Open();
                    var r = cmd.ExecuteReader();
                    while (r.Read())
                    {
                        items.Add(new ShiftItem(
                            Convert.ToInt32(r["id"]), Convert.ToInt32(r["index_number"]),
                            Convert.ToString(r["name"]), Convert.ToString(r["description"]),
                            Convert.ToString(r["time_after"]), Convert.ToString(r["time_before"]),
                            Convert.ToBoolean(r["is_active"]), Convert.ToInt32(r["shift_id"])
                            ));
                    }
                }
                catch (Exception e)
                {
                    System.Windows.Forms.MessageBox.Show(e.Message);
                }
            }
            return items;
        }

        /// <summary>
        /// Удаление элемента из таблицы
        /// </summary>
        /// <typeparam name="T">определяет удаляем смену или пункт из чек-листа</typeparam>
        /// <param name="item">предмет, который удаляем</param>
        /// <param name="collection">список, из которого удаляем</param>
        /// <returns></returns>
        public static bool RemoveItem<T>(T item, List<T> collection)
            where T : IBaseItem
        {
            try
            {
                string table;
                string itemType = item.GetType().Name;
                string collectionType = collection.GetType().GetGenericArguments().Single().Name;

                if (itemType == "Shift" && collectionType == "Shift")
                {
                    table = "shifts";
                }
                else if (itemType == "ShiftItem" && collectionType == "IShiftItem")
                {
                    table = "shifts_items";
                }
                else
                    return false;

                int queryCount = 0;
                int successQueryCount = 0;

                using (SQLiteConnection conn = new SQLiteConnection(toconnect, true))
                {
                    conn.Open();
                    using (SQLiteCommand cmd = new SQLiteCommand(conn))
                    using (var t = conn.BeginTransaction())
                    using (var builder = new SQLiteCommandBuilder())
                    {
                        try
                        {
                            string tableName = builder.QuoteIdentifier(table);

                            cmd.CommandText = $@"DELETE FROM {table} WHERE id = @id";
                            cmd.Parameters.AddWithValue("@id", item.ID);
                            successQueryCount += cmd.ExecuteNonQuery();
                            queryCount++;

                            int index = collection.IndexOf(item);
                            collection.Remove(item);
                            for (int i = index; i < collection.Count; i++)
                            {
                                collection[i].IndexNumber--;
                                cmd.CommandText = $@"UPDATE {table} SET index_number = @index_number WHERE id = @id";
                                cmd.Parameters.AddWithValue("@id", collection[i].ID);
                                cmd.Parameters.AddWithValue("@index_number", collection[i].IndexNumber);
                                successQueryCount += cmd.ExecuteNonQuery();
                                queryCount++;
                            }

                            if (queryCount == successQueryCount)
                            {
                                t.Commit();
                                return true;
                            }
                        }
                        catch (Exception ex)
                        {
                            t.Rollback();
                            System.Windows.Forms.MessageBox.Show(ex.Message);
                            return false;
                        }
                    }
                    return false;
                }
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message);
                return false;
            }
        }

        /// <summary>
        /// Меняет порядок у смен или списка дел у смены
        /// </summary>
        /// <param name="item1">первый элемент для замены</param>
        /// <param name="item2">второй элемент для замены</param>
        /// <returns></returns>
        public static bool SwapIndexNumbers(IBaseItem item1, IBaseItem item2)
        {
            try
            {
                string table;
                if (item1.GetType().Name == "Shift" && item2.GetType().Name == "Shift")
                    table = "shifts";
                else if (item1.GetType().Name == "ShiftItem" && item2.GetType().Name == "ShiftItem")
                    table = "shifts_items";
                else
                    return false;

                using (SQLiteConnection conn = new SQLiteConnection(toconnect, true))
                using (SQLiteCommand cmd = new SQLiteCommand(conn))
                {
                    conn.Open();
                    using (var t = conn.BeginTransaction())
                    using (var builder = new SQLiteCommandBuilder())
                    {
                        try
                        {
                            string tableName = builder.QuoteIdentifier(table);

                            cmd.CommandText = $@"UPDATE {tableName} SET index_number = @index_number2 WHERE id = @id1;
                                            UPDATE {tableName} SET index_number = @index_number1 WHERE id = @id2;";
                            cmd.Parameters.AddWithValue("@id1", item1.ID);
                            cmd.Parameters.AddWithValue("@index_number1", item1.IndexNumber);
                            cmd.Parameters.AddWithValue("@id2", item2.ID);
                            cmd.Parameters.AddWithValue("@index_number2", item2.IndexNumber);

                            int rowsAffected = cmd.ExecuteNonQuery();
                            if (rowsAffected == 2)
                            {
                                t.Commit();
                                return true;
                            }

                        }
                        catch (Exception ex)
                        {
                            t.Rollback();
                            System.Windows.Forms.MessageBox.Show(ex.Message);
                            return false;
                        }
                    }
                    return false;
                }

            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message);
                return false;
            }
        }

        public static bool AddShift(int indexNumber, string name, string timeAfter, string timeBefore)
        {
            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(toconnect, true))
                {
                    conn.Open();
                    using (SQLiteCommand cmd = new SQLiteCommand(conn))
                    {
                        cmd.CommandText = @"INSERT INTO shifts (index_number, name, time_after, time_before)
                                            VALUES (@index_number, @name, @time_after, @time_before)";
                        cmd.Parameters.AddWithValue("@index_number", indexNumber);
                        cmd.Parameters.AddWithValue("@name", name);
                        cmd.Parameters.AddWithValue("@time_after", timeAfter);
                        cmd.Parameters.AddWithValue("@time_before", timeBefore);
                        if (cmd.ExecuteNonQuery() == 1)
                            return true;
                        else
                            return false;
                    }
                }
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message);
                return false;
            }
        }

        public static bool UpdateShift(int id, string name, string timeAfter, string timeBefore)
        {
            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(toconnect, true))
                {
                    conn.Open();
                    using (SQLiteCommand cmd = new SQLiteCommand(conn))
                    {
                        cmd.CommandText = @"UPDATE shifts SET name = @name, time_after = @time_after, time_before = @time_before WHERE id = @id";
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.Parameters.AddWithValue("@name", name);
                        cmd.Parameters.AddWithValue("@time_after", timeAfter);
                        cmd.Parameters.AddWithValue("@time_before", timeBefore);
                        if (cmd.ExecuteNonQuery() == 1)
                            return true;
                        else
                            return false;
                    }
                }
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message);
                return false;
            }
        }

        public static bool AddShiftItem(int indexNumber, string name, string description,
            string timeAfter, string timeBefore, bool isActive, int shiftID)
        {
            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(toconnect, true))
                {
                    conn.Open();
                    using (SQLiteCommand cmd = new SQLiteCommand(conn))
                    {
                        cmd.CommandText = @"INSERT INTO shifts_items (index_number, name, description, time_after, time_before, is_active, shift_id)
                                            VALUES (@index_number, @name, @description, @time_after, @time_before, @is_active, @shift_id)";
                        cmd.Parameters.AddWithValue("@index_number", indexNumber);
                        cmd.Parameters.AddWithValue("@name", name);
                        cmd.Parameters.AddWithValue("@description", description);
                        cmd.Parameters.AddWithValue("@time_after", timeAfter);
                        cmd.Parameters.AddWithValue("@time_before", timeBefore);
                        cmd.Parameters.AddWithValue("@is_active", isActive);
                        cmd.Parameters.AddWithValue("@shift_id", shiftID);
                        if (cmd.ExecuteNonQuery() == 1)
                            return true;
                        else
                            return false;
                    }
                }
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message);
                return false;
            }
        }

        public static bool UpdateShiftItem(int id, string name, string description,
            string timeAfter, string timeBefore, bool isActive)
        {
            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(toconnect, true))
                {
                    conn.Open();
                    using (SQLiteCommand cmd = new SQLiteCommand(conn))
                    {
                        cmd.CommandText = @"UPDATE shifts_items 
                                            SET name = @name, 
                                            description = @description, 
                                            time_after = @timeAfter, 
                                            time_before = @timeBefore, 
                                            is_active = @isActive 
                                            WHERE id = @id";
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.Parameters.AddWithValue("@name", name);
                        cmd.Parameters.AddWithValue("@description", description);
                        cmd.Parameters.AddWithValue("@timeAfter", timeAfter);
                        cmd.Parameters.AddWithValue("@timeBefore", timeBefore);
                        cmd.Parameters.AddWithValue("@isActive", isActive);
                        if (cmd.ExecuteNonQuery() == 1)
                            return true;
                        else
                            return false;
                    }
                }
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message);
                return false;
            }
        }

        public static Dictionary<string, string> GetSettings()
        {
            var result = new Dictionary<string, string>();

            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(toconnect, true))
                {
                    conn.Open();
                    using (SQLiteCommand cmd = new SQLiteCommand(conn))
                    {
                        cmd.CommandText = @"select * from settings";

                        var dr = cmd.ExecuteReader();

                        while (dr.Read())
                        {
                            result.Add(Convert.ToString(dr["setting_name"]),
                                Convert.ToString(dr["setting_value"]));
                        }
                    }
                }
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message);
            }
            return result;
        }

        public static bool UpdateSettings(Dictionary<string, string> settings)
        {
            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(toconnect, true))
                {
                    conn.Open();
                    using (var t = conn.BeginTransaction())
                    using (SQLiteCommand cmd = new SQLiteCommand(conn))
                    {
                        int rowsAffected = 0;
                        int totalRows = 0;

                        foreach (var setting in settings)
                        {
                            cmd.Parameters.Clear();
                            cmd.CommandText = @"update settings 
                                            set setting_value = @setting_value
                                            where setting_name = @setting_name";
                            cmd.Parameters.AddWithValue("@setting_name", setting.Key);
                            cmd.Parameters.AddWithValue("@setting_value", setting.Value);
                            rowsAffected += cmd.ExecuteNonQuery();
                            totalRows++;
                        }

                        if (rowsAffected == totalRows)
                        {
                            t.Commit();
                            return true;
                        }
                        else
                        {
                            t.Rollback();
                            throw new Exception();
                        }
                    }
                }
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message);
            }
            return false;
        }

        public static List<JournalSettingsShift> GetJournalSettingsShifts()
        {
            {
                List<JournalSettingsShift> shifts = new List<JournalSettingsShift>();
                using (var conn = new SQLiteConnection(toconnect, true))
                {
                    var cmd = conn.CreateCommand();
                    cmd.CommandText = $@"SELECT id, index_number, name FROM shifts";

                    try
                    {
                        conn.Open();
                        var r = cmd.ExecuteReader();
                        while (r.Read())
                        {
                            shifts.Add(new JournalSettingsShift(Convert.ToInt32(r["id"]), 
                                Convert.ToInt32(r["index_number"]), Convert.ToString(r["name"])));
                        }
                    }
                    catch (Exception e)
                    {
                        System.Windows.Forms.MessageBox.Show(e.Message);
                    }
                }
                return shifts;
            }
        }

        public static List<JournalItem> GetJournal(int shiftID, string authorName, string startDate, string stopDate)
        {
            List<JournalItem> journal = new List<JournalItem>();
            using (var conn = new SQLiteConnection(toconnect, true))
            {
                var cmd = conn.CreateCommand();
                cmd.CommandText = $@"SELECT 
                                    journal.id,
                                    journal.record_time,
                                    shifts_items.name as shift_name, 
                                    shifts_items.description as shift_description, 
                                    journal.comment,
                                    shifts_items.time_after as shift_time_after, 
                                    shifts_items.time_before as shift_time_before, 
                                    journal.author_name
                                    FROM journal 
                                    INNER JOIN shifts_items 
                                    ON journal.shift_item_id = shifts_items.id
                                    WHERE journal.shift_id = @shift_id
                                    AND journal.author_name LIKE '%' || @author_name || '%'
                                    AND journal.record_time BETWEEN @start_date || ' 00:00' AND @stop_date || ' 23:59'
                                    ORDER BY journal.record_time DESC;";
                cmd.Parameters.AddWithValue("@shift_id", shiftID);
                cmd.Parameters.AddWithValue("@author_name", authorName);
                cmd.Parameters.AddWithValue("@start_date", startDate);
                cmd.Parameters.AddWithValue("@stop_date", stopDate);

                try
                {
                    conn.Open();
                    var r = cmd.ExecuteReader();

                    while (r.Read())
                    {
                        //journal.Add(new JournalItem(
                        //    Convert.ToInt32(r["id"]), Convert.ToString(r["record_time"]),
                        //    Convert.ToString(r["shift_name"]), Convert.ToString(r["shift_description"]),
                        //    Convert.ToString(r["comment"]), Convert.ToString(r["shift_time_after"]),
                        //    Convert.ToString(r["shift_time_before"]), Convert.ToString(r["author_name"])
                        //    ));
                        journal.Add(new JournalItem(
                            Convert.ToInt32(r["id"]), Convert.ToString(r["record_time"]),
                            Convert.ToString(r["shift_name"]), Convert.ToString(r["shift_description"]),
                            Convert.ToString(r["comment"]), Convert.ToString(r["shift_time_after"]),
                            Convert.ToString(r["shift_time_before"]), Convert.ToString(r["author_name"])
                            ));
                    }
                }
                catch (Exception e)
                {
                    System.Windows.Forms.MessageBox.Show(e.Message);
                }
            }

            return journal;
        }

        public static string GetSetting(string settingName)
        {
            string result = string.Empty;

            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(toconnect, true))
                {
                    conn.Open();
                    using (SQLiteCommand cmd = new SQLiteCommand(conn))
                    {
                        cmd.CommandText = @"select setting_value from settings
                                            where setting_name = @setting_name";
                        cmd.Parameters.AddWithValue("@setting_name", settingName);
                        var dr = cmd.ExecuteReader();

                        while (dr.Read())
                        {
                            result = Convert.ToString(dr["setting_value"]);
                        }
                    }
                }
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message);
            }
            return result;
        }

        public static List<OracleItem> GetSQLQueries()
        {
            List<OracleItem> queries = new List<OracleItem>();
            try
            {

                using (var conn = new SQLiteConnection(toconnect, true))
                {
                    conn.Open();
                    SQLiteCommand cmd = new SQLiteCommand(conn)
                    {
                        CommandText = @"SELECT ID, 
                                    author_name, 
                                    db_name,  
                                    user_name,
                                    sql_query_text 
                                    FROM sql_queries"
                    };

                    var r = cmd.ExecuteReader();

                    while (r.Read())
                    {
                        queries.Add(new OracleItem(Convert.ToInt32(r["ID"]), Convert.ToString(r["author_name"]),
                            Convert.ToString(r["db_name"]), Convert.ToString(r["user_name"]), Convert.ToString(r["sql_query_text"])));
                    }

                    conn.Close();
                }

            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Ошибка: " + ex.Message + "\n" + ex.StackTrace);
            }
            return queries;
        }

        public static OracleItem GetLastQuery()
        {
            OracleItem temp = null;
            try
            {
                using (var conn = new SQLiteConnection(toconnect, true))
                {
                    conn.Open();
                    SQLiteCommand cmd = new SQLiteCommand(conn)
                    {
                        CommandText = @"SELECT ID, 
                                        author_name, 
                                        db_name,  
                                        user_name,
                                        sql_query_text 
                                        FROM sql_queries
                                        ORDER BY sql_queries.ID DESC"
                    };

                    var r = cmd.ExecuteReader();

                    if (r.Read())
                    {
                        temp = new OracleItem(Convert.ToInt32(r["ID"]), Convert.ToString(r["author_name"]),
                            Convert.ToString(r["db_name"]), Convert.ToString(r["user_name"]), Convert.ToString(r["sql_query_text"]));
                    }

                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            return temp;
        }

        public static bool WriteInQueries(string query, string dbname, string usname, string authorName)
        {
            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(toconnect, true))
                {
                    conn.Open();
                    using (SQLiteCommand cmd = new SQLiteCommand(conn))
                    {
                        cmd.CommandText = @"INSERT INTO sql_queries(author_name, db_name, user_name, sql_query_text)
                                            VALUES (@author_name, @db_name, @user_name, @sql_query_text)";
                        cmd.Parameters.AddWithValue("@author_name", authorName);
                        cmd.Parameters.AddWithValue("@db_name", dbname);
                        cmd.Parameters.AddWithValue("@user_name", usname);
                        cmd.Parameters.AddWithValue("@sql_query_text", query);
                        if (cmd.ExecuteNonQuery() == 1)
                            return true;
                        else
                            return false;
                    }
                }
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message);
                return false;
            }
        }
    }
}
