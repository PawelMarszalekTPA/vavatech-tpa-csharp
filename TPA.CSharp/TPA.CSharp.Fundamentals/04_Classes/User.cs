using System;
using System.Collections.Generic;
using System.Text;

namespace TPA.CSharp.Fundamentals._04_Classes
{
    public class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        private readonly bool flaga;

        public DateTime LoggedAt { get; }   // modyfikator readonly powoduje, że wartość można przypisać tylko w konstruktorze

        public User(string firstname, string lastname)
        {
            FirstName = firstname;
            LastName = lastname;

            LoggedAt = DateTime.Now;

            flaga = true;
        }

    }


    public static class ClassesTest
    {
        public static void Test()
        {
            User user = new User("John", "Smith");

            // user.LoggedAt = DateTime.Now;

            Console.WriteLine($"User {user.FirstName} {user.LastName} logged at {user.LoggedAt}");
        }
    }


}
