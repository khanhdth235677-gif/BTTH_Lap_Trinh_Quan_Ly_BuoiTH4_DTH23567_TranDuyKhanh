namespace QuanLyBanHang
{
    partial class FormSanPham
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            btnDoiAnh = new Button();
            picHinhAnh = new PictureBox();
            numDonGia = new NumericUpDown();
            numSoLuong = new NumericUpDown();
            cboLoaiSanPham = new ComboBox();
            cboHangSanXuat = new ComboBox();
            label6 = new Label();
            txtMoTa = new TextBox();
            label5 = new Label();
            label4 = new Label();
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            txtTenSanPham = new TextBox();
            label3 = new Label();
            label2 = new Label();
            btnXuat = new Button();
            btnNhap = new Button();
            btnHuyBo = new Button();
            label1 = new Label();
            btnTimKiem = new Button();
            btnLuu = new Button();
            btnThoat = new Button();
            groupBox2 = new GroupBox();
            dataGridView = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            TenLoai = new DataGridViewTextBoxColumn();
            TenHangSanXuat = new DataGridViewTextBoxColumn();
            TenSanPham = new DataGridViewTextBoxColumn();
            SoLuong = new DataGridViewTextBoxColumn();
            DonGia = new DataGridViewTextBoxColumn();
            HinhAnh = new DataGridViewImageColumn();
            XoayHinhAnh = new GroupBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)picHinhAnh).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numDonGia).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numSoLuong).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            XoayHinhAnh.SuspendLayout();
            SuspendLayout();
            // 
            // btnDoiAnh
            // 
            btnDoiAnh.Location = new Point(985, 32);
            btnDoiAnh.Name = "btnDoiAnh";
            btnDoiAnh.Size = new Size(94, 29);
            btnDoiAnh.TabIndex = 26;
            btnDoiAnh.Text = "Đổi ảnh";
            btnDoiAnh.UseVisualStyleBackColor = true;
            btnDoiAnh.Click += btnDoiAnh_Click;
            // 
            // picHinhAnh
            // 
            picHinhAnh.Location = new Point(722, 32);
            picHinhAnh.Name = "picHinhAnh";
            picHinhAnh.Size = new Size(238, 140);
            picHinhAnh.SizeMode = PictureBoxSizeMode.StretchImage;
            picHinhAnh.TabIndex = 25;
            picHinhAnh.TabStop = false;
            // 
            // numDonGia
            // 
            numDonGia.Location = new Point(497, 76);
            numDonGia.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            numDonGia.Name = "numDonGia";
            numDonGia.Size = new Size(150, 27);
            numDonGia.TabIndex = 24;
            numDonGia.ThousandsSeparator = true;
            // 
            // numSoLuong
            // 
            numSoLuong.Location = new Point(497, 38);
            numSoLuong.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numSoLuong.Name = "numSoLuong";
            numSoLuong.Size = new Size(150, 27);
            numSoLuong.TabIndex = 23;
            numSoLuong.ThousandsSeparator = true;
            // 
            // cboLoaiSanPham
            // 
            cboLoaiSanPham.FormattingEnabled = true;
            cboLoaiSanPham.Location = new Point(156, 37);
            cboLoaiSanPham.Name = "cboLoaiSanPham";
            cboLoaiSanPham.Size = new Size(180, 28);
            cboLoaiSanPham.TabIndex = 22;
            // 
            // cboHangSanXuat
            // 
            cboHangSanXuat.FormattingEnabled = true;
            cboHangSanXuat.Location = new Point(156, 75);
            cboHangSanXuat.Name = "cboHangSanXuat";
            cboHangSanXuat.Size = new Size(180, 28);
            cboHangSanXuat.TabIndex = 21;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(20, 152);
            label6.Name = "label6";
            label6.Size = new Size(119, 20);
            label6.TabIndex = 20;
            label6.Text = "Mô tả sản phẩm:";
            // 
            // txtMoTa
            // 
            txtMoTa.Location = new Point(156, 145);
            txtMoTa.Name = "txtMoTa";
            txtMoTa.Size = new Size(491, 27);
            txtMoTa.TabIndex = 17;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(384, 83);
            label5.Name = "label5";
            label5.Size = new Size(85, 20);
            label5.TabIndex = 16;
            label5.Text = "Đơn giá (*):";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(384, 45);
            label4.Name = "label4";
            label4.Size = new Size(92, 20);
            label4.TabIndex = 15;
            label4.Text = "Số lượng (*):";
            // 
            // btnXoa
            // 
            btnXoa.ForeColor = Color.Red;
            btnXoa.Location = new Point(352, 185);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(84, 29);
            btnXoa.TabIndex = 14;
            btnXoa.Text = "Xóa ";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(252, 185);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(84, 29);
            btnSua.TabIndex = 13;
            btnSua.Text = "Sửa ";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(156, 183);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(84, 29);
            btnThem.TabIndex = 12;
            btnThem.Text = "Thêm ";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // txtTenSanPham
            // 
            txtTenSanPham.Location = new Point(156, 112);
            txtTenSanPham.Name = "txtTenSanPham";
            txtTenSanPham.Size = new Size(180, 27);
            txtTenSanPham.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 119);
            label3.Name = "label3";
            label3.Size = new Size(127, 20);
            label3.TabIndex = 9;
            label3.Text = "Tên sản phẩm (*): ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 83);
            label2.Name = "label2";
            label2.Size = new Size(130, 20);
            label2.TabIndex = 8;
            label2.Text = "Hãng sản xuất (*): ";
            // 
            // btnXuat
            // 
            btnXuat.Location = new Point(995, 183);
            btnXuat.Name = "btnXuat";
            btnXuat.Size = new Size(84, 29);
            btnXuat.TabIndex = 6;
            btnXuat.Text = "Xuất ...";
            btnXuat.UseVisualStyleBackColor = true;
            btnXuat.Click += btnXuat_Click;
            // 
            // btnNhap
            // 
            btnNhap.Location = new Point(891, 183);
            btnNhap.Name = "btnNhap";
            btnNhap.Size = new Size(84, 29);
            btnNhap.TabIndex = 7;
            btnNhap.Text = "Nhập ...";
            btnNhap.UseVisualStyleBackColor = true;
            btnNhap.Click += btnNhap_Click;
            // 
            // btnHuyBo
            // 
            btnHuyBo.ForeColor = Color.Black;
            btnHuyBo.Location = new Point(563, 183);
            btnHuyBo.Name = "btnHuyBo";
            btnHuyBo.Size = new Size(84, 29);
            btnHuyBo.TabIndex = 4;
            btnHuyBo.Text = "Hủy bỏ ";
            btnHuyBo.UseVisualStyleBackColor = true;
            btnHuyBo.Click += btnHuyBo_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 45);
            label1.Name = "label1";
            label1.Size = new Size(97, 20);
            label1.TabIndex = 0;
            label1.Text = "Phân loại (*): ";
            // 
            // btnTimKiem
            // 
            btnTimKiem.ForeColor = Color.Black;
            btnTimKiem.Location = new Point(784, 183);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(84, 29);
            btnTimKiem.TabIndex = 5;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // btnLuu
            // 
            btnLuu.ForeColor = Color.Blue;
            btnLuu.Location = new Point(457, 183);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(84, 29);
            btnLuu.TabIndex = 2;
            btnLuu.Text = "Lưu ";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnThoat
            // 
            btnThoat.ForeColor = Color.Black;
            btnThoat.Location = new Point(674, 183);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(84, 29);
            btnThoat.TabIndex = 3;
            btnThoat.Text = "Thoát ";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridView);
            groupBox2.Location = new Point(13, 270);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1092, 308);
            groupBox2.TabIndex = 15;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách sản phẩm ";
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.BackgroundColor = Color.White;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { ID, TenLoai, TenHangSanXuat, TenSanPham, SoLuong, DonGia, HinhAnh });
            dataGridView.Location = new Point(20, 26);
            dataGridView.MultiSelect = false;
            dataGridView.Name = "dataGridView";
            dataGridView.ReadOnly = true;
            dataGridView.RowHeadersVisible = false;
            dataGridView.RowHeadersWidth = 51;
            dataGridView.RowTemplate.Height = 60;
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView.Size = new Size(1059, 255);
            dataGridView.TabIndex = 0;
            // 
            // ID
            // 
            ID.DataPropertyName = "ID";
            ID.FillWeight = 112.923355F;
            ID.HeaderText = "ID";
            ID.MinimumWidth = 100;
            ID.Name = "ID";
            ID.ReadOnly = true;
            // 
            // TenLoai
            // 
            TenLoai.DataPropertyName = "TenLoai";
            TenLoai.FillWeight = 112.923355F;
            TenLoai.HeaderText = "Phân loại";
            TenLoai.MinimumWidth = 6;
            TenLoai.Name = "TenLoai";
            TenLoai.ReadOnly = true;
            // 
            // TenHangSanXuat
            // 
            TenHangSanXuat.DataPropertyName = "TenHangSanXuat";
            TenHangSanXuat.FillWeight = 112.923355F;
            TenHangSanXuat.HeaderText = "Hãng sản xuất";
            TenHangSanXuat.MinimumWidth = 6;
            TenHangSanXuat.Name = "TenHangSanXuat";
            TenHangSanXuat.ReadOnly = true;
            // 
            // TenSanPham
            // 
            TenSanPham.DataPropertyName = "TenSanPham";
            TenSanPham.FillWeight = 112.923355F;
            TenSanPham.HeaderText = "Tên sản phẩm";
            TenSanPham.MinimumWidth = 6;
            TenSanPham.Name = "TenSanPham";
            TenSanPham.ReadOnly = true;
            // 
            // SoLuong
            // 
            SoLuong.DataPropertyName = "SoLuong";
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.Format = "N0";
            SoLuong.DefaultCellStyle = dataGridViewCellStyle1;
            SoLuong.FillWeight = 112.923355F;
            SoLuong.HeaderText = "Số lượng";
            SoLuong.MinimumWidth = 6;
            SoLuong.Name = "SoLuong";
            SoLuong.ReadOnly = true;
            // 
            // DonGia
            // 
            DonGia.DataPropertyName = "DonGia";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "N0";
            DonGia.DefaultCellStyle = dataGridViewCellStyle2;
            DonGia.FillWeight = 112.923355F;
            DonGia.HeaderText = "Đơn giá";
            DonGia.MinimumWidth = 6;
            DonGia.Name = "DonGia";
            DonGia.ReadOnly = true;
            // 
            // HinhAnh
            // 
            HinhAnh.FillWeight = 22.4598923F;
            HinhAnh.HeaderText = "Hình ảnh";
            HinhAnh.ImageLayout = DataGridViewImageCellLayout.Zoom;
            HinhAnh.MinimumWidth = 100;
            HinhAnh.Name = "HinhAnh";
            HinhAnh.ReadOnly = true;
            HinhAnh.Resizable = DataGridViewTriState.False;
            // 
            // XoayHinhAnh
            // 
            XoayHinhAnh.Controls.Add(button1);
            XoayHinhAnh.Controls.Add(btnDoiAnh);
            XoayHinhAnh.Controls.Add(picHinhAnh);
            XoayHinhAnh.Controls.Add(numDonGia);
            XoayHinhAnh.Controls.Add(numSoLuong);
            XoayHinhAnh.Controls.Add(cboLoaiSanPham);
            XoayHinhAnh.Controls.Add(cboHangSanXuat);
            XoayHinhAnh.Controls.Add(label6);
            XoayHinhAnh.Controls.Add(txtMoTa);
            XoayHinhAnh.Controls.Add(label5);
            XoayHinhAnh.Controls.Add(label4);
            XoayHinhAnh.Controls.Add(btnXoa);
            XoayHinhAnh.Controls.Add(btnSua);
            XoayHinhAnh.Controls.Add(btnThem);
            XoayHinhAnh.Controls.Add(txtTenSanPham);
            XoayHinhAnh.Controls.Add(label3);
            XoayHinhAnh.Controls.Add(label2);
            XoayHinhAnh.Controls.Add(btnXuat);
            XoayHinhAnh.Controls.Add(btnNhap);
            XoayHinhAnh.Controls.Add(btnHuyBo);
            XoayHinhAnh.Controls.Add(label1);
            XoayHinhAnh.Controls.Add(btnTimKiem);
            XoayHinhAnh.Controls.Add(btnLuu);
            XoayHinhAnh.Controls.Add(btnThoat);
            XoayHinhAnh.Location = new Point(13, 8);
            XoayHinhAnh.Name = "XoayHinhAnh";
            XoayHinhAnh.Size = new Size(1092, 238);
            XoayHinhAnh.TabIndex = 16;
            XoayHinhAnh.TabStop = false;
            XoayHinhAnh.Text = "Thông tin sản phẩm  ";
            // 
            // button1
            // 
            button1.Location = new Point(966, 67);
            button1.Name = "button1";
            button1.Size = new Size(120, 29);
            button1.TabIndex = 27;
            button1.Text = "Xoay hình ảnh";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // FormSanPham
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1117, 617);
            Controls.Add(groupBox2);
            Controls.Add(XoayHinhAnh);
            Name = "FormSanPham";
            Text = "FormSanPham";
            Load += FormSanPham_Load;
            ((System.ComponentModel.ISupportInitialize)picHinhAnh).EndInit();
            ((System.ComponentModel.ISupportInitialize)numDonGia).EndInit();
            ((System.ComponentModel.ISupportInitialize)numSoLuong).EndInit();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            XoayHinhAnh.ResumeLayout(false);
            XoayHinhAnh.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnDoiAnh;
        private PictureBox picHinhAnh;
        private NumericUpDown numDonGia;
        private NumericUpDown numSoLuong;
        private ComboBox cboLoaiSanPham;
        private ComboBox cboHangSanXuat;
        private Label label6;
        private TextBox txtMoTa;
        private Label label5;
        private Label label4;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
        private TextBox txtTenSanPham;
        private Label label3;
        private Label label2;
        private Button btnXuat;
        private Button btnNhap;
        private Button btnHuyBo;
        private Label label1;
        private Button btnTimKiem;
        private Button btnLuu;
        private Button btnThoat;
        private GroupBox groupBox2;
        private GroupBox XoayHinhAnh;
        private DataGridView dataGridView;
        private Button button1;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn TenLoai;
        private DataGridViewTextBoxColumn TenHangSanXuat;
        private DataGridViewTextBoxColumn TenSanPham;
        private DataGridViewTextBoxColumn SoLuong;
        private DataGridViewTextBoxColumn DonGia;
        private DataGridViewImageColumn HinhAnh;
    }
}