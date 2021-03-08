using System;
using System.Collections.Generic;

namespace InterpretPattern_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<BaseInterpret> baseInterprets = new List<BaseInterpret>()
            {
                new JNInterpreter(),
                new AIInterpreter(),
                new OtherInterpreter()
            };
            string str = "aHraskdj";
            Console.WriteLine($"需要解析的字符串为{str}");
            foreach (var item in baseInterprets)
            {
                str= item.GetValue(str);
            }
            Console.WriteLine($"解释后的字符串为{str}");
            Console.ReadLine();
        }
    }
}
