using System;
using System.Collections.Generic;
using System.Text;

namespace VisitorPattern_Demo
{
    public abstract class AbstractStudent
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public abstract void GetVideo(IVisitor visitor);
    }
}
