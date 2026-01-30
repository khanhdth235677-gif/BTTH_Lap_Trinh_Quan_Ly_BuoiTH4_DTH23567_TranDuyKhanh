using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanHang.Data
{
    // HangSanXuat.cs
    public class HangSanXuat
    {
        public int ID { get; set; }
        public string TenHangSanXuat { get; set; } = string.Empty;

        public virtual List<SanPham> SanPhams { get; set; } = new();
    }
}
