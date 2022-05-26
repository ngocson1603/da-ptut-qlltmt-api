using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace API.Controllers
{
    public class CTPNController : ApiController
    {
        [HttpGet]
        public List<View_CTPhieuNhap> GetNhanVienLists()
        {
            QLLKDataContext db = new QLLKDataContext();

            return db.View_CTPhieuNhaps.ToList();
        }
        [HttpGet]
        public List<View_CTPhieuNhap> GetNhanVien(int id)
        {
            QLLKDataContext db = new QLLKDataContext();

            return db.View_CTPhieuNhaps.Where(t => t.MaPhieuNhap == id).ToList();
        }
        [HttpPost]
        public bool InsertPN(ChiTietPhieuNhap kh)
        {
            try
            {
                QLLKDataContext db = new QLLKDataContext();
                ChiTietPhieuNhap khs = new ChiTietPhieuNhap();

                khs.MaPhieuNhap = kh.MaPhieuNhap;
                khs.MaSanPham = kh.MaSanPham;
                khs.SoLuong = kh.SoLuong;
                khs.TienNhap = kh.TienNhap;

                db.ChiTietPhieuNhaps.InsertOnSubmit(kh);
                db.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }



        [HttpDelete]
        public bool DeletePN(int id)
        {
            try
            {
                QLLKDataContext db = new QLLKDataContext();
                var kh = db.ChiTietPhieuNhaps.Where(t => t.MaPhieuNhap == id).FirstOrDefault();

                db.ChiTietPhieuNhaps.DeleteOnSubmit(kh);
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
