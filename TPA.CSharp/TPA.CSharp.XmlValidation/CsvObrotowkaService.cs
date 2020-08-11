using CsvHelper;
using CsvHelper.Configuration;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using TPA.CSharp.XmlValidation.Models;

namespace TPA.CSharp.XmlValidation
{
    // PM> Install-Package CsvHelper
    public class CsvObrotowkaService
    {
        public List<Account> Get(string filename)
        {
            StreamReader reader = new StreamReader(filename);

            CsvReader csvReader = new CsvReader(reader, CultureInfo.CurrentCulture);

            csvReader.Configuration.Delimiter = ";";
            csvReader.Configuration.RegisterClassMap<ObrotowkaAMap>();

            IEnumerable<Account> accounts = csvReader.GetRecords<Account>();

            return accounts.ToList();

        }
    }

    public class ObrotowkaAMap : ClassMap<Account>
    {
        public ObrotowkaAMap()
        {
            Map(p => p.Symbol).Name("Symbol");
            Map(p => p.Name).Name("Nazwa");
            Map(p => p.SaldoBOWn).Name("SaldoBOWn");
            Map(p => p.SaldoBOMa).Name("SaldoBOMa");
            Map(p => p.ObrotyWn).Name("ObrWn");
            Map(p => p.ObrotyMa).Name("ObrotyMa");
            Map(p => p.ObrotyNWn).Name("ObrotyNWn");

        }
    }
}