using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern_Demo
{
    class DecoratorStudent : AbstractStudent
    {
        protected internal AbstractStudent _abstractStudent = null;
        public DecoratorStudent(AbstractStudent abstractStudent)
        {
            this._abstractStudent = abstractStudent;
            Name = abstractStudent.Name;
        }

        public override void Study()
        {
            this._abstractStudent.Study();
        }
    }
}
