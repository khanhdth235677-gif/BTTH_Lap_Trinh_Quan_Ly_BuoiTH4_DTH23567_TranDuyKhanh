using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanHang.Data
{
    public class HoaDon_ChiTiet
    {
        public int ID { get; set; }
        public int HoaDonID { get; set; }     // Foreign key
        public int SanPhamID { get; set; }    // Foreign key
        public short SoLuongBan { get; set; } // short vì số lượng thường không quá lớn
        public int DonGiaBan { get; set; }    // giá bán tại thời điểm lập hóa đơn

        // Navigation properties
        public virtual HoaDon HoaDon { get; set; } = null!;
        public virtual SanPham SanPham { get; set; } = null!;
    }
}
