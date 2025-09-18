using System;
using System.Drawing;
using System.Windows.Forms;

namespace YourNamespace
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();

            // 既定は Days
            rdoDays.Checked = true;
            UpdateUnitTitle();
            BuildComboItems();
            ReflectSelectionToLabel();

            ApplyCheckBoxStates();
            LoadDefaultImage();
            ApplyPictureBoxSizeMode();

            btnConfirmAll.BackColor = Color.Yellow;
            btnConfirmAll.ForeColor = Color.Black;
            btnConfirmAll.Enabled = false;
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
        private void ApplyCheckBoxStates()
        {
            cmbOptions.Enabled = chkComboConfirm.Checked;
            lblDays.Visible = chkLabelConfirm.Checked;

            btnConfirmAll.Enabled =
                chkRadioConfirm.Checked || chkComboConfirm.Checked || chkLabelConfirm.Checked;
        }

        private void LoadDefaultImage()
        {
            try
            {
                var path = @"C:\Users\Public\Pictures\Sample Pictures\test.jpg";
                if (System.IO.File.Exists(path))
                {
                    pic.Image?.Dispose();
                    pic.Image = Image.FromFile(path);
                }
            }
            catch {  }
        }

        private void rdoUnit_CheckedChanged(object sender, EventArgs e)
        {
            var rb = sender as RadioButton;
            if (rb == null || !rb.Checked) return;

            UpdateUnitTitle();
            BuildComboItems();
            ReflectSelectionToLabel();
        }

        private void UpdateUnitTitle()
        {
            lblUnitTitle.Text = rdoDays.Checked ? "Days" : "Years";
        }

        private void BuildComboItems()
        {
            cmbOptions.BeginUpdate();
            try
            {
                cmbOptions.Items.Clear();

                if (rdoDays.Checked)
                {
                    for (int i = 1; i <= 31; i++) cmbOptions.Items.Add(i.ToString());
                }
                else 
                {
                    for (int i = 1; i <= 10; i++) cmbOptions.Items.Add(i.ToString());
                }

                cmbOptions.SelectedIndex = -1;
            }
            finally { cmbOptions.EndUpdate(); }

            ReflectSelectionToLabel();
        }

        private void cmbOptions_SelectedIndexChanged(object sender, EventArgs e)
        {
            ReflectSelectionToLabel();
        }

        private void ReflectSelectionToLabel()
        {
            if (cmbOptions.SelectedItem == null)
            {
                lblDays.Text = string.Empty;
                return;
            }

            var unit = rdoDays.Checked ? "Days" : "Years";
            lblDays.Text = $"{cmbOptions.SelectedItem} {unit}";
        }

        private void rdoWeek_CheckedChanged(object sender, EventArgs e)
        {
            var rb = sender as RadioButton;
            if (rb != null && rb.Checked)
            {
                lblDays.Text = rb.Text;
            }
        }

        private void chkRadioConfirm_CheckedChanged(object sender, EventArgs e)
        {
            if (chkRadioConfirm.Checked)
            {
                string selected = "";
                foreach (Control ctrl in pnlWeek.Controls)
                {
                    if (ctrl is RadioButton r && r.Checked)
                    {
                        selected = r.Text;
                        break;
                    }
                }

                MessageBox.Show(selected != ""
                    ? $"選択されている曜日：{selected}"
                    : "曜日はまだ選択されていません");

                chkRadioConfirm.Checked = false; 
            }

            ApplyCheckBoxStates();
        }

        private void chkComboConfirm_CheckedChanged(object sender, EventArgs e)
        {
            if (chkComboConfirm.Checked)
            {
                if (cmbOptions.SelectedItem != null)
                {
                    string unit = rdoDays.Checked ? "日" : "年";
                    MessageBox.Show($"選択されているコンボ：{cmbOptions.SelectedItem}{unit}");
                }
                else
                {
                    MessageBox.Show("コンボボックスが未選択です");
                }
                chkComboConfirm.Checked = false;
            }

            ApplyCheckBoxStates();
        }

        private void chkLabelConfirm_CheckedChanged(object sender, EventArgs e)
        {
            if (chkLabelConfirm.Checked)
            {
                MessageBox.Show(
                    string.IsNullOrEmpty(lblDays.Text) ? "ラベルは空です" : $"現在のラベルの内容：{lblDays.Text}");
                chkLabelConfirm.Checked = false;
            }

            ApplyCheckBoxStates();
        }

        private void rdoSizeMode_CheckedChanged(object sender, EventArgs e)
        {
            var rb = sender as RadioButton;
            if (rb == null || !rb.Checked) return;
            ApplyPictureBoxSizeMode();
        }

        private void ApplyPictureBoxSizeMode()
        {
            if (rdoZoom.Checked) pic.SizeMode = PictureBoxSizeMode.Zoom;
            else if (rdoStretch.Checked) pic.SizeMode = PictureBoxSizeMode.StretchImage;
            else if (rdoCenter.Checked) pic.SizeMode = PictureBoxSizeMode.CenterImage;
        }

        private void btnLoadImage_Click(object sender, EventArgs e)
        {
            using (var ofd = new OpenFileDialog())
            {
                ofd.Title = "画像ファイルを選択してください。";
                ofd.Filter = "画像ファイル|*.jpg;*.jpeg;*.png;*.bmp;*.gif";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    pic.Image?.Dispose();
                    pic.Image = Image.FromFile(ofd.FileName);
                }
            }
        }

        private void btnConfirmAll_MouseEnter(object sender, EventArgs e)
        {
            btnConfirmAll.BackColor = Color.Black;
            btnConfirmAll.ForeColor = Color.Yellow;
        }

        private void btnConfirmAll_MouseLeave(object sender, EventArgs e)
        {
            btnConfirmAll.BackColor = Color.Yellow;
            btnConfirmAll.ForeColor = Color.Black;
        }

       
    }
}
