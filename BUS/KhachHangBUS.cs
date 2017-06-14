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
        public static void Them(string MaKH, string MaKV, string TenKH, string DiaChi, string MaSoThue, string DienThoai, string Email, string TaiKhoan, int GioiHanNo, int NoHienTai, string NganHang, string NguoiLienHe, bool ConQuanLy)
        {
            KhachHangDAO.Them(MaKH, MaKV, TenKH, DiaChi, MaSoThue, DienThoai, Email, TaiKhoan, GioiHanNo, NoHienTai, NganHang, NguoiLienHe, ConQuanLy);
        }
        public static string LayMaKH()
        {
            return KhachHangDAO.LayMaKH();
        }
        public static KhachHang ChiTietKH(string MaKH)
        {
            return KhachHangDAO.ChiTietKH(MaKH);
        }
        public static void Sua(string MaKH, string MaKV, string TenKH, string DiaChi, string MaSoThue, string DienThoai, string Email, string TaiKhoan, int GioiHanNo, int NoHienTai, string NganHang, string NguoiLienHe, bool ConQuanLy)
        {
            KhachHangDAO.Sua(MaKH, MaKV, TenKH, DiaChi, MaSoThue, DienThoai, Email, TaiKhoan, GioiHanNo, NoHienTai, NganHang, NguoiLienHe, ConQuanLy);
        }
        public static void Xoa(string MaKH)
        {
            KhachHangDAO.Xoa(MaKH);
        }
    }
}
