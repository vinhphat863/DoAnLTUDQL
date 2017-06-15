using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;
namespace BUS
{
    public class HangHoaBUS
    {
        public static List<HangHoaDTO> DanhSach()
        {
            return HangHoaDAO.DanhSach();
        }
        public static void Them(string MaHang, string TenHang, string MaPhanLoaiHangHoa, string MaLoaiHangHoa, string MaKho, string MaVach, string MaDonVi, string MaNhaCC, string XuatXu, int TonKhoToiThieu, int TonKhoHienTai, double GiaMua, double GiaBanLe, double GiaBanSi, bool ConQuanLy)
        {
            HangHoaDAO.Them(MaHang, TenHang, MaPhanLoaiHangHoa, MaLoaiHangHoa, MaKho, MaVach, MaDonVi, MaNhaCC, XuatXu, TonKhoToiThieu, TonKhoHienTai, GiaMua, GiaBanLe, GiaBanSi,ConQuanLy);
        }
        public static string LayMaHH()
        {
            return HangHoaDAO.LayMaHH();
        }
        public static HangHoa LayChiTiet(string MaHang)
        {
            return HangHoaDAO.LayChiTiet(MaHang);
        }
        public static void Sua(string MaHang, string TenHang, string MaPhanLoaiHangHoa, string MaLoaiHangHoa, string MaKho, string MaVach, string MaDonVi, string MaNhaCC, string XuatXu, int TonKhoToiThieu, int TonKhoHienTai, double GiaMua, double GiaBanLe, double GiaBanSi, bool ConQuanLy)
        {
            HangHoaDAO.Sua(MaHang, TenHang, MaPhanLoaiHangHoa, MaLoaiHangHoa, MaKho, MaVach, MaDonVi, MaNhaCC, XuatXu, TonKhoToiThieu, TonKhoHienTai, GiaMua, GiaBanLe, GiaBanSi, ConQuanLy);
        }
        public static void Xoa(string MaHang)
        {
            HangHoaDAO.Xoa(MaHang);
        }
    }
}
