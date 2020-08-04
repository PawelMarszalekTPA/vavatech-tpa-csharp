using System;
using System.Runtime.CompilerServices;

namespace TPA.CSharp.InvoiceCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Customer customer = new Customer();
            customer.name = "Vavatech Sp. z o.o.";
            customer.street = "Olesińska 18";
            customer.postCode = "00-950";
            customer.city = "Warszawa";

            Invoice invoice = new Invoice();
            invoice.number = "FV 100/2020";
            invoice.customer = customer;
            invoice.createdDate = DateTime.Now;
            invoice.dueDate = DateTime.Today.AddDays(14);

            Console.WriteLine(invoice.number);
            Console.WriteLine(invoice.createdDate);
            Console.WriteLine(invoice.customer.name);
            Console.WriteLine($"{invoice.customer.street} {invoice.customer.postCode} {invoice.customer.city}");
        }
    }
}
