namespace DoAnWinform
{
    partial class frmPhong
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tstAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.tstUAD = new System.Windows.Forms.ToolStripMenuItem();
            this.tstDSKH = new System.Windows.Forms.ToolStripMenuItem();
            this.tstLSKH = new System.Windows.Forms.ToolStripMenuItem();
            this.tstQLTKNV = new System.Windows.Forms.ToolStripMenuItem();
            this.tstThemPhong = new System.Windows.Forms.ToolStripMenuItem();
            this.tstUD = new System.Windows.Forms.ToolStripMenuItem();
            this.tstDSPD = new System.Windows.Forms.ToolStripMenuItem();
            this.tstLSPD = new System.Windows.Forms.ToolStripMenuItem();
            this.tstQLTK = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.dgvTTPhong = new System.Windows.Forms.DataGridView();
            this.colMA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChucVutxt = new System.Windows.Forms.Label();
            this.btnDX = new System.Windows.Forms.Button();
            this.txtSearchSG = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTimer = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTTPhong)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Aqua;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tstAdd,
            this.tstUAD,
            this.tstDSKH,
            this.tstLSKH,
            this.tstQLTKNV});
            this.menuStrip1.Location = new System.Drawing.Point(12, 9);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(809, 31);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tstAdd
            // 
            this.tstAdd.Name = "tstAdd";
            this.tstAdd.Size = new System.Drawing.Size(135, 27);
            this.tstAdd.Text = "Tạo Mới Phòng";
            this.tstAdd.Click += new System.EventHandler(this.tstAdd_Click);
            // 
            // tstUAD
            // 
            this.tstUAD.Name = "tstUAD";
            this.tstUAD.Size = new System.Drawing.Size(147, 27);
            this.tstUAD.Text = "Sửa / Xóa Phòng";
            this.tstUAD.Click += new System.EventHandler(this.tstUAD_Click);
            // 
            // tstDSKH
            // 
            this.tstDSKH.BackColor = System.Drawing.Color.Aqua;
            this.tstDSKH.Name = "tstDSKH";
            this.tstDSKH.Size = new System.Drawing.Size(177, 27);
            this.tstDSKH.Text = "Khu Vực Thanh Toán";
            this.tstDSKH.Click += new System.EventHandler(this.tstDSKH_Click);
            // 
            // tstLSKH
            // 
            this.tstLSKH.Name = "tstLSKH";
            this.tstLSKH.Size = new System.Drawing.Size(171, 27);
            this.tstLSKH.Text = "Lịch Sử Khách Hàng";
            this.tstLSKH.Click += new System.EventHandler(this.tstLSKH_Click);
            // 
            // tstQLTKNV
            // 
            this.tstQLTKNV.Name = "tstQLTKNV";
            this.tstQLTKNV.Size = new System.Drawing.Size(171, 27);
            this.tstQLTKNV.Text = "Quản Lý Tài Khoản ";
            this.tstQLTKNV.Click += new System.EventHandler(this.tstQLTKNV_Click);
            // 
            // tstThemPhong
            // 
            this.tstThemPhong.Name = "tstThemPhong";
            this.tstThemPhong.Size = new System.Drawing.Size(124, 24);
            this.tstThemPhong.Text = "Tạo Mới Phòng";
            // 
            // tstUD
            // 
            this.tstUD.Name = "tstUD";
            this.tstUD.Size = new System.Drawing.Size(126, 24);
            this.tstUD.Text = "Sửa/Xóa Phòng";
            // 
            // tstDSPD
            // 
            this.tstDSPD.Name = "tstDSPD";
            this.tstDSPD.Size = new System.Drawing.Size(157, 24);
            this.tstDSPD.Text = "Khu Vực Thanh Toán";
            // 
            // tstLSPD
            // 
            this.tstLSPD.Name = "tstLSPD";
            this.tstLSPD.Size = new System.Drawing.Size(154, 24);
            this.tstLSPD.Text = "Lịch Sử Khách Hàng";
            // 
            // tstQLTK
            // 
            this.tstQLTK.Name = "tstQLTK";
            this.tstQLTK.Size = new System.Drawing.Size(143, 24);
            this.tstQLTK.Text = "Quản Lý Tài Khoản";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Aqua;
            this.label1.Font = new System.Drawing.Font("Castellar", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SlateGray;
            this.label1.Location = new System.Drawing.Point(288, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(819, 48);
            this.label1.TabIndex = 2;
            this.label1.Text = "TRANG CHỦ QUẢN LÝ KHÁCH SẠN";
            // 
            // dgvTTPhong
            // 
            this.dgvTTPhong.AllowUserToAddRows = false;
            this.dgvTTPhong.AllowUserToDeleteRows = false;
            this.dgvTTPhong.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvTTPhong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTTPhong.BackgroundColor = System.Drawing.Color.Aqua;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTTPhong.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvTTPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTTPhong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMA,
            this.colLoai,
            this.colSG,
            this.colTT,
            this.colTN,
            this.colTG});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTTPhong.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvTTPhong.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvTTPhong.Location = new System.Drawing.Point(20, 172);
            this.dgvTTPhong.Name = "dgvTTPhong";
            this.dgvTTPhong.ReadOnly = true;
            this.dgvTTPhong.RowHeadersWidth = 51;
            this.dgvTTPhong.RowTemplate.Height = 24;
            this.dgvTTPhong.Size = new System.Drawing.Size(1326, 425);
            this.dgvTTPhong.TabIndex = 0;
            this.dgvTTPhong.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTTPhong_CellDoubleClick);
            // 
            // colMA
            // 
            this.colMA.HeaderText = "Mã Phòng";
            this.colMA.MinimumWidth = 6;
            this.colMA.Name = "colMA";
            this.colMA.ReadOnly = true;
            // 
            // colLoai
            // 
            this.colLoai.HeaderText = "Loại Phòng";
            this.colLoai.MinimumWidth = 6;
            this.colLoai.Name = "colLoai";
            this.colLoai.ReadOnly = true;
            // 
            // colSG
            // 
            this.colSG.HeaderText = "Số Giường";
            this.colSG.MinimumWidth = 6;
            this.colSG.Name = "colSG";
            this.colSG.ReadOnly = true;
            // 
            // colTT
            // 
            this.colTT.HeaderText = "Trạng Thái";
            this.colTT.MinimumWidth = 6;
            this.colTT.Name = "colTT";
            this.colTT.ReadOnly = true;
            // 
            // colTN
            // 
            this.colTN.HeaderText = "$ / Ngày";
            this.colTN.MinimumWidth = 6;
            this.colTN.Name = "colTN";
            this.colTN.ReadOnly = true;
            // 
            // colTG
            // 
            this.colTG.HeaderText = "$ / Giờ";
            this.colTG.MinimumWidth = 6;
            this.colTG.Name = "colTG";
            this.colTG.ReadOnly = true;
            // 
            // ChucVutxt
            // 
            this.ChucVutxt.AutoSize = true;
            this.ChucVutxt.BackColor = System.Drawing.Color.Aqua;
            this.ChucVutxt.Font = new System.Drawing.Font("Comic Sans MS", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChucVutxt.ForeColor = System.Drawing.Color.Gold;
            this.ChucVutxt.Location = new System.Drawing.Point(12, 96);
            this.ChucVutxt.Name = "ChucVutxt";
            this.ChucVutxt.Size = new System.Drawing.Size(137, 48);
            this.ChucVutxt.TabIndex = 7;
            this.ChucVutxt.Text = "ChucVu";
            // 
            // btnDX
            // 
            this.btnDX.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDX.BackColor = System.Drawing.Color.IndianRed;
            this.btnDX.FlatAppearance.BorderColor = System.Drawing.Color.Cyan;
            this.btnDX.FlatAppearance.BorderSize = 0;
            this.btnDX.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDX.Location = new System.Drawing.Point(1261, 603);
            this.btnDX.Name = "btnDX";
            this.btnDX.Size = new System.Drawing.Size(85, 48);
            this.btnDX.TabIndex = 8;
            this.btnDX.Text = "Đăng Xuất";
            this.btnDX.UseVisualStyleBackColor = false;
            this.btnDX.Click += new System.EventHandler(this.btnDX_Click);
            // 
            // txtSearchSG
            // 
            this.txtSearchSG.BackColor = System.Drawing.Color.Aqua;
            this.txtSearchSG.Location = new System.Drawing.Point(1159, 144);
            this.txtSearchSG.Name = "txtSearchSG";
            this.txtSearchSG.Size = new System.Drawing.Size(187, 22);
            this.txtSearchSG.TabIndex = 9;
            this.txtSearchSG.TextChanged += new System.EventHandler(this.txtSearchSG_TextChanged_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(1155, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Tìm kiếm theo số giường";
            // 
            // txtTimer
            // 
            this.txtTimer.AutoSize = true;
            this.txtTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTimer.Location = new System.Drawing.Point(1122, 15);
            this.txtTimer.Name = "txtTimer";
            this.txtTimer.Size = new System.Drawing.Size(62, 25);
            this.txtTimer.TabIndex = 11;
            this.txtTimer.Text = "Timer";
            // 
            // frmPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1366, 663);
            this.Controls.Add(this.txtTimer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSearchSG);
            this.Controls.Add(this.btnDX);
            this.Controls.Add(this.ChucVutxt);
            this.Controls.Add(this.dgvTTPhong);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.ForeColor = System.Drawing.Color.Black;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmPhong";
            this.Text = "frmPhong";
            this.Load += new System.EventHandler(this.frmPhong_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTTPhong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tstThemPhong;
        private System.Windows.Forms.ToolStripMenuItem tstUD;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem tstDSPD;
        private System.Windows.Forms.ToolStripMenuItem tstLSPD;
        private System.Windows.Forms.ToolStripMenuItem tstQLTK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvTTPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMA;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSG;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTN;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTG;
        private System.Windows.Forms.ToolStripMenuItem tstAdd;
        private System.Windows.Forms.ToolStripMenuItem tstUAD;
        private System.Windows.Forms.ToolStripMenuItem tstDSKH;
        private System.Windows.Forms.ToolStripMenuItem tstLSKH;
        private System.Windows.Forms.ToolStripMenuItem tstQLTKNV;
        private System.Windows.Forms.Label ChucVutxt;
        private System.Windows.Forms.Button btnDX;
        private System.Windows.Forms.TextBox txtSearchSG;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label txtTimer;
    }
}