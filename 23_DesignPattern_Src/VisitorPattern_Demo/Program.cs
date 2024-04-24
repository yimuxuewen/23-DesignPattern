using System;
using System.Collections.Generic;

namespace VisitorPattern_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<AbstractStudent> list = new List<AbstractStudent>()
            {
                new StudentFree()
                {Name="Lucy",Age=23 },
                new StudentVIP()
                {Name="Lily",Age=23 },
            };
            IVisitor visitor = new VisitorCurrent();
            foreach (var item in list)
            {
                item.GetVideo(visitor);
            }
            Console.ReadLine();
        }
    }
}
