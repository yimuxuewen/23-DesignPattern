using System;
using System.Collections.Generic;
using System.Text;

namespace IteratorPattern
{
    class KFCMenu: BaseMenu
    {
        private List<Food> _kfcfoods = new List<Food>();

        public KFCMenu()
        {
            _kfcfoods.Add(new Food() { Id = 1, Name = "香辣牛肉堡", Price = 10 });
            _kfcfoods.Add(new Food() { Id = 2, Name = "薯条", Price = 8 });
            _kfcfoods.Add(new Food() { Id = 3, Name = "可乐", Price = 6 });
        }
        public override IEnumerable<Food> GetFoods()
        {
            return _kfcfoods;
        }
    }
}
