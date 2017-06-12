using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAO
{
    public class HangHoaDAO
    {
        public static List<HangHoa> DanhSach()
        {
            var db = new PerfectAppEntities();
            return db.HangHoas.ToList();
        }
    }
}
