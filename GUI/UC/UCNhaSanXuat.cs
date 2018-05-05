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
    public partial class UCNhaSanXuat : UserControl
    {
        public UCNhaSanXuat()
        {
            InitializeComponent();
        }

        

        private void UCNhaSanXuat_Load(object sender, EventArgs e)
        {
            HienThiDanhSachNXX(); 
        }

        private void HienThiDanhSachNXX()
        {
            HienThiNhaSanXuatBLL hienThiNhaSanXuatBLL = new HienThiNhaSanXuatBLL();
            gvNhaSanXuat.Rows.Clear(); 
            foreach(NhaSanXuat nhaSanXuat in hienThiNhaSanXuatBLL.HienThiDanhSachNSX())
            {
                DataGridViewRow dataGridViewRow = new DataGridViewRow();
                dataGridViewRow.CreateCells(gvNhaSanXuat);
                dataGridViewRow.Cells[0].Value = nhaSanXuat.MaNhaSanXuat;
                dataGridViewRow.Cells[1].Value = nhaSanXuat.TenNhaSanXuat;
                dataGridViewRow.Cells[2].Value = nhaSanXuat.QuocGia;
                gvNhaSanXuat.Rows.Add(dataGridViewRow); 
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if(textMaNhaSX.Text == "" || textMaNhaSX == null)
            {
                MessageBox.Show("Mã Nhà Sản Xuất Không Đươc Để Trống");
                return; 
            }
            else
            {
                NhaSanXuat nhaSanXuat = new NhaSanXuat()
                {
                    MaNhaSanXuat = textMaNhaSX.Text,
                    TenNhaSanXuat = texTenNhaSX.Text,
                    QuocGia = texQuocGia.Text
                };
                HienThiNhaSanXuatBLL hienThiNhaSanXuatBLL = new HienThiNhaSanXuatBLL();
                hienThiNhaSanXuatBLL.ThemMoiNhaSanXuat(nhaSanXuat);
                HienThiDanhSachNXX(); 
            }
        }

        private void gvNhaSanXuat_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex > -1)
            {
                DataGridViewRow dataGridViewRow = gvNhaSanXuat.Rows[e.RowIndex];
                textMaNhaSX.Text = dataGridViewRow.Cells[0].Value + "";
                texTenNhaSX.Text = dataGridViewRow.Cells[1].Value + "";
                texQuocGia.Text = dataGridViewRow.Cells[2].Value + "";
            }
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            textMaNhaSX.Text ="";
            texTenNhaSX.Text ="";
            texQuocGia.Text ="";
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            HienThiNhaSanXuatBLL hienThiNhaSanXuatBLL = new HienThiNhaSanXuatBLL();
            List<NhaSanXuat> DanhSach = new List<NhaSanXuat>(); 
            if (radioMa.Checked)
            {
                DanhSach = hienThiNhaSanXuatBLL.HienThiDanhSachNSXTheoMa(textimKiem.Text);
                HienThiDanhSach(DanhSach); 
            }
            else if (radioTen.Checked)
            {
                DanhSach = hienThiNhaSanXuatBLL.HienThiDanhSachNSXTheoTen(textimKiem.Text);
                HienThiDanhSach(DanhSach);
            }
            else if (radioQuocGia.Checked)
            {
                DanhSach = hienThiNhaSanXuatBLL.HienThiDanhSachNSXTheoQuocGia(textimKiem.Text);
                HienThiDanhSach(DanhSach);
            }
            else
            {
                MessageBox.Show("Bạn Cần Chọn Danh Mục Tìm Kiếm ");
                return; 
            }
        }

        private void HienThiDanhSach(List<NhaSanXuat> danhSach)
        {
            gvNhaSanXuat.Rows.Clear(); 
            foreach(NhaSanXuat nhaSanXuat in danhSach)
            {
                DataGridViewRow dataGridViewRow = new DataGridViewRow();
                dataGridViewRow.CreateCells(gvNhaSanXuat);
                dataGridViewRow.Cells[0].Value = nhaSanXuat.MaNhaSanXuat;
                dataGridViewRow.Cells[1].Value = nhaSanXuat.TenNhaSanXuat;
                dataGridViewRow.Cells[2].Value = nhaSanXuat.QuocGia;
                gvNhaSanXuat.Rows.Add(dataGridViewRow);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (textMaNhaSX.Text == "" || textMaNhaSX == null)
            {
                MessageBox.Show("Mã Nhà Sản Xuất Không Đươc Để Trống");
                return; 
            }
            else
            {
                HienThiNhaSanXuatBLL hienThiNhaSanXuatBLL = new HienThiNhaSanXuatBLL();
                hienThiNhaSanXuatBLL.XoaThongTinNXX(textMaNhaSX.Text);
                HienThiDanhSachNXX(); 
            }

        }

        private void btnDanhSach_Click(object sender, EventArgs e)
        {
            HienThiDanhSachNXX(); 
        }
    }
}
