using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;
namespace BUS
{
    public class PhieuNhapHangBUS
    {
        public static string LayMaPhieu()
        {
            return PhieuNhapHangDAO.LayMaPhieu();
        }
        public static void Them(string MaPhieu, string MaNCC, string DiaChi, string DienThoai, DateTime Ngay, string GhiChu, string SoHoaDonVAT, string SoHoaDonVietTay, string MaNV, string MaKho, string MaDKTT, string MaHTTT, DateTime HTT)
        {
            PhieuNhapHangDAO.Them(MaPhieu, MaNCC, DiaChi, DienThoai, Ngay, GhiChu, SoHoaDonVAT, SoHoaDonVietTay, MaNV, MaKho, MaDKTT, MaHTTT, HTT);
        }
    }
}
