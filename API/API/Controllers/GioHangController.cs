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
        public List<View_CTHD> GetHDListsgio(int id)
        {
            QLLKDataContext db = new QLLKDataContext();

            return db.View_CTHDs.Where(t => t.MaKH == id).ToList();
        }
        [HttpPost]
        public bool InsertNewGio(HoaDon cthd)
        {
            try
            {
                QLLKDataContext db = new QLLKDataContext();

                HoaDon ct = new HoaDon();
                ct.MaHoaDon = cthd.MaHoaDon;
                ct.MaKH = cthd.MaKH;
                ct.NgayLapHoaDon = cthd.NgayLapHoaDon;
                ct.MaNhanVien = cthd.MaNhanVien;

                db.HoaDons.InsertOnSubmit(cthd);
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


    }
}
