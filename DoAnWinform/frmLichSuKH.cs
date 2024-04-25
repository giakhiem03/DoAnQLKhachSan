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
    public partial class frmLichSuKH : Form
    {
        public frmLichSuKH()
        {
            InitializeComponent();
        }

            DBContextModel context = new DBContextModel();
        private void frmLichSuKH_Load(object sender, EventArgs e)
        {
            dgvLSKH.DefaultCellStyle.BackColor = Color.Aqua;
            this.BackgroundImageLayout = ImageLayout.Stretch;
            this.BackgroundImage = Properties.Resources._1971799;
            var LSKH = context.LichSuKhachHang.ToList();
            GridViewLSKH(LSKH);
            SortDate(LSKH);
        }

        private void SortDate(List<LichSuKhachHang> lSKH)
        {
            for(int i = 0;i< lSKH.Count; i++)
            {
                dgvLSKH.Sort(dgvLSKH.Columns[6],ListSortDirection.Descending);
            }
        }

        private void GridViewLSKH(List<LichSuKhachHang> lSKH)
        {
            dgvLSKH.Rows.Clear();
            foreach(var item in lSKH)
            {
                int index = dgvLSKH.Rows.Add();
                dgvLSKH.Rows[index].Cells[0].Value = item.CCCD;
                dgvLSKH.Rows[index].Cells[1].Value = item.HoTen;
                dgvLSKH.Rows[index].Cells[2].Value = item.GioiTinh1.Ten;
                dgvLSKH.Rows[index].Cells[3].Value = item.SDT;
                dgvLSKH.Rows[index].Cells[4].Value = item.QuocTich;
                dgvLSKH.Rows[index].Cells[5].Value = item.NgayDat;
                dgvLSKH.Rows[index].Cells[6].Value = item.NgayThanhToan;
                if (item.SoNgayDat == null || item.SoNgayDat == "")
                    item.SoNgayDat = "0";
                dgvLSKH.Rows[index].Cells[7].Value = item.SoNgayDat;
                if (item.SoGioDat == null || item.SoGioDat == "")
                    item.SoGioDat = "0";
                dgvLSKH.Rows[index].Cells[8].Value = item.SoGioDat;
                dgvLSKH.Rows[index].Cells[9].Value = item.TongTien;
                dgvLSKH.Rows[index].Cells[10].Value = item.MaPhongDat;
            }
        }

        private void txtSearchSDT_TextChanged(object sender, EventArgs e)
        {
            var lsKH = context.LichSuKhachHang.ToList();
            dgvLSKH.Rows.Clear();
            foreach(var item in lsKH)
            {
                if (item.SDT.Contains(txtSearchSDT.Text))
                {
                    int index = dgvLSKH.Rows.Add();
                    dgvLSKH.Rows[index].Cells[0].Value = item.CCCD;
                    dgvLSKH.Rows[index].Cells[1].Value = item.HoTen;
                    dgvLSKH.Rows[index].Cells[2].Value = item.GioiTinh1.Ten;
                    dgvLSKH.Rows[index].Cells[3].Value = item.SDT;
                    dgvLSKH.Rows[index].Cells[4].Value = item.QuocTich;
                    dgvLSKH.Rows[index].Cells[5].Value = item.NgayDat;
                    dgvLSKH.Rows[index].Cells[6].Value = item.NgayThanhToan;
                    dgvLSKH.Rows[index].Cells[7].Value = item.SoNgayDat;
                    dgvLSKH.Rows[index].Cells[8].Value = item.SoGioDat;
                    dgvLSKH.Rows[index].Cells[9].Value = item.TongTien;
                    dgvLSKH.Rows[index].Cells[10].Value = item.MaPhongDat;
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
