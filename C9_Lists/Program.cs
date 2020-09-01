using System;
using System.Collections.Generic;

namespace C9_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            bool _hassiblings;

            Console.Write("Do you have any siblings (yes/no)?");
            var _siblingResponse = Console.ReadLine();

            switch (_siblingResponse.ToLower())
            {
                case "yes":
                     _hassiblings = true;
                    break;

                case "No":
                        _hassiblings = false;
                    break;

                default:
                    _hassiblings = false;
                    break;
            }
            if (!_hassiblings)
                Console.WriteLine("Okey, to bad.");
            else
            {
                Console.Write("Sweet. How many? ");
                int _numberOfSiblings = Convert.ToInt32(Console.ReadLine());

                var siblings = new List<string>();

                if(_numberOfSiblings == 1)
                {
                    Console.WriteLine("What is its name?");
                    siblings.Add(Console.ReadLine());

                    Console.WriteLine($"Ok, your siblings name is {siblings[0]}");
                }
                else
                {
                    Console.WriteLine("What is their names? Separate by comma(,)");
                    var _response = Console.ReadLine();

                    var names = _response.Replace(" ", "").Split(",");

                    foreach(var name in names)
                    {
                        siblings.Add(name);
                    }

                    Console.WriteLine("Whhich of your siblings are the oldest?");
                    var _oldest = Console.ReadLine();

                    var index = siblings.FindIndex(x => x.Contains(_oldest)); //hitta index i listan på det namn som är äldst
                    siblings.RemoveAt(index);
                    siblings.Insert(0, _oldest);

                    Console.Write($"Ok, so your oldest sibling is: ");
                    foreach(var sibling in siblings)
                    {
                        Console.Write($"{sibling}");
                    }
                }
                    
            }
        }
    }
}
