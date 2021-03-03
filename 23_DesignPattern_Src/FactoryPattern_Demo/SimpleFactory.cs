using FactoryPattern.War3.Interface;
using FactoryPattern.War3.Service;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Runtime.Loader;
using System.Text;

namespace FactoryPattern_Demo
{
    public class SimpleFactory
    {
        private static string _raceTypeByConfig = System.Configuration.ConfigurationManager.AppSettings["IRaceConfig"];
        private static string _raceTypeByReflect = System.Configuration.ConfigurationManager.AppSettings["IRaceReflect"];
        public static IRace GetRace()
        {
            return new Human();
        }

        /// <summary>
        /// 通过传递参数创建实例类型
        /// </summary>
        /// <param name="raceType"></param>
        /// <returns></returns>
        public static IRace GetRace(RaceType raceType)
        {
            IRace race = null;
            switch (raceType)
            {
                case RaceType.Human:
                    race = new Human();
                    break;
                case RaceType.NE:
                    race = new NE();
                    break;
                case RaceType.ORC:
                    race = new ORC();
                    break;
                case RaceType.Undead:
                    race = new Undead();
                    break;
                default:
                    throw new Exception($"种族{raceType}不存在");
            }
            return race;
        }


        /// <summary>
        /// 从配置读取创建的实例类型
        /// </summary>
        /// <returns></returns>
        public static IRace GetRaceByConfig()
        {
            RaceType raceType =(RaceType)Enum.Parse(typeof(RaceType), _raceTypeByConfig);
            return GetRace(raceType);
        }

        private readonly static AssemblyLoadContext _context;
        /// <summary>
        /// 反射，通过配置读取需要反射的类型，来创建实例
        /// .NetCore 要想通过增加dll来创建新的实例，需在deps.json中增加扩展的dll
        /// </summary>
        /// <returns></returns>
        public static IRace GetRaceByReflect()
        {
            //Assembly assembly = Assembly.Load(_raceTypeByReflect.Split(",")[1]);
            Assembly assembly = Assembly.LoadFile(Path.Combine(Environment.CurrentDirectory, _raceTypeByReflect.Split(",")[1]));
            Type type = assembly.GetType(_raceTypeByReflect.Split(",")[0]);
            return (IRace)Activator.CreateInstance(type);
        }

    }

    public enum RaceType
    {
        Human,
        NE,
        ORC,
        Undead
    }
}
