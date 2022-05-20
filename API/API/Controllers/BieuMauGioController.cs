﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace API.Controllers
{
    public class BieuMauGioController : ApiController
    {
        [HttpGet]
        public IHttpActionResult GetBieuMauGioLists()
        {
            QLLKDataContext db = new QLLKDataContext();
            List<ChiTietHoaDon> chitiet = db.ChiTietHoaDons.ToList();
            List<ChiTietHoaDonSanPham> sanpham = db.ChiTietHoaDonSanPhams.ToList();
            var query = from c in chitiet
                        join sp in sanpham on c.MaHoaDon equals sp.MaHoaDon into table1
                        from sp in table1.DefaultIfEmpty()
                        select new BieuMau { TenSanPham = sp.tensp, SoLuong = sp.soluong, TongTien = sp.giaban, NgayLapHoaDon = c.NgayLapHoaDon, Gmail = c.Gmail };
            return Ok(query);
        }

        [HttpGet]
        public IHttpActionResult GetBieuMauGioLists(string id)
        {
            QLLKDataContext db = new QLLKDataContext();
            List<ChiTietHoaDon> chitiet = db.ChiTietHoaDons.ToList();
            List<ChiTietHoaDonSanPham> sanpham = db.ChiTietHoaDonSanPhams.ToList();
            var query = from c in chitiet
                        join sp in sanpham on c.MaHoaDon equals sp.MaHoaDon into table1
                        from sp in table1.DefaultIfEmpty()
                        where c.Gmail == id.ToString()
                        select new BieuMau { TenSanPham = sp.tensp, SoLuong = sp.soluong, TongTien = sp.giaban, NgayLapHoaDon = c.NgayLapHoaDon, Gmail = c.Gmail };

            return Ok(query);
        }
    }
}
