using System;
using System.Collections.Generic;
using System.Text;

namespace FacadePattern_Demo
{
    class UserSystem : IUserSystem
    {
        public bool CheckUser(int userId)
        {
            return true;
        }

        public void NewUser(int userId)
        {
            Console.WriteLine($"新增用户{userId}"); ;
        }
    }
}
