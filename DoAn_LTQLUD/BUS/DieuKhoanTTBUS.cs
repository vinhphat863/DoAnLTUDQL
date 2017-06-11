using DoAn_LTQLUD.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_LTQLUD.BUS
{
    class DieuKhoanTTBUS
    {
        public static List<DieuKhoanThanhToan> DanhSach()
        {
            return DieuKhoanTTDAO.DanhSach();
        }
    }
}
