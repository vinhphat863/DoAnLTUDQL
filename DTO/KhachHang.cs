//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DTO
{
    using System;
    using System.Collections.Generic;
    
    public partial class KhachHang
    {
        public string MaKH { get; set; }
        public string MaKhuVuc { get; set; }
        public string TenKH { get; set; }
        public string DiaChi { get; set; }
        public string MaSoThue { get; set; }
        public string DienThoai { get; set; }
        public string Email { get; set; }
        public string TaiKhoan { get; set; }
        public Nullable<int> GioiHanNo { get; set; }
        public string NganHang { get; set; }
        public Nullable<int> NoHienTai { get; set; }
        public string NguoiLienHe { get; set; }
        public Nullable<bool> ConQuanLy { get; set; }
    
        public virtual KhuVuc KhuVuc { get; set; }
    }
}
