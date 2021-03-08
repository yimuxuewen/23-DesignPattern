using System;
using System.Collections.Generic;
using System.Text;

namespace InterpretPattern_Demo
{
    class AIInterpreter : BaseInterpret
    {
        private Dictionary<char, string> _dictInterpreter = new Dictionary<char, string>();

        public AIInterpreter()
        {
            _dictInterpreter.Add('a', "1");
            _dictInterpreter.Add('b', "2");
            _dictInterpreter.Add('c', "3");
            _dictInterpreter.Add('d', "4");
            _dictInterpreter.Add('e', "5");
            _dictInterpreter.Add('f', "6");
            _dictInterpreter.Add('g', "7");
            _dictInterpreter.Add('h', "8");
            _dictInterpreter.Add('i', "9");
        }
        public override string GetValue(string value)
        {
            List<string> listvalue = new List<string>();
            foreach (var item in value.ToLower())
            {
                if (_dictInterpreter.ContainsKey(item))
                {
                    listvalue.Add(_dictInterpreter[item]);
                }
                else
                {
                    listvalue.Add(item.ToString());
                }
            }
            return string.Concat(listvalue);
        }
    }
}
