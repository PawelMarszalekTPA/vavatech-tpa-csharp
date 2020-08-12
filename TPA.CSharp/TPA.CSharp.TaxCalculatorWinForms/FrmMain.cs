using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPA.CSharp.TaxCalculatorWinForms
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void bShowCalculator_Click(object sender, EventArgs e)
        {
            FrmTaxCalculator form = new FrmTaxCalculator();
            form.ShowDialog();   // okno modalne
        }

        private void bShowExporter_Click(object sender, EventArgs e)
        {
            FrmExporter form = new FrmExporter();
            form.Show(); // okno niemodalne
        }

        private void bShowDialog_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Czy chcesz anulować dokument?", "Anulowanie", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                MessageBox.Show("Anulowano dokument.");
            }
        }
    }
}
