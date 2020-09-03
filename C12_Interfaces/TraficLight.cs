using System;
using System.Collections.Generic;
using System.Text;

namespace C12_Interfaces
{
    class TraficLight : ITraficlight
    {
        public Guid Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Location { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void ChangeLight()
        {
            throw new NotImplementedException();
        }

        public void WarningLight()
        {
            throw new NotImplementedException();
        }
    }
}
