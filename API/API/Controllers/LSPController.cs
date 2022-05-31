using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace API.Controllers
{
    public class LSPController : ApiController
    {
        [HttpGet]
        public List<View_LSP> GetLSPLists()
        {
            QLLKDataContext db = new QLLKDataContext();

            return db.View_LSPs.ToList();
        }

        [HttpGet]
        public List<View_LSP> GetLSPLists(int id)
        {
            QLLKDataContext db = new QLLKDataContext();

            return db.View_LSPs.Where(t => t.MaLoaiSanPham == id).ToList();
        }

        [HttpPut]
        public bool UpdateLSP(LoaiSanPham kh, int id)
        {
            try
            {
                QLLKDataContext db = new QLLKDataContext();
                LoaiSanPham khs = db.LoaiSanPhams.Where(t => t.MaLoaiSanPham == id).FirstOrDefault();
                khs.TenLoaiSanPham = kh.TenLoaiSanPham;
                db.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        [HttpPost]
        public bool InsertLSP(LoaiSanPham kh)
        {
            try
            {
                QLLKDataContext db = new QLLKDataContext();
                LoaiSanPham khs = new LoaiSanPham();
                khs.TenLoaiSanPham = kh.TenLoaiSanPham;
                db.LoaiSanPhams.InsertOnSubmit(kh);
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
                var kh = db.LoaiSanPhams.Where(t => t.MaLoaiSanPham == id).FirstOrDefault();

                db.LoaiSanPhams.DeleteOnSubmit(kh);
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
