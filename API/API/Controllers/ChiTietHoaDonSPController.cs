using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace API.Controllers
{
    public class ChiTietHoaDonSPController : ApiController
    {
        [HttpPost]
        public bool InsertNewCTHD(ChiTietHoaDonSanPham cthd)
        {
            try
            {
                QLLKDataContext db = new QLLKDataContext();

                ChiTietHoaDonSanPham ct = new ChiTietHoaDonSanPham();
                ct.MaHoaDon = cthd.MaHoaDon;
                ct.tensp = cthd.tensp;
                ct.tenloai = cthd.tenloai;
                ct.tenhang = cthd.tenhang;
                ct.giaban = cthd.giaban;
                ct.soluong = cthd.soluong;
                ct.hinh = cthd.hinh;
                ct.MaSanPham = cthd.MaSanPham;

                db.ChiTietHoaDonSanPhams.InsertOnSubmit(cthd);
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
