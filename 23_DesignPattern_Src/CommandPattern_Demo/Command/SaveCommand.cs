using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern_Demo
{
    class SaveCommand : BaseCommand
    {
        public override void Excute()
        {
            this._receiver.Save();
        }
    }
}
