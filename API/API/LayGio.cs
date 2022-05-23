using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace API
{
    public class LayGio
    {
        public int MaHoaDon { get; set; }
        public int MaSanPham { get; set; }
        public int MaKH { get; set; }
        public string TenSanPham { get; set; }
        public string TenLoaiSanPham { get; set; }
        public int? soluong { get; set; }
        public int? giaban { get; set; }
        public DateTime? NgayLapHoaDon { get; set; }
        public string Image { get; set; }
    }
}