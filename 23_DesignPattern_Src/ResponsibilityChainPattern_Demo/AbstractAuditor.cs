using System;
using System.Collections.Generic;
using System.Text;

namespace ResponsibilityChainPattern_Demo
{
    abstract class AbstractAuditor
    {
        public AbstractAuditor NestAuditor { get; set; }

        public string Name { get; set; }

        public abstract bool Audit(Applicant applicant);
    }
}
