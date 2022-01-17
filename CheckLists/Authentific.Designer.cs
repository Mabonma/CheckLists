namespace CheckLists
{
    partial class Authentific
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Authentific));
            this.label1 = new System.Windows.Forms.Label();
            this.UsName = new System.Windows.Forms.TextBox();
            this.IfWin = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.UsPass = new System.Windows.Forms.TextBox();
            this.EnterPass = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(81, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Пользователь в домене";
            // 
            // UsName
            // 
            this.UsName.Location = new System.Drawing.Point(48, 52);
            this.UsName.Margin = new System.Windows.Forms.Padding(3, 3, 3, 5);
            this.UsName.Name = "UsName";
            this.UsName.Size = new System.Drawing.Size(250, 22);
            this.UsName.TabIndex = 1;
            // 
            // IfWin
            // 
            this.IfWin.AutoSize = true;
            this.IfWin.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IfWin.Location = new System.Drawing.Point(13, 81);
            this.IfWin.Margin = new System.Windows.Forms.Padding(3, 3, 3, 5);
            this.IfWin.Name = "IfWin";
            this.IfWin.Size = new System.Drawing.Size(347, 27);
            this.IfWin.TabIndex = 2;
            this.IfWin.Text = "Использовать учётную запись Windows";
            this.IfWin.UseVisualStyleBackColor = true;
            this.IfWin.CheckedChanged += new System.EventHandler(this.IfWin_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(145, 113);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Пароль";
            // 
            // UsPass
            // 
            this.UsPass.Location = new System.Drawing.Point(48, 144);
            this.UsPass.Margin = new System.Windows.Forms.Padding(3, 3, 3, 5);
            this.UsPass.Name = "UsPass";
            this.UsPass.PasswordChar = '*';
            this.UsPass.Size = new System.Drawing.Size(250, 22);
            this.UsPass.TabIndex = 4;
            this.UsPass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.UsPass_KeyDown);
            // 
            // EnterPass
            // 
            this.EnterPass.Location = new System.Drawing.Point(247, 174);
            this.EnterPass.Name = "EnterPass";
            this.EnterPass.Size = new System.Drawing.Size(105, 36);
            this.EnterPass.TabIndex = 5;
            this.EnterPass.Text = "OK";
            this.EnterPass.UseVisualStyleBackColor = true;
            this.EnterPass.Click += new System.EventHandler(this.EnterPass_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Blue;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(311, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "ru";
            // 
            // Authentific
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 220);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.EnterPass);
            this.Controls.Add(this.UsPass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.IfWin);
            this.Controls.Add(this.UsName);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Authentific";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Авторизация";
            this.Shown += new System.EventHandler(this.Authentific_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox UsName;
        private System.Windows.Forms.CheckBox IfWin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox UsPass;
        private System.Windows.Forms.Button EnterPass;
        private System.Windows.Forms.Label label3;
    }
}

