using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace API.Controllers
{
    public class TT3Controller : ApiController
    {
        [HttpGet]
        public List<View_TinhTrangThree> GetHDLists()
        {
            QLLKDataContext db = new QLLKDataContext();

            return db.View_TinhTrangThrees.ToList();
        }

        [HttpGet]
        public List<View_TinhTrangThree> GetHDListsgio(string id,string ma)
        {
            QLLKDataContext db = new QLLKDataContext();

            return db.View_TinhTrangThrees.Where(t => t.TenTinhTrangOne == id && t.TenTinhTrangTwo == ma).ToList();
        }
    }
}
