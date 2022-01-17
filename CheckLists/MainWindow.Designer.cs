namespace CheckLists
{
    partial class MainWindow
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.управлениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сменыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.настройкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.журналToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.Statements = new System.Windows.Forms.ToolStripButton();
            this.LoadToIsida = new System.Windows.Forms.ToolStripButton();
            this.AccentJournal = new System.Windows.Forms.ToolStripButton();
            this.OsedResponse = new System.Windows.Forms.ToolStripButton();
            this.SQLQuery = new System.Windows.Forms.ToolStripButton();
            this.Run = new System.Windows.Forms.ImageList(this.components);
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.listShifts = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ShiftItemsTable = new System.Windows.Forms.DataGridView();
            this.Index = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ShiftItName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Comments = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimeAfter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimeBefore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RegisterShift = new System.Windows.Forms.DataGridViewButtonColumn();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.StripUsname = new System.Windows.Forms.ToolStripStatusLabel();
            this.checkListItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ShiftItemsTable)).BeginInit();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkListItemBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.управлениеToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(882, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // управлениеToolStripMenuItem
            // 
            this.управлениеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сменыToolStripMenuItem,
            this.настройкиToolStripMenuItem,
            this.журналToolStripMenuItem});
            this.управлениеToolStripMenuItem.Name = "управлениеToolStripMenuItem";
            this.управлениеToolStripMenuItem.Size = new System.Drawing.Size(108, 24);
            this.управлениеToolStripMenuItem.Text = "Управление";
            // 
            // сменыToolStripMenuItem
            // 
            this.сменыToolStripMenuItem.Name = "сменыToolStripMenuItem";
            this.сменыToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.сменыToolStripMenuItem.Text = "Смены";
            this.сменыToolStripMenuItem.Click += new System.EventHandler(this.СменыToolStripMenuItem_Click);
            // 
            // настройкиToolStripMenuItem
            // 
            this.настройкиToolStripMenuItem.Name = "настройкиToolStripMenuItem";
            this.настройкиToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.настройкиToolStripMenuItem.Text = "Настройки";
            this.настройкиToolStripMenuItem.Click += new System.EventHandler(this.НастройкиToolStripMenuItem_Click);
            // 
            // журналToolStripMenuItem
            // 
            this.журналToolStripMenuItem.Name = "журналToolStripMenuItem";
            this.журналToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.журналToolStripMenuItem.Text = "Журнал";
            this.журналToolStripMenuItem.Click += new System.EventHandler(this.ЖурналToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Statements,
            this.LoadToIsida,
            this.AccentJournal,
            this.OsedResponse,
            this.SQLQuery});
            this.toolStrip1.Location = new System.Drawing.Point(0, 28);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(882, 27);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "панель элементов";
            // 
            // Statements
            // 
            this.Statements.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Statements.Image = ((System.Drawing.Image)(resources.GetObject("Statements.Image")));
            this.Statements.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Statements.Name = "Statements";
            this.Statements.Size = new System.Drawing.Size(29, 24);
            this.Statements.Text = "Выписки";
            this.Statements.ToolTipText = "Выписки";
            this.Statements.Click += new System.EventHandler(this.Statements_Click);
            // 
            // LoadToIsida
            // 
            this.LoadToIsida.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.LoadToIsida.Image = ((System.Drawing.Image)(resources.GetObject("LoadToIsida.Image")));
            this.LoadToIsida.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.LoadToIsida.Name = "LoadToIsida";
            this.LoadToIsida.Size = new System.Drawing.Size(29, 24);
            this.LoadToIsida.Text = "Загрузка документов в исиду";
            this.LoadToIsida.Click += new System.EventHandler(this.LoadToIsida_Click);
            // 
            // AccentJournal
            // 
            this.AccentJournal.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.AccentJournal.Image = ((System.Drawing.Image)(resources.GetObject("AccentJournal.Image")));
            this.AccentJournal.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AccentJournal.Name = "AccentJournal";
            this.AccentJournal.Size = new System.Drawing.Size(29, 24);
            this.AccentJournal.Text = "Журнал сервера акцента";
            this.AccentJournal.Click += new System.EventHandler(this.AccentJournal_Click);
            // 
            // OsedResponse
            // 
            this.OsedResponse.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.OsedResponse.Image = ((System.Drawing.Image)(resources.GetObject("OsedResponse.Image")));
            this.OsedResponse.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.OsedResponse.Name = "OsedResponse";
            this.OsedResponse.Size = new System.Drawing.Size(29, 24);
            this.OsedResponse.Text = "Проверка ответов по ОСЭД";
            this.OsedResponse.Click += new System.EventHandler(this.OsedResponse_Click);
            // 
            // SQLQuery
            // 
            this.SQLQuery.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.SQLQuery.Image = ((System.Drawing.Image)(resources.GetObject("SQLQuery.Image")));
            this.SQLQuery.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SQLQuery.Name = "SQLQuery";
            this.SQLQuery.Size = new System.Drawing.Size(29, 24);
            this.SQLQuery.Text = "Запрос на SQL";
            this.SQLQuery.Click += new System.EventHandler(this.SQLQuery_Click);
            // 
            // Run
            // 
            this.Run.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("Run.ImageStream")));
            this.Run.TransparentColor = System.Drawing.Color.Transparent;
            this.Run.Images.SetKeyName(0, "run.png");
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer2.IsSplitterFixed = true;
            this.splitContainer2.Location = new System.Drawing.Point(0, 55);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.splitContainer1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.statusStrip1);
            this.splitContainer2.Size = new System.Drawing.Size(882, 398);
            this.splitContainer2.SplitterDistance = 365;
            this.splitContainer2.TabIndex = 4;
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(3, 3, 3, 24);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.listShifts);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.ShiftItemsTable);
            this.splitContainer1.Size = new System.Drawing.Size(882, 365);
            this.splitContainer1.SplitterDistance = 122;
            this.splitContainer1.TabIndex = 3;
            // 
            // listShifts
            // 
            this.listShifts.AutoArrange = false;
            this.listShifts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.listShifts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listShifts.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.listShifts.HideSelection = false;
            this.listShifts.LargeImageList = this.Run;
            this.listShifts.Location = new System.Drawing.Point(0, 0);
            this.listShifts.MultiSelect = false;
            this.listShifts.Name = "listShifts";
            this.listShifts.Size = new System.Drawing.Size(122, 365);
            this.listShifts.TabIndex = 0;
            this.listShifts.UseCompatibleStateImageBehavior = false;
            this.listShifts.SelectedIndexChanged += new System.EventHandler(this.ListShifts_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Смена";
            this.columnHeader1.Width = 188;
            // 
            // ShiftItemsTable
            // 
            this.ShiftItemsTable.AllowUserToAddRows = false;
            this.ShiftItemsTable.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.ShiftItemsTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.ShiftItemsTable.BackgroundColor = System.Drawing.Color.White;
            this.ShiftItemsTable.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ShiftItemsTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.ShiftItemsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ShiftItemsTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Index,
            this.ShiftItName,
            this.Description,
            this.Comments,
            this.TimeAfter,
            this.TimeBefore,
            this.RegisterShift});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ShiftItemsTable.DefaultCellStyle = dataGridViewCellStyle3;
            this.ShiftItemsTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ShiftItemsTable.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.ShiftItemsTable.GridColor = System.Drawing.Color.Black;
            this.ShiftItemsTable.Location = new System.Drawing.Point(0, 0);
            this.ShiftItemsTable.Name = "ShiftItemsTable";
            this.ShiftItemsTable.RowHeadersVisible = false;
            this.ShiftItemsTable.RowHeadersWidth = 51;
            this.ShiftItemsTable.RowTemplate.Height = 24;
            this.ShiftItemsTable.Size = new System.Drawing.Size(756, 365);
            this.ShiftItemsTable.TabIndex = 0;
            this.ShiftItemsTable.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.ShiftItemsTable_CellMouseClick);
            this.ShiftItemsTable.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.ShiftItemsTable_CellMouseDoubleClick);
            // 
            // Index
            // 
            this.Index.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Index.HeaderText = "№";
            this.Index.MinimumWidth = 6;
            this.Index.Name = "Index";
            this.Index.Width = 51;
            // 
            // ShiftItName
            // 
            this.ShiftItName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ShiftItName.HeaderText = "Название";
            this.ShiftItName.MinimumWidth = 6;
            this.ShiftItName.Name = "ShiftItName";
            // 
            // Description
            // 
            this.Description.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Description.HeaderText = "Описание";
            this.Description.MinimumWidth = 6;
            this.Description.Name = "Description";
            // 
            // Comments
            // 
            this.Comments.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Comments.HeaderText = "Комментарии";
            this.Comments.MinimumWidth = 6;
            this.Comments.Name = "Comments";
            this.Comments.Width = 127;
            // 
            // TimeAfter
            // 
            this.TimeAfter.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.TimeAfter.HeaderText = "Время после";
            this.TimeAfter.MinimumWidth = 6;
            this.TimeAfter.Name = "TimeAfter";
            this.TimeAfter.Width = 122;
            // 
            // TimeBefore
            // 
            this.TimeBefore.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.TimeBefore.HeaderText = "Время до";
            this.TimeBefore.MinimumWidth = 6;
            this.TimeBefore.Name = "TimeBefore";
            this.TimeBefore.Width = 99;
            // 
            // RegisterShift
            // 
            this.RegisterShift.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.RegisterShift.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.RegisterShift.HeaderText = "";
            this.RegisterShift.MinimumWidth = 80;
            this.RegisterShift.Name = "RegisterShift";
            this.RegisterShift.Text = "Отметить";
            this.RegisterShift.UseColumnTextForButtonValue = true;
            this.RegisterShift.Width = 80;
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StripUsname});
            this.statusStrip1.Location = new System.Drawing.Point(0, 3);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.statusStrip1.Size = new System.Drawing.Size(882, 26);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // StripUsname
            // 
            this.StripUsname.Name = "StripUsname";
            this.StripUsname.Size = new System.Drawing.Size(82, 20);
            this.StripUsname.Text = "User Name";
            // 
            // checkListItemBindingSource
            // 
            this.checkListItemBindingSource.DataSource = typeof(CheckLists.Clasess.CheckListItem);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 453);
            this.Controls.Add(this.splitContainer2);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(800, 304);
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Чеклисты";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindow_FormClosing);
            this.Shown += new System.EventHandler(this.MainWindow_Shown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ShiftItemsTable)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkListItemBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem управлениеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сменыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem настройкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem журналToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton Statements;
        private System.Windows.Forms.ToolStripButton LoadToIsida;
        private System.Windows.Forms.ToolStripButton AccentJournal;
        private System.Windows.Forms.ToolStripButton OsedResponse;
        private System.Windows.Forms.ToolStripButton SQLQuery;
        private System.Windows.Forms.ImageList Run;
        private System.Windows.Forms.BindingSource checkListItemBindingSource;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ListView listShifts;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.DataGridView ShiftItemsTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn Index;
        private System.Windows.Forms.DataGridViewTextBoxColumn ShiftItName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Comments;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimeAfter;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimeBefore;
        private System.Windows.Forms.DataGridViewButtonColumn RegisterShift;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel StripUsname;
    }
}