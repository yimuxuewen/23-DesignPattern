using AbstractFactoryPattern.AbstractFactory;
using AbstractFactoryPattern.Interface;
using System;

namespace AbstractFactoryPattern_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractFactory abstractFactory = new WuFactory() /*new WeiFactory()*/ /*new ShuFactory()*/;
            IGroup group = abstractFactory.CreateGroup();
            IGenerial generial = abstractFactory.CreateGenerial();
            group.ShowGroup();
            generial.ShowGenerials();

            Console.ReadLine();
        }
    }
}
