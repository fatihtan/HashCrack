using Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Desktop
{
    public partial class FormExactChar : Form
    {
        public FormExactChar(int Count)
        {
            InitializeComponent();
            setup(Count);

            this.flowLayoutPanel.AutoScroll = true;
            this.flowLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            List<ExactChar> list = new List<ExactChar>();

            var controls = this.flowLayoutPanel.Controls;
            int i = 0;
            foreach (var c in controls)
            {
                var subPanel = (FlowLayoutPanel)c;
                var tb = subPanel.Controls.Find(string.Format("txtExactChar{0}", i++), false).FirstOrDefault();
                if (tb is TextBox)
                {
                    if (!string.IsNullOrEmpty(tb.Text))
                    {
                        tb.Text = removeDuplicates(tb.Text);
                    }

                    list.Add(new ExactChar((int)tb.Tag, tb.Text));
                }
            }

            FormMain.ExactCharList = list;
            this.Close();
        }

        private string removeDuplicates(string text)
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < text.Length; i++)
            {
                if (!sb.ToString().Contains(text[i]))
                {
                    sb.Append(text[i]);
                }
            }

            return sb.ToString();
        }

        private void setup(int Count)
        {
            for (int i = 0; i < Count; i++)
            {
                FlowLayoutPanel subPanel = new FlowLayoutPanel();

                TextBox tb = new TextBox();
                tb.Size = new System.Drawing.Size(35, 35);
                tb.Location = new System.Drawing.Point(10, 40);
                tb.TextAlign = HorizontalAlignment.Center;
                tb.Multiline = true;
                tb.Margin = new Padding(0, tb.Margin.Top, tb.Margin.Right, tb.Margin.Bottom);
                tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                tb.Tag = i;
                tb.Name = string.Format("txtExactChar{0}", i);
                if (FormMain.ExactCharList.Any() && FormMain.ExactCharList.Count > i)
                {
                    tb.Text = FormMain.ExactCharList[i].Chars;
                }

                Label lbl = new Label();
                lbl.Text = (i + 1).ToString();
                lbl.Size = new System.Drawing.Size(10, 40);
                lbl.TextAlign = ContentAlignment.MiddleCenter;
                lbl.BackColor = Color.Yellow;
                lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

                subPanel.Controls.Add(lbl);
                subPanel.Controls.Add(tb);

                subPanel.BackColor = Color.Red;
                subPanel.Location = new Point(i + 1, 0);
                
                subPanel.Size = new System.Drawing.Size(54, 40);

                this.flowLayoutPanel.Controls.Add(subPanel);
            }
        }
    }
}