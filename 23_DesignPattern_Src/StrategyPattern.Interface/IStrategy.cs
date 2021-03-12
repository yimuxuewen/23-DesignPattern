using System;

namespace StrategyPattern.Interface
{
    public interface IStrategy
    {
        public void Algorith(ref double currentPrice);
    }
}
