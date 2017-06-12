using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAO
{
    public class HinhThucThanhToanDAO
    {
        public static List<HinhThucThanhToan> DanhSach()
        {
            var db = new PerfectAppEntities();
            return db.HinhThucThanhToans.ToList();
        }
    }
}
