namespace CheckLists
{
    partial class AccentJournalWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccentJournalWindow));
            this.SelectedDatedtp = new System.Windows.Forms.DateTimePicker();
            this.IsOnlyUploadcb = new System.Windows.Forms.CheckBox();
            this.UpdateDatabut = new System.Windows.Forms.Button();
            this.JournalTable = new System.Windows.Forms.DataGridView();
            this.RecordTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Message = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Closebut = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.label1 = new System.Windows.Forms.Label();
            this.tbPartMess = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.JournalTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // SelectedDatedtp
            // 
            this.SelectedDatedtp.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.SelectedDatedtp.Location = new System.Drawing.Point(12, 12);
            this.SelectedDatedtp.Name = "SelectedDatedtp";
            this.SelectedDatedtp.Size = new System.Drawing.Size(110, 22);
            this.SelectedDatedtp.TabIndex = 0;
            this.SelectedDatedtp.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // IsOnlyUploadcb
            // 
            this.IsOnlyUploadcb.AutoSize = true;
            this.IsOnlyUploadcb.Location = new System.Drawing.Point(12, 42);
            this.IsOnlyUploadcb.Name = "IsOnlyUploadcb";
            this.IsOnlyUploadcb.Size = new System.Drawing.Size(154, 21);
            this.IsOnlyUploadcb.TabIndex = 1;
            this.IsOnlyUploadcb.Text = "Только по закачке";
            this.IsOnlyUploadcb.UseVisualStyleBackColor = true;
            // 
            // UpdateDatabut
            // 
            this.UpdateDatabut.Location = new System.Drawing.Point(405, 6);
            this.UpdateDatabut.Name = "UpdateDatabut";
            this.UpdateDatabut.Size = new System.Drawing.Size(130, 28);
            this.UpdateDatabut.TabIndex = 2;
            this.UpdateDatabut.Text = "Применить";
            this.UpdateDatabut.UseVisualStyleBackColor = true;
            this.UpdateDatabut.Click += new System.EventHandler(this.UpdateDatabut_Click);
            // 
            // JournalTable
            // 
            this.JournalTable.AllowUserToAddRows = false;
            this.JournalTable.AllowUserToDeleteRows = false;
            this.JournalTable.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.JournalTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.JournalTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RecordTime,
            this.Message});
            this.JournalTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.JournalTable.Location = new System.Drawing.Point(0, 0);
            this.JournalTable.Name = "JournalTable";
            this.JournalTable.ReadOnly = true;
            this.JournalTable.RowHeadersVisible = false;
            this.JournalTable.RowHeadersWidth = 51;
            this.JournalTable.RowTemplate.Height = 24;
            this.JournalTable.Size = new System.Drawing.Size(693, 453);
            this.JournalTable.TabIndex = 3;
            // 
            // RecordTime
            // 
            this.RecordTime.HeaderText = "Время";
            this.RecordTime.MinimumWidth = 25;
            this.RecordTime.Name = "RecordTime";
            this.RecordTime.ReadOnly = true;
            this.RecordTime.Width = 125;
            // 
            // Message
            // 
            this.Message.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Message.HeaderText = "Сообщение";
            this.Message.MinimumWidth = 6;
            this.Message.Name = "Message";
            this.Message.ReadOnly = true;
            this.Message.Width = 536;
            // 
            // Closebut
            // 
            this.Closebut.Location = new System.Drawing.Point(10, 18);
            this.Closebut.Name = "Closebut";
            this.Closebut.Size = new System.Drawing.Size(101, 28);
            this.Closebut.TabIndex = 4;
            this.Closebut.Text = "Закрыть";
            this.Closebut.UseVisualStyleBackColor = true;
            this.Closebut.Click += new System.EventHandler(this.Closebut_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.JournalTable);
            this.splitContainer1.Size = new System.Drawing.Size(693, 524);
            this.splitContainer1.SplitterDistance = 67;
            this.splitContainer1.TabIndex = 5;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer2.IsSplitterFixed = true;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.label1);
            this.splitContainer2.Panel1.Controls.Add(this.IsOnlyUploadcb);
            this.splitContainer2.Panel1.Controls.Add(this.SelectedDatedtp);
            this.splitContainer2.Panel1.Controls.Add(this.tbPartMess);
            this.splitContainer2.Panel1.Controls.Add(this.UpdateDatabut);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.Closebut);
            this.splitContainer2.Size = new System.Drawing.Size(693, 67);
            this.splitContainer2.SplitterDistance = 566;
            this.splitContainer2.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(200, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Поиск в сообщении";
            // 
            // tbPartMess
            // 
            this.tbPartMess.Location = new System.Drawing.Point(203, 40);
            this.tbPartMess.Name = "tbPartMess";
            this.tbPartMess.Size = new System.Drawing.Size(332, 22);
            this.tbPartMess.TabIndex = 3;
            // 
            // AccentJournalWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 524);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(711, 571);
            this.Name = "AccentJournalWindow";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Журнал Акцента";
            ((System.ComponentModel.ISupportInitialize)(this.JournalTable)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker SelectedDatedtp;
        private System.Windows.Forms.CheckBox IsOnlyUploadcb;
        private System.Windows.Forms.Button UpdateDatabut;
        private System.Windows.Forms.DataGridView JournalTable;
        private System.Windows.Forms.Button Closebut;
        private System.Windows.Forms.DataGridViewTextBoxColumn RecordTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Message;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbPartMess;
    }
}