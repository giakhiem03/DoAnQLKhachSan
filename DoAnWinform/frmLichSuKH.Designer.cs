namespace DoAnWinform
{
    partial class frmLichSuKH
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvLSKH = new System.Windows.Forms.DataGridView();
            this.colCCCd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colND = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSND = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSGD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearchSDT = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLSKH)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvLSKH
            // 
            this.dgvLSKH.AllowUserToAddRows = false;
            this.dgvLSKH.AllowUserToDeleteRows = false;
            this.dgvLSKH.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvLSKH.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLSKH.BackgroundColor = System.Drawing.Color.Aqua;
            this.dgvLSKH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLSKH.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCCCd,
            this.colHT,
            this.colGT,
            this.colSDT,
            this.colQT,
            this.colND,
            this.colNTT,
            this.colSND,
            this.colSGD,
            this.colTT,
            this.colMa});
            this.dgvLSKH.Location = new System.Drawing.Point(88, 148);
            this.dgvLSKH.Name = "dgvLSKH";
            this.dgvLSKH.ReadOnly = true;
            this.dgvLSKH.RowHeadersWidth = 51;
            this.dgvLSKH.RowTemplate.Height = 24;
            this.dgvLSKH.Size = new System.Drawing.Size(1233, 426);
            this.dgvLSKH.TabIndex = 0;
            // 
            // colCCCd
            // 
            this.colCCCd.HeaderText = "CCCD";
            this.colCCCd.MinimumWidth = 6;
            this.colCCCd.Name = "colCCCd";
            this.colCCCd.ReadOnly = true;
            // 
            // colHT
            // 
            this.colHT.HeaderText = "Họ Tên";
            this.colHT.MinimumWidth = 6;
            this.colHT.Name = "colHT";
            this.colHT.ReadOnly = true;
            // 
            // colGT
            // 
            this.colGT.HeaderText = "Giới Tính";
            this.colGT.MinimumWidth = 6;
            this.colGT.Name = "colGT";
            this.colGT.ReadOnly = true;
            // 
            // colSDT
            // 
            this.colSDT.HeaderText = "Số Điện Thoại";
            this.colSDT.MinimumWidth = 6;
            this.colSDT.Name = "colSDT";
            this.colSDT.ReadOnly = true;
            // 
            // colQT
            // 
            this.colQT.HeaderText = "Quốc Tịch";
            this.colQT.MinimumWidth = 6;
            this.colQT.Name = "colQT";
            this.colQT.ReadOnly = true;
            // 
            // colND
            // 
            this.colND.HeaderText = "Check in";
            this.colND.MinimumWidth = 6;
            this.colND.Name = "colND";
            this.colND.ReadOnly = true;
            // 
            // colNTT
            // 
            this.colNTT.HeaderText = "Check out";
            this.colNTT.MinimumWidth = 6;
            this.colNTT.Name = "colNTT";
            this.colNTT.ReadOnly = true;
            // 
            // colSND
            // 
            this.colSND.HeaderText = "Số Ngày Đặt";
            this.colSND.MinimumWidth = 6;
            this.colSND.Name = "colSND";
            this.colSND.ReadOnly = true;
            // 
            // colSGD
            // 
            this.colSGD.HeaderText = "Số Giờ Đặt";
            this.colSGD.MinimumWidth = 6;
            this.colSGD.Name = "colSGD";
            this.colSGD.ReadOnly = true;
            // 
            // colTT
            // 
            this.colTT.HeaderText = "Tổng Tiền";
            this.colTT.MinimumWidth = 6;
            this.colTT.Name = "colTT";
            this.colTT.ReadOnly = true;
            // 
            // colMa
            // 
            this.colMa.HeaderText = "Mã Phòng Đã Đặt";
            this.colMa.MinimumWidth = 6;
            this.colMa.Name = "colMa";
            this.colMa.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Aqua;
            this.label1.Font = new System.Drawing.Font("Castellar", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SlateGray;
            this.label1.Location = new System.Drawing.Point(445, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(554, 48);
            this.label1.TabIndex = 1;
            this.label1.Text = "LỊCH SỬ KHÁCH HÀNG ";
            // 
            // txtSearchSDT
            // 
            this.txtSearchSDT.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSearchSDT.Location = new System.Drawing.Point(1174, 99);
            this.txtSearchSDT.Name = "txtSearchSDT";
            this.txtSearchSDT.Size = new System.Drawing.Size(147, 22);
            this.txtSearchSDT.TabIndex = 2;
            this.txtSearchSDT.TextChanged += new System.EventHandler(this.txtSearchSDT_TextChanged);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(1170, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tìm Theo SĐT";
            // 
            // btnThoat
            // 
            this.btnThoat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThoat.ForeColor = System.Drawing.Color.Orange;
            this.btnThoat.Location = new System.Drawing.Point(1214, 591);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(107, 46);
            this.btnThoat.TabIndex = 4;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // frmLichSuKH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1395, 649);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSearchSDT);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvLSKH);
            this.Name = "frmLichSuKH";
            this.Text = "frmLichSuKH";
            this.Load += new System.EventHandler(this.frmLichSuKH_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLSKH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLSKH;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearchSDT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCCCd;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colND;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSND;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSGD;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMa;
        private System.Windows.Forms.Button btnThoat;
    }
}