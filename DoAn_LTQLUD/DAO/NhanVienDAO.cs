using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_LTQLUD.DAO
{
    class NhanVienDAO
    {
        public static List<NhanVien> DanhSach()
        {
            var db = new PerfectAppEntities();
            return db.NhanViens.ToList();
        }
    }
}
