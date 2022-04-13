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
    public partial class FrmBacLuong : Form
    {
        BUS_Functions busfc = new BUS_Functions();
        DataSet ds1 = new DataSet();

        public FrmBacLuong()
        {
            InitializeComponent();
        }
        BUS_BacLuong busbl = new BUS_BacLuong();

        private void button1_Click(object sender, EventArgs e)
        {
            Reset();
            txtmaluong.Text = busbl.tangma();
            txtluong.Focus();
            btnLuu.Enabled = true;
            button1.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            MessageBox.Show("Đang ở chế độ thêm mới", "THÔNG BÁO !!!");
            
        }
        public void Reset()
        {
            txtmaluong.ResetText();
            txtluong.ResetText();
        }
        private void FrmBacLuong_Load(object sender, EventArgs e)
        {
            btnLuu.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            busfc.loaddatagridview1(dataGridView1, ds1, "select * from BacLuong");
            dataGridView1.Columns[0].HeaderText = "Mã Lương";
            dataGridView1.Columns[1].HeaderText = "Lương";
            dataGridView1.Columns[2].HeaderText = "Ngày Tạo";
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
              if(txtluong.Text == "")
                {
                    MessageBox.Show("Chưa nhập lương", "THÔNG BÁO !!!");
                }
                int luong = Int32.Parse(txtluong.Text);
                DTO_BacLuong dtobl = new DTO_BacLuong(txtmaluong.Text, luong, DateTime.Now.ToString());
                if (busbl.Them(dtobl))
                {
                    MessageBox.Show("Thêm thành công", "THÔNG BÁO !!!");
                    Reset();
                    btnLuu.Enabled = false;
                    button1.Enabled = true;
                    busfc.loaddatagridview1(dataGridView1, ds1, "select * from BacLuong");
                }
            }
            catch 
            {
                MessageBox.Show("không được nhập chữ ", "LỖI !!! " );
                txtluong.ResetText();
                txtluong.Focus();
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (btnLuu.Enabled == true)
            {
                MessageBox.Show("Đang ở chế độ thêm mới", "THÔNG BÁO !!!");
            }
            else
            {
                int i = e.RowIndex;
                txtmaluong.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
                txtluong.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
            }   
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtluong.Text == "")
                {
                    MessageBox.Show("Chưa nhập lương", "THÔNG BÁO !!!");
                }
                string ID = txtmaluong.Text;
                int luong = Int32.Parse(txtluong.Text);
                DTO_BacLuong dtobl = new DTO_BacLuong(ID, luong, DateTime.Now.ToString());
                if (busbl.Sua(dtobl))
                {
                    MessageBox.Show("Sửa thành công", "THÔNG BÁO !!!");
                    busfc.loaddatagridview1(dataGridView1, ds1, "select * from BacLuong");
                    btnSua.Enabled = false;
                    btnXoa.Enabled = false;
                    Reset();
                }
            }
            catch 
            {
                MessageBox.Show("Nhập không đúng ", "LỖI !!!");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try {
                string ID = txtmaluong.Text;
                if (busbl.Xoa(ID))
                {
                    MessageBox.Show("Xóa thành công", "THÔNG BÁO !!!");
                    btnSua.Enabled = false;
                    btnXoa.Enabled = false;
                    Reset();
                    busfc.loaddatagridview1(dataGridView1, ds1, "select * from BacLuong");
                }
            } catch
            {
                MessageBox.Show("Không thể xóa", "THÔNG BÁO !!!");
            }
            
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult h = MessageBox.Show("Bạn có chắc muốn thoát không?", "THÔNG BÁO !!!", MessageBoxButtons.YesNo);
            if (h == DialogResult.Yes)
                Close();
                
        }
    }
}
