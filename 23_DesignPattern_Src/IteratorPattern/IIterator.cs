using System;
using System.Collections.Generic;
using System.Text;

namespace IteratorPattern
{
    interface IIterator
    {
        public Food Current();
        public void Reset();
        public bool MoveNext();
    }
}
