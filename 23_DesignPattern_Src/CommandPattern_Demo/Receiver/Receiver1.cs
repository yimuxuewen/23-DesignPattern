using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern_Demo
{
    class Receiver2: IReceiver
    {
       public void Read()
        {
            Console.WriteLine($"{this.GetType().Name}:Read2");
        }
        public void Write()
        {
            Console.WriteLine($"{this.GetType().Name}:Write2");

        }
        public void Save()
        {
            Console.WriteLine($"{this.GetType().Name}:Save2");

        }
    }
}
