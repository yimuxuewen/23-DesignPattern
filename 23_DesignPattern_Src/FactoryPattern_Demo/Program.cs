using FactoryPattern.FactoryMethod;
using FactoryPattern.War3.Interface;
using FactoryPattern.War3.Service;
using System;

namespace FactoryPattern_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Environment.CurrentDirectory);
            Player player = new Player() { Name = "Jim" };
            {
                //面向具体
                Human human = new Human();
                player.PlayHuman(human);
            }

            {
                //面向抽象
                IRace race = new Human();
                player.Play(race);
            }

            {
                //简单工厂
                IRace race = SimpleFactory.GetRace(RaceType.Undead);
                player.Play(race);
            }

            {
                //通过配置创建
                IRace race = SimpleFactory.GetRaceByConfig();
                player.Play(race);
            }

            {
                //通过反射创建
                IRace race = SimpleFactory.GetRaceByReflect();
                player.Play(race);
            }

            //{
            //    //通过工厂方法创建
            //    IFactory factory = new HumanFactory();
            //    IRace race = factory.CreateRace();
            //    player.Play(race);
            //}

            {
                //通过配置反射 工厂方法创建
                IFactory factory = FactoryMethod.GetFactory();
                IRace race = factory.CreateRace();
                player.Play(race);
            }

            Console.ReadLine();
        }
    }
}
