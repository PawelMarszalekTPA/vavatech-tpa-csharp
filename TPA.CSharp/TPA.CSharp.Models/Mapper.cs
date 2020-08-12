using System;
using System.Collections.Generic;

namespace TPA.CSharp.Models
{
    public class Mapper : Dictionary<string, List<Target>>
    {
        public void Add(string accountNumber, List<Target> targets)
        {
            this.Add(accountNumber, targets);
        }
    }


    public class Target
    {
        public string WorksheetName { get; set; }
        public string Address { get; set; }

        public Target(string worksheetName, string address)
        {
            this.WorksheetName = worksheetName;
            this.Address = address;
        }
    }
}
