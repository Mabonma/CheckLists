namespace CheckLists
{
    partial class SettingsWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsWindow));
            this.label1 = new System.Windows.Forms.Label();
            this.IsidaMessageRecipients = new System.Windows.Forms.TextBox();
            this.OsedResponseFolder = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.OpenOsedResponseFolder = new System.Windows.Forms.Button();
            this.Applybt = new System.Windows.Forms.Button();
            this.Closebt = new System.Windows.Forms.Button();
            this.OpenDBPathFolder = new System.Windows.Forms.Button();
            this.DBPathFolder = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(382, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Получатели в лотусе оповещений по исиде:";
            // 
            // IsidaMessageRecipients
            // 
            this.IsidaMessageRecipients.Location = new System.Drawing.Point(12, 36);
            this.IsidaMessageRecipients.Name = "IsidaMessageRecipients";
            this.IsidaMessageRecipients.Size = new System.Drawing.Size(575, 22);
            this.IsidaMessageRecipients.TabIndex = 1;
            // 
            // OsedResponseFolder
            // 
            this.OsedResponseFolder.Location = new System.Drawing.Point(12, 97);
            this.OsedResponseFolder.Name = "OsedResponseFolder";
            this.OsedResponseFolder.Size = new System.Drawing.Size(494, 22);
            this.OsedResponseFolder.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(249, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Папка для ответа по ОСЭД:";
            // 
            // OpenOsedResponseFolder
            // 
            this.OpenOsedResponseFolder.Location = new System.Drawing.Point(512, 92);
            this.OpenOsedResponseFolder.Name = "OpenOsedResponseFolder";
            this.OpenOsedResponseFolder.Size = new System.Drawing.Size(75, 32);
            this.OpenOsedResponseFolder.TabIndex = 4;
            this.OpenOsedResponseFolder.Text = "Обзор";
            this.OpenOsedResponseFolder.UseVisualStyleBackColor = true;
            this.OpenOsedResponseFolder.Click += new System.EventHandler(this.OpenOsedResponseFolder_Click);
            // 
            // Applybt
            // 
            this.Applybt.Location = new System.Drawing.Point(479, 194);
            this.Applybt.Name = "Applybt";
            this.Applybt.Size = new System.Drawing.Size(108, 31);
            this.Applybt.TabIndex = 5;
            this.Applybt.Text = "Применить";
            this.Applybt.UseVisualStyleBackColor = true;
            this.Applybt.Click += new System.EventHandler(this.Applybt_Click);
            // 
            // Closebt
            // 
            this.Closebt.Location = new System.Drawing.Point(371, 194);
            this.Closebt.Name = "Closebt";
            this.Closebt.Size = new System.Drawing.Size(102, 31);
            this.Closebt.TabIndex = 6;
            this.Closebt.Text = "Закрыть";
            this.Closebt.UseVisualStyleBackColor = true;
            this.Closebt.Click += new System.EventHandler(this.Closebt_Click);
            // 
            // OpenDBPathFolder
            // 
            this.OpenDBPathFolder.Location = new System.Drawing.Point(512, 146);
            this.OpenDBPathFolder.Name = "OpenDBPathFolder";
            this.OpenDBPathFolder.Size = new System.Drawing.Size(75, 32);
            this.OpenDBPathFolder.TabIndex = 9;
            this.OpenDBPathFolder.Text = "Обзор";
            this.OpenDBPathFolder.UseVisualStyleBackColor = true;
            this.OpenDBPathFolder.Click += new System.EventHandler(this.OpenDBPathFolder_Click);
            // 
            // DBPathFolder
            // 
            this.DBPathFolder.Location = new System.Drawing.Point(12, 151);
            this.DBPathFolder.Name = "DBPathFolder";
            this.DBPathFolder.Size = new System.Drawing.Size(494, 22);
            this.DBPathFolder.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(196, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Папка с базой данных";
            // 
            // SettingsWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 237);
            this.Controls.Add(this.OpenDBPathFolder);
            this.Controls.Add(this.DBPathFolder);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Closebt);
            this.Controls.Add(this.Applybt);
            this.Controls.Add(this.OpenOsedResponseFolder);
            this.Controls.Add(this.OsedResponseFolder);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.IsidaMessageRecipients);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingsWindow";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Настройки";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox IsidaMessageRecipients;
        private System.Windows.Forms.TextBox OsedResponseFolder;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button OpenOsedResponseFolder;
        private System.Windows.Forms.Button Applybt;
        private System.Windows.Forms.Button Closebt;
        private System.Windows.Forms.Button OpenDBPathFolder;
        private System.Windows.Forms.TextBox DBPathFolder;
        private System.Windows.Forms.Label label3;
    }
}