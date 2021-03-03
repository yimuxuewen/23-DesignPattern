using AbstractFactoryPattern.Interface;
using System;

namespace AbstractFactoryPattern.Service
{
    public class ShuGeneral : IGenerial
    {
        public void ShowGenerials()
        {
            Console.WriteLine($"Generials is 张飞,赵云,关羽,马超 ,黄忠 {this.GetType().Name}");
        }

    }
}
