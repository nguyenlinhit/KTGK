using DevComponents.DotNetBar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KTGK_QLVPP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            TabItem tab = tabControl1.CreateTab("Đăng nhập");
            MH_Dang_Nhap f_dangnhap = new MH_Dang_Nhap();
            f_dangnhap.Dock = DockStyle.Fill;
            f_dangnhap.FormBorderStyle = FormBorderStyle.None;
            f_dangnhap.TopLevel = false;
            tab.AttachedControl.Controls.Add(f_dangnhap);
            f_dangnhap.Show();
            tabControl1.SelectedTabIndex = tabControl1.Tabs.Count - 1;
        }
    }
}
