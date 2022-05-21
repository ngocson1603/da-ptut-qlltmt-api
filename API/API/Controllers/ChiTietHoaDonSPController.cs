using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace API.Controllers
{
    public class ChiTietHoaDonSPController : ApiController
    {
        [HttpGet]
        public List<View_CTHDSP> GetHDListssp()
        {
            QLLKDataContext db = new QLLKDataContext();

            return db.View_CTHDSPs.ToList();
        }

        [HttpGet]
        public List<View_CTHDSP> GetHDListsgiosp(int id)
        {
            QLLKDataContext db = new QLLKDataContext();

            return db.View_CTHDSPs.Where(t => t.MaHoaDon == id).ToList();
        }

        [HttpPost]
        public bool InsertNewGioCTHD(ChiTietHoaDonSanPham cthd)
        {
            try
            {
                QLLKDataContext db = new QLLKDataContext();

                ChiTietHoaDonSanPham ct = new ChiTietHoaDonSanPham();
                ct.MaHoaDon = cthd.MaHoaDon;
                ct.tensp = cthd.tensp;
                ct.tenloai = cthd.tenloai;
                ct.tenhang = cthd.tenhang;
                ct.giaban = cthd.giaban;
                ct.soluong = cthd.soluong;
                ct.TongTien = cthd.TongTien;
                ct.hinh = cthd.hinh;
                ct.MaSanPham = cthd.MaSanPham;
                db.ChiTietHoaDonSanPhams.InsertOnSubmit(cthd);
                db.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        [HttpDelete]
        public bool DeleteCTHD(int id)
        {
            try
            {
                QLLKDataContext db = new QLLKDataContext();
                var kh = db.ChiTietHoaDonSanPhams.Where(t => t.MaHoaDon == id).ToList();

                db.ChiTietHoaDonSanPhams.DeleteAllOnSubmit(kh);
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
