using System;
using System.Collections.Generic;
using System.Text;

namespace BridgePattern_Demo
{
    class WinPhoneSystem : ISystem
    {
        public string SystemName()
        {
            return "WinPhone";
        }

        public string VersionNo()
        {
            return "10.0";
        }
    }
}
