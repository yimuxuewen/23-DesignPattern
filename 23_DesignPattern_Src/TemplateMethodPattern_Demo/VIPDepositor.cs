using System;
using System.Collections.Generic;
using System.Text;

namespace TemplateMethodPattern_Demo
{
    class VIPDepositor : BaseDepositor
    {
        protected override void CalculationInterest()
        {
            Balance*=0.07;
            Console.WriteLine($"{this.GetType().Name}的存款利息为{Balance}");
        }
    }
}
