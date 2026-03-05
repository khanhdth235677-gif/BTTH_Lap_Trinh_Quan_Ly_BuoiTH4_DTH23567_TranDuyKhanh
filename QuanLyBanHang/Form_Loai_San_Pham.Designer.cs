namespace QuanLyBanHang
{
    partial class Form_Loai_San_Pham
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtTenLoai = new TextBox();
            btnThem = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            btnLuu = new Button();
            btnHuyBo = new Button();
            btnThoat = new Button();
            groupBox1 = new GroupBox();
            btnXuat = new Button();
            btnNhap = new Button();
            groupBox2 = new GroupBox();
            dataGridView = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            TenLoai = new DataGridViewTextBoxColumn();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 23);
            label1.Name = "label1";
            label1.Size = new Size(156, 20);
            label1.TabIndex = 0;
            label1.Text = "Tên loại sản phẩm (*): ";
            // 
            // txtTenLoai
            // 
            txtTenLoai.Location = new Point(168, 20);
            txtTenLoai.Name = "txtTenLoai";
            txtTenLoai.Size = new Size(590, 27);
            txtTenLoai.TabIndex = 1;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(332, 59);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(66, 29);
            btnThem.TabIndex = 2;
            btnThem.Text = "Thêm ";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnXoa
            // 
            btnXoa.ForeColor = Color.Red;
            btnXoa.Location = new Point(476, 59);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(66, 29);
            btnXoa.TabIndex = 3;
            btnXoa.Text = "Xóa ";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.ForeColor = Color.Black;
            btnSua.Location = new Point(404, 61);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(66, 29);
            btnSua.TabIndex = 4;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnLuu
            // 
            btnLuu.ForeColor = Color.Blue;
            btnLuu.Location = new Point(548, 59);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(66, 29);
            btnLuu.TabIndex = 5;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnHuyBo
            // 
            btnHuyBo.Location = new Point(692, 59);
            btnHuyBo.Name = "btnHuyBo";
            btnHuyBo.Size = new Size(66, 29);
            btnHuyBo.TabIndex = 6;
            btnHuyBo.Text = "Hủy bỏ";
            btnHuyBo.UseVisualStyleBackColor = true;
            btnHuyBo.Click += btnHuyBo_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(620, 59);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(66, 29);
            btnThoat.TabIndex = 7;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnXuat);
            groupBox1.Controls.Add(btnNhap);
            groupBox1.Controls.Add(btnHuyBo);
            groupBox1.Controls.Add(btnThoat);
            groupBox1.Controls.Add(btnSua);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(btnLuu);
            groupBox1.Controls.Add(txtTenLoai);
            groupBox1.Controls.Add(btnThem);
            groupBox1.Controls.Add(btnXoa);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(776, 115);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin loại sản phẩm";
            // 
            // btnXuat
            // 
            btnXuat.Location = new Point(260, 61);
            btnXuat.Name = "btnXuat";
            btnXuat.Size = new Size(66, 29);
            btnXuat.TabIndex = 9;
            btnXuat.Text = "Xuất ";
            btnXuat.UseVisualStyleBackColor = true;
            btnXuat.Click += btnXuat_Click;
            // 
            // btnNhap
            // 
            btnNhap.Location = new Point(188, 61);
            btnNhap.Name = "btnNhap";
            btnNhap.Size = new Size(66, 29);
            btnNhap.TabIndex = 8;
            btnNhap.Text = "Nhập ";
            btnNhap.UseVisualStyleBackColor = true;
            btnNhap.Click += btnNhap_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridView);
            groupBox2.Location = new Point(12, 133);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(776, 305);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách loại sản phẩm ";
            // 
            // dataGridView
            // 
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { ID, TenLoai });
            dataGridView.Location = new Point(6, 35);
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersWidth = 51;
            dataGridView.Size = new Size(752, 242);
            dataGridView.TabIndex = 0;
            // 
            // ID
            // 
            ID.DataPropertyName = "ID";
            ID.HeaderText = "ID";
            ID.MinimumWidth = 6;
            ID.Name = "ID";
            ID.ReadOnly = true;
            ID.Width = 80;
            // 
            // TenLoai
            // 
            TenLoai.DataPropertyName = "TenLoai";
            TenLoai.HeaderText = "Tên loại sản phẩm";
            TenLoai.MinimumWidth = 6;
            TenLoai.Name = "TenLoai";
            TenLoai.Width = 654;
            // 
            // Form_Loai_San_Pham
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form_Loai_San_Pham";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Loại sản phẩm";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private TextBox txtTenLoai;
        private Button btnThem;
        private Button btnXoa;
        private Button btnSua;
        private Button btnLuu;
        private Button btnHuyBo;
        private Button btnThoat;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private DataGridView dataGridView;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn TenLoai;
        private Button btnXuat;
        private Button btnNhap;
    }
}
