using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace API.Controllers
{
    public class NhanVienController : ApiController
    {
        [HttpGet]
        public List<View_NhanVien> GetNhanVienLists()
        {
            QLLKDataContext db = new QLLKDataContext();

            return db.View_NhanViens.ToList();
        }

        [HttpGet]
        public List<View_NhanVien> GetNhanVien(int id)
        {
            QLLKDataContext db = new QLLKDataContext();

            return db.View_NhanViens.Where(t => t.MaNhanVien == id).ToList();
        }

        [HttpPut]
        public bool UpdateNhanVien(NhanVien kh, int id)
        {
            try
            {
                QLLKDataContext db = new QLLKDataContext();
                NhanVien khs = db.NhanViens.Where(t => t.MaNhanVien == id).FirstOrDefault();
               // khs.MaNhanVien = kh.MaNhanVien;
                khs.TenNhanVien = kh.TenNhanVien;
                khs.NgaySinh = kh.NgaySinh;
                khs.GioiTinh = kh.GioiTinh;
                khs.NgayVaoLam = kh.NgayVaoLam;
                khs.ChucVu = kh.ChucVu;
                khs.DiaChi = kh.DiaChi;
                khs.SoDT = kh.SoDT;

                db.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        [HttpPost]
        public bool InsertNhanVien(NhanVien kh)
        {
            try
            {
                QLLKDataContext db = new QLLKDataContext();
                NhanVien khs = new NhanVien();
               // khs.MaNhanVien = kh.MaNhanVien;
                khs.TenNhanVien = kh.TenNhanVien;
                khs.NgaySinh = kh.NgaySinh;
                khs.GioiTinh = kh.GioiTinh;
                khs.NgayVaoLam = kh.NgayVaoLam;
                khs.ChucVu = kh.ChucVu;
                khs.DiaChi = kh.DiaChi;
                khs.SoDT = kh.SoDT;

                db.NhanViens.InsertOnSubmit(kh);
                db.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }



        [HttpDelete]
        public bool DeleteNhanVien(int id)
        {
            try
            {
                QLLKDataContext db = new QLLKDataContext();
                var kh = db.NhanViens.Where(t => t.MaNhanVien == id).FirstOrDefault();

                db.NhanViens.DeleteOnSubmit(kh);
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
