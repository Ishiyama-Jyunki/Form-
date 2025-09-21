namespace Form_
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Button btnGreen;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnGoForm2 = new System.Windows.Forms.Button();
            this.lblFileContact = new System.Windows.Forms.Label();
            this.lblReturn = new System.Windows.Forms.Label();
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.lblFileContent = new System.Windows.Forms.Label();
            this.btnSelectFile = new System.Windows.Forms.Button();
            this.btnShowContent = new System.Windows.Forms.Button();
            this.btnFileUpdate = new System.Windows.Forms.Button();
            this.btnYellow = new System.Windows.Forms.Button();
            this.btnBlue = new System.Windows.Forms.Button();
            this.lblClock = new System.Windows.Forms.Label();
            this.tmrClock = new System.Windows.Forms.Timer(this.components);
            this.btnGoForm3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            btnGreen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGreen
            // 
            btnGreen.BackColor = System.Drawing.Color.Yellow;
            btnGreen.ForeColor = System.Drawing.Color.Black;
            btnGreen.Location = new System.Drawing.Point(606, 219);
            btnGreen.Name = "btnGreen";
            btnGreen.Size = new System.Drawing.Size(75, 38);
            btnGreen.TabIndex = 9;
            btnGreen.Text = "Green";
            btnGreen.UseVisualStyleBackColor = false;
            btnGreen.Click += new System.EventHandler(this.btnGreen_Click);
            // 
            // btnGoForm2
            // 
            this.btnGoForm2.Location = new System.Drawing.Point(606, 106);
            this.btnGoForm2.Name = "btnGoForm2";
            this.btnGoForm2.Size = new System.Drawing.Size(88, 33);
            this.btnGoForm2.TabIndex = 0;
            this.btnGoForm2.Text = "PUSH";
            this.btnGoForm2.UseVisualStyleBackColor = true;
            this.btnGoForm2.Click += new System.EventHandler(this.btnGoForm2_Click);
            // 
            // lblFileContact
            // 
            this.lblFileContact.AutoSize = true;
            this.lblFileContact.Location = new System.Drawing.Point(226, 172);
            this.lblFileContact.Name = "lblFileContact";
            this.lblFileContact.Size = new System.Drawing.Size(41, 18);
            this.lblFileContact.TabIndex = 1;
            this.lblFileContact.Text = "渡す";
            // 
            // lblReturn
            // 
            this.lblReturn.AutoSize = true;
            this.lblReturn.Location = new System.Drawing.Point(40, 153);
            this.lblReturn.Name = "lblReturn";
            this.lblReturn.Size = new System.Drawing.Size(44, 18);
            this.lblReturn.TabIndex = 2;
            this.lblReturn.Text = "返却";
            // 
            // txtFilePath
            // 
            this.txtFilePath.Location = new System.Drawing.Point(184, 44);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.Size = new System.Drawing.Size(154, 25);
            this.txtFilePath.TabIndex = 3;
            // 
            // lblFileContent
            // 
            this.lblFileContent.AutoSize = true;
            this.lblFileContent.Location = new System.Drawing.Point(160, 172);
            this.lblFileContent.Name = "lblFileContent";
            this.lblFileContent.Size = new System.Drawing.Size(43, 18);
            this.lblFileContent.TabIndex = 4;
            this.lblFileContent.Text = "label";
            // 
            // btnSelectFile
            // 
            this.btnSelectFile.BackColor = System.Drawing.Color.Yellow;
            this.btnSelectFile.Location = new System.Drawing.Point(606, 29);
            this.btnSelectFile.Name = "btnSelectFile";
            this.btnSelectFile.Size = new System.Drawing.Size(119, 33);
            this.btnSelectFile.TabIndex = 5;
            this.btnSelectFile.Text = "ファイル選択";
            this.btnSelectFile.UseVisualStyleBackColor = false;
            this.btnSelectFile.Click += new System.EventHandler(this.btnSelectFile_Click);
            // 
            // btnShowContent
            // 
            this.btnShowContent.BackColor = System.Drawing.Color.Yellow;
            this.btnShowContent.Location = new System.Drawing.Point(606, 68);
            this.btnShowContent.Name = "btnShowContent";
            this.btnShowContent.Size = new System.Drawing.Size(119, 32);
            this.btnShowContent.TabIndex = 6;
            this.btnShowContent.Text = "表示";
            this.btnShowContent.UseVisualStyleBackColor = false;
            this.btnShowContent.Click += new System.EventHandler(this.btnShowContent_Click);
            // 
            // btnFileUpdate
            // 
            this.btnFileUpdate.BackColor = System.Drawing.Color.Yellow;
            this.btnFileUpdate.Location = new System.Drawing.Point(606, 307);
            this.btnFileUpdate.Name = "btnFileUpdate";
            this.btnFileUpdate.Size = new System.Drawing.Size(119, 34);
            this.btnFileUpdate.TabIndex = 7;
            this.btnFileUpdate.Text = "ファイル更新";
            this.btnFileUpdate.UseVisualStyleBackColor = false;
            this.btnFileUpdate.Click += new System.EventHandler(this.btnFileUpdate_Click);
            // 
            // btnYellow
            // 
            this.btnYellow.BackColor = System.Drawing.Color.Yellow;
            this.btnYellow.ForeColor = System.Drawing.Color.Black;
            this.btnYellow.Location = new System.Drawing.Point(606, 172);
            this.btnYellow.Name = "btnYellow";
            this.btnYellow.Size = new System.Drawing.Size(75, 38);
            this.btnYellow.TabIndex = 8;
            this.btnYellow.Text = "Yellow";
            this.btnYellow.UseVisualStyleBackColor = false;
            this.btnYellow.Click += new System.EventHandler(this.btnYellow_Click);
            // 
            // btnBlue
            // 
            this.btnBlue.BackColor = System.Drawing.Color.Yellow;
            this.btnBlue.ForeColor = System.Drawing.Color.Black;
            this.btnBlue.Location = new System.Drawing.Point(606, 263);
            this.btnBlue.Name = "btnBlue";
            this.btnBlue.Size = new System.Drawing.Size(75, 38);
            this.btnBlue.TabIndex = 10;
            this.btnBlue.Text = "Blue";
            this.btnBlue.UseVisualStyleBackColor = false;
            this.btnBlue.Click += new System.EventHandler(this.btnBlue_Click);
            // 
            // lblClock
            // 
            this.lblClock.BackColor = System.Drawing.Color.Blue;
            this.lblClock.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClock.ForeColor = System.Drawing.Color.White;
            this.lblClock.Location = new System.Drawing.Point(40, 240);
            this.lblClock.Name = "lblClock";
            this.lblClock.Size = new System.Drawing.Size(361, 146);
            this.lblClock.TabIndex = 11;
            this.lblClock.Text = "00;00;00";
            this.lblClock.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblClock.Paint += new System.Windows.Forms.PaintEventHandler(this.lblClock_Paint);
            // 
            // tmrClock
            // 
            this.tmrClock.Interval = 1000;
            this.tmrClock.Tick += new System.EventHandler(this.tmrClock_Tick);
            // 
            // btnGoForm3
            // 
            this.btnGoForm3.Location = new System.Drawing.Point(606, 371);
            this.btnGoForm3.Name = "btnGoForm3";
            this.btnGoForm3.Size = new System.Drawing.Size(88, 33);
            this.btnGoForm3.TabIndex = 12;
            this.btnGoForm3.Text = "PUSH";
            this.btnGoForm3.UseVisualStyleBackColor = true;
            this.btnGoForm3.Click += new System.EventHandler(this.btnGoForm3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 18);
            this.label1.TabIndex = 13;
            this.label1.Text = "ファイル選択：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 18);
            this.label2.TabIndex = 14;
            this.label2.Text = "ファイル表示：";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGoForm3);
            this.Controls.Add(this.lblClock);
            this.Controls.Add(this.btnBlue);
            this.Controls.Add(btnGreen);
            this.Controls.Add(this.btnYellow);
            this.Controls.Add(this.btnFileUpdate);
            this.Controls.Add(this.btnShowContent);
            this.Controls.Add(this.btnSelectFile);
            this.Controls.Add(this.lblFileContent);
            this.Controls.Add(this.txtFilePath);
            this.Controls.Add(this.lblReturn);
            this.Controls.Add(this.lblFileContact);
            this.Controls.Add(this.btnGoForm2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGoForm2;
        private System.Windows.Forms.Label lblFileContact;
        private System.Windows.Forms.Label lblReturn;
        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.Label lblFileContent;
        private System.Windows.Forms.Button btnSelectFile;
        private System.Windows.Forms.Button btnShowContent;
        private System.Windows.Forms.Button btnFileUpdate;
        private System.Windows.Forms.Button btnYellow;
        private System.Windows.Forms.Button btnBlue;
        private System.Windows.Forms.Label lblClock;
        private System.Windows.Forms.Timer tmrClock;
        private System.Windows.Forms.Button btnGoForm3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

