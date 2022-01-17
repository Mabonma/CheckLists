namespace CheckLists
{
    partial class StatementsWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StatementsWindow));
            this.StartDatedtp = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.StopDatedtp = new System.Windows.Forms.DateTimePicker();
            this.Refreshbut = new System.Windows.Forms.Button();
            this.CountStatements = new System.Windows.Forms.Label();
            this.Closebut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // StartDatedtp
            // 
            this.StartDatedtp.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.StartDatedtp.Location = new System.Drawing.Point(13, 13);
            this.StartDatedtp.Name = "StartDatedtp";
            this.StartDatedtp.Size = new System.Drawing.Size(116, 22);
            this.StartDatedtp.TabIndex = 1;
            this.StartDatedtp.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Количество выписок:";
            // 
            // StopDatedtp
            // 
            this.StopDatedtp.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.StopDatedtp.Location = new System.Drawing.Point(136, 13);
            this.StopDatedtp.Name = "StopDatedtp";
            this.StopDatedtp.Size = new System.Drawing.Size(116, 22);
            this.StopDatedtp.TabIndex = 2;
            this.StopDatedtp.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // Refreshbut
            // 
            this.Refreshbut.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Refreshbut.BackgroundImage")));
            this.Refreshbut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Refreshbut.Location = new System.Drawing.Point(228, 48);
            this.Refreshbut.Name = "Refreshbut";
            this.Refreshbut.Size = new System.Drawing.Size(24, 24);
            this.Refreshbut.TabIndex = 3;
            this.Refreshbut.UseVisualStyleBackColor = true;
            this.Refreshbut.Click += new System.EventHandler(this.Refreshbut_Click);
            // 
            // CountStatements
            // 
            this.CountStatements.AutoSize = true;
            this.CountStatements.Location = new System.Drawing.Point(159, 52);
            this.CountStatements.Name = "CountStatements";
            this.CountStatements.Size = new System.Drawing.Size(0, 17);
            this.CountStatements.TabIndex = 4;
            // 
            // Closebut
            // 
            this.Closebut.Location = new System.Drawing.Point(162, 82);
            this.Closebut.Name = "Closebut";
            this.Closebut.Size = new System.Drawing.Size(90, 27);
            this.Closebut.TabIndex = 5;
            this.Closebut.Text = "Закрыть";
            this.Closebut.UseVisualStyleBackColor = true;
            this.Closebut.Click += new System.EventHandler(this.Closebut_Click);
            // 
            // StatementsWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(265, 121);
            this.Controls.Add(this.Closebut);
            this.Controls.Add(this.CountStatements);
            this.Controls.Add(this.Refreshbut);
            this.Controls.Add(this.StopDatedtp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.StartDatedtp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StatementsWindow";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Выписки";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker StartDatedtp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker StopDatedtp;
        private System.Windows.Forms.Button Refreshbut;
        private System.Windows.Forms.Label CountStatements;
        private System.Windows.Forms.Button Closebut;
    }
}