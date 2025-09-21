using System;
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
    public partial class Form2 : Form
    {
        public string ReturnValue { get; private set; } = "";
        public Form2(string formForm1Value)
        {
            InitializeComponent();
            lblfromForm1.Text = formForm1Value ?? "";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            var ret = (txtJoin.Text ?? "").Trim();
            if (ret.Length > 0) this.ReturnValue = ret;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnSplit_Click(object sender, EventArgs e)
        {
            var src = (lblfromForm1.Text ?? "").Trim();

            var parts = (src.Length == 0)
                ? new string[0]
                : src.Split(new[] { ',', '，' }, StringSplitOptions.RemoveEmptyEntries);

            string p1 = parts.Length > 0 ? parts[0].Trim() : "";
            string p2 = parts.Length > 1 ? parts[1].Trim() : "";
            string p3 = parts.Length > 2 ? parts[2].Trim() : "";
            string p4 = parts.Length > 3 ? parts[3].Trim() : "";

            txt1.Text = p1;
            txt2.Text = p2;
            txt3.Text = p3;
            txt4.Text = p4;
        }

        private void btnTrimEdge_Click(object sender, EventArgs e)
        {
            foreach (var tb in new[] { txt1, txt2, txt3, txt4 })
            {
                tb.Text = (tb.Text ?? "").Trim();
            }
        }

        private void btnTrimAll_Click(object sender, EventArgs e)
        {

        }

        private void btnJoin_Click(object sender, EventArgs e)
        {
            var list = new System.Collections.Generic.List<string>();
            foreach (var tb in new[] { txt1, txt2, txt3, txt4 })
            {
                var s = (tb.Text ?? "").Trim();
                if (s.Length > 0) list.Add(s);
            }

            var joined = string.Join(", ", list.ToArray());
            txtJoin.Text = joined;

            this.ReturnValue = joined;
        }

        private void btnLoop_Click(object sender, EventArgs e)
        {
            rtbResult.Clear();
            int n = (int)nudSteps.Value;

            for (int i = 0; i < n; i++)
            {
                System.Text.StringBuilder sb = new System.Text.StringBuilder();
                for (int d = 0; d <= i; d++)
                {
                    sb.Append(d.ToString());
                }
                rtbResult.AppendText(sb.ToString() + Environment.NewLine);
            }
        }

        private void UpdateResult()
        {
           rtbResult.Text = $"{txt1.Text},{txt2.Text},{txt3.Text},{txt4.Text}";

           int steps = (int)nudSteps.Value;
              rtbResult.AppendText($"\nSteps: {steps}");
        }

        private void txt1_TextChanged(object sender, EventArgs e)
        {
            UpdateResult();
        }

        private void txt2_TextChanged(object sender, EventArgs e)
        {
            UpdateResult();
        }

        private void txt3_TextChanged(object sender, EventArgs e)
        {
            UpdateResult();
        }

        private void txt4_TextChanged(object sender, EventArgs e)
        {
            UpdateResult();
        }

        private void nudSteps_ValueChanged(object sender, EventArgs e)
        {
            UpdateResult();
        }
    }


}
