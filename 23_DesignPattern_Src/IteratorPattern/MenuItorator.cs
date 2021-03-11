using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IteratorPattern
{
    class MenuItorator : IIterator
    {
        private int _index = -1;
        private IEnumerable<Food> _foods = null;
        public MenuItorator(BaseMenu menu)
        {
            _foods = menu.GetFoods(); 
        }
        public Food Current()
        {
            return _foods.ElementAt(_index);
        }

        public bool MoveNext()
        {
            return _foods.Count()>++_index;
        }

        public void Reset()
        {
            _index=-1;
        }
    }
}
