using System;

namespace IteratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseMenu kFCMenu = new KFCMenu();
            BaseMenu macDonaldMenu = new MacDonaldMenu();

            MenuItorator kFCmenuItorator = new MenuItorator(kFCMenu);
            MenuItorator macDonaldItorator = new MenuItorator(macDonaldMenu);

            while (kFCmenuItorator.MoveNext())
            {
                Food food = kFCmenuItorator.Current();
                Console.WriteLine($"菜品：{food.Name} 价格：${food.Price}");
            }
            while (macDonaldItorator.MoveNext())
            {
                Food food = macDonaldItorator.Current();
                Console.WriteLine($"菜品：{food.Name} 价格：${food.Price}");
            }

            Console.ReadLine() ;
        }
    }
}
