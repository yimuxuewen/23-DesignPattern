using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern_Demo
{
    class Receiver1: IReceiver
    {
       public void Read()
        {
            Console.WriteLine($"{this.GetType().Name}:Read1");
        }
        public void Write()
        {
            Console.WriteLine($"{this.GetType().Name}:Write1");

        }
        public void Save()
        {
            Console.WriteLine($"{this.GetType().Name}:Save1");

        }
    }
}
