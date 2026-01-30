using QuanLyBanHang.Data;

namespace QuanLyBanHang
{
    public partial class Form_Loai_San_Pham : Form
    {
        //  Khai báo biến toàn cục
        private QLBHDbContext context = new QLBHDbContext();  // Khởi tạo biến ngữ cảnh CSDL
        private bool xuLyThem = false;                        // Kiểm tra có đang xử lý thêm mới hay không
        private int id;                                       // Lưu mã loại sản phẩm khi sửa/xóa
        public Form_Loai_San_Pham()
        {
            InitializeComponent();
        }
        // Hàm bật/tắt các chức năng ( phần chung)
        private void BatTatChucNang(bool giaTri)
        {
            btnLuu.Enabled = giaTri;
            btnHuyBo.Enabled = giaTri;
            txtTenLoai.Enabled = giaTri;

            btnThem.Enabled = !giaTri;
            btnSua.Enabled = !giaTri;
            btnXoa.Enabled = !giaTri;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            BatTatChucNang(false);

            // Lấy danh sách loại sản phẩm từ CSDL
            List<LoaiSanPham> lsp = context.LoaiSanPham.ToList();

            // BindingSource để binding dữ liệu
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = lsp;

            // Binding TextBox với trường TenLoai (chỉ hiển thị, không tự update ngược)
            txtTenLoai.DataBindings.Clear();
            txtTenLoai.DataBindings.Add("Text", bindingSource, "TenLoai", false, DataSourceUpdateMode.Never);

            // Gán nguồn dữ liệu cho DataGridView
            dataGridView.DataSource = bindingSource;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            xuLyThem = true;
            BatTatChucNang(true);
            txtTenLoai.Clear();
            txtTenLoai.Focus();  // Đặt con trỏ vào TextBox
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dataGridView.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn một dòng để sửa!", "Thông báo");
                return;
            }

            xuLyThem = false;
            BatTatChucNang(true);

            // Lấy ID từ cột ID của dòng đang chọn
            id = Convert.ToInt32(dataGridView.CurrentRow.Cells["ID"].Value.ToString());
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenLoai.Text))
            {
                MessageBox.Show("Vui lòng nhập tên loại sản phẩm?", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTenLoai.Focus();
                return;
            }

            if (xuLyThem)
            {
                // Thêm mới
                LoaiSanPham lsp = new LoaiSanPham();
                lsp.TenLoai = txtTenLoai.Text.Trim();
                context.LoaiSanPham.Add(lsp);
            }
            else
            {
                // Sửa
                LoaiSanPham lsp = context.LoaiSanPham.Find(id);
                if (lsp != null)
                {
                    lsp.TenLoai = txtTenLoai.Text.Trim();
                    context.LoaiSanPham.Update(lsp);
                }
            }

            context.SaveChanges();

            // Tải lại form (làm mới danh sách và reset trạng thái)
            Form1_Load(sender, e);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dataGridView.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn một dòng để xóa!", "Thông báo");
                return;
            }

            if (MessageBox.Show("Xác nhận xóa loại sản phẩm?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                id = Convert.ToInt32(dataGridView.CurrentRow.Cells["ID"].Value.ToString());

                LoaiSanPham lsp = context.LoaiSanPham.Find(id);
                if (lsp != null)
                {
                    context.LoaiSanPham.Remove(lsp);
                    context.SaveChanges();
                }

                // Tải lại form
                Form1_Load(sender, e);
            }
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            Form1_Load(sender, e);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
