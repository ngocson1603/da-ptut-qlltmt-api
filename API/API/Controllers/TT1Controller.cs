using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace API.Controllers
{
    public class TT1Controller : ApiController
    {
        [HttpGet]
        public List<TinhTrangOne> GetHDLists()
        {
            QLLKDataContext db = new QLLKDataContext();

            return db.TinhTrangOnes.ToList();
        }
    }
}
