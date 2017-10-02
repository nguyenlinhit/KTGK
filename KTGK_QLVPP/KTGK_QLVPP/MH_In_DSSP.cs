using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace KTGK_QLVPP
{
    public partial class MH_In_DSSP : Form
    {
        SqlConnection cnn;
        SqlDataAdapter da;
        DataTable dt_SanPham;

        public MH_In_DSSP()
        {
            InitializeComponent();
        }

        private void MH_In_DSSP_Load(object sender, EventArgs e)
        {
            cnn = new SqlConnection("Data Source=DESKTOP-GQ9H33C\\NGUYENLINH;Initial Catalog=QLVanPhongPham;Integrated Security=True");
            //
            da = new SqlDataAdapter("SELECT  SANPHAM.MaSP, SANPHAM.TenSP, SANPHAM.SoLuong, SANPHAM.DonVi, SANPHAM.DonGia, NSX.TenNSX, LOAI.TenLoai "
                                    +"FROM   SANPHAM INNER JOIN " 
                                    +"NSX ON SANPHAM.MaNSX = NSX.MaNSX INNER JOIN "
                                    +"LOAI ON SANPHAM.MaLoai = LOAI.MaLoai", cnn);

            dt_SanPham = new System.Data.DataTable();
            da.Fill(dt_SanPham);

            DSSP rpt = new DSSP();
            rpt.SetDataSource(dt_SanPham.DefaultView);
            crvBaoCao.ReportSource = rpt;
            
        }

        

    }
}
