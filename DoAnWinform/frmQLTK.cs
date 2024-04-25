using DoAnWinform.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnWinform
{
    public partial class frmQLTK : Form
    {
        public frmQLTK()
        {
            InitializeComponent();
        }
        DBContextModel context = new DBContextModel();

        private void frmQLTK_Load(object sender, EventArgs e)
        {
            dgvDSTK.DefaultCellStyle.BackColor = Color.Aqua;
            this.BackgroundImageLayout = ImageLayout.Stretch;
            this.BackgroundImage = Properties.Resources._1971799;
            var TKNV = context.Login.ToList();
            GridViewTk(TKNV);
            cmbGT.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbChucVu.DropDownStyle = ComboBoxStyle.DropDownList;
            var gt = context.GioiTinh.ToList();
            var cv = context.LoaiTaiKhoan.ToList();
            cmbGT.SelectedIndex = -1;
            cmbChucVu.SelectedIndex = -1;
            FillcmbGT(gt);
            FillcmbCV(cv);
        }

        private void FillcmbCV(List<LoaiTaiKhoan> cv)
        {
            cmbChucVu.DataSource = cv;
            cmbChucVu.DisplayMember = "Ten";
            cmbChucVu.ValueMember = "Ma";
        }

        private void FillcmbGT(List<GioiTinh> gt)
        {
            cmbGT.DataSource = gt;
            cmbGT.DisplayMember = "Ten";
            cmbGT.ValueMember = "Ma";
        }

        private void GridViewTk(List<Login> tKNV)
        {
            dgvDSTK.Rows.Clear();
            foreach (var item in tKNV)
            {
                int index = dgvDSTK.Rows.Add();
                dgvDSTK.Rows[index].Cells[0].Value = item.TenDN;
                dgvDSTK.Rows[index].Cells[1].Value = item.MatKhau;
                dgvDSTK.Rows[index].Cells[2].Value = item.LoaiTaiKhoan1.Ten;
                dgvDSTK.Rows[index].Cells[3].Value = item.TenNV;
                dgvDSTK.Rows[index].Cells[4].Value = item.TuoiNV;
                dgvDSTK.Rows[index].Cells[5].Value = item.GioiTinh.Ten;
                dgvDSTK.Rows[index].Cells[6].Value = item.CCCDNV;
                dgvDSTK.Rows[index].Cells[7].Value = item.NgaySinhNV;

            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUser.Text) || string.IsNullOrEmpty(txtPassword.Text) ||
                string.IsNullOrEmpty(txtTenNV.Text) || string.IsNullOrEmpty(txtTuoiNV.Text) ||
                string.IsNullOrEmpty(txtCCCD.Text) || cmbChucVu.SelectedIndex == -1 || cmbGT.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!!!");
                return;
            }
            if (int.Parse(txtTuoiNV.Text) < 18)
            {
                MessageBox.Show("Nhân viên phải từ 18 tuổi trở lên!!!");
                return;
            }
            var dbLogin = context.Login.FirstOrDefault(p => p.TenDN == txtUser.Text);
            if (dbLogin == null)
            {
                Login login = new Login()
                {
                    TenDN = txtUser.Text,
                    MatKhau = txtPassword.Text,
                    LoaiTaiKhoan = cmbChucVu.SelectedIndex + 1,
                    TenNV = txtTenNV.Text,
                    TuoiNV = txtTuoiNV.Text,
                    GioiTinhNV = cmbGT.SelectedIndex + 1,
                    CCCDNV = txtCCCD.Text,
                    NgaySinhNV = dateNS.Value,
                };
                context.Login.Add(login);
                context.SaveChanges();
                dgvDSTK.Refresh();
                var TKNV = context.Login.ToList();
                GridViewTk(TKNV);

            }
            else
            {
                MessageBox.Show("Tài khoản đã tồn tại!!!");
                return;
            }

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUser.Text) || string.IsNullOrEmpty(txtPassword.Text) ||
                string.IsNullOrEmpty(txtTenNV.Text) || string.IsNullOrEmpty(txtTuoiNV.Text) ||
                string.IsNullOrEmpty(txtCCCD.Text) || cmbChucVu.SelectedIndex == -1 || cmbGT.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!!!");
                return;
            }
            if (int.Parse(txtTuoiNV.Text) < 18)
            {
                MessageBox.Show("Nhân viên phải từ 18 tuổi trở lên!!!");
                return;
            }
            var dbTK = context.Login.FirstOrDefault(p => p.TenDN == txtUser.Text);
            if (dbTK != null)
            {
                dbTK.TenDN = txtUser.Text;
                dbTK.MatKhau = txtPassword.Text;
                dbTK.LoaiTaiKhoan = cmbChucVu.SelectedIndex + 1;
                dbTK.TenNV = txtTenNV.Text;
                dbTK.TuoiNV = txtTuoiNV.Text;
                dbTK.GioiTinhNV = cmbGT.SelectedIndex + 1;
                dbTK.CCCDNV = txtCCCD.Text;
                dbTK.NgaySinhNV = dateNS.Value;
                context.SaveChanges();
                MessageBox.Show("Sửa thành công!!!");
                dgvDSTK.Refresh();
                var TKNV = context.Login.ToList();
                GridViewTk(TKNV);
            }
            else
            {
                MessageBox.Show("Tài khoản không tồn tại!!!");
                return;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            var dbTK = context.Login.FirstOrDefault(p => p.TenDN == txtUser.Text);
            if (dbTK != null)
            {
                context.Login.Remove(dbTK);
                context.SaveChanges();
                MessageBox.Show("Xóa thành công!!!");
                dgvDSTK.Refresh();
                var TKNV = context.Login.ToList();
                GridViewTk(TKNV);
            }
            else
            {
                MessageBox.Show("Tài khoản không tồn tại!!!");
                return;
            }
        }

        private void dgvDSTK_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if(index != -1)
            {
            txtUser.Text = dgvDSTK.Rows[index].Cells[0].Value.ToString();
            txtPassword.Text = dgvDSTK.Rows[index].Cells[1].Value.ToString();
            cmbChucVu.Text = dgvDSTK.Rows[index].Cells[2].Value.ToString();
            txtTenNV.Text = dgvDSTK.Rows[index].Cells[3].Value.ToString();
            txtTuoiNV.Text = dgvDSTK.Rows[index].Cells[4].Value.ToString();
            cmbGT.Text = dgvDSTK.Rows[index].Cells[5].Value.ToString();
            txtCCCD.Text = dgvDSTK.Rows[index].Cells[6].Value.ToString();
            dateNS.Value = Convert.ToDateTime(dgvDSTK.Rows[index].Cells[7].Value.ToString());

            }
            else
            {
                MessageBox.Show("Vui lòng chọn đúng dòng!!!");
                return;
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
