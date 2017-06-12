using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAO
{
    public class NhaCungCapDAO
    {
        public static List<NhaCungCap> DanhSach()
        {
            
            var db = new PerfectAppEntities();
            return db.NhaCungCaps.ToList();
        }
    }
}
