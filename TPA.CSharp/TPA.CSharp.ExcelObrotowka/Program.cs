using OfficeOpenXml.FormulaParsing.Excel.Functions.Math;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
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

            //foreach (Account account in accountsFromExcel)
            //{
            //    Console.WriteLine(account);
            //}

            // TODO: pobierz i wyświetl tylko te konta, których saldo jest powyżej 0 PLN

            ICollection<Account> filteredAccounts = new Collection<Account>();

            // filtrowanie accountsFromExcel

            foreach (Account account in accountsFromExcel)
            {
                // && - operator logiczny AND (iloczyn logiczny)
                // || - operator logiczny OR (suma logiczna)

                if (account.PerSaldo > 0 && account.Symbol.StartsWith("1"))
                {
                    filteredAccounts.Add(account);
                }
            }


            // C#   Linq -> Entity Framework -> SQL -> Database

            // C#   Linq -> Soneta -> ...... Database

            // Linq (język do operacji na zbiorach danych)

            // Linq != lambda

            IEnumerable<Account> filteredAccountLinq = accountsFromExcel
                .Where(account => account.PerSaldo > 0 && account.Symbol.StartsWith("2"))
                .OrderBy(account => account.Symbol)
                .Take(5);

            int count = filteredAccountLinq.Count();

            Account account1 = filteredAccountLinq.First();

            decimal totalPerSaldo = filteredAccountLinq.Sum(account => account.PerSaldo);

            // wyświetl filteredAccount
            foreach (Account account in filteredAccountLinq)
            {
                Console.WriteLine(account);
            }

            var query = accountsFromExcel
                .GroupBy(account => account.Symbol.Substring(0,1))
                .Select(group => new { Symbol = group.Key, TotalPerSaldo = group.Sum(account => account.PerSaldo)})
                .ToList();

            foreach (var group in query)
            {
                Console.WriteLine($"{group.Symbol} {group.TotalPerSaldo}");
            }

            excelObrotowkaService.UpdateTest(accountsFromExcel);
        }
    }
}
