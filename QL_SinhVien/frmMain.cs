using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_SinhVien
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void mnuGioiThieu_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ứng dụng quản lý sinh viên", "Giới thiệu", 
                MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
        }

        private void mnuThoat_Click(object sender, EventArgs e)
        {
            Close();
            //Application.Exit();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            //frmDangNhap fDangNhap = new frmDangNhap(this);
            //fDangNhap.ShowDialog();
        }

        private void mnuDangNhap_Click(object sender, EventArgs e)
        {
            //frmDangNhap fDangNhap = new frmDangNhap(this);
            //fDangNhap.ShowDialog();
        }

        private void mnuLop_Click(object sender, EventArgs e)
        {
            frmLop fLop = new frmLop();
            fLop.ShowDialog();
        }

        private void mnuMonHoc_Click(object sender, EventArgs e)
        {
            //frmMonHoc fMonHoc = new frmMonHoc();
            //fMonHoc.ShowDialog();
        }

        private void mnuLopChuyenNganh02_Click(object sender, EventArgs e)
        {
            //frmLop_02 fLop02 = new frmLop_02();
            //fLop02.ShowDialog();
        }

        private void mnuMonHocChuyenNganh02_Click(object sender, EventArgs e)
        {
            frmMonHoc_02 fMonHoc02 = new frmMonHoc_02();
            fMonHoc02.ShowDialog();
        }

        private void mnuDoiMatKhau_Click(object sender, EventArgs e)
        {
            //frmDoiMatKhau fDoiMatKhau = new frmDoiMatKhau();
            //fDoiMatKhau.ShowDialog();
        }

        private void mnuMonHocChuyenNganh03_Click(object sender, EventArgs e)
        {
            //frmMonHoc_03 fMonHoc03 = new frmMonHoc_03();
            //fMonHoc03.ShowDialog();
        }

        private void mnuLopChuyenNganh03_Click(object sender, EventArgs e)
        {
            //frmLop_03 fLop03 = new frmLop_03();
            //fLop03.ShowDialog();
        }

        private void mnuSinhVien_Click(object sender, EventArgs e)
        {
            //frmSinhVien fSinhVien = new frmSinhVien();
            //fSinhVien.ShowDialog();
        }

        private void mnuSinhVienTheoLop_Click(object sender, EventArgs e)
        {
            //frmSinhVienTheoLop fSinhVienTheoLop = new frmSinhVienTheoLop();
            //fSinhVienTheoLop.ShowDialog();
        }

        

    }
}
