using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern_Demo
{
    class DecoratorStudentAnswer:DecoratorStudent
    {
        public DecoratorStudentAnswer(AbstractStudent abstractStudent):base(abstractStudent)
        {
        }

        public override void Study()
        {
            base.Study();
            Console.WriteLine($"对{_abstractStudent.Name}进行课后答疑！");
        }
    }
}
