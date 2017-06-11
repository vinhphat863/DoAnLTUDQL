using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_LTQLUD.DAO
{
    class DieuKhoanTTDAO
    {
        public static List<DieuKhoanThanhToan> DanhSach()
        {
            var db = new PerfectAppEntities();
            return db.DieuKhoanThanhToans.ToList();
        }
    }
}
