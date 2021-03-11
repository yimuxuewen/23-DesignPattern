using System;
using System.Collections.Generic;
using System.Text;

namespace ResponsibilityChainPattern_Demo
{
    class Charge : AbstractAuditor
    {
        public override bool Audit(Applicant applicant)
        {
            if (applicant.Hours<=24)
            {

                Console.WriteLine("主管同意了请假申请");
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
