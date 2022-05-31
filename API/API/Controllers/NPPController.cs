using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace API.Controllers
{
    public class NPPController : ApiController
    {
        [HttpGet]
        public List<View_NPP> GetLSPLists()
        {
            QLLKDataContext db = new QLLKDataContext();

            return db.View_NPPs.ToList();
        }

        [HttpGet]
        public List<View_NPP> GetLSPLists(int id)
        {
            QLLKDataContext db = new QLLKDataContext();

            return db.View_NPPs.Where(t => t.MaNhaPhanPhoi == id).ToList();
        }

        [HttpPut]
        public bool UpdateNPP(NhaPhanPhoi kh, int id)
        {
            try
            {
                QLLKDataContext db = new QLLKDataContext();
                NhaPhanPhoi khs = db.NhaPhanPhois.Where(t => t.MaNhaPhanPhoi == id).FirstOrDefault();
                khs.TenNhaPhanPhoi = kh.TenNhaPhanPhoi;
                khs.DiaChi = kh.DiaChi;
                khs.SDT = kh.SDT;
                khs.Email = kh.Email;
                db.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        [HttpPost]
        public bool InsertNPP(NhaPhanPhoi kh)
        {
            try
            {
                QLLKDataContext db = new QLLKDataContext();
                NhaPhanPhoi khs = new NhaPhanPhoi();
                khs.TenNhaPhanPhoi = kh.TenNhaPhanPhoi;
                khs.DiaChi = kh.DiaChi;
                khs.SDT = kh.SDT;
                khs.Email = kh.Email;
                db.NhaPhanPhois.InsertOnSubmit(kh);
                db.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        [HttpDelete]
        public bool DeleteNPP(int id)
        {
            try
            {
                QLLKDataContext db = new QLLKDataContext();
                var kh = db.NhaPhanPhois.Where(t => t.MaNhaPhanPhoi == id).FirstOrDefault();

                db.NhaPhanPhois.DeleteOnSubmit(kh);
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
