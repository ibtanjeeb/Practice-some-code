using System;

namespace String
{
    class Program
    {
        static void Main(string[] args)
        {
            string FirstName = "Mosh";
            string LastName = "fet";

            string FullName = FirstName + " " + LastName;

            var MyFullName = string.Format("My name is {0} {1}", FirstName, LastName);
            var Names = new string[3] { "bad", "tad", "get" };

            var FormattedName = string.Join(",",Names);

            Console.WriteLine(FormattedName);


        }
    }
}
