using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;
namespace BUS
{
    public class KhuVucBUS
    {
        public static List<KhuVucDTO> DanhSach()
        {
            return KhuVucDAO.DanhSach();
        }
        public static string MaKhuVuc()
        {
            return KhuVucDAO.MaKhuVuc();
        }
        public static void Them(string Ma, string Ten, string GhiChu,bool ConQuanLy)
        {
            KhuVucDAO.Them(Ma, Ten, GhiChu,ConQuanLy);
        }
        public static void Sua(string Ma, string Ten, string GhiChu,bool ConQuanLy)
        {
            KhuVucDAO.Sua(Ma, Ten, GhiChu,ConQuanLy);
        }
        public static void Xoa(string Ma)
        {
            KhuVucDAO.Xoa(Ma);
        }
    }
}
