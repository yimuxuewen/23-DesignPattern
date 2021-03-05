using System;
using System.Collections.Generic;
using System.Text;

namespace FacadePattern_Demo
{
    interface IStorageSystem
    {
        bool CheckStorage(int productId, int cityId);

        void NewStorage(int productId, int cityId);

    }
}
