using FactoryPattern.War3.Interface;
using FactoryPattern.War3.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern.FactoryMethod
{
    public class UndeadFactory : IFactory
    {
        public IRace CreateRace()
        {
            return new Undead();
        }
    }
}
