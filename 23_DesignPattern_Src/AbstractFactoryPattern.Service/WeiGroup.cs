using AbstractFactoryPattern.Interface;
using System;

namespace AbstractFactoryPattern.Service
{
    public class WeiGroup : IGroup
    {
        public void ShowGroup()
        {
            Console.WriteLine($"Group is 曹操  {this.GetType().Name}");
        }
    }
}
