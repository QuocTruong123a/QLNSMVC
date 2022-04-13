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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void hộpĐồngLàmViệcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmHDLV hd = new FrmHDLV();
            panel1.Show();
            panel1.Controls.Clear();
            hd.TopLevel = false;
            hd.Dock = DockStyle.Fill;
            panel1.Controls.Add(hd);
            hd.Show();
        }

        private void thôngTinNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTTNhanVien ttnv = new FrmTTNhanVien();
            panel1.Show();
            panel1.Controls.Clear();
            ttnv.TopLevel = false;
            ttnv.Dock = DockStyle.Fill;
            panel1.Controls.Add(ttnv);
            ttnv.Show();

        }

        private void lươngNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmLuongNhanVien lnv = new FrmLuongNhanVien();
            panel1.Show();
            panel1.Controls.Clear();
            lnv.TopLevel = false;
            lnv.Dock = DockStyle.Fill;
            panel1.Controls.Add(lnv);
            lnv.Show();
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {
         
            DangNhap dn = new DangNhap();
            this.Hide();
            dn.Show();
        }

        private void bậcLươngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBacLuong luong = new FrmBacLuong();
            panel1.Show();
            panel1.Controls.Clear();
            luong.TopLevel = false;
            
            panel1.Controls.Add(luong);
            luong.Show();
        }

        private void phòngBanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPhongBan pb = new FrmPhongBan();
            panel1.Show();
            panel1.Controls.Clear();
            pb.TopLevel = false;
            panel1.Controls.Add(pb);
            pb.Show();
        }

        private void taiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTaiKhoan tk = new FrmTaiKhoan();
            panel1.Show();
            panel1.Controls.Clear();
            tk.TopLevel = false;
            panel1.Controls.Add(tk);
            tk.Show();
        }

        private void chếĐộToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCheDo cd = new FrmCheDo();
            panel1.Show();
            panel1.Controls.Clear();
            cd.TopLevel = false;
            panel1.Controls.Add(cd);
            cd.Show();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult h = MessageBox.Show("Bạn có chắc muốn thoát không?", "THÔNG BÁO !!!", MessageBoxButtons.YesNo);
            if (h == DialogResult.Yes)
                Application.Exit();
        }

        private void toolStripStatusLabel2_Click(object sender, EventArgs e)
        {
         
        }

        private void traCứuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTraCuu tracuu = new FrmTraCuu();
            panel1.Show();
            panel1.Controls.Clear();
            tracuu.TopLevel = false;
            panel1.Controls.Add(tracuu);
            tracuu.Show();
        }

        private void menubaocao_Click(object sender, EventArgs e)
        {
            BaoCaoLuongNV baocao = new BaoCaoLuongNV();
            panel1.Show();
            panel1.Controls.Clear();
            baocao.TopLevel = false;
            panel1.Controls.Add(baocao);
            baocao.Show();
        }

        private void thôngTinHệThốngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTTHeThong hethong = new FrmTTHeThong();
            panel1.Show();
            panel1.Controls.Clear();
            hethong.TopLevel = false;
            panel1.Controls.Add(hethong);
            hethong.Show();
        }

        private void báoCáoLuongNhânViênThờiVụToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BaoCaoLuongNVTV baocao = new BaoCaoLuongNVTV();
            panel1.Show();
            panel1.Controls.Clear();
            baocao.TopLevel = false;
            panel1.Controls.Add(baocao);
            baocao.Show();
        }
        public static String Quyen;
        private void Main_Load(object sender, EventArgs e)
        {
            menudanhmuc.Enabled = false;
            menuquanly.Enabled = false;
            menuchucnang.Enabled = false;
            if (Quyen == "1")
            {
                menudanhmuc.Enabled = true;
                menuquanly.Enabled = true;
                menuchucnang.Enabled = true;
            }
            if (Quyen == "2")
            {
                menuchucnang.Enabled = true;
                menudanhmuc.Enabled = true;
                menubaocao.Enabled = false;
                menubaocaotv.Enabled = false;


            }
            if (Quyen == "3")
            {
                menuchucnang.Enabled = true;
                menuttht.Enabled = true;
                menudanhmuc.Enabled = true;
                menuttnv.Enabled = false;
                menuhdlv.Enabled = false;
                menuchedo.Enabled = false;
                menuquanly.Enabled = true;
                menuphongban.Enabled = false;
                menubacluong.Enabled = false;
                menutk.Enabled = false;
            }
        }
    }
}
