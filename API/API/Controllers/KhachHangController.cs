using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace API.Controllers
{
    public class KhachHangController : ApiController
    {
        [HttpGet]
        public List<KhachHang> GetKhoaLists()
        {
            QLLKDataContext db = new QLLKDataContext();

            return db.KhachHangs.ToList();
        }

        [HttpGet]
        public KhachHang GetKhoa(string id)
        {
            QLLKDataContext db = new QLLKDataContext();

            return db.KhachHangs.FirstOrDefault(t => t.Gmail.Equals(id));
        }
    }
}
