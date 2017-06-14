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
        public static string LayMaKH()
        {
            string Ma;
            var db = new PerfectAppEntities();
            Ma = db.KhachHangs.OrderByDescending(k => k.MaKH).FirstOrDefault().MaKhuVuc;
            if (Ma != null)
            {
                Ma = XuLyChuoi.LayChuoi(Ma);
            }
            else
            {
                Ma = "KH0001";
            }
            return Ma;
        }
        public static void Them(string MaKH,string MaKV,string TenKH,string DiaChi,string MaSoThue,string DienThoai,string Email,string TaiKhoan,int GioiHanNo,int NoHienTai,string NganHang,string NguoiLienHe,bool ConQuanLy)
        {
            var db = new PerfectAppEntities();
            KhachHang kh = new KhachHang();
            kh.MaKH = MaKH;
            kh.MaKhuVuc = MaKV;
            kh.TenKH = TenKH;
            kh.DiaChi = DiaChi;
            kh.MaSoThue = MaSoThue;
            kh.DienThoai = DienThoai;
            kh.Email = Email;
            kh.TaiKhoan = TaiKhoan;
            kh.GioiHanNo = GioiHanNo;
            kh.NoHienTai = NoHienTai;
            kh.NganHang = NganHang;
            kh.NguoiLienHe = NguoiLienHe;
            kh.ConQuanLy = ConQuanLy;
            db.KhachHangs.Add(kh);
            db.SaveChanges();
        }

        public static KhachHang ChiTietKH(string MaKH)
        {
            var db = new PerfectAppEntities();
            KhachHang kh = db.KhachHangs.FirstOrDefault(k => k.MaKH == MaKH);
            return kh;
        }

        public static void Sua(string MaKH, string MaKV, string TenKH, string DiaChi, string MaSoThue, string DienThoai, string Email, string TaiKhoan, int GioiHanNo, int NoHienTai, string NganHang, string NguoiLienHe, bool ConQuanLy)
        {
            var db = new PerfectAppEntities();
            KhachHang kh = db.KhachHangs.Where(k => k.MaKH == MaKH).First();
            kh.MaKH = MaKH;
            kh.MaKhuVuc = MaKV;
            kh.TenKH = TenKH;
            kh.DiaChi = DiaChi;
            kh.MaSoThue = MaSoThue;
            kh.DienThoai = DienThoai;
            kh.Email = Email;
            kh.TaiKhoan = TaiKhoan;
            kh.GioiHanNo = GioiHanNo;
            kh.NoHienTai = NoHienTai;
            kh.NganHang = NganHang;
            kh.NguoiLienHe = NguoiLienHe;
            kh.ConQuanLy = ConQuanLy;
            db.SaveChanges();
        }

        public static void Xoa(string MaKH)
        {
            var db = new PerfectAppEntities();
            KhachHang kh = db.KhachHangs.Where(k => k.MaKH == MaKH).First();
            db.KhachHangs.Remove(kh);
            db.SaveChanges();
        }
    }
}
