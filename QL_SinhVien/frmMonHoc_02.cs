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
    public partial class frmMonHoc_02 : Form
    {
        DataSet dsMonHoc = new DataSet(); // luu tru du lieu khong ket noi
        SqlDataAdapter daMonHoc = new SqlDataAdapter(); // cap nhat du lieu
        BindingSource bsMonHoc = new BindingSource(); // quan ly du lieu
        bool blnThem = false;

        public frmMonHoc_02()
        {
            InitializeComponent();
        }
        void DieuKhienKhiBinhThuong()
        {
            if (MyPublics.strQuyenSD == "AdminKhoa")
            {
                btnThem.Enabled = true;
                btnChinhSua.Enabled = true;
                btnXoa.Enabled = true;
            }
            else
            {
                btnThem.Enabled = false;
                btnChinhSua.Enabled = false;
                btnXoa.Enabled = false;
            }

            btnLuu.Enabled = false;
            btnKhongLuu.Enabled = false;
            btnDong.Enabled = true;

            txtMaSoMonHoc.ReadOnly = true;
            txtMaSoMonHoc.BackColor = Color.Pink;
            txtTenMonHoc.ReadOnly = true;
            txtTenMonHoc.BackColor = Color.Pink;
            txtSoTC.ReadOnly = true;
            txtSoTC.BackColor = Color.Pink;
        }

        void GanDuLieu()
        {
            txtMaSoMonHoc.DataBindings.Add(new Binding("Text", bsMonHoc, "MSMH"));
            txtTenMonHoc.DataBindings.Add(new Binding("Text", bsMonHoc, "TenMH"));
            txtSoTC.DataBindings.Add(new Binding("Text", bsMonHoc, "SoTC"));
        }

        private void frmMonHoc_02_Load(object sender, EventArgs e)
        {
            string strQuery = "SELECT * FROM MonHoc";
            MyPublics.OpenData(strQuery, dsMonHoc, "MonHoc", daMonHoc);
            bsMonHoc.DataSource = dsMonHoc;
            bsMonHoc.DataMember = "MonHoc";

            txtMaSoMonHoc.MaxLength = 5;
            txtTenMonHoc.MaxLength = 50;

            GanDuLieu();
            dgvMonHoc.DataSource = dsMonHoc;
            dgvMonHoc.DataMember = "MonHoc";

            dgvMonHoc.Width = 550;
            dgvMonHoc.Columns[0].HeaderText = "Mã số môn học";
            dgvMonHoc.Columns[0].Width = 150;

            dgvMonHoc.Columns[1].HeaderText = "Tên môn học";
            dgvMonHoc.Columns[1].Width = 250;

            dgvMonHoc.Columns[2].HeaderText = "Số tín chỉ";
            dgvMonHoc.Columns[2].Width = 90;

            dgvMonHoc.AllowUserToAddRows = false;
            dgvMonHoc.AllowUserToDeleteRows = false;
            dgvMonHoc.EditMode = DataGridViewEditMode.EditProgrammatically;
            DieuKhienKhiBinhThuong();
        }

        private void dgvMonHoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            bsMonHoc.Position = dgvMonHoc.CurrentRow.Index;
        }

        void DieuKhienKhiThem()
        {
            btnThem.Enabled = false;
            btnChinhSua.Enabled = false;
            btnXoa.Enabled = false;
            btnDong.Enabled = false;
            btnLuu.Enabled = true;
            btnKhongLuu.Enabled = true;

            txtMaSoMonHoc.ReadOnly = false;
            txtMaSoMonHoc.BackColor = Color.White;
            txtTenMonHoc.ReadOnly = false;
            txtTenMonHoc.BackColor = Color.White;
            txtSoTC.ReadOnly = false;
            txtSoTC.BackColor = Color.White;
            txtMaSoMonHoc.Clear();
            txtTenMonHoc.Clear();
            txtSoTC.Clear();
            txtMaSoMonHoc.Focus();
        }

        void DieuKhienKhiChinhSua()
        {
            btnThem.Enabled = false;
            btnChinhSua.Enabled = false;
            btnXoa.Enabled = false;
            btnDong.Enabled = false;
            btnLuu.Enabled = true;
            btnKhongLuu.Enabled = true;

            txtMaSoMonHoc.ReadOnly = true;
            txtMaSoMonHoc.BackColor = Color.Pink;
            txtTenMonHoc.ReadOnly = false;
            txtTenMonHoc.BackColor = Color.White;
            txtSoTC.ReadOnly = false;
            txtSoTC.BackColor = Color.White;
            txtTenMonHoc.Focus();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            blnThem = true;
            bsMonHoc.AddNew();
            bsMonHoc.Position = bsMonHoc.Count;
            dgvMonHoc.CurrentCell = dgvMonHoc[0, bsMonHoc.Count - 1];
            DieuKhienKhiThem();
        }

        private void btnChinhSua_Click(object sender, EventArgs e)
        {
            DieuKhienKhiChinhSua();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            int soTC;

            if (txtMaSoMonHoc.Text == "" || txtMaSoMonHoc.Text.Trim().Length == 0)
            {
                MessageBox.Show("Lỗi nhập mã số môn học. Vui lòng nhập lại mã số môn học.", "Lỗi nhập", 
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                txtMaSoMonHoc.Clear();
                txtMaSoMonHoc.Focus();
                return;
            }

            if (txtTenMonHoc.Text == "" || txtTenMonHoc.Text.Trim().Length == 0)
            {
                MessageBox.Show("Lỗi nhập tên môn học. Vui lòng nhập lại tên môn học.", "Lỗi nhập", 
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                txtTenMonHoc.Clear();
                txtTenMonHoc.Focus();
                return;
            }

            if (!int.TryParse(txtSoTC.Text, out soTC) || soTC <= 0)
            {
                MessageBox.Show("Lỗi nhập số tín chỉ. Vui lòng nhập lại số tín chỉ.", "Lỗi nhập", 
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                txtSoTC.Clear();
                txtSoTC.Focus();
                return;
            }

            if ((blnThem) && (MyPublics.TonTaiKhoaChinh(txtMaSoMonHoc.Text, "MSMH", "MonHoc")))
            {
                MessageBox.Show("Mã số môn học này đã tồn tại. Vui lòng nhập lại mã số môn học khác.", "Lỗi", 
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                txtMaSoMonHoc.Clear();
                txtMaSoMonHoc.Focus();
            }
            else
            {
                bsMonHoc.EndEdit();
                daMonHoc.Update(dsMonHoc, "MonHoc");
                dsMonHoc.AcceptChanges();
                blnThem = false;
                DieuKhienKhiBinhThuong();
            }
        }

        private void btnKhongLuu_Click(object sender, EventArgs e)
        {
            bsMonHoc.EndEdit();
            dsMonHoc.RejectChanges();
            blnThem = false;
            DieuKhienKhiBinhThuong();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MyPublics.TonTaiKhoaChinh(txtMaSoMonHoc.Text, "MSMH", "KetQuaHocTap"))
                MessageBox.Show("Môn học này đã có kết quả học tập của sinh viên. Vui lòng xóa kết quả học tập của sinh viên trước khi xóa môn học này.", "Lỗi xóa", 
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            else
            {
                DialogResult btnDongY;
                btnDongY = MessageBox.Show("Bạn chắc chắn muốn xóa. Dữ liệu sau khi xóa sẽ không thể khôi phục.", "Xác nhận xóa", 
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (btnDongY == DialogResult.Yes)
                {
                    bsMonHoc.RemoveCurrent();
                    daMonHoc.Update(dsMonHoc, "MonHoc");
                    dsMonHoc.AcceptChanges();
                }
                DieuKhienKhiBinhThuong();
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            //this.Close();
            Close();
        }


    }
}
