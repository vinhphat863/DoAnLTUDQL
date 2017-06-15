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
        public string TenKhuVuc { get; set; }
        public string TenNCC { get; set; }
        public string DiaChi { get; set; }
        public string DienThoai { get; set; }
        public string ChucVu { get; set; }
        public int? Fax { get; set; }
        public string DiDong { get; set; }
        public string NguoiLienHe { get; set; }
        public bool? ConQuanLy { get; set; }
    }
}
