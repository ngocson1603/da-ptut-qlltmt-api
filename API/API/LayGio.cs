using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace API
{
    public class LayGio
    {
        public int maHoaDon { get; set; }
        public int? maSanPham { get; set; }
        public string gmail { get; set; }
        public int? soluong { get; set; }
        public int? tongtien { get; set; }
        public int? tongtienhoadon { get; set; }
        public DateTime? ngaylaphoadon { get; set; }
        public string image { get; set; }
    }
}