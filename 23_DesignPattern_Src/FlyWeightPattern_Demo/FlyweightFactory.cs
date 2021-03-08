using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.Concurrent;

namespace FlyWeightPattern_Demo
{
    class FlyweightFactory
    {
        private ConcurrentDictionary<WordType, BaseWord> _dictBaseWord = new ConcurrentDictionary<WordType, BaseWord>();

        public BaseWord GetWord(WordType wordType)
        {
            if (_dictBaseWord.ContainsKey(wordType))
            {
                return _dictBaseWord[wordType];
            }
            else
            {
                switch (wordType)
                {
                    case WordType.A:
                        _dictBaseWord.AddOrUpdate(wordType, new A(), (k, v) => new A());
                        break;
                    case WordType.G:
                        _dictBaseWord.AddOrUpdate(wordType, new G(), (k, v) => new G());
                        break;
                    case WordType.N:
                        _dictBaseWord.AddOrUpdate(wordType, new N(), (k, v) => new N());
                        break;
                    case WordType.Y:
                        _dictBaseWord.AddOrUpdate(wordType, new Y(), (k, v) => new Y());
                        break;
                    default:
                        throw new Exception($"字符类型{wordType}不存在！");
                }
            }
            return _dictBaseWord[wordType];
        }

    }
    enum WordType
    {
        A,
        G,
        N,
        Y
    }
}
