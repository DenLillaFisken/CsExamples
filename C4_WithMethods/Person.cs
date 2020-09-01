using System;
using System.Collections.Generic;
using System.Text;

namespace C4_WithMethods
{
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string City { get; set; }

        public void AskForName()
        {
            Console.Write("Hello, what's your name? ");
            Name = Console.ReadLine();

            Console.Write($"{Name}, sweet :)");
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

        public void AskForCity()
        {
            Console.Write("Where do you live? ");
            City = Console.ReadLine();

            Console.WriteLine($" I am also {City}.");
        }
    }
}
