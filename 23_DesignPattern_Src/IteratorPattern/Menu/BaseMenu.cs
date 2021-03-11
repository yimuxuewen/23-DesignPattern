using System;
using System.Collections.Generic;
using System.Text;

namespace IteratorPattern
{
    abstract class BaseMenu
    {
        public abstract IEnumerable<Food> GetFoods();
    }
}
