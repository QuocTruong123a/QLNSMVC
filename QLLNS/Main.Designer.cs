
namespace QLLNS
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menudanhmuc = new System.Windows.Forms.ToolStripMenuItem();
            this.menuttnv = new System.Windows.Forms.ToolStripMenuItem();
            this.menuhdlv = new System.Windows.Forms.ToolStripMenuItem();
            this.menuchedo = new System.Windows.Forms.ToolStripMenuItem();
            this.menuttht = new System.Windows.Forms.ToolStripMenuItem();
            this.menuquanly = new System.Windows.Forms.ToolStripMenuItem();
            this.menuphongban = new System.Windows.Forms.ToolStripMenuItem();
            this.menuluong = new System.Windows.Forms.ToolStripMenuItem();
            this.menubacluong = new System.Windows.Forms.ToolStripMenuItem();
            this.menutk = new System.Windows.Forms.ToolStripMenuItem();
            this.menuchucnang = new System.Windows.Forms.ToolStripMenuItem();
            this.menutracuu = new System.Windows.Forms.ToolStripMenuItem();
            this.menubaocao = new System.Windows.Forms.ToolStripMenuItem();
            this.menubaocaotv = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menudanhmuc,
            this.menuquanly,
            this.menuchucnang,
            this.thoátToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(10, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1037, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menudanhmuc
            // 
            this.menudanhmuc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.menudanhmuc.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuttnv,
            this.menuhdlv,
            this.menuchedo,
            this.menuttht});
            this.menudanhmuc.Image = ((System.Drawing.Image)(resources.GetObject("menudanhmuc.Image")));
            this.menudanhmuc.Name = "menudanhmuc";
            this.menudanhmuc.Size = new System.Drawing.Size(137, 29);
            this.menudanhmuc.Text = "Danh Mục";
            // 
            // menuttnv
            // 
            this.menuttnv.Name = "menuttnv";
            this.menuttnv.Size = new System.Drawing.Size(287, 30);
            this.menuttnv.Text = "Thông Tin Nhân Viên";
            this.menuttnv.Click += new System.EventHandler(this.thôngTinNhânViênToolStripMenuItem_Click);
            // 
            // menuhdlv
            // 
            this.menuhdlv.Name = "menuhdlv";
            this.menuhdlv.Size = new System.Drawing.Size(287, 30);
            this.menuhdlv.Text = "Hợp Đồng Làm Việc";
            this.menuhdlv.Click += new System.EventHandler(this.hộpĐồngLàmViệcToolStripMenuItem_Click);
            // 
            // menuchedo
            // 
            this.menuchedo.Name = "menuchedo";
            this.menuchedo.Size = new System.Drawing.Size(287, 30);
            this.menuchedo.Text = "Chế Độ";
            this.menuchedo.Click += new System.EventHandler(this.chếĐộToolStripMenuItem_Click);
            // 
            // menuttht
            // 
            this.menuttht.Name = "menuttht";
            this.menuttht.Size = new System.Drawing.Size(287, 30);
            this.menuttht.Text = "Thông Tin Hệ Thống";
            this.menuttht.Click += new System.EventHandler(this.thôngTinHệThốngToolStripMenuItem_Click);
            // 
            // menuquanly
            // 
            this.menuquanly.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuphongban,
            this.menuluong,
            this.menubacluong,
            this.menutk});
            this.menuquanly.Image = ((System.Drawing.Image)(resources.GetObject("menuquanly.Image")));
            this.menuquanly.Name = "menuquanly";
            this.menuquanly.Size = new System.Drawing.Size(118, 29);
            this.menuquanly.Text = "Quản Lý";
            // 
            // menuphongban
            // 
            this.menuphongban.Name = "menuphongban";
            this.menuphongban.Size = new System.Drawing.Size(255, 30);
            this.menuphongban.Text = "Phòng Ban";
            this.menuphongban.Click += new System.EventHandler(this.phòngBanToolStripMenuItem_Click);
            // 
            // menuluong
            // 
            this.menuluong.Name = "menuluong";
            this.menuluong.Size = new System.Drawing.Size(255, 30);
            this.menuluong.Text = "Lương Nhân Viên";
            this.menuluong.Click += new System.EventHandler(this.lươngNhânViênToolStripMenuItem_Click);
            // 
            // menubacluong
            // 
            this.menubacluong.Name = "menubacluong";
            this.menubacluong.Size = new System.Drawing.Size(255, 30);
            this.menubacluong.Text = "Bậc Lương ";
            this.menubacluong.Click += new System.EventHandler(this.bậcLươngToolStripMenuItem_Click);
            // 
            // menutk
            // 
            this.menutk.Name = "menutk";
            this.menutk.Size = new System.Drawing.Size(255, 30);
            this.menutk.Text = "Tài Khoản Admin";
            this.menutk.Click += new System.EventHandler(this.taiToolStripMenuItem_Click);
            // 
            // menuchucnang
            // 
            this.menuchucnang.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menutracuu,
            this.menubaocao,
            this.menubaocaotv});
            this.menuchucnang.Image = ((System.Drawing.Image)(resources.GetObject("menuchucnang.Image")));
            this.menuchucnang.Name = "menuchucnang";
            this.menuchucnang.Size = new System.Drawing.Size(145, 29);
            this.menuchucnang.Text = "Chức Năng";
            // 
            // menutracuu
            // 
            this.menutracuu.Name = "menutracuu";
            this.menutracuu.Size = new System.Drawing.Size(438, 30);
            this.menutracuu.Text = "Tra Cứu";
            this.menutracuu.Click += new System.EventHandler(this.traCứuToolStripMenuItem_Click);
            // 
            // menubaocao
            // 
            this.menubaocao.Name = "menubaocao";
            this.menubaocao.Size = new System.Drawing.Size(438, 30);
            this.menubaocao.Text = "Báo Cáo Lương Nhân Viên Chính Thức";
            this.menubaocao.Click += new System.EventHandler(this.menubaocao_Click);
            // 
            // menubaocaotv
            // 
            this.menubaocaotv.Name = "menubaocaotv";
            this.menubaocaotv.Size = new System.Drawing.Size(438, 30);
            this.menubaocaotv.Text = "Báo Cáo Lương Nhân Viên Thời Vụ";
            this.menubaocaotv.Click += new System.EventHandler(this.báoCáoLuongNhânViênThờiVụToolStripMenuItem_Click);
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.thoátToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("thoátToolStripMenuItem.Image")));
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(97, 29);
            this.thoátToolStripMenuItem.Text = "Thoát";
            this.thoátToolStripMenuItem.Click += new System.EventHandler(this.thoátToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Dock = System.Windows.Forms.DockStyle.Top;
            this.statusStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel3,
            this.toolStripStatusLabel2});
            this.statusStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.statusStrip1.Location = new System.Drawing.Point(0, 33);
            this.statusStrip1.Margin = new System.Windows.Forms.Padding(10);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1037, 29);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripStatusLabel1.Image")));
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(105, 23);
            this.toolStripStatusLabel1.Text = "Đăng Nhập";
            this.toolStripStatusLabel1.Click += new System.EventHandler(this.toolStripStatusLabel1_Click);
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(14, 23);
            this.toolStripStatusLabel3.Text = "|";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripStatusLabel2.Image")));
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(99, 23);
            this.toolStripStatusLabel2.Text = "Đăng Xuất";
            this.toolStripStatusLabel2.Click += new System.EventHandler(this.toolStripStatusLabel2_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(0, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1037, 585);
            this.panel1.TabIndex = 3;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 647);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menudanhmuc;
        private System.Windows.Forms.ToolStripMenuItem menuquanly;
        private System.Windows.Forms.ToolStripMenuItem menuchucnang;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuttnv;
        private System.Windows.Forms.ToolStripMenuItem menuhdlv;
        private System.Windows.Forms.ToolStripMenuItem menuchedo;
        private System.Windows.Forms.ToolStripMenuItem menuttht;
        private System.Windows.Forms.ToolStripMenuItem menuphongban;
        private System.Windows.Forms.ToolStripMenuItem menuluong;
        private System.Windows.Forms.ToolStripMenuItem menubacluong;
        private System.Windows.Forms.ToolStripMenuItem menutracuu;
        private System.Windows.Forms.ToolStripMenuItem menubaocao;
        private System.Windows.Forms.ToolStripMenuItem menutk;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem menubaocaotv;
    }
}