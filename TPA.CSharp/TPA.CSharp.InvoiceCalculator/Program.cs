using System;
using System.Runtime.CompilerServices;

namespace TPA.CSharp.InvoiceCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            CreateInvoiceTest2();
        }

        private static void CreateInvoiceTest1()
        {
            Customer customer = new Customer("Vavatech Sp. z o.o.");
            customer.invoiceAddress = new Address("Olesińska 18", "00-950", "Warszawa");
            customer.postAddress = new Address("Dworcowa 1", "00-001", "Warszawa");

            Invoice invoice = new Invoice("FV 100/2020", customer);
            //invoice.number = "FV 100/2020";
            // invoice.customer = customer;
            invoice.createdDate = DateTime.Now;
            invoice.dueDate = DateTime.Today.AddDays(14);

            Console.WriteLine(invoice.number);
            Console.WriteLine(invoice.createdDate);
            Console.WriteLine(invoice.customer.name);

            Console.WriteLine($"{invoice.customer.invoiceAddress}");
            Console.WriteLine(invoice.customer.postAddress);
        }

        private static void CreateInvoiceTest2()
        {
            Customer customer = new Customer("Vavatech Sp. z o.o.");
            customer.invoiceAddress = new Address("Olesińska 18", "00-950", "Warszawa");
            customer.postAddress = new Address("Dworcowa 1", "00-001", "Warszawa");

            Invoice invoice = new Invoice("FV 100/2020", customer);

            //if (invoice.Status == InvoiceStatus.Created)
            //{
            //    invoice.Status = InvoiceStatus.Posted;
            //    invoice.postedDate = DateTime.Now;
            //}

            Console.WriteLine(invoice.Status);

            invoice.Post();

            Console.WriteLine(invoice.Status);

            int status = (int)invoice.Status;

            invoice.Cancel();

            invoice.Send("marcin.sulecki@gmail.com");

            Console.WriteLine(invoice.Status);

            Console.WriteLine(invoice.number);
            Console.WriteLine(invoice.createdDate);
            Console.WriteLine(invoice.customer.name);
            Console.WriteLine(invoice.Status);


            //Console.WriteLine($"{invoice.customer.invoiceAddress.street} {invoice.customer.invoiceAddress.postCode} {invoice.customer.invoiceAddress.city}");

            // Console.WriteLine($"{invoice.customer.postAddress.street} {invoice.customer.postAddress.postCode} {invoice.customer.postAddress.city}");

            Console.WriteLine(invoice.customer.invoiceAddress);
            Console.WriteLine(invoice.customer.postAddress);
        }
    }
}
