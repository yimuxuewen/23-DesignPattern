using System;
using System.Collections.Generic;
using System.Text;

namespace VisitorPattern_Demo
{
    class VisitorCurrent : IVisitor
    {
        public void GetVideoFree(AbstractStudent student)
        {
            Console.WriteLine("只能获取当前源码"); 
        }

        public void GetVideoVIP(AbstractStudent student)
        {
            Console.WriteLine("获取全套源码");

        }
    }
}
