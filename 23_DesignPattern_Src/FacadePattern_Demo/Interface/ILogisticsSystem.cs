using System;
using System.Collections.Generic;
using System.Text;

namespace FacadePattern_Demo
{
    interface ILogisticsSystem
    {
        bool CheckLogistics(int productId, int cityId);

        void NewLogistics(int productId, int cityId);
    }
}
