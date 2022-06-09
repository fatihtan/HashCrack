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

namespace UI.Desktop
{
    public partial class FormMachineTest : Form
    {
        public FormMachineTest()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            decimal average = 0;
            for (int i = 0; i < nudLaps.Value; i++)
            {
                Stopwatch stopWatch = new Stopwatch();
                stopWatch.Start();
                for (int j = 0; j < nudGuidCount.Value; j++)
                {
                    EncryptionUtility.MD5_ASCII(Guid.NewGuid().ToString());
                }
                stopWatch.Stop();

                average += stopWatch.ElapsedTicks;
            }

            average /= nudLaps.Value;
            MessageBox.Show(average + "");
        }
    }
}