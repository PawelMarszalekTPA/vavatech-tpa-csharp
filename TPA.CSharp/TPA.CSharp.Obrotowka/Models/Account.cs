﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TPA.CSharp.Obrotowka.Models
{
    public class Account
    {
        // snippet: prop + 2 x Tab + Tab + Tab + Enter
        public string Symbol { get; set; }
        public string Name { get; set; }
        public decimal SaldoBOWn { get; set; }
        public decimal SaldoBOMa { get; set; }
        public decimal ObrotyWn { get; set; }
        public decimal ObrotyMa { get; set; }
        public decimal ObrotyNWn { get; set; }
        public decimal ObrotyNMa { get; set; }
        public decimal SaldoWn { get; set; }
        public decimal SaldoMa { get; set; }
        public decimal PerSaldo { get; set; }

        public override string ToString()
        {
            return $"{Symbol} {Name} {PerSaldo}";
        }
    }
}
