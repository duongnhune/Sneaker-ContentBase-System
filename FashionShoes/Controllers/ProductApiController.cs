using FashionShoes.Entity;
using FashionShoes.Entity.DAO;
using FashionShoes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace FashionShoes.Controllers
{
    public class ProductApiController : ApiController
    {
        // GET api/<controller>
        dbFashionShoesEntities db = new dbFashionShoesEntities();
        public List<SanPham> GetShoes(int page = 1)
        {
            int pageSize = 12;
            var list = from a in db.tb_SanPham
                       select new SanPham()
                       {
                           ID = a.ID,
                           MaKhuyenMai = a.MaDanhMuc,
                           TenSP = a.TenSP,
                           ThgHieu = a.ThgHieu,
                           MaDanhMuc = a.MaDanhMuc,
                           SoLuongTon = a.SoLuongTon,
                           ThoiGianBH = a.ThoiGianBH,
                           UrlHinh = a.UrlHinh,
                           MoTa = a.MoTa,
                           TrangThai = a.TrangThai,
                           ThongTinSP = a.ThongTinSP,

                       };

            return list.OrderBy(t => t.ID).Skip((page - 1) * pageSize).Take(pageSize).ToList();
        }

    }
}