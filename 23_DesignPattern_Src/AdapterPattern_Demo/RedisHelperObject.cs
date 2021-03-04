using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterPattern_Demo
{
    /// <summary>
    /// 对象组合 对象适配器
    /// </summary>
    class RedisHelperObject : IHelper
    {
        private RedisHelper _redisHelper = null;
        public RedisHelperObject(RedisHelper redisHelper)
        {
            _redisHelper = redisHelper;
        }
        public void Add<T>()
        {
            _redisHelper.AddRedis<T>();
        }
        public void Delete<T>()
        {
            _redisHelper.DeleteRedis<T>();
        }

        public void Select<T>()
        {
            _redisHelper.SelectRedis<T>();
        }


        public void Update<T>()
        {
            _redisHelper.UpdateRedis<T>();
        }

    }
}
