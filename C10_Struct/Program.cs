using System;

namespace C10_Struct
{
    class Program
    {
        // MINNESHANTERING (RAM el. Hårddisk)
        // HEAP     = Långsammare   MALLOC()/FREE() - reservera RAM-minne               CLASS
        // STACK    = Snabbare                                                          STRUCT/VARIABLER        stack overflow

       /* struct Person //lokal variabel (grupperade variabel)(tar mindre plats än en klass) gör samma sak som en klass
        {
            public string Name { get; set; }
            public int Age { get; set; }
            public string City { get; set; }
        }
       */

        class ClassExample
        {
            public int Nr1 { get; set; }
            public int Nr2 { get; set; }


            //structor
            public ClassExample(int nr1, int nr2)
            {
                Nr1 = nr1;
                Nr2 = nr2;
            }

            public void DisplayValues()
            {
                Console.WriteLine($"Display value: {Nr1 }, {Nr2 }");
            }
        }
        struct StructExample
        {
            public int Nr1 { get; set; }
            public int Nr2 { get; set; }


            //structor
            public StructExample(int nr1, int nr2)
            {
                Nr1 = nr1;
                Nr2 = nr2;
            }

            public void DisplayValues()
            {
                Console.WriteLine($"Display value: {Nr1 }, {Nr2 }");
            }
        }

        class Program
        {
            private static void ModifyValue(dynamic d)
            {
                d.Nr1 += 1;
                d.Nr2 += 1;

                Console.WriteLine({ d.Nr1 }, { d.Nr2});
            }
            static void Main(string[] args)
            {



                Console.WriteLine("ClassExample - HEAP (GLOBAL)");
                var classexample = new ClassExample(1, 1);

                classexample.DisplayValues();
                ModifyValue(structexample);
                classexample.DisplayValues();

                Console.WriteLine("\n--------------------------------\n");

                Console.WriteLine("StructExample - STAC (LOCAL)");
                var structsexample = new StructExample(1, 1);

                structexample.DisplayValues();
                ModifyValue(structexample);
                structexample.DisplayValues();



                Console.ReadKey();
            }
            /*
             int Nr1 = 1 (global, utanför funtion)

            function{
            int Nr2 = 1 (lokal)
            Nr1(kopia) += 1; (=2) (lokal, inuti funktion)
                
            }
             
             
             */
        }
        }
    }
}
