using System;
using System.Collections.Generic;
using System.Text;

namespace ResponsibilityChainPattern_Demo
{
    class CEO : AbstractAuditor
    {
        public override bool Audit(Applicant applicant)
        {
            if (applicant.Hours<=120)
            {
                Console.WriteLine("经理同意了请假申请");
                return true;
            }
            else
            {
                if (NestAuditor!=null)
                {
                    return NestAuditor.Audit(applicant);
                }
                return false;

            }
        }
    }
}
