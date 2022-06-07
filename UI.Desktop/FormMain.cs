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
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void cboxChars_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cb = (CheckBox)sender;
            TextBox tb = (TextBox)this.Controls.Find(cb.Tag.ToString(), false).FirstOrDefault();
            if (tb == null)
                return;

            tb.Enabled = cb.Checked;

            if (cb == cboxIncludeSpace && tb.Enabled)
            {
                tb.Text = "Space is included";
            }
            else if (cb == cboxIncludeSpace && !tb.Enabled)
            {
                tb.Text = "Space is NOT included";
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {

        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            cboxEncryptionAlgorithm.DataSource = TypeService.GetList(TK.TKEncrytionAlgorithm.Undefined);
        }


    }
}