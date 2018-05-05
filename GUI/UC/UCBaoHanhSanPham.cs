using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DTO;

namespace GUI.UC
{
    public partial class UCBaoHanhSanPham : UserControl
    {
        public UCBaoHanhSanPham()
        {
            InitializeComponent();
        }

        private void HienThiDanhSachBaoHanh()
        {
            HienThiBaoHanhBLL hienThiBaoHanhBLL = new HienThiBaoHanhBLL();
            GVBaoHanh.Rows.Clear();
            foreach (BaoHanh baoHanh in hienThiBaoHanhBLL.LayToanBoBaoHanh())
            {
                DataGridViewRow dataGridViewRow = new DataGridViewRow();
                dataGridViewRow.Cells[0].Value = baoHanh.MaBaoHanh;
                dataGridViewRow.Cells[1].Value = baoHanh.TenSanPham;
                dataGridViewRow.Cells[2].Value = baoHanh.MaMay;
                dataGridViewRow.Cells[3].Value = baoHanh.MaHoaDon;
                dataGridViewRow.Cells[4].Value = baoHanh.MaPhieuXuat;
                dataGridViewRow.Cells[5].Value = baoHanh.MaKhachHang;
                dataGridViewRow.Cells[6].Value = baoHanh.NgayBatDau;
                dataGridViewRow.Cells[7].Value = baoHanh.NgayHetHan;
                GVBaoHanh.Rows.Add(dataGridViewRow);
            }
        }
        private void GVBaoHanh_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void UCBaoHanhSanPham_Load(object sender, EventArgs e)
        {
            HienThiDanhSachBaoHanh(); 
        }
    }
}
