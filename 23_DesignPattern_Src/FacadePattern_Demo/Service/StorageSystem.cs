using System;
using System.Collections.Generic;
using System.Text;

namespace FacadePattern_Demo
{
    class StorageSystem : IStorageSystem
    {
        public bool CheckStorage(int productId, int cityId)
        {
            return true;
        }

        public void NewStorage(int productId, int cityId)
        {
            Console.WriteLine($"来自城市{cityId}的产品订单{productId}的物流信息"); ;
        }
    }
}
