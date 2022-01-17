using CheckLists.Clasess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CheckLists
{
    public partial class SQLQuery : Form
    {
        List<OracleItem> queries;
        public SQLQuery()
        {
            InitializeComponent();

            OracleItem temp = SQL.SQLite.GetLastQuery();
            if (temp != null)
            {
                tbNameDB.Text = temp.DB_Name;
                tbUserName.Text = temp.User_Name;
                SQLCommand.Text = temp.SQL_Query_Text;
            }
        }

        private void BtExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtExecute_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("In progress");

            string text = RepCont(SQLCommand.Text);
            try
            {
                List<List<string>> rez = SQL.Oracle.OracleQuery(text, tbNameDB.Text, tbUserName.Text, tbPassword.Text);
                try
                {
                    if (rez == null)
                    {
                        SQL.SQLite.WriteInQueries(SQLCommand.Text, tbNameDB.Text, tbUserName.Text, Program.usname);
                        return;
                    }
                    else
                        SQL.SQLite.WriteInQueries(SQLCommand.Text, tbNameDB.Text, tbUserName.Text, Program.usname);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при записи в БД SQLite\n" + ex.Message + "\n" + ex.StackTrace);
                }
                try
                {
                    dgvOutput.Visible = true;
                    dgvOutput.CellDoubleClick -= DgvOutput_CellDoubleClick;
                    dgvOutput.SelectionMode = DataGridViewSelectionMode.CellSelect;
                    btExecute.Visible = false;
                    btImport.Visible = false;
                    btLoad.Visible = false;
                    for (int i = 0; i < rez[0].Count; i++)
                    {
                        dgvOutput.Columns.Add("col" + rez[0][i], rez[0][i]);
                    }
                    for (int i = 1; i < rez.Count; i++)
                    {
                        dgvOutput.RowCount++;
                        for (int j = 0; j < rez[i].Count; j++)
                        {
                            dgvOutput[j, i - 1].Value = rez[i][j];
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при выводе таблицы\n" + ex.Message + "\n" + ex.StackTrace);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при выполнении запроса. Запрос отменён\n" + ex.Message + "\n" + ex.StackTrace);
                return;
            }
            //List<List<string>> rez = new List<List<string>>();
            //rez.Add(new List<string>());
            //for (int i = 0; i < 5; i++)
            //{
            //    rez[0].Add("check" + i);
            //}
            //for (int i = 1; i < 100; i++)
            //{
            //    rez.Add(new List<string>());
            //    for (int j = 0; j < 5; j++)
            //    {
            //        rez[i].Add("check" + i + "|" + j);
            //    }
            //}
        }

        string RepCont(string text)
        {
            string newtext = "";
            for (int i = 0; i < text.Length; i++)
            {
                if (char.IsControl(text[i]))
                {
                    newtext += ' ';
                }
                else
                    newtext += text[i];
            }

            return newtext;
        }

        private void BtLoad_Click(object sender, EventArgs e)
        {
            try
            {
                queries = SQL.SQLite.GetSQLQueries();

                dgvOutput.Visible = true;
                dgvOutput.Columns.Add("AuthorName", "Автор");
                dgvOutput.Columns.Add("DBName", "Название БД");
                dgvOutput.Columns.Add("UserName", "Имя пользователя");
                dgvOutput.Columns.Add("SQLQueryText", "Текст запроса");
                if (queries.Count > 0)
                {
                    foreach (var item in queries)
                    {
                        dgvOutput.Rows.Add(item.Author_Name, item.DB_Name, item.User_Name, item.SQL_Query_Text);
                    }
                }
                else
                    dgvOutput.Rows.Clear();
                btnCancel.Visible = true;
                btExecute.Visible = btImport.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message + "\n" + ex.StackTrace);
            }
        }

        private void BtImport_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("In progress");

            using (var dialog = new OpenFileDialog())
            {
                dialog.Filter = "SQL-files|*.sql|All files|*.*";
                dialog.Multiselect = false;
                DialogResult result = dialog.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(dialog.FileName))
                {
                    StreamReader read = new StreamReader(dialog.FileName, Encoding.GetEncoding(1251));
                    SQLCommand.Text = read.ReadToEnd();
                }
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            dgvOutput.Visible = false;
            dgvOutput.Rows.Clear();
            dgvOutput.Columns.Clear();
            queries.Clear();

            btnCancel.Visible = false;
            btExecute.Visible = btImport.Visible = true;
        }

        private void DgvOutput_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (queries.Count > 0)
            {
                int num = dgvOutput.CurrentRow.Index;
                tbNameDB.Text = queries[num].DB_Name;
                tbUserName.Text = queries[num].User_Name;
                SQLCommand.Text = queries[num].SQL_Query_Text;
            }

            BtnCancel_Click(new object(), new EventArgs());
        }
    }
}
