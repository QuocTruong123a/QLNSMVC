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
    public partial class FrmHDLV : Form
    {
        BUS_HopDongLD busld = new BUS_HopDongLD();
        BUS_Functions busfc = new BUS_Functions();
        BUS_CongLVNVCT busct = new BUS_CongLVNVCT();
        BUS_CongLVNVTV bustv = new BUS_CongLVNVTV();
        BUS_SoBH busbh = new BUS_SoBH();
        BUS_BacLuong busbl = new BUS_BacLuong();

        DataSet ds1 = new DataSet();
        public FrmHDLV()
        {
            InitializeComponent();
        }
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
        private void FrmHDLV_Load(object sender, EventArgs e)
        {
            
            busfc.loadcombobox(cmbmaluong, "select MaLuong from BacLuong", 0);
            busfc.loadcombobox(cmbmaphongban, "select MaPhong from PhongBan", 0);
            busfc.loadcombobox(cmbtrocap, "select MaTroCap from TroCap", 0);
            btnluu.Enabled = false;
            btnsua.Enabled = false;
            btnxoa.Enabled = false;
            busfc.loaddatagridview1(dgvHopDong, ds1, "select * from HopDongLD");
            dgvHopDong.Columns[0].HeaderText = "Mã phòng";
            dgvHopDong.Columns[1].HeaderText = "Mã Nhân viên";
            dgvHopDong.Columns[2].HeaderText = "Họ tên ";
            dgvHopDong.Columns[3].HeaderText = "Mã Trợ cấp";
            dgvHopDong.Columns[4].HeaderText = "Mã Lương";
            dgvHopDong.Columns[5].HeaderText = "Giới Tính";
            dgvHopDong.Columns[6].HeaderText = "TT Hôn nhân";
            dgvHopDong.Columns[7].HeaderText = "Số lượng con";
            dgvHopDong.Columns[8].HeaderText = "Chức vụ";
            dgvHopDong.Columns[9].HeaderText = "Loại hợp đồng";
            dgvHopDong.Columns[10].HeaderText = "Thời gian";
            dgvHopDong.Columns[11].HeaderText = "Ngày bắt đầu";
            dgvHopDong.Columns[12].HeaderText = "Ngày kết thúc";
            dgvHopDong.Columns[13].HeaderText = "Ghi chú";
          
        }

        private void dataGVHopDong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (btnluu.Enabled == true)
            {
                MessageBox.Show("Đang ở chế độ thêm mới", "THÔNG BÁO !!!");
            }
            else
            {
                int i = e.RowIndex;
                cmbmaphongban.Text = dgvHopDong.Rows[i].Cells[0].Value.ToString();
                txtmanv.Text = dgvHopDong.Rows[i].Cells[1].Value.ToString();
                txthoten.Text = dgvHopDong.Rows[i].Cells[2].Value.ToString();
                cmbtrocap.Text = dgvHopDong.Rows[i].Cells[3].Value.ToString();
                cmbmaluong.Text = dgvHopDong.Rows[i].Cells[4].Value.ToString();
                cmbgioitinh.Text = dgvHopDong.Rows[i].Cells[5].Value.ToString();
                cmbtthonnhan.Text = dgvHopDong.Rows[i].Cells[6].Value.ToString();
                txtslcon.Text = dgvHopDong.Rows[i].Cells[7].Value.ToString();
                txtchucvu.Text = dgvHopDong.Rows[i].Cells[8].Value.ToString();
                cmbloaihopdong.Text = dgvHopDong.Rows[i].Cells[9].Value.ToString();
                txtthoigian.Text = dgvHopDong.Rows[i].Cells[10].Value.ToString();
                dtpngaybatdau.Text = dgvHopDong.Rows[i].Cells[11].Value.ToString();
                dtpngayketthuc.Text = dgvHopDong.Rows[i].Cells[12].Value.ToString();
                txtghichu.Text = dgvHopDong.Rows[i].Cells[13].Value.ToString();
                btnsua.Enabled = true;
                btnxoa.Enabled = true;
            }
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            Reset();
            btnthem.Enabled = false;
            btnluu.Enabled = true;
            btnsua.Enabled = false;
            btnxoa.Enabled = false;
            txtmanv.Text = busld.tangma();
            MessageBox.Show("Đang ở chế độ thêm mới", "THÔNG BÁO !!!");
     
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbmaphongban.Text == "" || cmbtrocap.Text == "" || cmbloaihopdong.Text == "" || cmbmaluong.Text == "")
                {
                    MessageBox.Show("Chưa nhập đủ thông tin nhân viên", "THÔNG BÁO !!!");
                }
                int manv = Int32.Parse(txtmanv.Text);
                int slcon = Int32.Parse(txtslcon.Text);
                DTO_HopDongLD dtold = new DTO_HopDongLD(cmbmaphongban.Text, manv, txthoten.Text, cmbtrocap.Text, cmbmaluong.Text, cmbgioitinh.Text, cmbtthonnhan.Text, slcon, txtchucvu.Text, cmbloaihopdong.Text, txtthoigian.Text, dtpngaybatdau.Text, dtpngaybatdau.Text, txtghichu.Text);
                if (busld.Them(dtold))
                {
                    MessageBox.Show("Thêm thành công", "THÔNG BÁO !!!");
                    btnthem.Enabled = true;
                    btnluu.Enabled = false;
                    busfc.loaddatagridview1(dgvHopDong, ds1, "select * from HopDongLD");
                    Reset();
                }
            }
            catch
            {
                MessageBox.Show("Dữ liệu nhập sai", "Lỗi !!!");
            }
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            if (cmbmaphongban.Text == "" || cmbtrocap.Text == "" || cmbloaihopdong.Text == "" || cmbmaluong.Text == "")
            {
                MessageBox.Show("Chưa nhập đủ thông tin nhân viên", "THÔNG BÁO !!!");
            }
            int manv = Int32.Parse(txtmanv.Text);
            int slcon = Int32.Parse(txtslcon.Text);
            DTO_HopDongLD dtold = new DTO_HopDongLD(cmbmaphongban.Text, manv, txthoten.Text, cmbtrocap.Text, cmbmaluong.Text, cmbgioitinh.Text, cmbtthonnhan.Text, slcon, txtchucvu.Text, cmbloaihopdong.Text, txtthoigian.Text, dtpngaybatdau.Text, dtpngaybatdau.Text, txtghichu.Text);
            if (busld.Sua(dtold))
            {
                MessageBox.Show("Sửa thành công", "THÔNG BÁO !!!");
                btnsua.Enabled = false;
                btnxoa.Enabled = false;
                Reset();
                busfc.loaddatagridview1(dgvHopDong, ds1, "select * from HopDongLD");
            }
        }
        
        private void btnxoa_Click(object sender, EventArgs e)
        {

            string ID = txtmanv.Text;
            bustv.Xoa(ID);
            busct.Xoa(ID);
            if (busld.Xoa(ID))
            {
                MessageBox.Show("Xóa thành công", "THÔNG BÁO !!!");
                btnsua.Enabled = false;
                btnxoa.Enabled = false;
                Reset();
                busfc.loaddatagridview1(dgvHopDong, ds1, "select * from HopDongLD");
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
