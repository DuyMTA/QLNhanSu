using QL_NHANSU.Data;
using QL_NHANSU.GUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_NHANSU
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Visible=true;
        }

        private void hệThốngToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btnDangky_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dangky dangky = new Dangky();
            dangky.Visible = true;
        }

        private void btnDangxuat_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Login lg = new Login();
            lg.Visible = true;
        }

        private void NhanVienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            NhanVienNV add = new NhanVienNV();
            add.Visible = true;
        }

        private void DuAn_Click(object sender, EventArgs e)
        {
            this.Hide();
            DuAnNV da = new DuAnNV();
            da.Visible = true;
        }

        private void phòngBanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            PB pb = new PB();
            pb.Visible = true;
        }
    }
}
