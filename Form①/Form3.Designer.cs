namespace YourNamespace
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.lblDays = new System.Windows.Forms.Label();
            this.cmbOptions = new System.Windows.Forms.ComboBox();
            this.chkComboConfirm = new System.Windows.Forms.CheckBox();
            this.lblUnitTitle = new System.Windows.Forms.Label();
            this.rdoYears = new System.Windows.Forms.RadioButton();
            this.rdoDays = new System.Windows.Forms.RadioButton();
            this.lblResult = new System.Windows.Forms.Label();
            this.pnlWeek = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.rdoSun = new System.Windows.Forms.RadioButton();
            this.rdoSat = new System.Windows.Forms.RadioButton();
            this.rdoFri = new System.Windows.Forms.RadioButton();
            this.rdoThu = new System.Windows.Forms.RadioButton();
            this.rdoWed = new System.Windows.Forms.RadioButton();
            this.rdoTue = new System.Windows.Forms.RadioButton();
            this.rdoMon = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnConfirmAll = new System.Windows.Forms.Button();
            this.chkLabelConfirm = new System.Windows.Forms.CheckBox();
            this.chkRadioConfirm = new System.Windows.Forms.CheckBox();
            this.rdoZoom = new System.Windows.Forms.RadioButton();
            this.rdoStretch = new System.Windows.Forms.RadioButton();
            this.rdoCenter = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pic = new System.Windows.Forms.PictureBox();
            this.btnLoadImage = new System.Windows.Forms.Button();
            this.pnlWeek.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDays
            // 
            this.lblDays.AutoSize = true;
            this.lblDays.Location = new System.Drawing.Point(13, 9);
            this.lblDays.Name = "lblDays";
            this.lblDays.Size = new System.Drawing.Size(164, 18);
            this.lblDays.TabIndex = 0;
            this.lblDays.Text = "日数、選択結果表示";
            // 
            // cmbOptions
            // 
            this.cmbOptions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOptions.FormattingEnabled = true;
            this.cmbOptions.Location = new System.Drawing.Point(135, 69);
            this.cmbOptions.Name = "cmbOptions";
            this.cmbOptions.Size = new System.Drawing.Size(152, 26);
            this.cmbOptions.TabIndex = 6;
            this.cmbOptions.SelectedIndexChanged += new System.EventHandler(this.cmbOptions_SelectedIndexChanged);
            // 
            // chkComboConfirm
            // 
            this.chkComboConfirm.AutoSize = true;
            this.chkComboConfirm.Location = new System.Drawing.Point(9, 76);
            this.chkComboConfirm.Name = "chkComboConfirm";
            this.chkComboConfirm.Size = new System.Drawing.Size(161, 22);
            this.chkComboConfirm.TabIndex = 7;
            this.chkComboConfirm.Text = "コンボボックス確認";
            this.chkComboConfirm.UseVisualStyleBackColor = true;
            this.chkComboConfirm.CheckedChanged += new System.EventHandler(this.chkComboConfirm_CheckedChanged);
            // 
            // lblUnitTitle
            // 
            this.lblUnitTitle.AutoSize = true;
            this.lblUnitTitle.BackColor = System.Drawing.Color.Green;
            this.lblUnitTitle.Location = new System.Drawing.Point(238, 110);
            this.lblUnitTitle.Name = "lblUnitTitle";
            this.lblUnitTitle.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblUnitTitle.Size = new System.Drawing.Size(46, 18);
            this.lblUnitTitle.TabIndex = 13;
            this.lblUnitTitle.Text = "Days";
            // 
            // rdoYears
            // 
            this.rdoYears.AutoSize = true;
            this.rdoYears.Location = new System.Drawing.Point(23, 104);
            this.rdoYears.Name = "rdoYears";
            this.rdoYears.Size = new System.Drawing.Size(76, 22);
            this.rdoYears.TabIndex = 8;
            this.rdoYears.TabStop = true;
            this.rdoYears.Text = "Years";
            this.rdoYears.UseVisualStyleBackColor = true;
            this.rdoYears.CheckedChanged += new System.EventHandler(this.rdoUnit_CheckedChanged);
            // 
            // rdoDays
            // 
            this.rdoDays.AutoSize = true;
            this.rdoDays.Location = new System.Drawing.Point(23, 34);
            this.rdoDays.Name = "rdoDays";
            this.rdoDays.Size = new System.Drawing.Size(71, 22);
            this.rdoDays.TabIndex = 7;
            this.rdoDays.TabStop = true;
            this.rdoDays.Text = "Days";
            this.rdoDays.UseVisualStyleBackColor = true;
            this.rdoDays.CheckedChanged += new System.EventHandler(this.rdoUnit_CheckedChanged);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(267, 292);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 18);
            this.lblResult.TabIndex = 11;
            // 
            // pnlWeek
            // 
            this.pnlWeek.Controls.Add(this.label2);
            this.pnlWeek.Controls.Add(this.rdoSun);
            this.pnlWeek.Controls.Add(this.rdoSat);
            this.pnlWeek.Controls.Add(this.rdoFri);
            this.pnlWeek.Controls.Add(this.rdoThu);
            this.pnlWeek.Controls.Add(this.rdoWed);
            this.pnlWeek.Controls.Add(this.rdoTue);
            this.pnlWeek.Controls.Add(this.rdoMon);
            this.pnlWeek.Location = new System.Drawing.Point(17, 40);
            this.pnlWeek.Name = "pnlWeek";
            this.pnlWeek.Size = new System.Drawing.Size(200, 218);
            this.pnlWeek.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Green;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(137, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 18);
            this.label2.TabIndex = 14;
            this.label2.Text = "Days";
            // 
            // rdoSun
            // 
            this.rdoSun.AutoSize = true;
            this.rdoSun.Location = new System.Drawing.Point(3, 178);
            this.rdoSun.Name = "rdoSun";
            this.rdoSun.Size = new System.Drawing.Size(62, 22);
            this.rdoSun.TabIndex = 6;
            this.rdoSun.Text = "Sun";
            this.rdoSun.UseVisualStyleBackColor = true;
            this.rdoSun.CheckedChanged += new System.EventHandler(this.rdoWeek_CheckedChanged);
            // 
            // rdoSat
            // 
            this.rdoSat.AutoSize = true;
            this.rdoSat.Location = new System.Drawing.Point(3, 152);
            this.rdoSat.Name = "rdoSat";
            this.rdoSat.Size = new System.Drawing.Size(59, 22);
            this.rdoSat.TabIndex = 5;
            this.rdoSat.Text = "Sat";
            this.rdoSat.UseVisualStyleBackColor = true;
            this.rdoSat.CheckedChanged += new System.EventHandler(this.rdoWeek_CheckedChanged);
            // 
            // rdoFri
            // 
            this.rdoFri.AutoSize = true;
            this.rdoFri.Location = new System.Drawing.Point(3, 123);
            this.rdoFri.Name = "rdoFri";
            this.rdoFri.Size = new System.Drawing.Size(53, 22);
            this.rdoFri.TabIndex = 4;
            this.rdoFri.Text = "Fri";
            this.rdoFri.UseVisualStyleBackColor = true;
            this.rdoFri.CheckedChanged += new System.EventHandler(this.rdoWeek_CheckedChanged);
            // 
            // rdoThu
            // 
            this.rdoThu.AutoSize = true;
            this.rdoThu.Location = new System.Drawing.Point(3, 94);
            this.rdoThu.Name = "rdoThu";
            this.rdoThu.Size = new System.Drawing.Size(62, 22);
            this.rdoThu.TabIndex = 3;
            this.rdoThu.Text = "Thu";
            this.rdoThu.UseVisualStyleBackColor = true;
            this.rdoThu.CheckedChanged += new System.EventHandler(this.rdoWeek_CheckedChanged);
            // 
            // rdoWed
            // 
            this.rdoWed.AutoSize = true;
            this.rdoWed.Location = new System.Drawing.Point(3, 68);
            this.rdoWed.Name = "rdoWed";
            this.rdoWed.Size = new System.Drawing.Size(64, 22);
            this.rdoWed.TabIndex = 2;
            this.rdoWed.Text = "Wed";
            this.rdoWed.UseVisualStyleBackColor = true;
            this.rdoWed.CheckedChanged += new System.EventHandler(this.rdoWeek_CheckedChanged);
            // 
            // rdoTue
            // 
            this.rdoTue.AutoSize = true;
            this.rdoTue.Location = new System.Drawing.Point(3, 38);
            this.rdoTue.Name = "rdoTue";
            this.rdoTue.Size = new System.Drawing.Size(62, 22);
            this.rdoTue.TabIndex = 1;
            this.rdoTue.Text = "Tue";
            this.rdoTue.UseVisualStyleBackColor = true;
            this.rdoTue.CheckedChanged += new System.EventHandler(this.rdoWeek_CheckedChanged);
            // 
            // rdoMon
            // 
            this.rdoMon.AutoSize = true;
            this.rdoMon.Checked = true;
            this.rdoMon.Location = new System.Drawing.Point(3, 10);
            this.rdoMon.Name = "rdoMon";
            this.rdoMon.Size = new System.Drawing.Size(64, 22);
            this.rdoMon.TabIndex = 0;
            this.rdoMon.TabStop = true;
            this.rdoMon.Text = "Mon";
            this.rdoMon.UseVisualStyleBackColor = true;
            this.rdoMon.CheckedChanged += new System.EventHandler(this.rdoWeek_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnConfirmAll);
            this.panel1.Controls.Add(this.chkLabelConfirm);
            this.panel1.Controls.Add(this.chkRadioConfirm);
            this.panel1.Controls.Add(this.chkComboConfirm);
            this.panel1.Location = new System.Drawing.Point(418, 160);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(320, 166);
            this.panel1.TabIndex = 15;
            // 
            // btnConfirmAll
            // 
            this.btnConfirmAll.BackColor = System.Drawing.Color.Yellow;
            this.btnConfirmAll.Enabled = false;
            this.btnConfirmAll.Location = new System.Drawing.Point(182, 43);
            this.btnConfirmAll.Name = "btnConfirmAll";
            this.btnConfirmAll.Size = new System.Drawing.Size(135, 107);
            this.btnConfirmAll.TabIndex = 18;
            this.btnConfirmAll.Text = "button1";
            this.btnConfirmAll.UseVisualStyleBackColor = false;
            this.btnConfirmAll.Click += new System.EventHandler(this.btnConfirmAll_Click);
            this.btnConfirmAll.MouseEnter += new System.EventHandler(this.btnConfirmAll_MouseEnter);
            this.btnConfirmAll.MouseLeave += new System.EventHandler(this.btnConfirmAll_MouseLeave);
            // 
            // chkLabelConfirm
            // 
            this.chkLabelConfirm.AutoSize = true;
            this.chkLabelConfirm.Location = new System.Drawing.Point(9, 128);
            this.chkLabelConfirm.Name = "chkLabelConfirm";
            this.chkLabelConfirm.Size = new System.Drawing.Size(148, 22);
            this.chkLabelConfirm.TabIndex = 16;
            this.chkLabelConfirm.Text = "ラベル表示確認";
            this.chkLabelConfirm.UseVisualStyleBackColor = true;
            this.chkLabelConfirm.CheckedChanged += new System.EventHandler(this.chkLabelConfirm_CheckedChanged);
            // 
            // chkRadioConfirm
            // 
            this.chkRadioConfirm.AutoSize = true;
            this.chkRadioConfirm.Location = new System.Drawing.Point(9, 15);
            this.chkRadioConfirm.Name = "chkRadioConfirm";
            this.chkRadioConfirm.Size = new System.Drawing.Size(162, 22);
            this.chkRadioConfirm.TabIndex = 17;
            this.chkRadioConfirm.Text = "ラジオボックス確認";
            this.chkRadioConfirm.UseVisualStyleBackColor = true;
            this.chkRadioConfirm.CheckedChanged += new System.EventHandler(this.chkRadioConfirm_CheckedChanged);
            // 
            // rdoZoom
            // 
            this.rdoZoom.AutoSize = true;
            this.rdoZoom.Location = new System.Drawing.Point(260, 292);
            this.rdoZoom.Name = "rdoZoom";
            this.rdoZoom.Size = new System.Drawing.Size(74, 22);
            this.rdoZoom.TabIndex = 16;
            this.rdoZoom.TabStop = true;
            this.rdoZoom.Text = "Zoom";
            this.rdoZoom.UseVisualStyleBackColor = true;
            this.rdoZoom.CheckedChanged += new System.EventHandler(this.rdoSizeMode_CheckedChanged);
            // 
            // rdoStretch
            // 
            this.rdoStretch.AutoSize = true;
            this.rdoStretch.Location = new System.Drawing.Point(260, 340);
            this.rdoStretch.Name = "rdoStretch";
            this.rdoStretch.Size = new System.Drawing.Size(89, 22);
            this.rdoStretch.TabIndex = 17;
            this.rdoStretch.TabStop = true;
            this.rdoStretch.Text = "Stretch";
            this.rdoStretch.UseVisualStyleBackColor = true;
            this.rdoStretch.CheckedChanged += new System.EventHandler(this.rdoSizeMode_CheckedChanged);
            // 
            // rdoCenter
            // 
            this.rdoCenter.AutoSize = true;
            this.rdoCenter.Location = new System.Drawing.Point(260, 388);
            this.rdoCenter.Name = "rdoCenter";
            this.rdoCenter.Size = new System.Drawing.Size(84, 22);
            this.rdoCenter.TabIndex = 18;
            this.rdoCenter.TabStop = true;
            this.rdoCenter.Text = "Center";
            this.rdoCenter.UseVisualStyleBackColor = true;
            this.rdoCenter.CheckedChanged += new System.EventHandler(this.rdoSizeMode_CheckedChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rdoDays);
            this.panel2.Controls.Add(this.lblUnitTitle);
            this.panel2.Controls.Add(this.rdoYears);
            this.panel2.Controls.Add(this.cmbOptions);
            this.panel2.Location = new System.Drawing.Point(405, 9);
            this.panel2.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(333, 150);
            this.panel2.TabIndex = 0;
            // 
            // pic
            // 
            this.pic.Image = global::Form_.Properties.Resources.sf6;
            this.pic.Location = new System.Drawing.Point(20, 264);
            this.pic.Name = "pic";
            this.pic.Size = new System.Drawing.Size(215, 161);
            this.pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic.TabIndex = 14;
            this.pic.TabStop = false;
            // 
            // btnLoadImage
            // 
            this.btnLoadImage.Location = new System.Drawing.Point(260, 244);
            this.btnLoadImage.Name = "btnLoadImage";
            this.btnLoadImage.Size = new System.Drawing.Size(109, 34);
            this.btnLoadImage.TabIndex = 19;
            this.btnLoadImage.Text = "画像選択";
            this.btnLoadImage.UseVisualStyleBackColor = true;
            this.btnLoadImage.Click += new System.EventHandler(this.btnLoadImage_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLoadImage);
            this.Controls.Add(this.pic);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.rdoCenter);
            this.Controls.Add(this.rdoStretch);
            this.Controls.Add(this.rdoZoom);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlWeek);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblDays);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.pnlWeek.ResumeLayout(false);
            this.pnlWeek.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDays;
        private System.Windows.Forms.ComboBox cmbOptions;
        private System.Windows.Forms.CheckBox chkComboConfirm;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Panel pnlWeek;
        private System.Windows.Forms.RadioButton rdoSun;
        private System.Windows.Forms.RadioButton rdoSat;
        private System.Windows.Forms.RadioButton rdoFri;
        private System.Windows.Forms.RadioButton rdoThu;
        private System.Windows.Forms.RadioButton rdoWed;
        private System.Windows.Forms.RadioButton rdoTue;
        private System.Windows.Forms.RadioButton rdoMon;
        private System.Windows.Forms.RadioButton rdoDays;
        private System.Windows.Forms.RadioButton rdoYears;
        private System.Windows.Forms.Label lblUnitTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox chkLabelConfirm;
        private System.Windows.Forms.CheckBox chkRadioConfirm;
        private System.Windows.Forms.RadioButton rdoZoom;
        private System.Windows.Forms.RadioButton rdoStretch;
        private System.Windows.Forms.RadioButton rdoCenter;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pic;
        private System.Windows.Forms.Button btnLoadImage;
        private System.Windows.Forms.Button btnConfirmAll;
    }
}