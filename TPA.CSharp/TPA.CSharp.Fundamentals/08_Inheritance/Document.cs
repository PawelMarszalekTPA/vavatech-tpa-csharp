using System;

namespace TPA.CSharp.Fundamentals.Inheritance
{
    public abstract class Document
    {
        public string Number { get; set; }          // właściwość (property)
        public DateTime CreatedDate { get; set; }
        public DateTime DueDate { get; set; }
        public decimal TotalAmount { get; set; }
        public string Customer { get; set; }
        public string Note { get; set; }
        public string User { get; set; }
        public virtual void Print()
        {
            Console.WriteLine($"Document {Number}");
        }

        public override string ToString()
        {
            return $"Number: {Number} Created At: {CreatedDate} Total: {TotalAmount} Customer: {Customer} Note: {Note} User: {User}";
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

        public override string ToString()
        {
            return base.ToString() + $"VAT: {Tax}";
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


        public override string ToString()
        {
            return base.ToString() + $"Korygowany dok.: {CorrectedInvoiceCreateDate} z dn. {CorrectedInvoiceCreateDate}";
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
