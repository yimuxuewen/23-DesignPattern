using StrategyPattern.Interface;
using System;

namespace StrategyPattern.Service
{
    /// <summary>
    /// 赠送策略
    /// </summary>
    public class GiveAway : IStrategy
    {
        public void Algorith(ref double currentPrice)
        {
            Console.WriteLine("赠送一个玩具！"); 
        }
    }
}
