using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace API.Controllers
{
    public class TT2Controller : ApiController
    {
        [HttpGet]
        public List<View_TinhTrangTwo> GetHDLists()
        {
            QLLKDataContext db = new QLLKDataContext();

            return db.View_TinhTrangTwos.ToList();
        }

        [HttpGet]
        public List<View_TinhTrangTwo> GetHDListsgio(string id)
        {
            QLLKDataContext db = new QLLKDataContext();

            return db.View_TinhTrangTwos.Where(t => t.TenTinhTrangOne == id).ToList();
        }
    }
}
