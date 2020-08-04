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
    }

    public class Customer
    {
        public string name;
        public string street;
        public string postCode;
        public string city;
    }
}
