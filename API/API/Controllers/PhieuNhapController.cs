using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace API.Controllers
{
    public class PhieuNhapController : ApiController
    {
        [HttpGet]
        public List<View_PhieuNhap> GetNhanVienLists()
        {
            QLLKDataContext db = new QLLKDataContext();

            return db.View_PhieuNhaps.ToList();
        }

        [HttpGet]
        public List<View_PhieuNhap> GetNhanVien(int id)
        {
            QLLKDataContext db = new QLLKDataContext();

            return db.View_PhieuNhaps.Where(t => t.MaPhieuNhap == id).ToList();
        }

        [HttpPut]
        public bool UpdatePN(PhieuNhap kh, int id)
        {
            try
            {
                QLLKDataContext db = new QLLKDataContext();
                PhieuNhap khs = db.PhieuNhaps.Where(t => t.MaPhieuNhap == id).FirstOrDefault();
                khs.MaPhieuNhap = kh.MaPhieuNhap;
                khs.MaNhanVien = kh.MaNhanVien;
                khs.MaNhaPhanPhoi = kh.MaNhaPhanPhoi;
                //khs.TongTien = kh.TongTien;
                khs.NgayNhap = kh.NgayNhap;

                db.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        [HttpPost]
        public bool InsertPN(PhieuNhap kh)
        {
            try
            {
                QLLKDataContext db = new QLLKDataContext();
                PhieuNhap khs = new PhieuNhap();

                khs.MaPhieuNhap = kh.MaPhieuNhap;
                khs.MaNhanVien = kh.MaNhanVien;
                khs.MaNhaPhanPhoi = kh.MaNhaPhanPhoi;
               // khs.TongTien = kh.TongTien;
                khs.NgayNhap = kh.NgayNhap;

                db.PhieuNhaps.InsertOnSubmit(kh);
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
                var kh = db.PhieuNhaps.Where(t => t.MaPhieuNhap == id).FirstOrDefault();

                db.PhieuNhaps.DeleteOnSubmit(kh);
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
