using System;

namespace StatePattern_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseLight light = new RedLight();
            LightContext context = new LightContext();
            context.CurrentLight = light;
            context.Show();
            context.Turn();
            context.Show();
            context.Turn();
            context.Show();
            context.Turn();
            Console.ReadLine();
        }
    }
}
