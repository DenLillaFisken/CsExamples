using System;

namespace C8_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("How many siblings do you have?");

            var _numberOfSiblings = Convert.ToInt32(Console.ReadLine());

            if(_numberOfSiblings < 1)
                Console.WriteLine("Najs.");
            else
            {
                string[] siblings = new string[_numberOfSiblings];

                if(_numberOfSiblings == 1)
                {
                    Console.WriteLine("What's your siblings name?");
                    siblings[0] = Console.ReadLine();
                }
                else
                {
                    for (var i = 0; i < _numberOfSiblings; i++)
                    {
                        if (i == 0)
                            Console.Write("What is your first siblings name?");
                        else
                            Console.Write("What is your next siblings name?");


                        siblings[i] = Console.ReadLine();
                    }

                    if (_numberOfSiblings == 1)
                        Console.Write("So correct me if I am wrong. Yor sibling name is " );
                    else
                        Console.Write("So correct me if I am wrong. Yor siblings name are ");

                    foreach (var sibling in siblings)
                    {
                        Console.Write($"{sibling} ");
                    }
                }


            }
        }
    }
}
