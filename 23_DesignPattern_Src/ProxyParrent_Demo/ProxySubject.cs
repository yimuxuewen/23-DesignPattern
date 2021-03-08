using System;
using System.Collections.Generic;
using System.Text;

namespace ProxyParrent_Demo
{
    /// <summary>
    /// 代理模式，类似AOP面向切面编程
    /// 在不破坏封装的前提下，动态扩展功能
    /// 在代理类中增加缓存、权限、延时等功能
    /// </summary>
    class ProxySubject : ISubject
    {
        private static RealSubject _realSubject = null;

        private void Init()
        {
            _realSubject = new RealSubject();
        }
        public void DoSomething()
        {
            if (_realSubject!=null)
            {
                this.Init();
            }
            _realSubject.DoSomething();
        }

        public void GetSomething()
        {
            if (_realSubject != null)
            {
                this.Init();
            }
            _realSubject.GetSomething();
        }
    }
}
