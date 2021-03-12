using System;

namespace ObserverPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                Console.WriteLine("************************基于对象的观察者模式************************");
                Cat cat = new Cat();
                Dog dog = new Dog();
                cat.AddObserver(dog);
                cat.AddObserver(new Mother());
                cat.AddObserver(new Chicken());

                cat.Mewing();

                cat.RemoveObserver(dog);
                cat.Mewing();
            }
            {
                Console.WriteLine("************************基于事件的观察者模式************************");
                Cat cat = new Cat();
                Chicken chicken = new Chicken();
                cat.MiaoEvent += new Dog().Bark;
                cat.MiaoEvent += new Mother().Coax;
                cat.MiaoEvent += chicken.Fly;

                cat.MewingEvent();

                cat.MiaoEvent -= chicken.Fly;
                cat.MewingEvent();


            }
            Console.ReadLine() ;
        }
    }
}
