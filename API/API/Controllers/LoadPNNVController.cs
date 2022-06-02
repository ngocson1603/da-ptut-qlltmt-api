using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace API.Controllers
{
    public class LoadPNNVController : ApiController
    {
        [HttpGet]
        public List<View_PhieuNhap> GetHoaDonLists()
        {
            QLLKDataContext db = new QLLKDataContext();

            return db.View_PhieuNhaps.ToList();
        }
        [HttpGet]
        public List<View_PhieuNhap> GetHDListsgio(int id)
        {
            QLLKDataContext db = new QLLKDataContext();

            return db.View_PhieuNhaps.Where(t => t.MaNhanVien == id).ToList();
        }
    }
}
