using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TPA.CSharp.Models;
using TPA.CSharp.ObrotowkaService;
using TPA.CSharp.ObrotowkaService.Models;

namespace TPA.CSharp.TaxCalculatorWinForms
{
    public partial class FrmExporter : Form
    {
        private ExcelObrotowkaService obrotowkaService;

        public FrmExporter()
        {
            InitializeComponent();

            obrotowkaService = new ExcelObrotowkaService();

            //dDateFrom.Value = new DateTime(DateTime.Today.Year, DateTime.Today.AddMonths(-1).Month, 1);
            //dDateTo.Value = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1).AddDays(-1);

            dDateFrom.Value = obrotowkaService.GetMinDate();
            dDateTo.Value = obrotowkaService.GetMaxDate();

            IEnumerable<Account> accounts = obrotowkaService.Get();

            foreach (Account account in accounts)
            {
                cAccount.Items.Add(account.Symbol);
            }

        }

        private void bSaveToCSV_Click(object sender, EventArgs e)
        {
            string selectedAccount = (string)cAccount.SelectedItem;

            if (sfdCSV.ShowDialog() == DialogResult.OK)
            {
                sfdCSV.DefaultExt = "xlsx";

                string filename = sfdCSV.FileName;

                obrotowkaService.Save(filename);

                Mapper mapper = new Mapper();
            }
        }

        // Data Binding
    }
}
