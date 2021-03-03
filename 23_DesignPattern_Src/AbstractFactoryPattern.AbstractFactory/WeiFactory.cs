using AbstractFactoryPattern.Interface;
using AbstractFactoryPattern.Service;
using System;

namespace AbstractFactoryPattern.AbstractFactory
{
    public class WeiFactory : AbstractFactory
    {
        public override IGroup CreateGroup()
        {
            return new WeiGroup();
        }
        public override IGenerial CreateGenerial()
        {
            return new WeiGeneral();
        }
    }
}
