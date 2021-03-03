using AbstractFactoryPattern.Interface;
using System;

namespace AbstractFactoryPattern.Service
{
    public class ShuGroup : IGroup
    {
        public void ShowGroup()
        {
            Console.WriteLine($"Group is 刘备  {this.GetType().Name}"); 
        }
    }
}
