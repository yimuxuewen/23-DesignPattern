using System;
using System.Threading.Tasks;

namespace SingletonPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                for (int i = 0; i < 10; i++)
                {
                    Task.WaitAll(
                    Task.Run(
                        () =>
                        {
                        //SingletonFirst singletonFirst = SingletonFirst.GetSingleton();
                        //SingletonSecond singletonsecond = SingletonSecond.GetSingleton();
                        //SingletonThird singletonthird = SingletonThird.GetSingleton();
                        //SingletonFour singletonfour = SingletonFour.GetSingleton();
                        Console.WriteLine(SingletonSecond.Name);
                        Console.WriteLine(SingletonFour.Name);
                        }
                    )
                   );
            }

            }
            catch (Exception)
            {

                throw;
            }
            Console.WriteLine("Hello World!");
        }
    }
}
