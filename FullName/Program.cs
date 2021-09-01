using System;

namespace FullName
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutaja käest kasutaja eesnime
            //programm küsib kasutaja käest perekonnanime
            //programm tervitab kasutajat kasutades neid andmeid


            Console.WriteLine("What is your first name?");
            string UserFirstName = Console.ReadLine();
            

            Console.WriteLine("What is your last name?");
            string UserLastname = Console.ReadLine();

            Console.WriteLine($"Hello, {UserFirstName}{UserLastname}");








        }
    }
}
