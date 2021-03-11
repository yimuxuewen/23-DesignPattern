using System;
using System.Collections.Generic;
using System.Text;

namespace IteratorPattern
{
    class MacDonaldMenu : BaseMenu
    {
        private Food[] _macdonaldfoods = new Food[3];

        public MacDonaldMenu()
        {
            _macdonaldfoods[0] = new Food() { Id = 1, Name = "麦香堡", Price = 11 };
            _macdonaldfoods[1] = new Food() { Id = 2, Name = "鸡肉卷", Price = 9 };
            _macdonaldfoods[2] = new Food() { Id = 3, Name = "可乐", Price = 6 };
        }
        public override IEnumerable<Food> GetFoods()
        {
            return _macdonaldfoods;
        }
    }
}
