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
    public partial class FormSanPham : Form
    {
        // --- 1. KHAI BÁO BIẾN ---
        QLBHDbContext context = new QLBHDbContext();
        bool xuLyThem = false;
        int idHienTai = 0; // Đổi tên biến để tránh nhầm lẫn

        // Đường dẫn thư mục ảnh
        string imagesFolder = Application.StartupPath.Replace("bin\\Debug\\net8.0-windows", "Images");

        // Biến lưu tên ảnh tạm
        string tenFileAnhTam = "";

        // --- 2. CÁC HÀM HỖ TRỢ ---
        private void BatTatChucNang(bool giaTri)
        {
            // --- NHÓM 1: CÁC NÚT SÁNG LÊN KHI BẤM THÊM/SỬA ---
            btnLuu.Enabled = giaTri;
            btnHuyBo.Enabled = giaTri;
            cboHangSanXuat.Enabled = giaTri;
            cboLoaiSanPham.Enabled = giaTri;
            txtTenSanPham.Enabled = giaTri;
            numSoLuong.Enabled = giaTri;
            numDonGia.Enabled = giaTri;
            txtMoTa.Enabled = giaTri;
            picHinhAnh.Enabled = giaTri;

            // Đưa nút Đổi Ảnh lên đây (bỏ dấu chấm than !)
            btnDoiAnh.Enabled = giaTri;


            // --- NHÓM 2: CÁC NÚT BỊ MỜ ĐI KHI BẤM THÊM/SỬA ---
            btnThem.Enabled = !giaTri;
            // Xóa dòng btnDoiAnh ở dưới này đi
            btnSua.Enabled = !giaTri;
            btnXoa.Enabled = !giaTri;
            btnTimKiem.Enabled = !giaTri;
            btnNhap.Enabled = !giaTri;
            btnXuat.Enabled = !giaTri;
        }
        public void LayLoaiSanPhamVaoComboBox()
        {
            cboLoaiSanPham.DataSource = context.LoaiSanPham.ToList();
            cboLoaiSanPham.ValueMember = "ID";
            cboLoaiSanPham.DisplayMember = "TenLoai";
        }

        public void LayHangSanXuatVaoComboBox()
        {
            cboHangSanXuat.DataSource = context.HangSanXuat.ToList();
            cboHangSanXuat.ValueMember = "ID";
            cboHangSanXuat.DisplayMember = "TenHangSanXuat";
        }
        public FormSanPham()
        {
            InitializeComponent();
        }

        private void FormSanPham_Load(object sender, EventArgs e)
        {
            try
            {
                BatTatChucNang(false);
                LayLoaiSanPhamVaoComboBox();
                LayHangSanXuatVaoComboBox();
                dataGridView.AutoGenerateColumns = false; // Tự chủ động cột

                // Lấy dữ liệu
                var listSP = context.SanPham.Select(r => new DanhSachSanPham
                {
                    ID = r.ID,
                    LoaiSanPhamID = r.LoaiSanPhamID,
                    TenLoai = r.LoaiSanPham.TenLoai,
                    HangSanXuatID = r.HangSanXuatID,
                    TenHangSanXuat = r.HangSanXuat.TenHangSanXuat,
                    TenSanPham = r.TenSanPham,
                    SoLuong = r.SoLuong,
                    DonGia = r.DonGia,
                    HinhAnh = r.HinhAnh,
                    MoTa = r.MoTa
                }).ToList();

                BindingSource bindingSource = new BindingSource();
                bindingSource.DataSource = listSP;

                // Xóa binding cũ trước khi thêm mới để tránh lỗi trùng
                txtTenSanPham.DataBindings.Clear();
                txtMoTa.DataBindings.Clear();
                numSoLuong.DataBindings.Clear();
                numDonGia.DataBindings.Clear();
                cboLoaiSanPham.DataBindings.Clear();
                cboHangSanXuat.DataBindings.Clear();
                picHinhAnh.DataBindings.Clear();

                // Binding dữ liệu
                cboLoaiSanPham.DataBindings.Add("SelectedValue", bindingSource, "LoaiSanPhamID", true, DataSourceUpdateMode.Never);
                cboHangSanXuat.DataBindings.Add("SelectedValue", bindingSource, "HangSanXuatID", true, DataSourceUpdateMode.Never);
                txtTenSanPham.DataBindings.Add("Text", bindingSource, "TenSanPham", true, DataSourceUpdateMode.Never);
                txtMoTa.DataBindings.Add("Text", bindingSource, "MoTa", true, DataSourceUpdateMode.Never);
                numSoLuong.DataBindings.Add("Value", bindingSource, "SoLuong", true, DataSourceUpdateMode.Never);
                numDonGia.DataBindings.Add("Value", bindingSource, "DonGia", true, DataSourceUpdateMode.Never);

                // --- XỬ LÝ ẢNH AN TOÀN (Sửa lỗi Null) ---
                Binding hinhAnhBinding = new Binding("ImageLocation", bindingSource, "HinhAnh", true);
                hinhAnhBinding.Format += (s, args) =>
                {
                    if (args.Value == null || string.IsNullOrEmpty(args.Value.ToString()))
                    {
                        args.Value = null; // Ảnh null thì trả về null
                    }
                    else
                    {
                        string fullPath = Path.Combine(imagesFolder, args.Value.ToString());
                        if (File.Exists(fullPath))
                            args.Value = fullPath;
                        else
                            args.Value = null;
                    }
                };
                picHinhAnh.DataBindings.Add(hinhAnhBinding);

                dataGridView.DataSource = bindingSource;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu: " + ex.Message);
            }

        }
        private void dataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridView.Columns[e.ColumnIndex].Name == "HinhAnh")
            {
                e.Value = null; // Mặc định là null để tránh lỗi text

                // Lấy đối tượng dòng hiện tại
                var row = dataGridView.Rows[e.RowIndex].DataBoundItem as DanhSachSanPham;
                if (row != null && !string.IsNullOrEmpty(row.HinhAnh))
                {
                    string filePath = Path.Combine(imagesFolder, row.HinhAnh);
                    if (File.Exists(filePath))
                    {
                        try
                        {
                            using (Image img = Image.FromFile(filePath))
                            {
                                e.Value = new Bitmap(img, 24, 24);
                            }
                        }
                        catch { } // Bỏ qua lỗi ảnh hỏng
                    }
                }
            }
        }
        private void dataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.ThrowException = false;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            xuLyThem = true;
            BatTatChucNang(true);

            // Reset form
            cboLoaiSanPham.SelectedIndex = -1;
            cboHangSanXuat.SelectedIndex = -1;
            txtTenSanPham.Clear();
            txtMoTa.Clear();
            numSoLuong.Value = 0;
            numDonGia.Value = 0;
            picHinhAnh.Image = null;

            tenFileAnhTam = ""; // Reset biến tạm
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            {
                // Kiểm tra nhập liệu
                if (string.IsNullOrWhiteSpace(txtTenSanPham.Text)) return;

                try
                {
                    if (xuLyThem)
                    {
                        SanPham sp = new SanPham();
                        sp.TenSanPham = txtTenSanPham.Text.Trim();
                        sp.SoLuong = (int)numSoLuong.Value;
                        sp.DonGia = (int)numDonGia.Value;
                        sp.LoaiSanPhamID = Convert.ToInt32(cboLoaiSanPham.SelectedValue);
                        sp.HangSanXuatID = Convert.ToInt32(cboHangSanXuat.SelectedValue);
                        sp.MoTa = txtMoTa.Text;

                        // Lưu ảnh từ biến tạm
                        if (!string.IsNullOrEmpty(tenFileAnhTam))
                        {
                            sp.HinhAnh = tenFileAnhTam;
                        }

                        context.SanPham.Add(sp);
                        context.SaveChanges();
                        tenFileAnhTam = ""; // Reset sau khi lưu
                        MessageBox.Show("Đã thêm!");
                    }
                    else
                    {
                        var sp = context.SanPham.Find(idHienTai);
                        if (sp != null)
                        {
                            sp.TenSanPham = txtTenSanPham.Text.Trim();
                            sp.SoLuong = (int)numSoLuong.Value;
                            sp.DonGia = (int)numDonGia.Value;
                            sp.LoaiSanPhamID = Convert.ToInt32(cboLoaiSanPham.SelectedValue);
                            sp.HangSanXuatID = Convert.ToInt32(cboHangSanXuat.SelectedValue);
                            sp.MoTa = txtMoTa.Text;
                            // Không gán HinhAnh ở đây vì nút Đổi Ảnh đã lưu rồi

                            context.SanPham.Update(sp);
                            context.SaveChanges();
                            MessageBox.Show("Đã sửa!");
                        }
                    }
                    FormSanPham_Load(sender, e);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi lưu: " + ex.Message);
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dataGridView.CurrentRow == null) return;

            if (MessageBox.Show("Xác nhận xóa?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                // Cách lấy ID an toàn nhất (FIX LỖI HÌNH 5)
                var item = dataGridView.CurrentRow.DataBoundItem as DanhSachSanPham;
                if (item != null)
                {
                    int idCanXoa = item.ID;
                    var sp = context.SanPham.Find(idCanXoa);
                    if (sp != null)
                    {
                        context.SanPham.Remove(sp);
                        context.SaveChanges();
                        FormSanPham_Load(sender, e); // Tải lại
                    }
                }
            }
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            tenFileAnhTam = "";
            FormSanPham_Load(sender, e);
        }

        private void btnDoiAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Ảnh|*.jpg;*.png;*.gif;*.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                string ext = Path.GetExtension(open.FileName);
                string newName = Guid.NewGuid().ToString() + ext; // Tạo tên ngẫu nhiên

                if (!Directory.Exists(imagesFolder)) Directory.CreateDirectory(imagesFolder);
                string dest = Path.Combine(imagesFolder, newName);

                File.Copy(open.FileName, dest, true);
                picHinhAnh.ImageLocation = dest;

                if (xuLyThem)
                {
                    tenFileAnhTam = newName; // Chỉ lưu tên vào biến tạm
                }
                else
                {
                    // Sửa thì lưu luôn vào DB
                    if (dataGridView.CurrentRow != null)
                    {
                        var item = dataGridView.CurrentRow.DataBoundItem as DanhSachSanPham;
                        if (item != null)
                        {
                            var sp = context.SanPham.Find(item.ID);
                            if (sp != null)
                            {
                                sp.HinhAnh = newName;
                                context.SaveChanges();
                                item.HinhAnh = newName; // Cập nhật hiển thị lưới
                                dataGridView.Refresh();
                            }
                        }
                    }
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            xuLyThem = false;
            BatTatChucNang(true);

            // Lấy ID an toàn từ dữ liệu ngầm (Tránh lỗi sai tên cột ID)
            if (dataGridView.CurrentRow != null)
            {
                var item = dataGridView.CurrentRow.DataBoundItem as DanhSachSanPham;
                if (item != null) idHienTai = item.ID;
            }

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 1. Kiểm tra xem có ảnh để xoay không
            if (picHinhAnh.Image == null) return;

            try
            {
                // 2. Xoay ảnh 90 độ theo chiều kim đồng hồ
                Image img = picHinhAnh.Image;
                img.RotateFlip(RotateFlipType.Rotate90FlipNone);
                picHinhAnh.Image = img;
                picHinhAnh.Refresh(); // Cập nhật hiển thị ngay

                // 3. Lưu ảnh đã xoay ra một file mới (để tránh lỗi file đang sử dụng)
                string newName = "rotated_" + Guid.NewGuid().ToString() + ".jpg";

                // Tạo thư mục nếu chưa có
                if (!Directory.Exists(imagesFolder)) Directory.CreateDirectory(imagesFolder);

                string newPath = Path.Combine(imagesFolder, newName);

                // Lưu file ảnh mới xuống ổ cứng
                img.Save(newPath, System.Drawing.Imaging.ImageFormat.Jpeg);

                // 4. Xử lý lưu dữ liệu
                if (xuLyThem)
                {
                    // Nếu đang THÊM MỚI: Chỉ cập nhật biến tạm, chờ bấm nút LƯU mới chốt
                    tenFileAnhTam = newName;
                }
                else
                {
                    // Nếu đang SỬA: Cập nhật luôn vào CSDL (giống nút Đổi Ảnh)
                    if (dataGridView.CurrentRow != null)
                    {
                        var item = dataGridView.CurrentRow.DataBoundItem as DanhSachSanPham;
                        if (item != null)
                        {
                            var sp = context.SanPham.Find(item.ID);
                            if (sp != null)
                            {
                                sp.HinhAnh = newName; // Lưu tên ảnh mới đã xoay
                                context.SaveChanges();

                                // Cập nhật lại tên ảnh trên lưới để hiển thị đúng
                                item.HinhAnh = newName;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xoay ảnh: " + ex.Message);
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
                                SanPham tsp = new SanPham();
                                tsp.TenSanPham = r["TenSanPham"].ToString();
                                context.SanPham.Add(tsp);
                            }
                            context.SaveChanges();
                            MessageBox.Show("Đã nhập thành công " + table.Rows.Count + " dòng.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            FormSanPham_Load(sender, e);
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

        private void btnXuat_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Xuất dữ liệu ra tập tin Excel";
            saveFileDialog.Filter = "Tập tin Excel|*.xls;*.xlsx";
            saveFileDialog.FileName = "SanPham_" + DateTime.Now.ToShortDateString().Replace("/", "_") + ".xlsx";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    DataTable table = new DataTable();
                    table.Columns.AddRange(new DataColumn[2] {
                    new DataColumn("ID", typeof(int)),
                    new DataColumn("TenSanPham", typeof(string))
                    });
                    var SanPham = context.SanPham.ToList();
                    if (SanPham != null)
                    {
                        foreach (var p in SanPham)
                            table.Rows.Add(p.ID, p.TenSanPham);
                    }
                    using (XLWorkbook wb = new XLWorkbook())
                    {
                        var sheet = wb.Worksheets.Add(table, "LoaiSanPham");
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
    }
}