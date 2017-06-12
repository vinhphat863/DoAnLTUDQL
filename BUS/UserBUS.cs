using DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class UserBUS
    {
        public static bool CheckUser(string username,string password)
        {
            return UserDAO.CheckUser(username, password);
        }
    }
}
