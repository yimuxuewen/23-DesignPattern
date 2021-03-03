using AbstractFactoryPattern.Interface;
using System;

namespace AbstractFactoryPattern.Service
{
    public class WuGeneral : IGenerial
    {
        public void ShowGenerials()
        {
            Console.WriteLine($"Generials is 太史慈,甘宁,凌统,朱恒,徐盛 {this.GetType().Name}");
        }

    }
}
