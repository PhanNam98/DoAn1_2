//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class ChiTietHDNhapHang
    {
        public string MaHoaDonNH { get; set; }
        public string MaKieu { get; set; }
        public int SoLuongNhap { get; set; }
        public decimal GiaNSX { get; set; }
    
        public virtual ChiTietSP ChiTietSP { get; set; }
        public virtual HoaDonNhapHang HoaDonNhapHang { get; set; }
    }
}
