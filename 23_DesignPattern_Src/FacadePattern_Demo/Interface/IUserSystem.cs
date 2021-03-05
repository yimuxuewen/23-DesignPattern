using System;
using System.Collections.Generic;
using System.Text;

namespace FacadePattern_Demo
{
    interface IUserSystem
    {
        bool CheckUser(int userId);

        void NewUser(int userId);

    }
}
