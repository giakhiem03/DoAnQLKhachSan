using DoAnWinform.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Reflection;
using System.Security.Cryptography.Pkcs;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace DoAnWinform
{
    public partial class frmUpdateDelete : Form
    {
        public frmUpdateDelete()
        {
            InitializeComponent();
        }

        DBContextModel context = new DBContextModel();
        private void frmUpdateDelete_Load(object sender, EventArgs e)
        {
            this.BackgroundImageLayout = ImageLayout.Stretch;
            this.BackgroundImage = Properties.Resources._1971799;
            dgvPhong.DefaultCellStyle.BackColor = Color.IndianRed;
            var phong = context.ThongTinPhong.ToList();
            GirdView(phong);
            CheckTTP(phong);
            var loaiPhong = context.LoaiPhong.ToList();
            FillcmbLP(loaiPhong);
            var trangThai = context.TrangThai.ToList();
            FillcmbTT(trangThai);
            var searchLP = context.LoaiPhong.ToList();
            FillcmbSLP(searchLP);
            cmbTT.SelectedIndex = -1;
            cmbLoaiPhong.SelectedIndex = -1;
            cmbSearchLP.SelectedIndex = 0;
            cmbLoaiPhong.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTT.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSearchLP.DropDownStyle = ComboBoxStyle.DropDownList;

        }

        private void CheckTTP(List<ThongTinPhong> phong)
        {
            for (int i = 0; i < phong.Count; i++)
            {
                if (phong[i].TrangThai == 1)
                {
                    dgvPhong.Rows[i].DefaultCellStyle.BackColor = Color.Yellow;
                }
            }
        }

        private void FillcmbSLP(List<LoaiPhong> searchLP)
        {
            //fill cmbSearch
            searchLP.Insert(0, new LoaiPhong());
            cmbSearchLP.DataSource = searchLP;
            cmbSearchLP.DisplayMember = "Ten";
            cmbSearchLP.ValueMember = "Ma";
        }

        private void FillcmbTT(List<TrangThai> trangThai)
        {
            cmbTT.DataSource = trangThai;
            cmbTT.DisplayMember = "Ten";
            cmbTT.ValueMember = "Ma";
        }

        private void FillcmbLP(List<LoaiPhong> loaiPhong)
        {
            //fill cmbLP
            cmbLoaiPhong.DataSource = loaiPhong;
            cmbLoaiPhong.DisplayMember = "Ten";
            cmbLoaiPhong.ValueMember = "Ma";
        }

        private void GirdView(List<ThongTinPhong> phong)
        {
            dgvPhong.Rows.Clear();
            foreach (var item in phong)
            {
                int index = dgvPhong.Rows.Add();
                dgvPhong.Rows[index].Cells[0].Value = item.MaPhong;
                dgvPhong.Rows[index].Cells[1].Value = item.LoaiPhong1.Ten;
                dgvPhong.Rows[index].Cells[2].Value = item.SoGiuong;
                dgvPhong.Rows[index].Cells[3].Value = item.TrangThai1.Ten;
                dgvPhong.Rows[index].Cells[4].Value = item.TienNgay;
                dgvPhong.Rows[index].Cells[5].Value = item.TienGio;
            }
        }

        private void dgvPhong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int dongchon = e.RowIndex;
            if(dongchon != -1)
            {
                txtMaPhong.Text = dgvPhong.Rows[dongchon].Cells[0].Value.ToString();
                cmbLoaiPhong.Text = dgvPhong.Rows[dongchon].Cells[1].Value.ToString();
                txtSoGiuong.Text = dgvPhong.Rows[dongchon].Cells[2].Value.ToString();
                cmbTT.Text = dgvPhong.Rows[dongchon].Cells[3].Value.ToString();
                txtTienNgay.Text = dgvPhong.Rows[dongchon].Cells[4].Value.ToString();
                txtTienGio.Text = dgvPhong.Rows[dongchon].Cells[5].Value.ToString();
            } else
            {
                MessageBox.Show("Chọn đúng dòng thông tin!!!");
                return;
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtMaPhong.Text) || string.IsNullOrEmpty(txtSoGiuong.Text) 
                || string.IsNullOrEmpty(txtTienGio.Text) || string.IsNullOrEmpty(txtTienNgay.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!!!");
                return;
            }
            int maPhong = int.Parse(txtMaPhong.Text);
            var dbMa = context.ThongTinPhong.FirstOrDefault(p => p.MaPhong == maPhong);
            if (dbMa != null)
            {
                dbMa.MaPhong = int.Parse(txtMaPhong.Text);
                dbMa.LoaiPhong = cmbLoaiPhong.SelectedIndex + 1;
                dbMa.SoGiuong = int.Parse(txtSoGiuong.Text);
                dbMa.TrangThai = cmbTT.SelectedIndex + 1;
                dbMa.TienNgay = txtTienNgay.Text;
                dbMa.TienGio = txtTienGio.Text;
                MessageBox.Show("Cập nhật thành công!!!");
                context.SaveChanges();
                dgvPhong.Refresh();
                var phong = context.ThongTinPhong.ToList();
                GirdView(phong);
                CheckTTP(phong);
            }
            else
            {
                MessageBox.Show("Mã phòng không tồn tại!!!");
                return;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaPhong.Text))
            {
                MessageBox.Show("Vui lòng nhập mã phòng!!!");
                return;
            }
            int maPhong = int.Parse(txtMaPhong.Text);
            var dbMa = context.ThongTinPhong.FirstOrDefault(p => p.MaPhong == maPhong);
            if (dbMa != null)
            {
                DialogResult dialog =  MessageBox.Show("Bạn có muốn xóa phòng này không ? ","Cảnh Báo",MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialog ==  DialogResult.Yes)
                {
                context.ThongTinPhong.Remove(dbMa);
                context.SaveChanges();
                    MessageBox.Show("Xóa thành công!!!");
                dgvPhong.Refresh();
                var phong = context.ThongTinPhong.ToList();
                GirdView(phong);
                CheckTTP(phong);
                } else
                {
                    MessageBox.Show("Mã phòng không tồn tại!!!");
                    return;
                }
            }

        }

        private void txtSearchMa_TextChanged(object sender, EventArgs e)
        {
            bool kt = true;
            var ttP = context.ThongTinPhong.ToList();
            dgvPhong.Rows.Clear();
            for(int i = 0;i<ttP.Count;i++)
            { 
                if (txtSearchMa.Text != ""  && txtMaPhong != null)
                {
                    try
                    {
                        if(cmbSearchLP.SelectedIndex == 0)
                        {
                        if (int.Parse(txtSearchMa.Text) == ttP[i].MaPhong)
                        {
                            int index = dgvPhong.Rows.Add();
                            if (ttP[i].TrangThai == 1)
                            {
                                dgvPhong.Rows[index].DefaultCellStyle.BackColor = Color.Yellow;
                            }
                            dgvPhong.Rows[index].Cells[0].Value = ttP[i].MaPhong;
                            dgvPhong.Rows[index].Cells[1].Value = ttP[i].LoaiPhong1.Ten;
                            dgvPhong.Rows[index].Cells[2].Value = ttP[i].SoGiuong;
                            dgvPhong.Rows[index].Cells[3].Value = ttP[i].TrangThai1.Ten;
                            dgvPhong.Rows[index].Cells[4].Value = ttP[i].TienNgay;
                            dgvPhong.Rows[index].Cells[5].Value = ttP[i].TienGio;
                            kt = false;
                        }
                        } else
                        {
                            if(int.Parse(txtSearchMa.Text) == ttP[i].MaPhong && cmbSearchLP.SelectedIndex == ttP[i].LoaiPhong)
                            {
                                int index = dgvPhong.Rows.Add(); 
                            if (ttP[i].TrangThai == 1)
                            {
                                dgvPhong.Rows[index].DefaultCellStyle.BackColor = Color.Yellow;
                            }
                            dgvPhong.Rows[index].Cells[0].Value = ttP[i].MaPhong;
                                dgvPhong.Rows[index].Cells[1].Value = ttP[i].LoaiPhong1.Ten;
                                dgvPhong.Rows[index].Cells[2].Value = ttP[i].SoGiuong;
                                dgvPhong.Rows[index].Cells[3].Value = ttP[i].TrangThai1.Ten;
                                dgvPhong.Rows[index].Cells[4].Value = ttP[i].TienNgay;
                                dgvPhong.Rows[index].Cells[5].Value = ttP[i].TienGio;
                                kt = false;
                            }
                        }
                          } catch(Exception) 
                          {
                              MessageBox.Show("Mã search phải là số!!!");
                              return;
                          }
                    if (kt)
                    {
                        dgvPhong.Rows.Clear();
                    }
                }
                else
                {
                    GirdView(ttP);
                    CheckTTP(ttP);
                } 
            }
        }

        private void cmbSearchLP_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool kt2 = true;
            bool kt = true;
            var ttP = context.ThongTinPhong.ToList();
            dgvPhong.Rows.Clear(); 
            foreach (var item in ttP)
            {
                try
                {
                    if (string.IsNullOrEmpty(txtSearchMa.Text)==true)
                    {
                        if (cmbSearchLP.SelectedIndex == item.LoaiPhong)
                        {
                            int index = dgvPhong.Rows.Add();
                            if (item.TrangThai == 1)
                            {
                                dgvPhong.Rows[index].DefaultCellStyle.BackColor = Color.Yellow;
                            }
                            dgvPhong.Rows[index].Cells[0].Value = item.MaPhong;
                            dgvPhong.Rows[index].Cells[1].Value = item.LoaiPhong1.Ten;
                            dgvPhong.Rows[index].Cells[2].Value = item.SoGiuong;
                            dgvPhong.Rows[index].Cells[3].Value = item.TrangThai1.Ten;
                            dgvPhong.Rows[index].Cells[4].Value = item.TienNgay;
                            dgvPhong.Rows[index].Cells[5].Value = item.TienGio;
                            kt = false;
                        }
                        kt2 = false;
                    }
                    else if(string.IsNullOrEmpty(txtSearchMa.Text) == false)
                    {
                        if (int.Parse(txtSearchMa.Text) == item.MaPhong)
                        { 
                            if (cmbSearchLP.SelectedIndex == item.LoaiPhong)
                            {
                            int index = dgvPhong.Rows.Add();
                            if (item.TrangThai == 1)
                            {
                                dgvPhong.Rows[index].DefaultCellStyle.BackColor = Color.Yellow;
                            }
                            dgvPhong.Rows[index].Cells[0].Value = item.MaPhong;
                            dgvPhong.Rows[index].Cells[1].Value = item.LoaiPhong1.Ten;
                            dgvPhong.Rows[index].Cells[2].Value = item.SoGiuong;
                            dgvPhong.Rows[index].Cells[3].Value = item.TrangThai1.Ten;
                            dgvPhong.Rows[index].Cells[4].Value = item.TienNgay;
                            dgvPhong.Rows[index].Cells[5].Value = item.TienGio;
                            kt = false;

                            }
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("Mã search phải là số!!!");
                    return;
                }
            }
                
            if (kt)
            {
                dgvPhong.Rows.Clear();
                if (!kt2)
                {
                    GirdView(ttP);
                    CheckTTP(ttP);
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
