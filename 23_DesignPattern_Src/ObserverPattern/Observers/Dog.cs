using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern
{
    class Dog : IObserver
    {
        public void Bark()
        {
            Console.WriteLine("狗吠");
        }
        public void Action()
        {
            Bark();
        }
    }
}
