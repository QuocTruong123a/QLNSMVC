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
    public partial class BaoCaoLuongNV : Form
    {
        public BaoCaoLuongNV()
        {
            InitializeComponent();
        }
        BUS_Functions busfc = new BUS_Functions();
        private void BaoCaoLuongNV_Load(object sender, EventArgs e)
        {
          
            this.reportViewer1.RefreshReport();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult h = MessageBox.Show("Bạn có chắc muốn thoát không?", "THÔNG BÁO !!!", MessageBoxButtons.YesNo);
            if (h == DialogResult.Yes)
                Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int nam = Int32.Parse(textBox1.Text);
            int thang = Int32.Parse(comboBox2.Text);
            if (textBox1.Text == "")
            {
                MessageBox.Show("Chưa nhập năm", "THÔNG BÁO");
                return;
            }
            if (comboBox2.Text == "")
            {
                MessageBox.Show("Chưa chọn Tháng", "THÔNG BÁO");
                return;
            }
                this.congLamViecNVCTTableAdapter.Fill(this.luongNVCT.CongLamViecNVCT, nam, thang);
  
         
            this.reportViewer1.RefreshReport();
        }
    }
}
