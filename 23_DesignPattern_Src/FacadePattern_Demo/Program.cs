using System;

namespace FacadePattern_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            int userId = 12;
            int productId = 42;
            int cityId=77812;
            FacadeCenter facadeCenter = new FacadeCenter(userId, productId, cityId);
            Console.ReadLine();
        }
    }
}
