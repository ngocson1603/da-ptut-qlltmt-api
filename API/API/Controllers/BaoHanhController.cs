using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace API.Controllers
{
    public class BaoHanhController : ApiController
    {
        [HttpGet]
        public List<View_BaoHanh> GetHSXLists()
        {
            QLLKDataContext db = new QLLKDataContext();

            return db.View_BaoHanhs.ToList();
        }

        [HttpGet]
        public List<View_BaoHanh> GetHSXLists(int id)
        {
            QLLKDataContext db = new QLLKDataContext();

            return db.View_BaoHanhs.Where(t => t.MaBH == id).ToList();
        }

        [HttpPost]
        public bool InsertBH(BaoHanh kh)
        {
            try
            {
                QLLKDataContext db = new QLLKDataContext();
                BaoHanh khs = new BaoHanh();
                khs.NgayLap = kh.NgayLap;
                khs.MaNhanVien = kh.MaNhanVien;
                khs.MaHoaDon = kh.MaHoaDon;
                db.BaoHanhs.InsertOnSubmit(kh);
                db.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        [HttpDelete]
        public bool DeleteBH(int id)
        {
            try
            {
                QLLKDataContext db = new QLLKDataContext();
                var kh = db.BaoHanhs.Where(t => t.MaBH == id).FirstOrDefault();

                db.BaoHanhs.DeleteOnSubmit(kh);
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
