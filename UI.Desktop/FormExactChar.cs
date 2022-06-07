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

        private void btnStart_Click(object sender, EventArgs e)
        {
            
        }

        private void setup(int Count)
        {
            for (int i = 0; i < Count; i++)
            {
                FlowLayoutPanel subPanel = new FlowLayoutPanel();

                TextBox tb = new TextBox();
                tb.MaxLength = 1;
                tb.Size = new System.Drawing.Size(35, 35);
                tb.Location = new System.Drawing.Point(10, 40);
                tb.TextAlign = HorizontalAlignment.Center;
                tb.Multiline = true;
                tb.Margin = new Padding(0, tb.Margin.Top, tb.Margin.Right, tb.Margin.Bottom);
                tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

                Label lbl = new Label();
                lbl.Text = (i + 1).ToString();
                lbl.Size = new System.Drawing.Size(10, 40);
                lbl.TextAlign = ContentAlignment.MiddleCenter;
                lbl.BackColor = Color.Yellow;
                lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

                subPanel.Controls.Add(lbl);
                subPanel.Controls.Add(tb);

                subPanel.BackColor = Color.Red;

                if (i % 10 == 0)
                {
                    subPanel.Location = new Point(i + 10, 0);
                }
                else
                {
                    subPanel.Location = new Point(i + 1, 0);
                }
                
                subPanel.Size = new System.Drawing.Size(54, 40);

                this.flowLayoutPanel.Controls.Add(subPanel);
            }
        }
    }
}