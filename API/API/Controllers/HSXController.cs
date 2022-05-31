using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace API.Controllers
{
    public class HSXController : ApiController
    {
        [HttpGet]
        public List<View_HSX> GetHSXLists()
        {
            QLLKDataContext db = new QLLKDataContext();

            return db.View_HSXes.ToList();
        }

        [HttpGet]
        public List<View_HSX> GetHSXLists(int id)
        {
            QLLKDataContext db = new QLLKDataContext();

            return db.View_HSXes.Where(t => t.MaHangSanXuat == id).ToList();
        }

        [HttpPut]
        public bool UpdateLSP(HangSanXuat kh, int id)
        {
            try
            {
                QLLKDataContext db = new QLLKDataContext();
                HangSanXuat khs = db.HangSanXuats.Where(t => t.MaHangSanXuat == id).FirstOrDefault();
                khs.TenHangSanXuat = kh.TenHangSanXuat;
                db.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        [HttpPost]
        public bool InsertLSP(HangSanXuat kh)
        {
            try
            {
                QLLKDataContext db = new QLLKDataContext();
                HangSanXuat khs = new HangSanXuat();
                khs.TenHangSanXuat = kh.TenHangSanXuat;
                db.HangSanXuats.InsertOnSubmit(kh);
                db.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        [HttpDelete]
        public bool DeleteLSP(int id)
        {
            try
            {
                QLLKDataContext db = new QLLKDataContext();
                var kh = db.HangSanXuats.Where(t => t.MaHangSanXuat == id).FirstOrDefault();

                db.HangSanXuats.DeleteOnSubmit(kh);
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
