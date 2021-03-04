using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterPattern_Demo
{
    class MySqlHelper : IHelper
    {
        public void Add<T>()
        {
            Console.WriteLine($"{this.GetType().Name}进行数据添加");
        }

        public void Delete<T>()
        {
            Console.WriteLine($"{this.GetType().Name}进行数据删除");
        }

        public void Select<T>()
        {
            Console.WriteLine($"{this.GetType().Name}进行数据修改");
        }

        public void Update<T>()
        {
            Console.WriteLine($"{this.GetType().Name}进行数据更新");
        }
    }
}
