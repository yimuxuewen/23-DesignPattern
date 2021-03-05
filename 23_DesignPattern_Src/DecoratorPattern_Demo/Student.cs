using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern_Demo
{
    class Student : AbstractStudent
    {
        public override void Study()
        {
            Console.WriteLine($"学生{ Name}正在学习"); 
        }
    }
}
