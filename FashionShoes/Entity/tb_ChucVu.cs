//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FashionShoes.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class tb_ChucVu
    {
        public tb_ChucVu()
        {
            this.tb_NhanVien = new HashSet<tb_NhanVien>();
        }
    
        public int MaChucVu { get; set; }
        public string TenChucVu { get; set; }
    
        public virtual ICollection<tb_NhanVien> tb_NhanVien { get; set; }
    }
}
