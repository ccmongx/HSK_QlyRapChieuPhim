namespace QLyRapChieuPhim
{
    partial class FrmRap
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
            this.tcVe = new System.Windows.Forms.TabControl();
            this.tabRap = new System.Windows.Forms.TabPage();
            this.tbTongGhe = new System.Windows.Forms.TextBox();
            this.tbSoPhong = new System.Windows.Forms.TextBox();
            this.tbSDT = new System.Windows.Forms.TextBox();
            this.tbDiaChi = new System.Windows.Forms.TextBox();
            this.tbTenRap = new System.Windows.Forms.TextBox();
            this.tbMaRap = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.maRap = new System.Windows.Forms.Label();
            this.btnTim = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvRap = new System.Windows.Forms.DataGridView();
            this.tabPhongChieu = new System.Windows.Forms.TabPage();
            this.tabGioChieu = new System.Windows.Forms.TabPage();
            this.tabGhe = new System.Windows.Forms.TabPage();
            this.tabVe = new System.Windows.Forms.TabPage();
            this.errorSDT = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorSoPhong = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorTongGhe = new System.Windows.Forms.ErrorProvider(this.components);
            this.tcVe.SuspendLayout();
            this.tabRap.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorSDT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorSoPhong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorTongGhe)).BeginInit();
            this.SuspendLayout();
            // 
            // tcVe
            // 
            this.tcVe.Controls.Add(this.tabRap);
            this.tcVe.Controls.Add(this.tabPhongChieu);
            this.tcVe.Controls.Add(this.tabGioChieu);
            this.tcVe.Controls.Add(this.tabGhe);
            this.tcVe.Controls.Add(this.tabVe);
            this.tcVe.Location = new System.Drawing.Point(12, 12);
            this.tcVe.Name = "tcVe";
            this.tcVe.SelectedIndex = 0;
            this.tcVe.Size = new System.Drawing.Size(779, 425);
            this.tcVe.TabIndex = 0;
            // 
            // tabRap
            // 
            this.tabRap.Controls.Add(this.tbTongGhe);
            this.tabRap.Controls.Add(this.tbSoPhong);
            this.tabRap.Controls.Add(this.tbSDT);
            this.tabRap.Controls.Add(this.tbDiaChi);
            this.tabRap.Controls.Add(this.tbTenRap);
            this.tabRap.Controls.Add(this.tbMaRap);
            this.tabRap.Controls.Add(this.label6);
            this.tabRap.Controls.Add(this.label5);
            this.tabRap.Controls.Add(this.label4);
            this.tabRap.Controls.Add(this.label3);
            this.tabRap.Controls.Add(this.label2);
            this.tabRap.Controls.Add(this.maRap);
            this.tabRap.Controls.Add(this.btnTim);
            this.tabRap.Controls.Add(this.btnXoa);
            this.tabRap.Controls.Add(this.btnSua);
            this.tabRap.Controls.Add(this.btnThem);
            this.tabRap.Controls.Add(this.panel1);
            this.tabRap.Location = new System.Drawing.Point(4, 25);
            this.tabRap.Name = "tabRap";
            this.tabRap.Padding = new System.Windows.Forms.Padding(3);
            this.tabRap.Size = new System.Drawing.Size(771, 396);
            this.tabRap.TabIndex = 0;
            this.tabRap.Text = "Rạp";
            this.tabRap.UseVisualStyleBackColor = true;
            // 
            // tbTongGhe
            // 
            this.tbTongGhe.Location = new System.Drawing.Point(572, 46);
            this.tbTongGhe.Name = "tbTongGhe";
            this.tbTongGhe.Size = new System.Drawing.Size(169, 22);
            this.tbTongGhe.TabIndex = 15;
            this.tbTongGhe.TextChanged += new System.EventHandler(this.tbTongGhe_TextChanged);
            // 
            // tbSoPhong
            // 
            this.tbSoPhong.Location = new System.Drawing.Point(572, 10);
            this.tbSoPhong.Name = "tbSoPhong";
            this.tbSoPhong.Size = new System.Drawing.Size(169, 22);
            this.tbSoPhong.TabIndex = 14;
            this.tbSoPhong.TextChanged += new System.EventHandler(this.tbSoPhong_TextChanged);
            // 
            // tbSDT
            // 
            this.tbSDT.Location = new System.Drawing.Point(314, 46);
            this.tbSDT.Name = "tbSDT";
            this.tbSDT.Size = new System.Drawing.Size(159, 22);
            this.tbSDT.TabIndex = 13;
            this.tbSDT.TextChanged += new System.EventHandler(this.tbSDT_TextChanged);
            // 
            // tbDiaChi
            // 
            this.tbDiaChi.Location = new System.Drawing.Point(314, 10);
            this.tbDiaChi.Name = "tbDiaChi";
            this.tbDiaChi.Size = new System.Drawing.Size(159, 22);
            this.tbDiaChi.TabIndex = 12;
            // 
            // tbTenRap
            // 
            this.tbTenRap.Location = new System.Drawing.Point(91, 46);
            this.tbTenRap.Name = "tbTenRap";
            this.tbTenRap.Size = new System.Drawing.Size(156, 22);
            this.tbTenRap.TabIndex = 11;
            // 
            // tbMaRap
            // 
            this.tbMaRap.Location = new System.Drawing.Point(91, 10);
            this.tbMaRap.Name = "tbMaRap";
            this.tbMaRap.Size = new System.Drawing.Size(156, 22);
            this.tbMaRap.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(479, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "Tổng Số Ghế";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(479, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Số Phòng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(259, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "SĐT";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(259, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Địa Chỉ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tên Rạp";
            // 
            // maRap
            // 
            this.maRap.AutoSize = true;
            this.maRap.Location = new System.Drawing.Point(30, 13);
            this.maRap.Name = "maRap";
            this.maRap.Size = new System.Drawing.Size(55, 16);
            this.maRap.TabIndex = 1;
            this.maRap.Text = "Mã Rạp";
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(434, 93);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(75, 23);
            this.btnTim.TabIndex = 4;
            this.btnTim.Text = "Tìm Kiếm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(293, 93);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 3;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(155, 93);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 2;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(33, 93);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 1;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvRap);
            this.panel1.Location = new System.Drawing.Point(0, 122);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(768, 275);
            this.panel1.TabIndex = 0;
            // 
            // dgvRap
            // 
            this.dgvRap.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvRap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRap.Location = new System.Drawing.Point(0, 0);
            this.dgvRap.Name = "dgvRap";
            this.dgvRap.RowHeadersWidth = 51;
            this.dgvRap.RowTemplate.Height = 24;
            this.dgvRap.Size = new System.Drawing.Size(771, 275);
            this.dgvRap.TabIndex = 0;
            this.dgvRap.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRap_CellContentClick);
            // 
            // tabPhongChieu
            // 
            this.tabPhongChieu.Location = new System.Drawing.Point(4, 25);
            this.tabPhongChieu.Name = "tabPhongChieu";
            this.tabPhongChieu.Padding = new System.Windows.Forms.Padding(3);
            this.tabPhongChieu.Size = new System.Drawing.Size(771, 396);
            this.tabPhongChieu.TabIndex = 1;
            this.tabPhongChieu.Text = "Phòng Chiếu";
            this.tabPhongChieu.UseVisualStyleBackColor = true;
            // 
            // tabGioChieu
            // 
            this.tabGioChieu.Location = new System.Drawing.Point(4, 25);
            this.tabGioChieu.Name = "tabGioChieu";
            this.tabGioChieu.Padding = new System.Windows.Forms.Padding(3);
            this.tabGioChieu.Size = new System.Drawing.Size(771, 396);
            this.tabGioChieu.TabIndex = 2;
            this.tabGioChieu.Text = "Giờ Chiếu";
            this.tabGioChieu.UseVisualStyleBackColor = true;
            // 
            // tabGhe
            // 
            this.tabGhe.Location = new System.Drawing.Point(4, 25);
            this.tabGhe.Name = "tabGhe";
            this.tabGhe.Padding = new System.Windows.Forms.Padding(3);
            this.tabGhe.Size = new System.Drawing.Size(771, 396);
            this.tabGhe.TabIndex = 3;
            this.tabGhe.Text = "Ghế";
            this.tabGhe.UseVisualStyleBackColor = true;
            // 
            // tabVe
            // 
            this.tabVe.Location = new System.Drawing.Point(4, 25);
            this.tabVe.Name = "tabVe";
            this.tabVe.Padding = new System.Windows.Forms.Padding(3);
            this.tabVe.Size = new System.Drawing.Size(771, 396);
            this.tabVe.TabIndex = 4;
            this.tabVe.Text = "Vé";
            this.tabVe.UseVisualStyleBackColor = true;
            // 
            // errorSDT
            // 
            this.errorSDT.ContainerControl = this;
            // 
            // errorSoPhong
            // 
            this.errorSoPhong.ContainerControl = this;
            // 
            // errorTongGhe
            // 
            this.errorTongGhe.ContainerControl = this;
            // 
            // FrmRap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 468);
            this.Controls.Add(this.tcVe);
            this.Name = "FrmRap";
            this.Text = "Quản Lý Rạp";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmRap_FormClosing);
            this.Load += new System.EventHandler(this.FrmRap_Load);
            this.tcVe.ResumeLayout(false);
            this.tabRap.ResumeLayout(false);
            this.tabRap.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorSDT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorSoPhong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorTongGhe)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcVe;
        private System.Windows.Forms.TabPage tabRap;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvRap;
        private System.Windows.Forms.TabPage tabPhongChieu;
        private System.Windows.Forms.TabPage tabGioChieu;
        private System.Windows.Forms.TabPage tabGhe;
        private System.Windows.Forms.TabPage tabVe;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label maRap;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbTongGhe;
        private System.Windows.Forms.TextBox tbSoPhong;
        private System.Windows.Forms.TextBox tbSDT;
        private System.Windows.Forms.TextBox tbDiaChi;
        private System.Windows.Forms.TextBox tbTenRap;
        private System.Windows.Forms.TextBox tbMaRap;
        private System.Windows.Forms.ErrorProvider errorSDT;
        private System.Windows.Forms.ErrorProvider errorSoPhong;
        private System.Windows.Forms.ErrorProvider errorTongGhe;
    }
}