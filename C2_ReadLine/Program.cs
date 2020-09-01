using System;

namespace C2_ReadLine
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Hejsan, vad heter du? ");
            string name = Console.ReadLine();
            


            Console.Write($"{name}, sweet :) How old are you? ");
            // int age = Convert.ToInt32(Console.ReadLine());
            // int age = int.Parse(Console.ReadLine());
            int age = 0;
            try
            {
                age = Convert.ToInt32(Console.ReadLine());
            }
            catch 
            {
                Console.WriteLine("Sorry, You must write a number. ");
                Console.Write("How old are you? ");
                age = Convert.ToInt32(Console.ReadLine());
            }
            finally
            {
                Console.WriteLine($"Nice to know! We are the same {age}.");
            }
            
        }
    }
}
