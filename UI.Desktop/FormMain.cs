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
using UI.Desktop.Layouts;

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
            Control control = (Control)this.Controls.Find(cb.Tag.ToString(), false).FirstOrDefault();
            if (control == null)
                return;

            control.Enabled = cb.Checked;

            if (cb == cboxIncludeSpace && control.Enabled)
                control.Text = "Space is included";
            else if (cb == cboxIncludeSpace && !control.Enabled)
                control.Text = "Space is NOT included";
        }

        private void btnStart_Click(object sender, EventArgs e)
        {

        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            cboxEncryptionAlgorithm.DataSource = TypeService.GetList(TK.TKEncrytionAlgorithm.Undefined);
        }

        private void btnSetExactChar_Click(object sender, EventArgs e)
        {
            FormExactChar form = new FormExactChar((int)nudMaxPasswordLength.Value);
            form.ShowDialog();
        }
    }
}