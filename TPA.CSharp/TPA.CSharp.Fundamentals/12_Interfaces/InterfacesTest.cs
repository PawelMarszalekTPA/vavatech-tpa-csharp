using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace TPA.CSharp.Fundamentals._12_Interfaces
{
    class InterfacesTest
    {
        public static void Test()
        {
            // wstrzykiwanie zależności (Dependency Injection)

            Dictionary<string, IFileObrotowkaService> dictionary = new Dictionary<string, IFileObrotowkaService>();
            dictionary.Add("xml", new XmlObrotowkaService());
            dictionary.Add("xlsx", new ExcelObrotowkaService());
            dictionary.Add("csv", new CsvObrotowkaService());

            string filename = "obrotowka.xml";
            
            string extention = Path.GetExtension(filename);

            IFileObrotowkaService obrotowkaService = dictionary[extention];

            List<Account> accounts = obrotowkaService.Get("obrotówka.xlsx");


            // UI
            foreach (Account account in accounts)
            {
                Console.WriteLine(account);
            }

            obrotowkaService.Add(new List<Account>(), "output.xlsx");
        }
    }

    // Interface - nie ma implementacji, posiada tylko sygnatury metod

    public interface IFileObrotowkaService      // kontrakt (umowa pomiędzy dwoma stronami)
    {
        List<Account> Get(string filename);
        void Add(IEnumerable<Account> accounts, string filename);
    }

    public interface IObrotowkaService
    {
        List<Account> Get();
        void Add(IEnumerable<Account> accounts);
    }

    public class JsonObrotowkaService : IObrotowkaService
    {
        private readonly string filename;

        public JsonObrotowkaService(string filename)
        {
            this.filename = filename;
        }

        public void Add(IEnumerable<Account> accounts)
        {
            throw new NotImplementedException();
        }

        public List<Account> Get()
        {
            throw new NotImplementedException();
        }
    }




    public class XmlObrotowkaService : IFileObrotowkaService
    {
        public List<Account> Get(string filename)
        {
            throw new NotImplementedException();
        }

        public void Add(IEnumerable<Account> accounts, string filename)
        {
            throw new NotImplementedException();
        }
    }

    public class CsvObrotowkaService : IFileObrotowkaService    // Klasa CsvObrotowkaService implementuje interfejs IObrotowkaService
    {
        public void Add(IEnumerable<Account> accounts, string filename)
        {
            throw new NotImplementedException();
        }

        public List<Account> Get(string filename)
        {
            return Load(filename);
        }

        public List<Account> Load(string filename)       // <= sygnatura metody
        {
            // ladowanie z csv
            throw new NotImplementedException();
        }
    }

    public class ExcelObrotowkaService : IFileObrotowkaService
    {
        public List<Account> Get(string filename)       // <= sygnatura metody
        {
            // ladowanie z xslt
            throw new NotImplementedException();
        }
        public void Add(IEnumerable<Account> accounts, string filename)
        {
            throw new NotImplementedException();
        }
    }

    public class Account
    {
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
            return $"{Symbol} {Name} {SaldoBOMa} {SaldoBOWn}";
        }
    }


}
