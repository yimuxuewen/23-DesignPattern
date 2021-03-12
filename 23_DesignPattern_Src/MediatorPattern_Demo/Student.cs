using System;
using System.Collections.Generic;
using System.Text;

namespace MediatorPattern_Demo
{
    class Student : BaseCharacter
    {
        public override void GetMessage(string message, BaseCharacter fromCharacter)
        {
            Console.WriteLine($"学生 {Name}收到 {fromCharacter.Name}发送的消息:{message}");
        }

        public override void SendMessage(string message, BaseCharacter toCharacter)
        {
            Console.WriteLine($"学生 {Name}向 {toCharacter.Name}发送消息:{message}");
            toCharacter.GetMessage(message, this);
        }
    }
}
