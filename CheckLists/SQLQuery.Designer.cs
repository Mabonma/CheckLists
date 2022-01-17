namespace CheckLists
{
    partial class SQLQuery
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SQLQuery));
            this.SQLCommand = new System.Windows.Forms.TextBox();
            this.btExit = new System.Windows.Forms.Button();
            this.btExecute = new System.Windows.Forms.Button();
            this.btLoad = new System.Windows.Forms.Button();
            this.btImport = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbNameDB = new System.Windows.Forms.TextBox();
            this.tbUserName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvOutput = new System.Windows.Forms.DataGridView();
            this.btnCancel = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOutput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // SQLCommand
            // 
            this.SQLCommand.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SQLCommand.Location = new System.Drawing.Point(0, 0);
            this.SQLCommand.Multiline = true;
            this.SQLCommand.Name = "SQLCommand";
            this.SQLCommand.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.SQLCommand.Size = new System.Drawing.Size(639, 524);
            this.SQLCommand.TabIndex = 0;
            // 
            // btExit
            // 
            this.btExit.Location = new System.Drawing.Point(116, 487);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(75, 32);
            this.btExit.TabIndex = 7;
            this.btExit.Text = "Выход";
            this.btExit.UseVisualStyleBackColor = true;
            this.btExit.Click += new System.EventHandler(this.BtExit_Click);
            // 
            // btExecute
            // 
            this.btExecute.Location = new System.Drawing.Point(54, 337);
            this.btExecute.Name = "btExecute";
            this.btExecute.Size = new System.Drawing.Size(95, 51);
            this.btExecute.TabIndex = 6;
            this.btExecute.Text = "Выполнить SQL-скрипт";
            this.btExecute.UseVisualStyleBackColor = true;
            this.btExecute.Click += new System.EventHandler(this.BtExecute_Click);
            // 
            // btLoad
            // 
            this.btLoad.Location = new System.Drawing.Point(54, 259);
            this.btLoad.Name = "btLoad";
            this.btLoad.Size = new System.Drawing.Size(95, 54);
            this.btLoad.TabIndex = 5;
            this.btLoad.Text = "Загрузить из БД";
            this.btLoad.UseVisualStyleBackColor = true;
            this.btLoad.Click += new System.EventHandler(this.BtLoad_Click);
            // 
            // btImport
            // 
            this.btImport.Location = new System.Drawing.Point(38, 187);
            this.btImport.Name = "btImport";
            this.btImport.Size = new System.Drawing.Size(124, 55);
            this.btImport.TabIndex = 4;
            this.btImport.Text = "Импортировать SQL-скрипт";
            this.btImport.UseVisualStyleBackColor = true;
            this.btImport.Click += new System.EventHandler(this.BtImport_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Введите базу данных";
            // 
            // tbNameDB
            // 
            this.tbNameDB.Location = new System.Drawing.Point(11, 35);
            this.tbNameDB.Name = "tbNameDB";
            this.tbNameDB.Size = new System.Drawing.Size(180, 22);
            this.tbNameDB.TabIndex = 1;
            // 
            // tbUserName
            // 
            this.tbUserName.Location = new System.Drawing.Point(11, 80);
            this.tbUserName.Name = "tbUserName";
            this.tbUserName.Size = new System.Drawing.Size(180, 22);
            this.tbUserName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Введите имя пользователя";
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(11, 125);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.Size = new System.Drawing.Size(180, 22);
            this.tbPassword.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Введите пароль";
            // 
            // dgvOutput
            // 
            this.dgvOutput.BackgroundColor = System.Drawing.Color.White;
            this.dgvOutput.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvOutput.GridColor = System.Drawing.Color.Black;
            this.dgvOutput.Location = new System.Drawing.Point(0, 0);
            this.dgvOutput.MultiSelect = false;
            this.dgvOutput.Name = "dgvOutput";
            this.dgvOutput.RowHeadersVisible = false;
            this.dgvOutput.RowHeadersWidth = 51;
            this.dgvOutput.RowTemplate.Height = 24;
            this.dgvOutput.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOutput.Size = new System.Drawing.Size(639, 524);
            this.dgvOutput.TabIndex = 11;
            this.dgvOutput.Visible = false;
            this.dgvOutput.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvOutput_CellDoubleClick);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(54, 413);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(95, 34);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Visible = false;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dgvOutput);
            this.splitContainer1.Panel1.Controls.Add(this.SQLCommand);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.btExit);
            this.splitContainer1.Panel2.Controls.Add(this.btnCancel);
            this.splitContainer1.Panel2.Controls.Add(this.tbNameDB);
            this.splitContainer1.Panel2.Controls.Add(this.btExecute);
            this.splitContainer1.Panel2.Controls.Add(this.btLoad);
            this.splitContainer1.Panel2.Controls.Add(this.btImport);
            this.splitContainer1.Panel2.Controls.Add(this.tbPassword);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.tbUserName);
            this.splitContainer1.Size = new System.Drawing.Size(842, 524);
            this.splitContainer1.SplitterDistance = 639;
            this.splitContainer1.TabIndex = 13;
            // 
            // SQLQuery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 524);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(860, 571);
            this.Name = "SQLQuery";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Выполнение SQL-скриптов";
            ((System.ComponentModel.ISupportInitialize)(this.dgvOutput)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox SQLCommand;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.Button btExecute;
        private System.Windows.Forms.Button btLoad;
        private System.Windows.Forms.Button btImport;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbNameDB;
        private System.Windows.Forms.TextBox tbUserName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvOutput;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.SplitContainer splitContainer1;
    }
}