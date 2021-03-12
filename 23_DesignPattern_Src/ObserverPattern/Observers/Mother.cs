using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern
{
    class Mother : IObserver
    {
        public void Coax()
        {
            Console.WriteLine("哄娃");
        }
        public void Action()
        {
            Coax();
        }
    }
}
