using System;

namespace TemplateMethodPattern_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseDepositor normal = new NormalDepositor();
            BaseDepositor vip = new VIPDepositor();
            normal.Query("张三");
            vip.Query("Lily"); 
            Console.ReadLine();
        }
    }
}
