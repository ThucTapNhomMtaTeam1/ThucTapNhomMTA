using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.FormBaoCao.FormLoaiSanPham
{
    public partial class FormBaoCaoLoaiSanPham : Form
    {
        public FormBaoCaoLoaiSanPham()
        {
            InitializeComponent();
        }

        private void FormBaoCaoLoaiSanPham_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSetLoaiSanPham.LoaiSanPham' table. You can move, or remove it, as needed.
            this.LoaiSanPhamTableAdapter.Fill(this.DataSetLoaiSanPham.LoaiSanPham);

            this.reportViewer1.RefreshReport();
        }
    }
}
