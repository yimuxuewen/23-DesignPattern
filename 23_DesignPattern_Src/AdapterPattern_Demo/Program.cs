using System;

namespace AdapterPattern_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            RedisHelper redisHelper = new RedisHelper();
            IHelper helper = new RedisHelperObject(redisHelper)/*new RedisHelperClass()*/ /*new MySqlHelper()*/;
            helper.Add<Program>();
            helper.Delete<Program>();
            helper.Update<Program>();
            helper.Select<Program>();
            Console.ReadLine();
        }
    }
}
