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
    public partial class StatementsWindow : Form
    {
        public StatementsWindow()
        {
            InitializeComponent();

            //MessageBox.Show("Не тестировалось!!");

            StartDatedtp.Value = SQL.Oracle.GetLastWorkingDay();
            StopDatedtp.Value = SQL.Oracle.GetNextWorkingDay();
            UpdateStatementsCount();
        }

        private void Closebut_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Refreshbut_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Не тестировалось!!");

            UpdateStatementsCount();
        }

        private void UpdateStatementsCount()
        {
            CountStatements.Text = SQL.Oracle.GetStatementsCount(StartDatedtp.Value, StopDatedtp.Value).ToString();
            //if (StartDatedtp.Value <= new DateTime(2019, 12, 20))
            //{
            //    if (StopDatedtp.Value >= new DateTime(2019, 12, 20))
            //    {
            //        CountStatements.Text = "40341";
            //    }
            //    else
            //        CountStatements.Text = "";
            //}
            //else
            //    CountStatements.Text = "";
        }
    }
}
