namespace QLSanPham
{
    partial class frmSanPham
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
            txtTenSP = new TextBox();
            txtMaSP = new TextBox();
            txtDonGia = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            numSoLuong = new NumericUpDown();
            dtpNgayNhap = new DateTimePicker();
            label4 = new Label();
            label5 = new Label();
            cboLoai = new ComboBox();
            label6 = new Label();
            grbTrangThai = new GroupBox();
            radHetHang = new RadioButton();
            radConHang = new RadioButton();
            dgvSanPham = new DataGridView();
            btnThem = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            btnLuu = new Button();
            btnHuy = new Button();
            btnThoat = new Button();
            ((System.ComponentModel.ISupportInitialize)numSoLuong).BeginInit();
            grbTrangThai.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSanPham).BeginInit();
            SuspendLayout();
            // 
            // txtTenSP
            // 
            txtTenSP.Location = new Point(125, 100);
            txtTenSP.Name = "txtTenSP";
            txtTenSP.Size = new Size(125, 27);
            txtTenSP.TabIndex = 0;
            // 
            // txtMaSP
            // 
            txtMaSP.Location = new Point(125, 53);
            txtMaSP.Name = "txtMaSP";
            txtMaSP.Size = new Size(125, 27);
            txtMaSP.TabIndex = 1;
            // 
            // txtDonGia
            // 
            txtDonGia.Location = new Point(125, 149);
            txtDonGia.Name = "txtDonGia";
            txtDonGia.Size = new Size(125, 27);
            txtDonGia.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 53);
            label1.Name = "label1";
            label1.Size = new Size(98, 20);
            label1.TabIndex = 3;
            label1.Text = "Mã sản phẩm";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 107);
            label2.Name = "label2";
            label2.Size = new Size(98, 20);
            label2.TabIndex = 4;
            label2.Text = "tên sản phẩm";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(13, 152);
            label3.Name = "label3";
            label3.Size = new Size(60, 20);
            label3.TabIndex = 5;
            label3.Text = "đơn giá";
            // 
            // numSoLuong
            // 
            numSoLuong.Location = new Point(426, 51);
            numSoLuong.Name = "numSoLuong";
            numSoLuong.Size = new Size(150, 27);
            numSoLuong.TabIndex = 6;
            // 
            // dtpNgayNhap
            // 
            dtpNgayNhap.Format = DateTimePickerFormat.Short;
            dtpNgayNhap.Location = new Point(426, 98);
            dtpNgayNhap.Name = "dtpNgayNhap";
            dtpNgayNhap.Size = new Size(150, 27);
            dtpNgayNhap.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(307, 60);
            label4.Name = "label4";
            label4.Size = new Size(67, 20);
            label4.TabIndex = 8;
            label4.Text = "số lượng";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(307, 103);
            label5.Name = "label5";
            label5.Size = new Size(84, 20);
            label5.TabIndex = 9;
            label5.Text = "Ngày Nhập";
            // 
            // cboLoai
            // 
            cboLoai.DropDownStyle = ComboBoxStyle.DropDownList;
            cboLoai.FormattingEnabled = true;
            cboLoai.Location = new Point(425, 145);
            cboLoai.Name = "cboLoai";
            cboLoai.Size = new Size(151, 28);
            cboLoai.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(307, 152);
            label6.Name = "label6";
            label6.Size = new Size(37, 20);
            label6.TabIndex = 11;
            label6.Text = "Loại";
            // 
            // grbTrangThai
            // 
            grbTrangThai.Controls.Add(radHetHang);
            grbTrangThai.Controls.Add(radConHang);
            grbTrangThai.Location = new Point(595, 51);
            grbTrangThai.Name = "grbTrangThai";
            grbTrangThai.Size = new Size(98, 125);
            grbTrangThai.TabIndex = 12;
            grbTrangThai.TabStop = false;
            grbTrangThai.Text = "Trạng thái";
            grbTrangThai.UseCompatibleTextRendering = true;
            // 
            // radHetHang
            // 
            radHetHang.AutoSize = true;
            radHetHang.Location = new Point(3, 69);
            radHetHang.Name = "radHetHang";
            radHetHang.Size = new Size(91, 24);
            radHetHang.TabIndex = 1;
            radHetHang.TabStop = true;
            radHetHang.Text = "Hết hàng";
            radHetHang.UseVisualStyleBackColor = true;
            // 
            // radConHang
            // 
            radConHang.AutoSize = true;
            radConHang.Location = new Point(3, 23);
            radConHang.Name = "radConHang";
            radConHang.Size = new Size(93, 24);
            radConHang.TabIndex = 0;
            radConHang.TabStop = true;
            radConHang.Text = "Còn hàng";
            radConHang.UseVisualStyleBackColor = true;
            // 
            // dgvSanPham
            // 
            dgvSanPham.AllowUserToAddRows = false;
            dgvSanPham.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSanPham.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSanPham.Location = new Point(0, 182);
            dgvSanPham.Name = "dgvSanPham";
            dgvSanPham.ReadOnly = true;
            dgvSanPham.RowHeadersWidth = 51;
            dgvSanPham.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSanPham.Size = new Size(994, 265);
            dgvSanPham.TabIndex = 13;
            dgvSanPham.CellClick += dgvSanPham_CellClick;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(736, 56);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 29);
            btnThem.TabIndex = 2;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(736, 96);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 29);
            btnXoa.TabIndex = 14;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(736, 143);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(94, 29);
            btnSua.TabIndex = 15;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnLuu
            // 
            btnLuu.Location = new Point(858, 53);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(94, 29);
            btnLuu.TabIndex = 16;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnHuy
            // 
            btnHuy.Location = new Point(858, 96);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(94, 29);
            btnHuy.TabIndex = 17;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = true;
            btnHuy.Click += btnHuy_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(858, 143);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(94, 29);
            btnThoat.TabIndex = 18;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // frmSanPham
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(994, 450);
            Controls.Add(btnThoat);
            Controls.Add(btnHuy);
            Controls.Add(btnLuu);
            Controls.Add(btnSua);
            Controls.Add(btnXoa);
            Controls.Add(btnThem);
            Controls.Add(dgvSanPham);
            Controls.Add(grbTrangThai);
            Controls.Add(label6);
            Controls.Add(cboLoai);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(dtpNgayNhap);
            Controls.Add(numSoLuong);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtDonGia);
            Controls.Add(txtMaSP);
            Controls.Add(txtTenSP);
            Name = "frmSanPham";
            Text = "Form1";
            Load += frmSanPham_Load;
            ((System.ComponentModel.ISupportInitialize)numSoLuong).EndInit();
            grbTrangThai.ResumeLayout(false);
            grbTrangThai.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSanPham).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTenSP;
        private TextBox txtMaSP;
        private TextBox txtDonGia;
        private Label label1;
        private Label label2;
        private Label label3;
        private NumericUpDown numSoLuong;
        private DateTimePicker dtpNgayNhap;
        private Label label4;
        private Label label5;
        private ComboBox cboLoai;
        private Label label6;
        private GroupBox grbTrangThai;
        private RadioButton radHetHang;
        private RadioButton radConHang;
        private DataGridView dgvSanPham;
        private Button btnThem;
        private Button btnXoa;
        private Button btnSua;
        private Button btnLuu;
        private Button btnHuy;
        private Button btnThoat;
    }
}
