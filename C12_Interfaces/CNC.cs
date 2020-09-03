using System;
using System.Collections.Generic;
using System.Text;

namespace C12_Interfaces
{
    class CNC : IMachineFeatures
    {
        public bool Start()
        {
            Console.WriteLine("CNC machine started.");
            return true;
        }

        public bool Stop()
        {
            Console.WriteLine("CNC machine stopped.");
            return true;
        }
    }
}
