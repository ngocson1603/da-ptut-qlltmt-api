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
            List<HoaDon> hoadon = db.HoaDons.ToList();
            List<SanPham> sanpham = db.SanPhams.ToList();
            List<KhachHang> khachhang = db.KhachHangs.ToList();
            List<LoaiSanPham> loaisp = db.LoaiSanPhams.ToList();
            var query = from c in chitiet
                        join hd in hoadon on c.MaHoaDon equals hd.MaHoaDon into table1
                        from hd in table1.DefaultIfEmpty()
                        join sp in sanpham on c.MaSanPham equals sp.MaSanPham into table2
                        from sp in table2.DefaultIfEmpty()
                        join kh in khachhang on hd.MaKH equals kh.MaKH into table3
                        from kh in table3.DefaultIfEmpty()
                        join lsp in loaisp on sp.LoaiSanPham equals lsp.MaLoaiSanPham into table4
                        from lsp in table4.DefaultIfEmpty()
                        select new LayGio { MaHoaDon = c.MaHoaDon, MaSanPham = sp.MaSanPham, MaKH = kh.MaKH,TenSanPham = sp.TenSanPham,TenLoaiSanPham = lsp.TenLoaiSanPham, soluong = c.soluong, giaban = c.giaban, NgayLapHoaDon = hd.NgayLapHoaDon, Image = sp.Image };
            return Ok(query);
        }

        [HttpGet]
        public IHttpActionResult GetGioLists(string id)
        {
            QLLKDataContext db = new QLLKDataContext();
            List<ChiTietHoaDon> chitiet = db.ChiTietHoaDons.ToList();
            List<HoaDon> hoadon = db.HoaDons.ToList();
            List<SanPham> sanpham = db.SanPhams.ToList();
            List<KhachHang> khachhang = db.KhachHangs.ToList();
            List<LoaiSanPham> loaisp = db.LoaiSanPhams.ToList();
            var query = from c in chitiet
                        join hd in hoadon on c.MaHoaDon equals hd.MaHoaDon into table1
                        from hd in table1.DefaultIfEmpty()
                        join sp in sanpham on c.MaSanPham equals sp.MaSanPham into table2
                        from sp in table2.DefaultIfEmpty()
                        join kh in khachhang on hd.MaKH equals kh.MaKH into table3
                        from kh in table3.DefaultIfEmpty()
                        join lsp in loaisp on sp.LoaiSanPham equals lsp.MaLoaiSanPham into table4
                        from lsp in table4.DefaultIfEmpty()
                        where kh.Gmail == id.ToString()
                        select new LayGio { MaHoaDon = c.MaHoaDon, MaSanPham = sp.MaSanPham, MaKH = kh.MaKH, TenSanPham = sp.TenSanPham, TenLoaiSanPham = lsp.TenLoaiSanPham, soluong = c.soluong, giaban = c.giaban, NgayLapHoaDon = hd.NgayLapHoaDon, Image = sp.Image };
            return Ok(query);
        }
    }
}
