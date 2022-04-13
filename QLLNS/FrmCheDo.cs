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
using DTO;
using DAL;
namespace QLLNS
{
    public partial class FrmCheDo : Form
    {
        BUS_SoBH bussobh = new BUS_SoBH();
        BUS_TroCap bustc = new BUS_TroCap();
        BUS_Functions busfc = new BUS_Functions();
        DataSet ds1 = new DataSet();
        DataSet ds2 = new DataSet();
        public FrmCheDo()
        {
            InitializeComponent();
        }
        private void ResetBH()
        {
            txtmabaohiem.ResetText();
            cmbmanv.ResetText();
            txtnoicap.ResetText();
            txtghichu.ResetText();
        }
        private void ResetTroCap()
        {
            txtmatrocap.ResetText();
            txtpcdl.ResetText();
            txtpcconc.ResetText();
            txtpccv.ResetText();
            txtpcnhao.ResetText();
            txtghichutrocap.ResetText();
            txtpck.Text = "0";
        }
        private void btnthem_Click(object sender, EventArgs e)
        {
            ResetTroCap();
            txtmabaohiem.Text = bussobh.tangma();
            btnthem.Enabled = false;
            btnluu.Enabled = true;
            MessageBox.Show("Đang ở chế độ thêm mới", "THÔNG BÁO !!!");
        }

        private void FrmCheDo_Load(object sender, EventArgs e)
        {
            btnluu.Enabled = false;
            btnsua.Enabled = false;
            btnxoa.Enabled = false;
            btnluutrocap.Enabled = false;
            btnsuatrocap.Enabled = false;
            btnxoatrocap.Enabled = false;
            busfc.loaddatagridview1(dgvsobaohiem, ds1, "select * from SoBH");
            dgvsobaohiem.Columns[0].HeaderText = "Mã Bảo Hiểm";
            dgvsobaohiem.Columns[1].HeaderText = "Mã Nhân Viên";
            dgvsobaohiem.Columns[2].HeaderText = "Ngày Cấp";
            dgvsobaohiem.Columns[3].HeaderText = "Nơi Cấp";
            dgvsobaohiem.Columns[4].HeaderText = "Ghi Chú";
            busfc.loaddatagridview1(dgvtrocap, ds2, "select * from TroCap");
            dgvtrocap.Columns[0].HeaderText = "Mã Trợ Cấp";
            dgvtrocap.Columns[1].HeaderText = "Phụ Cấp Chức Vụ";
            dgvtrocap.Columns[2].HeaderText = "Phụ Cấp Đi Lại";
            dgvtrocap.Columns[3].HeaderText = "Phụ Cấp Nhà Ở";
            dgvtrocap.Columns[4].HeaderText = "Phụ Cấp Con Cái";
            dgvtrocap.Columns[5].HeaderText = "Phụ Cấp Khác";
            dgvtrocap.Columns[6].HeaderText = "Tổng";
            dgvtrocap.Columns[7].HeaderText = "Ghi Chú";
            busfc.loadcombobox(cmbmanv, "select MaNV from HopDongLD", 0);
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            try
            {
                if(cmbmanv.Text == "" || txtnoicap.Text == "")
                {
                    MessageBox.Show("Chưa nhập đủ thông tin", "THÔNG BÁO !!!");
                    return;
                }
                int manv = Int32.Parse(cmbmanv.Text);
                DTO_SoBH dtosobh = new DTO_SoBH(txtmabaohiem.Text, manv, dtpngaycap.Text, txtnoicap.Text, txtghichu.Text);
                if (bussobh.Them(dtosobh))
                {
                    MessageBox.Show("Thêm thành công", "THÔNG BÁO !!!");
                    ResetBH();
                    btnluu.Enabled = false;
                    btnthem.Enabled = true;
                    busfc.loaddatagridview1(dgvsobaohiem, ds1, "select * from SoBH");
                }
            }
            catch
            {
                MessageBox.Show("Nhập không đúng ", "LỖI !!!");
            }
        }

        private void btnthemtrocap_Click(object sender, EventArgs e)
        {
            btnsuatrocap.Enabled = false;
            btnxoatrocap.Enabled = false;
            btnluutrocap.Enabled = true;
            btnthem.Enabled = false;
            txtmatrocap.Text = bustc.tangma();
            MessageBox.Show("Đang ở chế độ thêm mới", "THÔNG BÁO !!!");
        }

        private void btnluutrocap_Click(object sender, EventArgs e)
        {
            if (txtpcconc.Text == "" || txtpcdl.Text == "" || txtpccv.Text == "" || txtpcnhao.Text == "" || txtpck.Text =="")
            {
                MessageBox.Show("Chưa nhập đủ thông tin cần lưu", "THÔNG BÁO");
                return;
            }
            int con = Int32.Parse(txtpcconc.Text);
            int dl = Int32.Parse(txtpcdl.Text);
            int cv = Int32.Parse(txtpccv.Text);
            int no = Int32.Parse(txtpcnhao.Text);
            int khac = Int32.Parse(txtpck.Text);
            string tong = (con + dl + cv + no + khac).ToString();
            DTO_TroCap dtotc = new DTO_TroCap(txtmatrocap.Text,cv,dl,no,con,khac,tong, txtghichutrocap.Text);
            if (bustc.Them(dtotc))
            {
                btnthemtrocap.Enabled = true;
                btnluutrocap.Enabled = false;
                MessageBox.Show("Lưu thành công", "THÔNG BÁO !!!");
                busfc.loaddatagridview1(dgvtrocap, ds2, "select * from TroCap");
                ResetTroCap();
            }
        }

        private void btnthoattrocap_Click(object sender, EventArgs e)
        {
            DialogResult h = MessageBox.Show("Bạn có chắc muốn thoát không?", "THÔNG BÁO !!!", MessageBoxButtons.YesNo);
            if (h == DialogResult.Yes)
                Close();
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            DialogResult h = MessageBox.Show("Bạn có chắc muốn thoát không?", "THÔNG BÁO !!!", MessageBoxButtons.YesNo);
            if (h == DialogResult.Yes)
                Close();
        }

        private void dgvtrocap_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (btnluutrocap.Enabled == true)
            {
                MessageBox.Show("Đang ở chế độ thêm mới", "THÔNG BÁO !!!");
            }
            else
            {
                int i = e.RowIndex;
                txtmatrocap.Text = dgvtrocap.Rows[i].Cells[0].Value.ToString();
                txtpccv.Text = dgvtrocap.Rows[i].Cells[1].Value.ToString();
                txtpcdl.Text = dgvtrocap.Rows[i].Cells[2].Value.ToString();
                txtpcnhao.Text = dgvtrocap.Rows[i].Cells[3].Value.ToString();
                txtpcconc.Text = dgvtrocap.Rows[i].Cells[4].Value.ToString();
                txtpck.Text = dgvtrocap.Rows[i].Cells[5].Value.ToString();
                txtghichutrocap.Text = dgvtrocap.Rows[i].Cells[7].Value.ToString();
                btnsuatrocap.Enabled = true;
                btnxoatrocap.Enabled = true;
            }
        }

        private void btnsuatrocap_Click(object sender, EventArgs e)
        {
            if (txtpcconc.Text == "" || txtpcdl.Text == "" || txtpccv.Text == "" || txtpcnhao.Text == "" || txtpck.Text == "")
            {
                MessageBox.Show("Chưa nhập đủ thông tin cần lưu", "THÔNG BÁO");
                return;
            }
            int con = Int32.Parse(txtpcconc.Text);
            int dl = Int32.Parse(txtpcdl.Text);
            int cv = Int32.Parse(txtpccv.Text);
            int no = Int32.Parse(txtpcnhao.Text);
            int khac = Int32.Parse(txtpck.Text);
            string ID = txtmatrocap.Text;
            string tong = (con + dl + cv + no + khac).ToString();
            DTO_TroCap dtotc = new DTO_TroCap(ID, cv, dl, no, con, khac,tong,txtghichutrocap.Text);
            if (bustc.Sua(dtotc))
            {
                btnsuatrocap.Enabled = false;
                btnxoatrocap.Enabled = false;
                MessageBox.Show("Sửa thành công", "THÔNG BÁO !!!");
                busfc.loaddatagridview1(dgvtrocap, ds2, "select * from TroCap");
                ResetTroCap();
            }
        }

        private void btnxoatrocap_Click(object sender, EventArgs e)
        {
            try {
                string ID = txtmatrocap.Text;

                if (bustc.Xoa(ID))
                {
                    btnsuatrocap.Enabled = false;
                    btnxoatrocap.Enabled = false;
                    MessageBox.Show("Xoa thành công", "THÔNG BÁO !!!");
                    busfc.loaddatagridview1(dgvtrocap, ds2, "select * from TroCap");
                    ResetTroCap();
                }
            }
            catch
            {
                MessageBox.Show("Không thể xóa", "THÔNG BÁO");
            }

        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbmanv.Text == "" || txtnoicap.Text == "")
                {
                    MessageBox.Show("Chưa nhập đủ thông tin", "THÔNG BÁO !!!");
                    return;
                }
                string ID = txtmabaohiem.Text;
                int manv = Int32.Parse(cmbmanv.Text);
                DTO_SoBH dtosobh = new DTO_SoBH(ID, manv, dtpngaycap.Text, txtnoicap.Text, txtghichu.Text);
                if (bussobh.Sua(dtosobh))
                {
                    MessageBox.Show("Sửa thành công", "THÔNG BÁO !!!");
                    ResetBH();
                    btnsua.Enabled = false;
                    btnxoa.Enabled = false;
                    busfc.loaddatagridview1(dgvsobaohiem, ds1, "select * from SoBH");
                }
        }
            catch
            {
                MessageBox.Show("Nhập không đúng ", "LỖI !!!");
            }
}

        private void btnxoa_Click(object sender, EventArgs e)
        {
            string ID = txtmabaohiem.Text;

            if (bussobh.Xoa(ID))
            {
                btnsua.Enabled = false;
                btnxoa.Enabled = false;
                MessageBox.Show("Xóa thành công", "THÔNG BÁO !!!");
                busfc.loaddatagridview1(dgvsobaohiem, ds1, "select * from SoBH");
                ResetBH();
            }
        }

        private void dgvsobaohiem_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (btnluu.Enabled == true)
            {
                MessageBox.Show("Đang ở chế độ thêm mới", "THÔNG BÁO !!!");
            }
            else
            {
                int i = e.RowIndex;
                txtmabaohiem.Text = dgvsobaohiem.Rows[i].Cells[0].Value.ToString();
                cmbmanv.Text = dgvsobaohiem.Rows[i].Cells[1].Value.ToString();
                dtpngaycap.Text = dgvsobaohiem.Rows[i].Cells[2].Value.ToString();
                txtnoicap.Text = dgvsobaohiem.Rows[i].Cells[3].Value.ToString();
                txtghichu.Text = dgvsobaohiem.Rows[i].Cells[4].Value.ToString();
                btnsua.Enabled = true;
                btnxoa.Enabled = true;
            }
        }

        
    }
}
