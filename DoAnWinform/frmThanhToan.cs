using DoAnWinform.Models;
using Microsoft.Reporting.WinForms;
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
    public partial class frmThanhToan : Form
    {
        public frmThanhToan()
        {
            InitializeComponent();
        }
            DBContextModel context = new DBContextModel();
        private void frmThanhToan_Load(object sender, EventArgs e)
        {
            this.reportViewer1.RefreshReport();
            reportViewer1.LocalReport.ReportPath = "Report1.rdlc";
            var thanhToan = context.ThanhToan.ToList();
            var NamevaTotal = context.ThanhToan.FirstOrDefault(p => p.CCCD == SaveNameVaTotal.CCCD);
            // in thong tin Parameter
            ReportParameter[] r = new ReportParameter[] {
                new ReportParameter("hoTen", NamevaTotal.HoTen),
                new ReportParameter("tongTien",NamevaTotal.TongTien),
                new ReportParameter("Tks","Cảm Ơn Và Hẹn Gặp Lại!!!\n" +
                "Thank You And See You Soon!!!"),
            };
           //in Thong tin table
           reportViewer1.LocalReport.SetParameters(r);
            var source = new ReportDataSource("DataSet1", thanhToan);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(source);

            this.reportViewer1.RefreshReport();
            context.ThanhToan.RemoveRange(thanhToan);
            context.SaveChanges();
        }
    }
}
