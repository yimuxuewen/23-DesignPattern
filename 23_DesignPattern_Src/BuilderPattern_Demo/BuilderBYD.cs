using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPattern_Demo
{
    public class BuilderBYD:AbstractBuilder
    {
        private Engine _engine;
        private Wheels _wheels;
        private Lights _lights;

        public override Car Car()
        {
            Console.WriteLine($"组装 {_engine} {_wheels} {_lights}");
            Console.WriteLine($"{this.GetType().Name} Build BYD");
            return new Car(_engine, _wheels, _lights) { Name="比亚迪"};

        }

        public override void Engine()
        {
            _engine = new Engine() { Name="引擎"};
            Console.WriteLine($"{this.GetType().Name} builder Engine");
        }

        public override void Lights()
        {
            _lights = new Lights() { Name = "车灯" };
            Console.WriteLine($"{this.GetType().Name} builder Lights");
        }

        public override void Wheels()
        {
            _wheels = new Wheels() { Name = "车轮" }; ;
            Console.WriteLine($"{this.GetType().Name} builder Wheels");
        }
    }
}
