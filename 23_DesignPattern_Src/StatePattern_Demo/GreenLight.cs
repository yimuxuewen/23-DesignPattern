using System;
using System.Collections.Generic;
using System.Text;

namespace StatePattern_Demo
{
    class GreenLight : BaseLight
    {
        public GreenLight()
        {
            base.CurrentLightColor = LightColor.Green;
        }
        public override void Show()
        {
            Console.WriteLine("绿灯，请通行！"); ;
        }

        public override void TurnContex(LightContext context)
        {
            context.CurrentLight=new YellowLight();
        }
    }
}
