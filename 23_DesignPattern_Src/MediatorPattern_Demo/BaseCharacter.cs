using System;
using System.Collections.Generic;
using System.Text;

namespace MediatorPattern_Demo
{
    abstract class BaseCharacter
    {
        public string Name { get; set; }

        public abstract void SendMessage(string message,BaseCharacter toCharacter);

        public abstract void GetMessage(string message, BaseCharacter fromCharacter);
    }
}
