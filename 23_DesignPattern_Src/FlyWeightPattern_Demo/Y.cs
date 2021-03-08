using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace FlyWeightPattern_Demo
{
    class Y : BaseWord
    {
        public Y()
        {
            long result = 0;
            for (int i = 0; i < 10000; i++)
            {
                result += i;
            }
            Thread.Sleep(1000);
            Console.WriteLine($"{this.GetType().Name}被构造");
        }
        public override string Get()
        {
            return this.GetType().Name;
        }
    }
}
