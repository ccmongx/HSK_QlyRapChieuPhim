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
            hiencombobox();
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

        // Function
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

        // Function
        private void btnThemPhong_Click(object sender, EventArgs e)
        {
            if (checkNullPhong())
            {
                string sqlInsert = "insert into tblPhongChieu values(@sMaPhong,@iTenPhong,@iTongSoGhe,@sMaRap)";
                SqlCommand cmd = new SqlCommand(sqlInsert, conn);
                cmd.Parameters.AddWithValue("sMaPhong", tbMaPhong.Text);
                cmd.Parameters.AddWithValue("iTenPhong", tbTenPhong.Text);
                cmd.Parameters.AddWithValue("iTongSoGhe", tbTongGheP.Text);
                cmd.ExecuteNonQuery();
                GetAllPhong();
                GetAllRap();
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
    }
}
