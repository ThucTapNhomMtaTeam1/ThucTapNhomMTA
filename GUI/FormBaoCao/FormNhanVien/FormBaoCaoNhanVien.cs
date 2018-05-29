using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.FormBaoCao.FormNhanVien
{
    public partial class FormBaoCaoNhanVien : Form
    {
        public FormBaoCaoNhanVien()
        {
            InitializeComponent();
        }

        private void FormBaoCaoNhanVien_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSetNhanVien.NhanVien' table. You can move, or remove it, as needed.
            this.NhanVienTableAdapter.Fill(this.DataSetNhanVien.NhanVien);

            this.reportViewer1.RefreshReport();
        }
    }
}
