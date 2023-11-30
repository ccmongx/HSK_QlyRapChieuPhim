using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using QLyRapChieuPhim.Properties;
using System.Configuration;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace QLyRapChieuPhim
{
    public partial class FrmRap : Form
    {
        public FrmRap()
        {
            InitializeComponent();
        }

        SqlConnection conn;

        private void FrmRap_Load(object sender, EventArgs e)
        {
            string conString = ConfigurationManager.ConnectionStrings["QLRP"].ConnectionString.ToString();
            conn = new SqlConnection(conString);
            conn.Open();
            dgvRap.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPhong.AutoSizeColumnsMode= DataGridViewAutoSizeColumnsMode.Fill;
            GetAllRap();
            GetAllPhong();
            GetAllGioChieu();
            GetAllGhe();
            hiencombobox();
            hiencomboboxGC();
            hiencomboboxGhe();
            hiencomboboxVe();
        }
        private void FrmRap_FormClosing(object sender, FormClosingEventArgs e)
        {
            conn.Close();
        }


// Rạp ----------------------------------------------------------------------------------------------------------------------
        // Load data dgv
        public void GetAllRap()
        {
            string sqlSelect = "select * from view_rap";
            SqlCommand cmd = new SqlCommand(sqlSelect, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dgvRap.DataSource = dt;
        }

        private void dgvRap_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dgvRap.CurrentRow.Index;
            tbMaRap.Text = dgvRap.Rows[i].Cells[0].Value.ToString();
            tbTenRap.Text = dgvRap.Rows[i].Cells[1].Value.ToString();
            tbDiaChi.Text = dgvRap.Rows[i].Cells[2].Value.ToString();
            tbSDT.Text = dgvRap.Rows[i].Cells[3].Value.ToString();
            tbSoPhong.Text = dgvRap.Rows[i].Cells[4].Value.ToString();
            tbTongGhe.Text = dgvRap.Rows[i].Cells[5].Value.ToString();
        }

        // Functions
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (checkNullRap())
            {
                string sqlInsert = "insert into tblRap values(@sMaRap,@sTenRap,@sDiaChi,@sSDT,@iSoPhong,@iTongSoGhe)";
                SqlCommand cmd = new SqlCommand(sqlInsert, conn);
                cmd.Parameters.AddWithValue("sMaRap", tbMaRap.Text);
                cmd.Parameters.AddWithValue("sTenRap", tbTenRap.Text);
                cmd.Parameters.AddWithValue("sDiaChi", tbDiaChi.Text);
                cmd.Parameters.AddWithValue("sSDT", tbSDT.Text);
                cmd.Parameters.AddWithValue("iSoPhong", tbSoPhong.Text);
                cmd.Parameters.AddWithValue("iTongSoGhe", tbTongGhe.Text);
                cmd.ExecuteNonQuery();
                GetAllRap();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sqlUpdate = "update tblRap set sTenRap=@sTenRap,sDiaChi=@sDiaChi,sSDT=@sSDT,iSoPhong=@iSoPhong,iTongSoGhe=@iTongSoGhe where sMaRap=@sMaRap";
            SqlCommand cmd = new SqlCommand(sqlUpdate, conn);
            cmd.Parameters.AddWithValue("sMaRap", tbMaRap.Text);
            cmd.Parameters.AddWithValue("sTenRap", tbTenRap.Text);
            cmd.Parameters.AddWithValue("sDiaChi", tbDiaChi.Text);
            cmd.Parameters.AddWithValue("sSDT", tbSDT.Text);
            cmd.Parameters.AddWithValue("iSoPhong", tbSoPhong.Text);
            cmd.Parameters.AddWithValue("iTongSoGhe", tbTongGhe.Text);
            cmd.ExecuteNonQuery();
            GetAllRap();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sqlDelete = "delete from tblRap  where sMaRap=@sMaRap";
            SqlCommand cmd = new SqlCommand(sqlDelete, conn);
            cmd.Parameters.AddWithValue("sMaRap", tbMaRap.Text);
            cmd.Parameters.AddWithValue("sTenRap", tbTenRap.Text);
            cmd.Parameters.AddWithValue("sDiaChi", tbDiaChi.Text);
            cmd.Parameters.AddWithValue("sSDT", tbSDT.Text);
            cmd.Parameters.AddWithValue("iSoPhong", tbSoPhong.Text);
            cmd.Parameters.AddWithValue("iTongSoGhe", tbTongGhe.Text);
            cmd.ExecuteNonQuery();
            GetAllRap();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            string sqlSearch = "SELECT * FROM tblRap WHERE 1=1";
            if (!string.IsNullOrWhiteSpace(tbMaRap.Text))
                sqlSearch += " AND sMaRap LIKE '%' + @sMaRap + '%'";
            if (!string.IsNullOrWhiteSpace(tbTenRap.Text))
                sqlSearch += " AND sTenRap LIKE '%' + @sTenRap + '%'";
            if (!string.IsNullOrWhiteSpace(tbDiaChi.Text))
                sqlSearch += " AND sDiaChi LIKE '%' + @sDiaChi + '%'";
            if (!string.IsNullOrWhiteSpace(tbSDT.Text))
                sqlSearch += " AND sSDT LIKE '%' + @sSDT + '%'";
            if (!string.IsNullOrWhiteSpace(tbSoPhong.Text))
                sqlSearch += " AND iSoPhong LIKE '%' + @iSoPhong + '%'";
            if (!string.IsNullOrWhiteSpace(tbTongGhe.Text))
                sqlSearch += " AND iTongSoGhe LIKE '%' + @iTongSoGhe + '%'";
            SqlCommand cmd = new SqlCommand(sqlSearch, conn);
            cmd.Parameters.AddWithValue("sMaRap", tbMaRap.Text);
            cmd.Parameters.AddWithValue("sTenRap", tbTenRap.Text);
            cmd.Parameters.AddWithValue("sDiaChi", tbDiaChi.Text);
            cmd.Parameters.AddWithValue("sSDT", tbSDT.Text);
            cmd.Parameters.AddWithValue("iSoPhong", tbSoPhong.Text);
            cmd.Parameters.AddWithValue("iTongSoGhe", tbTongGhe.Text);
            cmd.ExecuteNonQuery();
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dgvRap.DataSource = dt;

            // thông báo nếu không có kết quả tìm kiếm
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Không có rạp cần tìm!");
            }
            else
            {
                dgvRap.DataSource = dt;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            tbMaRap.Text = "";
            tbTenRap.Text = "";
            tbTongGhe.Text = "";
            tbDiaChi.Text = "";
            tbSDT.Text = "";
            tbSoPhong.Text = "";
        }

        private void btnInRap_Click(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand lenh = new SqlCommand("select * from tblRap", conn);
            lenh.CommandText = "select * from tblRap";
            lenh.Parameters.Clear();
            lenh.Parameters.AddWithValue("@MaRap", tbMaRap.Text);
            da.SelectCommand = lenh;
            DataTable dt = new DataTable("in");
            da.Fill(dt);
            crRap crRap = new crRap();
            crRap.SetDataSource(dt);
            rptRapfrm f = new rptRapfrm();
            
            f.crystalReportViewer1.ReportSource = crRap;
            f.ShowDialog();

        }

        // Validate
        bool checkNullRap()
        {
            if (tbMaRap.Text == "")
            {
                MessageBox.Show("KHÔNG ĐƯỢC ĐỂ TRỐNG!", "Thông Báo");
                tbMaRap.Focus();
                return false;
            }
            if (tbTenRap.Text == "")
            {
                MessageBox.Show("KHÔNG ĐƯỢC ĐỂ TRỐNG!", "Thông Báo");
                tbTenRap.Focus();
                return false;
            }
            if (tbDiaChi.Text == "")
            {
                MessageBox.Show("KHÔNG ĐƯỢC ĐỂ TRỐNG!", "Thông Báo");
                tbDiaChi.Focus();
                return false;
            }
            if (tbSDT.Text == "")
            {
                MessageBox.Show("KHÔNG ĐƯỢC ĐỂ TRỐNG!", "Thông Báo");
                tbSDT.Focus();
                return false;
            }
            if (tbSoPhong.Text == "")
            {
                MessageBox.Show("KHÔNG ĐƯỢC ĐỂ TRỐNG!", "Thông Báo");
                tbSoPhong.Focus();
                return false;
            }
            if (tbTongGhe.Text == "")
            {
                MessageBox.Show("KHÔNG ĐƯỢC ĐỂ TRỐNG!", "Thông Báo");
                tbTongGhe.Focus();
                return false;
            }
            return true;
        }

        private void tbSDT_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(tbSDT.Text, out int sdt))
            {
                errorSDT.SetError(tbSDT, "Số điện thoại phải là số!");
            }
            else if (!(tbSDT.Text.StartsWith("0")))
            {
                errorSDT.SetError(tbSDT, "SĐT phải bắt đầu bằng 0!");
            }
            else if (tbSDT.Text.Length < 10)
            {
                errorSDT.SetError(tbSDT, "SĐT phải có 10 chữ số!");
            }
            else
            {
                errorSDT.Clear();
            }
        }

        private void tbSoPhong_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(tbSoPhong.Text, out int soPhong))
            {
                errorSoPhong.SetError(tbSoPhong, "Số phòng phải là số!");
            }
            else if (soPhong < 3)
            {
                errorSoPhong.SetError(tbSoPhong, "Một rạp phải có ít nhất 3 phòng!");
            }
            else
            {
                errorSoPhong.Clear();
            }
        }

        private void tbTongGhe_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(tbTongGhe.Text, out int tongGhe))
            {
                errorTongGheR.SetError(tbTongGhe, "Tổng số ghế phải là số!");
            }
            else if (tongGhe < 100)
            {
                errorTongGheR.SetError(tbTongGhe, "Tổng số ghế không được ít hơn 100!");
            }
            else
            {
                errorTongGheR.Clear();
            }
        }

        private bool isMaRapExists(string maRap)
        {
            string sqlCheck = "SELECT COUNT(*) FROM tblRap WHERE sMaRap = @sMaRap";
            SqlCommand cmd = new SqlCommand(sqlCheck, conn);
            cmd.Parameters.AddWithValue("sMaRap", maRap);
            int count = (int)cmd.ExecuteScalar();
            return count > 0;
        }

        private void tbMaRap_TextChanged(object sender, EventArgs e)
        {
            string maRap = tbMaRap.Text;
            if (isMaRapExists(maRap))
            {
                errorMaRap.SetError(tbMaRap, "Mã rạp đã tồn tại!");
            }
        }


// Phòng Chiếu ----------------------------------------------------------------------------------------------------------------------
        // Load data dgv
        public void GetAllPhong()
        {
            string sqlSelect = "select * from tblPhongChieu";
            SqlCommand cmd = new SqlCommand(sqlSelect, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dgvPhong.DataSource = dt;
        }

        private void dgvPhong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dgvPhong.CurrentRow.Index;
            tbMaPhong.Text = dgvPhong.Rows[i].Cells[0].Value.ToString();
            tbTenPhong.Text = dgvPhong.Rows[i].Cells[1].Value.ToString();
            tbTongGheP.Text = dgvPhong.Rows[i].Cells[2].Value.ToString();
            cbMaRap.Text = dgvPhong.Rows[i].Cells[3].Value.ToString();
        }

        // Load data combobox
        private DataTable layDSMR()
        {
            string conString = ConfigurationManager.ConnectionStrings["QLRP"].ConnectionString.ToString();
            using (SqlConnection cnn = new SqlConnection(conString))
            {
                using (SqlCommand cmd = new SqlCommand("select*from tblRap", cnn))
                {
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataAdapter ad = new SqlDataAdapter(cmd))
                    {
                        DataTable tb = new DataTable();
                        ad.Fill(tb);
                        return tb;
                    }
                }
            }
        }

        private void hiencombobox()
        {
            DataTable t = layDSMR();
            DataView v = new DataView(t);
            v.Sort = "sMaRap";
            cbMaRap.DataSource = v;
            cbMaRap.DisplayMember = "sMaRap";
            cbMaRap.ValueMember = "sMaRap";
        }

        // Validate
        bool checkNullPhong()
        {
            if (tbMaPhong.Text == "")
            {
                MessageBox.Show("KHÔNG ĐƯỢC ĐỂ TRỐNG!", "Thông Báo");
                tbMaPhong.Focus();
                return false;
            }
            if (tbTenPhong.Text == "")
            {
                MessageBox.Show("KHÔNG ĐƯỢC ĐỂ TRỐNG!", "Thông Báo");
                tbTenPhong.Focus();
                return false;
            }
            if (tbTongGheP.Text == "")
            {
                MessageBox.Show("KHÔNG ĐƯỢC ĐỂ TRỐNG!", "Thông Báo");
                tbTongGheP.Focus();
                return false;
            }
            return true;
        }

        private bool isMaPhongExists(string maPhong)
        {
            string sqlCheck = "SELECT COUNT(*) FROM tblPhongChieu WHERE sMaPhong=@sMaPhong";
            SqlCommand cmd = new SqlCommand(sqlCheck, conn);
            cmd.Parameters.AddWithValue("sMaPhong", maPhong);
            int count = (int)cmd.ExecuteScalar();
            return count > 0;
        }

        private void tbMaPhong_TextChanged(object sender, EventArgs e)
        {
            string maPhong = tbMaPhong.Text;
            if (isMaPhongExists(maPhong))
            {
                errorMaPhong.SetError(tbMaPhong, "Mã phòng đã tồn tại!");
            }
        }


        // Functions
        private void btnThemPhong_Click(object sender, EventArgs e)
        {
            if (checkNullPhong())
            {
                string sqlInsert = "insert into tblPhongChieu values(@sMaPhong,@iTenPhong,@iTongSoGhe,@sMaRap)";
                SqlCommand cmd = new SqlCommand(sqlInsert, conn);
                cmd.Parameters.AddWithValue("sMaPhong", tbMaPhong.Text);
                cmd.Parameters.AddWithValue("iTenPhong", tbTenPhong.Text);
                cmd.Parameters.AddWithValue("iTongSoGhe", tbTongGheP.Text);
                cmd.Parameters.AddWithValue("sMaRap", cbMaRap.Text);
                cmd.ExecuteNonQuery();
                GetAllPhong();
                GetAllRap();
                GetAllGioChieu();
            }

        }

        private void btnSuaPhong_Click(object sender, EventArgs e)
        {
            string sqlUpdate = "update tblPhongChieu set iTenPhong=@iTenPhong,iTongSoGhe=@iTongSoGhe,sMaRap=@sMaRap where sMaPhong=@sMaPhong";
            SqlCommand cmd = new SqlCommand(sqlUpdate, conn);
            cmd.Parameters.AddWithValue("sMaPhong", tbMaPhong.Text);
            cmd.Parameters.AddWithValue("iTenPhong", tbTenPhong.Text);
            cmd.Parameters.AddWithValue("iTongSoGhe", tbTongGheP.Text);
            cmd.Parameters.AddWithValue("sMaRap", cbMaRap.Text);
            cmd.ExecuteNonQuery();
            GetAllRap();
            GetAllPhong();
        }

        private void btnXoaPhong_Click(object sender, EventArgs e)
        {
            string sqlDelete = "delete from tblPhongChieu  where sMaPhong=@sMaPhong";
            SqlCommand cmd = new SqlCommand(sqlDelete, conn);
            cmd.Parameters.AddWithValue("sMaPhong", tbMaPhong.Text);
            cmd.Parameters.AddWithValue("iTenPhong", tbTenPhong.Text);
            cmd.Parameters.AddWithValue("iTongSoGhe", tbTongGheP.Text);
            cmd.Parameters.AddWithValue("sMaRap", cbMaRap.Text);
            cmd.ExecuteNonQuery();
            GetAllRap();
            GetAllPhong();
        }

        private void btnTimPhong_Click(object sender, EventArgs e)
        {
            string sqlSearch = "SELECT * FROM tblPhongChieu WHERE 1=1";
            if (!string.IsNullOrWhiteSpace(tbMaPhong.Text))
                sqlSearch += " AND sMaPhong LIKE '%' + @sMaPhong + '%'";
            if (!string.IsNullOrWhiteSpace(tbTenPhong.Text))
                sqlSearch += " AND iTenPhong LIKE '%' + @iTenPhong + '%'";
            if (!string.IsNullOrWhiteSpace(tbTongGheP.Text))
                sqlSearch += " AND iTongSoGhe LIKE '%' + @iTongSoGhe + '%'";
            SqlCommand cmd = new SqlCommand(sqlSearch, conn);
            cmd.Parameters.AddWithValue("sMaPhong", tbMaPhong.Text);
            cmd.Parameters.AddWithValue("iTenPhong", tbTenPhong.Text);
            cmd.Parameters.AddWithValue("iTongSoGhe", tbTongGheP.Text);
            cmd.Parameters.AddWithValue("sMaRap", cbMaRap.Text);
            cmd.ExecuteNonQuery();
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dgvPhong.DataSource = dt;

            // thông báo nếu không có kết quả tìm kiếm
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Không có phòng cần tìm!");
            }
            else
            {
                dgvPhong.DataSource = dt;
            }
        }

        private void btnResetPhong_Click(object sender, EventArgs e)
        {
            tbMaPhong.Text = "";
            tbTenPhong.Text = "";
            tbTongGheP.Text = "";
            cbMaRap.Text = "";
        }

        private void tbTongGheP_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(tbTongGheP.Text, out int tongGhe))
            {
                errorTongGheP.SetError(tbTongGheP, "Tổng số ghế phải là số!");
            }
            else if (tongGhe < 100)
            {
                errorTongGheP.SetError(tbTongGheP, "Tổng số ghế không được ít hơn 100!");
            }
            else
            {
                errorTongGheP.Clear();
            }

        }


// Giờ chiếu ----------------------------------------------------------------------------------------------------------------------
        // Load data dgv
        public void GetAllGioChieu()
        {
            string sqlSelect = "select * from tblGioChieu";
            SqlCommand cmd = new SqlCommand(sqlSelect, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dgvGioChieu.DataSource = dt;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dgvGioChieu.CurrentRow.Index;
            tbMaGioChieu.Text = dgvGioChieu.Rows[i].Cells[0].Value.ToString();
            cbMaRapGC.Text = dgvGioChieu.Rows[i].Cells[1].Value.ToString();
            timeGC.Text = dgvGioChieu.Rows[i].Cells[2].Value.ToString();
        }


        // Load data combobox
        private void hiencomboboxGC()
        {
            DataTable t = layDSMR();
            DataView v = new DataView(t);
            v.Sort = "sMaRap";
            cbMaRapGC.DataSource = v;
            cbMaRapGC.DisplayMember = "sMaRap";
            cbMaRapGC.ValueMember = "sMaRap";
        }


        // Validate
        bool checkNullGC()
        {
            if (tbMaGioChieu.Text == "")
            {
                MessageBox.Show("KHÔNG ĐƯỢC ĐỂ TRỐNG!", "Thông Báo");
                tbMaPhong.Focus();
                return false;
            }
            return true;
        }


        // Functions
        private void btn_ThemGC_Click(object sender, EventArgs e)
        {
            if (checkNullGC())
            {
                string sqlInsert = "insert into tblGioChieu values(@sMaGioChieu,@sMaRap,@tGioChieu)";
                SqlCommand cmd = new SqlCommand(sqlInsert, conn);
                cmd.Parameters.AddWithValue("sMaGioChieu", tbMaGioChieu.Text);
                cmd.Parameters.AddWithValue("sMaRap", cbMaRapGC.Text);
                cmd.Parameters.AddWithValue("tGioChieu", timeGC.Text);
                cmd.ExecuteNonQuery();
                GetAllPhong();
                GetAllRap();
                GetAllGioChieu();
            }

        }


// Ghế ----------------------------------------------------------------------------------------------------------------------
        // Load data dgv
        public void GetAllGhe()
        {
            string sqlSelect = "select * from tblTrangThaiGhe";
            SqlCommand cmd = new SqlCommand(sqlSelect, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dgvGhe.DataSource = dt;
        }

        private void dgvGhe_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        // Load data combobox
        private void hiencomboboxGhe()
        {
            DataTable t = layDSMR();
            DataView v = new DataView(t);
            v.Sort = "sMaRap";
            cbMaRapGhe.DataSource = v;
            cbMaRapGhe.DisplayMember = "sMaRap";
            cbMaRapGhe.ValueMember = "sMaRap";
        }

        // Validate
        bool checkNullGhe()
        {
            if (tbMaGhe.Text == "")
            {
                MessageBox.Show("KHÔNG ĐƯỢC ĐỂ TRỐNG!", "Thông Báo");
                tbMaPhong.Focus();
                return false;
            }
            if (tbMaPhongGhe.Text == "")
            {
                MessageBox.Show("KHÔNG ĐƯỢC ĐỂ TRỐNG!", "Thông Báo");
                tbMaPhong.Focus();
                return false;
            }
            return true;
        }


        // Functions
        private void button10_Click(object sender, EventArgs e)
        {
            if (checkNullGhe())
            {
                string sqlInsert = "insert into tblTrangThaiGhe values(@sMaPhong,@sMaGhe,@sTrangThai,@sMaRap)";
                SqlCommand cmd = new SqlCommand(sqlInsert, conn);
                cmd.Parameters.AddWithValue("sMaPhong", tbMaPhongGhe.Text);
                cmd.Parameters.AddWithValue("sMaGhe", tbMaGhe.Text);
                cmd.Parameters.AddWithValue("sTrangThai", cbTrangThaiGhe.Text);
                cmd.Parameters.AddWithValue("sMaRap", cbMaRapGhe.Text);
                cmd.ExecuteNonQuery();
                GetAllPhong();
                GetAllRap();
                GetAllGioChieu();
                GetAllGhe();
            }

        }


// Vé ----------------------------------------------------------------------------------------------------------------------
        // Load data dgv
        public void GetAllVe()
        {
            string sqlSelect = "select * from tblVe";
            SqlCommand cmd = new SqlCommand(sqlSelect, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dgvVe.DataSource = dt;
        }

        private void dgvVe_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        // Load data combobox
        private DataTable layDSMG()
        {
            string conString = ConfigurationManager.ConnectionStrings["QLRP"].ConnectionString.ToString();
            using (SqlConnection cnn = new SqlConnection(conString))
            {
                using (SqlCommand cmd = new SqlCommand("select*from tblTrangThaiGhe", cnn))
                {
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataAdapter ad = new SqlDataAdapter(cmd))
                    {
                        DataTable tb = new DataTable();
                        ad.Fill(tb);
                        return tb;
                    }
                }
            }
        }
        private void hiencomboboxVe()
        {
            DataTable t = layDSMG();
            DataView v = new DataView(t);
            v.Sort = "sMaGhe";
            cbMaGhe.DataSource = v;
            cbMaGhe.DisplayMember = "sMaGhe";
            cbMaGhe.ValueMember = "sMaGhe";
        }


    }
}
