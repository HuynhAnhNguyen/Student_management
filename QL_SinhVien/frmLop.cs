using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_SinhVien
{
    public partial class frmLop : Form
    {
        DataSet dsLop = new DataSet(); // luu tru du lieu khong ket noi
        SqlDataAdapter daLop = new SqlDataAdapter(); // cap nhat du lieu
        BindingSource bsLop = new BindingSource(); // quan ly du lieu
        bool blnThem = false; // trang thai them

        public frmLop()
        {
            InitializeComponent();
        }

        void DieuKhienKhiBinhThuong()
        {
            if (MyPublics.strQuyenSD == "AdminKhoa")
            { // neu quyen sd là admin khoa
                btnThem.Enabled = true;
                btnChinhSua.Enabled = true;
                btnXoa.Enabled = true;
            }
            else
            { // khong phai la admin
                btnThem.Enabled = false;
                btnChinhSua.Enabled = false;
                btnXoa.Enabled = false;
            }
            // cac nut Luu, Khong luu, Dong khong duoc su dung
            btnLuu.Enabled = false; 
            btnKhongLuu.Enabled = false;
            btnDong.Enabled = true;
            // cac textbox MaSoLop, TenLop, KhoaHoc chi doc
            txtMaSoLop.ReadOnly = true;
            txtMaSoLop.BackColor = Color.Pink;
            txtTenLop.ReadOnly = true;
            txtTenLop.BackColor = Color.Pink;
            txtKhoaHoc.ReadOnly = true;
            txtKhoaHoc.BackColor = Color.Pink;
            DieuKhienViTri();
        }

        void GanDuLieu()
        {
            txtMaSoLop.DataBindings.Add(new Binding("Text",bsLop, "MSLop")); 
            txtTenLop.DataBindings.Add(new Binding("Text", bsLop, "TenLop"));
            txtKhoaHoc.DataBindings.Add(new Binding("Text", bsLop, "KhoaHoc"));
        }

        private void frmLop_Load(object sender, EventArgs e)
        {
            string strQuery = "SELECT * FROM Lop"; // cau lenh sql
            MyPublics.OpenData(strQuery, dsLop, "Lop", daLop); // truy xuat du lieu
            bsLop.DataSource = dsLop; 
            bsLop.DataMember = "Lop";
            txtMaSoLop.MaxLength = 8; // gioi han gia tri la 8
            txtTenLop.MaxLength = 40; // gioi han gia tri la 40
            txtViTri.ReadOnly = true;  // txtViTri chi doc
            txtViTri.BackColor = Color.Pink;
            txtViTri.TextAlign = HorizontalAlignment.Center; // can giua
            GanDuLieu();
            DieuKhienKhiBinhThuong();
        }

        void DieuKhienViTri()
        {
            txtViTri.Text= (bsLop.Position +1) + " / "+ bsLop.Count; // gan vi tri hien tai / tong so phan tu
            if (MyPublics.strQuyenSD == "AdminLop") // neu la adminlop
                if (txtMaSoLop.Text == MyPublics.strLop)
                    btnChinhSua.Enabled = true;
                else
                    btnChinhSua.Enabled = false;

            if (bsLop.Position > 0)
            { // neu vi tri hien tai > 0
                btnDau.Enabled = true;
                btnTruoc.Enabled = true;
            }
            else
            {
                btnDau.Enabled = false;
                btnTruoc.Enabled = false;
            }

            if (bsLop.Position < bsLop.Count - 1)
            { // neu vi tri hien tai < tong so phan tu trong du lieu
                btnKe.Enabled = true;
                btnCuoi.Enabled = true;
            }
            else
            {
                btnKe.Enabled = false;
                btnCuoi.Enabled = false;
            }
        }

        private void btnDau_Click(object sender, EventArgs e)
        {
            bsLop.MoveFirst(); // chuyen ve vi tri dau tien
            DieuKhienViTri();
        }

        private void btnTruoc_Click(object sender, EventArgs e)
        {
            bsLop.MovePrevious(); // chuyen ve vi tri truoc do
            DieuKhienViTri();
        }

        private void btnKe_Click(object sender, EventArgs e)
        {
            bsLop.MoveNext(); // chuyen den vi tri tiep theo
            DieuKhienViTri();
        }

        private void btnCuoi_Click(object sender, EventArgs e)
        {
            bsLop.MoveLast(); // chuyen den vi tri cuoi cung
            DieuKhienViTri();
        }

        void DieuKhienKhiThem()
        { // cac logic khi them moi
            btnDau.Enabled = false;
            btnKe.Enabled = false;
            btnTruoc.Enabled = false;
            btnCuoi.Enabled = false;

            btnThem.Enabled = false;
            btnChinhSua.Enabled = false;
            btnLuu.Enabled = true;
            btnKhongLuu.Enabled = true;
            btnXoa.Enabled = false;
            btnDong.Enabled = false;
            // cac textbox duoc phep nhap
            txtMaSoLop.ReadOnly = false;
            txtMaSoLop.BackColor = Color.White;
            txtTenLop.ReadOnly = false;
            txtTenLop.BackColor = Color.White;
            txtKhoaHoc.ReadOnly = false;
            txtKhoaHoc.BackColor = Color.White;

            txtMaSoLop.Clear();
            txtTenLop.Clear();
            txtKhoaHoc.Clear();
            txtViTri.Text = bsLop.Count + " / " + bsLop.Count; // gan lai vi tri
            txtMaSoLop.Focus();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            blnThem = true; // bat trang thai them 
            bsLop.AddNew(); // them phan tu moi vao bsLop
            DieuKhienKhiThem();
        }

        void DieuKhienKhiChinhSua()
        { // cac logic khi chinh sua
            btnDau.Enabled = false;
            btnTruoc.Enabled = false;
            btnKe.Enabled = false;
            btnCuoi.Enabled = false;

            btnThem.Enabled = false;
            btnChinhSua.Enabled = false;
            btnLuu.Enabled = true;
            btnKhongLuu.Enabled = true;
            btnXoa.Enabled = false;
            btnDong.Enabled = false;

            txtMaSoLop.ReadOnly = false;
            txtTenLop.ReadOnly = false;
            txtTenLop.BackColor = Color.White;
            txtKhoaHoc.ReadOnly = false;
            txtKhoaHoc.BackColor = Color.White;
            txtTenLop.Focus();
        }

        private void btnChinhSua_Click(object sender, EventArgs e)
        {
            DieuKhienKhiChinhSua();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            int khoa;
            if (txtMaSoLop.Text == "" || txtMaSoLop.Text.Trim().Length ==0 )
            { // kiem tra ma so lop
                MessageBox.Show("Lỗi nhập mã số lớp. Vui lòng nhập lại mã số lớp.", "Lỗi nhập", 
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                txtMaSoLop.Clear();
                txtMaSoLop.Focus();
                return;
            }

            if (txtTenLop.Text == "" || txtTenLop.Text.Trim().Length == 0)
            {// kiem tra ten lop
                MessageBox.Show("Lỗi nhập tên lớp. Vui lòng nhập lại tên lớp.", "Lỗi nhập", 
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                txtTenLop.Clear();
                txtTenLop.Focus();
                return;
            }

            if (!int.TryParse(txtKhoaHoc.Text, out khoa) || khoa <=0)
            {// kiem tra khoa hoc
                MessageBox.Show("Lỗi nhập khóa học. Vui lòng nhập lại khóa học.", "Lỗi nhập", 
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                txtKhoaHoc.Clear();
                txtKhoaHoc.Focus();
                return;
            }

            if ((blnThem) && (MyPublics.TonTaiKhoaChinh(txtMaSoLop.Text, "MSLop", "Lop")))
            { // kiem tra khoa chinh 
                MessageBox.Show("Mã số lớp này đã tồn tại. Vui lòng nhập mã số lớp khác.", "Lỗi", 
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                txtMaSoLop.Clear();
                txtMaSoLop.Focus();
            }
            else
            {
                bsLop.EndEdit(); // ket thuc chinh sua
                daLop.Update(dsLop, "Lop"); // cap nhat lai daLop
                dsLop.AcceptChanges(); // chap nhan thay doi
                blnThem = false; // chuyen trang thai them = false
                DieuKhienKhiBinhThuong();
            }
        }

        private void btnKhongLuu_Click(object sender, EventArgs e)
        {
            bsLop.EndEdit(); // ket thuc chinh sua
            dsLop.RejectChanges(); // khong chap nhan thay doi
            blnThem = false; // chuyen trang thai them = false
            DieuKhienKhiBinhThuong();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MyPublics.TonTaiKhoaChinh(txtMaSoLop.Text, "MSLop", "SinhVien"))
            {
                MessageBox.Show("Lớp này đã có sinh viên. Vui lòng xóa những sinh viên này trước khi xóa lớp này.", "Lỗi xóa", 
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
            else
            {
                DialogResult btnDongY;
                btnDongY = MessageBox.Show("Bạn chắc chắn muốn xóa. Dữ liệu đã xóa không thể khôi phục.", "Xác nhận xóa", 
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (btnDongY == DialogResult.Yes)
                {
                    bsLop.RemoveCurrent(); // xoa tai vi tri hien tai
                    daLop.Update(dsLop, "Lop"); // cap nhat lai daLop
                    dsLop.AcceptChanges(); // chap nhan thay doi
                }
                DieuKhienKhiBinhThuong();
            }
            
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            Close();
            //this.Close();
        }


    }
}
