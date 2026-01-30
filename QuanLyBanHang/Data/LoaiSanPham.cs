using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanHang.Data
{
    // LoaiSanPham.cs
    public class LoaiSanPham
    {
        public int ID { get; set; }
        public string TenLoai { get; set; } = string.Empty;

        public virtual List<SanPham> SanPhams { get; set; } = new();   // thay ObservableCollectionListSource bằng List
    }
}
