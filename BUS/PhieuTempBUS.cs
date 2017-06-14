using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;
using System.ComponentModel;

namespace BUS
{
    public class PhieuTempBUS
    {
        public static BindingList<PhieuTemp> DanhSach()
        {
            return PhieuTempDAO.DanhSach();
        }
        public static List<PhieuTempDTO> DanhSachHangHienThi()
        {
            return PhieuTempDAO.DanhSachHangHienThi();
        }
    }
}
