using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class HangHoaDTO
    {
        public string MaHang { get; set; }
        public string TenHang { get; set; }
        public string TenDonVi { get; set; }
        public string PhanLoaiHangHoa { get; set; }
        public string TenKho  { get; set; }
        public int? TonKhoToiThieu { get; set; }
        public double? GiaMua { get; set; }
        public double? GiaBanSi { get; set; }
        public double? GiaBanLe { get; set; }
        public bool? ConQuanLy { get; set; }

    }
}
