using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAO
{
    public class PhanLoaiHangHoaDAO
    {
        public static List<PhanLoaiHangHoa> DanhSach()
        {
            var db = new PerfectAppEntities();
            return db.PhanLoaiHangHoas.ToList();
        }
    }
}
