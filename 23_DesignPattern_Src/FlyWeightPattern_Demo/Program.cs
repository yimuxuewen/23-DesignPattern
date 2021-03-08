using System;
using System.Threading.Tasks;

namespace FlyWeightPattern_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            FlyweightFactory flyweightFactory = new FlyweightFactory();
            Task.WaitAll(
                Task.Run(
                    () =>
                    {
                        for (int i = 0; i < 10; i++)
                        {
                            BaseWord baseWordY = flyweightFactory.GetWord(WordType.Y);
                            BaseWord baseWordA = flyweightFactory.GetWord(WordType.A);
                            BaseWord baseWordN = flyweightFactory.GetWord(WordType.N);
                            BaseWord baseWordG = flyweightFactory.GetWord(WordType.G);
                            Console.WriteLine($"{ baseWordY.Get()}{ baseWordA.Get()}{ baseWordN.Get()}{ baseWordG.Get()}");
                        }
                    }
                    ));

            Console.ReadLine();
        }
    }
}
