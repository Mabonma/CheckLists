namespace CheckLists
{
    partial class JournalWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JournalWindow));
            this.JournalTable = new System.Windows.Forms.DataGridView();
            this.RecordTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ShiftName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ShiftDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Comment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ShiftTimeAfter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ShiftTimeBefore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AuthorName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.AuthorUsernametb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.JournalSettingscb = new System.Windows.Forms.ComboBox();
            this.datebeforedtp = new System.Windows.Forms.DateTimePicker();
            this.dateafterdtp = new System.Windows.Forms.DateTimePicker();
            this.Applybt = new System.Windows.Forms.Button();
            this.Closebt = new System.Windows.Forms.Button();
            this.WriteInExcelbt = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this.JournalTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // JournalTable
            // 
            this.JournalTable.AllowUserToAddRows = false;
            this.JournalTable.AllowUserToDeleteRows = false;
            this.JournalTable.BackgroundColor = System.Drawing.Color.White;
            this.JournalTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.JournalTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RecordTime,
            this.ShiftName,
            this.ShiftDescription,
            this.Comment,
            this.ShiftTimeAfter,
            this.ShiftTimeBefore,
            this.AuthorName});
            this.JournalTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.JournalTable.Location = new System.Drawing.Point(0, 0);
            this.JournalTable.Name = "JournalTable";
            this.JournalTable.ReadOnly = true;
            this.JournalTable.RowHeadersVisible = false;
            this.JournalTable.RowHeadersWidth = 51;
            this.JournalTable.RowTemplate.Height = 24;
            this.JournalTable.Size = new System.Drawing.Size(878, 363);
            this.JournalTable.TabIndex = 6;
            // 
            // RecordTime
            // 
            this.RecordTime.HeaderText = "Время";
            this.RecordTime.MinimumWidth = 25;
            this.RecordTime.Name = "RecordTime";
            this.RecordTime.ReadOnly = true;
            this.RecordTime.Width = 125;
            // 
            // ShiftName
            // 
            this.ShiftName.HeaderText = "Имя смены";
            this.ShiftName.MinimumWidth = 25;
            this.ShiftName.Name = "ShiftName";
            this.ShiftName.ReadOnly = true;
            this.ShiftName.Width = 125;
            // 
            // ShiftDescription
            // 
            this.ShiftDescription.HeaderText = "Описание смены";
            this.ShiftDescription.MinimumWidth = 10;
            this.ShiftDescription.Name = "ShiftDescription";
            this.ShiftDescription.ReadOnly = true;
            this.ShiftDescription.Width = 125;
            // 
            // Comment
            // 
            this.Comment.HeaderText = "Комментарий";
            this.Comment.MinimumWidth = 25;
            this.Comment.Name = "Comment";
            this.Comment.ReadOnly = true;
            this.Comment.Width = 125;
            // 
            // ShiftTimeAfter
            // 
            this.ShiftTimeAfter.HeaderText = "Время после";
            this.ShiftTimeAfter.MinimumWidth = 25;
            this.ShiftTimeAfter.Name = "ShiftTimeAfter";
            this.ShiftTimeAfter.ReadOnly = true;
            this.ShiftTimeAfter.Width = 125;
            // 
            // ShiftTimeBefore
            // 
            this.ShiftTimeBefore.HeaderText = "Время до";
            this.ShiftTimeBefore.MinimumWidth = 25;
            this.ShiftTimeBefore.Name = "ShiftTimeBefore";
            this.ShiftTimeBefore.ReadOnly = true;
            this.ShiftTimeBefore.Width = 125;
            // 
            // AuthorName
            // 
            this.AuthorName.HeaderText = "Автор";
            this.AuthorName.MinimumWidth = 25;
            this.AuthorName.Name = "AuthorName";
            this.AuthorName.ReadOnly = true;
            this.AuthorName.Width = 125;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Имя пользователя:";
            // 
            // AuthorUsernametb
            // 
            this.AuthorUsernametb.Location = new System.Drawing.Point(13, 37);
            this.AuthorUsernametb.Name = "AuthorUsernametb";
            this.AuthorUsernametb.Size = new System.Drawing.Size(289, 22);
            this.AuthorUsernametb.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(13, 85);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Смена: ";
            // 
            // JournalSettingscb
            // 
            this.JournalSettingscb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.JournalSettingscb.FormattingEnabled = true;
            this.JournalSettingscb.Location = new System.Drawing.Point(86, 85);
            this.JournalSettingscb.Name = "JournalSettingscb";
            this.JournalSettingscb.Size = new System.Drawing.Size(137, 24);
            this.JournalSettingscb.TabIndex = 2;
            // 
            // datebeforedtp
            // 
            this.datebeforedtp.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datebeforedtp.Location = new System.Drawing.Point(195, 127);
            this.datebeforedtp.Name = "datebeforedtp";
            this.datebeforedtp.Size = new System.Drawing.Size(107, 22);
            this.datebeforedtp.TabIndex = 4;
            this.datebeforedtp.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // dateafterdtp
            // 
            this.dateafterdtp.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateafterdtp.Location = new System.Drawing.Point(82, 127);
            this.dateafterdtp.Name = "dateafterdtp";
            this.dateafterdtp.Size = new System.Drawing.Size(107, 22);
            this.dateafterdtp.TabIndex = 3;
            this.dateafterdtp.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // Applybt
            // 
            this.Applybt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Applybt.Location = new System.Drawing.Point(175, 165);
            this.Applybt.Name = "Applybt";
            this.Applybt.Size = new System.Drawing.Size(127, 28);
            this.Applybt.TabIndex = 5;
            this.Applybt.Text = "Применить";
            this.Applybt.UseVisualStyleBackColor = true;
            this.Applybt.Click += new System.EventHandler(this.Applybt_Click);
            // 
            // Closebt
            // 
            this.Closebt.Location = new System.Drawing.Point(195, 314);
            this.Closebt.Name = "Closebt";
            this.Closebt.Size = new System.Drawing.Size(92, 28);
            this.Closebt.TabIndex = 7;
            this.Closebt.Text = "Закрыть";
            this.Closebt.UseVisualStyleBackColor = true;
            this.Closebt.Click += new System.EventHandler(this.Closebt_Click);
            // 
            // WriteInExcelbt
            // 
            this.WriteInExcelbt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("WriteInExcelbt.BackgroundImage")));
            this.WriteInExcelbt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.WriteInExcelbt.Location = new System.Drawing.Point(12, 314);
            this.WriteInExcelbt.Name = "WriteInExcelbt";
            this.WriteInExcelbt.Size = new System.Drawing.Size(36, 36);
            this.WriteInExcelbt.TabIndex = 8;
            this.WriteInExcelbt.UseVisualStyleBackColor = true;
            this.WriteInExcelbt.Click += new System.EventHandler(this.WriteInExcelbt_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.Closebt);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.JournalTable);
            this.splitContainer1.Size = new System.Drawing.Size(1190, 363);
            this.splitContainer1.SplitterDistance = 311;
            this.splitContainer1.SplitterWidth = 1;
            this.splitContainer1.TabIndex = 0;
            // 
            // JournalWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1190, 363);
            this.Controls.Add(this.WriteInExcelbt);
            this.Controls.Add(this.Applybt);
            this.Controls.Add(this.dateafterdtp);
            this.Controls.Add(this.datebeforedtp);
            this.Controls.Add(this.JournalSettingscb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AuthorUsernametb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1032, 399);
            this.Name = "JournalWindow";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Журнал";
            ((System.ComponentModel.ISupportInitialize)(this.JournalTable)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView JournalTable;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox AuthorUsernametb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox JournalSettingscb;
        private System.Windows.Forms.DateTimePicker datebeforedtp;
        private System.Windows.Forms.DateTimePicker dateafterdtp;
        private System.Windows.Forms.Button Applybt;
        private System.Windows.Forms.Button Closebt;
        private System.Windows.Forms.Button WriteInExcelbt;
        private System.Windows.Forms.DataGridViewTextBoxColumn RecordTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn ShiftName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ShiftDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn Comment;
        private System.Windows.Forms.DataGridViewTextBoxColumn ShiftTimeAfter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ShiftTimeBefore;
        private System.Windows.Forms.DataGridViewTextBoxColumn AuthorName;
        private System.Windows.Forms.SplitContainer splitContainer1;
    }
}