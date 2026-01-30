using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanHang.Data
{
    public class NhanVien
    {
        public int ID { get; set; }
        public string HoVaTen { get; set; } = string.Empty;
        public string? DienThoai { get; set; }
        public string? DiaChi { get; set; }
        public string TenDangNhap { get; set; } = string.Empty;
        public string MatKhau { get; set; } = string.Empty;  // Lưu ý: Trong thực tế nên hash mật khẩu
        public bool QuyenHan { get; set; }  // true = admin, false = nhân viên thường

        // Navigation property (1 nhân viên → nhiều hóa đơn)
        public virtual List<HoaDon> HoaDons { get; set; } = new();
    }
}
