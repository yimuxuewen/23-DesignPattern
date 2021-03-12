using System;

namespace MementoPattern_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Caretaker caretaker = new Caretaker();
            Console.WriteLine("**************人物创建**************");
            War3Player war3Player = new War3Player()
            {
                Name = "Lucy",
                Attack = "10",
                Breath = "100",
                Level = "1级小妖",
                Race = "杀杀杀"
            };
            caretaker.Save("1级进度", war3Player);
            Console.WriteLine($"玩家:{war3Player.Name}当前生命值:{war3Player.Breath},当前攻击力:{war3Player.Attack},当前等级：{war3Player.Level}");
            Console.WriteLine("**************刷怪升级**************");
            war3Player.Level = "3级小妖";
            war3Player.Breath = "120";
            war3Player.Attack = "30";

            caretaker.Save("3级进度", war3Player);
            Console.WriteLine($"玩家:{war3Player.Name}当前生命值:{war3Player.Breath},当前攻击力:{war3Player.Attack},当前等级：{war3Player.Level}");

            Console.WriteLine("**************闯关**************");
            war3Player.Breath = "0";
            war3Player.Attack = "30";
            Console.WriteLine($"玩家:{war3Player.Name}当前生命值:{war3Player.Breath},当前攻击力:{war3Player.Attack},当前等级：{war3Player.Level}");

            Console.WriteLine("**************闯关失败，加载存档**************");
            caretaker.Load("3级进度",ref war3Player);
            Console.WriteLine($"玩家:{war3Player.Name}当前生命值:{war3Player.Breath},当前攻击力:{war3Player.Attack},当前等级：{war3Player.Level}");

            Console.ReadLine() ;
        }
    }
}
