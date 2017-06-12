using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;
namespace BUS
{
    public class ChiTietPhieuNhapHangBUS
    {
        public static void Them(string MaPhieu, string MaHang, string MaDonVi, int SoLuong, double DonGia, string GhiChu)
        {
            ChiTietPhieuNhapHangDAO.Them(MaPhieu, MaHang, MaDonVi, SoLuong, DonGia, GhiChu);
        }
    }
}
