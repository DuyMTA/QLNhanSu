using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QL_NHANSU.Data;

namespace QL_NHANSU.GUI
{
    public partial class NhanVienNV : Form
    {
        MyContext context = new MyContext();
        NhanVien nv = new NhanVien();
        public NhanVienNV()
        {
            InitializeComponent();
            init();
        }
        private void init()
        {
            var TBNV = context.NhanViens.ToList();
            dgvNV.DataSource = TBNV;
        }
        private void display()
        {
            int row = dgvNV.CurrentCell.RowIndex;
            var temp = dgvNV.Rows[row];
            txtMaNV.Text = temp.Cells[0].Value.ToString();
            txtTen.Text = temp.Cells[1].Value.ToString();
            dtNS.Value = Convert.ToDateTime(temp.Cells[2].Value);
            txtdiachi.Text = temp.Cells[3].Value.ToString();
            comboBox1.Text = temp.Cells[4].Value.ToString();
            txtluong.Text = temp.Cells[5].Value.ToString();
            txtPhong.Text = temp.Cells[6].Value.ToString();
            try
            {
                var temp1 = temp.Cells[7].Value;
                if (temp1 == null) { txtNgGS.Text ="Không có"; }
                else { txtNgGS.Text = temp1.ToString(); }
            }
            catch { }
            txtSonv.Text = temp.Cells[8].Value.ToString();
            txtEmail.Text = temp.Cells[9].Value.ToString();
        }
        private void clear()
        {
            txtTen.Text = "";
            dtNS.Value = Convert.ToDateTime("2020/2/2");
            txtdiachi.Text = "";
            comboBox1.Text = "";
            txtluong.Text = "";
            txtPhong.Text = "";
            txtNgGS.Text = ""; 
            txtSonv.Text = "";
            txtEmail.Text = "";
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtMaNV.Text = (context.NhanViens.Max(x => x.MaNV) + 1).ToString();
            if (Convert.ToInt32(txtMaNV.Text)< context.NhanViens.Max(x => x.MaNV) + 1||txtMaNV.Text==null)
            {
                clear();
                MessageBox.Show("Mời nhập thông tin");
                return;
            }
            else
            {
                if (txtEmail.Text.Trim()== ""|| txtchucvu.Text.Trim() == "" || txtdiachi.Text.Trim() == "" || txtluong.Text.Trim() == "" || txtSoDT.Text.Trim() == "" || txtSonv.Text.Trim() == "" || txtTen.Text.Trim() == "" )
                {
                    MessageBox.Show("Chưa nhập đủ thông tin");
                }
                else
                {
                    nv.MaNV = Convert.ToInt32(txtMaNV.Text);
                    nv.TenNV = txtTen.Text;
                    nv.NgaySinh= dtNS.Value;
                    nv.DChi = txtdiachi.Text;
                    nv.GTinh = comboBox1.Text;
                    try
                    {
                        nv.Luong = Convert.ToInt32(txtluong.Text);

                    }
                    catch { }
                    nv.MaPB = Convert.ToInt32(txtPhong.Text);
                    nv.NgGS = Convert.ToInt32(txtNgGS.Text);
                    nv.SoNVDuoiQuyen = Convert.ToInt32(txtSonv.Text);
                    nv.Email = txtEmail.Text;
                    context.NhanViens.Add(nv);
                    context.SaveChanges();
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
        }

        private void dgvNV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            display();
        }
    }
}
