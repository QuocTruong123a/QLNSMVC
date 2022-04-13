using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;
namespace QLLNS
{
    public partial class FrmTaiKhoan : Form
    {
        public FrmTaiKhoan()
        {
            InitializeComponent();
        }
        BUS_User bususer = new BUS_User();
        BUS_Functions busfc = new BUS_Functions();
        DataSet ds1 = new DataSet();
        private void dgvtaikhoan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (btnluu.Enabled == true)
            {
                MessageBox.Show("Đang ở chế độ thêm mới", "THÔNG BÁO !!!");
            }
            else
            {
                int i = e.RowIndex;
                txtID.Text = dgvtaikhoan.Rows[i].Cells[0].Value.ToString();
                txttaikhoan.Text = dgvtaikhoan.Rows[i].Cells[1].Value.ToString();
                txtmatkhau.Text = dgvtaikhoan.Rows[i].Cells[2].Value.ToString();
                cmbquyen.Text = dgvtaikhoan.Rows[i].Cells[4].Value.ToString();
                btnsua.Enabled = true;
                btnxoa.Enabled = true;
                txtID.ReadOnly = true;
            }
        }

        private void FrmTaiKhoan_Load(object sender, EventArgs e)
        {
            btnluu.Enabled = false;
            btnsua.Enabled = false;
            btnxoa.Enabled = false;
            busfc.loaddatagridview1(dgvtaikhoan, ds1, "select * from Users");
            dgvtaikhoan.Columns[0].HeaderText = "ID";
            dgvtaikhoan.Columns[1].HeaderText = "Tên tài khoản";
            dgvtaikhoan.Columns[2].HeaderText = "Mật Khẩu ";
            dgvtaikhoan.Columns[4].HeaderText = "Tên Quyền";
            dgvtaikhoan.Columns[5].HeaderText = "Ngày Tạo";
        }
        private void Reset()
        {
            txttaikhoan.ResetText();
            txtmatkhau.ResetText();
            cmbquyen.ResetText();
            txtID.ResetText();
        }
        private void btnthem_Click(object sender, EventArgs e)
        {
            Reset();
            btnluu.Enabled = true;
            btnsua.Enabled = false;
            btnxoa.Enabled = false;
            btnthem.Enabled = false;
            txtID.ReadOnly = false;
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(txtID.Text);
            int quyen = 0;
            if (cmbquyen.Text == "Nhân Sự")
            {
                 quyen = 2;
            }
            if (cmbquyen.Text == "Kế Toán")
             {
                 quyen = 3;
             }
            if (busfc.kttrungkhoa(txtID.Text, "select Id from Users"))
            {
                MessageBox.Show("Mã này đã tồn tại");
            }
            else
            {
                DTO_User dtouser = new DTO_User(id, txttaikhoan.Text, txtmatkhau.Text, quyen, cmbquyen.Text, DateTime.Now.ToString());
                if (bususer.them(dtouser))
                {
                    MessageBox.Show("Thêm thành công");
                    btnthem.Enabled = true;
                    btnluu.Enabled = false;
                    Reset();
                    busfc.loaddatagridview1(dgvtaikhoan, ds1, "select * from Users");
                }
            }
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(txtID.Text);
            int quyen = 0;
            if (cmbquyen.Text == "Admin")
            {
                quyen = 1;
            }
            if (cmbquyen.Text == "Nhân Sự")
            {
                quyen = 2;
            }
            if (cmbquyen.Text == "Kế Toán")
            {
                quyen = 3;
            }
            if(cmbquyen.Text == "Admin")
            {
                MessageBox.Show("Không thể đổi thông tin tài khoản này", "THÔNG BÁO !!!");
            }
            else
            {
                DTO_User dtouser = new DTO_User(id, txttaikhoan.Text, txtmatkhau.Text, quyen, cmbquyen.Text, DateTime.Now.ToString());
                if (bususer.sua(dtouser))
                {
                    MessageBox.Show("Sửa thành công");
                    btnthem.Enabled = true;
                    btnluu.Enabled = false;
                    Reset();
                    busfc.loaddatagridview1(dgvtaikhoan, ds1, "select * from Users");
                }
            }
           
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(txtID.Text); 
            if (bususer.xoa(id))
            {
                MessageBox.Show("Xóa thành công", "THÔNG BÁO !!!");
                btnsua.Enabled = false;
                btnxoa.Enabled = false;
                Reset();
                busfc.loaddatagridview1(dgvtaikhoan, ds1, "select * from Users");
            }
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            DialogResult h = MessageBox.Show("Bạn có chắc muốn thoát không?", "THÔNG BÁO !!!", MessageBoxButtons.YesNo);
            if (h == DialogResult.Yes)
                Close();
        }
    }
}
