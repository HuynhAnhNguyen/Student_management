namespace QL_SinhVien
{
    partial class frmMain
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
            this.mnuQuanLySinhVien = new System.Windows.Forms.MenuStrip();
            this.mnuDuLieu = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuLop = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuLopChuyenNganh02 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuLopChuyenNganh03 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSinhVien = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMonHoc = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMonHocChuyenNganh02 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMonHocChuyenNganh03 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuSinhVienTheoLop = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCapNhat = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuChonHKNK = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuKetQuaHT = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTienIch = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDangNhap = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDangXuat = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDoiMatKhau = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuGioiThieu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuThoat = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuQuanLySinhVien.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuQuanLySinhVien
            // 
            this.mnuQuanLySinhVien.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuDuLieu,
            this.mnuCapNhat,
            this.mnuTienIch});
            this.mnuQuanLySinhVien.Location = new System.Drawing.Point(0, 0);
            this.mnuQuanLySinhVien.Name = "mnuQuanLySinhVien";
            this.mnuQuanLySinhVien.Size = new System.Drawing.Size(426, 27);
            this.mnuQuanLySinhVien.TabIndex = 1;
            // 
            // mnuDuLieu
            // 
            this.mnuDuLieu.BackColor = System.Drawing.Color.GhostWhite;
            this.mnuDuLieu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuLop,
            this.mnuLopChuyenNganh02,
            this.mnuLopChuyenNganh03,
            this.mnuSinhVien,
            this.mnuMonHoc,
            this.mnuMonHocChuyenNganh02,
            this.mnuMonHocChuyenNganh03,
            this.toolStripMenuItem1,
            this.mnuSinhVienTheoLop});
            this.mnuDuLieu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuDuLieu.ForeColor = System.Drawing.Color.Blue;
            this.mnuDuLieu.Name = "mnuDuLieu";
            this.mnuDuLieu.Size = new System.Drawing.Size(71, 23);
            this.mnuDuLieu.Text = "Dữ liệu";
            // 
            // mnuLop
            // 
            this.mnuLop.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuLop.ForeColor = System.Drawing.Color.OrangeRed;
            this.mnuLop.Name = "mnuLop";
            this.mnuLop.Size = new System.Drawing.Size(252, 24);
            this.mnuLop.Text = "Lớp";
            this.mnuLop.Click += new System.EventHandler(this.mnuLop_Click);
            // 
            // mnuLopChuyenNganh02
            // 
            this.mnuLopChuyenNganh02.ForeColor = System.Drawing.Color.Red;
            this.mnuLopChuyenNganh02.Name = "mnuLopChuyenNganh02";
            this.mnuLopChuyenNganh02.Size = new System.Drawing.Size(252, 24);
            this.mnuLopChuyenNganh02.Text = "Lớp chuyên ngành 02";
            this.mnuLopChuyenNganh02.Click += new System.EventHandler(this.mnuLopChuyenNganh02_Click);
            // 
            // mnuLopChuyenNganh03
            // 
            this.mnuLopChuyenNganh03.ForeColor = System.Drawing.Color.Red;
            this.mnuLopChuyenNganh03.Name = "mnuLopChuyenNganh03";
            this.mnuLopChuyenNganh03.Size = new System.Drawing.Size(252, 24);
            this.mnuLopChuyenNganh03.Text = "Lớp chuyên ngành 03";
            this.mnuLopChuyenNganh03.Click += new System.EventHandler(this.mnuLopChuyenNganh03_Click);
            // 
            // mnuSinhVien
            // 
            this.mnuSinhVien.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuSinhVien.ForeColor = System.Drawing.Color.OrangeRed;
            this.mnuSinhVien.Name = "mnuSinhVien";
            this.mnuSinhVien.Size = new System.Drawing.Size(252, 24);
            this.mnuSinhVien.Text = "Sinh viên";
            this.mnuSinhVien.Click += new System.EventHandler(this.mnuSinhVien_Click);
            // 
            // mnuMonHoc
            // 
            this.mnuMonHoc.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuMonHoc.ForeColor = System.Drawing.Color.OrangeRed;
            this.mnuMonHoc.Name = "mnuMonHoc";
            this.mnuMonHoc.Size = new System.Drawing.Size(252, 24);
            this.mnuMonHoc.Text = "Môn học";
            this.mnuMonHoc.Click += new System.EventHandler(this.mnuMonHoc_Click);
            // 
            // mnuMonHocChuyenNganh02
            // 
            this.mnuMonHocChuyenNganh02.ForeColor = System.Drawing.Color.Red;
            this.mnuMonHocChuyenNganh02.Name = "mnuMonHocChuyenNganh02";
            this.mnuMonHocChuyenNganh02.Size = new System.Drawing.Size(252, 24);
            this.mnuMonHocChuyenNganh02.Text = "Môn học chuyên ngành 02";
            this.mnuMonHocChuyenNganh02.Click += new System.EventHandler(this.mnuMonHocChuyenNganh02_Click);
            // 
            // mnuMonHocChuyenNganh03
            // 
            this.mnuMonHocChuyenNganh03.ForeColor = System.Drawing.Color.Red;
            this.mnuMonHocChuyenNganh03.Name = "mnuMonHocChuyenNganh03";
            this.mnuMonHocChuyenNganh03.Size = new System.Drawing.Size(252, 24);
            this.mnuMonHocChuyenNganh03.Text = "Môn học chuyên ngành 03";
            this.mnuMonHocChuyenNganh03.Click += new System.EventHandler(this.mnuMonHocChuyenNganh03_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(249, 6);
            // 
            // mnuSinhVienTheoLop
            // 
            this.mnuSinhVienTheoLop.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuSinhVienTheoLop.ForeColor = System.Drawing.Color.Gold;
            this.mnuSinhVienTheoLop.Name = "mnuSinhVienTheoLop";
            this.mnuSinhVienTheoLop.Size = new System.Drawing.Size(252, 24);
            this.mnuSinhVienTheoLop.Text = "Sinh viên theo lớp";
            this.mnuSinhVienTheoLop.Click += new System.EventHandler(this.mnuSinhVienTheoLop_Click);
            // 
            // mnuCapNhat
            // 
            this.mnuCapNhat.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuChonHKNK,
            this.toolStripMenuItem2,
            this.mnuKetQuaHT});
            this.mnuCapNhat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuCapNhat.ForeColor = System.Drawing.Color.Blue;
            this.mnuCapNhat.Name = "mnuCapNhat";
            this.mnuCapNhat.Size = new System.Drawing.Size(81, 23);
            this.mnuCapNhat.Text = "Cập nhật";
            // 
            // mnuChonHKNK
            // 
            this.mnuChonHKNK.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuChonHKNK.ForeColor = System.Drawing.Color.OrangeRed;
            this.mnuChonHKNK.Name = "mnuChonHKNK";
            this.mnuChonHKNK.Size = new System.Drawing.Size(183, 24);
            this.mnuChonHKNK.Text = "Chọn học kỳ ";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(180, 6);
            // 
            // mnuKetQuaHT
            // 
            this.mnuKetQuaHT.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuKetQuaHT.ForeColor = System.Drawing.Color.Olive;
            this.mnuKetQuaHT.Name = "mnuKetQuaHT";
            this.mnuKetQuaHT.Size = new System.Drawing.Size(183, 24);
            this.mnuKetQuaHT.Text = "Kết quả học tập";
            // 
            // mnuTienIch
            // 
            this.mnuTienIch.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuDangNhap,
            this.mnuDangXuat,
            this.mnuDoiMatKhau,
            this.toolStripMenuItem3,
            this.mnuGioiThieu,
            this.toolStripMenuItem4,
            this.mnuThoat});
            this.mnuTienIch.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuTienIch.ForeColor = System.Drawing.Color.Blue;
            this.mnuTienIch.Name = "mnuTienIch";
            this.mnuTienIch.Size = new System.Drawing.Size(74, 23);
            this.mnuTienIch.Text = "Tiện ích";
            // 
            // mnuDangNhap
            // 
            this.mnuDangNhap.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuDangNhap.ForeColor = System.Drawing.Color.Lime;
            this.mnuDangNhap.Name = "mnuDangNhap";
            this.mnuDangNhap.Size = new System.Drawing.Size(168, 24);
            this.mnuDangNhap.Text = "Đăng nhập";
            this.mnuDangNhap.Click += new System.EventHandler(this.mnuDangNhap_Click);
            // 
            // mnuDangXuat
            // 
            this.mnuDangXuat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuDangXuat.ForeColor = System.Drawing.Color.Red;
            this.mnuDangXuat.Name = "mnuDangXuat";
            this.mnuDangXuat.Size = new System.Drawing.Size(168, 24);
            this.mnuDangXuat.Text = "Đăng xuất";
            // 
            // mnuDoiMatKhau
            // 
            this.mnuDoiMatKhau.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuDoiMatKhau.ForeColor = System.Drawing.Color.DodgerBlue;
            this.mnuDoiMatKhau.Name = "mnuDoiMatKhau";
            this.mnuDoiMatKhau.Size = new System.Drawing.Size(168, 24);
            this.mnuDoiMatKhau.Text = "Đổi mật khẩu";
            this.mnuDoiMatKhau.Click += new System.EventHandler(this.mnuDoiMatKhau_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(165, 6);
            // 
            // mnuGioiThieu
            // 
            this.mnuGioiThieu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuGioiThieu.ForeColor = System.Drawing.Color.DeepPink;
            this.mnuGioiThieu.Name = "mnuGioiThieu";
            this.mnuGioiThieu.Size = new System.Drawing.Size(168, 24);
            this.mnuGioiThieu.Text = "Giới thiệu";
            this.mnuGioiThieu.Click += new System.EventHandler(this.mnuGioiThieu_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(165, 6);
            // 
            // mnuThoat
            // 
            this.mnuThoat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuThoat.ForeColor = System.Drawing.Color.Red;
            this.mnuThoat.Name = "mnuThoat";
            this.mnuThoat.Size = new System.Drawing.Size(168, 24);
            this.mnuThoat.Text = "Thoát";
            this.mnuThoat.Click += new System.EventHandler(this.mnuThoat_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QL_SinhVien.Properties.Resources.backgroud;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(426, 381);
            this.Controls.Add(this.mnuQuanLySinhVien);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mnuQuanLySinhVien;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý sinh viên";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.mnuQuanLySinhVien.ResumeLayout(false);
            this.mnuQuanLySinhVien.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuQuanLySinhVien;
        public System.Windows.Forms.ToolStripMenuItem mnuDuLieu;
        private System.Windows.Forms.ToolStripMenuItem mnuLop;
        private System.Windows.Forms.ToolStripMenuItem mnuSinhVien;
        private System.Windows.Forms.ToolStripMenuItem mnuMonHoc;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mnuSinhVienTheoLop;
        public System.Windows.Forms.ToolStripMenuItem mnuCapNhat;
        private System.Windows.Forms.ToolStripMenuItem mnuChonHKNK;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem mnuKetQuaHT;
        private System.Windows.Forms.ToolStripMenuItem mnuTienIch;
        public System.Windows.Forms.ToolStripMenuItem mnuDangNhap;
        public System.Windows.Forms.ToolStripMenuItem mnuDangXuat;
        public System.Windows.Forms.ToolStripMenuItem mnuDoiMatKhau;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem mnuGioiThieu;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem mnuThoat;
        private System.Windows.Forms.ToolStripMenuItem mnuLopChuyenNganh02;
        private System.Windows.Forms.ToolStripMenuItem mnuMonHocChuyenNganh02;
        private System.Windows.Forms.ToolStripMenuItem mnuLopChuyenNganh03;
        private System.Windows.Forms.ToolStripMenuItem mnuMonHocChuyenNganh03;
    }
}

