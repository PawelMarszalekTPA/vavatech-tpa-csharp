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

        // Konstruktor - metoda uruchamiana automatycznie podczas tworzenia instancji obiektu
        public Invoice(string number, Customer customer)
        {
            createdDate = DateTime.Now;
            dueDate = createdDate.AddDays(14);

            this.number = number;
            this.customer = customer;

        }
    }

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
    }
}
