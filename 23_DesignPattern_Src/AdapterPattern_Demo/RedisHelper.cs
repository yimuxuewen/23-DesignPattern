using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterPattern_Demo
{
    class RedisHelper
    {
        public void AddRedis<T>()
        {
            Console.WriteLine($"{this.GetType().Name}进行数据添加");
        }

        public void DeleteRedis<T>()
        {
            Console.WriteLine($"{this.GetType().Name}进行数据删除");
        }

        public void SelectRedis<T>()
        {
            Console.WriteLine($"{this.GetType().Name}进行数据修改");
        }

        public void UpdateRedis<T>()
        {
            Console.WriteLine($"{this.GetType().Name}进行数据更新");
        }
    }
}
