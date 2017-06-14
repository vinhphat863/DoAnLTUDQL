using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.ComponentModel;
using System.Data.Entity;

namespace DAO
{
    public class PhieuTempDAO
    {
        public static BindingList<PhieuTemp> DanhSach()
        {
            var db = new PerfectAppEntities();
            return db.PhieuTemps.Local.ToBindingList();
        }

        public static List<PhieuTempDTO> DanhSachHangHienThi()
        {
            var db = new PerfectAppEntities();
            var rs = (from dv in db.DonViTinhs
                      join hh in db.HangHoas on dv.MaDV equals hh.MaDV
                      select new PhieuTempDTO
                      {
                          MaHang = hh.MaHang,
                          TenHang = hh.TenHang,
                          MaDonVi = hh.MaDV,
                          TenDonVi = dv.Ten
                      }).ToList();
            return rs;
        }
    }
}
