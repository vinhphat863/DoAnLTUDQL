using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAO
{
    public class NhomHangDAO
    {
        public static List<NhomHang> DanhSach()
        {
            var db = new PerfectAppEntities();
            return db.NhomHangs.ToList();
        }
    }
}
