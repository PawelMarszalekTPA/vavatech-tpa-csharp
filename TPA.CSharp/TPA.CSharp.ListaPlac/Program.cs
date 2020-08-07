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
            Console.WriteLine("Hello Lista Płac!");

            string filename = "username-or-email.csv";

            EmployeeService employeeService = new EmployeeService();

            //Collection<string> projects = new Collection<string>();
            //projects.Add("Project A");
            //projects.Add("Project B");
            //projects.Add("Project C");

            ProjectService projectService = new ProjectService();
            Collection<string> projects = projectService.Get();

            IEnumerable<Employee> employees = employeeService.Get(filename);

            foreach (Employee employee in employees)
            {
                Console.WriteLine(employee);

                string projectName;

                do
                {
                    Console.WriteLine("Wybierz projekt: " + string.Join(',', projects));

                    projectName = Console.ReadLine();

                    if (projects.Contains(projectName))
                    {
                        employee.Project = projectName;
                    }
                    else
                    {
                        Console.WriteLine("Nieznany projekt");
                    }
                }
                while (!projects.Contains(projectName));
            }



            employeeService.Add(employees, @"c:\temp\lista-plac.csv");



        }
    }
}
