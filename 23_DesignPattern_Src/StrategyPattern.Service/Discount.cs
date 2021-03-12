using StrategyPattern.Interface;
using System;

namespace StrategyPattern.Service
{
    /// <summary>
    /// 打折策略
    /// </summary>
    public class Discount : IStrategy
    {
        public void Algorith(ref double currentPrice)
        {
            currentPrice *= 0.8;
            Console.WriteLine("打八折！"); ;
        }
    }
}
