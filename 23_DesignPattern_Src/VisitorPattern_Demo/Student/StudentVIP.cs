using System;
using System.Collections.Generic;
using System.Text;

namespace VisitorPattern_Demo
{
    public class StudentVIP : AbstractStudent
    {
        public override void GetVideo(IVisitor visitor)
        {
            visitor.GetVideoVIP(this);
        }
    }
}
