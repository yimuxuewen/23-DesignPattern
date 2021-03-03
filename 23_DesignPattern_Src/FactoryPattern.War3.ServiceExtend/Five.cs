using FactoryPattern.War3.Interface;
using System;

namespace FactoryPattern.War3.ServiceExtend
{
    public class Five : IRace
    {
        public void ShowKing()
        {
            Console.WriteLine($"The King of {this.GetType().Name}:Tim");
        }
    }
}
