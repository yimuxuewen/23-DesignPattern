using System;
using System.Collections.Generic;
using System.Text;

namespace FacadePattern_Demo
{
    class OrderSystem : IOrderSystem
    {
        public bool CheckOrder(int userId, int productId, int cityId)
        {
            return true;
        }

        public void NewOrder(int userId, int productId, int cityId)
        {
            Console.WriteLine($"增加来自{cityId}的用户{userId}产品{productId}的订单"); ;
        }

    }
}
