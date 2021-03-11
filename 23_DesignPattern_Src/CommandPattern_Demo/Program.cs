using System;

namespace CommandPattern_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            //System.Configuration.ConfigurationManager.AppSettings["IFactoryReflect"]
            Document document = new Document();
            IReceiver receiver = new Receiver1();
            Invoker invoker = null;
            while (true)
            {
                string type = Console.ReadLine();
                if (type=="q")
                {
                    break;
                }
                string assm = System.Configuration.ConfigurationManager.AppSettings[type];
                if (string.IsNullOrEmpty(assm))
                {
                    Console.WriteLine("输入的操作不存在，请重新输入！");
                    type = Console.ReadLine();
                }
                else
                {
                    BaseCommand command =(BaseCommand) Activator.CreateInstanceFrom(assm.Split(",")[1], assm.Split(",")[0]).Unwrap();
                    command.SetReceiver(receiver);
                    command.SetDocument(document);

                    invoker = new Invoker(command);
                    invoker.InvokeExcute();
                }

            }
            Console.ReadLine();
        }
    }
}
