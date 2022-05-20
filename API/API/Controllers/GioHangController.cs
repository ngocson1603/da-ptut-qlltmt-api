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
        public List<View_CTHD> GetHDLists()
        {
            QLLKDataContext db = new QLLKDataContext();

            return db.View_CTHDs.ToList();
        }

        [HttpGet]
        public List<View_CTHD> GetHDListsgio(string id)
        {
            QLLKDataContext db = new QLLKDataContext();

            return db.View_CTHDs.Where(t => t.Gmail == id).ToList();
        }
        [HttpPost]
        public bool InsertNewGio(ChiTietHoaDon cthd)
        {
            try
            {
                QLLKDataContext db = new QLLKDataContext();

                ChiTietHoaDon ct = new ChiTietHoaDon();
                ct.MaHoaDon = cthd.MaHoaDon;
                ct.Gmail = cthd.Gmail;
                ct.NgayLapHoaDon = cthd.NgayLapHoaDon;
                ct.MaNhanVien = cthd.MaNhanVien;

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
                var kh = db.ChiTietHoaDons.Where(t => t.MaHoaDon == id).ToList();

                db.ChiTietHoaDons.DeleteAllOnSubmit(kh);
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
