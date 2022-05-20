using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace API.Controllers
{
    public class HoaDonController : ApiController
    {
        [HttpGet]
        public IHttpActionResult GetGioLists()
        {
            QLLKDataContext db = new QLLKDataContext();
            List<ChiTietHoaDon> chitiet = db.ChiTietHoaDons.ToList();
            List<ChiTietHoaDonSanPham> sanpham = db.ChiTietHoaDonSanPhams.ToList();
            var query = from c in chitiet
                        join sp in sanpham on c.MaHoaDon equals sp.MaHoaDon into table1
                        from sp in table1.DefaultIfEmpty()
                        select new LayGio { MaHoaDon = c.MaHoaDon, MaSanPham = sp.MaSanPham, Gmail = c.Gmail, soluong = sp.soluong, giaban = sp.giaban, NgayLapHoaDon = c.NgayLapHoaDon, hinh = sp.hinh };
            return Ok(query);
        }

        [HttpGet]
        public IHttpActionResult GetGioLists(string id)
        {
            QLLKDataContext db = new QLLKDataContext();
            List<ChiTietHoaDon> chitiet = db.ChiTietHoaDons.ToList();
            List<ChiTietHoaDonSanPham> sanpham = db.ChiTietHoaDonSanPhams.ToList();
            var query = from c in chitiet
                        join sp in sanpham on c.MaHoaDon equals sp.MaHoaDon into table1
                        from sp in table1.DefaultIfEmpty()
                        where c.Gmail == id.ToString()
                        select new LayGio { MaHoaDon = c.MaHoaDon, MaSanPham = sp.MaSanPham, Gmail = c.Gmail, soluong = sp.soluong, giaban = sp.giaban, NgayLapHoaDon = c.NgayLapHoaDon, hinh = sp.hinh };
            return Ok(query);
        }
    }
}
