using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace API.Controllers
{
    public class DangNhapController : ApiController
    {
        public bool GetNhanVien(string id, string pass)
        {
            QLLKDataContext db = new QLLKDataContext();

            return db.Users.Where(t => t.TenDangNhap == id && t.Password == pass).FirstOrDefault() != null;
        }
    }
}
