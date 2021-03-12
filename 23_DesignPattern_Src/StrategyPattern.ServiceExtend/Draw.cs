using StrategyPattern.Interface;
using System;

namespace StrategyPattern.ServiceExtend
{
    public class Draw : IStrategy
    {
        public void Algorith(ref double currentPrice)
        {
            Console.WriteLine("参与抽奖，抽了个寂寞");
        }
    }
}
