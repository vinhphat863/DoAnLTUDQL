using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAO
{
    public class NhaCungCapDAO
    {
        public static List<NhaCungCapDTO> DanhSach()
        {
            var db = new PerfectAppEntities();
            var rs = (from n in db.NhaCungCaps
                      join k in db.KhuVucs on n.MaKhuVuc equals k.MaKhuVuc
                      select new NhaCungCapDTO()
                      {
                          MaNCC = n.MaNCC,
                          TenNCC = n.TenNCC,
                          TenKhuVuc = k.TenKhuVuc,
                          DiaChi = n.DiaChi,
                          DiDong = n.Mobile,
                          DienThoai = n.DienThoai,
                          Fax = n.Fax,
                          ConQuanLy = n.ConQuanLy,
                          NguoiLienHe = n.NguoiLienHe,
                          ChucVu = n.ChucVu
                      }).ToList();
            return rs;
        }
        public static NhaCungCap LayChiTiet(string MaNCC)
        {
            var db = new PerfectAppEntities();
            return db.NhaCungCaps.FirstOrDefault(n => n.MaNCC == MaNCC);
        }
        public static string LayMaNCC()
        {
            string Ma;
            var db = new PerfectAppEntities();
            Ma = db.NhaCungCaps.OrderByDescending(k => k.MaNCC).FirstOrDefault().MaNCC;
            if (Ma != null)
            {
                Ma = XuLyChuoi.LayChuoi(Ma);
            }
            else
            {
                Ma = "NCC0001";
            }
            return Ma;
        }
        public static void Them(string MaNCC,string TenNCC,string MaKhuVuc,string DiaChi,int MaSoThue,string DienThoai,string Mobile,string Email,string TaiKhoan,int GioiHanNo,int Fax,string NganHang,string Website,int NoHienTai,string ChucVu,string NguoiLienHe,int ChietKhau,bool ConQuanLy)
        {
            var db = new PerfectAppEntities();
            NhaCungCap n = new NhaCungCap();
            n.MaNCC = MaNCC;
            n.TenNCC = TenNCC;
            n.MaKhuVuc = MaKhuVuc;
            n.DiaChi = DiaChi;
            n.MaSoThue = MaSoThue;
            n.DienThoai = DienThoai;
            n.Mobile = Mobile;
            n.Email = Email;
            n.Website = Website;
            n.NganHang = NganHang;
            n.NguoiLienHe = NguoiLienHe;
            n.NoHienTai = NoHienTai;
            n.GioiHanNo = GioiHanNo;
            n.TaiKhoan = TaiKhoan;
            n.Fax = Fax;
            n.ChietKhau = ChietKhau;
            n.ConQuanLy = ConQuanLy;
            n.ChucVu = ChucVu;
            n.MaSoThue = MaSoThue;
            db.NhaCungCaps.Add(n);
            db.SaveChanges();
        }
        public static void Sua(string MaNCC, string TenNCC, string MaKhuVuc, string DiaChi, int MaSoThue, string DienThoai, string Mobile, string Email, string TaiKhoan, int GioiHanNo, int Fax, string NganHang, string Website, int NoHienTai, string ChucVu, string NguoiLienHe, int ChietKhau, bool ConQuanLy)
        {
            var db = new PerfectAppEntities();
            NhaCungCap n = db.NhaCungCaps.FirstOrDefault(p => p.MaNCC == MaNCC);
            n.MaNCC = MaNCC;
            n.TenNCC = TenNCC;
            n.MaKhuVuc = MaKhuVuc;
            n.DiaChi = DiaChi;
            n.MaSoThue = MaSoThue;
            n.DienThoai = DienThoai;
            n.Mobile = Mobile;
            n.Email = Email;
            n.Website = Website;
            n.NganHang = NganHang;
            n.TaiKhoan = TaiKhoan;
            n.NguoiLienHe = NguoiLienHe;
            n.NoHienTai = NoHienTai;
            n.GioiHanNo = GioiHanNo;
            n.Fax = Fax;
            n.ChietKhau = ChietKhau;
            n.ConQuanLy = ConQuanLy;
            n.ChucVu = ChucVu;
            n.MaSoThue = MaSoThue;
            db.SaveChanges();
        }
    }
}
