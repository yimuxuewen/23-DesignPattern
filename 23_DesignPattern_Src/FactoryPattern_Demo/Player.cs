using FactoryPattern.War3.Interface;
using FactoryPattern.War3.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern_Demo
{
    public class Player
    {
        public string Name { get; set; }

        /// <summary>
        /// 面向抽象编程  
        /// </summary>
        /// <param name="race"></param>
        public void Play(IRace race)
        {
            Console.WriteLine("****************************************");
            Console.WriteLine($"This is {this.Name} Play War3.{race.GetType().Name}");
        }

        /// <summary>
        /// 面向具体对象
        /// </summary>
        /// <param name="human"></param>
        public void PlayHuman(Human human)
        {
            Console.WriteLine("****************************************");
            Console.WriteLine($"This is {this.Name} Play War3.{human.GetType().Name}");
        }

    }
}
