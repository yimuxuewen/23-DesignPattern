using AbstractFactoryPattern.Interface;
using System;

namespace AbstractFactoryPattern.AbstractFactory
{
    public abstract class AbstractFactory
    {
        public abstract IGroup CreateGroup();

        public abstract IGenerial CreateGenerial();

    }
}
