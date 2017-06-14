using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class KhachHangDTO
    {
        public string MaKH { get; set; }
        public string TenKV { get; set; }
        public string TenKH { get; set; }
        public string DiaChi { get; set; }
        public string MaSoThue { get; set; }
        public string DienThoai { get; set; }
        public string Email { get; set; }
        public string TaiKhoan { get; set; }
        public int? GioiHanNo { get; set; }
        public int? NoHienTai { get; set; }
        public string NganHang { get; set; }
        public string NguoiLienHe { get; set; }
        public Boolean? ConQuanLy { get; set; }
    }
}
