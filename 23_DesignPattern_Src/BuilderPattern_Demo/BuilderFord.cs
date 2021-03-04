using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPattern_Demo
{
    public class BuilderFord : AbstractBuilder
    {
        private Engine _engine;
        private Wheels _wheels;
        private Lights _lights;

        public override Car Car()
        {
            Console.WriteLine($"组装 {_engine} {_wheels} {_lights}");
            Console.WriteLine($"{this.GetType().Name} Build BYD");
            return new Car(_engine, _wheels, _lights) { Name = "福特" };
        }

        public override void Engine()
        {
            _engine = new Engine();
            Console.WriteLine($"{this.GetType().Name} builder Engine");
        }

        public override void Lights()
        {
            _lights = new Lights();
            Console.WriteLine($"{this.GetType().Name} builder Lights");
        }

        public override void Wheels()
        {
            _wheels = new Wheels();
            Console.WriteLine($"{this.GetType().Name} builder Wheels");
        }
    }
}
