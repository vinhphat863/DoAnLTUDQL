using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;
namespace BUS
{
    public class NhaCungCapBUS
    {
        public static List<NhaCungCapDTO> DanhSach()
        {
            return NhaCungCapDAO.DanhSach();
        }
        public static string LayMaNCC()
        {
            return NhaCungCapDAO.LayMaNCC();
        }
        public static void Them(string MaNCC, string TenNCC, string MaKhuVuc, string DiaChi, int MaSoThue, string DienThoai, string Mobile, string Email, string TaiKhoan, int GioiHanNo, int Fax, string NganHang, string Website, int NoHienTai, string ChucVu, string NguoiLienHe, int ChietKhau, bool ConQuanLy)
        {
            NhaCungCapDAO.Them(MaNCC, TenNCC, MaKhuVuc, DiaChi, MaSoThue, DienThoai, Mobile, Email, TaiKhoan, GioiHanNo, Fax, NganHang, Website, NoHienTai, ChucVu, NguoiLienHe, ChietKhau, ConQuanLy);
        }
        public static NhaCungCap LayChiTiet(string MaNCC)
        {
            return NhaCungCapDAO.LayChiTiet(MaNCC);
        }
        public static void Sua(string MaNCC, string TenNCC, string MaKhuVuc, string DiaChi, int MaSoThue, string DienThoai, string Mobile, string Email, string TaiKhoan, int GioiHanNo, int Fax, string NganHang, string Website, int NoHienTai, string ChucVu, string NguoiLienHe, int ChietKhau, bool ConQuanLy)
        {
            NhaCungCapDAO.Sua(MaNCC, TenNCC, MaKhuVuc, DiaChi, MaSoThue, DienThoai, Mobile, Email, TaiKhoan, GioiHanNo, Fax, NganHang, Website, NoHienTai, ChucVu, NguoiLienHe, ChietKhau, ConQuanLy);
        }
    }
}
