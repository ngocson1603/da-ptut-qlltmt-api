using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace API.Controllers
{
    public class HDController : ApiController
    {
        [HttpGet]
        public List<View_CTHD> GetHoaDonLists()
        {
            QLLKDataContext db = new QLLKDataContext();

            return db.View_CTHDs.ToList();
        }
        [HttpGet]
        public List<View_CTHD> GetHDListsgio(int id)
        {
            QLLKDataContext db = new QLLKDataContext();

            return db.View_CTHDs.Where(t => t.MaHoaDon == id).ToList();
        }

        [HttpPost]
        public bool InsertHoaDon(HoaDon sp)
        {
            try
            {
                QLLKDataContext db = new QLLKDataContext();
                HoaDon khs = new HoaDon();
                //khs.MaSanPham = sp.MaSanPham;
                khs.MaHoaDon = sp.MaHoaDon;
                khs.MaKH = sp.MaKH;
                khs.NgayLapHoaDon = sp.NgayLapHoaDon;
                khs.MaNhanVien = sp.MaNhanVien;


                db.HoaDons.InsertOnSubmit(sp);
                db.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        [HttpDelete]
        public bool DeleteHoaDon(int id)
        {
            try
            {
                QLLKDataContext db = new QLLKDataContext();
                var kh = db.HoaDons.Where(t => t.MaHoaDon == id).FirstOrDefault();

                db.HoaDons.DeleteOnSubmit(kh);
                db.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }


        [HttpPut]
        public bool UpdateHoaDon(HoaDon sp, int id)
        {
            try
            {
                QLLKDataContext db = new QLLKDataContext();
                HoaDon khs = db.HoaDons.Where(t => t.MaHoaDon == id).FirstOrDefault();

                khs.MaKH = sp.MaKH;
                khs.NgayLapHoaDon = sp.NgayLapHoaDon;
                khs.MaNhanVien = sp.MaNhanVien;

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
