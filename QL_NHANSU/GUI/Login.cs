using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QL_NHANSU.Data;
namespace QL_NHANSU.GUI
{
    public partial class Login : Form
    {
        MyContext context = new MyContext();
        NguoiDung nd = new NguoiDung();
        public Login()
        {
            InitializeComponent();
            txtname.Select();
        }
        
        private void button6_Click(object sender, EventArgs e)
        {
            if (txtname.Text == "" || txtpass.Text == "")
            {
                MessageBox.Show("Tên tài khoản và mật khẩu còn trống");
                return;
            }

            else
            {
                //var list1 = context.NguoiDungs.Where(p => p.ID == txtname.Text && p.pass == txtpass.Text).ToList();
                var list = context.NguoiDungs.SingleOrDefault(x => x.ID == txtname.Text && x.pass == txtpass.Text);
                if (list == null)
                {
                    MessageBox.Show("Tài khoản không tồn tại");
                    txtpass.Clear(); txtname.Clear();
                }
                else
                {
                    DialogResult = MessageBox.Show("Đăng nhập thành công", "", MessageBoxButtons.OKCancel);
                    this.Hide();
                    Main ql = new Main();
                    ql.ShowDialog();
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Login_Enter(object sender, EventArgs e)
        {
        }

        private void Login_MouseEnter(object sender, EventArgs e)
        {
            
        }

        private void Login_MouseMove(object sender, MouseEventArgs e)
        {
            
        }
        
    }
}
