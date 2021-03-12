using System;
using System.Collections.Generic;
using System.Text;

namespace MediatorPattern_Demo
{
    class BaseMediator
    {
        private List<BaseCharacter> _baseCharacters = new List<BaseCharacter>();

        public void AddCharactor(BaseCharacter baseCharacter)
        {
            _baseCharacters.Add(baseCharacter);
        }

        public void SendMessage(string message,BaseCharacter character)
        {
            Console.WriteLine($"中介者发布信息：{message}");
            foreach (var item in _baseCharacters)
            {
                if (character!=item)
                {
                    item.GetMessage(message, character);
                }
            }
        }
    }
}
