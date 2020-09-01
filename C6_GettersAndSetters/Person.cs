using System;
using System.Collections.Generic;
using System.Text;

namespace C6_GettersAndSetters
{
    class Person
    {
        public string Name { get; set; }
        public int Age => CalculateAge(); //tar bort set, behåller get.
        public string City { get; set; }
        public DateTime DateOfBirth { get; set; }


        public void AskForName()
        {
            Console.Write("Hello, what's your name? ");
            Name = Console.ReadLine();

            Console.Write($"{Name}, sweet :)");
        }

        public void AskForCity()
        {
            Console.Write("Where do you live? ");
            City = Console.ReadLine();

            Console.WriteLine($" I am also {City}.");
        }


        public void AskForDateOfBirth()
        {
            Console.Write("When where you born?");

            try
            {
                DateOfBirth = Convert.ToDateTime(Console.ReadLine());
            }
            catch
            {
                Console.Write("Sorry dude, I mean when, like 1999-01-01. So When where you born?");
                try
                {
                    DateOfBirth = Convert.ToDateTime(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Nope...");
                }
            }
            Console.WriteLine($"Cool, we are the same Age. I am also {Age}");
        }

        private int CalculateAge()
        {
            int _age = DateTime.Now.Year - DateOfBirth.Year;
            if (DateTime.Now.DayOfYear < DateOfBirth.DayOfYear)
                _age = _age - 1;

            return _age;
        }
    }
}
