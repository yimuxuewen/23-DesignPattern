using StrategyPattern.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern_Demo
{
    /// <summary>
    /// 顾客
    /// </summary>
    public class Customer
    {
        /// <summary>
        /// 商品价格
        /// </summary>
        private double _price;

        /// <summary>
        /// 折扣策略
        /// </summary>
        private List<IStrategy> strategies = new List<IStrategy>();

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="price"></param>
        public Customer(double price)
        {
            _price = price;
        }
        /// <summary>
        /// 增加策略
        /// </summary>
        /// <param name="strategy"></param>
        public void AddStrategy(IStrategy strategy)
        {
            strategies.Add(strategy);
        }

        /// <summary>
        /// 计算折扣
        /// </summary>
        public void Promoto()
        {
            foreach (var item in strategies)
            {
                item.Algorith(ref _price);
                Console.WriteLine(this);
            }
        }

        public override string ToString()
        {
            return $"当前商品价格：{_price}";
        }
    }
}
