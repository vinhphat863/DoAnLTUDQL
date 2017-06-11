using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_LTQLUD.DAO
{
    class DonViDAO
    {
        public static List<DonViTinh> DanhSach()
        {
            var db = new PerfectAppEntities();
            return db.DonViTinhs.ToList();
        }
    }
}
