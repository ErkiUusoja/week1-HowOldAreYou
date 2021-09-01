using System;

namespace HowOldAreYou
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            string UserName = Console.ReadLine();

            //console.WriteLine("Hello, " + UserName + "!");
            //string interpolation

            Console.WriteLine($"Hello, {UserName}");

            Console.WriteLine("How old are you? enter digits only:");

            int Age = Int32.Parse(Console.ReadLine());

            int yearofbirth = 2021 - Age;
            //console.WriteLine("You were born in" + yearofbirth);
            Console.WriteLine($"You were born in {yearofbirth}");


        }
    }
}
