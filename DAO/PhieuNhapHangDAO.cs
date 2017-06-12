using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAO
{
    public class PhieuNhapHangDAO
    {
        public static string LayMaPhieu()
        {
            string kq = "";
            var db = new PerfectAppEntities();
            var rs = db.PhieuNhapHangs.OrderByDescending(p => p.MaPhieu).FirstOrDefault();
            if(rs != null)
            {
                kq = XuLyChuoi.LayChuoi(rs.MaPhieu);
            }
            else
            {
                kq = "PNH0001";
            }
            return kq;
        }
        public static void Them(string MaPhieu, string MaNCC, string DiaChi, string DienThoai, DateTime Ngay, string GhiChu, string SoHoaDonVAT, string SoHoaDonVietTay, string MaNV, string MaKho, string MaDKTT, string MaHTTT, DateTime HTT)
        {
            var db = new PerfectAppEntities();
            PhieuNhapHang a = new PhieuNhapHang();
            a.MaPhieu = MaPhieu;
            a.MaNCC = MaNCC;
            a.DiaChi = DiaChi;
            a.DienThoai = DienThoai;
            a.Ngay = Ngay;
            a.GhiChu = GhiChu;
            a.SoHoaDonVAT = SoHoaDonVAT;
            a.SoHoaDonVietTay = SoHoaDonVietTay;
            a.MaNV = MaNV;
            a.MaKho = MaKho;
            a.MaDKTT = MaDKTT;
            a.MaHTTT = MaHTTT;
            a.HanTT = HTT;
            db.PhieuNhapHangs.Add(a);
            db.SaveChanges();
        }
    }
}
