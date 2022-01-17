using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckLists
{
    public partial class AccentJournalWindow : Form
    {
        public AccentJournalWindow()
        {
            InitializeComponent();

            //MessageBox.Show("Не тестировалось!!!");

            SelectedDatedtp.Value = DateTime.Now;
            IsOnlyUploadcb.Checked = true;
            UpdateData();
        }

        private void UpdateDatabut_Click(object sender, EventArgs e)
        {
            UpdateData();
        }

        private void UpdateData()
        {
            List<Clasess.AccentJournalItem> temp = SQL.Oracle.GetAccentJournal(SelectedDatedtp.Value, IsOnlyUploadcb.Checked, tbPartMess.Text);

            JournalTable.Rows.Clear();
            foreach (var item in temp)
            {
                JournalTable.Rows.Add(item.RecordTime, item.Message);
            }
        }

        private void Closebut_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
