using System;
using System.Collections.Generic;
using System.Text;

namespace StatePattern_Demo
{
    class LightContext
    {
        public BaseLight CurrentLight { get; set; }

        public void Show()
        {
            CurrentLight.Show();
        }

        public void Turn()
        {
            CurrentLight.TurnContex(this);
        }
    }
}
