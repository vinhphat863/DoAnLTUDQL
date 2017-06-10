using DoAn_LTQLUD.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_LTQLUD.BUS
{
    class KhuVucBUS
    {
        public static List<KhuVuc> DanhSach()
        {
            return KhuVucDAO.DanhSach();
        }
        public static string MaKhuVuc()
        {
            return KhuVucDAO.MaKhuVuc();
        }
        public static void Them(string Ma, string Ten,string GhiChu)
        {
            KhuVucDAO.Them(Ma,Ten,GhiChu);
        }
        public static void Sua(string Ma,string Ten,string GhiChu)
        {
            KhuVucDAO.Sua(Ma, Ten, GhiChu);
        }
        public static void Xoa(string Ma)
        {
            KhuVucDAO.Xoa(Ma);
        }
    }
}
