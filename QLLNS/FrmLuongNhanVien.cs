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
    public partial class FrmLuongNhanVien : Form
    {
        public FrmLuongNhanVien()
        {
            InitializeComponent();
        }
        BUS_CongLVNVCT busnvct = new BUS_CongLVNVCT();
        BUS_CongLVNVTV busnvtv = new BUS_CongLVNVTV();
        BUS_Functions busfc = new BUS_Functions();
        DataSet ds1 = new DataSet();
        DataSet ds2 = new DataSet();

        private void FrmLuongNhanVien_Load(object sender, EventArgs e)
        {
            busfc.loadcombobox(cmbmanv, "select MaNV  from HopDongLD where LoaiHD = N'Chính Thức' ", 0);
            busfc.loadcombobox(cmbmanvtv, "select MaNV  from HopDongLD where LoaiHD = N'Thời vụ' ", 0);
            busfc.loaddatagridview1(dgvluongnvct, ds1, "select * from CongLamViecNVCT");
            dgvluongnvct.Columns[0].HeaderText = "Mã nhân viên";
            dgvluongnvct.Columns[1].HeaderText = "Lương cơ bản";
            dgvluongnvct.Columns[2].HeaderText = "tiền trợ cấp";
            dgvluongnvct.Columns[3].HeaderText = "Họ và tên";
            dgvluongnvct.Columns[4].HeaderText = "Số ngày công";
            dgvluongnvct.Columns[5].HeaderText = "Số ngày nghỉ";
            dgvluongnvct.Columns[6].HeaderText = "Tháng";
            dgvluongnvct.Columns[7].HeaderText = "Năm";
            dgvluongnvct.Columns[8].HeaderText = "Số giờ tăng ca";
            dgvluongnvct.Columns[9].HeaderText = "Lương";
            dgvluongnvct.Columns[10].HeaderText = "Ghi Chú";
            busfc.loaddatagridview1(dgvtv, ds2, "select * from CongLamViecNVTV");
            dgvtv.Columns[0].HeaderText = "Mã nhân viên";
            dgvtv.Columns[1].HeaderText = "Họ và tên";
            dgvtv.Columns[2].HeaderText = "Lương cơ bản";
            dgvtv.Columns[3].HeaderText = "Tháng";
            dgvtv.Columns[4].HeaderText = "Năm";
            dgvtv.Columns[5].HeaderText = "Số ngày công";
            dgvtv.Columns[6].HeaderText = "Số ngày nghỉ";
            dgvtv.Columns[7].HeaderText = "Số giờ tăng ca";
            dgvtv.Columns[8].HeaderText = "Trợ cấp";
            dgvtv.Columns[9].HeaderText = "Lương";
            dgvtv.Columns[10].HeaderText = "Ghi Chú";
            btnluu.Enabled = false;
            btnsua.Enabled = false;
            btnluutv.Enabled = false;
            btnsuatv.Enabled = false;
            btntinhluong.Enabled = false;
            btntinhluongtv.Enabled = false;
        }
        private void Reset()
        {
            cmbmanv.ResetText();
            txtluongcb.ResetText();
            txttrocap.ResetText();
            txthoten.ResetText();
            cmbmanvtv.ResetText();
            txtluongcbtv.ResetText();
            txttrocaptv.ResetText();
            txthotentv.ResetText();
        }
        private void close_readonlys()
        {
            txtsongaylam.ReadOnly = false;
            txtsongaynghi.ReadOnly = false;
            txttangca.ReadOnly = false;
            txtsongaylamtv.ReadOnly = false;
            txtsongaynghitv.ReadOnly = false;
            txtsogiotangcatv.ReadOnly = false;
        }
        private void open_readonlys()
        {
            txtsongaylam.ReadOnly = true;
            txtsongaynghi.ReadOnly = true;
            txttangca.ReadOnly = true;
            txtsongaylamtv.ReadOnly = true;
            txtsongaynghitv.ReadOnly = true;
            txtsogiotangcatv.ReadOnly = true;
        }
        private void cmbmanv_SelectedIndexChanged(object sender, EventArgs e)
        {
            busfc.loadtextboxchiso(txthoten, "select HovaTen from HopDongLD where MaNV='" + cmbmanv.Text + "'", 0);
            busfc.loadtextboxchiso(txtluongcb, "select LCB  from HopDongLD as hdld,BacLuong as bl where hdld.MaLuong = bl.MaLuong and MaNV='" + cmbmanv.Text + "'", 0);
            busfc.loadtextboxchiso(txttrocap, "select Tong from HopDongLD as hdld,TroCap as tc where hdld.MaTroCap = tc.MaTroCap and MaNV='" + cmbmanv.Text + "'", 0);
        }


        private void cmbmanvtv_SelectedIndexChanged(object sender, EventArgs e)
        {
            busfc.loadtextboxchiso(txthotentv, "select HovaTen from HopDongLD where MaNV='" + cmbmanvtv.Text + "'", 0);
            busfc.loadtextboxchiso(txtluongcbtv, "select LCB  from HopDongLD as hdld,BacLuong as bl where hdld.MaLuong = bl.MaLuong and MaNV='" + cmbmanvtv.Text + "'", 0);
            busfc.loadtextboxchiso(txttrocaptv, "select Tong from HopDongLD as hdld,TroCap as tc where hdld.MaTroCap = tc.MaTroCap and MaNV='" + cmbmanvtv.Text + "'", 0);
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            Reset();
            close_readonlys();
            btnluu.Enabled = true;
            btntinhluong.Enabled = true;
            btnthem.Enabled = false;
            btnsua.Enabled = false;
            MessageBox.Show("đang ở chế độ tính lương cho nhân viên...Tháng: " + DateTime.Now.Month, "THÔNG BÁO !!!");
        }
        private void btnthemtv_Click(object sender, EventArgs e)
        {
            close_readonlys();
            Reset();
            btnluutv.Enabled = true;
            btntinhluongtv.Enabled = true;
            btnthemtv.Enabled = false;
            btnsuatv.Enabled = false;
            MessageBox.Show("đang ở chế độ tính lương cho nhân viên...Tháng: " + DateTime.Now.Month, "THÔNG BÁO !!!");
        }
        private void dgvluongnvct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (btnluu.Enabled == true)
            {
                MessageBox.Show("Đang ở chế độ thêm mới", "THÔNG BÁO !!!");
            }
            else
            {
                int i = e.RowIndex;
                cmbmanv.Text = dgvluongnvct.Rows[i].Cells[0].Value.ToString();
                txtluongcb.Text = dgvluongnvct.Rows[i].Cells[1].Value.ToString();
                txttrocap.Text = dgvluongnvct.Rows[i].Cells[2].Value.ToString();
                txthoten.Text = dgvluongnvct.Rows[i].Cells[3].Value.ToString();
                txtsongaylam.Text = dgvluongnvct.Rows[i].Cells[4].Value.ToString();
                txtsongaynghi.Text = dgvluongnvct.Rows[i].Cells[5].Value.ToString();
                txtthang.Text = dgvluongnvct.Rows[i].Cells[6].Value.ToString();
                txtnam.Text = dgvluongnvct.Rows[i].Cells[7].Value.ToString();
                txttangca.Text = dgvluongnvct.Rows[i].Cells[8].Value.ToString();
                txtluong.Text = dgvluongnvct.Rows[i].Cells[9].Value.ToString();
                txtghichu.Text = dgvluongnvct.Rows[i].Cells[10].Value.ToString();
                btnsua.Enabled = true;
                btntinhluong.Enabled = true;
            }
        }

        private void dgvtv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (btnluutv.Enabled == true)
            {
                MessageBox.Show("Đang ở chế độ thêm mới", "THÔNG BÁO !!!");
            }
            else
            {
                int i = e.RowIndex;
                cmbmanvtv.Text = dgvtv.Rows[i].Cells[0].Value.ToString();
                txthotentv.Text = dgvtv.Rows[i].Cells[1].Value.ToString();
                txtluongcbtv.Text = dgvtv.Rows[i].Cells[2].Value.ToString();
                txtthangtv.Text = dgvtv.Rows[i].Cells[3].Value.ToString();
                txtnamtv.Text = dgvtv.Rows[i].Cells[4].Value.ToString();
                txtsongaylamtv.Text = dgvtv.Rows[i].Cells[5].Value.ToString();
                txtsongaynghitv.Text = dgvtv.Rows[i].Cells[6].Value.ToString();
                txtsogiotangcatv.Text = dgvtv.Rows[i].Cells[7].Value.ToString();
                txttrocaptv.Text = dgvtv.Rows[i].Cells[8].Value.ToString();
                txtluongtv.Text = dgvtv.Rows[i].Cells[9].Value.ToString();
                txtghichutv.Text = dgvtv.Rows[i].Cells[10].Value.ToString();
                btnsuatv.Enabled = true;
                btntinhluongtv.Enabled = true;
            }
        }

        private void btntinhluong_Click(object sender, EventArgs e)
        {
            try
            {
                float songaylam = Int32.Parse(txtsongaylam.Text);
                float songaynghi = Int32.Parse(txtsongaynghi.Text);
                float sogiotangca = Int32.Parse(txttangca.Text);
                float tientrocap = Int32.Parse(txttrocap.Text);
                float luongcb = Int32.Parse(txtluongcb.Text);
                double luong = (luongcb / 26) * songaylam + ((luongcb / 26) / 8) * sogiotangca - (luongcb / 26) * songaynghi + tientrocap;

                txtluong.Text = luong.ToString("#");

                txtthang.Text = DateTime.Now.Month.ToString();
                txtnam.Text = DateTime.Now.Year.ToString();
                btntinhluong.Enabled = false;
                open_readonlys();
            }
            catch
            {
                MessageBox.Show("Chưa nhập đủ thông tin");
            }
        }

        private void btntinhluongtv_Click(object sender, EventArgs e)
        {
            try
            {
                float songaylam = Int32.Parse(txtsongaylamtv.Text);
                float songaynghi = Int32.Parse(txtsongaynghitv.Text);
                float sogiotangca = Int32.Parse(txtsogiotangcatv.Text);
                float tientrocap = Int32.Parse(txttrocaptv.Text);
                float luongcb = Int32.Parse(txtluongcbtv.Text);
                double luong = (luongcb / 26) * songaylam + ((luongcb / 26) / 8) * sogiotangca - (luongcb / 26) * songaynghi + tientrocap;

                txtluongtv.Text = luong.ToString("#");

                txtthangtv.Text = DateTime.Now.Month.ToString();
                txtnamtv.Text = DateTime.Now.Year.ToString();
                btntinhluongtv.Enabled = false;
                open_readonlys();
            }
            catch
            {
                MessageBox.Show("Chưa nhập đủ thông tin");
            }
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            if (btntinhluong.Enabled == true)
            {
                MessageBox.Show("Chưa tính lương cho nhân viên", "Thông Báo!!!");
            }
            else
            {
                try
                {
                    int manv = Int32.Parse(cmbmanv.Text);
                    int luongcb = Int32.Parse(txtluongcb.Text);
                    int trocap = Int32.Parse(txttrocap.Text);
                    int sndl = Int32.Parse(txtsongaylam.Text);
                    int snn = Int32.Parse(txtsongaynghi.Text);
                    int thang = Int32.Parse(txtthang.Text);
                    int nam = Int32.Parse(txtnam.Text);
                    int sgtc = Int32.Parse(txttangca.Text);
                    int luong = Int32.Parse(txtluong.Text);
                    DTO_CongLamViecNhanVienCT dtoct = new DTO_CongLamViecNhanVienCT(manv, luongcb, trocap, txthoten.Text, sndl, snn, thang, nam, sgtc, luong, txtghichu.Text);
                    if (!busfc.kttrungkhoa(txtnam.Text, "select Nam from CongLamViecNVCT"))
                    {
                        if(!busfc.kttrungkhoa(txtthang.Text, "select Thang from CongLamViecNVCT"))
                        {
                            if (busnvct.Them(dtoct))
                            {
                                MessageBox.Show("Thêm thành công", "THÔNG BÁO !!!");
                                btnluu.Enabled = false;
                                btnthem.Enabled = true;
                                Reset();
                                busfc.loaddatagridview1(dgvluongnvct, ds1, "select * from CongLamViecNVCT");
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Tháng này đã tính lương cho nhân viên");
                    }
                }
                catch
                {
                    MessageBox.Show("thông tin nhập chưa đúng", "THÔNG BÁO !!!");
                }
            }

        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            if (btntinhluong.Enabled == true)
            {
                MessageBox.Show("Chưa tính lương cho nhân viên", "THÔNG BÁO !!!");
            }
            else
            {
                try
                {
                    {
                        int manv = Int32.Parse(cmbmanv.Text);
                        int luongcb = Int32.Parse(txtluongcb.Text);
                        int trocap = Int32.Parse(txttrocap.Text);
                        int sndl = Int32.Parse(txtsongaylam.Text);
                        int snn = Int32.Parse(txtsongaynghi.Text);
                        int thang = Int32.Parse(txtthang.Text);
                        int nam = Int32.Parse(txtnam.Text);
                        int sgtc = Int32.Parse(txttangca.Text);
                        int luong = Int32.Parse(txtluong.Text);
                        DTO_CongLamViecNhanVienCT dtoct = new DTO_CongLamViecNhanVienCT(manv, luongcb, trocap, txthoten.Text, sndl, snn, thang, nam, sgtc, luong, txtghichu.Text);
                        if (busnvct.Sua(dtoct))
                        {
                            MessageBox.Show("Sửa thành công", "THÔNG BÁO !!!");
                            btnluu.Enabled = false;
                            btnthem.Enabled = true;
                            Reset();
                            busfc.loaddatagridview1(dgvluongnvct, ds1, "select * from CongLamViecNVCT");
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("Thông tin nhập không đúng", "THÔNG BÁO !!!");
                }

            }
        }

        private void btnluutv_Click(object sender, EventArgs e)
        {
            if (btntinhluongtv.Enabled == true)
            {
                MessageBox.Show("Chưa tính lương cho nhân viên", "THÔNG BÁO !!!");
            }
            else
            {
                try
                {
                    int manv = Int32.Parse(cmbmanvtv.Text);
                    int luongcb = Int32.Parse(txtluongcbtv.Text);
                    int trocap = Int32.Parse(txttrocaptv.Text);
                    int sndl = Int32.Parse(txtsongaylamtv.Text);
                    int snn = Int32.Parse(txtsongaynghitv.Text);
                    int thang = Int32.Parse(txtthangtv.Text);
                    int nam = Int32.Parse(txtnamtv.Text);
                    int sgtc = Int32.Parse(txtsogiotangcatv.Text);
                    int luong = Int32.Parse(txtluongtv.Text);
                    DTO_CongLamViecNhanVienTV dtotv = new DTO_CongLamViecNhanVienTV(manv, txthotentv.Text, luongcb, thang, nam, sndl, snn, sgtc, trocap, luong, txtghichutv.Text);
                    if (!busfc.kttrungkhoa(txtnamtv.Text, "select Nam from CongLamViecNVTV"))
                    {
                        if (!busfc.kttrungkhoa(txtthangtv.Text, "select Thang from CongLamViecNVTV"))
                        {
                            if (busnvtv.Them(dtotv))
                            {
                                MessageBox.Show("Thêm thành công", "THÔNG BÁO !!!");
                                btnluutv.Enabled = false;
                                btnthemtv.Enabled = true;
                                Reset();
                                busfc.loaddatagridview1(dgvtv, ds2, "select * from CongLamViecNVTV");
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Tháng này đã tính lương cho nhân viên");
                    }
                    
                }
                catch
                {
                    MessageBox.Show("Chưa nhập đủ thông tin", "THÔNG BÁO !!!");
                }
            }
        }

        private void btnsuatv_Click(object sender, EventArgs e)
        {
            if (btntinhluongtv.Enabled == true)
            {
                MessageBox.Show("Chưa tính lương cho nhân viên", "THÔNG BÁO !!!");
            }
            else
            {
                try
                {
                    int manv = Int32.Parse(cmbmanvtv.Text);
                int luongcb = Int32.Parse(txtluongcbtv.Text);
                int trocap = Int32.Parse(txttrocaptv.Text);
                int sndl = Int32.Parse(txtsongaylamtv.Text);
                int snn = Int32.Parse(txtsongaynghitv.Text);
                int thang = Int32.Parse(txtthangtv.Text);
                int nam = Int32.Parse(txtnamtv.Text);
                int sgtc = Int32.Parse(txtsogiotangcatv.Text);
                int luong = Int32.Parse(txtluongtv.Text);
                DTO_CongLamViecNhanVienTV dtotv = new DTO_CongLamViecNhanVienTV(manv, txthotentv.Text, luongcb, thang, nam, sndl, snn, sgtc, trocap, luong, txtghichutv.Text);
                if (busnvtv.Sua(dtotv))
                {
                    MessageBox.Show("Sửa thành công", "THÔNG BÁO !!!");
                    btnluutv.Enabled = false;
                    btnthemtv.Enabled = true;
                    Reset();
                    busfc.loaddatagridview1(dgvtv, ds2, "select * from CongLamViecNVTV");
                }
            }
                catch
            {
                MessageBox.Show("Chưa nhập đủ thông tin", "THÔNG BÁO !!!");
            }
        }
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            DialogResult h = MessageBox.Show("Bạn có chắc muốn thoát không?", "THÔNG BÁO !!!", MessageBoxButtons.YesNo);
            if (h == DialogResult.Yes)
                Close();
        }

        private void btnthoattv_Click(object sender, EventArgs e)
        {
            DialogResult h = MessageBox.Show("Bạn có chắc muốn thoát không?", "THÔNG BÁO !!!", MessageBoxButtons.YesNo);
            if (h == DialogResult.Yes)
                Close();
        }
    }
}


