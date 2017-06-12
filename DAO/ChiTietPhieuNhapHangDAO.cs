using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAO
{
    public class ChiTietPhieuNhapHangDAO
    {
        public static void Them(string MaPhieu, string MaHang, string MaDonVi, int SoLuong, double DonGia, string GhiChu)
        {
            var db = new PerfectAppEntities();
            ChiTietPhieuNhapHang ct = new ChiTietPhieuNhapHang();
            ct.MaPhieu = MaPhieu;
            ct.MaHang = MaHang;
            ct.MaDonVi = MaDonVi;
            ct.SoLuong = SoLuong;
            ct.DonGia = DonGia;
            ct.GhiChu = GhiChu;
            db.ChiTietPhieuNhapHangs.Add(ct);
            db.SaveChanges();
        }
    }
}
