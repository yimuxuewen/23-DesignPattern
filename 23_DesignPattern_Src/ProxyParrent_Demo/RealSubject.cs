using System;
using System.Collections.Generic;
using System.Text;

namespace ProxyParrent_Demo
{
    class RealSubject : ISubject
    {
        public void DoSomething()
        {
            Console.WriteLine("处理数据完成"); 
        }

        public void GetSomething()
        {
            Console.WriteLine("数据获取完成");
        }
    }
}
