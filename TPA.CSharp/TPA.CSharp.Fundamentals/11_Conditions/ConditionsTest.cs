using System;
using System.Collections.Generic;
using System.Text;

namespace TPA.CSharp.Fundamentals._11_Conditions
{
    public class ConditionsTest
    {
        public static void Test()
        {
            int amount = 560;

            // if

            // ponizej 500

            // powyzej 500

            string message;

            if (amount<500)
            {
               message = "Poniżej 500";
            }
            else
            {
                message = "Powyżej 500";
            }

            Console.WriteLine(message);

            // skrócony zapis if
            // warunek ? true : false 
            // JEŻELI(wyrażenie;true;false)
            string message2 = amount < 500 ? "Poniżej 500" : "Powyżej 500";

            Console.WriteLine(message2);

        }
    }
}
