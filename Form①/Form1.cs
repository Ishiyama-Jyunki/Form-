using System;
using System.IO;
using YourNamespace;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            btnGoForm3.Cursor = Cursors.Hand;

            tmrClock.Interval = 1000;
            tmrClock.Start();
            lblClock.Text = "00:00:00";
        }

        private void tmrClock_Tick(object sender, EventArgs e)
        {
            lblClock.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void btnGoForm2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Form2を開きます。よろしいですか？", "確認",
                     MessageBoxButtons.OKCancel, MessageBoxIcon.Question) != DialogResult.OK) return;

            var valueToSend = lblFileContent.Text ?? "";
            using (var f2 = new Form2(lblFileContent.Text))
            {
                if (f2.ShowDialog(this) == DialogResult.OK)
                {


                    lblReturn.Text = f2.ReturnValue ?? "";
                }
            }
        }

        

        private void btnSelectFile_Click(object sender, EventArgs e)
        {
            using (var dlg = new OpenFileDialog())
            {
                dlg.Title = "ファイルを選択してください";
                dlg.Filter = "テキスト|*.txt;*.log;*.csv|すべてのファイル|*.*";
                dlg.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                dlg.CheckFileExists = false;  
                dlg.Multiselect = false;

                if (dlg.ShowDialog(this) == DialogResult.OK)
                {
                    txtFilePath.Text = dlg.FileName;
                }
            }
        }



        private void btnFileUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtFilePath.Text))
                {
                    MessageBox.Show("ファイルを選択してください。");
                    return;
                }

                if (MessageBox.Show("書き換えしてよろしいですか？", "確認", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
                    != DialogResult.OK)
                {
                    return;
                }

                if (!File.Exists(txtFilePath.Text))
                {
                    MessageBox.Show("ファイルが存在しません。");
                    return;
                }

                File.WriteAllText(txtFilePath.Text, GroupBox1.Text ?? "");
                MessageBox.Show("更新しました。");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"更新に失敗しました: {ex.Message}");
            }
        }


        private void btnShowContent_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtFilePath.Text))
                {
                    MessageBox.Show("ファイルを選択してください。");
                    return;
                }
                if (!File.Exists(txtFilePath.Text))
                {
                    MessageBox.Show("ファイルが存在しません。");
                    return;
                }

                lblFileContent.Text = File.ReadAllText(txtFilePath.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"読み込みに失敗しました: {ex.Message}");
            }
        }


        private void btnYellow_Click(object sender, EventArgs e)
        {
            GroupBox1.BackColor = Color.Yellow;
        }

        private void btnGreen_Click(object sender, EventArgs e)
        {
            GroupBox1.BackColor = Color.Lime;
        }

        private void btnBlue_Click(object sender, EventArgs e)
        {
            GroupBox1.BackColor = Color.Aqua;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tmrClock.Interval = 1000;
            tmrClock.Enabled = true;
            lblClock.AutoSize = false;
            lblClock.TextAlign = ContentAlignment.MiddleCenter;
        }

        private void TmrClock_Tick(object sender, EventArgs e)
        {
            lblClock.Text = DateTime.Now.ToString("HH:mm:ss");
            lblClock.Invalidate(); 
        }

        private void lblClock_Paint(object sender, PaintEventArgs e)
        {
            using (var brush = new System.Drawing.Drawing2D.LinearGradientBrush(
                       lblClock.ClientRectangle, Color.LightSkyBlue, Color.White, 90f))
            {
                e.Graphics.FillRectangle(brush, lblClock.ClientRectangle);
            }

            using (var f = new Font("メイリオ", 32, FontStyle.Bold))
            {
                var s = DateTime.Now.ToString("HH:mm:ss");
                var sz = e.Graphics.MeasureString(s, f);
                e.Graphics.DrawString(
                    s, f, Brushes.Black,
                    (lblClock.Width - sz.Width) / 2f,
                    (lblClock.Height - sz.Height) / 2f
                );
            }
        }

        private void btnGoForm3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Form3を開きます。よろしいですか？", "確認",
                     MessageBoxButtons.OKCancel, MessageBoxIcon.Question) != DialogResult.OK) return;

            using (var f3 = new Form3())
            {
                f3.ShowDialog(this);
            }
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }
    }
}
