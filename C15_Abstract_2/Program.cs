using C15_Abstract_2.Models;
using System;

namespace C15_Abstract_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var tempsensor = new TempSensor();

            tempsensor.CreateFromConnectionString("Hostname=iot.azure.com;deviceId=dev1");

            Console.WriteLine();

            var command = tempsensor.RevieveMessage();
            Console.WriteLine($"Recieved command: {command}");

            switch (command)
            {
                case "get":
                    tempsensor.SendMessage("temperature = 12");
                    break;
                case "reset":
                    tempsensor.SendMessage("device has ben reseted");
                    break;
                default:
                    tempsensor.SendMessage("command not implemented");
                    break;
            }
        }
    }
}
