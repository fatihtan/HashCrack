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
        public static List<ExactChar> ExactCharList;
        private readonly ISettingsService _iSettingsService;

        public FormMain()
        {
            InitializeComponent();
            
            ExactCharList = new List<ExactChar>();
            this._iSettingsService = new SettingsService();
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
            if (this.nudMinPasswordLength.Value > this.nudMaxPasswordLength.Value)
            {
                MessageBox.Show("Min Password Length has to be equal to or greater than Max Password Length.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            FormExactChar form = new FormExactChar((int)nudMaxPasswordLength.Value);
            form.ShowDialog();

            this.txtExactChar.Text = ExactChar.ToString(ExactCharList);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.FileName = string.Format("hash-crack-{0}.txt", DateTime.UtcNow.ToString("yyyy-MM-dd HH.mm.ss.fff"));
            sfd.Filter = "Text Files|*.txt";
            DialogResult dr = sfd.ShowDialog();
            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                Settings settings = this.PackSettings();
                if (this._iSettingsService.Save(settings, sfd.FileName))
                {
                    MessageBox.Show("File has been saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {

        }

        private Settings PackSettings()
        {
            Settings settings = new Settings();

            settings.TKEncrytionAlgorithm = (TK.TKEncrytionAlgorithm)((TypeValue)cboxEncryptionAlgorithm.SelectedItem).Value;
            settings.Output = txtOutput.Text;
            settings.MinPasswordLength = Convert.ToInt32(nudMinPasswordLength.Value);
            settings.MaxPasswordLength = Convert.ToInt32(nudMaxPasswordLength.Value);
            
            settings.IsExactCharDefined = cboxExactChar.Checked;
            settings.ExactCharList = ExactCharList;
            
            settings.IncludeCharsBigAZ = cboxCharsBigAZ.Checked;
            settings.CharsBigAZ = txtCharsBigAZ.Text;

            settings.IncludeCharsSmallAZ = cboxCharsSmallAZ.Checked;
            settings.CharsSmallAZ = txtCharsSmallAZ.Text;

            settings.IncludeCharsNumbers = cboxCharsNumbers.Checked;
            settings.CharsNumbers = txtCharsNumbers.Text;

            settings.IncludeSpace = cboxIncludeSpace.Checked;
            settings.IncludeCharsAdditional = cboxIncludeCharsAdditional.Checked;
            settings.CharsAdditional = txtCharsAdditional.Text;

            return settings;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {

        }
    }
}