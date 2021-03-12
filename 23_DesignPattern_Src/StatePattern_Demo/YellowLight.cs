using System;
using System.Collections.Generic;
using System.Text;

namespace StatePattern_Demo
{
    class YellowLight : BaseLight
    {
        public YellowLight()
        {
            base.CurrentLightColor = LightColor.Yellow;
        }
        public override void Show()
        {
            Console.WriteLine("黄灯，等一等"); ;
        }

        public override void TurnContex(LightContext context)
        {
            context.CurrentLight = new GreenLight() ;
        }
    }
}
