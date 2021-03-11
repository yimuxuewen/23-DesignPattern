using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern_Demo
{
    public interface IReceiver
    {
        public void Read();
        public void Write();
        public void Save();
    }
}
