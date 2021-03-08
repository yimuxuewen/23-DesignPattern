using System;
using System.Collections.Generic;
using System.Text;

namespace InterpretPattern_Demo
{
    class OtherInterpreter : BaseInterpret
    {
        private Dictionary<char, string> _dictInterpreter = new Dictionary<char, string>();

        public OtherInterpreter()
        {
            _dictInterpreter.Add('1', "1");
            _dictInterpreter.Add('2', "2");
            _dictInterpreter.Add('3', "3");
            _dictInterpreter.Add('4', "4");
            _dictInterpreter.Add('5', "5");
            _dictInterpreter.Add('6', "6");
            _dictInterpreter.Add('7', "7");
            _dictInterpreter.Add('8', "8");
            _dictInterpreter.Add('9', "9");
        }
        public override string GetValue(string value)
        {
            List<string> listvalue = new List<string>();
            foreach (var item in value.ToLower())
            {
                if (!_dictInterpreter.ContainsKey(item))
                {
                    listvalue.Add("0");
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
