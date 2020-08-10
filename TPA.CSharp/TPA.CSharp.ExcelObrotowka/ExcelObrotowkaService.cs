﻿using OfficeOpenXml;
using OfficeOpenXml.Style;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Drawing;
using System.IO;
using System.Linq;
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
            FileInfo file = new FileInfo(filename);
            ExcelPackage excelPackage = new ExcelPackage(file);

            ExcelWorksheet worksheet = excelPackage.Workbook.Worksheets.FirstOrDefault();

            int rows = worksheet.Dimension.Rows;
            int columns = worksheet.Dimension.Columns;

            Collection<Account> accounts = new Collection<Account>();

            for(int i=2; i<=rows; i++)
            {
                // TODO: przenieść mapowanie do osobnej metody

                Account account = new Account();

                string symbol = worksheet.Cells[i, 1].Value.ToString();
                string nazwa = worksheet.Cells[i, 2].Value.ToString();
                decimal saldoBOWn = decimal.Parse(worksheet.Cells[i, 3].Value.ToString());
                decimal saldoBOMa = decimal.Parse(worksheet.Cells[i, 4].Value.ToString());
                decimal obrotyWn = decimal.Parse(worksheet.Cells[i, 5].Value.ToString());
                decimal obrotyMa = decimal.Parse(worksheet.Cells[i, 6].Value.ToString());
                decimal obrotyNWn = decimal.Parse(worksheet.Cells[i, 7].Value.ToString());
                decimal obrotyNMa = decimal.Parse(worksheet.Cells[i, 8].Value.ToString());
                decimal saldoWn = decimal.Parse(worksheet.Cells[i, 9].Value.ToString());
                decimal saldoMa = decimal.Parse(worksheet.Cells[i, 10].Value.ToString());
                decimal perSaldo = decimal.Parse(worksheet.Cells[i, 11].Value.ToString());

                account.Symbol = symbol;
                account.Name = nazwa;
                account.SaldoBOWn = saldoBOWn;
                account.SaldoBOMa = saldoBOMa;
                account.ObrotyWn = obrotyWn;
                account.ObrotyMa = obrotyMa;
                account.ObrotyNWn = obrotyNWn;
                account.ObrotyNMa = obrotyNMa;
                account.SaldoWn = saldoWn;
                account.SaldoMa = saldoMa;
                account.PerSaldo = perSaldo;

                accounts.Add(account);

                //for (int j=1; j<=columns; j++)
                //{
                //    string content = worksheet.Cells[i, j].Value.ToString();

                //    Console.WriteLine(content);
                //}
            }

            return accounts;

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
