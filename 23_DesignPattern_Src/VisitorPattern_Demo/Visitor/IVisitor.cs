using System;
using System.Collections.Generic;
using System.Text;

namespace VisitorPattern_Demo
{
    public interface IVisitor
    {
        public void GetVideoVIP(AbstractStudent student);

        public void GetVideoFree(AbstractStudent student);
    }
}
