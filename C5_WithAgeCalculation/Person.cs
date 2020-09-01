using System;
using System.Collections.Generic;
using System.Text;

namespace C5_WithAgeCalculation
{
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
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

        public void AskForAge()
        {
            Console.Write("How old are you? ");


            try
            {
                Age = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Sorry, You must write a number. ");
                Console.Write("How old are you? ");
                try
                {
                    Age = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Dumbass...");
                }
            }
            finally
            {
                Console.WriteLine($"Nice to know! I am also {Age}.");
            }
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
            Console.WriteLine($"Cool, we are the same Age. I am also {CalculateAge()}");
        }

        private int CalculateAge()
        {
            Age = DateTime.Now.Year - DateOfBirth.Year;
            if(DateTime.Now.DayOfYear < DateOfBirth.DayOfYear) 
                Age = Age - 1;

            return Age;
        }
    }
}
