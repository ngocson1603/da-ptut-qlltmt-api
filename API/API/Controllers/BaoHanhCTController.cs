using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace API.Controllers
{
    public class BaoHanhCTController : ApiController
    {
        [HttpGet]
        public List<View_BaoHanhCT> GetHSXLists()
        {
            QLLKDataContext db = new QLLKDataContext();

            return db.View_BaoHanhCTs.ToList();
        }

        [HttpGet]
        public List<View_BaoHanhCT> GetHSXLists(int id)
        {
            QLLKDataContext db = new QLLKDataContext();

            return db.View_BaoHanhCTs.Where(t => t.MaBH == id).ToList();
        }

        [HttpPost]
        public bool InsertBH(CTBaoHanh kh)
        {
            try
            {
                QLLKDataContext db = new QLLKDataContext();
                CTBaoHanh khs = new CTBaoHanh();
                khs.MaBH = kh.MaBH;
                khs.MaSanPham = kh.MaSanPham;
                khs.SoLuong = kh.SoLuong;
                khs.LyDo = kh.LyDo;
                db.CTBaoHanhs.InsertOnSubmit(kh);
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
                var kh = db.CTBaoHanhs.Where(t => t.MaBH == id).FirstOrDefault();

                db.CTBaoHanhs.DeleteOnSubmit(kh);
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
