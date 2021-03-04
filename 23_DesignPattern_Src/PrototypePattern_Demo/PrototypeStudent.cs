using System;
using System.Collections.Generic;
using System.Text;

namespace PrototypePattern_Demo
{
    class PrototypeStudent:ICloneable
    {
        public PrototypeStudent()
        {
            Console.WriteLine($"{this.GetType().Name}被构造");
        }
        public int Id { get; set; }
        public string Name { get; set; }

        public Classes ClassesInfo { get; set; }


        public object Clone()
        {
            PrototypeStudent _prototypeStudent = (PrototypeStudent)base.MemberwiseClone();
            _prototypeStudent.ClassesInfo = (Classes)_prototypeStudent.ClassesInfo.Clone();
            return _prototypeStudent;
        }

        public void Study()
        {
            Console.WriteLine($"班级{ClassesInfo.ClassName}的学生{Name}正在学习");
        }
    }
}
