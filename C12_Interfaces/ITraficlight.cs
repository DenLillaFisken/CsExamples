using System;
using System.Collections.Generic;
using System.Text;

namespace C12_Interfaces
{
    interface ITraficlight
    {
        Guid Id { get; set; }
        string Location { get; set; }

        void ChangeLight();
        void WarningLight();
    }
}
