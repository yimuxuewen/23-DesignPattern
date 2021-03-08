using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InterpretPattern_Demo
{
    class JNInterpreter : BaseInterpret
    {
        private Dictionary<char, string> _dictInterpreter = new Dictionary<char, string>();

        public JNInterpreter()
        {
            _dictInterpreter.Add('j', "a");
            _dictInterpreter.Add('k', "b");
            _dictInterpreter.Add('l', "c");
            _dictInterpreter.Add('m', "d");
            _dictInterpreter.Add('n', "e");
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
