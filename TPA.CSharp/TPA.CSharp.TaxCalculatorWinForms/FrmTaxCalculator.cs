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
    public partial class FrmTaxCalculator : Form
    {
        public FrmTaxCalculator()
        {
            InitializeComponent();
        }

        private void bCalculateBrutto_Click(object sender, EventArgs e)
        {
            decimal amountNetto = decimal.Parse(tNettoAmount.Text);
            decimal vat = decimal.Parse(tVAT.Text) / 100;

            decimal amountBrutto = amountNetto + amountNetto * vat;

            tAmountBrutto.Text = amountBrutto.ToString();



        }
    }
}
