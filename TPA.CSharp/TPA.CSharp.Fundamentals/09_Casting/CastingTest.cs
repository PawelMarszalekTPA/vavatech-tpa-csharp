using System;
using System.Collections.Generic;
using System.Text;

namespace TPA.CSharp.Fundamentals._09_Casting
{
    public class CastingTest
    {
        public static void Test()
        {
            int x = 160;

            checked
            {
                byte y = (byte)x;  // <- rzutowanie typów 

                Console.WriteLine(y);
            }

            int a = 10;
            byte b = (byte) a; // (jawna konwersja = explicit convertion)

            byte c = 10;
            int d = c;  // (niejawna konwersja = implicit conversion)

            float salary = 0.99f;
            double tax = salary;     // niejawna konwersja

            //Person person = new Person();
            //int age = (int) person;

        }

    }

    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }

        public void Send()
        {

        }

        public static byte GetAdultAge()
        {
            return 18;
        }
    }
}
