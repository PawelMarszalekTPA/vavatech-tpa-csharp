using System;
using System.Collections.Generic;
using System.Text;

namespace TPA.CSharp.InvoiceCalculator
{

    public class InvoiceNumberGenerator
    {
        private int lastNumber;

        //public int GetNextNumber()
        //{
        //   // lastNumber = lastNumber + 1;

        //    lastNumber++;    // inkrementacja o 1

        //    return lastNumber;

        //}


        public int GetNextNumber()
        {
            return ++lastNumber;  // lastNumber = lastNumber + 1;
        }

        // FV 100/07
        public string GetNextNumber2()
        {
            int month = DateTime.Today.Month - 1;

            return $"FV {++lastNumber}/{month:00}/{DateTime.Today.Year}";
        }
    }
}
