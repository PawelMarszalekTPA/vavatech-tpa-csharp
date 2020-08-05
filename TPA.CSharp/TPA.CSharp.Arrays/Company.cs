using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace TPA.CSharp.Arrays
{
    public class Company
    {
        public string Name { get; set; }

        public Collection<Account> Accounts { get; set; }

        public Company(string name)
        {
            this.Name = name;
        }

    }

    public class Account
    {
        public string Number { get; set; }
        public decimal Saldo { get; set; }

        public Account(string number)
        {
            this.Number = number;
            this.Saldo = 0;
        }
    }
}
