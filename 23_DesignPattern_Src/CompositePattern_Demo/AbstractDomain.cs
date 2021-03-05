using System;
using System.Collections.Generic;
using System.Text;

namespace CompositePattern_Demo
{
    abstract class AbstractDomain
    {
        public string Name { get; set; }
        public double Percent { get; set; }
        public abstract void Commission(double total);
        public abstract void AddDomain(params AbstractDomain[] abstractdomains);
    }
}
