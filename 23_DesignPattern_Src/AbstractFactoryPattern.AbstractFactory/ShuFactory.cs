using AbstractFactoryPattern.Interface;
using AbstractFactoryPattern.Service;
using System;

namespace AbstractFactoryPattern.AbstractFactory
{
    public class ShuFactory : AbstractFactory
    {
        public override IGroup CreateGroup()
        {
            return new ShuGroup();
        }
        public override IGenerial CreateGenerial()
        {
            return new ShuGeneral();
        }
    }
}
