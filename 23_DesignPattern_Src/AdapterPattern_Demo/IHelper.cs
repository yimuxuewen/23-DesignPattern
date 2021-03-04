using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterPattern_Demo
{
    interface IHelper
    {
        void Add<T>();
        void Delete<T>();
        void Update<T>();
        void Select<T>();
    }
}
