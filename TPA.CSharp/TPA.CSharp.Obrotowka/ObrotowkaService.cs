using System;
using System.Collections.ObjectModel;
using System.IO;
using TPA.CSharp.Obrotowka.Models;

namespace TPA.CSharp.Obrotowka
{
    public class ObrotowkaService
    {
        public Collection<Account> Get(string filename)
        {
            StreamReader reader = new StreamReader(filename);

            // pominięcie nagłówka
            reader.ReadLine();

            Collection<Account> accounts = new Collection<Account>();

            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();

                string[] columns = line.Split(';');

                Account account = new Account();

                if (!string.IsNullOrWhiteSpace(columns[0]))
                {
                    account.Symbol = columns[0];
                    account.Name = columns[1];
                    account.SaldoBOWn = decimal.Parse(columns[2]);
                    account.SaldoBOMa = decimal.Parse(columns[3]);
                    account.ObrotyWn = decimal.Parse(columns[4]);
                    account.ObrotyMa = decimal.Parse(columns[5]);
                    account.ObrotyNWn = decimal.Parse(columns[6]);
                    account.ObrotyNMa = decimal.Parse(columns[7]);
                    account.SaldoWn = decimal.Parse(columns[8]);
                    account.SaldoMa = decimal.Parse(columns[9]);
                    account.PerSaldo = decimal.Parse(columns[10]);

                    accounts.Add(account);
                }
            }

            // rzucenie wyjątku
            // throw new NotImplementedException();

           return accounts;
        }
    }
}
