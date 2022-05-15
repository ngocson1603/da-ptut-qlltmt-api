using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace API
{
    public class ThemGioHang
    {
        public int MaHoaDon { get; set; }
        public int MaSanPham { get; set; }
        public string Gmail { get; set; }
        public int SoLuong { get; set; }
        public int TongTien { get; set; }
        public int TongTienHoaDon { get; set; }
        public DateTime NgayLapHoaDon { get; set; }
        public int MaNhanVien { get; set; }
    }
}