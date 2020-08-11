using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace TPA.CSharp.XmlValidation.Models
{
    [XmlRoot(ElementName = "Konto")]
    public class Account
    {
        [XmlAttribute]
        public string Symbol { get; set; }

        [XmlAttribute("Nazwa")]
        public string Name { get; set; }

        public decimal SaldoBOWn { get; set; }
        public decimal SaldoBOMa { get; set; }
        public decimal ObrotyWn { get; set; }
        public decimal ObrotyMa { get; set; }
        public decimal ObrotyNWn { get; set; }
        public decimal ObrotyNMa { get; set; }
        public decimal SaldoWn { get; set; }
        public decimal SaldoMa { get; set; }

        [XmlElement("Saldo")]
        public decimal PerSaldo { get; set; }

        public override string ToString()
        {
            return $"{Symbol} {Name} {SaldoBOMa} {SaldoBOWn}";
        }
    }
}
