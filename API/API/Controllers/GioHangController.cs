using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace API.Controllers
{
    public class GioHangController : ApiController
    {
        [HttpGet]
        public IHttpActionResult GetGioLists()
        {
            QLLKDataContext db = new QLLKDataContext();
            List<ChiTietHoaDon> chitiet = db.ChiTietHoaDons.ToList();
            List<SanPham> sanpham = db.SanPhams.ToList();
            var query = from c in chitiet
                        join sp in sanpham on c.MaSanPham equals sp.MaSanPham into table1
                        from sp in table1.DefaultIfEmpty()
                        select new LayGio { maHoaDon = c.MaHoaDon,maSanPham = c.MaSanPham,gmail = c.Gmail,soluong=c.SoLuong,tongtien = c.TongTien,tongtienhoadon=c.TongTienHoaDon,ngaylaphoadon=c.NgayLapHoaDon,image=sp.Image };
            return Ok(query);
        }

        [HttpGet]
        public IHttpActionResult GetGioLists(string id)
        {
            QLLKDataContext db = new QLLKDataContext();
            List<ChiTietHoaDon> chitiet = db.ChiTietHoaDons.ToList();
            List<SanPham> sanpham = db.SanPhams.ToList();
            var query = from c in chitiet
                        join sp in sanpham on c.MaSanPham equals sp.MaSanPham into table1
                        from sp in table1.DefaultIfEmpty()
                        where c.Gmail == id.ToString()
                        select new LayGio { maHoaDon = c.MaHoaDon, maSanPham = c.MaSanPham, gmail = c.Gmail, soluong = c.SoLuong, tongtien = c.TongTien, tongtienhoadon = c.TongTienHoaDon, ngaylaphoadon = c.NgayLapHoaDon, image = sp.Image };
            return Ok(query);
        }
    }
}
