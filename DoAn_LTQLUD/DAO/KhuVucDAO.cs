using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_LTQLUD.DAO
{
    class KhuVucDAO
    {
        public static List<KhuVuc> DanhSach()
        {
            var db = new PerfectAppEntities();
            return db.KhuVucs.ToList();
        }
        public static string MaKhuVuc()
        {
            string Ma;
            int SoMoi = 0;
            string temp;
            var db = new PerfectAppEntities();
            Ma = db.KhuVucs.OrderByDescending(k => k.MaKhuVuc).FirstOrDefault().MaKhuVuc;
            if (Ma != null)
            {
                Ma = XuLyChuoi.LayChuoi(Ma);
            }
            return Ma;
        }
        public static void Them(string Ma, string Ten, string GhiChu)
        {
            KhuVuc kv = new KhuVuc();
            kv.MaKhuVuc = Ma;
            kv.TenKhuVuc = Ten;
            kv.GhiChu = GhiChu;
            var db = new PerfectAppEntities();
            db.KhuVucs.Add(kv);
            db.SaveChanges();
        }
        public static void Sua(string Ma,string Ten,string GhiChu)
        {
            var db = new PerfectAppEntities();
            var rs = db.KhuVucs.Where(k => k.MaKhuVuc == Ma).First();
            rs.TenKhuVuc = Ten;
            rs.GhiChu = GhiChu;
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
