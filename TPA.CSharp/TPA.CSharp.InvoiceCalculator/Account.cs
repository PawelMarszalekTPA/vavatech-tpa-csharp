using System;
using System.Collections.Generic;
using System.Text;

namespace TPA.CSharp.InvoiceCalculator
{
    public class Account
    {
        private string accountNumber;

        //public string GetAccountNumber()
        //{
        //    return accountNumber;
        //}

        public string AccountNumber
        {
            get
            {
                return accountNumber;
            }
        }

        private decimal saldo;

        private bool isClosed;

        //public bool GetIsClosed()
        //{
        //    return isClosed;
        //}

        //public void SetIsClosed(bool value)
        //{
        //    isClosed = value;
        //}

        // Właściwość (property)
        public bool IsClosed
        {
            get  // getter
            {
                return isClosed;
            }
            set  // setter
            {
                isClosed = value;

                // Console.WriteLine("Zamykanie konta...");
            }
        }


        //private string name;
        //public string Name
        //{
        //    get
        //    {
        //        return name;
        //    }
        //    set
        //    {
        //        name = value;
        //    }
        //}

        public string Name { get; set; }


        public Account(string number)
        {
            accountNumber = number;
            saldo = 0;
        }

        public void Deposit(decimal amount)
        {
            saldo = saldo + amount;
        }

        public bool TryRedraw(decimal amount)
        {
            if (amount <= saldo)
            {
                saldo = saldo - amount;

                return true;
            }
            else
            {
                return false;
            }
        }

        public decimal GetSaldo()
        {
            return saldo;
        }
    }
}
