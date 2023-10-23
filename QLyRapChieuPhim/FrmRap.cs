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
            GetAllRap();
        }

        public void GetAllRap()
        {
            string sqlSelect = "select * from tblRap";
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

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (check())
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

        private void FrmRap_FormClosing(object sender, FormClosingEventArgs e)
        {
            conn.Close();
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
            string sqlSearch = "Select * from tblRap  where sMaRap Like '%'+@sMaRap+'%'";
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
        }

        bool check()
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
            /*                string input = tbSDT.Text;

                // Sử dụng biểu thức chính quy để kiểm tra số điện thoại
                string pattern = @"^0[0-9]{10,}$"; // Bắt đầu bằng 0 và có ít nhất 11 số (10 số sau số 0)

                if (Regex.IsMatch(input, pattern))
                {
                    errorSDT.Clear(); // Xóa lỗi nếu số điện thoại hợp lệ
                }
                else
                {
                    errorSDT.SetError(tbSDT, "Số điện thoại không hợp lệ!");
                }*/

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
                errorTongGhe.SetError(tbTongGhe, "Tổng số ghế phải là số!");
            }
            else if (tongGhe < 100)
            {
                errorTongGhe.SetError(tbTongGhe, "Tổng số ghế không được ít hơn 100!");
            }
            else
            {
                errorTongGhe.Clear();
            }
        }
    }
}
