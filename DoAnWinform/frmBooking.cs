using DoAnWinform.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
//using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnWinform
{
    public partial class frmBooking : Form
    {
        public frmBooking()
        {
            InitializeComponent();
            timer1.Start();
        }
            DBContextModel context = new DBContextModel();
        private void frmBooking_Load(object sender, EventArgs e)
        {
            dgvBooking.DefaultCellStyle.BackColor = Color.Aqua;
            this.BackgroundImageLayout = ImageLayout.Stretch;
            this.BackgroundImage = Properties.Resources._1971799;
            GridView();
            var Gender = context.GioiTinh.ToList();
            FillcmbGender(Gender);
            txtGio.Enabled = false;
            cmbLuaChon.SelectedIndex = 0; 
            cmbGioiTinh.DropDownStyle = ComboBoxStyle.DropDownList; 
            cmbLuaChon.DropDownStyle = ComboBoxStyle.DropDownList;  
            txtMaPhongDat.Enabled = false;
            txtMaPhongDat.Text = LuuThongTinQuaBooking.maPhong.ToString();
            txtTongTien.Enabled = false;
        }

        private void LoadForm()
        {
            txtCCCD.Text = string.Empty;
            txtHoTen.Text = string.Empty;
            txtDT.Text = string.Empty;
            txtGio.Text = string.Empty;
            txtNgay.Text = string.Empty;    
            txtQuocTich.Text = string.Empty;
            cmbGioiTinh.SelectedIndex = -1;
            txtMaPhongDat.Text = string.Empty;
            txtTongTien.Text = string.Empty;
            cmbLuaChon.SelectedIndex = 0;
        }

        private void FillcmbGender(List<GioiTinh> gender)
        {
            cmbGioiTinh.DataSource = gender;
            cmbGioiTinh.DisplayMember = "Ten";
            cmbGioiTinh.ValueMember = "Ma";
        }
        int tienNgay;
        int tienGio;
        private void GridView()
        {
            dgvBooking.Rows.Clear();
            var ttP = context.ThongTinPhong.FirstOrDefault(p => p.MaPhong == LuuThongTinQuaBooking.maPhong);
            if(ttP != null)
            {
                int index = dgvBooking.Rows.Add();
            dgvBooking.Rows[index].Cells[0].Value = ttP.MaPhong;
            dgvBooking.Rows[index].Cells[1].Value = ttP.LoaiPhong1.Ten;
            dgvBooking.Rows[index].Cells[2].Value = ttP.SoGiuong;
            dgvBooking.Rows[index].Cells[3].Value = ttP.TrangThai1.Ten;
            dgvBooking.Rows[index].Cells[4].Value = ttP.TienNgay;
            dgvBooking.Rows[index].Cells[5].Value = ttP.TienGio;
                tienNgay = int.Parse(ttP.TienNgay);
                tienGio = int.Parse(ttP.TienGio);
            }

        }
        private void timer1_Tick(object sender, EventArgs e)
        {

            txtTime.Text = DateTime.Now.ToString("G");
        }

        private void btnBooking_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtHoTen.Text) || string.IsNullOrEmpty(txtCCCD.Text)
                || string.IsNullOrEmpty(txtDT.Text) || string.IsNullOrEmpty(txtQuocTich.Text)
                || cmbGioiTinh.SelectedIndex == -1)
            {
                MessageBox.Show("Điền đầy đủ thông tin khách hàng!!!");
                return;
            }
            if (string.IsNullOrEmpty(txtNgay.Text) && string.IsNullOrEmpty(txtGio.Text))
            {
                MessageBox.Show("Vui lòng nhập số ngày hoặc giờ");
                return;
            }
            if (txtCCCD.Text.Length != 12)
            {
                MessageBox.Show("CCCD phải có 12 số!!!");
                return;
            }
            if (txtDT.Text.Length != 10)
            {
                MessageBox.Show("SDT phải có 10 số!!!");
                return;
            }
            var khachHang = context.KhachHang.FirstOrDefault(p => p.CCCD == txtCCCD.Text);
            if( khachHang != null)
            {
                MessageBox.Show("Trùng CCCD");
                return;
            }
            try
            {
            KhachHang kh = new KhachHang()
            {
                CCCD = txtCCCD.Text,
                HoTen = txtHoTen.Text,
                SDT = txtDT.Text,
                GioiTinh = cmbGioiTinh.SelectedIndex+1,
                QuocTich = txtQuocTich.Text,
                NgayDat = Convert.ToDateTime(txtTime.Text),
                SoGioDat = txtGio.Text,
                SoNgayDat = txtNgay.Text,
                MaPhongDat = int.Parse(txtMaPhongDat.Text),
                TongTien = txtTongTien.Text,
            };
            context.KhachHang.Add(kh);

            MessageBox.Show("Xác nhận đặt phòng thành công!!!");
            int maDatPhong = int.Parse(txtMaPhongDat.Text);
            ThongTinPhong ttP = context.ThongTinPhong.FirstOrDefault(p => p.MaPhong == maDatPhong);
            ttP.TrangThai = 2;
            context.SaveChanges();
            LoadForm();
            this.Close();
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
                    }

        private void cmbLuaChon_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbLuaChon.SelectedIndex == 0)
            {
                txtNgay.Enabled = true;
                txtGio.Text = string.Empty;
                txtGio.Enabled = false;
                
            }
            else
            {
                txtGio.Enabled = true;
                txtNgay.Text = string.Empty;
                txtNgay.Enabled= false;
            }
        }

        private void txtNgay_TextChanged(object sender, EventArgs e)
        {
            try
            {
            if(txtNgay.Text != null && txtNgay.Text != "")
            txtTongTien.Text = (int.Parse(txtNgay.Text) * tienNgay).ToString() ;
            else
            {
                txtTongTien.Text = string.Empty;
                return;
            }
            }
            catch
            {
                MessageBox.Show("Chỉ nhập số!!!");
                return;
            }
        }

        private void txtGio_TextChanged(object sender, EventArgs e)
        {
            try
            {
            if(txtGio.Text != null && txtGio.Text != "")
            txtTongTien.Text = (int.Parse(txtGio.Text) * tienGio).ToString();
            else
            {
                txtTongTien.Text = string.Empty;
                return;
            }

            }
            catch
            {
                MessageBox.Show("Chỉ nhập số!!!");
                return;

            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
