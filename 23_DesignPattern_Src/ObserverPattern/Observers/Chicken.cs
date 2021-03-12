using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern
{
    class Chicken : IObserver
    {
        public void Fly()
        {
            Console.WriteLine("鸡飞");
        }
        public void Action()
        {
            Fly();
        }
    }
}
