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
    public partial class FrmTraCuu : Form
    {
        public FrmTraCuu()
        {
            InitializeComponent();
        }
        BUS_Functions busfc = new BUS_Functions();
        private void FrmTraCuu_Load(object sender, EventArgs e)
        {
        }
        int i = 0;
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
             i = 1;
            if (radioButton1.Checked == true)
            {
                busfc.loadcombobox(comboBox1, "select MaNV from HopDongLD", 0);
            
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
             i = 2;
            if (radioButton2.Checked == true)
            {
                busfc.loadcombobox(comboBox1, "select HovaTen from HopDongLD", 0);

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((comboBox1.Text == "") || (comboBox1.Text == "Nhập vào từ khóa tìm kiếm"))
            {
                MessageBox.Show("bạn chưa nhập tù khóa", "Nhập từ khóa", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (i == 1)
                {
                    busfc.loaddatagridview(dataGridView1, "select MaNV,HovaTen,GioiTinh,ChucVu,LoaiHD,TenPhong,LCB,Tong from HopDongLD as hdld , BacLuong as bl ,TroCap as tc , PhongBan as pb  where hdld.MaLuong = bl.MaLuong and hdld.MaTroCap = tc.MaTroCap and hdld.MaPhong = pb.MaPhong and MaNV=N'" + comboBox1.Text + "'");
                }
                if (i == 2)
                {
                    busfc.loaddatagridview(dataGridView1, "select MaNV,HovaTen,GioiTinh,ChucVu,LoaiHD,TenPhong,LCB,Tong from HopDongLD as hdld , BacLuong as bl ,TroCap as tc , PhongBan as pb  where hdld.MaLuong = bl.MaLuong and hdld.MaTroCap = tc.MaTroCap and hdld.MaPhong = pb.MaPhong and HovaTen=N'" + comboBox1.Text + "'");
                }
                dataGridView1.Columns[0].HeaderText = "Mã Nhân Viên";
                dataGridView1.Columns[1].HeaderText = "Họ và Tên";
                dataGridView1.Columns[2].HeaderText = "Giới Tính";
                dataGridView1.Columns[2].HeaderText = "Chức Vụ";
                dataGridView1.Columns[2].HeaderText = "Loại HD";
                dataGridView1.Columns[2].HeaderText = "Tên Phòng";
                dataGridView1.Columns[2].HeaderText = "Lương Cơ Bản";
                dataGridView1.Columns[2].HeaderText = "Trợ Cấp";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult h = MessageBox.Show("Bạn có chắc muốn thoát không?", "THÔNG BÁO !!!", MessageBoxButtons.YesNo);
            if (h == DialogResult.Yes)
                Close();
        }
    }
}
