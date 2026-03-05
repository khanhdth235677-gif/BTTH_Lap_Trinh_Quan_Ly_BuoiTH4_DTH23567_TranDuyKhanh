namespace QuanLyBanHang
{
    partial class FormHoaDon
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
            btnLapHoaDon = new Button();
            btnInHoaDon = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnThoat = new Button();
            btnTimKiem = new Button();
            btnXuat = new Button();
            dataGridView = new DataGridView();
            HoVaTenNhanVien = new DataGridViewTextBoxColumn();
            HoVaTenKhachHang = new DataGridViewTextBoxColumn();
            NgayLap = new DataGridViewTextBoxColumn();
            TongTienHoaDon = new DataGridViewTextBoxColumn();
            XemChiTiet = new DataGridViewLinkColumn();
            groupBox1 = new GroupBox();
            btnNhap = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnLapHoaDon
            // 
            btnLapHoaDon.ForeColor = Color.Blue;
            btnLapHoaDon.Location = new Point(120, 365);
            btnLapHoaDon.Name = "btnLapHoaDon";
            btnLapHoaDon.Size = new Size(179, 29);
            btnLapHoaDon.TabIndex = 0;
            btnLapHoaDon.Text = "Lập hóa đơn mới…";
            btnLapHoaDon.UseVisualStyleBackColor = true;
            btnLapHoaDon.Click += btnLapHoaDon_Click;
            // 
            // btnInHoaDon
            // 
            btnInHoaDon.Location = new Point(305, 365);
            btnInHoaDon.Name = "btnInHoaDon";
            btnInHoaDon.Size = new Size(120, 29);
            btnInHoaDon.TabIndex = 1;
            btnInHoaDon.Text = "In hóa đơn…";
            btnInHoaDon.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(431, 365);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(94, 29);
            btnSua.TabIndex = 2;
            btnSua.Text = "Sửa...";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.ForeColor = Color.Red;
            btnXoa.Location = new Point(531, 365);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 29);
            btnXoa.TabIndex = 3;
            btnXoa.Text = "Xóa ";
            btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(631, 365);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(94, 29);
            btnThoat.TabIndex = 4;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Location = new Point(731, 365);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(94, 29);
            btnTimKiem.TabIndex = 5;
            btnTimKiem.Text = "Tìm kiếm...";
            btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // btnXuat
            // 
            btnXuat.Location = new Point(831, 365);
            btnXuat.Name = "btnXuat";
            btnXuat.Size = new Size(94, 29);
            btnXuat.TabIndex = 6;
            btnXuat.Text = "Xuất Excel...";
            btnXuat.UseVisualStyleBackColor = true;
            btnXuat.Click += btnXuat_Click;
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { HoVaTenNhanVien, HoVaTenKhachHang, NgayLap, TongTienHoaDon, XemChiTiet });
            dataGridView.Dock = DockStyle.Fill;
            dataGridView.Location = new Point(3, 23);
            dataGridView.MultiSelect = false;
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersVisible = false;
            dataGridView.RowHeadersWidth = 51;
            dataGridView.Size = new Size(1068, 307);
            dataGridView.TabIndex = 7;
            // 
            // HoVaTenNhanVien
            // 
            HoVaTenNhanVien.DataPropertyName = "HoVaTenNhanVien";
            HoVaTenNhanVien.HeaderText = "Nhân viên";
            HoVaTenNhanVien.MinimumWidth = 6;
            HoVaTenNhanVien.Name = "HoVaTenNhanVien";
            // 
            // HoVaTenKhachHang
            // 
            HoVaTenKhachHang.DataPropertyName = "HoVaTenKhachHang";
            HoVaTenKhachHang.HeaderText = "Khách hàng";
            HoVaTenKhachHang.MinimumWidth = 6;
            HoVaTenKhachHang.Name = "HoVaTenKhachHang";
            // 
            // NgayLap
            // 
            NgayLap.DataPropertyName = "NgayLap";
            NgayLap.HeaderText = "Ngày lập";
            NgayLap.MinimumWidth = 6;
            NgayLap.Name = "NgayLap";
            // 
            // TongTienHoaDon
            // 
            TongTienHoaDon.DataPropertyName = "TongTienHoaDon";
            TongTienHoaDon.HeaderText = "Tổng tiền";
            TongTienHoaDon.MinimumWidth = 6;
            TongTienHoaDon.Name = "TongTienHoaDon";
            // 
            // XemChiTiet
            // 
            XemChiTiet.DataPropertyName = "XemChiTiet";
            XemChiTiet.HeaderText = "Chi tiết";
            XemChiTiet.MinimumWidth = 6;
            XemChiTiet.Name = "XemChiTiet";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dataGridView);
            groupBox1.Location = new Point(14, 17);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1074, 333);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Danh sách hóa đơn ";
            // 
            // btnNhap
            // 
            btnNhap.Location = new Point(931, 365);
            btnNhap.Name = "btnNhap";
            btnNhap.Size = new Size(94, 29);
            btnNhap.TabIndex = 9;
            btnNhap.Text = "Nhập";
            btnNhap.UseVisualStyleBackColor = true;
            btnNhap.Click += btnNhap_Click;
            // 
            // FormHoaDon
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1098, 413);
            Controls.Add(btnNhap);
            Controls.Add(groupBox1);
            Controls.Add(btnXuat);
            Controls.Add(btnTimKiem);
            Controls.Add(btnThoat);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnInHoaDon);
            Controls.Add(btnLapHoaDon);
            Name = "FormHoaDon";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hóa đơn ";
            Load += FormHoaDon_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button btnLapHoaDon;
        private Button btnInHoaDon;
        private Button btnSua;
        private Button btnXoa;
        private Button btnThoat;
        private Button btnTimKiem;
        private Button btnXuat;
        private DataGridView dataGridView;
        private GroupBox groupBox1;
        private DataGridViewTextBoxColumn HoVaTenNhanVien;
        private DataGridViewTextBoxColumn HoVaTenKhachHang;
        private DataGridViewTextBoxColumn NgayLap;
        private DataGridViewTextBoxColumn TongTienHoaDon;
        private DataGridViewLinkColumn XemChiTiet;
        private Button btnNhap;
    }
}