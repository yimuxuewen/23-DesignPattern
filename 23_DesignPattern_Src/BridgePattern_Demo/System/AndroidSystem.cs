using System;
using System.Collections.Generic;
using System.Text;

namespace BridgePattern_Demo
{
    class AndroidSystem : ISystem
    {
        public string SystemName()
        {
            return "Android";
        }

        public string VersionNo()
        {
            return "11.0";
        }
    }
}
