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
    public partial class AddEditShiftWindow : Form
    {
        public AddEditShiftWindow()
        {
            InitializeComponent();
            houraftercb.SelectedIndex = 0;
            hourbeforecb.SelectedIndex = 0;
            minaftercb.SelectedIndex = 0;
            minbeforecb.SelectedIndex = 0;
        }

        private void Shiftname_TextChanged(object sender, EventArgs e)
        {
            if (shiftname.Text.Equals(""))
            {
                ok.Enabled = false;
            }
            else
                ok.Enabled = true;
        }
    }
}
