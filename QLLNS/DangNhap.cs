using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
namespace QLLNS
{
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }
        BUS_Functions busfc = new BUS_Functions();
        private void button1_Click(object sender, EventArgs e)
        {
            string sql = Convert.ToString(busfc.login("Select Name from Users where Name=N'" + textBox1.Text + "'"));
            string sqlpass = Convert.ToString(busfc.login("Select Pass from Users where Pass=N'" + textBox2.Text + "'"));
            string _Quyen = Convert.ToString(busfc.login("Select Quyen from Users where Name=N'" + textBox1.Text + "'"));
            if (textBox1.Text.Trim().Length == 0)
            {
                MessageBox.Show("Chưa nhập tên đăng nhâp", " THÔNG BÁO !!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox1.Focus();
                return;
            }
            if (textBox2.Text.Trim().Length == 0)
            {
                MessageBox.Show("Chưa nhập mật khẩu", " THÔNG BÁO !!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox2.Focus();
                return;
            }
            if (Convert.ToString(textBox1.Text) != sql)
            {
                MessageBox.Show("Tên đăng nhập không đúng");

            }
            else if(Convert.ToString(textBox2.Text) != sqlpass)
            {
                MessageBox.Show("Mật khẩu không đúng");
            }    
            else
            {
                try
                {
                    Main.Quyen = _Quyen;
                    MessageBox.Show("Xin chào: " + textBox1.Text, " THÔNG BÁO !!!");
                    this.Hide();
                    Main frm = new Main();
                    frm.ShowDialog();
                }
                catch
                {
                    MessageBox.Show("Đăng nhập không thành công", "LỖI !!!");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Main ma = new Main();
            ma.Show();
            Close();   
        }
    }
}
