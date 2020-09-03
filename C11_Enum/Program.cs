using System;

namespace C11_Enum
{
    public enum Level
    {
        Low,
        Normal,
        High
    }

    class Program
    {
        enum Status
        {
            Pending, 
            Production,
            Transporting,
            Delivered
        }
        static void Main(string[] args)
        {
            var temperature = 32;
            var _tempLevel = Level.Normal;

            switch (temperature){
                case int t when t < 10:
                    _tempLevel = Level.Low;
                    Console.WriteLine("Temp is too low");
                    break;

                case int t when t > 30:
                    _tempLevel = Level.High;
                    Console.WriteLine("Temp is too high");
                    break;
                default:
                    _tempLevel = Level.Normal;
                    Console.WriteLine("Temp is normal");
                    break;
            }

            switch (_tempLevel)
            {
                case Level.Low:
                    Console.WriteLine("Temp is too low");
                    break;

                case Level.High:
                    Console.WriteLine("Temp is too high");
                    break;
                default:
                    _tempLevel = Level.Normal;
                    Console.WriteLine("Temp is normal");
                    break;
            }

            var status = Status.Pending;

            switch (status)
            {
                case Status.Pending:
                    Console.WriteLine("Electronic registration information has been recived.");
                    break;
                case Status.Production:
                    Console.WriteLine("Your product are being prepared for shipping.");
                    break;
                case Status.Transporting:
                    Console.WriteLine("Your product are being shipped.");
                    break;
                case Status.Delivered:
                    Console.WriteLine("Your product has been delivered.");
                    break;
            }


        }
    }
}
