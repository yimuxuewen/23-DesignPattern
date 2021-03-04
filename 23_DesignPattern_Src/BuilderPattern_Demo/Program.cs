using System;

namespace BuilderPattern_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Director director = new Director(new BuilderBYD());
            director.BuilderCar();
            Console.ReadLine();
        }
    }
}
