using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLLNS
{
    public partial class BaoCaoLuongNVTV : Form
    {
        public BaoCaoLuongNVTV()
        {
            InitializeComponent();
        }

        private void BaoCaoLuongNVTV_Load(object sender, EventArgs e)
        {

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
            this.congLamViecNVTVTableAdapter.Fill(this.luongNVTV.CongLamViecNVTV, nam, thang);


            this.reportViewer1.RefreshReport();
        }
    }
}
