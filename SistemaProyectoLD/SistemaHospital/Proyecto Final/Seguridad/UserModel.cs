using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final
{
    internal class UserModel
    {
        UserDao userDao = new UserDao();
        public bool LoginUser(string usuario, string contraseña)
        {
            return userDao.Login(usuario, contraseña);
        }
        

    }
}
