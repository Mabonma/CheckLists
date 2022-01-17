namespace CheckLists
{
    partial class AddEditShiftWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddEditShiftWindow));
            this.label1 = new System.Windows.Forms.Label();
            this.shiftname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.houraftercb = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.minaftercb = new System.Windows.Forms.ComboBox();
            this.minbeforecb = new System.Windows.Forms.ComboBox();
            this.hourbeforecb = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ok = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(11, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Название";
            // 
            // shiftname
            // 
            this.shiftname.Location = new System.Drawing.Point(11, 34);
            this.shiftname.Margin = new System.Windows.Forms.Padding(2);
            this.shiftname.Name = "shiftname";
            this.shiftname.Size = new System.Drawing.Size(366, 22);
            this.shiftname.TabIndex = 1;
            this.shiftname.TextChanged += new System.EventHandler(this.Shiftname_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Начало смены";
            // 
            // houraftercb
            // 
            this.houraftercb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.houraftercb.FormattingEnabled = true;
            this.houraftercb.Items.AddRange(new object[] {
            "00",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23"});
            this.houraftercb.Location = new System.Drawing.Point(149, 76);
            this.houraftercb.MaxLength = 2;
            this.houraftercb.Name = "houraftercb";
            this.houraftercb.Size = new System.Drawing.Size(57, 24);
            this.houraftercb.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(205, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = ":";
            // 
            // minaftercb
            // 
            this.minaftercb.AutoCompleteCustomSource.AddRange(new string[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59"});
            this.minaftercb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.minaftercb.FormattingEnabled = true;
            this.minaftercb.Items.AddRange(new object[] {
            "00",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59"});
            this.minaftercb.Location = new System.Drawing.Point(217, 76);
            this.minaftercb.Name = "minaftercb";
            this.minaftercb.Size = new System.Drawing.Size(49, 24);
            this.minaftercb.TabIndex = 3;
            // 
            // minbeforecb
            // 
            this.minbeforecb.AutoCompleteCustomSource.AddRange(new string[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59"});
            this.minbeforecb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.minbeforecb.FormattingEnabled = true;
            this.minbeforecb.Items.AddRange(new object[] {
            "00",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59"});
            this.minbeforecb.Location = new System.Drawing.Point(217, 106);
            this.minbeforecb.Name = "minbeforecb";
            this.minbeforecb.Size = new System.Drawing.Size(49, 24);
            this.minbeforecb.TabIndex = 5;
            // 
            // hourbeforecb
            // 
            this.hourbeforecb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.hourbeforecb.FormattingEnabled = true;
            this.hourbeforecb.Items.AddRange(new object[] {
            "00",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23"});
            this.hourbeforecb.Location = new System.Drawing.Point(149, 106);
            this.hourbeforecb.MaxLength = 2;
            this.hourbeforecb.Name = "hourbeforecb";
            this.hourbeforecb.Size = new System.Drawing.Size(57, 24);
            this.hourbeforecb.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(12, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Конец смены";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(205, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(14, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = ":";
            // 
            // ok
            // 
            this.ok.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.ok.Enabled = false;
            this.ok.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ok.Location = new System.Drawing.Point(272, 142);
            this.ok.Name = "ok";
            this.ok.Size = new System.Drawing.Size(78, 31);
            this.ok.TabIndex = 7;
            this.ok.Text = "ОК";
            this.ok.UseVisualStyleBackColor = true;
            // 
            // cancel
            // 
            this.cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cancel.Location = new System.Drawing.Point(174, 142);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(92, 31);
            this.cancel.TabIndex = 6;
            this.cancel.Text = "Отмена";
            this.cancel.UseVisualStyleBackColor = true;
            // 
            // AddEditShiftWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 185);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.ok);
            this.Controls.Add(this.minbeforecb);
            this.Controls.Add(this.hourbeforecb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.minaftercb);
            this.Controls.Add(this.houraftercb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.shiftname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddEditShiftWindow";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Смены";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button ok;
        private System.Windows.Forms.Button cancel;
        public System.Windows.Forms.TextBox shiftname;
        public System.Windows.Forms.ComboBox houraftercb;
        public System.Windows.Forms.ComboBox minaftercb;
        public System.Windows.Forms.ComboBox minbeforecb;
        public System.Windows.Forms.ComboBox hourbeforecb;
    }
}