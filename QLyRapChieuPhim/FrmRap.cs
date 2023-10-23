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
    }
}
