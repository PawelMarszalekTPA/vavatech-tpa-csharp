using CsvHelper;
using CsvHelper.Configuration;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.IO;
using System.Text;
using TPA.CSharp.ListaPlac.Models;

namespace TPA.CSharp.ListaPlac
{
    public class EmployeeService
    {

        // PM> Install-Package CsvHelper
        public IEnumerable<Employee> Get(string filename)
        {
            StreamReader reader = new StreamReader(filename);
            CsvReader csvReader = new CsvReader(reader, CultureInfo.CurrentCulture);

            csvReader.Configuration.Delimiter = ";";
            csvReader.Configuration.RegisterClassMap<EmployeeMap>();

            IEnumerable<Employee> employees = csvReader.GetRecords<Employee>();

            return employees;
        }
    }

    public class EmployeeMap : ClassMap<Employee>
    {
        // snippet: ctor

        public EmployeeMap()
        {
            Map(p => p.Username).Name("Username");
            Map(p => p.LoginEmail).Name("Login email");
            Map(p => p.Identifier).Name("Identifier");
            Map(p => p.FirstName).Name("First name");
            Map(p => p.LastName).Name("Last name");

        }

    }
}
