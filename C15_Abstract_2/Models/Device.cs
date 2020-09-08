using System;
using System.Collections.Generic;
using System.Text;

namespace C15_Abstract_2.Models
{
    abstract class Device
    {
        //virtual gör det möjligt att skriva över om man vill
        public virtual string CreateFromConnectionString(string connectionstring)
        {
            return $"Initializing connection with \"{connectionstring}\"";
        }

        public abstract string RevieveMessage();
        public abstract void SendMessage(string payload);

    }
}
