using System;

namespace C1_WriteLine
{
    class Program
    {
        static void Main(string[] args)
        {

            var path = @"\test\test2";
            //Eller
            var path2 = "\\test\\test2";

            string name = "Alex";
            int age = 24;
            var city = "Örebro";


            var text1 = "Välkommer hit, tjabba tjena hallå";
            var text2 = "Välkommen" + name + "You are" + age + "olds right?" + name + "do ypu live in" + city + "?";
            var text3 = String.Format("Välkommen {0}. You are  {1} olds right? {0} do ypu live in {2}", name, age, city);
            //best practice
            var text4 = $"Välkommen {name}. You are  {age} olds right? {name} do ypu live in {city}?";

            Console.WriteLine(text4);

        }
    }
}
