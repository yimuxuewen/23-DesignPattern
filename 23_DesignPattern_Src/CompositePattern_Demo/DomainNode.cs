using System;
using System.Collections.Generic;
using System.Text;

namespace CompositePattern_Demo
{
    class DomainNode : AbstractDomain
    {
        List<AbstractDomain> _listDomains = new List<AbstractDomain>();
        public override void AddDomain(params AbstractDomain[] abstractdomains)
        {
            foreach (var abstractdomain in abstractdomains)
            {
                _listDomains.Add(abstractdomain);
            }
        }

        public override void Commission(double total)
        {
            double result=total*Percent/100;
            Console.WriteLine($"{Name}的提成是：{result}");
            foreach (var item in _listDomains)
            {
                item.Commission(result);
            }
        }
    }
}
