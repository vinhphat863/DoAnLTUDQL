using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAO
{
    public class UserDAO
    {
        public static bool CheckUser(string username,string password)
        {
            bool kq = false;
            var db = new PerfectAppEntities();
            var rs = db.UserIDs.SingleOrDefault(u => u.username == username && u.password == password);
            if(rs != null)
            {
                kq = true;
            }
            return kq;
        }
    }
}
