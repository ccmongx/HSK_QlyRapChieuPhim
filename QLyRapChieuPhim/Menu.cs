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

namespace QLyRapChieuPhim
{
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private Form currentFormChild;

/*        private void OpenChildForm(Form childForm)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel_body.Controls.Add(childForm);
            panel_body.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }*/

        private void rapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Rap rap = new Rap();
            rap.Show();
        }
    }
}
