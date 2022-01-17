namespace CheckLists
{
    partial class ManageShifts
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageShifts));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.ShiftsTable = new System.Windows.Forms.DataGridView();
            this.ShiftNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ShiftName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ShiftTimeAfter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ShiftTimeBefore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddShift = new System.Windows.Forms.Button();
            this.RemoveShift = new System.Windows.Forms.Button();
            this.EditShift = new System.Windows.Forms.Button();
            this.ShiftUp = new System.Windows.Forms.Button();
            this.ShiftDown = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.splitContainer4 = new System.Windows.Forms.SplitContainer();
            this.ShiftItemsTable = new System.Windows.Forms.DataGridView();
            this.Index = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ShiftItName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimeAfter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimeBefore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RegisterShift = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.AddShiftItem = new System.Windows.Forms.Button();
            this.RemoveShiftItem = new System.Windows.Forms.Button();
            this.EditShiftItem = new System.Windows.Forms.Button();
            this.MoveUpShiftItem = new System.Windows.Forms.Button();
            this.MoveDownShiftItem = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ShiftsTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).BeginInit();
            this.splitContainer4.Panel1.SuspendLayout();
            this.splitContainer4.Panel2.SuspendLayout();
            this.splitContainer4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ShiftItemsTable)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.Color.White;
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.White;
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.White;
            this.splitContainer1.Panel2.Controls.Add(this.button1);
            this.splitContainer1.Panel2MinSize = 33;
            this.splitContainer1.Size = new System.Drawing.Size(992, 468);
            this.splitContainer1.SplitterDistance = 434;
            this.splitContainer1.SplitterWidth = 1;
            this.splitContainer1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.BackColor = System.Drawing.Color.White;
            this.splitContainer2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.IsSplitterFixed = true;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.BackColor = System.Drawing.Color.White;
            this.splitContainer2.Panel1.Controls.Add(this.splitContainer3);
            this.splitContainer2.Panel1.Controls.Add(this.label2);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.BackColor = System.Drawing.Color.White;
            this.splitContainer2.Panel2.Controls.Add(this.splitContainer4);
            this.splitContainer2.Panel2.Controls.Add(this.label1);
            this.splitContainer2.Size = new System.Drawing.Size(992, 434);
            this.splitContainer2.SplitterDistance = 270;
            this.splitContainer2.SplitterWidth = 1;
            this.splitContainer2.TabIndex = 0;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.IsSplitterFixed = true;
            this.splitContainer3.Location = new System.Drawing.Point(0, 18);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.ShiftsTable);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.AddShift);
            this.splitContainer3.Panel2.Controls.Add(this.RemoveShift);
            this.splitContainer3.Panel2.Controls.Add(this.EditShift);
            this.splitContainer3.Panel2.Controls.Add(this.ShiftUp);
            this.splitContainer3.Panel2.Controls.Add(this.ShiftDown);
            this.splitContainer3.Size = new System.Drawing.Size(268, 414);
            this.splitContainer3.SplitterDistance = 358;
            this.splitContainer3.SplitterWidth = 1;
            this.splitContainer3.TabIndex = 3;
            // 
            // ShiftsTable
            // 
            this.ShiftsTable.AllowUserToAddRows = false;
            this.ShiftsTable.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.ShiftsTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.ShiftsTable.BackgroundColor = System.Drawing.Color.LightGray;
            this.ShiftsTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ShiftsTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.ShiftsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ShiftsTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ShiftNumber,
            this.ShiftName,
            this.ShiftTimeAfter,
            this.ShiftTimeBefore});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ShiftsTable.DefaultCellStyle = dataGridViewCellStyle3;
            this.ShiftsTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ShiftsTable.GridColor = System.Drawing.Color.Black;
            this.ShiftsTable.Location = new System.Drawing.Point(0, 0);
            this.ShiftsTable.MultiSelect = false;
            this.ShiftsTable.Name = "ShiftsTable";
            this.ShiftsTable.ReadOnly = true;
            this.ShiftsTable.RowHeadersVisible = false;
            this.ShiftsTable.RowHeadersWidth = 51;
            this.ShiftsTable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.ShiftsTable.RowTemplate.Height = 24;
            this.ShiftsTable.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ShiftsTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ShiftsTable.Size = new System.Drawing.Size(268, 358);
            this.ShiftsTable.TabIndex = 1;
            this.ShiftsTable.SelectionChanged += new System.EventHandler(this.ShiftsTable_SelectionChanged);
            // 
            // ShiftNumber
            // 
            this.ShiftNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ShiftNumber.HeaderText = "№";
            this.ShiftNumber.MinimumWidth = 6;
            this.ShiftNumber.Name = "ShiftNumber";
            this.ShiftNumber.ReadOnly = true;
            this.ShiftNumber.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ShiftNumber.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ShiftNumber.Width = 30;
            // 
            // ShiftName
            // 
            this.ShiftName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ShiftName.HeaderText = "Название";
            this.ShiftName.MinimumWidth = 50;
            this.ShiftName.Name = "ShiftName";
            this.ShiftName.ReadOnly = true;
            this.ShiftName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ShiftName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ShiftTimeAfter
            // 
            this.ShiftTimeAfter.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ShiftTimeAfter.HeaderText = "Начало";
            this.ShiftTimeAfter.MinimumWidth = 6;
            this.ShiftTimeAfter.Name = "ShiftTimeAfter";
            this.ShiftTimeAfter.ReadOnly = true;
            this.ShiftTimeAfter.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ShiftTimeAfter.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ShiftTimeAfter.Width = 60;
            // 
            // ShiftTimeBefore
            // 
            this.ShiftTimeBefore.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ShiftTimeBefore.HeaderText = "Конец";
            this.ShiftTimeBefore.MinimumWidth = 6;
            this.ShiftTimeBefore.Name = "ShiftTimeBefore";
            this.ShiftTimeBefore.ReadOnly = true;
            this.ShiftTimeBefore.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ShiftTimeBefore.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ShiftTimeBefore.Width = 60;
            // 
            // AddShift
            // 
            this.AddShift.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AddShift.BackgroundImage")));
            this.AddShift.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.AddShift.Location = new System.Drawing.Point(38, 7);
            this.AddShift.Margin = new System.Windows.Forms.Padding(5);
            this.AddShift.Name = "AddShift";
            this.AddShift.Size = new System.Drawing.Size(26, 26);
            this.AddShift.TabIndex = 4;
            this.AddShift.UseVisualStyleBackColor = true;
            this.AddShift.Click += new System.EventHandler(this.AddShift_Click);
            // 
            // RemoveShift
            // 
            this.RemoveShift.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("RemoveShift.BackgroundImage")));
            this.RemoveShift.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.RemoveShift.Location = new System.Drawing.Point(74, 7);
            this.RemoveShift.Margin = new System.Windows.Forms.Padding(5);
            this.RemoveShift.Name = "RemoveShift";
            this.RemoveShift.Size = new System.Drawing.Size(26, 26);
            this.RemoveShift.TabIndex = 3;
            this.RemoveShift.UseVisualStyleBackColor = true;
            this.RemoveShift.Click += new System.EventHandler(this.RemoveShift_Click);
            // 
            // EditShift
            // 
            this.EditShift.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("EditShift.BackgroundImage")));
            this.EditShift.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.EditShift.Location = new System.Drawing.Point(110, 7);
            this.EditShift.Margin = new System.Windows.Forms.Padding(5);
            this.EditShift.Name = "EditShift";
            this.EditShift.Size = new System.Drawing.Size(26, 26);
            this.EditShift.TabIndex = 2;
            this.EditShift.UseVisualStyleBackColor = true;
            this.EditShift.Click += new System.EventHandler(this.EditShift_Click);
            // 
            // ShiftUp
            // 
            this.ShiftUp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ShiftUp.BackgroundImage")));
            this.ShiftUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ShiftUp.Location = new System.Drawing.Point(146, 7);
            this.ShiftUp.Margin = new System.Windows.Forms.Padding(5);
            this.ShiftUp.Name = "ShiftUp";
            this.ShiftUp.Size = new System.Drawing.Size(26, 26);
            this.ShiftUp.TabIndex = 1;
            this.ShiftUp.UseVisualStyleBackColor = true;
            this.ShiftUp.Click += new System.EventHandler(this.ShiftUp_Click);
            // 
            // ShiftDown
            // 
            this.ShiftDown.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ShiftDown.BackgroundImage")));
            this.ShiftDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ShiftDown.Location = new System.Drawing.Point(182, 7);
            this.ShiftDown.Margin = new System.Windows.Forms.Padding(5);
            this.ShiftDown.Name = "ShiftDown";
            this.ShiftDown.Size = new System.Drawing.Size(26, 26);
            this.ShiftDown.TabIndex = 0;
            this.ShiftDown.UseVisualStyleBackColor = true;
            this.ShiftDown.Click += new System.EventHandler(this.ShiftDown_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Смены:";
            // 
            // splitContainer4
            // 
            this.splitContainer4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer4.IsSplitterFixed = true;
            this.splitContainer4.Location = new System.Drawing.Point(0, 18);
            this.splitContainer4.Name = "splitContainer4";
            this.splitContainer4.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer4.Panel1
            // 
            this.splitContainer4.Panel1.Controls.Add(this.ShiftItemsTable);
            // 
            // splitContainer4.Panel2
            // 
            this.splitContainer4.Panel2.Controls.Add(this.AddShiftItem);
            this.splitContainer4.Panel2.Controls.Add(this.RemoveShiftItem);
            this.splitContainer4.Panel2.Controls.Add(this.EditShiftItem);
            this.splitContainer4.Panel2.Controls.Add(this.MoveUpShiftItem);
            this.splitContainer4.Panel2.Controls.Add(this.MoveDownShiftItem);
            this.splitContainer4.Size = new System.Drawing.Size(719, 414);
            this.splitContainer4.SplitterDistance = 358;
            this.splitContainer4.SplitterWidth = 1;
            this.splitContainer4.TabIndex = 2;
            // 
            // ShiftItemsTable
            // 
            this.ShiftItemsTable.AllowUserToAddRows = false;
            this.ShiftItemsTable.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.ShiftItemsTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.ShiftItemsTable.BackgroundColor = System.Drawing.Color.LightGray;
            this.ShiftItemsTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ShiftItemsTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.ShiftItemsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ShiftItemsTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Index,
            this.ShiftItName,
            this.Description,
            this.TimeAfter,
            this.TimeBefore,
            this.RegisterShift});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ShiftItemsTable.DefaultCellStyle = dataGridViewCellStyle6;
            this.ShiftItemsTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ShiftItemsTable.GridColor = System.Drawing.Color.Black;
            this.ShiftItemsTable.Location = new System.Drawing.Point(0, 0);
            this.ShiftItemsTable.MultiSelect = false;
            this.ShiftItemsTable.Name = "ShiftItemsTable";
            this.ShiftItemsTable.ReadOnly = true;
            this.ShiftItemsTable.RowHeadersVisible = false;
            this.ShiftItemsTable.RowHeadersWidth = 51;
            this.ShiftItemsTable.RowTemplate.Height = 24;
            this.ShiftItemsTable.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ShiftItemsTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ShiftItemsTable.Size = new System.Drawing.Size(719, 358);
            this.ShiftItemsTable.TabIndex = 1;
            this.ShiftItemsTable.SelectionChanged += new System.EventHandler(this.ShiftItemsTable_SelectionChanged);
            // 
            // Index
            // 
            this.Index.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Index.HeaderText = "№";
            this.Index.MinimumWidth = 6;
            this.Index.Name = "Index";
            this.Index.ReadOnly = true;
            this.Index.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Index.Width = 30;
            // 
            // ShiftItName
            // 
            this.ShiftItName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ShiftItName.HeaderText = "Название";
            this.ShiftItName.MinimumWidth = 50;
            this.ShiftItName.Name = "ShiftItName";
            this.ShiftItName.ReadOnly = true;
            this.ShiftItName.Width = 136;
            // 
            // Description
            // 
            this.Description.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Description.HeaderText = "Описание";
            this.Description.MinimumWidth = 50;
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            this.Description.Width = 185;
            // 
            // TimeAfter
            // 
            this.TimeAfter.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.TimeAfter.HeaderText = "Время после";
            this.TimeAfter.MinimumWidth = 6;
            this.TimeAfter.Name = "TimeAfter";
            this.TimeAfter.ReadOnly = true;
            this.TimeAfter.Width = 137;
            // 
            // TimeBefore
            // 
            this.TimeBefore.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.TimeBefore.HeaderText = "Время до";
            this.TimeBefore.MinimumWidth = 6;
            this.TimeBefore.Name = "TimeBefore";
            this.TimeBefore.ReadOnly = true;
            this.TimeBefore.Width = 139;
            // 
            // RegisterShift
            // 
            this.RegisterShift.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.RegisterShift.FalseValue = "false";
            this.RegisterShift.HeaderText = "Активный";
            this.RegisterShift.IndeterminateValue = "null";
            this.RegisterShift.MinimumWidth = 80;
            this.RegisterShift.Name = "RegisterShift";
            this.RegisterShift.ReadOnly = true;
            this.RegisterShift.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.RegisterShift.TrueValue = "true";
            this.RegisterShift.Width = 90;
            // 
            // AddShiftItem
            // 
            this.AddShiftItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AddShiftItem.BackgroundImage")));
            this.AddShiftItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.AddShiftItem.Location = new System.Drawing.Point(534, 7);
            this.AddShiftItem.Margin = new System.Windows.Forms.Padding(5);
            this.AddShiftItem.Name = "AddShiftItem";
            this.AddShiftItem.Size = new System.Drawing.Size(26, 26);
            this.AddShiftItem.TabIndex = 4;
            this.AddShiftItem.UseVisualStyleBackColor = true;
            this.AddShiftItem.Click += new System.EventHandler(this.AddShiftItem_Click);
            // 
            // RemoveShiftItem
            // 
            this.RemoveShiftItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("RemoveShiftItem.BackgroundImage")));
            this.RemoveShiftItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.RemoveShiftItem.Location = new System.Drawing.Point(570, 7);
            this.RemoveShiftItem.Margin = new System.Windows.Forms.Padding(5);
            this.RemoveShiftItem.Name = "RemoveShiftItem";
            this.RemoveShiftItem.Size = new System.Drawing.Size(26, 26);
            this.RemoveShiftItem.TabIndex = 3;
            this.RemoveShiftItem.UseVisualStyleBackColor = true;
            this.RemoveShiftItem.Click += new System.EventHandler(this.RemoveShiftItem_Click);
            // 
            // EditShiftItem
            // 
            this.EditShiftItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("EditShiftItem.BackgroundImage")));
            this.EditShiftItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.EditShiftItem.Location = new System.Drawing.Point(606, 7);
            this.EditShiftItem.Margin = new System.Windows.Forms.Padding(5);
            this.EditShiftItem.Name = "EditShiftItem";
            this.EditShiftItem.Size = new System.Drawing.Size(26, 26);
            this.EditShiftItem.TabIndex = 2;
            this.EditShiftItem.UseVisualStyleBackColor = true;
            this.EditShiftItem.Click += new System.EventHandler(this.EditShiftItem_Click);
            // 
            // MoveUpShiftItem
            // 
            this.MoveUpShiftItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("MoveUpShiftItem.BackgroundImage")));
            this.MoveUpShiftItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.MoveUpShiftItem.Location = new System.Drawing.Point(642, 7);
            this.MoveUpShiftItem.Margin = new System.Windows.Forms.Padding(5);
            this.MoveUpShiftItem.Name = "MoveUpShiftItem";
            this.MoveUpShiftItem.Size = new System.Drawing.Size(26, 26);
            this.MoveUpShiftItem.TabIndex = 1;
            this.MoveUpShiftItem.UseVisualStyleBackColor = true;
            this.MoveUpShiftItem.Click += new System.EventHandler(this.MoveUpShiftItem_Click);
            // 
            // MoveDownShiftItem
            // 
            this.MoveDownShiftItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("MoveDownShiftItem.BackgroundImage")));
            this.MoveDownShiftItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.MoveDownShiftItem.Location = new System.Drawing.Point(678, 7);
            this.MoveDownShiftItem.Margin = new System.Windows.Forms.Padding(5);
            this.MoveDownShiftItem.Name = "MoveDownShiftItem";
            this.MoveDownShiftItem.Size = new System.Drawing.Size(26, 26);
            this.MoveDownShiftItem.TabIndex = 0;
            this.MoveDownShiftItem.UseVisualStyleBackColor = true;
            this.MoveDownShiftItem.Click += new System.EventHandler(this.MoveDownShiftItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Пункты:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(887, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 29);
            this.button1.TabIndex = 0;
            this.button1.Text = "Закрыть";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // ManageShifts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(992, 468);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(600, 300);
            this.Name = "ManageShifts";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Чеклисты";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ShiftsTable)).EndInit();
            this.splitContainer4.Panel1.ResumeLayout(false);
            this.splitContainer4.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).EndInit();
            this.splitContainer4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ShiftItemsTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.SplitContainer splitContainer4;
        private System.Windows.Forms.DataGridView ShiftItemsTable;
        private System.Windows.Forms.Button EditShiftItem;
        private System.Windows.Forms.Button MoveUpShiftItem;
        private System.Windows.Forms.Button MoveDownShiftItem;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.DataGridView ShiftsTable;
        private System.Windows.Forms.Button AddShift;
        private System.Windows.Forms.Button RemoveShift;
        private System.Windows.Forms.Button EditShift;
        private System.Windows.Forms.Button ShiftUp;
        private System.Windows.Forms.Button ShiftDown;
        private System.Windows.Forms.Button AddShiftItem;
        private System.Windows.Forms.Button RemoveShiftItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Index;
        private System.Windows.Forms.DataGridViewTextBoxColumn ShiftItName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimeAfter;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimeBefore;
        private System.Windows.Forms.DataGridViewCheckBoxColumn RegisterShift;
        private System.Windows.Forms.DataGridViewTextBoxColumn ShiftNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn ShiftName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ShiftTimeAfter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ShiftTimeBefore;
    }
}