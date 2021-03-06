﻿using System;
using System.Collections.ObjectModel;

namespace TPA.CSharp.Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            CompanyWithAccountsTest();

            CollectionTest();

            AccountsTest();

            ArrayTest1();
            ArrayTest2();

            // Zadanie 

            // Utwórz salda na 12-miesięcy (decimal) i wyświetl wszystkie miesiące

        }

        private static void CompanyWithAccountsTest()
        {
            Collection<Company> companies = new Collection<Company>();

            Company company0 = new Company("TPA");
            Company company1 = new Company("ABC");
            Company company2 = new Company("VAVA");
            companies.Add(company0);
            companies.Add(company1);
            companies.Add(company2);
            Account account1 = new Account("10001");
            Account account2 = new Account("10002");
            Account account3 = new Account("10003");

            company0.Accounts.Add(account1);
            company0.Accounts.Add(account2);
            company0.Accounts.Add(account3);
            company1.Accounts.Add(account1);
            company2.Accounts.Add(account3);

            account3.Saldo = 3350;
            company0.Accounts[0].Saldo = 256;
        }

        private static void CollectionTest()
        {
            Collection<Company> companies = new Collection<Company>
            {
                new Company("TPA"),
                new Company("ABC"),
                new Company("Vavatech")
            };

            foreach (Company company in companies)
            {
                Console.WriteLine($"{company.Name}");
            }
        }



        private static void AccountsTest()
        {
            Company company = new Company("TPA");
            company.Accounts = new Collection<Account>();

            Account account1 = new Account("10000");
            Account account2 = new Account("20000");
            Account account3 = new Account("30000");
            account3.Saldo = 1000;

            company.Accounts.Add(account1);
            company.Accounts.Add(account2);
            company.Accounts.Add(account3);

            company.Accounts.Remove(account2);

            company.Accounts[0].Saldo = 500;

            foreach (Account account in company.Accounts)
            {
                Console.WriteLine($"{account.Number} saldo: {account.Saldo}");
            }
        }

        private static void ArrayTest1()
        {
            // zmienna tablicowa (wektor)
            byte[] happyNumbers = new byte[8];

            happyNumbers[0] = 100;
            happyNumbers[1] = 24;
            happyNumbers[2] = 24;
            happyNumbers[3] = 255;

            byte number0 = happyNumbers[0];
            byte number3 = happyNumbers[3];

            // pętla for
            for (int i = 0; i < happyNumbers.Length; i++)
            {
                byte number = happyNumbers[i];

                Console.WriteLine($"{i} = {number}");
            }

            foreach (byte number in happyNumbers)
            {
                Console.WriteLine(number);
            }
        }

        private static void ArrayTest2()
        {
            // zmienna tablicowa (wektor)
            byte[] happyNumbers = new byte[8] { 100, 24, 24, 255, 5, 5, 6, 1 };

            byte number0 = happyNumbers[0];
            byte number3 = happyNumbers[3];

            // pętla for
            for (int i = 0; i < happyNumbers.Length; i++)
            {
                byte number = happyNumbers[i];

                Console.WriteLine($"{i} = {number}");
            }

            foreach (byte number in happyNumbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}
