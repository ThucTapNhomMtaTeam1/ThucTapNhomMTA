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
    public partial class UCLoaiKhacHang : UserControl
    {
        public UCLoaiKhacHang()
        {
            InitializeComponent();
        }

        private void UCLoaiKhacHang_Load(object sender, EventArgs e)
        {
            HienThiDanhSachLKH(); 
        }

        private void HienThiDanhSachLKH()
        {
            HienThiLoaiKhachHangBLL hienThiLoaiKhachHangBLL = new HienThiLoaiKhachHangBLL();
            gvLoaiKhachHang.Rows.Clear(); 
            foreach(LoaiKhachHang loaiKhachHang in hienThiLoaiKhachHangBLL.HienThiDanhSachLoaiKhachHang())
            {
                DataGridViewRow dataGridViewRow = new DataGridViewRow();
                dataGridViewRow.CreateCells(gvLoaiKhachHang);
                dataGridViewRow.Cells[0].Value = loaiKhachHang.MaLoaiKhachHang;
                dataGridViewRow.Cells[1].Value = loaiKhachHang.TenLoaiKhachHang;
                dataGridViewRow.Cells[2].Value = loaiKhachHang.KhuyenMai;
                gvLoaiKhachHang.Rows.Add(dataGridViewRow); 
            }
        }

        private void gvLoaiKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex > -1)
            {
                DataGridViewRow dataGridViewRow = gvLoaiKhachHang.Rows[e.RowIndex];
                texMaLoaiKH.Text = dataGridViewRow.Cells[0].Value + "";
                texTenLoaiKH.Text = dataGridViewRow.Cells[1].Value + "";
                TexKhuyenMai.Text = dataGridViewRow.Cells[2].Value + "";
            }
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            texMaLoaiKH.Text =  "";
            texTenLoaiKH.Text = "";
            TexKhuyenMai.Text = "";
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(texMaLoaiKH.Text == "" ||texTenLoaiKH.Text == null)
            {
                MessageBox.Show("Bạn Cần Chọn Loại Khach Hàng Cần Xóa");
                return; 
            }
            else
            {
                HienThiLoaiKhachHangBLL hienThiLoaiKhachHangBLL = new HienThiLoaiKhachHangBLL();
                hienThiLoaiKhachHangBLL.XoaLoaiKhachHang(texMaLoaiKH.Text);
                HienThiDanhSachLKH(); 
            }
        }

        private void btbLuu_Click(object sender, EventArgs e)
        {
            if (texMaLoaiKH.Text == "" || texTenLoaiKH.Text == null)
            {
                MessageBox.Show("Bạn Cần Phải Có Mã Loại Khách Hàng");
                return;
            }
            HienThiLoaiKhachHangBLL hienThiLoaiKhachHangBLL = new HienThiLoaiKhachHangBLL();
            LoaiKhachHang loaiKhachHang = new LoaiKhachHang()
            {
                MaLoaiKhachHang = texMaLoaiKH.Text,
                TenLoaiKhachHang = texTenLoaiKH.Text,
                KhuyenMai = TexKhuyenMai.Text 
            };
            hienThiLoaiKhachHangBLL.ThemLoaiKhachHang(loaiKhachHang);
            HienThiDanhSachLKH(); 
        }

        private void btnChinhSua_Click(object sender, EventArgs e)
        {
            if (texMaLoaiKH.Text == "" || texTenLoaiKH.Text == null)
            {
                MessageBox.Show("Bạn Cần Phải Có Mã Loại Khách Hàng");
                return;
            }
            HienThiLoaiKhachHangBLL hienThiLoaiKhachHangBLL = new HienThiLoaiKhachHangBLL();
            LoaiKhachHang loaiKhachHang = new LoaiKhachHang()
            {
                MaLoaiKhachHang = texMaLoaiKH.Text,
                TenLoaiKhachHang = texTenLoaiKH.Text,
                KhuyenMai = TexKhuyenMai.Text
            };
            hienThiLoaiKhachHangBLL.SuaLoaiKhachHang(loaiKhachHang);
            HienThiDanhSachLKH();
        }

        private void btnDanhSach_Click(object sender, EventArgs e)
        {
            HienThiDanhSachLKH(); 
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            HienThiLoaiKhachHangBLL hienThiLoaiKhachHangBLL = new HienThiLoaiKhachHangBLL();
            List<LoaiKhachHang> DanhSachLKH = new List<LoaiKhachHang>(); 
            if (radioMa.Checked)
            {
                DanhSachLKH = hienThiLoaiKhachHangBLL.HienThiDanhSachLKHTheoMa(texTimKiem.Text);
                HienThiDSTheoMa(DanhSachLKH); 
            }
            else if (radioTen.Checked)
            {
                DanhSachLKH = hienThiLoaiKhachHangBLL.HienThiDanhSachLKHTheoTen(texTimKiem.Text);
                HienThiDSTheoMa(DanhSachLKH);
            }
            else
            {
                MessageBox.Show("Bạn Cần Nhập Lựa Chon Trước Khi Tìm Kiếm"); 
            }
        }

        private void HienThiDSTheoMa(List<LoaiKhachHang> danhSachLKH)
        {
            gvLoaiKhachHang.Rows.Clear(); 
            foreach(LoaiKhachHang loaiKhachHang in danhSachLKH)
            {
                DataGridViewRow dataGridViewRow = new DataGridViewRow();
                dataGridViewRow.CreateCells(gvLoaiKhachHang);
                dataGridViewRow.Cells[0].Value = loaiKhachHang.MaLoaiKhachHang;
                dataGridViewRow.Cells[1].Value = loaiKhachHang.TenLoaiKhachHang;
                dataGridViewRow.Cells[2].Value = loaiKhachHang.KhuyenMai;
                gvLoaiKhachHang.Rows.Add(dataGridViewRow);
            }
        }
    }
}
