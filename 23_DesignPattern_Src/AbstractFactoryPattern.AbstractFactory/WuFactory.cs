using AbstractFactoryPattern.Interface;
using AbstractFactoryPattern.Service;
using System;

namespace AbstractFactoryPattern.AbstractFactory
{
    public class WuFactory : AbstractFactory
    {
        public override IGroup CreateGroup()
        {
            return new WuGroup();
        }
        public override IGenerial CreateGenerial()
        {
            return new WuGeneral();
        }
    }
}
