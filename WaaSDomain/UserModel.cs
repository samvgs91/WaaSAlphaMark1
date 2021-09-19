using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WaaSDataAccess;

namespace WaaSDomain
{
    public class UserModel
    {
        UserDao userDao = new UserDao();
        public bool LoginUser(string UserNameOrEmail, string Password)
        {
            return userDao.Login(UserNameOrEmail, Password);
        }
        public bool CreateUser(string UserName, string Email, string Password)
        {
            return userDao.CreateUser(UserName, Email, Password);
        }
    }
}
