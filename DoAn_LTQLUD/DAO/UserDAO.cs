using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_LTQLUD.DAO
{
    class UserDAO
    {
        public static bool CheckTaiKhoan(string username, string password)
        {
            bool kq = false;
            var db = new PerfectAppEntities();
            var user = db.UserIDs.FirstOrDefault(u => u.username == username && u.password == password);
            if (user != null)
            {
                kq = true;
            }
            return kq;
        }
    }
}
