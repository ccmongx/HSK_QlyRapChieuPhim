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
            this.btnReset = new System.Windows.Forms.Button();
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
            this.btnTimRap = new System.Windows.Forms.Button();
            this.btnXoaRap = new System.Windows.Forms.Button();
            this.btnSuaRap = new System.Windows.Forms.Button();
            this.btnThemRap = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvRap = new System.Windows.Forms.DataGridView();
            this.tabPhongChieu = new System.Windows.Forms.TabPage();
            this.cbMaRap = new System.Windows.Forms.ComboBox();
            this.tbTongGheP = new System.Windows.Forms.TextBox();
            this.tbTenPhong = new System.Windows.Forms.TextBox();
            this.tbMaPhong = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnTimPhong = new System.Windows.Forms.Button();
            this.btnXoaPhong = new System.Windows.Forms.Button();
            this.btnSuaPhong = new System.Windows.Forms.Button();
            this.btnThemPhong = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvPhong = new System.Windows.Forms.DataGridView();
            this.tabGioChieu = new System.Windows.Forms.TabPage();
            this.tabGhe = new System.Windows.Forms.TabPage();
            this.tabVe = new System.Windows.Forms.TabPage();
            this.errorSDT = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorSoPhong = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorTongGheR = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorMaRap = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorMaPhong = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorTongGheP = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorMaRapP = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnResetPhong = new System.Windows.Forms.Button();
            this.tcVe.SuspendLayout();
            this.tabRap.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRap)).BeginInit();
            this.tabPhongChieu.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorSDT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorSoPhong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorTongGheR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorMaRap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorMaPhong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorTongGheP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorMaRapP)).BeginInit();
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
            this.tabRap.Controls.Add(this.btnReset);
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
            this.tabRap.Controls.Add(this.btnTimRap);
            this.tabRap.Controls.Add(this.btnXoaRap);
            this.tabRap.Controls.Add(this.btnSuaRap);
            this.tabRap.Controls.Add(this.btnThemRap);
            this.tabRap.Controls.Add(this.panel1);
            this.tabRap.Location = new System.Drawing.Point(4, 25);
            this.tabRap.Name = "tabRap";
            this.tabRap.Padding = new System.Windows.Forms.Padding(3);
            this.tabRap.Size = new System.Drawing.Size(771, 396);
            this.tabRap.TabIndex = 0;
            this.tabRap.Text = "Rạp";
            this.tabRap.UseVisualStyleBackColor = true;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(572, 93);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 16;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
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
            this.tbMaRap.TextChanged += new System.EventHandler(this.tbMaRap_TextChanged);
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
            // btnTimRap
            // 
            this.btnTimRap.Location = new System.Drawing.Point(434, 93);
            this.btnTimRap.Name = "btnTimRap";
            this.btnTimRap.Size = new System.Drawing.Size(75, 23);
            this.btnTimRap.TabIndex = 4;
            this.btnTimRap.Text = "Tìm Kiếm";
            this.btnTimRap.UseVisualStyleBackColor = true;
            this.btnTimRap.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // btnXoaRap
            // 
            this.btnXoaRap.Location = new System.Drawing.Point(293, 93);
            this.btnXoaRap.Name = "btnXoaRap";
            this.btnXoaRap.Size = new System.Drawing.Size(75, 23);
            this.btnXoaRap.TabIndex = 3;
            this.btnXoaRap.Text = "Xóa";
            this.btnXoaRap.UseVisualStyleBackColor = true;
            this.btnXoaRap.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSuaRap
            // 
            this.btnSuaRap.Location = new System.Drawing.Point(155, 93);
            this.btnSuaRap.Name = "btnSuaRap";
            this.btnSuaRap.Size = new System.Drawing.Size(75, 23);
            this.btnSuaRap.TabIndex = 2;
            this.btnSuaRap.Text = "Sửa";
            this.btnSuaRap.UseVisualStyleBackColor = true;
            this.btnSuaRap.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThemRap
            // 
            this.btnThemRap.Location = new System.Drawing.Point(33, 93);
            this.btnThemRap.Name = "btnThemRap";
            this.btnThemRap.Size = new System.Drawing.Size(75, 23);
            this.btnThemRap.TabIndex = 1;
            this.btnThemRap.Text = "Thêm";
            this.btnThemRap.UseVisualStyleBackColor = true;
            this.btnThemRap.Click += new System.EventHandler(this.btnThem_Click);
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
            this.tabPhongChieu.Controls.Add(this.btnResetPhong);
            this.tabPhongChieu.Controls.Add(this.cbMaRap);
            this.tabPhongChieu.Controls.Add(this.tbTongGheP);
            this.tabPhongChieu.Controls.Add(this.tbTenPhong);
            this.tabPhongChieu.Controls.Add(this.tbMaPhong);
            this.tabPhongChieu.Controls.Add(this.label1);
            this.tabPhongChieu.Controls.Add(this.label7);
            this.tabPhongChieu.Controls.Add(this.label10);
            this.tabPhongChieu.Controls.Add(this.label11);
            this.tabPhongChieu.Controls.Add(this.btnTimPhong);
            this.tabPhongChieu.Controls.Add(this.btnXoaPhong);
            this.tabPhongChieu.Controls.Add(this.btnSuaPhong);
            this.tabPhongChieu.Controls.Add(this.btnThemPhong);
            this.tabPhongChieu.Controls.Add(this.panel2);
            this.tabPhongChieu.Location = new System.Drawing.Point(4, 25);
            this.tabPhongChieu.Name = "tabPhongChieu";
            this.tabPhongChieu.Padding = new System.Windows.Forms.Padding(3);
            this.tabPhongChieu.Size = new System.Drawing.Size(771, 396);
            this.tabPhongChieu.TabIndex = 1;
            this.tabPhongChieu.Text = "Phòng Chiếu";
            this.tabPhongChieu.UseVisualStyleBackColor = true;
            // 
            // cbMaRap
            // 
            this.cbMaRap.FormattingEnabled = true;
            this.cbMaRap.Location = new System.Drawing.Point(487, 39);
            this.cbMaRap.Name = "cbMaRap";
            this.cbMaRap.Size = new System.Drawing.Size(121, 24);
            this.cbMaRap.TabIndex = 33;
            // 
            // tbTongGheP
            // 
            this.tbTongGheP.Location = new System.Drawing.Point(487, 11);
            this.tbTongGheP.Name = "tbTongGheP";
            this.tbTongGheP.Size = new System.Drawing.Size(169, 22);
            this.tbTongGheP.TabIndex = 31;
            // 
            // tbTenPhong
            // 
            this.tbTenPhong.Location = new System.Drawing.Point(159, 41);
            this.tbTenPhong.Name = "tbTenPhong";
            this.tbTenPhong.Size = new System.Drawing.Size(156, 22);
            this.tbTenPhong.TabIndex = 28;
            // 
            // tbMaPhong
            // 
            this.tbMaPhong.Location = new System.Drawing.Point(159, 11);
            this.tbMaPhong.Name = "tbMaPhong";
            this.tbMaPhong.Size = new System.Drawing.Size(156, 22);
            this.tbMaPhong.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(387, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 16);
            this.label1.TabIndex = 26;
            this.label1.Text = "Tổng Số Ghế";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(387, 41);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 16);
            this.label7.TabIndex = 25;
            this.label7.Text = "Mã Rạp";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(80, 44);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 16);
            this.label10.TabIndex = 22;
            this.label10.Text = "Tên Phòng";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(80, 14);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(68, 16);
            this.label11.TabIndex = 17;
            this.label11.Text = "Mã Phòng";
            // 
            // btnTimPhong
            // 
            this.btnTimPhong.Location = new System.Drawing.Point(435, 88);
            this.btnTimPhong.Name = "btnTimPhong";
            this.btnTimPhong.Size = new System.Drawing.Size(75, 23);
            this.btnTimPhong.TabIndex = 21;
            this.btnTimPhong.Text = "Tìm Kiếm";
            this.btnTimPhong.UseVisualStyleBackColor = true;
            this.btnTimPhong.Click += new System.EventHandler(this.btnTimPhong_Click);
            // 
            // btnXoaPhong
            // 
            this.btnXoaPhong.Location = new System.Drawing.Point(294, 88);
            this.btnXoaPhong.Name = "btnXoaPhong";
            this.btnXoaPhong.Size = new System.Drawing.Size(75, 23);
            this.btnXoaPhong.TabIndex = 20;
            this.btnXoaPhong.Text = "Xóa";
            this.btnXoaPhong.UseVisualStyleBackColor = true;
            this.btnXoaPhong.Click += new System.EventHandler(this.btnXoaPhong_Click);
            // 
            // btnSuaPhong
            // 
            this.btnSuaPhong.Location = new System.Drawing.Point(156, 88);
            this.btnSuaPhong.Name = "btnSuaPhong";
            this.btnSuaPhong.Size = new System.Drawing.Size(75, 23);
            this.btnSuaPhong.TabIndex = 19;
            this.btnSuaPhong.Text = "Sửa";
            this.btnSuaPhong.UseVisualStyleBackColor = true;
            this.btnSuaPhong.Click += new System.EventHandler(this.btnSuaPhong_Click);
            // 
            // btnThemPhong
            // 
            this.btnThemPhong.Location = new System.Drawing.Point(34, 88);
            this.btnThemPhong.Name = "btnThemPhong";
            this.btnThemPhong.Size = new System.Drawing.Size(75, 23);
            this.btnThemPhong.TabIndex = 18;
            this.btnThemPhong.Text = "Thêm";
            this.btnThemPhong.UseVisualStyleBackColor = true;
            this.btnThemPhong.Click += new System.EventHandler(this.btnThemPhong_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvPhong);
            this.panel2.Location = new System.Drawing.Point(1, 117);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(768, 275);
            this.panel2.TabIndex = 16;
            // 
            // dgvPhong
            // 
            this.dgvPhong.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhong.Location = new System.Drawing.Point(0, 0);
            this.dgvPhong.Name = "dgvPhong";
            this.dgvPhong.RowHeadersWidth = 51;
            this.dgvPhong.RowTemplate.Height = 24;
            this.dgvPhong.Size = new System.Drawing.Size(771, 275);
            this.dgvPhong.TabIndex = 0;
            this.dgvPhong.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPhong_CellContentClick);
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
            // errorTongGheR
            // 
            this.errorTongGheR.ContainerControl = this;
            // 
            // errorMaRap
            // 
            this.errorMaRap.ContainerControl = this;
            // 
            // errorMaPhong
            // 
            this.errorMaPhong.ContainerControl = this;
            // 
            // errorTongGheP
            // 
            this.errorTongGheP.ContainerControl = this;
            // 
            // errorMaRapP
            // 
            this.errorMaRapP.ContainerControl = this;
            // 
            // btnResetPhong
            // 
            this.btnResetPhong.Location = new System.Drawing.Point(581, 88);
            this.btnResetPhong.Name = "btnResetPhong";
            this.btnResetPhong.Size = new System.Drawing.Size(75, 23);
            this.btnResetPhong.TabIndex = 34;
            this.btnResetPhong.Text = "Reset";
            this.btnResetPhong.UseVisualStyleBackColor = true;
            this.btnResetPhong.Click += new System.EventHandler(this.btnResetPhong_Click);
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
            this.tabPhongChieu.ResumeLayout(false);
            this.tabPhongChieu.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorSDT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorSoPhong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorTongGheR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorMaRap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorMaPhong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorTongGheP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorMaRapP)).EndInit();
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
        private System.Windows.Forms.Button btnTimRap;
        private System.Windows.Forms.Button btnXoaRap;
        private System.Windows.Forms.Button btnSuaRap;
        private System.Windows.Forms.Button btnThemRap;
        private System.Windows.Forms.Label maRap;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbTongGhe;
        private System.Windows.Forms.TextBox tbSoPhong;
        private System.Windows.Forms.TextBox tbTenRap;
        private System.Windows.Forms.TextBox tbMaRap;
        private System.Windows.Forms.ErrorProvider errorSDT;
        private System.Windows.Forms.ErrorProvider errorSoPhong;
        private System.Windows.Forms.ErrorProvider errorTongGheR;
        private System.Windows.Forms.ErrorProvider errorMaRap;
        private System.Windows.Forms.TextBox tbTongGheP;
        private System.Windows.Forms.TextBox tbTenPhong;
        private System.Windows.Forms.TextBox tbMaPhong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnTimPhong;
        private System.Windows.Forms.Button btnXoaPhong;
        private System.Windows.Forms.Button btnSuaPhong;
        private System.Windows.Forms.Button btnThemPhong;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvPhong;
        private System.Windows.Forms.TextBox tbSDT;
        private System.Windows.Forms.TextBox tbDiaChi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ErrorProvider errorMaPhong;
        private System.Windows.Forms.ErrorProvider errorTongGheP;
        private System.Windows.Forms.ErrorProvider errorMaRapP;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.ComboBox cbMaRap;
        private System.Windows.Forms.Button btnResetPhong;
    }
}