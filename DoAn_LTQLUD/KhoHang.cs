//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DoAn_LTQLUD
{
    using System;
    using System.Collections.Generic;
    
    public partial class KhoHang
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public KhoHang()
        {
            this.HangHoas = new HashSet<HangHoa>();
            this.PhieuNhapHangs = new HashSet<PhieuNhapHang>();
        }
    
        public string MaKho { get; set; }
        public string Ten { get; set; }
        public string KyHieu { get; set; }
        public string NguoiQuanLy { get; set; }
        public string NguoiLienHe { get; set; }
        public string DiaChi { get; set; }
        public Nullable<int> DienThoai { get; set; }
        public Nullable<int> Fax { get; set; }
        public string Email { get; set; }
        public string DienGia { get; set; }
        public Nullable<int> ConQuanLy { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HangHoa> HangHoas { get; set; }
        public virtual NhanVien NhanVien { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PhieuNhapHang> PhieuNhapHangs { get; set; }
    }
}
