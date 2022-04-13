using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using DTO;
using BUS;
namespace QLLNS
{
    public partial class FrmPhongBan : Form
    {
        BUS_PhongBan buspb = new BUS_PhongBan();
        BUS_Functions busfc = new BUS_Functions();
        DataSet ds1 = new DataSet();
        public FrmPhongBan()
        {
            InitializeComponent();
        }
        private void Reset()
        {
            txtmaphong.ResetText();
            txttenphong.ResetText();
            txtghichu.ResetText();
        }
        private void btnthem_Click(object sender, EventArgs e)
        {
            Reset();
            txtmaphong.Text = buspb.tangma();
            btnluu.Enabled = true;
            btnthem.Enabled = false;
            btnsua.Enabled = false;
            btnxoa.Enabled = false;
            MessageBox.Show("Đang ở ché độ thêm mới", " THÔNG BÁO !!!");
        }

        private void FrmPhongBan_Load(object sender, EventArgs e)
        {
            btnluu.Enabled = false;
            btnsua.Enabled = false;
            btnxoa.Enabled = false;
            busfc.loaddatagridview1(dgvphongban, ds1, "select * from PhongBan");
            dgvphongban.Columns[0].HeaderText = "Mã Phòng";
            dgvphongban.Columns[1].HeaderText = "Tên Phòng";
            dgvphongban.Columns[2].HeaderText = "Ghi Chú";
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            try
            {   if(txttenphong.Text == "")
                {
                    MessageBox.Show("Chưa nhập tên phòng", "THÔNG BÁO !!!");
                }   
                DTO_PhongBan dtopb = new DTO_PhongBan(txtmaphong.Text, txttenphong.Text, txtghichu.Text);
                if (buspb.Them(dtopb))
                {
                    MessageBox.Show("Thêm thành công", "THÔNG BÁO !!!");
                    Reset();
                    btnluu.Enabled = false;
                    btnthem.Enabled = true;
                    busfc.loaddatagridview1(dgvphongban, ds1, "select * from PhongBan");
                }
            }
            catch
            {
                MessageBox.Show("Nhập không đúng ", "LỖI !!!");
            }
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            DialogResult h = MessageBox.Show("Bạn có chắc muốn thoát không?", "THÔNG BÁO !!!", MessageBoxButtons.YesNo);
            if (h == DialogResult.Yes)
                Close();
        }

        private void dgvphongban_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (btnluu.Enabled == true)
            {
                MessageBox.Show("Đang ở chế độ thêm mới", "THÔNG BÁO !!!");
            }
            else
            {
                int i = e.RowIndex;
                txtmaphong.Text = dgvphongban.Rows[i].Cells[0].Value.ToString();
                txttenphong.Text = dgvphongban.Rows[i].Cells[1].Value.ToString();
                txtghichu.Text = dgvphongban.Rows[i].Cells[2].Value.ToString();
                btnsua.Enabled = true;
                btnxoa.Enabled = true;
            }
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            try
            {
                if (txttenphong.Text == "")
            {
                MessageBox.Show("Chưa nhập tên phòng", "THÔNG BÁO !!!");
            }
            string ID = txtmaphong.Text;
                DTO_PhongBan dtopb = new DTO_PhongBan(ID, txttenphong.Text, txtghichu.Text);
                if (buspb.Sua(dtopb))
                {
                    MessageBox.Show("Sửa thành công", "THÔNG BÁO !!!");
                    busfc.loaddatagridview1(dgvphongban, ds1, "select * from PhongBan");
                    btnsua.Enabled = false;
                    btnxoa.Enabled = false;
                    Reset();
                }
            }
            catch
            {
                MessageBox.Show("Nhập không đúng ", "LỖI !!!");
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            try
            {
                string ID = txtmaphong.Text;
                if (buspb.Xoa(ID))
                {
                    MessageBox.Show("Xóa thành công", "THÔNG BÁO !!!");
                    btnsua.Enabled = false;
                    btnxoa.Enabled = false;
                    Reset();
                    busfc.loaddatagridview1(dgvphongban, ds1, "select * from PhongBan");
                }
            }
            catch
            {
                MessageBox.Show("không thể xóa", "THÔNG BÁO !!!");
            }
            
        }
    }
}
