using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAO
{
    public class DonViDAO
    {
        public static List<DonViTinh> DanhSach()
        {
            var db = new PerfectAppEntities();
            return db.DonViTinhs.ToList();
        }
    }
}
