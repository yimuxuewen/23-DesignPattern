using System;
using System.Collections.Generic;
using System.Text;

namespace CompositePattern_Demo
{
    class DomainLeaf : AbstractDomain
    {
        public override void AddDomain(params AbstractDomain[] abstractdomains)
        {
            throw new Exception("不允许添加子节点");
        }

        public override void Commission(double total)
        {
            double result=total*Percent/100;
            Console.WriteLine($"{Name}的提成是：{result}");
        }
    }
}
