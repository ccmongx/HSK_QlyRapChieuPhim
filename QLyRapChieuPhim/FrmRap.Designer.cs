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
            this.tcVe = new System.Windows.Forms.TabControl();
            this.tabRap = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvRap = new System.Windows.Forms.DataGridView();
            this.tabPhongChieu = new System.Windows.Forms.TabPage();
            this.tabGioChieu = new System.Windows.Forms.TabPage();
            this.tabGhe = new System.Windows.Forms.TabPage();
            this.tabVe = new System.Windows.Forms.TabPage();
            this.tcVe.SuspendLayout();
            this.tabRap.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRap)).BeginInit();
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
            this.tabRap.Controls.Add(this.panel1);
            this.tabRap.Location = new System.Drawing.Point(4, 25);
            this.tabRap.Name = "tabRap";
            this.tabRap.Padding = new System.Windows.Forms.Padding(3);
            this.tabRap.Size = new System.Drawing.Size(771, 396);
            this.tabRap.TabIndex = 0;
            this.tabRap.Text = "Rạp";
            this.tabRap.UseVisualStyleBackColor = true;
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
            this.dgvRap.Size = new System.Drawing.Size(768, 275);
            this.dgvRap.TabIndex = 0;
            // 
            // tabPhongChieu
            // 
            this.tabPhongChieu.Location = new System.Drawing.Point(4, 25);
            this.tabPhongChieu.Name = "tabPhongChieu";
            this.tabPhongChieu.Padding = new System.Windows.Forms.Padding(3);
            this.tabPhongChieu.Size = new System.Drawing.Size(768, 397);
            this.tabPhongChieu.TabIndex = 1;
            this.tabPhongChieu.Text = "Phòng Chiếu";
            this.tabPhongChieu.UseVisualStyleBackColor = true;
            // 
            // tabGioChieu
            // 
            this.tabGioChieu.Location = new System.Drawing.Point(4, 25);
            this.tabGioChieu.Name = "tabGioChieu";
            this.tabGioChieu.Padding = new System.Windows.Forms.Padding(3);
            this.tabGioChieu.Size = new System.Drawing.Size(768, 397);
            this.tabGioChieu.TabIndex = 2;
            this.tabGioChieu.Text = "Giờ Chiếu";
            this.tabGioChieu.UseVisualStyleBackColor = true;
            // 
            // tabGhe
            // 
            this.tabGhe.Location = new System.Drawing.Point(4, 25);
            this.tabGhe.Name = "tabGhe";
            this.tabGhe.Padding = new System.Windows.Forms.Padding(3);
            this.tabGhe.Size = new System.Drawing.Size(768, 397);
            this.tabGhe.TabIndex = 3;
            this.tabGhe.Text = "Ghế";
            this.tabGhe.UseVisualStyleBackColor = true;
            // 
            // tabVe
            // 
            this.tabVe.Location = new System.Drawing.Point(4, 25);
            this.tabVe.Name = "tabVe";
            this.tabVe.Padding = new System.Windows.Forms.Padding(3);
            this.tabVe.Size = new System.Drawing.Size(768, 397);
            this.tabVe.TabIndex = 4;
            this.tabVe.Text = "Vé";
            this.tabVe.UseVisualStyleBackColor = true;
            // 
            // FrmRap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 468);
            this.Controls.Add(this.tcVe);
            this.Name = "FrmRap";
            this.Text = "Quản Lý Rạp";
            this.tcVe.ResumeLayout(false);
            this.tabRap.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRap)).EndInit();
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
    }
}