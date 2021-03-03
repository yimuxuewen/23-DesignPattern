using FactoryPattern.War3.Interface;
using System;

namespace FactoryPattern.FactoryMethod
{
    public interface IFactory
    {
        IRace CreateRace();
    }
}
