using System;

namespace TPA.CSharp.OrderCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // snippet: cw + 2 x Tab
            Console.WriteLine("Hello Order Calculator");
       
            Console.Write("Podaj cenę: ");
            decimal unitPrice = decimal.Parse(Console.ReadLine());

            Console.Write("Podaj ilość: ");

            bool isValid = int.TryParse(Console.ReadLine(), out int quantity);

            if (isValid)
            {
                decimal totalAmount = CalculateTotalAmount(unitPrice, quantity);

                Console.WriteLine($"Cena całkowita: {totalAmount}");
            }
            else
            {
                Console.WriteLine("Błędne dane");
            }

            Console.WriteLine("Koniec działania programu");
           
        }

        static decimal CalculateTotalAmount(decimal unitPrice, int quantity)
        {
            decimal totalAmount = unitPrice * quantity;

            return totalAmount;
        }
    }
}
