using FactoryPattern.War3.Interface;
using System;

namespace FactoryPattern.War3.Service
{
    public class NE : IRace
    {
        public void ShowKing()
        {
            Console.WriteLine($"The King of {this.GetType().Name}:Tom");
        }
    }
}
