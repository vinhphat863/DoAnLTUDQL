using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAO
{
    public class KhuVucDAO
    {
        public static List<KhuVucDTO> DanhSach()
        {
            List<KhuVucDTO> lst = new List<KhuVucDTO>();
            var db = new PerfectAppEntities();
            foreach(var row in db.KhuVucs)
            {
                KhuVucDTO kv = new KhuVucDTO();
                kv.MaKhuVuc = row.MaKhuVuc;
                kv.TenKhuVuc = row.TenKhuVuc;
                kv.GhiChu = row.GhiChu;
                kv.ConQuanLy = row.ConQuanLy;
                lst.Add(kv);
            }
            return lst;
        }
        public static string MaKhuVuc()
        {
            string Ma;
            var db = new PerfectAppEntities();
            Ma = db.KhuVucs.OrderByDescending(k => k.MaKhuVuc).FirstOrDefault().MaKhuVuc;
            if (Ma != null)
            {
                Ma = XuLyChuoi.LayChuoi(Ma);
            }
            return Ma;
        }
        public static void Them(string Ma, string Ten, string GhiChu,bool ConQuanLy)
        {
            KhuVuc kv = new KhuVuc();
            kv.MaKhuVuc = Ma;
            kv.TenKhuVuc = Ten;
            kv.GhiChu = GhiChu;
            kv.ConQuanLy = ConQuanLy;
            var db = new PerfectAppEntities();
            db.KhuVucs.Add(kv);
            db.SaveChanges();
        }
        public static void Sua(string Ma, string Ten, string GhiChu,bool ConQuanLy)
        {
            var db = new PerfectAppEntities();
            var rs = db.KhuVucs.Where(k => k.MaKhuVuc == Ma).First();
            rs.TenKhuVuc = Ten;
            rs.GhiChu = GhiChu;
            rs.ConQuanLy = ConQuanLy;
            db.SaveChanges();
        }
        public static void Xoa(string Ma)
        {
            var db = new PerfectAppEntities();
            var rs = db.KhuVucs.Where(k => k.MaKhuVuc == Ma).First();
            db.KhuVucs.Remove(rs);
            db.SaveChanges();
        }
    }
}
