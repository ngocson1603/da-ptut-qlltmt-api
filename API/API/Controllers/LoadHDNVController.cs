using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace API.Controllers
{
    public class LoadHDNVController : ApiController
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

            return db.View_CTHDs.Where(t => t.MaNhanVien == id).ToList();
        }
    }
}
