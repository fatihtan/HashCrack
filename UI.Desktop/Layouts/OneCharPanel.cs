using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Desktop.Layouts
{
    [Obsolete("Not in usage")]
    public class OneCharPanel : FlowLayoutPanel
    {

        public OneCharPanel(int count, int width, int height)
        {
            setup(count);
            this.BackColor = Color.RoyalBlue;
            this.Width = width;
            this.Height = height;

            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
        }

        private void setup(int count)
        {
            for (int i = 0; i < count; i++)
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

                subPanel.Location = new Point(i + 1, 0);
                subPanel.Size = new System.Drawing.Size(54, 40);

                this.Controls.Add(subPanel);
                
            }
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            this.ResumeLayout(false);

        }
    }
}