using System;
using System.Collections.Generic;
using System.Text;

namespace StatePattern_Demo
{
    class RedLight : BaseLight
    {
        public RedLight()
        {
            base.CurrentLightColor = LightColor.Red;
        }
        public override void Show()
        {
            Console.WriteLine("红灯，静止通行！"); ;
        }

        public override void TurnContex(LightContext context)
        {
            context.CurrentLight = new GreenLight() ;
        }
    }
}
