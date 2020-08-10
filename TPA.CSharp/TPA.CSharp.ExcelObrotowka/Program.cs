using OfficeOpenXml.FormulaParsing.Excel.Functions.Math;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using TPA.CSharp.ExcelObrotowka.Models;

namespace TPA.CSharp.ExcelObrotowka
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            CsvObrotowkaService obrotowkaService = new CsvObrotowkaService();

            IEnumerable<Account> accounts = obrotowkaService.Get("Obrotówka.csv");

            ExcelObrotowkaService excelObrotowkaService = new ExcelObrotowkaService();
        //    excelObrotowkaService.HelloWorld("hello.xlsx");
            excelObrotowkaService.Add(accounts, "output-obrotowka.xlsx");

            IEnumerable<Account> accountsFromExcel = excelObrotowkaService.Get("Obrotówka.xlsx");

            foreach (Account account in accountsFromExcel)
            {
                Console.WriteLine(account);
            }
        }
    }
}
