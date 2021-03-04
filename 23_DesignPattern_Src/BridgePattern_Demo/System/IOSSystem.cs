using System;
using System.Collections.Generic;
using System.Text;

namespace BridgePattern_Demo
{
    class IOSSystem : ISystem
    {
        public string SystemName()
        {
            return "IOS";
        }

        public string VersionNo()
        {
            return "11.4";
        }
    }
}
