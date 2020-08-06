﻿using CsvHelper;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.IO;
using System.Linq;
using TPA.CSharp.Obrotowka.Models;

namespace TPA.CSharp.Obrotowka
{

    public class ObrotowkaService2
    {
        public List<Account> Get(string filename)
        {
            StreamReader reader = new StreamReader(filename);

            CsvReader csvReader = new CsvReader(reader, CultureInfo.CurrentCulture);

            csvReader.Configuration.Delimiter = ";";

            IEnumerable<Account> accounts = csvReader.GetRecords<Account>();

            return accounts.ToList();
        }
    }


    public class ObrotowkaService
    {
        private Dictionary<string, int> headersMapping;

        public ObrotowkaService()
        {
            headersMapping = new Dictionary<string, int>();
        }

        private void CreateDictionary(string[] headers)
        {
            foreach (string header in headers)
            {
                int index = Array.IndexOf(headers, header);

                headersMapping.Add(header, index);
            }
        }

        public Collection<Account> Get(string filename)
        {
            StreamReader reader = new StreamReader(filename);

            // utworzenie słownika kolumn
            string headerLine = reader.ReadLine();

            string[] headers = headerLine.Split(';');

            CreateDictionary(headers);

            Collection<Account> accounts = new Collection<Account>();

            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();

                string[] columns = line.Split(';');

               
                if (!string.IsNullOrWhiteSpace(columns[0]))
                {
                    Account account = Map(columns);

                    accounts.Add(account);
                }
            }

            // rzucenie wyjątku
            // throw new NotImplementedException();

           return accounts;
        }

        private Account Map(string[] columns)
        {
            Account account = new Account();

            account.Symbol = columns[headersMapping["Symbol"]];
            account.Name = columns[headersMapping["Name"]];
            account.SaldoBOWn = decimal.Parse(columns[headersMapping["SaldoBOWn"]]);
            account.SaldoBOMa = decimal.Parse(columns[headersMapping["SaldoBOMa"]]);
            account.ObrotyWn = decimal.Parse(columns[headersMapping["ObrotyWn"]]);
            account.ObrotyMa = decimal.Parse(columns[headersMapping["ObrotyMa"]]);
            account.ObrotyNWn = decimal.Parse(columns[6]);
            account.ObrotyNMa = decimal.Parse(columns[7]);
            account.SaldoWn = decimal.Parse(columns[8]);
            account.SaldoMa = decimal.Parse(columns[9]);
            account.PerSaldo = decimal.Parse(columns[10]);

            return account;
        }
    }
}
