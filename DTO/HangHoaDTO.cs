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
        public string MaLoaiHangHoa { get; set; }
        public string MaKho { get; set; }
        public string MaPhanLoai { get; set; }
        public string MaDV { get; set; }
        public string MaNCC { get; set; }
        public string MaVachNSX { get; set; }
        public string TenHang { get; set; }
        public string XuatXu { get; set; }
        public string Anh { get; set; }
        public int TonKhoToiThieu { get; set; }
        public int TonKhoHienTai { get; set; }
        public float GiaMua { get; set; }
        public float GiaBanSi { get; set; }
        public float GiaBanLe { get; set; }
        public bool ConQuanLy { get; set; }

    }
}
