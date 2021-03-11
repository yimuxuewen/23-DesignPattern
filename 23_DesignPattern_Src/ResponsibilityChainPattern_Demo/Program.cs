using System;

namespace ResponsibilityChainPattern_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Applicant applicant = new Applicant()
            {
                Name = "Lucy",
                Hours = 10,
                Reasons = "回家休息"
            };
            AbstractAuditor manager = new Manager()
            {
                Name = "Lily"
            };
            AbstractAuditor charge = new Charge()
            {
                Name = "Tom"
            };
            AbstractAuditor ceo = new CEO()
            {
                Name = "Jack"
            };
            manager.NestAuditor = charge;
            charge.NestAuditor = ceo;
            manager.Audit(applicant);

            Console.ReadLine();
        }
    }
}
