namespace QuanLyBanHang
{
    partial class FormNhanVien
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
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            txtDiaChi = new TextBox();
            txtDienThoai = new TextBox();
            label2 = new Label();
            groupBox1 = new GroupBox();
            label6 = new Label();
            cboQuyenHan = new ComboBox();
            txtMatKhau = new TextBox();
            txtTenDangNhap = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            btnXuat = new Button();
            btnNhap = new Button();
            btnHuyBo = new Button();
            label1 = new Label();
            btnTimKiem = new Button();
            txtHoVaTen = new TextBox();
            btnLuu = new Button();
            btnThoat = new Button();
            dataGridView = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            HoVaTen = new DataGridViewTextBoxColumn();
            DienThoai = new DataGridViewTextBoxColumn();
            DiaChi = new DataGridViewTextBoxColumn();
            TenDangNhap = new DataGridViewTextBoxColumn();
            QuyenHan = new DataGridViewTextBoxColumn();
            groupBox2 = new GroupBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // btnXoa
            // 
            btnXoa.ForeColor = Color.Red;
            btnXoa.Location = new Point(497, 109);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(84, 29);
            btnXoa.TabIndex = 14;
            btnXoa.Text = "Xóa ";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(497, 67);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(84, 29);
            btnSua.TabIndex = 13;
            btnSua.Text = "Sửa ";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(497, 26);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(84, 29);
            btnThem.TabIndex = 12;
            btnThem.Text = "Thêm ";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(104, 110);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(115, 27);
            txtDiaChi.TabIndex = 11;
            // 
            // txtDienThoai
            // 
            txtDienThoai.Location = new Point(104, 69);
            txtDienThoai.Name = "txtDienThoai";
            txtDienThoai.Size = new Size(115, 27);
            txtDienThoai.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 69);
            label2.Name = "label2";
            label2.Size = new Size(85, 20);
            label2.TabIndex = 8;
            label2.Text = "Điện thoại: ";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(cboQuyenHan);
            groupBox1.Controls.Add(txtMatKhau);
            groupBox1.Controls.Add(txtTenDangNhap);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(btnXoa);
            groupBox1.Controls.Add(btnSua);
            groupBox1.Controls.Add(btnThem);
            groupBox1.Controls.Add(txtDiaChi);
            groupBox1.Controls.Add(txtDienThoai);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(btnXuat);
            groupBox1.Controls.Add(btnNhap);
            groupBox1.Controls.Add(btnHuyBo);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(btnTimKiem);
            groupBox1.Controls.Add(txtHoVaTen);
            groupBox1.Controls.Add(btnLuu);
            groupBox1.Controls.Add(btnThoat);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(776, 149);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin nhân viên ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(230, 31);
            label6.Name = "label6";
            label6.Size = new Size(130, 20);
            label6.TabIndex = 20;
            label6.Text = "Tên đăng nhập (*):";
            // 
            // cboQuyenHan
            // 
            cboQuyenHan.FormattingEnabled = true;
            cboQuyenHan.Items.AddRange(new object[] { "Quản lý", "Nhân viên" });
            cboQuyenHan.Location = new Point(360, 110);
            cboQuyenHan.Name = "cboQuyenHan";
            cboQuyenHan.Size = new Size(110, 28);
            cboQuyenHan.TabIndex = 19;
            // 
            // txtMatKhau
            // 
            txtMatKhau.Location = new Point(360, 69);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.Size = new Size(110, 27);
            txtMatKhau.TabIndex = 18;
            // 
            // txtTenDangNhap
            // 
            txtTenDangNhap.Location = new Point(360, 28);
            txtTenDangNhap.Name = "txtTenDangNhap";
            txtTenDangNhap.Size = new Size(110, 27);
            txtTenDangNhap.TabIndex = 17;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(230, 113);
            label5.Name = "label5";
            label5.Size = new Size(102, 20);
            label5.TabIndex = 16;
            label5.Text = "Quyền hạn (*):";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(230, 72);
            label4.Name = "label4";
            label4.Size = new Size(93, 20);
            label4.TabIndex = 15;
            label4.Text = "Mật khẩu (*):";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 113);
            label3.Name = "label3";
            label3.Size = new Size(62, 20);
            label3.TabIndex = 9;
            label3.Text = "Địa chỉ: ";
            // 
            // btnXuat
            // 
            btnXuat.Location = new Point(683, 109);
            btnXuat.Name = "btnXuat";
            btnXuat.Size = new Size(84, 29);
            btnXuat.TabIndex = 6;
            btnXuat.Text = "Xuất ...";
            btnXuat.UseVisualStyleBackColor = true;
            btnXuat.Click += btnXuat_Click;
            // 
            // btnNhap
            // 
            btnNhap.Location = new Point(683, 67);
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
            btnHuyBo.Location = new Point(592, 67);
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
            label1.Location = new Point(6, 31);
            label1.Name = "label1";
            label1.Size = new Size(100, 20);
            label1.TabIndex = 0;
            label1.Text = "Họ và tên (*): ";
            // 
            // btnTimKiem
            // 
            btnTimKiem.ForeColor = Color.Black;
            btnTimKiem.Location = new Point(683, 26);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(84, 29);
            btnTimKiem.TabIndex = 5;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // txtHoVaTen
            // 
            txtHoVaTen.Location = new Point(104, 28);
            txtHoVaTen.Name = "txtHoVaTen";
            txtHoVaTen.Size = new Size(115, 27);
            txtHoVaTen.TabIndex = 1;
            // 
            // btnLuu
            // 
            btnLuu.ForeColor = Color.Blue;
            btnLuu.Location = new Point(592, 26);
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
            btnThoat.Location = new Point(592, 109);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(84, 29);
            btnThoat.TabIndex = 3;
            btnThoat.Text = "Thoát ";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.BackgroundColor = Color.White;
            dataGridView.BorderStyle = BorderStyle.Fixed3D;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { ID, HoVaTen, DienThoai, DiaChi, TenDangNhap, QuyenHan });
            dataGridView.Dock = DockStyle.Fill;
            dataGridView.Location = new Point(3, 23);
            dataGridView.MultiSelect = false;
            dataGridView.Name = "dataGridView";
            dataGridView.ReadOnly = true;
            dataGridView.RowHeadersVisible = false;
            dataGridView.RowHeadersWidth = 51;
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView.Size = new Size(770, 245);
            dataGridView.TabIndex = 0;
            dataGridView.CellContentClick += dataGridView_CellContentClick;
            // 
            // ID
            // 
            ID.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            ID.DataPropertyName = "ID";
            ID.FillWeight = 0.5591064F;
            ID.Frozen = true;
            ID.HeaderText = "ID";
            ID.MinimumWidth = 6;
            ID.Name = "ID";
            ID.ReadOnly = true;
            ID.Width = 50;
            // 
            // HoVaTen
            // 
            HoVaTen.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            HoVaTen.DataPropertyName = "HoVaTen";
            HoVaTen.FillWeight = 16.9101982F;
            HoVaTen.Frozen = true;
            HoVaTen.HeaderText = "Họ và tên";
            HoVaTen.MinimumWidth = 6;
            HoVaTen.Name = "HoVaTen";
            HoVaTen.ReadOnly = true;
            HoVaTen.Width = 150;
            // 
            // DienThoai
            // 
            DienThoai.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            DienThoai.DataPropertyName = "DienThoai";
            DienThoai.FillWeight = 21.0333824F;
            DienThoai.Frozen = true;
            DienThoai.HeaderText = "Điện thoại";
            DienThoai.MinimumWidth = 6;
            DienThoai.Name = "DienThoai";
            DienThoai.ReadOnly = true;
            DienThoai.Width = 125;
            // 
            // DiaChi
            // 
            DiaChi.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            DiaChi.DataPropertyName = "DiaChi";
            DiaChi.FillWeight = 361.497284F;
            DiaChi.Frozen = true;
            DiaChi.HeaderText = "Địa chỉ";
            DiaChi.MinimumWidth = 6;
            DiaChi.Name = "DiaChi";
            DiaChi.ReadOnly = true;
            DiaChi.Width = 200;
            // 
            // TenDangNhap
            // 
            TenDangNhap.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            TenDangNhap.DataPropertyName = "TenDangNhap";
            TenDangNhap.Frozen = true;
            TenDangNhap.HeaderText = "Tên đăng nhập";
            TenDangNhap.MinimumWidth = 6;
            TenDangNhap.Name = "TenDangNhap";
            TenDangNhap.ReadOnly = true;
            TenDangNhap.Width = 150;
            // 
            // QuyenHan
            // 
            QuyenHan.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            QuyenHan.DataPropertyName = "QuyenHan";
            QuyenHan.Frozen = true;
            QuyenHan.HeaderText = "Quyền hạn";
            QuyenHan.MinimumWidth = 6;
            QuyenHan.Name = "QuyenHan";
            QuyenHan.ReadOnly = true;
            QuyenHan.Width = 120;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridView);
            groupBox2.Location = new Point(12, 167);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(776, 271);
            groupBox2.TabIndex = 11;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách nhân viên";
            // 
            // FormNhanVien
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            Name = "FormNhanVien";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Nhân viên ";
            Load += FormNhanVien_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
        private TextBox txtDiaChi;
        private TextBox txtDienThoai;
        private Label label2;
        private GroupBox groupBox1;
        private Label label6;
        private ComboBox cboQuyenHan;
        private TextBox txtMatKhau;
        private TextBox txtTenDangNhap;
        private Label label5;
        private Label label4;
        private Label label3;
        private Button btnXuat;
        private Button btnNhap;
        private Button btnHuyBo;
        private Label label1;
        private Button btnTimKiem;
        private TextBox txtHoVaTen;
        private Button btnLuu;
        private Button btnThoat;
        private DataGridView dataGridView;
        private GroupBox groupBox2;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn HoVaTen;
        private DataGridViewTextBoxColumn DienThoai;
        private DataGridViewTextBoxColumn DiaChi;
        private DataGridViewTextBoxColumn TenDangNhap;
        private DataGridViewTextBoxColumn QuyenHan;
    }
}