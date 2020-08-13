using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace TPA.CSharp.Fundamentals._10_Strings
{
    public class Account
    {
        public string AccountNumber { get; set; }

        //public string Fragment1 { get; set; }
        //public string Fragment2 { get; set; }
        //public string Fragment3 { get; set; }
        //public string Fragment4 { get; set; }

        public string[] Fragments { get; set; }

        public Account(string accountNumber)
        {
            this.AccountNumber = accountNumber;

            Fragments = AccountNumber.Split('-');

            //Fragment1 = fragments[0];
            //Fragment2 = fragments[1];
            //Fragment3 = fragments[2];
            //Fragment4 = fragments[3];
        }
    }

    public class StringsTest
    {

        public static void Test()
        {
            AccountTest();

            SplitTest();

            RegexTest();


            string accountNumber = "201-01-01-P005";

            // czy tekst rozpoczyna się od podanego ciągu
            if (accountNumber.StartsWith("30"))
            {

            }

            // czy tekst kończy się na podany ciąg
            if (accountNumber.EndsWith("005"))
            {

            }

            // Pobranie fragmentu tekstu
            string prefix = accountNumber.Substring(0, 3);

            Console.WriteLine(prefix);


            int index = accountNumber.IndexOf("-");

            string number = accountNumber.Substring(0, index);

            Console.WriteLine(number);
        }

        private static void AccountTest()
        {
            Account account = new Account("201-01-01-P005-5454-54545-54-54");

            Console.WriteLine(account.Fragments[0]);
        }

        private static void SplitTest()
        {
            string input = "201-01-01-P005";

            string[] fragments = input.Split('-');
        }

        private static void RegexTest()
        {
            string pattern = @"^(\d+)-(\d+)/(\d+)-(.+)";

            string input = "201-01-01-P005";

            Match match = Regex.Match(input, pattern);

            GroupCollection groups = match.Groups;

            string fragment1 = groups[1].Value;
            string fragment2 = groups[2].Value;
            string fragment3 = groups[3].Value;
            string fragment4 = groups[4].Value;

        }
    }
}
