using AbstractFactoryPattern.Interface;
using System;

namespace AbstractFactoryPattern.Service
{
    public class WeiGeneral : IGenerial
    {
        public void ShowGenerials()
        {
            Console.WriteLine($"Generials is 张辽、乐进、于禁、张颌、徐晃  {this.GetType().Name}");
        }

    }
}
