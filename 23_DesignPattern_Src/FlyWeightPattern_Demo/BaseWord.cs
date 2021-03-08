﻿using System;
using System.Collections.Generic;
using System.Text;

namespace FlyWeightPattern_Demo
{
    abstract class BaseWord
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime CreateTime { get; set; }

        public abstract string Get();
    }
}
