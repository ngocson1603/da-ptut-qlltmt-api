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
            List<HoaDon> hoadon = db.HoaDons.ToList();
            List<SanPham> sanpham = db.SanPhams.ToList();
            List<KhachHang> khachhang = db.KhachHangs.ToList();
            var query = from c in chitiet
                        join hd in hoadon on c.MaHoaDon equals hd.MaHoaDon into table1
                        from hd in table1.DefaultIfEmpty()
                        join sp in sanpham on c.MaSanPham equals sp.MaSanPham into table2
                        from sp in table2.DefaultIfEmpty()
                        join kh in khachhang on hd.MaKH equals kh.MaKH into table3
                        from kh in table3.DefaultIfEmpty()
                        select new BieuMau { TenSanPham = sp.TenSanPham, soluong = c.soluong, giaban = c.giaban, NgayLapHoaDon = hd.NgayLapHoaDon,MaHoaDon = c.MaHoaDon, TongTien = c.TongTien,MaKH=kh.MaKH };
            return Ok(query);
        }

        [HttpGet]
        public IHttpActionResult GetBieuMauGioListss(int id, int ma)
        {
            QLLKDataContext db = new QLLKDataContext();
            List<ChiTietHoaDon> chitiet = db.ChiTietHoaDons.ToList();
            List<HoaDon> hoadon = db.HoaDons.ToList();
            List<SanPham> sanpham = db.SanPhams.ToList();
            List<KhachHang> khachhang = db.KhachHangs.ToList();
            var query = from c in chitiet
                        join hd in hoadon on c.MaHoaDon equals hd.MaHoaDon into table1
                        from hd in table1.DefaultIfEmpty()
                        join sp in sanpham on c.MaSanPham equals sp.MaSanPham into table2
                        from sp in table2.DefaultIfEmpty()
                        join kh in khachhang on hd.MaKH equals kh.MaKH into table3
                        from kh in table3.DefaultIfEmpty()
                        where kh.MaKH == id && c.MaHoaDon == ma
                        select new BieuMau { TenSanPham = sp.TenSanPham, soluong = c.soluong, giaban = c.giaban, NgayLapHoaDon = hd.NgayLapHoaDon, MaHoaDon = c.MaHoaDon, TongTien = c.TongTien, MaKH = kh.MaKH };

            return Ok(query);
        }
    }
}
