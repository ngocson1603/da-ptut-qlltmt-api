using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace API
{
    public class BieuMau
    {
        public string TenSanPham { get; set; }
        public int? soluong { get; set; }
        public int? giaban { get; set; }
        public DateTime? NgayLapHoaDon { get; set; }
        public int MaHoaDon { get; set; }
        public int? TongTien { get; set; }
        public int MaKH { get; set; }
    }
}