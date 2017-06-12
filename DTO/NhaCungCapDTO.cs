using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NhaCungCapDTO
    {
        public string MaNCC { get; set; }
        public string MaKhuVuc { get; set; }
        public string TenNCC { get; set; }
        public string DiaChi { get; set; }
        public int? MaSoThue { get; set; }
        public string DienThoai { get; set; }
        public string Email { get; set; }
        public string TaiKhoan { get; set; }
        public int? GioiHanNo { get; set; }
        public int? ChietKhau { get; set; }
        public int? Fax { get; set; }
        public string Mobile { get; set; }
        public string Website { get; set; }
        public string NganHang { get; set; }
        public int? NoHienTai { get; set; }
        public string NguoiLienHe { get; set; }
        public bool? ConQuanLy { get; set; }
    }
}
