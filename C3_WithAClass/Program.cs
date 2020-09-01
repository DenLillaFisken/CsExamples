using System;

namespace C3_WithAClass
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person();


            Console.Write("Hejsan, vad heter du? ");
            person.Name = Console.ReadLine();

            Console.Write($"{person.Name}, sweet :) How old are you? ");
            // int age = Convert.ToInt32(Console.ReadLine());
            // int age = int.Parse(Console.ReadLine());
  
            try
            {
                person.Age = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Sorry, You must write a number. ");
                Console.Write("How old are you? ");
                person.Age = Convert.ToInt32(Console.ReadLine());
            }
            finally
            {
                Console.WriteLine($"Nice to know! We are the same {person.Age}.");
            }


        }
    }
}
