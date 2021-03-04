using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPattern_Demo
{
    public class Director
    {
        private AbstractBuilder _abstractBuilder = null;
        public Director(AbstractBuilder abstractBuilder)
        {
            _abstractBuilder = abstractBuilder;
        }
        public void BuilderCar()
        {
            _abstractBuilder.Engine();
            _abstractBuilder.Wheels();
            _abstractBuilder.Lights();
            _abstractBuilder.Car();
        }
    }
}
