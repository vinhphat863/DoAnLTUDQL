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
    
    public partial class MaVach
    {
        public Nullable<int> SoLanIn { get; set; }
        public string MaHang { get; set; }
        public string Ten { get; set; }
        public string Giaban { get; set; }
        public string MaVach1 { get; set; }
        public string MaDV { get; set; }
    
        public virtual DonViTinh DonViTinh { get; set; }
        public virtual HangHoa HangHoa { get; set; }
    }
}
