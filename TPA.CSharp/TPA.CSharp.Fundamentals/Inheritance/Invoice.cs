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


    public abstract class Document
    {
        public string Number { get; set; }          // właściwość (property)
        public DateTime CreatedDate { get; set; }
        public DateTime DueDate { get; set; }
        public decimal TotalAmount { get; set; }
        public string Customer { get; set; }
        public string Note { get; set; }
        public virtual void Print()
        {
            Console.WriteLine($"Document {Number}");
        }
    }


    public class Bill : Document
    {
        public override void Print()
        {
            Console.WriteLine($"Rachunek {Number}");
        }
    }


    public class Invoice : Document
    {
        public decimal Tax { get; set; }

        public void Send(string email)
        {
            Console.WriteLine($"Sending {email}");
        }

        public override void Print()
        {
            Console.WriteLine($"Faktura {Number}");
        }


    }

    // Dziedziczenie

    // Klasa potomna : Klasa bazowa

    public class Correction : Invoice
    {
        public DateTime CorrectedInvoiceCreateDate { get; set; }
        public string CorrectedInvoiceNumber { get; set; }

        public override void Print()
        {
        }

    }


    //public class Correction
    //{
    //    public string Number { get; set; }
    //    public DateTime CreatedDate { get; set; }
    //    public DateTime DueDate { get; set; }
    //    public decimal TotalAmount { get; set; }
    //    public string Customer { get; set; }

    //    public DateTime CorrectedInvoiceCreateDate { get; set; }
    //    public string CorrectedInvoiceNumber { get; set; }

    //    public void Print()
    //    {
    //        Console.WriteLine($"Korekta {Number}");
    //    }

    //    public void Send(string email)
    //    {
    //        Console.WriteLine($"Sending {email}");
    //    }

    //}

}
