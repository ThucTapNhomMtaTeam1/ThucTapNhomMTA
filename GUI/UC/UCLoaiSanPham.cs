using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BLL; 

namespace GUI.UC
{
    public partial class UCLoaiSanPham : UserControl
    {
        public UCLoaiSanPham()
        {
            InitializeComponent();
        }

        private void UCLoaiSanPham_Load(object sender, EventArgs e)
        {
            HienThiDanhSachLoaiSP(); 
        }

        private void HienThiDanhSachLoaiSP()
        {
            HienThiLoaiSanPhamBLL hienThiLoaiSanPhamBLL = new HienThiLoaiSanPhamBLL();
            gvLoaiSanPham.Rows.Clear(); 
            foreach(LoaiSanPham loaiSanPham in hienThiLoaiSanPhamBLL.HienThiDanhSachLoaiSanPham())
            {
                DataGridViewRow dataGridViewRow = new DataGridViewRow();
                dataGridViewRow.CreateCells(gvLoaiSanPham);
                dataGridViewRow.Cells[0].Value = loaiSanPham.MaLoaiSanPham;
                dataGridViewRow.Cells[1].Value = loaiSanPham.TenLoaiSanPham;
                dataGridViewRow.Cells[2].Value = loaiSanPham.DonViTinh;
                dataGridViewRow.Cells[3].Value = loaiSanPham.GhiChu;
                gvLoaiSanPham.Rows.Add(dataGridViewRow); 
            }
        }

        private void gvLoaiSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex > -1)
            {
                DataGridViewRow dataGridViewRow = gvLoaiSanPham.Rows[e.RowIndex];
                textMaLoaiSanPham.Text = dataGridViewRow.Cells[0].Value +"";
                texTenLoaiSanPham.Text = dataGridViewRow.Cells[1].Value + "";
                texDonViTinh.Text = dataGridViewRow.Cells[2].Value + "";
                textBGhiChu.Text = dataGridViewRow.Cells[3].Value + "";
            }
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            textMaLoaiSanPham.Text ="";
            texTenLoaiSanPham.Text ="";
            texDonViTinh.Text ="";
            textBGhiChu.Text ="";
        }

        private void btnDanhSach_Click(object sender, EventArgs e)
        {
            HienThiDanhSachLoaiSP(); 
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            HienThiLoaiSanPhamBLL hienThiLoaiSanPhamBLL = new HienThiLoaiSanPhamBLL();
            List<LoaiSanPham> DanhSachLoaiSP = new List<LoaiSanPham>(); 
            if (radioMa.Checked)
            {
                DanhSachLoaiSP = hienThiLoaiSanPhamBLL.HienThiDanhSachLoaiSanPhamTheoMa(texTimKiem.Text);
                HienThiDanhSach(DanhSachLoaiSP); 
            }
            else if (radioTen.Checked)
            {
                DanhSachLoaiSP = hienThiLoaiSanPhamBLL.HienThiDanhSachLoaiSanPhamTheoTen(texTimKiem.Text);
                HienThiDanhSach(DanhSachLoaiSP);
            }
            else
            {
                MessageBox.Show("Bạn Hãy Nhập Lụa Chọn Trước Khi Tìm Kiếm"); 
            }
        }

        private void HienThiDanhSach(List<LoaiSanPham> danhSachLoaiSP)
        {
            gvLoaiSanPham.Rows.Clear(); 
            foreach(LoaiSanPham loaiSanPham in danhSachLoaiSP)
            {
                DataGridViewRow dataGridViewRow = new DataGridViewRow();
                dataGridViewRow.CreateCells(gvLoaiSanPham);
                dataGridViewRow.Cells[0].Value = loaiSanPham.MaLoaiSanPham;
                dataGridViewRow.Cells[1].Value = loaiSanPham.TenLoaiSanPham;
                dataGridViewRow.Cells[2].Value = loaiSanPham.DonViTinh;
                dataGridViewRow.Cells[3].Value = loaiSanPham.GhiChu;
                gvLoaiSanPham.Rows.Add(dataGridViewRow);
            }

        }

        private void btbLuu_Click(object sender, EventArgs e)
        {
            if (textMaLoaiSanPham.Text == "" || textMaLoaiSanPham.Text == null)
            {
                MessageBox.Show("Bạn Cần Phải Nhập Mã Loại SP Trươc Khi Thêm");
                return; 
            }
            else
            {
                LoaiSanPham loaiSanPham = new LoaiSanPham()
                {
                    MaLoaiSanPham = textMaLoaiSanPham.Text,
                    TenLoaiSanPham = texTenLoaiSanPham.Text,
                    DonViTinh = texDonViTinh.Text,
                    GhiChu = textBGhiChu.Text
                };
                HienThiLoaiSanPhamBLL hienThiLoaiSanPhamBLL = new HienThiLoaiSanPhamBLL();
                hienThiLoaiSanPhamBLL.ThemMoiLoaiSanPham(loaiSanPham);
                HienThiDanhSachLoaiSP(); 
            }
        }

        private void btnChinhSua_Click(object sender, EventArgs e)
        {
            if (textMaLoaiSanPham.Text == "" || textMaLoaiSanPham.Text == null)
            {
                MessageBox.Show("Bạn Cần Phải Nhập Mã Loại SP Trươc Khi Sửa");
                return; 
            }
            else
            {
                LoaiSanPham loaiSanPham = new LoaiSanPham()
                {
                    MaLoaiSanPham = textMaLoaiSanPham.Text,
                    TenLoaiSanPham = texTenLoaiSanPham.Text,
                    DonViTinh = texDonViTinh.Text,
                    GhiChu = textBGhiChu.Text
                };
                HienThiLoaiSanPhamBLL hienThiLoaiSanPhamBLL = new HienThiLoaiSanPhamBLL();
                hienThiLoaiSanPhamBLL.SuaThongTinLoaiSanPham(loaiSanPham);
                HienThiDanhSachLoaiSP();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (textMaLoaiSanPham.Text == "" || textMaLoaiSanPham.Text == null)
            {
                MessageBox.Show("Bạn Cần Phải Chọn Nhân Viên Cần Xóa");
                return; 
            }
            else
            {
                HienThiLoaiSanPhamBLL hienThiLoaiSanPhamBLL = new HienThiLoaiSanPhamBLL();
                hienThiLoaiSanPhamBLL.XoaLoaiSanPham(textMaLoaiSanPham.Text);
                HienThiDanhSachLoaiSP(); 
            }
        }
    }
}
