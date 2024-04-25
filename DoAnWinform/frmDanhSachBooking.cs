using DoAnWinform.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnWinform
{
    public partial class frmDanhSachBooking : Form
    {
        public frmDanhSachBooking()
        {
            InitializeComponent();
            timer1.Start();
        }
        int dongchon;
            DBContextModel context = new DBContextModel();
        private void frmDanhSachBooking_Load(object sender, EventArgs e)
        {
            dgvBookingRoom.DefaultCellStyle.BackColor = Color.Aqua;
            this.BackgroundImageLayout = ImageLayout.Stretch;
            this.BackgroundImage = Properties.Resources._1971799;
            var khachHang = context.KhachHang.ToList();
            GridView(khachHang);
        }

        private void GridView(List<KhachHang> khachHang)
        {
            dgvBookingRoom.Rows.Clear();
            foreach( var item in khachHang)
            {
                int index = dgvBookingRoom.Rows.Add();
                dgvBookingRoom.Rows[index].Cells[0].Value = item.CCCD;
                dgvBookingRoom.Rows[index].Cells[1].Value = item.HoTen;
                dgvBookingRoom.Rows[index].Cells[2].Value = item.GioiTinh1.Ten;
                dgvBookingRoom.Rows[index].Cells[3].Value = item.SDT;
                dgvBookingRoom.Rows[index].Cells[4].Value = item.QuocTich;
                dgvBookingRoom.Rows[index].Cells[5].Value = item.NgayDat;
                if (item.SoNgayDat == null || item.SoNgayDat == "")
                    item.SoNgayDat = "0";
                dgvBookingRoom.Rows[index].Cells[6].Value = item.SoNgayDat;
                if(item.SoGioDat == null || item.SoGioDat == "")
                    item.SoGioDat = "0";
                dgvBookingRoom.Rows[index].Cells[7].Value = item.SoGioDat;
                dgvBookingRoom.Rows[index].Cells[8].Value = item.TongTien;
                dgvBookingRoom.Rows[index].Cells[9].Value = item.MaPhongDat;
            }
        }

        private void dgvBookingRoom_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dongchon = e.RowIndex;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            txtTimer.Text = DateTime.Now.ToString("G");
        }
                int gioiTinh;
        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            dgvBookingRoom.Refresh();
            if(dongchon != -1)
            {
                if (dgvBookingRoom.Rows[dongchon].Cells[2].Value.ToString() == "Nam")
                {
                    gioiTinh = 1;
                }else 
                if(dgvBookingRoom.Rows[dongchon].Cells[2].Value.ToString() == "Nữ")
                {
                    gioiTinh = 2;
                }
                // In Thanh toán ra ReportViewer
                SaveNameVaTotal.CCCD = dgvBookingRoom.Rows[dongchon].Cells[0].Value.ToString();
                ThanhToan thanhToan = new ThanhToan()
                {
                    CCCD = dgvBookingRoom.Rows[dongchon].Cells[0].Value.ToString(),
                    HoTen = dgvBookingRoom.Rows[dongchon].Cells[1].Value.ToString(),
                    GioiTinh = gioiTinh,
                    SDT = dgvBookingRoom.Rows[dongchon].Cells[3].Value.ToString(),
                    QuocTich = dgvBookingRoom.Rows[dongchon].Cells[4].Value.ToString(),
                    NgayDat = Convert.ToDateTime(dgvBookingRoom.Rows[dongchon].Cells[5].Value.ToString()),
                    NgayThanhToan = Convert.ToDateTime(txtTimer.Text),
                    SoNgayDat = dgvBookingRoom.Rows[dongchon].Cells[6].Value.ToString(),
                    SoGioDat = dgvBookingRoom.Rows[dongchon].Cells[7].Value.ToString(),
                    TongTien = dgvBookingRoom.Rows[dongchon].Cells[8].Value.ToString(),
                    MaPhongDat = int.Parse(dgvBookingRoom.Rows[dongchon].Cells[9].Value.ToString()),
                };
                context.ThanhToan.Add(thanhToan);
                context.SaveChanges();
                //add vào lịch sử khách hàng
                LichSuKhachHang lskh = new LichSuKhachHang()
                {
                    CCCD = dgvBookingRoom.Rows[dongchon].Cells[0].Value.ToString(),
                    HoTen = dgvBookingRoom.Rows[dongchon].Cells[1].Value.ToString(),
                    GioiTinh = gioiTinh,
                    SDT = dgvBookingRoom.Rows[dongchon].Cells[3].Value.ToString(),
                    QuocTich = dgvBookingRoom.Rows[dongchon].Cells[4].Value.ToString(),
                    NgayDat = Convert.ToDateTime(dgvBookingRoom.Rows[dongchon].Cells[5].Value.ToString()),
                    NgayThanhToan = Convert.ToDateTime(txtTimer.Text),
                    SoNgayDat = dgvBookingRoom.Rows[dongchon].Cells[6].Value.ToString(),
                    SoGioDat = dgvBookingRoom.Rows[dongchon].Cells[7].Value.ToString(),
                    TongTien = dgvBookingRoom.Rows[dongchon].Cells[8].Value.ToString(),
                    MaPhongDat = int.Parse(dgvBookingRoom.Rows[dongchon].Cells[9].Value.ToString()),
                };
                context.LichSuKhachHang.Add(lskh);
                context.SaveChanges();
                //
                var CCCD = dgvBookingRoom.Rows[dongchon].Cells[0].Value.ToString();
                var dbKH = context.KhachHang.FirstOrDefault(p => p.CCCD == CCCD);
                if(dbKH != null)
                {
                    context.KhachHang.Remove(dbKH);
                    context.SaveChanges();
                    MessageBox.Show("Thanh toán thành công!!!");
                }
                var maPD = int.Parse(dgvBookingRoom.Rows[dongchon].Cells[9].Value.ToString());

                var dbTTP = context.ThongTinPhong.FirstOrDefault(p => p.MaPhong == maPD);
                if(dbTTP != null)
                {
                    dbTTP.TrangThai = 1;
                    context.SaveChanges();
                    dgvBookingRoom.Refresh();
                    var khachHang = context.KhachHang.ToList();
                    GridView(khachHang);
                }
               
                this.Hide();
                frmThanhToan frm = new frmThanhToan();
                frm.ShowDialog();
                frm.Close();
                this.Show();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn khách hàng cần thanh toán!!!");
                return;
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
