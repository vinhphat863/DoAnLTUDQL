using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;
namespace BUS
{
    public class KhachHangBUS
    {
        public static List<KhachHangDTO> DanhSach()
        {
            return KhachHangDAO.DanhSach();
        }
    }
}
