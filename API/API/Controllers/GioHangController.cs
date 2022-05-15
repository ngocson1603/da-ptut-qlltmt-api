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
                        select new LayGio { MaHoaDon = c.MaHoaDon,MaSanPham = c.MaSanPham,Gmail = c.Gmail,SoLuong=c.SoLuong,TongTien = c.TongTien,TongTienHoaDon=c.TongTienHoaDon,NgayLapHoaDon=c.NgayLapHoaDon,Image=sp.Image };
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
                        select new LayGio { MaHoaDon = c.MaHoaDon, MaSanPham = c.MaSanPham, Gmail = c.Gmail, SoLuong = c.SoLuong, TongTien = c.TongTien, TongTienHoaDon = c.TongTienHoaDon, NgayLapHoaDon = c.NgayLapHoaDon, Image = sp.Image };
            return Ok(query);
        }
        [HttpPost]
        public bool InsertNewGio(ChiTietHoaDon cthd)
        {
            try
            {
                QLLKDataContext db = new QLLKDataContext();

                ChiTietHoaDon ct = new ChiTietHoaDon();
                ct.MaSanPham = cthd.MaSanPham;
                ct.Gmail = cthd.Gmail;
                ct.SoLuong = cthd.SoLuong;
                ct.TongTien = cthd.TongTien;
                ct.TongTienHoaDon = cthd.TongTienHoaDon;
                ct.NgayLapHoaDon = cthd.NgayLapHoaDon;

                db.ChiTietHoaDons.InsertOnSubmit(cthd);
                db.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        [HttpDelete]
        public bool DeleteGio(int id)
        {
            try
            {
                QLLKDataContext db = new QLLKDataContext();
                ChiTietHoaDon kh = db.ChiTietHoaDons.Where(t => t.MaHoaDon == id).FirstOrDefault();

                db.ChiTietHoaDons.DeleteOnSubmit(kh);
                db.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
