namespace DoAnWinform
{
    partial class frmDanhSachBooking
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvBookingRoom = new System.Windows.Forms.DataGridView();
            this.colCCCD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colND = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSND = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSGD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMPD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.txtTimer = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookingRoom)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBookingRoom
            // 
            this.dgvBookingRoom.AllowUserToAddRows = false;
            this.dgvBookingRoom.AllowUserToDeleteRows = false;
            this.dgvBookingRoom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvBookingRoom.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBookingRoom.BackgroundColor = System.Drawing.Color.Aqua;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBookingRoom.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvBookingRoom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBookingRoom.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCCCD,
            this.colTen,
            this.colGT,
            this.colSDT,
            this.colQT,
            this.colND,
            this.colSND,
            this.colSGD,
            this.colTT,
            this.colMPD});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBookingRoom.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvBookingRoom.Location = new System.Drawing.Point(46, 149);
            this.dgvBookingRoom.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dgvBookingRoom.Name = "dgvBookingRoom";
            this.dgvBookingRoom.ReadOnly = true;
            this.dgvBookingRoom.RowHeadersWidth = 51;
            this.dgvBookingRoom.RowTemplate.Height = 24;
            this.dgvBookingRoom.Size = new System.Drawing.Size(1310, 386);
            this.dgvBookingRoom.TabIndex = 0;
            this.dgvBookingRoom.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBookingRoom_CellClick);
            // 
            // colCCCD
            // 
            this.colCCCD.HeaderText = "CMND/CCCD";
            this.colCCCD.MinimumWidth = 6;
            this.colCCCD.Name = "colCCCD";
            this.colCCCD.ReadOnly = true;
            // 
            // colTen
            // 
            this.colTen.HeaderText = "Họ Tên";
            this.colTen.MinimumWidth = 6;
            this.colTen.Name = "colTen";
            this.colTen.ReadOnly = true;
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
            // colMPD
            // 
            this.colMPD.HeaderText = "Mã Phòng Đặt";
            this.colMPD.MinimumWidth = 6;
            this.colMPD.Name = "colMPD";
            this.colMPD.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Aqua;
            this.label1.Font = new System.Drawing.Font("Castellar", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SlateGray;
            this.label1.Location = new System.Drawing.Point(480, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(492, 48);
            this.label1.TabIndex = 1;
            this.label1.Text = "THÔNG TIN BOKING";
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnThanhToan.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThanhToan.ForeColor = System.Drawing.Color.Orange;
            this.btnThanhToan.Location = new System.Drawing.Point(1179, 568);
            this.btnThanhToan.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(177, 61);
            this.btnThanhToan.TabIndex = 2;
            this.btnThanhToan.Text = "Thanh Toán";
            this.btnThanhToan.UseVisualStyleBackColor = true;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // txtTimer
            // 
            this.txtTimer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTimer.AutoSize = true;
            this.txtTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTimer.Location = new System.Drawing.Point(1095, 39);
            this.txtTimer.Name = "txtTimer";
            this.txtTimer.Size = new System.Drawing.Size(52, 20);
            this.txtTimer.TabIndex = 3;
            this.txtTimer.Text = "Timer";
            // 
            // btnThoat
            // 
            this.btnThoat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThoat.ForeColor = System.Drawing.Color.Orange;
            this.btnThoat.Location = new System.Drawing.Point(984, 569);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(177, 60);
            this.btnThoat.TabIndex = 4;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // frmDanhSachBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1402, 681);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.txtTimer);
            this.Controls.Add(this.btnThanhToan);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvBookingRoom);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "frmDanhSachBooking";
            this.Text = "frmDanhSachBooking";
            this.Load += new System.EventHandler(this.frmDanhSachBooking_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookingRoom)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBookingRoom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label txtTimer;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCCCD;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colND;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSND;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSGD;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMPD;
        private System.Windows.Forms.Button btnThoat;
    }
}