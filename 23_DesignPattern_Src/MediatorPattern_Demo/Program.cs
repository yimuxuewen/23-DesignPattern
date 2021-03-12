using System;

namespace MediatorPattern_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseCharacter teacher = new Teacher() { Name = "Jike" };
            BaseCharacter master = new Master() { Name = "Lucy" };
            BaseCharacter student1 = new Student() { Name = "Lily" };
            BaseCharacter student2 = new Student() { Name = "Tom" };
            BaseCharacter student3 = new Student() { Name = "Luly" };
            BaseCharacter student4 = new Student() { Name = "Juck" };
            BaseCharacter student5 = new Student() { Name = "Maly" };

            BaseMediator mediator = new BaseMediator();
            mediator.AddCharactor(master);
            mediator.AddCharactor(student1);
            mediator.AddCharactor(student2);
            mediator.AddCharactor(student3);
            mediator.AddCharactor(student5);

            mediator.SendMessage("今天晚上的课取消！", master);
            Console.ReadLine();
        }
    }
}
