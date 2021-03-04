using System;
using System.Collections.Generic;
using System.Text;

namespace BridgePattern_Demo
{
    abstract class BasePhone
    {
        public ISystem CurrentSystem { get; set; }
        public abstract void Call();
        public abstract void Text();
    }
}
