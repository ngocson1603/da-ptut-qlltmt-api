using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace API.Controllers
{
    public class BieuMauGioController : ApiController
    {
        [HttpGet]
        public IHttpActionResult GetBieuMauGioLists()
        {
            QLLKDataContext db = new QLLKDataContext();
            List<ChiTietHoaDon> chitiet = db.ChiTietHoaDons.ToList();
            List<SanPham> sanpham = db.SanPhams.ToList();
            var query = from c in chitiet
                        join sp in sanpham on c.MaSanPham equals sp.MaSanPham into table1
                        from sp in table1.DefaultIfEmpty()
                        select new BieuMau { TenSanPham = sp.TenSanPham, SoLuong = c.SoLuong, TongTien = c.TongTien, TongTienHoaDon = c.TongTienHoaDon, NgayLapHoaDon = c.NgayLapHoaDon, Gmail = c.Gmail };
            return Ok(query);
        }

        [HttpGet]
        public IHttpActionResult GetBieuMauGioLists(string id)
        {
            QLLKDataContext db = new QLLKDataContext();
            List<ChiTietHoaDon> chitiet = db.ChiTietHoaDons.ToList();
            List<SanPham> sanpham = db.SanPhams.ToList();
            var query = from c in chitiet
                        join sp in sanpham on c.MaSanPham equals sp.MaSanPham into table1
                        from sp in table1.DefaultIfEmpty()
                        where c.Gmail == id.ToString()
                        select new BieuMau { TenSanPham = sp.TenSanPham, SoLuong = c.SoLuong, TongTien = c.TongTien, TongTienHoaDon = c.TongTienHoaDon, NgayLapHoaDon = c.NgayLapHoaDon, Gmail = c.Gmail };
            return Ok(query);
        }
    }
}
