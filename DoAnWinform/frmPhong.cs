using DoAnWinform.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnWinform
{
    public partial class frmPhong : Form
    {
        public frmPhong()
        {
            InitializeComponent();
            timer1.Start();
        }
        DBContextModel context = new DBContextModel();
        private void frmPhong_Load(object sender, EventArgs e)
        {
            this.BackgroundImageLayout = ImageLayout.Stretch;
            this.BackgroundImage = Properties.Resources._1971799;
            List<ThongTinPhong> thongTinPhong = context.ThongTinPhong.ToList();
            loadForm(thongTinPhong);
            ChucVutxt.Enabled = false;
            dgvTTPhong.DefaultCellStyle.BackColor = Color.IndianRed;
            CheckTTP(thongTinPhong);
            ChucVutxt.ForeColor = Color.Yellow;
            if(Const.login.LoaiTaiKhoan == 1)
            {   // Chức vụ : Giám đốc
                ChucVutxt.Text = Const.login.LoaiTaiKhoan1.Ten;
            }else
            if (Const.login.LoaiTaiKhoan == 2)
            {   // Chức vụ : Quản Lý
                ChucVutxt.Text = Const.login.LoaiTaiKhoan1.Ten;
                tstQLTKNV.Enabled = false;
            } else
            {   // Chức vụ : Nhân Viên
                ChucVutxt.Text = Const.login.LoaiTaiKhoan1.Ten;
                tstQLTKNV.Enabled = false;
                tstAdd.Enabled = false;
                tstUAD.Enabled = false;
            }
        }

        private void CheckTTP(List<ThongTinPhong> thongTinPhong)
        {
            for (int i = 0; i <thongTinPhong.Count; i++)
            {
                if (thongTinPhong[i].TrangThai == 1)
                {
                    dgvTTPhong.Rows[i].DefaultCellStyle.BackColor = Color.Yellow;
                }
            }
        }

        private void loadForm(List<ThongTinPhong> thongTinPhong)
        {
            dgvTTPhong.Rows.Clear();
            foreach (var item in thongTinPhong)
            {
                int index = dgvTTPhong.Rows.Add();
                dgvTTPhong.Rows[index].Cells[0].Value = item.MaPhong;
                dgvTTPhong.Rows[index].Cells[1].Value = item.LoaiPhong1.Ten;
                dgvTTPhong.Rows[index].Cells[2].Value = item.SoGiuong;
                dgvTTPhong.Rows[index].Cells[3].Value = item.TrangThai1.Ten;
                dgvTTPhong.Rows[index].Cells[4].Value = item.TienNgay;
                dgvTTPhong.Rows[index].Cells[5].Value = item.TienGio;
            }
        }


        private void dgvTTPhong_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            List<ThongTinPhong> thongTinPhong = context.ThongTinPhong.ToList();
            if (dgvTTPhong.Rows[e.RowIndex].Cells[3].Value.ToString() == "Còn")
                {
            int maPhong = int.Parse(dgvTTPhong.Rows[e.RowIndex].Cells[0].Value.ToString());
            DialogResult dialog = MessageBox.Show("Chuyển hướng đặt phòng", "Thông Báo",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                LuuThongTinQuaBooking.maPhong = maPhong;
                      this.Hide();
                      frmBooking frm = new frmBooking();
                      frm.ShowDialog();
                      frm.Close();
                      dgvTTPhong.Refresh();
                      frmPhong frmP = new frmPhong(); 
                      frmP.ShowDialog();
            } else
            {
                return;
            }

                }
            else
            {
                MessageBox.Show("Phòng đã được đặt");
                return;
            }
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            txtTimer.Text = DateTime.Now.ToString("G");
        }

        private void tstAdd_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmCreateRoom frm = new frmCreateRoom();
            frm.ShowDialog();
            frm.Close();
            dgvTTPhong.Refresh();
            frmPhong frmP = new frmPhong();
            frmP.ShowDialog();

        }

        private void tstUAD_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmUpdateDelete frm = new frmUpdateDelete();
            frm.ShowDialog();
            frm.Close();
            dgvTTPhong.Refresh();
            frmPhong frmP = new frmPhong();
            frmP.ShowDialog();
        }

        private void tstDSKH_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmDanhSachBooking frm = new frmDanhSachBooking();
            frm.ShowDialog();
            frm.Close();
            dgvTTPhong.Refresh();
            frmPhong frmP = new frmPhong();
            frmP.ShowDialog();
        }

        private void tstLSKH_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLichSuKH frm = new frmLichSuKH();
            frm.ShowDialog();
            frm.Close();
            dgvTTPhong.Refresh();
            frmPhong frmP = new frmPhong();
            frmP.ShowDialog();
        }

        private void tstQLTKNV_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmQLTK frm = new frmQLTK();
            frm.ShowDialog();
            frm.Close();
            dgvTTPhong.Refresh();
            frmPhong frmP = new frmPhong();
            frmP.ShowDialog();

        }

        private void txtSearchSG_TextChanged_1(object sender, EventArgs e)
        {
            bool kt = true;
            bool kt2 = true;
            var phong = context.ThongTinPhong.ToList();
            dgvTTPhong.Rows.Clear();
            foreach (var item in phong)
            {
                try
                {
                    if (txtSearchSG.Text != "" && txtSearchSG.Text != null)
                    {
                        int soGiuong = int.Parse(txtSearchSG.Text);
                        if (item.SoGiuong == soGiuong)
                        {
                            int index = dgvTTPhong.Rows.Add();
                            dgvTTPhong.Rows[index].Cells[0].Value = item.MaPhong;
                            dgvTTPhong.Rows[index].Cells[1].Value = item.LoaiPhong1.Ten;
                            dgvTTPhong.Rows[index].Cells[2].Value = item.SoGiuong;
                            dgvTTPhong.Rows[index].Cells[3].Value = item.TrangThai1.Ten;
                            dgvTTPhong.Rows[index].Cells[4].Value = item.TienNgay;
                            dgvTTPhong.Rows[index].Cells[5].Value = item.TienGio;
                            if (item.TrangThai == 1)
                            {
                                dgvTTPhong.Rows[index].DefaultCellStyle.BackColor = Color.Yellow;
                            }
                            kt = false;
                        }
                    }
                    else
                    {
                        loadForm(phong);
                        CheckTTP(phong);
                        kt2 = false;
                    }
                    if (kt)
                    {
                        dgvTTPhong.Rows.Clear();
                        if (!kt2)
                        {
                            loadForm(phong);
                            CheckTTP(phong);
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("Chỉ nhập số");
                    return;
                }
            }
        }

        private void btnDX_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn đăng xuất không?", "Cảnh Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                == DialogResult.Yes)
            {
            this.Close();
            }
            else
            {
                return;
            }

        }
    }
}
