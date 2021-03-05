using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern_Demo
{
    class DecoratorStudentVideo : DecoratorStudent
    {
        public DecoratorStudentVideo(AbstractStudent abstractStudent) : base(abstractStudent)
        {
        }

        public override void Study()
        {
            base.Study();
            Console.WriteLine($"对{_abstractStudent.Name}发送视频课件！");
        }
    }
}
