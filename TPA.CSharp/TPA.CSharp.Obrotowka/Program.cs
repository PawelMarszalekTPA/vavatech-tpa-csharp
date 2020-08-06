using System;
using System.Collections.ObjectModel;
using System.IO;
using System.Runtime.Serialization;
using TPA.CSharp.Obrotowka.Models;

namespace TPA.CSharp.Obrotowka
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            string filename = "Obrotówka.csv";

            ObrotowkaService obrotowkaService = new ObrotowkaService();
            Collection<Account> accounts = obrotowkaService.Get(filename);

            foreach (Account account in accounts)
            {
                Console.WriteLine(account);
            }


            // pętla while (dopóki)
            // realizuje kod dopóki warunek jest spełniony


            // NegationTest();

            // WhileLoopTest();

        }

        private static void NegationTest()
        {
            bool isClosed = false;

            isClosed = !isClosed;

            // ! - negacja
            if (!isClosed)
            {

            }
        }

        private static void WhileLoopTest()
        {
            int i = 0;

            while (i < 10)
            {
                Console.WriteLine(i);
                i++;
            }

            Console.WriteLine("koniec");
        }
    }
}
