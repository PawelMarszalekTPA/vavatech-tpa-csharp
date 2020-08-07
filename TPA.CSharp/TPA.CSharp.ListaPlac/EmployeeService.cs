using CsvHelper;
using CsvHelper.Configuration;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.IO;
using System.Linq;
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

            return employees.ToList();
        }

        public void Add(IEnumerable<Employee> employees, string filename)
        {
            StreamWriter writer = new StreamWriter(filename);

            writer.WriteLine("Username;Login email;Identifier;First name;Last name;Project");

            foreach (Employee employee in employees)
            {
                writer.WriteLine($"{employee.Username};{employee.LoginEmail};{employee.Identifier};{employee.FirstName};{employee.LastName};{employee.Project}");
            }

            writer.Dispose();

        }

        //public void Add(IEnumerable<Employee> employees, string filename)
        //{
        //    StreamWriter writer = new StreamWriter(filename);
        //    CsvWriter csvWriter = new CsvWriter(writer, CultureInfo.CurrentCulture);
        //    csvWriter.Configuration.Delimiter = ";";
        //    csvWriter.Configuration.RegisterClassMap<EmployeeMap>();
        //    csvWriter.WriteRecords(employees);

        //    writer.Dispose();
        //}
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
