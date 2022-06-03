using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace API.Controllers
{
    public class SanPhamController : ApiController
    {
        [HttpGet]
        public List<View_SanPham> GetSanPhamLists()
        {
            QLLKDataContext db = new QLLKDataContext();

            return db.View_SanPhams.ToList();
        }


        [HttpPost]
        public bool InsertSanPham(SanPham sp)
        {
            try
            {
                QLLKDataContext db = new QLLKDataContext();
                SanPham khs = new SanPham();
                //khs.MaSanPham = sp.MaSanPham;
                khs.TenSanPham = sp.TenSanPham;
                khs.LoaiSanPham = sp.LoaiSanPham;
                khs.HangSanXuat = sp.HangSanXuat;
                khs.HSD = sp.HSD;
                khs.GiaBan = sp.GiaBan;
                khs.TonKho = sp.TonKho;
                khs.Image = sp.Image;

                db.SanPhams.InsertOnSubmit(sp);
                db.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        [HttpDelete]
        public bool DeleteGio(int id)
        {
            try
            {
                QLLKDataContext db = new QLLKDataContext();
                var kh = db.SanPhams.Where(t => t.MaSanPham == id).FirstOrDefault();

                db.SanPhams.DeleteOnSubmit(kh);
                db.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }


        [HttpPut]
        public bool UpdateKhachHang(SanPham sp, int id)
        {
            try
            {
                QLLKDataContext db = new QLLKDataContext();
                SanPham khs = db.SanPhams.Where(t => t.MaSanPham == id).FirstOrDefault();
                //khs.MaSanPham = sp.MaSanPham;
                khs.TenSanPham = sp.TenSanPham;
                khs.LoaiSanPham = sp.LoaiSanPham;
                khs.HangSanXuat = sp.HangSanXuat;
                khs.HSD = sp.HSD;
                khs.GiaBan = sp.GiaBan;
                khs.TonKho = sp.TonKho;
                khs.Image = sp.Image;

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
