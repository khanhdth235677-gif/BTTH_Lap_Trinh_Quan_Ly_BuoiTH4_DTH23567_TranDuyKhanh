using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanHang.Data
{
    // SanPham.cs
    public class SanPham
    {
        public int ID { get; set; }
        public int HangSanXuatID { get; set; }
        public int LoaiSanPhamID { get; set; }
        public string TenSanPham { get; set; } = string.Empty;
        public int DonGia { get; set; }
        public int SoLuong { get; set; }
        public string? HinhAnh { get; set; }
        public string? MoTa { get; set; }

        public virtual LoaiSanPham LoaiSanPham { get; set; } = null!;
        public virtual HangSanXuat HangSanXuat { get; set; } = null!;

        public virtual List<HoaDon_ChiTiet> HoaDon_ChiTiets { get; set; } = new();
    }
}
