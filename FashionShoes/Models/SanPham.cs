using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FashionShoes.Models
{
    public class SanPham
    {
        internal int? DanhGia;
        internal int MaKhuyenMai;

        public int ID { get; set; }
        public string TenSP { get; set; }
        public int ThgHieu { get; set; }
        public int MaDanhMuc { get; set; }
        public Nullable<int> SoLuongTon { get; set; }
        public int ThoiGianBH { get; set; }
        public string UrlHinh { get; set; }
        public string MoTa { get; set; }
        public Nullable<int> TrangThai { get; set; }
        public string ThongTinSP { get; set; }
    }
}