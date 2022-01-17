using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CheckLists
{
    static class Program
    {
        static public bool local = false;
        static public string usname = Environment.UserName;
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());
            if (new Authentific().ShowDialog() != DialogResult.Yes)
            {
                MessageBox.Show("До свидания", "Выход");
                return;
            }
            //MessageBox.Show("Добро пожаловать", "Вход выполнен");
            //LoadPathDB();
            SQL.SQLite.Checks(local);
            Application.Run(new MainWindow());
            //Application.Run(new ManageShifts());
            //Application.Run(new AddEditShiftWindow());
            //new AddEditShiftWindow().ShowDialog();
            //new AddEditShiftItemWindow().ShowDialog();
            //Application.Run(new SettingsWindow());
            //Application.Run(new JournalWindow());
            //new StatementsWindow().ShowDialog();
            //new SQLQuery().ShowDialog();
        }
    }
}
