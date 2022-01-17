using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace CheckLists
{
    public partial class JournalWindow : Form
    {
        List<JournalSettingsShift> journalSettingsShifts;
        List<JournalItem> journals;

        public JournalWindow()
        {
            InitializeComponent();

            dateafterdtp.Value = DateTime.Now;
            datebeforedtp.Value = DateTime.Now;

            journalSettingsShifts = new List<JournalSettingsShift>(
            SQL.SQLite.GetJournalSettingsShifts());

            if (journalSettingsShifts.Count > 0)
            {
                foreach (var item in journalSettingsShifts)
                {
                    JournalSettingscb.Items.Add(item.Name);
                }
                JournalSettingscb.SelectedIndex = 0;
                UpdateJournal();
            }
        }

        public void UpdateJournal()
        {
            if (journalSettingsShifts != null && journalSettingsShifts.Count > 0)
            {
                //journals = new List<JournalItem>(SQL.SQLite.GetJournal(journalSettingsShifts[JournalSettingscb.SelectedIndex].ID,
                //    AuthorUsernametb.Text, dateafterdtp.Value.ToString("yyyy-mm-dd"), datebeforedtp.Value.ToString("yyyy-mm-dd")));
                string d1, d2, m1, m2;
                if (dateafterdtp.Value.Month < 10)
                {
                    m1 = "0" + dateafterdtp.Value.Month;
                }
                else
                    m1 = "" + dateafterdtp.Value.Month;

                if (datebeforedtp.Value.Month < 10)
                {
                    m2 = "0" + datebeforedtp.Value.Month;
                }
                else
                    m2 = "" + datebeforedtp.Value.Month;

                if (dateafterdtp.Value.Day < 10)
                {
                    d1 = "0" + dateafterdtp.Value.Day;
                }
                else
                    d1 = "" + dateafterdtp.Value.Day;

                if (datebeforedtp.Value.Day < 10)
                {
                    d2 = "0" + datebeforedtp.Value.Day;
                }
                else
                    d2 = "" + datebeforedtp.Value.Day;

                journals = new List<JournalItem>(SQL.SQLite.GetJournal
                    (journalSettingsShifts[JournalSettingscb.SelectedIndex].ID, AuthorUsernametb.Text,
                    dateafterdtp.Value.Year + "-" + m1 + "-" + d1,
                    datebeforedtp.Value.Year + "-" + m2 + "-" + d2));

                JournalTable.Rows.Clear();
                foreach (var item in journals)
                {
                    JournalTable.Rows.Add(item.RecordTime, item.ShiftName, 
                        item.ShiftDescription, item.Comment, item.ShiftTimeAfter, item.ShiftTimeBefore, item.AuthorName);
                }
            }
        }

        private void Applybt_Click(object sender, EventArgs e)
        {
            UpdateJournal();
        }

        private void Closebt_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void WriteInExcelbt_Click(object sender, EventArgs e)
        {
            var excelApp = new Excel.Application();
            excelApp.Visible = true;

            excelApp.Workbooks.Add();
            Excel._Worksheet workSheet = (Excel.Worksheet)excelApp.ActiveSheet;

            workSheet.Cells[1, 1] = "Время";
            workSheet.Cells[1, 2] = "Имя смены";
            workSheet.Cells[1, 3] = "Описание смены";
            workSheet.Cells[1, 4] = "Комментарий";
            workSheet.Cells[1, 5] = "Время после";
            workSheet.Cells[1, 6] = "Время до";
            workSheet.Cells[1, 7] = "Автор";

            var row = 1;
            foreach (var item in journals)
            {
                row++;
                workSheet.Cells[row, 1] = item.RecordTime;
                workSheet.Cells[row, 2] = item.ShiftName;
                workSheet.Cells[row, 3] = item.ShiftDescription;
                workSheet.Cells[row, 4] = item.Comment;
                workSheet.Cells[row, 5] = item.ShiftTimeAfter;
                workSheet.Cells[row, 6] = item.ShiftTimeBefore;
                workSheet.Cells[row, 7] = item.AuthorName;
            }

            for (int i = 1; i <= 7; i++)
            {
                workSheet.Columns[i].AutoFit();
            }
        }
    }
}
