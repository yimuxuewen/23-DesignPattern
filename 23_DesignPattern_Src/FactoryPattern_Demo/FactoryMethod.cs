using FactoryPattern.FactoryMethod;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;

namespace FactoryPattern_Demo
{
    public class FactoryMethod
    {
        private static string _factoryByReflect = System.Configuration.ConfigurationManager.AppSettings["IFactoryReflect"];

        public static IFactory GetFactory()
        {
            Assembly assembly = Assembly.LoadFile(Path.Combine(Environment.CurrentDirectory, _factoryByReflect.Split(",")[1]));
            Type type = assembly.GetType(_factoryByReflect.Split(",")[0]);
            return (IFactory)Activator.CreateInstance(type);
        }
    }
}
