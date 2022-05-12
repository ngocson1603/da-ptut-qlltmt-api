﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace API.Controllers
{
    public class GioHangController : ApiController
    {
        [HttpGet]
        public List<View_GioHang> GetGioLists()
        {
            QLLKDataContext db = new QLLKDataContext();

            return db.View_GioHangs.ToList();
        }

        [HttpGet]
        public List<View_GioHang> GetGio(string id)
        {
            QLLKDataContext db = new QLLKDataContext();

            return db.View_GioHangs.Where(t => t.Gmail.Equals(id)).ToList();
        }
    }
}
