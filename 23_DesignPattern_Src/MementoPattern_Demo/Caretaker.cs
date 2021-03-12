using System;
using System.Collections.Generic;
using System.Text;

namespace MementoPattern_Demo
{
    class Caretaker
    {
        private Dictionary<string, War3Mementor> _mementoDict = new Dictionary<string, War3Mementor>();

        public void Save(string name,War3Player war3Player)
        {
            War3Mementor war3Mementor = new War3Mementor()
            {
                Attack = war3Player.Attack,
                Breath = war3Player.Breath,
                Level = war3Player.Level
            };
            _mementoDict.Add(name, war3Mementor);
        }

        public void Load(string name,ref War3Player war3Player)
        {
            if (_mementoDict.ContainsKey(name))
            {
                War3Mementor war3Mementor = _mementoDict[name];
                war3Player.Attack = war3Mementor.Attack;
                war3Player.Breath = war3Mementor.Breath;
                war3Mementor.Level = war3Mementor.Level;
            }
        }
    }
}
