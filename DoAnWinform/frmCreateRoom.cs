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
    public partial class frmCreateRoom : Form
    {
        public frmCreateRoom()
        {
            InitializeComponent();
        }
        DBContextModel context = new DBContextModel();
        private void frmCreateRoom_Load(object sender, EventArgs e)
        {

            this.BackgroundImageLayout = ImageLayout.Stretch;
            this.BackgroundImage = Properties.Resources._1971799;
            cmbLoaiPhong.DropDownStyle = ComboBoxStyle.DropDownList;
            List<LoaiPhong> loaiPhongs = context.LoaiPhong.ToList();
            FillCmbLP(loaiPhongs);
            cmbLoaiPhong.SelectedIndex = 0;
        }

        private void FillCmbLP(List<LoaiPhong> loaiPhongs)
        {
            cmbLoaiPhong.DataSource = loaiPhongs;
            cmbLoaiPhong.DisplayMember = "Ten";
            cmbLoaiPhong.ValueMember = "Ma";
        }
        private void LoadForm()
        {
            cmbLoaiPhong.SelectedIndex = 0;
            txtMaPhong.Text = string.Empty;
            txtSoGiuong.Text = string.Empty;
            txtTienGio.Text = string.Empty;
            txtTienNgay.Text = string.Empty;
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaPhong.Text) || string.IsNullOrEmpty(txtSoGiuong.Text) || 
                string.IsNullOrEmpty(txtTienGio.Text) || string.IsNullOrEmpty(txtTienNgay.Text ))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!!!");
                return;
            }
            if(int.Parse(txtMaPhong.Text) < 0)
            {
                MessageBox.Show("Mã phòng phải lớn hơn 0");
                return;
            }
            if(int.Parse(txtSoGiuong.Text) < 1)
            {
                MessageBox.Show("Số giường phải lớn hơn 1");
                return;
            }
            if(float.Parse(txtTienGio.Text) < 0 || float.Parse(txtTienNgay.Text) < 0) 
            {
                MessageBox.Show("Số tiền phải lớn hơn 0");
                return;
            }
            int maPhong = int.Parse(txtMaPhong.Text);
            var dbMa = context.ThongTinPhong.FirstOrDefault(p => p.MaPhong == maPhong);
            if (dbMa == null)
            {
            ThongTinPhong ttPhong = new ThongTinPhong()
            {
                MaPhong = int.Parse(txtMaPhong.Text),
                LoaiPhong = cmbLoaiPhong.SelectedIndex + 1,
                TrangThai = 1,
                SoGiuong = int.Parse(txtSoGiuong.Text),
                TienNgay = txtTienNgay.Text,
                TienGio = txtTienGio.Text,
            };
            MessageBox.Show("Thêm Phòng Thành Công");
            context.ThongTinPhong.Add(ttPhong);
            context.SaveChanges();
            LoadForm();
            } else
            {
                MessageBox.Show("Trùng mã số phòng!!!");
                return;
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
