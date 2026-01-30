using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanHang.Data
{
    public class KhachHang
    {
        public int ID { get; set; }
        public string HoVaTen { get; set; } = string.Empty;
        public string? DienThoai { get; set; }
        public string? DiaChi { get; set; }

        // Navigation property (1 khách hàng → nhiều hóa đơn)
        public virtual List<HoaDon> HoaDons { get; set; } = new();
    }
}
