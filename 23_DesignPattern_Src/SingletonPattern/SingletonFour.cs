using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace SingletonPattern
{
    /// <summary>
    /// 懒汉式
    /// </summary>
    public sealed class SingletonFour
    {
        /// <summary>
        ///未调用GetSingleton, 调用此字段时，SingletonFour不会被初始化
        /// </summary>
        public static readonly string Name = "2";
        private SingletonFour()
        {
            long result = 0;
            for (int i = 0; i < 100000; i++)
            {
                result += i;
            }
            Thread.Sleep(1000);
            Console.WriteLine($"构造函数{this.GetType().Name}被构造");
        }
        public static SingletonFour GetSingleton()
        {
            return InternalSingleton.Instance;
        }
        public void Show()
        {
            Console.WriteLine($"这是对象{this.GetType().Name}的Show方法");
        }

        private class InternalSingleton
        {
            internal static readonly SingletonFour Instance = null;
            static InternalSingleton()
            {
                Instance = new SingletonFour();
            }
        }
    }

}
