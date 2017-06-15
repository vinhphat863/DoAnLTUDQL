using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;
namespace BUS
{
    public class PhanLoaiHangHoaBUS
    {
        public static List<PhanLoaiHangHoa> DanhSach()
        {
            return PhanLoaiHangHoaDAO.DanhSach();
        }
    }
}
