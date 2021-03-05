using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern_Demo
{
    class DecoratorStudentPreview : DecoratorStudent
    {
        public DecoratorStudentPreview(AbstractStudent abstractStudent):base(abstractStudent)
        {
        }

        public override void Study()
        {
            Console.WriteLine($"{_abstractStudent.Name}在进行课前预习！");
            base.Study();
        }
    }
}
