using System;

namespace CSharpFundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            var firstName = "Mike";
            String lastName = "Kap";

            var fullName = firstName + " " + lastName;

            var myFullName= string.Format("My name is {0} {1}", firstName, lastName);
            var names = new string[3] { "John", "Jack", "Mary" };
            var formattedNames = string.Join(",", names);
            Console.WriteLine(formattedNames);

            var text = 
            
        }
    }
}
