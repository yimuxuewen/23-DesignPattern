using System;

namespace DecoratorPattern_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractStudent student = new Student() { Name = "Tom" };
            student = new DecoratorStudentHomework(student);
            student = new DecoratorStudentVideo(student);
            student = new DecoratorStudentAnswer(student);
            student = new DecoratorStudentPreview(student);
            student.Study();
            Console.ReadLine();
        }
    }
}
