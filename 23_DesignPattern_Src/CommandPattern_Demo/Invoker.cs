using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern_Demo
{
    class Invoker
    {
        protected BaseCommand _command = null;

        public Invoker(BaseCommand command)
        {
            _command = command;
        }

        public void InvokeExcute()
        {
            _command.Excute();
        }
    }
}
