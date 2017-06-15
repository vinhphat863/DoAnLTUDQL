using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAO
{
    public class HangHoaDAO
    {
        public static List<HangHoaDTO> DanhSach()
        {
            var db = new PerfectAppEntities();
            var rs = (from hh in db.HangHoas
                      join dv in db.DonViTinhs on hh.MaDV equals dv.MaDV
                      join pl in db.PhanLoaiHangHoas on hh.MaPhanLoai equals pl.MaPhanLoai
                      join k in db.KhoHangs on hh.MaKho equals k.MaKho
                      select new HangHoaDTO()
                      {
                          MaHang = hh.MaHang,
                          TenHang = hh.TenHang,
                          TenDonVi = dv.Ten,
                          TenKho = k.Ten,
                          PhanLoaiHangHoa = pl.TenPhanLoai,
                          TonKhoToiThieu = hh.TonKhoToiThieu,
                          GiaMua = hh.GiaMua,
                          GiaBanLe = hh.GiaBanLe,
                          GiaBanSi = hh.GiaBanSi,
                          ConQuanLy = hh.ConQuanLy
                      }).ToList();
            return rs;
        }

        public static string LayMaHH()
        {
            string Ma;
            var db = new PerfectAppEntities();
            Ma = db.HangHoas.OrderByDescending(k => k.MaHang).FirstOrDefault().MaHang;
            if (Ma != null)
            {
                Ma = XuLyChuoi.LayChuoi(Ma);
            }
            else
            {
                Ma = "HH0001";
            }
            return Ma;
        }

        public static void Them(string MaHang,string TenHang,string MaPhanLoaiHangHoa,string MaLoaiHangHoa,string MaKho,string MaVach,string MaDonVi,string MaNhaCC,string XuatXu,int TonKhoToiThieu,int TonKhoHienTai,double GiaMua,double GiaBanLe,double GiaBanSi,bool ConQuanLy)
        {
            var db = new PerfectAppEntities();
            HangHoa hh = new HangHoa();
            hh.MaHang = MaHang;
            hh.TenHang = TenHang;
            hh.MaPhanLoai = MaPhanLoaiHangHoa;
            hh.MaLoaiHangHoa = MaLoaiHangHoa;
            hh.MaKho = MaKho;
            hh.MaVachNSX = MaVach;
            hh.MaDV = MaDonVi;
            hh.MaNCC = MaNhaCC;
            hh.XuatXu = XuatXu;
            hh.TonKhoToiThieu = TonKhoToiThieu;
            hh.TonHienTai = TonKhoHienTai;
            hh.GiaMua = GiaMua;
            hh.GiaBanSi = GiaBanSi;
            hh.GiaBanLe = GiaBanLe;
            hh.ConQuanLy = ConQuanLy;
            db.HangHoas.Add(hh);
            db.SaveChanges();
        }
        public static HangHoa LayChiTiet(string MaHang)
        {
            var db = new PerfectAppEntities();
            HangHoa hh = db.HangHoas.FirstOrDefault(h => h.MaHang==MaHang);
            return hh;
        }
        public static void Sua(string MaHang,string TenHang,string MaPhanLoaiHangHoa,string MaLoaiHangHoa,string MaKho,string MaVach,string MaDonVi,string MaNhaCC,string XuatXu,int TonKhoToiThieu,int TonKhoHienTai,double GiaMua,double GiaBanLe,double GiaBanSi,bool ConQuanLy)
        {
            var db = new PerfectAppEntities();
            HangHoa hh = db.HangHoas.FirstOrDefault(h => h.MaHang == MaHang);
            hh.MaHang = MaHang;
            hh.TenHang = TenHang;
            hh.MaPhanLoai = MaPhanLoaiHangHoa;
            hh.MaLoaiHangHoa = MaLoaiHangHoa;
            hh.MaKho = MaKho;
            hh.MaVachNSX = MaVach;
            hh.MaDV = MaDonVi;
            hh.MaNCC = MaNhaCC;
            hh.XuatXu = XuatXu;
            hh.TonKhoToiThieu = TonKhoToiThieu;
            hh.TonHienTai = TonKhoHienTai;
            hh.GiaMua = GiaMua;
            hh.GiaBanSi = GiaBanSi;
            hh.GiaBanLe = GiaBanLe;
            hh.ConQuanLy = ConQuanLy;
            db.SaveChanges();
        }
        public static void Xoa(string MaHang)
        {
            var db = new PerfectAppEntities();
            HangHoa hh = db.HangHoas.FirstOrDefault(h => h.MaHang == MaHang);
            db.HangHoas.Remove(hh);
            db.SaveChanges();
        }
    }
}
