using System;
using System.Collections.Generic;
using System.Text;

namespace TemplateMethodPattern_Demo
{
    class NormalDepositor : BaseDepositor
    {
        protected override void CalculationInterest()
        {
            Balance*=0.03;
            Console.WriteLine($"{this.GetType().Name}的存款利息为{Balance}");
        }
    }
}
