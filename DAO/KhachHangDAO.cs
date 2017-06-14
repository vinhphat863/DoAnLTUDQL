using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAO
{
    public class KhachHangDAO
    {
        public static List<KhachHangDTO> DanhSach()
        {
            var db = new PerfectAppEntities();
            var rs = (from kh in db.KhachHangs
                      join kv in db.KhuVucs on kh.MaKhuVuc equals kv.MaKhuVuc
                      select new KhachHangDTO()
                      {
                          MaKH = kh.MaKH,
                          TenKV = kv.TenKhuVuc,
                          TenKH = kh.TenKH,
                          DiaChi = kh.DiaChi,
                          MaSoThue = kh.MaSoThue,
                          DienThoai = kh.DienThoai,
                          Email = kh.Email,
                          TaiKhoan = kh.TaiKhoan,
                          GioiHanNo = kh.GioiHanNo,
                          NoHienTai = kh.NoHienTai,
                          NganHang = kh.NganHang,
                          NguoiLienHe = kh.NguoiLienHe,
                          ConQuanLy = kh.ConQuanLy
                      }).ToList();
            return rs;
        }
    }
}
