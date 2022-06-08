using Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
        private readonly IComputationService _iComputationService;

        public static List<ExactChar> ExactCharList;

        public FormMain()
        {
            InitializeComponent();
            ExactCharList = new List<ExactChar>();
            this._iComputationService = new ComputationService();
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

        private void btnComputeTryCount_Click(object sender, EventArgs e)
        {
            var result = this._iComputationService.Compute(new Settings()
            {
                MinPasswordLength = (int)nudMinPasswordLength.Value,
                MaxPasswordLength = (int)nudMaxPasswordLength.Value,
                IncludeExactChar = cboxExactChar.Checked,
                ExactCharList = ExactCharList,
                IncludeCharsBigAZ = cboxCharsBigAZ.Checked,
                IncludeCharsSmallAZ = cboxCharsSmallAZ.Checked,
                IncludeCharsNumbers = cboxCharsNumbers.Checked,
                IncludeSpace = cboxIncludeSpace.Checked,
                IncludeAdditionalChars = cboxCharsAdditional.Checked,
                AdditionalChars = txtCharsAdditional.Text,
                CharsBigAZ = txtCharsBigAZ.Text,
                CharsSmallAZ = txtCharsSmallAZ.Text,
                CharsNumbers = txtCharsNumbers.Text
            });

            ulong totalTry = 0;
            foreach (var item in result)
            {
                totalTry += item.TryCount;
            }

            //MessageBox.Show(totalTry.ToString());
            txtOutput.Text = totalTry.ToString();

            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();

            for (int i = 0; i < 1000000; i++)
            {
                string foo = EncryptionUtility.MD5_ASCII(Guid.NewGuid().ToString());
            }

            stopWatch.Stop();

            Console.WriteLine(stopWatch);

            Console.WriteLine("test");
        }

        private void btnMachineTest_Click(object sender, EventArgs e)
        {
            FormMachineTest form = new FormMachineTest();
            form.ShowDialog();
        }
    }
}