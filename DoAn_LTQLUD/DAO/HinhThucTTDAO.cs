using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_LTQLUD.DAO
{
    class HinhThucTTDAO
    {
        public static List<HinhThucThanhToan> DanhSach()
        {
            var db = new PerfectAppEntities();
            return db.HinhThucThanhToans.ToList();
        }
    }
}
