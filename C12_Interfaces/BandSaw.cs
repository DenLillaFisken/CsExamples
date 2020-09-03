using System;
using System.Collections.Generic;
using System.Text;

namespace C12_Interfaces
{
    class BandSaw : IMachineFeatures
    {
        public bool Start()
        {
            Console.WriteLine("bandsaw machine started.");
            return true;
        }

        public bool Stop()
        {
            Console.WriteLine("bandsaw machine stopped.");
            return true;
        }
    }
}
