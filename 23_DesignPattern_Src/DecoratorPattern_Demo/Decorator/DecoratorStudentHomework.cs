using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern_Demo
{
    class DecoratorStudentHomework : DecoratorStudent
    {
        public DecoratorStudentHomework(AbstractStudent abstractStudent):base(abstractStudent)
        {
        }

        public override void Study()
        {
            base.Study();
            Console.WriteLine($"对{_abstractStudent.Name}进行家庭作业布置！");
        }
    }
}
