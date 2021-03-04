using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPattern_Demo
{
    public abstract class AbstractBuilder
    {
        public abstract void Engine();

        public abstract void Wheels();
        public abstract void Lights();
        public abstract Car Car();

    }
}
