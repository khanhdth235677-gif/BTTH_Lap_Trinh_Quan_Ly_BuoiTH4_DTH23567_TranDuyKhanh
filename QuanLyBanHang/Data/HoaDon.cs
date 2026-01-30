using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanHang.Data
{
    public class HoaDon
    {
        public int ID { get; set; }
        public int NhanVienID { get; set; }      // Foreign key
        public int KhachHangID { get; set; }     // Foreign key
        public DateTime NgayLap { get; set; } = DateTime.Now;
        public string? GhiChuHoaDon { get; set; }

        // Navigation properties
        public virtual List<HoaDon_ChiTiet> HoaDon_ChiTiets { get; set; } = new();

        public virtual NhanVien NhanVien { get; set; } = null!;
        public virtual KhachHang KhachHang { get; set; } = null!;
    }
}
