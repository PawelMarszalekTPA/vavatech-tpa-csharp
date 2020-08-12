using System;
using System.Collections.Generic;
using TPA.CSharp.ObrotowkaService.Models;

namespace TPA.CSharp.ObrotowkaService
{
    public class ExcelObrotowkaService
    {
        public DateTime GetMinDate()
        {
            return DateTime.Today.AddDays(-15);
        }

        public DateTime GetMaxDate()
        {
            return DateTime.Today.AddDays(-5);
        }

        public void Save(string filename)
        {

        }

        public IEnumerable<Account> Get()
        {
            // inicjalizatory
            IEnumerable<Account> accounts = new List<Account>()
            {
                new Account { Symbol = "10" },
                new Account { Symbol = "11" },
                new Account { Symbol = "20" },
            };

            return accounts;

        }
    }
}
