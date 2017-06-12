using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAO
{
    public class DieuKhoanThanhToanDAO
    {
        public static List<DieuKhoanThanhToan> DanhSach()
        {
            var db = new PerfectAppEntities();
            return db.DieuKhoanThanhToans.ToList();
        }
    }
}
