using System;
using System.Collections.Generic;
using System.Text;

namespace StatePattern_Demo
{
    abstract class BaseLight
    {
        public LightColor CurrentLightColor { get; set; }
        public abstract void Show();

        public abstract void TurnContex(LightContext context);
    }

    enum LightColor
    {
        Yellow,
        Red,
        Green
    }
}
