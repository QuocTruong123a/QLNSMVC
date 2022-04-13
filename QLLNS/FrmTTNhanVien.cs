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
    public partial class FrmTTNhanVien : Form
    {
        public FrmTTNhanVien()
        {
            InitializeComponent();
        }
        BUS_TTNhanVien busttnv = new BUS_TTNhanVien();
        BUS_Functions busfc = new BUS_Functions();
        DataSet ds1 = new DataSet();
        private void Reset()
        {
            foreach (Control tbx in this.Controls)
            {
                if (tbx is TextBox)
                    ((TextBox)tbx).Text = " ";
            }
            foreach (Control cmb in this.Controls)
            {
                if (cmb is ComboBox)
                    ((ComboBox)cmb).Text = " ";
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            btnluu.Enabled = true;
            btnsua.Enabled = false;
            btnxoa.Enabled = false;
            MessageBox.Show("Đang ở chế độ thêm mới", "THÔNG BÁO !!!");
            Reset();
        }

        private void FrmTTNhanVien_Load(object sender, EventArgs e)
        {
            btnluu.Enabled = false;
            btnsua.Enabled = false;
            btnxoa.Enabled = false;
            busfc.loadcombobox(cmbmanv, "select MaNV from HopDongLD", 0);
            busfc.loaddatagridview1(dgvttnv, ds1, "select * from TTNhanVien");
            dgvttnv.Columns[0].HeaderText = "Mã nhân viên";
            dgvttnv.Columns[1].HeaderText = "Họ tên";
            dgvttnv.Columns[2].HeaderText = "CMTND";
            dgvttnv.Columns[3].HeaderText = "Nơi cấp";
            dgvttnv.Columns[4].HeaderText = "Giói tính";
            dgvttnv.Columns[5].HeaderText = "Nơi sinh";
            dgvttnv.Columns[6].HeaderText = "Ngày sinh";
            dgvttnv.Columns[7].HeaderText = "Địa chỉ thường.T";
            dgvttnv.Columns[8].HeaderText = "Địa chỉ tạm.T";
            dgvttnv.Columns[9].HeaderText = "SĐT";
            dgvttnv.Columns[10].HeaderText = "Dân tộc";
            dgvttnv.Columns[11].HeaderText = "Tôn giáo";
            dgvttnv.Columns[12].HeaderText = "Quốc Tịch";
            dgvttnv.Columns[13].HeaderText = "Học Vấn";
            dgvttnv.Columns[14].HeaderText = "Ghi Chú";
        }

        private void dgvttnv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (btnluu.Enabled == true)
            {
                MessageBox.Show("Đang ở chế độ thêm mới", "THÔNG BÁO !!!");
            }
            else
            {
                int i = e.RowIndex;
                cmbmanv.Text = dgvttnv.Rows[i].Cells[0].Value.ToString();
                txthovaten.Text = dgvttnv.Rows[i].Cells[1].Value.ToString();
                txtcmnd.Text = dgvttnv.Rows[i].Cells[2].Value.ToString();
                txtnoicap.Text = dgvttnv.Rows[i].Cells[3].Value.ToString();
                txtgt.Text = dgvttnv.Rows[i].Cells[4].Value.ToString();
                txtnoisinh.Text = dgvttnv.Rows[i].Cells[5].Value.ToString();
                dtpngaysinh.Text = dgvttnv.Rows[i].Cells[6].Value.ToString();
                txtdcthuongtr.Text = dgvttnv.Rows[i].Cells[7].Value.ToString();
                txtdctamtr.Text = dgvttnv.Rows[i].Cells[8].Value.ToString();
                txtsdt.Text = dgvttnv.Rows[i].Cells[9].Value.ToString();
                txtdantoc.Text = dgvttnv.Rows[i].Cells[10].Value.ToString();
                txttongiao.Text = dgvttnv.Rows[i].Cells[11].Value.ToString();
                txtquoctich.Text = dgvttnv.Rows[i].Cells[12].Value.ToString();
                txthocvan.Text = dgvttnv.Rows[i].Cells[13].Value.ToString();
                txtghichu.Text = dgvttnv.Rows[i].Cells[14].Value.ToString();
                btnsua.Enabled = true;
                btnxoa.Enabled = true;
            }
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            try
            {
                if(cmbmanv.Text =="" || txtnoicap.Text == "" || txtnoisinh.Text == "" || txtdcthuongtr.Text == "" || txtdantoc.Text == "")
                {
                    MessageBox.Show("Chưa nhập đủ thông tin", "THÔNG BÁO !!!");
                }
                int manv = Int32.Parse(cmbmanv.Text);
                int sdt = Int32.Parse(txtsdt.Text);
                int cmnd = Int32.Parse(txtcmnd.Text);
                DTO_TTNhanVien dtottnv = new DTO_TTNhanVien(manv, txthovaten.Text, cmnd, txtnoicap.Text, txtgt.Text, txtnoisinh.Text, dtpngaysinh.Text, txtdcthuongtr.Text, txtdctamtr.Text, sdt, txtdantoc.Text, txttongiao.Text, txtquoctich.Text, txthocvan.Text, txtghichu.Text);
                if (busttnv.Them(dtottnv))
                {
                    btnluu.Enabled = false;
                    btnthem.Enabled = true;
                    MessageBox.Show("Thêm thành công", "THÔNG BÁO !!!");
                    busfc.loaddatagridview1(dgvttnv, ds1, "select * from TTNhanVien");
                    Reset();
                }
            }
            catch
            {
                MessageBox.Show("Nhập không đúng", "LỖI !!!");
            }
        }
        private void cmbmanv_SelectedIndexChanged(object sender, EventArgs e)
        {
            busfc.loadtextboxchiso(txthovaten, "select HovaTen from HopDongLD where MaNV='" + cmbmanv.Text + "'", 0);
            busfc.loadtextboxchiso(txtgt, "select GioiTinh from HopDongLD where MaNV='" + cmbmanv.Text + "'", 0);
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbmanv.Text == "" || txtnoicap.Text == "" || txtnoisinh.Text == "" || txtdcthuongtr.Text == "" || txtdantoc.Text == "")
                {
                    MessageBox.Show("Chưa nhập đủ thông tin", "THÔNG BÁO !!!");
                }
                int manv = Int32.Parse(cmbmanv.Text);
                int sdt = Int32.Parse(txtsdt.Text);
                int cmnd = Int32.Parse(txtcmnd.Text);
                DTO_TTNhanVien dtottnv = new DTO_TTNhanVien(manv, txthovaten.Text, cmnd, txtnoicap.Text, txtgt.Text, txtnoisinh.Text, dtpngaysinh.Text, txtdcthuongtr.Text, txtdctamtr.Text, sdt, txtdantoc.Text, txttongiao.Text, txtquoctich.Text, txthocvan.Text, txtghichu.Text);
                if (busttnv.Sua(dtottnv))
                {
                    btnluu.Enabled = false;
                    btnthem.Enabled = true;
                    MessageBox.Show("Sửa thành công", "THÔNG BÁO !!!");
                    busfc.loaddatagridview1(dgvttnv, ds1, "select * from TTNhanVien");
                    Reset();
                }
            }
            catch
            {
                MessageBox.Show("Nhập không đúng", "LỖI !!!");
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            string ID = cmbmanv.Text;
            if (busttnv.Xoa(ID))
            {
                MessageBox.Show("Xóa thành công", "THÔNG BÁO !!!");
                btnsua.Enabled = false;
                btnxoa.Enabled = false;
                Reset();
                busfc.loaddatagridview1(dgvttnv, ds1, "select * from TTNhanVien");
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
