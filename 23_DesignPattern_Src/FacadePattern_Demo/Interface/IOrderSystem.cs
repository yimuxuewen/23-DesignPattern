using System;
using System.Collections.Generic;
using System.Text;

namespace FacadePattern_Demo
{
    interface IOrderSystem
    {
        bool CheckOrder(int userId, int productId,int cityId);

        void NewOrder(int userId, int productId, int cityId);

    }
}
