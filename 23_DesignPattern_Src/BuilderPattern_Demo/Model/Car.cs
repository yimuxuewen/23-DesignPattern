using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPattern_Demo
{
    public class Car
    {
        Engine _engine;
        Wheels _wheels;
        Lights _lights;
        public Car(Engine engine, Wheels wheels, Lights lights)
        {
            _engine = engine;
            _wheels = wheels;
            _lights = lights;
        }
        public string Name { get; set; }

    }
}
