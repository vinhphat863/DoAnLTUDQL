using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;
namespace BUS
{
    public class DonViBUS
    {
        public static List<DonViTinh> DanhSach()
        {
            return DonViDAO.DanhSach();
        }
    }
}
