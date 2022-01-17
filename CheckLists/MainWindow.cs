using CheckLists.Clasess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices.AccountManagement;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.IO;

namespace CheckLists
{
    /// <summary>
    /// Главное окно программы
    /// </summary>
    public partial class MainWindow : Form
    {
        System.Windows.Forms.Timer timer;
        public List<CheckListShift> shifts;
        Thread qq;
        int curind = 0;

        #region Работа с формой

        public MainWindow()
        {
            InitializeComponent();
            //listShifts.Items.Add(new ListViewItem().Text = "Смена 7:30-17:30");
            //listShifts.Items[0].ImageIndex = 0;
            //listShifts.Items[0].Selected = true;
            //MessageBox.Show(listShifts.SelectedIndices[0].ToString());
            StripUsname.Text = Program.usname + " | " + GetFullname(Program.usname);
        }

        private void MainWindow_Shown(object sender, EventArgs e)
        {
            timer = new System.Windows.Forms.Timer
            {
                Enabled = true,
                Interval = 30000
            };
            timer.Tick += new EventHandler(Timer_Tick);

            UpdateCheckLists();
        }

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            timer.Stop();
            if (qq.IsAlive)
            {
                Visible = false;
                Thread.Sleep(10000);
                qq.Abort();
                qq.Join(500);
            }
        }

        private void ShiftItemsTable_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (ShiftItemsTable.CurrentRow == null)
            {
                return;
            }
            if (e.ColumnIndex == 6)//Если нажатие произошло в столбце с кнопками. У нас индекс стобца 2, у тебя может быть другой.
            {
                int num = ShiftItemsTable.CurrentRow.Index;
                string comment;
                if (ShiftItemsTable.Rows[num].Cells[3].Value == null)
                {
                    comment = "";
                }
                else
                    comment = ShiftItemsTable.Rows[num].Cells[3].Value.ToString();
                int shiftitid = shifts[curind].ShiftItems[num].ID;
                if (SQL.SQLite.WriteInJournal(shiftitid, shifts[curind].ID, Program.usname, comment))
                {
                    shifts[curind].ShiftItems.RemoveAt(num);
                    ShiftItemsTable.Rows.Clear();
                    listShifts.Items.Clear();
                    if (shifts.Count > 0)
                    {
                        if (shifts.Count < curind)
                        {
                            curind = 0;
                        }
                        //DateTime temp = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
                        foreach (var item in shifts)
                        {
                            listShifts.Items.Add(new ListViewItem(item.Name));
                            if (item.IsLasts)
                            {
                                listShifts.Items[listShifts.Items.Count - 1].ImageIndex = 0;
                            }
                            //temp.Hour = int.Parse(item.TimeAfter.Split(':')[0]);
                            //ShiftItemsTable.Rows.Add(item.ID, item.Name, item.ShiftItems.Count, item.TimeAfter, item.TimeBefore);
                            /*ShiftItemsTable.RowCount++;
                            ShiftItemsTable.Rows[ShiftItemsTable.RowCount - 1].Cells[0].Value = "1";
                            ShiftItemsTable.Rows[ShiftItemsTable.RowCount - 1].Cells[1].Value = "dfsh";
                            ShiftItemsTable.Rows[ShiftItemsTable.RowCount - 1].Cells[2].Value = "dklj;s";
                            ShiftItemsTable.Rows[ShiftItemsTable.RowCount - 1].Cells[3].Value = "adsjk";
                            ShiftItemsTable.Rows[ShiftItemsTable.RowCount - 1].Cells[4].Value = "iosadj;";
                            ShiftItemsTable.Rows[ShiftItemsTable.RowCount - 1].Cells[5].Value = "sajdlk";*/
                        }
                        foreach (var item in shifts[curind].ShiftItems)
                        {
                            if (item.IsActive)
                            {
                                ShiftItemsTable.Rows.Add(item.IndexNumber, item.Name, item.Description, (item as CheckListItem).Comment, item.TimeAfter, item.TimeBefore);
                            }
                        }
                    }
                    UpdateCheckLists();
                }
                else
                    MessageBox.Show("Во время записи в журнал возникла ошибка");
                //UpdateCheckLists();
            }
        }

        private void ShiftItemsTable_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            ShiftItemsTable_CellMouseClick(sender, e);
        }

        private void СменыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer.Stop();
            new ManageShifts().ShowDialog();
            UpdateCheckLists();
            timer.Start();
        }

        private void ListShifts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listShifts.SelectedIndices.Count > 0)
            {
                curind = listShifts.SelectedIndices[0];
                ShiftItemsTable.Rows.Clear();
                //Thread.Sleep(200);
                foreach (var item in shifts[curind].ShiftItems)
                {
                    if (item.IsActive)
                    {
                        ShiftItemsTable.Rows.Add(item.IndexNumber, item.Name, item.Description, (item as CheckListItem).Comment, item.TimeAfter, item.TimeBefore);
                    }
                }
            }
        }

        private void НастройкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new SettingsWindow().ShowDialog();
        }

        private void ЖурналToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new JournalWindow().ShowDialog();
        }

        private void Statements_Click(object sender, EventArgs e)
        {
            new StatementsWindow().ShowDialog();
        }

        private void LoadToIsida_Click(object sender, EventArgs e)
        {
            new IsidaMessageWindow().ShowDialog();
        }

        private void AccentJournal_Click(object sender, EventArgs e)
        {
            new AccentJournalWindow().ShowDialog();
        }

        private void OsedResponse_Click(object sender, EventArgs e)
        {
            Task t = Task.Run(() =>
            {
                try
                {
                    string dir = SQL.SQLite.GetSetting("OsedResponseFolder");

                    if (Directory.Exists(dir))
                    {
                        var file = new DirectoryInfo(dir).GetFiles().Where(f => f.Name.StartsWith("SU")).OrderByDescending(f => f.LastWriteTime).Last();
                        string secondLine = File.ReadLines(file.FullName).Skip(1).First();
                        if (secondLine.Equals("0"))
                        {
                            MessageBox.Show($"Имя последнего файла ответа по ОСЭД: {file.Name}\nФайл без ошибок", "Ответ по ОСЭД");
                        }
                        else
                        {
                            MessageBox.Show($"Имя последнего файла ответа по ОСЭД: {file.Name}\nФайл с ошибками", "Ответ по ОСЭД");
                        }
                    }
                    else
                    {
                        MessageBox.Show("В настройках неверно указан путь к папке.");
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.InnerException+"\n"+ex.Message + "\n" + ex.StackTrace);
                }
            });
            TimeSpan ts = TimeSpan.FromMilliseconds(10000);
            if (!t.Wait(ts))
                MessageBox.Show("Время ожидания превысило 10 секунд.");
        }

        private void SQLQuery_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("В разработке!!!");
            new SQLQuery().ShowDialog();
        }

        #endregion

        #region Дополнительные методы для работы с формой

        private void UpdateCheckLists()
        {
            //отправить в отдельный поток
            qq = new Thread(new ThreadStart(Potok));
            //qq.Priority = ThreadPriority.Highest;
            qq.Start();
        }

        private void Potok()
        {
            try
            {
                //ShiftItemsTable.Invoke(new Action(() =>
                //{
                //    ShiftItemsTable.RowsDefaultCellStyle.BackColor = ShiftItemsTable.AlternatingRowsDefaultCellStyle.BackColor = Color.Gray;
                //}));
                shifts = SQL.SQLite.GetCheckList();
                ShiftItemsTable.Invoke(new Action(() =>
                {
                    //ShiftItemsTable.RowsDefaultCellStyle.BackColor = ShiftItemsTable.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
                    ShiftItemsTable.Rows.Clear();
                    listShifts.Items.Clear();
                    if (shifts.Count > 0)
                    {
                        if (shifts.Count < curind)
                        {
                            curind = 0;
                        }
                        //DateTime temp = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
                        foreach (var item in shifts)
                        {
                            listShifts.Items.Add(new ListViewItem(item.Name));
                            if (item.IsLasts)
                            {
                                listShifts.Items[listShifts.Items.Count - 1].ImageIndex = 0;
                            }
                            //temp.Hour = int.Parse(item.TimeAfter.Split(':')[0]);
                            //ShiftItemsTable.Rows.Add(item.ID, item.Name, item.ShiftItems.Count, item.TimeAfter, item.TimeBefore);
                            /*ShiftItemsTable.RowCount++;
                            ShiftItemsTable.Rows[ShiftItemsTable.RowCount - 1].Cells[0].Value = "1";
                            ShiftItemsTable.Rows[ShiftItemsTable.RowCount - 1].Cells[1].Value = "dfsh";
                            ShiftItemsTable.Rows[ShiftItemsTable.RowCount - 1].Cells[2].Value = "dklj;s";
                            ShiftItemsTable.Rows[ShiftItemsTable.RowCount - 1].Cells[3].Value = "adsjk";
                            ShiftItemsTable.Rows[ShiftItemsTable.RowCount - 1].Cells[4].Value = "iosadj;";
                            ShiftItemsTable.Rows[ShiftItemsTable.RowCount - 1].Cells[5].Value = "sajdlk";*/
                        }
                        foreach (var item in shifts[curind].ShiftItems)
                        {
                            if (item.IsActive)
                            {
                                ShiftItemsTable.Rows.Add(item.IndexNumber, item.Name, item.Description, (item as CheckListItem).Comment, item.TimeAfter, item.TimeBefore);
                            }
                        }
                    }
                }));
                return;
            }
            catch (System.Threading.ThreadAbortException)
            {
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Что-то пошло не так.\nВот сообщение об ошибке:\n" + ex.Message);
                return;
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            UpdateCheckLists();
        }

        public static string GetFullname(string username)
        {
            System.Threading.Thread.GetDomain().SetPrincipalPolicy(PrincipalPolicy.WindowsPrincipal);
            //WindowsPrincipal principal = (WindowsPrincipal)System.Threading.Thread.CurrentPrincipal;
            if (Program.local)
                using (var pc = new PrincipalContext(ContextType.Machine))
                {
                    UserPrincipal up = UserPrincipal.FindByIdentity(pc, username);
                    return up.DisplayName;
                }
            else
                using (var pc = new PrincipalContext(ContextType.Domain))
                {
                    UserPrincipal up = UserPrincipal.FindByIdentity(pc, username);
                    return up.DisplayName;
                }
        }

        #endregion
    }
}
