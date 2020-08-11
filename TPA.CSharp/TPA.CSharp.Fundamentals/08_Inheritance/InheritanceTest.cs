using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.Design;
using System.Runtime.InteropServices.ComTypes;
using System.Text;

namespace TPA.CSharp.Fundamentals.Inheritance
{

    public class InheritanceTest
    {
        public static void Test()
        {
            InvoiceTest();

            ProductTest();

        }

        private static void ProductTest()
        {
            Product product = new Product();
            product.Name = "Product 1";
            product.Color = "Red";
            product.UnitPrice = 0.99m;

            DocumentDetail documentDetail = new DocumentDetail();
            documentDetail.Item = product;
            documentDetail.Quantity = 5;

            Console.WriteLine(documentDetail.Item);
        }

        private static void InvoiceTest()
        {
            Invoice document = new Invoice();
            document.Number = "Dok 24/2020";
            document.TotalAmount = 100;
            document.Tax = 23;

            Invoice invoice = new Invoice();
            invoice.Number = "FV 100/2020";
            invoice.CreatedDate = DateTime.Today;
            invoice.DueDate = invoice.CreatedDate.AddDays(14);
            invoice.Customer = "TPA";
            invoice.TotalAmount = 1000;

            invoice.Print();

            Correction correction = new Correction();
            correction.Number = "KOR 1/2020";
            correction.CreatedDate = DateTime.Today;
            correction.DueDate = correction.CreatedDate.AddDays(14);
            correction.Customer = "TPA";
            correction.TotalAmount = 1100;
            correction.CorrectedInvoiceNumber = invoice.Number;
            correction.CorrectedInvoiceCreateDate = invoice.CreatedDate;
            correction.Note = "Uwagi";

            correction.Print();

            Collection<Document> documents = new Collection<Document>();
            documents.Add(document);
            documents.Add(invoice);
            documents.Add(correction);

            foreach (Document currentDocument in documents)
            {
                currentDocument.Print();    // poliformizm

                // if (typeof(Document))==Invoice
                // Invoice.Print();
                // if (typeof(Document))==Correction
                // Correction.Print();
                // if (typeof(Document))==Bill
                // Bill.Print();
            }
        }
    }


   

}
