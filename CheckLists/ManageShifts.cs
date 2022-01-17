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

namespace CheckLists
{
    public partial class ManageShifts : Form
    {
        List<Clasess.Shift> shifts;
        int curind = 0, curite = 0;
        public ManageShifts()
        {
            InitializeComponent();

            UpdateShifts();
        }

        private void UpdateShifts()
        {
            Cursor = Cursors.WaitCursor;
            shifts = SQL.SQLite.GetShifts(Clasess.ShiftsItemsStates.All);
            int ite = curite;
            ShiftsTable.Rows.Clear();
            if (shifts.Count > 0)
            {
                if (shifts.Count <= curind)
                {
                    curind = 0;
                }
                int ind = curind;
                if (shifts[curind].ShiftItems.Count > 0)
                {
                    if (shifts[ind].ShiftItems.Count < ite)
                    {
                        ite = 0;
                    }
                }
                else
                    ite = -1;
                foreach (var item in shifts)
                {
                    ShiftsTable.Rows.Add(item.IndexNumber, item.Name, item.TimeAfter, item.TimeBefore);
                }

                //foreach (var item in shifts[curind].ShiftItems)
                //{
                //    ShiftItemsTable.Rows.Add(item.IndexNumber, item.Name, item.Description, item.TimeAfter, item.TimeBefore, item.IsActive);
                //}

                ShiftsTable.CurrentCell = ShiftsTable.Rows[ind].Cells[0];
                ShiftsTable_SelectionChanged(new object(), new EventArgs());

                if (ite != -1)
                {
                    if (ite >= ShiftItemsTable.Rows.Count)
                    {
                        ite = 0;
                    }
                    ShiftItemsTable.CurrentCell = ShiftItemsTable.Rows[ite].Cells[0];
                    ShiftItemsTable_SelectionChanged(new object(), new EventArgs());
                }

                //ShiftUp.Enabled = true;
                //ShiftDown.Enabled = true;
                //if (curind == 0)
                //{
                //    ShiftUp.Enabled = false;
                //}
                //else if (curind == (shifts.Count - 1))
                //{
                //    ShiftDown.Enabled = false;
                //}
                Cursor = Cursors.Default;
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ShiftsTable_SelectionChanged(object sender, EventArgs e)
        {
            if (ShiftsTable.CurrentRow == null)
            {
                return;
            }
            if (ShiftsTable.CurrentRow.Index + 1 > shifts.Count)
            {
                curind = shifts.Count;
                return;
            }
            curind = ShiftsTable.CurrentRow.Index;
            ShiftItemsTable.Rows.Clear();
            //Thread.Sleep(200);
            foreach (var item in shifts[curind].ShiftItems)
            {
                ShiftItemsTable.Rows.Add(item.IndexNumber, item.Name, item.Description, item.TimeAfter, item.TimeBefore, item.IsActive);
            }

            ShiftUp.Enabled = true;
            ShiftDown.Enabled = true;
            if (curind == 0)
            {
                ShiftUp.Enabled = false;
            }
            if (curind == (shifts.Count - 1))
            {
                ShiftDown.Enabled = false;
            }

            //if (curite == -1)
            //{
            //    return;
            //}

            //ShiftItemsTable.CurrentCell = ShiftItemsTable.Rows[curite].Cells[0];
            //ShiftItemsTable_SelectionChanged(new object(), new EventArgs());
        }

        private void ShiftItemsTable_SelectionChanged(object sender, EventArgs e)
        {
            if (ShiftItemsTable.CurrentRow == null)
            {
                curite = -1;
                return;
            }
            else if (ShiftItemsTable.CurrentRow.Index + 1 > shifts[curind].ShiftItems.Count)
            {
                curite = shifts[curind].ShiftItems.Count;
                return;
            }
            else
                curite = ShiftItemsTable.CurrentRow.Index;
            MoveUpShiftItem.Enabled = true;
            MoveDownShiftItem.Enabled = true;
            if (ShiftItemsTable.CurrentRow.Index == 0)
            {
                MoveUpShiftItem.Enabled = false;
            }
            if (ShiftItemsTable.CurrentRow.Index == (shifts[curind].ShiftItems.Count - 1))
            {
                MoveDownShiftItem.Enabled = false;
            }
        }

        #region Изменение таблицы смен

        private void AddShift_Click(object sender, EventArgs e)
        {
            //ShiftsTable.CurrentCell = ShiftsTable.Rows[2].Cells[0];
            //ShiftsTable.Rows[2].Selected = true;
            //ShiftsTable_SelectionChanged(sender, e);
            //////////string[] t = null;

            //////////MessageBox.Show(t?[0] ?? "test");

            var newadd = new AddEditShiftWindow();
            if (newadd.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }

            if (SQL.SQLite.AddShift(shifts.Count + 1, newadd.shiftname.Text, newadd.houraftercb.Text + ':' + newadd.minaftercb.Text,
                newadd.hourbeforecb.Text + ':' + newadd.minbeforecb.Text))
            {
                UpdateShifts();
            }
            else
                ErrorMessage();
        }

        private void RemoveShift_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите удалить данную запись?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            if (SQL.SQLite.RemoveItem(shifts[curind], shifts))
            {
                UpdateShifts();
            }
            else
                ErrorMessage();
        }

        private void EditShift_Click(object sender, EventArgs e)
        {
            var upadd = new AddEditShiftWindow();
            upadd.shiftname.Text = shifts[curind].Name;
            upadd.houraftercb.SelectedIndex/*.Text*/= int.Parse(shifts[curind].TimeAfter.Substring(0, 2));
            upadd.minaftercb.SelectedIndex= int.Parse(shifts[curind].TimeAfter.Substring(3, 2));
            upadd.hourbeforecb.SelectedIndex = int.Parse(shifts[curind].TimeBefore.Substring(0, 2));
            upadd.minbeforecb.SelectedIndex = int.Parse(shifts[curind].TimeBefore.Substring(3, 2));
            if (upadd.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }

            if (SQL.SQLite.UpdateShift(shifts[curind].ID, upadd.shiftname.Text, upadd.houraftercb.Text + ':' + upadd.minaftercb.Text,
                upadd.hourbeforecb.Text + ':' + upadd.minbeforecb.Text))
            {
                UpdateShifts();
            }
            else
                ErrorMessage();
        }

        private void ShiftUp_Click(object sender, EventArgs e)
        {
            if (SQL.SQLite.SwapIndexNumbers(shifts[curind - 1], shifts[curind]))
            {
                ShiftsTable.CurrentCell = ShiftsTable.Rows[curind - 1].Cells[0];
                ShiftsTable_SelectionChanged(sender, e);
                UpdateShifts();
            }
            else
                ErrorMessage();
        }

        private void ShiftDown_Click(object sender, EventArgs e)
        {
            if (SQL.SQLite.SwapIndexNumbers(shifts[curind + 1], shifts[curind]))
            {
                ShiftsTable.CurrentCell = ShiftsTable.Rows[curind + 1].Cells[0];
                ShiftsTable_SelectionChanged(sender, e);
                UpdateShifts();
            }
            else
                ErrorMessage();
        }

        #endregion

        #region Изменение таблицы списка дел смены

        private void AddShiftItem_Click(object sender, EventArgs e)
        {
            var newadd = new AddEditShiftItemWindow();
            if (newadd.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            if (SQL.SQLite.AddShiftItem(shifts[curind].ShiftItems.Count + 1, newadd.shiftitemnametb.Text, newadd.shiftitemdescriptiontb.Text,
                newadd.houraftercb.Text + ':' + newadd.minaftercb.Text, newadd.hourbeforecb.Text + ':' + newadd.minbeforecb.Text,
                newadd.isactivecb.Checked, shifts[curind].ID))
            {
                UpdateShifts();
            }
            else
                ErrorMessage();
        }

        private void RemoveShiftItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите удалить данную запись?", "Подтверждение", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            if (SQL.SQLite.RemoveItem(shifts[curind].ShiftItems[curite], shifts[curind].ShiftItems))
            {
                UpdateShifts();
            }
            else
                ErrorMessage();
        }

        private void EditShiftItem_Click(object sender, EventArgs e)
        {
            var upadd = new AddEditShiftItemWindow();
            upadd.shiftitemnametb.Text = ShiftItemsTable.CurrentRow.Cells[1].Value.ToString();
            upadd.shiftitemdescriptiontb.Text = ShiftItemsTable.CurrentRow.Cells[2].Value.ToString();
            upadd.houraftercb.SelectedIndex = int.Parse(ShiftItemsTable.CurrentRow.Cells[3].Value.ToString().Substring(0, 2));
            upadd.minaftercb.SelectedIndex = int.Parse(ShiftItemsTable.CurrentRow.Cells[3].Value.ToString().Substring(3, 2));
            upadd.hourbeforecb.SelectedIndex = int.Parse(ShiftItemsTable.CurrentRow.Cells[4].Value.ToString().Substring(0, 2));
            upadd.minbeforecb.SelectedIndex = int.Parse(ShiftItemsTable.CurrentRow.Cells[4].Value.ToString().Substring(3, 2));
            upadd.isactivecb.Checked = bool.Parse(ShiftItemsTable.CurrentRow.Cells[5].Value.ToString());
            if (upadd.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            if (SQL.SQLite.UpdateShiftItem(shifts[curind].ShiftItems[curite].ID, upadd.shiftitemnametb.Text, 
                upadd.shiftitemdescriptiontb.Text, upadd.houraftercb.Text + ':' + upadd.minaftercb.Text, 
                upadd.hourbeforecb.Text + ':' + upadd.minbeforecb.Text, upadd.isactivecb.Checked))
            {
                UpdateShifts();
            }
            else
                ErrorMessage();
        }

        private void MoveUpShiftItem_Click(object sender, EventArgs e)
        {
            if (SQL.SQLite.SwapIndexNumbers(shifts[curind].ShiftItems[curite - 1], shifts[curind].ShiftItems[curite]))
            {
                ShiftItemsTable.CurrentCell = ShiftItemsTable.Rows[curite - 1].Cells[0];
                ShiftItemsTable_SelectionChanged(sender, e);
                UpdateShifts();
            }
            else
                ErrorMessage();
        }

        private void MoveDownShiftItem_Click(object sender, EventArgs e)
        {
            if (SQL.SQLite.SwapIndexNumbers(shifts[curind].ShiftItems[curite + 1], shifts[curind].ShiftItems[curite]))
            {
                ShiftItemsTable.CurrentCell = ShiftItemsTable.Rows[curite + 1].Cells[0];
                ShiftItemsTable_SelectionChanged(sender, e);
                UpdateShifts();
            }
            else
                ErrorMessage();
        }

        #endregion

        private void ErrorMessage()
        {
            MessageBox.Show("При внесении изменений возникла ошибка.");
        }
    }
}
