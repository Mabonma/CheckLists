namespace CheckLists
{
    partial class IsidaMessageWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IsidaMessageWindow));
            this.SelectedDatedtp = new System.Windows.Forms.DateTimePicker();
            this.SendMessagebut = new System.Windows.Forms.Button();
            this.Closebut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SelectedDatedtp
            // 
            this.SelectedDatedtp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SelectedDatedtp.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.SelectedDatedtp.Location = new System.Drawing.Point(13, 13);
            this.SelectedDatedtp.Name = "SelectedDatedtp";
            this.SelectedDatedtp.Size = new System.Drawing.Size(126, 27);
            this.SelectedDatedtp.TabIndex = 0;
            this.SelectedDatedtp.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // SendMessagebut
            // 
            this.SendMessagebut.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SendMessagebut.Image = ((System.Drawing.Image)(resources.GetObject("SendMessagebut.Image")));
            this.SendMessagebut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SendMessagebut.Location = new System.Drawing.Point(145, 13);
            this.SendMessagebut.Name = "SendMessagebut";
            this.SendMessagebut.Size = new System.Drawing.Size(139, 27);
            this.SendMessagebut.TabIndex = 1;
            this.SendMessagebut.Text = "Отправить";
            this.SendMessagebut.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.SendMessagebut.UseVisualStyleBackColor = true;
            this.SendMessagebut.Click += new System.EventHandler(this.SendMessagebut_Click);
            // 
            // Closebut
            // 
            this.Closebut.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Closebut.Location = new System.Drawing.Point(173, 67);
            this.Closebut.Name = "Closebut";
            this.Closebut.Size = new System.Drawing.Size(111, 28);
            this.Closebut.TabIndex = 2;
            this.Closebut.Text = "Закрыть";
            this.Closebut.UseVisualStyleBackColor = true;
            this.Closebut.Click += new System.EventHandler(this.Closebut_Click);
            // 
            // IsidaMessageWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 107);
            this.Controls.Add(this.Closebut);
            this.Controls.Add(this.SendMessagebut);
            this.Controls.Add(this.SelectedDatedtp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "IsidaMessageWindow";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Оповещение";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker SelectedDatedtp;
        private System.Windows.Forms.Button SendMessagebut;
        private System.Windows.Forms.Button Closebut;
    }
}