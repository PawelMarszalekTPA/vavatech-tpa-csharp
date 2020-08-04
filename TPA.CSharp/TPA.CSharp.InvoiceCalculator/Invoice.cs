using System;
using System.Collections.Generic;
using System.Text;

namespace TPA.CSharp.InvoiceCalculator
{
    public class Invoice
    {
        // pole
        public string number;
        public DateTime createdDate;
        public Customer customer;
        public DateTime dueDate;

        // Nullable
        public DateTime? postedDate;

        public InvoiceStatus Status;

        // Konstruktor - metoda uruchamiana automatycznie podczas tworzenia instancji obiektu
        public Invoice(string number, Customer customer)
        {
            createdDate = DateTime.Now;
            dueDate = createdDate.AddDays(14);
            this.Status = InvoiceStatus.Created;

            this.number = number;
            this.customer = customer;
        }

        // zaksięguj
        public void Post()
        {
            if (Status == InvoiceStatus.Created)
            {
                Status = InvoiceStatus.Posted;
                postedDate = DateTime.Now;
            }
        }
        

        // TODO: dodaj metodę do anulowania faktury - Cancel()

        public void Cancel()
        {
            if (Status == InvoiceStatus.Created || Status == InvoiceStatus.Posted)
            {
                Status = InvoiceStatus.Cancelled;
                postedDate = null;
            }
        }

        public void Send(string email)
        {
            Console.WriteLine($"Sending invoice {number} to {email}");
        }

    }

    // Typ wyliczeniowy
    public enum InvoiceStatus
    {
        Created,
        Posted,
        Cancelled
    }

    // faktura: utworzona, zaksięgowana, anulowana

    public class Customer
    {
        public string name;

        public Address invoiceAddress;
        public Address postAddress;

        public Customer(string name)
        {
            this.name = name;
        }
    }

    public class Address
    {
        public string street;
        public string postCode;
        public string city;

        public Address(string street, string postCode, string city)
        {
            this.street = street;
            this.postCode = postCode;
            this.city = city;
        }


        // przesłanianie metody
        public override string ToString()
        {
            return $"{street} \n{postCode} {city}";
        }

    }
}
