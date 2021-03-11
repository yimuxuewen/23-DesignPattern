using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern_Demo
{
    class WriteCommand : BaseCommand
    {
        public override void Excute()
        {
            this._receiver.Write();
        }
    }
}
