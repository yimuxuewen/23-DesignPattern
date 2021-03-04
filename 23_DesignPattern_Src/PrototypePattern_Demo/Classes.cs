using System;
using System.Collections.Generic;
using System.Text;

namespace PrototypePattern_Demo
{
    class Classes : ICloneable
    {
        public Classes()
        {
            Console.WriteLine($"{this.GetType().Name}被构造");
        }
        public int Id { get; set; }
        public string ClassName { get; set; }

        public object Clone()
        {
            return base.MemberwiseClone();
        }
    }
}
