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
        public List<View_KH> GetKhachHangLists()
        {
            QLLKDataContext db = new QLLKDataContext();

            return db.View_KHs.ToList();
        }

        [HttpGet]
        public List<View_KH> GetKhachHang(string id)
        {
            QLLKDataContext db = new QLLKDataContext();

            return db.View_KHs.Where(t => t.Gmail == id).ToList();
        }

        [HttpPut]
        public bool UpdateKhachHang(KhachHang kh, int id)
        {
            try
            {
                QLLKDataContext db = new QLLKDataContext();
                KhachHang khs = db.KhachHangs.Where(t => t.MaKH == id).FirstOrDefault();
                khs.Gmail = kh.Gmail;
                khs.Pass = kh.Pass;
                khs.TenKhachHang = kh.TenKhachHang;
                khs.Ngaysinh = kh.Ngaysinh;
                khs.GioiTinh = kh.GioiTinh;
                khs.DiaChi = kh.DiaChi;
                khs.SDT = kh.SDT;
                db.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        [HttpPost]
        public bool InsertKhachHang(KhachHang kh)
        {
            try
            {
                QLLKDataContext db = new QLLKDataContext();
                KhachHang khs = new KhachHang();
                khs.Gmail = kh.Gmail;
                khs.Pass = kh.Pass;
                khs.TenKhachHang = kh.TenKhachHang;
                khs.Ngaysinh = kh.Ngaysinh;
                khs.GioiTinh = kh.GioiTinh;
                khs.DiaChi = kh.DiaChi;
                khs.SDT = kh.SDT;

                db.KhachHangs.InsertOnSubmit(kh);
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
