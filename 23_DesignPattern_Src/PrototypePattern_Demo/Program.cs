using System;

namespace PrototypePattern_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            PrototypeStudent prototypeStudent = new PrototypeStudent()
            {
                Id = 1,
                Name = "张三",
                ClassesInfo = new Classes()
                {
                    Id = 1,
                    ClassName = "一班"
                }
            };
            PrototypeStudent prototypeStudent1 = (PrototypeStudent)prototypeStudent.Clone();
            PrototypeStudent prototypeStudent2 = (PrototypeStudent)prototypeStudent.Clone();
            prototypeStudent1.Name = "Lily";
            prototypeStudent1.ClassesInfo.ClassName = "二班";
            prototypeStudent2.Name = "Lucy";
            prototypeStudent2.ClassesInfo.ClassName = "三班";

            prototypeStudent.Study();
            prototypeStudent1.Study();
            prototypeStudent2.Study();
            Console.ReadLine();
        }
    }
}
