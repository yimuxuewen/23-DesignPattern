using StrategyPattern.Interface;
using System;

namespace StrategyPattern.Service
{
    /// <summary>
    /// 抵扣策略
    /// </summary>
    public class Deduction : IStrategy
    {
        public void Algorith(ref double currentPrice)
        {
            if (currentPrice > 500)
            {
                currentPrice -= 50;
                Console.WriteLine("总价减50"); ;
            }
            else
            {
                Console.WriteLine("总价未达到抵扣最低标准！"); ;
            }
        }
    }
}
