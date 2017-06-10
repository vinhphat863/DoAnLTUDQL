using DoAn_LTQLUD.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_LTQLUD.BUS
{
    class UserBUS
    {
        public static bool CheckTaiKhoan(string username, string password)
        {
            return UserDAO.CheckTaiKhoan(username,password);
        }
    }
}
