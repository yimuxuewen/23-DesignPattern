using StrategyPattern.Interface;
using System;
using System.Reflection;

namespace StrategyPattern_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("请输入消费金额：");
                string price = Console.ReadLine();
                if (price == "q")
                {
                    break;
                }
                Customer customer = new Customer(double.Parse(price));

                Console.WriteLine("请输入优惠策略（1,2,3）");
                string strategys = Console.ReadLine();

                foreach (var item in strategys.Split(","))
                {
                    string strategykey = System.Configuration.ConfigurationManager.AppSettings[item];
                    Assembly assembly = Assembly.LoadFrom(strategykey.Split(",")[0]);
                    Type type = assembly.GetType(strategykey.Split(",")[1]);
                    IStrategy strategy = (IStrategy)Activator.CreateInstance(type);
                    customer.AddStrategy(strategy);
                }
                customer.Promoto();
            }
            Console.ReadLine();
        }
    }
}
