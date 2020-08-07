using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using TPA.CSharp.ListaPlac.Models;

namespace TPA.CSharp.ListaPlac
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            string filename = "username-or-email.csv";

            EmployeeService employeeService = new EmployeeService();

            IEnumerable<Employee> employees = employeeService.Get(filename);

            foreach (Employee employee in employees)
            {
                Console.WriteLine(employee);
            }

        }
    }
}
