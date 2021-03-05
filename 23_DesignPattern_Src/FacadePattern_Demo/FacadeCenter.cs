using System;
using System.Collections.Generic;
using System.Text;

namespace FacadePattern_Demo
{
    class FacadeCenter
    {
        int _userId, _productId, _cityId;
        public FacadeCenter(int userId,int productId,int cityId)
        {
            _userId = userId;
            _productId = productId;
            _cityId = cityId;
        }

        public void Check()
        {
            IUserSystem userSystem = new UserSystem();
            ILogisticsSystem logisticsSystem = new LogisticsSystem();
            IOrderSystem orderSystem = new OrderSystem();
            IStorageSystem storageSystem = new StorageSystem();

            if (!userSystem.CheckUser(_userId))
            {
                Console.WriteLine("用户检测失败");
            }
            else if (!storageSystem.CheckStorage(_productId, _cityId))
            {
                Console.WriteLine("仓储检测失败");
            }
            else if (!logisticsSystem.CheckLogistics(_productId, _cityId))
            {
                Console.WriteLine("物流检测失败");
            }
            else if (!orderSystem.CheckOrder(_userId, _productId, _cityId))
            {
                Console.WriteLine("订单检测失败");
            }
            else
            {
                orderSystem.NewOrder(_userId, _productId, _cityId);
                logisticsSystem.NewLogistics(_productId, _cityId);
            }
        }
    }
}
