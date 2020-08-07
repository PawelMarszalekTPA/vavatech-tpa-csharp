using System;
using System.Collections.Generic;
using System.Text;

namespace TPA.CSharp.ListaPlac.Models
{
    public class Employee
    {
        public int Identifier { get; set; }
        public string Username { get; set; }
        public string LoginEmail { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Project { get; set; }


        public override string ToString()
        {
            return $"{Identifier} {Username} {LoginEmail} {FirstName} {LastName}";
        }
    }
}
