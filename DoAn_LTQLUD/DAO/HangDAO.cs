using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_LTQLUD.DAO
{
    class HangDAO
    {
        public static List<HangHoa> DanhSach()
        {
            var db = new PerfectAppEntities();
            return db.HangHoas.ToList();
        }
    }
}
