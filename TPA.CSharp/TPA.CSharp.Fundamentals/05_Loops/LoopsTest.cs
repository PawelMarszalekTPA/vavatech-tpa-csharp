using System;
using System.Collections.Generic;
using System.Text;

namespace TPA.CSharp.Fundamentals.Loops
{
    class LoopsTest
    {
        public static void Test()
        {
            ForTest();

            ForeachTest();

            WhileTest();

            DoWhileTest();
        }

        private static void ForTest()
        {
            byte[] happyNumbers = new byte[8] { 100, 34, 34, 37, 12, 45, 2, 7 };

            for (int i = 0; i < happyNumbers.Length; i++)
            {
                byte number = happyNumbers[i];

                Console.WriteLine($"{i} = {number}");
            }
        }

        private static void ForeachTest()
        {
            byte[] happyNumbers = new byte[8] { 100, 34, 34, 37, 12, 45, 2, 7 };

            foreach (byte number in happyNumbers)
            {
                Console.WriteLine(number);
            }
        }

        private static void DoWhileTest()
        {
            throw new NotImplementedException();
        }

        private static void WhileTest()
        {
            throw new NotImplementedException();
        }

       
    }

   
}
