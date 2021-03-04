using System;

namespace BridgePattern_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            ISystem systemAndroid = new AndroidSystem();
            ISystem systemIOS = new IOSSystem();
            ISystem systemWinPhone = new WinPhoneSystem();
            BasePhone CurrPhone = new IOSPhoneBridge();
            CurrPhone.CurrentSystem = systemIOS;
            CurrPhone.Call();
            CurrPhone.Text();

            Console.ReadLine(); ;
        }
    }
}
