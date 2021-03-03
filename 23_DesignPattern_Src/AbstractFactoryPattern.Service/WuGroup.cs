using AbstractFactoryPattern.Interface;
using System;

namespace AbstractFactoryPattern.Service
{
    public class WuGroup : IGroup

    {
        public void ShowGroup()
        {
            Console.WriteLine($"Group is 孙权  {this.GetType().Name}");
        }
    }
}
