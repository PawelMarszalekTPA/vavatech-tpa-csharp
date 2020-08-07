using OfficeOpenXml;
using OfficeOpenXml.Style;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text;
using TPA.CSharp.ExcelObrotowka.Models;

namespace TPA.CSharp.ExcelObrotowka
{

    // PM> Install-Package EPPlus -Version 4.5.3.3 

    // Dokumentacja: https://epplussoftware.com/en/Developers
    public class ExcelObrotowkaService
    {
        public IEnumerable<Account> Get(string filename)
        {
            throw new NotImplementedException();
        }


        public void Add(IEnumerable<Account> accounts, string filename)
        {
            ExcelPackage excelPackage = new ExcelPackage();

            ExcelWorksheet worksheet = excelPackage.Workbook.Worksheets.Add("Konta");

            worksheet.Cells[1, 1].LoadFromCollection(accounts, true);

            ExcelRange range = worksheet.Cells["A1:Z10"];
            range.Style.Font.Bold = true;
            range.Style.Fill.PatternType = ExcelFillStyle.Solid;
            range.Style.Fill.BackgroundColor.SetColor(Color.FromArgb(79, 129, 189));
            range.Style.Font.Color.SetColor(Color.White);

            FileInfo file = new FileInfo(filename);

            excelPackage.SaveAs(file);

        }

        public void HelloWorld(string filename)
        {
            ExcelPackage excelPackage = new ExcelPackage();

            ExcelWorksheet worksheet =  excelPackage.Workbook.Worksheets.Add("Konta");

            worksheet.Cells[1, 1].Value = "Hello World!";

            FileInfo file = new FileInfo(filename);

            excelPackage.SaveAs(file);
        }
    }
}
