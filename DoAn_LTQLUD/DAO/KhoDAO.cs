using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_LTQLUD.DAO
{
    class KhoDAO
    {
        public static List<KhoHang> DanhSach()
        {
            var db = new PerfectAppEntities();
            return db.KhoHangs.ToList();
        }
    }
}
