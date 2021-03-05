using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern_Demo
{
    abstract class AbstractStudent
    {
        public string Name { get; set; }

        public abstract void Study();
    }
}
