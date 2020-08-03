using System;
using System.Runtime.InteropServices.ComTypes;

namespace TPA.CSharp.HelloWorld
{

    /// <summary>
    /// Program służący do generowania sprawozdania finansowego
    /// </summary>
    class Program
    {
        // Debugger

        // Metoda
        static void Main(string[] args)
        {
            Console.WriteLine("Hello TPA!");

            Console.Write("Podaj wartość faktury: ");
            decimal totalAmount = decimal.Parse(Console.ReadLine());

            if (totalAmount>1000)
            {
                Console.WriteLine("Kwota większa od 1000");
            }
            else
            {
                Console.WriteLine("Kwota mnniejsza od 1000");
            }



            // GenerateReport();

            Console.Write("Podaj kwotę netto: ");
            decimal amount = decimal.Parse(Console.ReadLine());

            Console.Write("Podaj stawkę VAT: (np. 23, 7)");

            decimal tax = decimal.Parse(Console.ReadLine());

            tax = tax / 100;

            decimal grossAmount = CalculateGrossAmount(amount, tax);

            Console.WriteLine(grossAmount);

        }



        // Parametr opcjonalny
        private static decimal CalculateGrossAmount(decimal amount, decimal tax = 0.23m) 
        {
            decimal grossAmount = amount + amount * tax;

            return grossAmount;
        }

        // Przeciążanie metod
        //private static decimal CalculateGrossAmount(decimal amount)
        //{
        //    decimal grossAmount = amount + amount * 0.23m;

        //    return grossAmount;
        //}




        private static string GenerateReport(string reportName, DateTime from, DateTime to)
        {
            string message = $"Generowanie raportu {reportName} za okres od {from:yyyy-MM-dd} do {to:yyyy-MM-dd}";

            return message;
        }


        private static void GenerateReport()
        {
            Console.Write("Podaj nazwę raportu: ");

            string reportName = Console.ReadLine();

            Console.Write("Podaj ilość dni: ");

            byte days = byte.Parse(Console.ReadLine());

            // Typy daty
            DateTime from = DateTime.Today;
            DateTime to = from.AddDays(days);

            // konkatencja ciągu tekstowego 

            // string message = "Generowanie raportu " + reportName + " za okres od " + from + " do " + to;

            // string message = string.Format("Generowanie raportu {0} za okres od {1:yyyy-MM-dd} do {2:yyyy-MM-dd}", reportName, from, to);

            string message = $"Generowanie raportu {reportName} za okres od {from:yyyy-MM-dd} do {to:yyyy-MM-dd}";

            Console.WriteLine(message);
        }

        private static void Types()
        {
            // Strong-typed - język silnie-typowane

            // komentarz

            // typy całkowite
            // https://docs.microsoft.com/pl-pl/dotnet/csharp/language-reference/builtin-types/integral-numeric-types

            int quantity = 10; // liczba całkowita
            byte age = 110;
            short counter = 21000;

            /*
                komentarz blokowy
                komentarz blokowy
                komentarz blokowy
            */


            // Typy zmiennoprzecinkowe 
            // https://docs.microsoft.com/pl-pl/dotnet/csharp/language-reference/builtin-types/floating-point-numeric-types
            decimal saldo = 100.99m;
            float weight = 10.5f;
        }
    }
}
