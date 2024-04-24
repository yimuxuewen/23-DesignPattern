using System;
using System.Collections.Generic;
using System.Text;

namespace VisitorPattern_Demo
{
    public class StudentFree : AbstractStudent
    {
        public override void GetVideo(IVisitor visitor)
        {
            visitor.GetVideoFree(this);
        }
    }
}
