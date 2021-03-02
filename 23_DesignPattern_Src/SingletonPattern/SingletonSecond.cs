using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace SingletonPattern
{
    /// <summary>
    /// 饿汉式
    /// </summary>
    public sealed class SingletonSecond
    {
        /// <summary>
        ///未调用GetSingleton, 调用此字段时，SingletonSecond已被初始化
        /// </summary>
        public static readonly string Name = "2";

        private static SingletonSecond _singletonsecond = null;
        private SingletonSecond()
        {
            long result = 0;
            for (int i = 0; i < 100000; i++)
            {
                result += i;
            }
            Thread.Sleep(1000);
            Console.WriteLine($"构造函数{this.GetType().Name}被构造");
        }
        static SingletonSecond()
        {
            _singletonsecond = new SingletonSecond();
        }

        public static SingletonSecond GetSingleton()
        {
            return _singletonsecond;
        }
        public void Show()
        {
            Console.WriteLine($"这是对象{this.GetType().Name}的Show方法");
        }
    }
}
