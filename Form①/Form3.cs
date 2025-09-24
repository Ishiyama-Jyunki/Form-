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

            
            rdoDays.Checked = true;
            UpdateUnitTitle();
            BuildComboItems();
            ReflectSelectionToLabel();

            ApplyCheckBoxStates();
            LoadDefaultImage();
            ApplyPictureBoxSizeMode();

           
        }

        private void Form3_Load(object sender, EventArgs e)
        {

            btnConfirmAll.BackColor = Color.Yellow;
            btnConfirmAll.ForeColor = Color.Black;
            btnConfirmAll.Cursor = Cursors.Hand;

            if (!rdoDays.Checked && !rdoYears.Checked) rdoDays.Checked = true; 
            BuildComboItems();           
            UpdateUnitTitle();
            cmbOptions.SelectedIndex = -1;
        }
        private void ApplyCheckBoxStates()
        {
            
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

           
            BuildComboItems();
            cmbOptions.SelectedIndex = -1;
            UpdateUnitTitle();
        }

        private void UpdateUnitTitle()
        {
            lblUnitTitle.Text = cmbOptions.SelectedItem is string s ? s : (rdoDays.Checked ? "Days" : "Years");
               
        }

        private void BuildComboItems()
        {
            cmbOptions.BeginUpdate();
            try
            {
                cmbOptions.Items.Clear();
                if (rdoDays.Checked)
                    cmbOptions.Items.AddRange(new[] { "Mon", "Tue", "Wed", "Thu", "Fri", "Sat", "Sun" });
                else
                    cmbOptions.Items.AddRange(new[] { "Jan.", "Feb.", "Mar.", "Apr.", "May.", "Jun.",
                                              "Jul.", "Aug.", "Sep.", "Oct.", "Nov.", "Dec." });
            }
            finally { cmbOptions.EndUpdate(); }


        }


        private void cmbOptions_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateUnitTitle();
        }

        private void ReflectSelectionToLabel()
        {
            if (cmbOptions.SelectedItem == null)
            {
                lblUnitTitle.Text = string.Empty;
                return;
            }

            lblUnitTitle.Text = cmbOptions.SelectedItem.ToString();
        }

        private void rdoWeek_CheckedChanged(object sender, EventArgs e)
        {
            var rb = sender as RadioButton;
            if (rb != null && rb.Checked)
            {
                label2.Text = rb.Text;
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
                
            }

            ApplyCheckBoxStates();
        }

        private void chkLabelConfirm_CheckedChanged(object sender, EventArgs e)
        {
            if (!chkLabelConfirm.Checked) return;

            if (!string.IsNullOrEmpty(lblDays.Text))
                MessageBox.Show($"現在のラベルの内容: {lblDays.Text}");
            else
                MessageBox.Show("ラベルは空です");

            

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

        private void btnConfirmAll_Click(object sender, EventArgs e)
        {
            MessageBox.Show("チェック完了！");
        }

        private static readonly string[] WeekDays =
    { "Mon", "Tue", "Wed", "Thu", "Fri", "Sat", "Sun" };

        private static readonly string[] Months =
            { "Jan.", "Feb.", "Mar.", "Apr.", "May", "Jun.",
      "Jul.", "Aug.", "Sep.", "Oct.", "Nov.", "Dec." };
    }
}
