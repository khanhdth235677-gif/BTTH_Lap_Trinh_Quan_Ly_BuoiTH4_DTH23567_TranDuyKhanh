using ClosedXML.Excel;
using QuanLyBanHang.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanHang
{
    public partial class Form_Hang_San_Xuat : Form
    {
        //  Khai báo biến toàn cục
        private QLBHDbContext context = new QLBHDbContext();  // Khởi tạo biến ngữ cảnh CSDL
        private bool xuLyThem = false;                        // Kiểm tra có đang xử lý thêm mới hay không
        private int id;                                       // Lưu mã loại sản phẩm khi sửa/xóa

        public Form_Hang_San_Xuat()
        {
            InitializeComponent();
        }
        private void BatTatChucNang(bool giaTri)
        {
            btnLuu.Enabled = giaTri;
            btnHuyBo.Enabled = giaTri;
            txtTenHangSanXuat.Enabled = giaTri;

            btnThem.Enabled = !giaTri;
            btnSua.Enabled = !giaTri;
            btnXoa.Enabled = !giaTri;
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            BatTatChucNang(false);

            // Lấy danh sách loại sản phẩm từ CSDL
            List<HangSanXuat> hsx = context.HangSanXuat.ToList();

            // BindingSource để binding dữ liệu
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = hsx;

            // Binding TextBox với trường TenLoai (chỉ hiển thị, không tự update ngược)
            txtTenHangSanXuat.DataBindings.Clear();
            txtTenHangSanXuat.DataBindings.Add("Text", bindingSource, "TenHangSanXuat", false, DataSourceUpdateMode.Never);

            // Gán nguồn dữ liệu cho DataGridView
            dataGridView.DataSource = bindingSource;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            xuLyThem = true;
            BatTatChucNang(true);
            txtTenHangSanXuat.Clear();
            txtTenHangSanXuat.Focus();  // Đặt con trỏ vào TextBox
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
            if (string.IsNullOrWhiteSpace(txtTenHangSanXuat.Text))
            {
                MessageBox.Show("Vui lòng nhập tên loại sản phẩm?", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTenHangSanXuat.Focus();
                return;
            }

            if (xuLyThem)
            {
                // Thêm mới
                LoaiSanPham lsp = new LoaiSanPham();
                lsp.TenLoai = txtTenHangSanXuat.Text.Trim();
                context.LoaiSanPham.Add(lsp);
            }
            else
            {
                // Sửa
                LoaiSanPham lsp = context.LoaiSanPham.Find(id);
                if (lsp != null)
                {
                    lsp.TenLoai = txtTenHangSanXuat.Text.Trim();
                    context.LoaiSanPham.Update(lsp);
                }
            }

            context.SaveChanges();

            // Tải lại form (làm mới danh sách và reset trạng thái)
            Form2_Load(sender, e);
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
                Form2_Load(sender, e);
            }
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            Form2_Load(sender, e);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Xuất dữ liệu ra tập tin Excel";
            saveFileDialog.Filter = "Tập tin Excel|*.xls;*.xlsx";
            saveFileDialog.FileName = "HangSanXuat_" + DateTime.Now.ToShortDateString().Replace("/", "_") + ".xlsx";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    DataTable table = new DataTable();
                    table.Columns.AddRange(new DataColumn[2] {
                        new DataColumn("ID", typeof(int)),
                        new DataColumn("TenHang", typeof(string))
                    });
                    var HangSanXuat = context.HangSanXuat.ToList();
                    if (HangSanXuat != null)
                    {
                        foreach (var p in HangSanXuat)
                            table.Rows.Add(p.ID, p.TenHangSanXuat);
                    }
                    using (XLWorkbook wb = new XLWorkbook())
                    {
                        var sheet = wb.Worksheets.Add(table, "HangSanXuat");
                        sheet.Columns().AdjustToContents();
                        wb.SaveAs(saveFileDialog.FileName);
                        MessageBox.Show("Đã xuất dữ liệu ra tập tin Excel thành công.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void btnNhap_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Nhập dữ liệu từ tập tin Excel";
            openFileDialog.Filter = "Tập tin Excel|*.xls;*.xlsx";
            openFileDialog.Multiselect = false;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    DataTable table = new DataTable();
                    using (XLWorkbook workbook = new XLWorkbook(openFileDialog.FileName))
                    {
                        IXLWorksheet worksheet = workbook.Worksheet(1);
                        bool firstRow = true;
                        string readRange = "1:1";
                        foreach (IXLRow row in worksheet.RowsUsed())
                        {
                            // Đọc dòng tiêu đề (dòng đầu tiên)
                            if (firstRow)
                            {
                                readRange = string.Format("{0}:{1}", 1, row.LastCellUsed().Address.ColumnNumber);
                                foreach (IXLCell cell in row.Cells(readRange))
                                    table.Columns.Add(cell.Value.ToString());
                                firstRow = false;
                            }
                            else // Đọc các dòng nội dung (các dòng tiếp theo)
                            {
                                table.Rows.Add();
                                int cellIndex = 0;
                                foreach (IXLCell cell in row.Cells(readRange))
                                {
                                    table.Rows[table.Rows.Count - 1][cellIndex] = cell.Value.ToString();
                                    cellIndex++;
                                }
                            }
                        }
                        if (table.Rows.Count > 0)
                        {
                            foreach (DataRow r in table.Rows)
                            {
                                HangSanXuat lsp = new HangSanXuat();
                                lsp.TenHangSanXuat = r["TenHangSanXuat"].ToString();
                                context.HangSanXuat.Add(lsp);
                            }
                            context.SaveChanges();
                            MessageBox.Show("Đã nhập thành công " + table.Rows.Count + " dòng.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Form2_Load(sender, e);
                        }
                        if (firstRow)
                            MessageBox.Show("Tập tin Excel rỗng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }
    }
}
