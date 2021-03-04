using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterPattern_Demo
{
    /// <summary>
    /// 类继承 类适配器
    /// </summary>
    class RedisHelperClass:RedisHelper,IHelper
    {
        public void Add<T>()
        {
            base.AddRedis<T>();
        }
        public void Delete<T>()
        {
            base.DeleteRedis<T>();
        }

        public void Select<T>()
        {
            base.SelectRedis<T>();
        }


        public void Update<T>()
        {
            base.UpdateRedis<T>();
        }

    }
}
