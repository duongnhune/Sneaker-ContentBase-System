using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FashionShoes.Entity.DAO
{
    public class DonHangDAO
    {
        private static DonHangDAO instance;
        public static DonHangDAO Instance
        {
            get { if (instance == null) instance = new DonHangDAO(); return instance; }
            set => instance = value;
        }
        private dbFashionShoesEntities db = new dbFashionShoesEntities();
        public IEnumerable<ChiTietDonHang_Result> getOrderDetail(int maDonHang)
        {
            var result = db.ChiTietDonHang(maDonHang);
            return result;
        }

    }
}