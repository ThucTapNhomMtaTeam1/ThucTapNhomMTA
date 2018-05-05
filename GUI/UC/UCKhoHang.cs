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
    public partial class UCKhoHang : UserControl
    {
        public UCKhoHang()
        {
            InitializeComponent();
        }

        private void labelX8_Click(object sender, EventArgs e)
        {

        }

        private void UCKhoHang_Load(object sender, EventArgs e)
        {
            HienThiDanhSachKhoHang(); 
        }

        private void HienThiDanhSachKhoHang()
        {
            HienThiKhoHangBLL hienThiKhoHangBLL = new HienThiKhoHangBLL();
            gvDanhSachKhoHang.Rows.Clear(); 
            foreach (KhoHang khoHang in hienThiKhoHangBLL.LayToanBoKhoHang())
            {
                DataGridViewRow dataGridViewRow = new DataGridViewRow();
                dataGridViewRow.CreateCells(gvDanhSachKhoHang);
                dataGridViewRow.Cells[0].Value = khoHang.MaKhoHang;
                dataGridViewRow.Cells[1].Value = khoHang.TenKhoHang;
                dataGridViewRow.Cells[2].Value = khoHang.DiaChi;
                dataGridViewRow.Cells[3].Value = khoHang.SoDienThoai;
                gvDanhSachKhoHang.Rows.Add(dataGridViewRow); 

            }
        }

        private void gvDanhSachKhoHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex > -1)
            {
                DataGridViewRow dataGridViewRow = gvDanhSachKhoHang.Rows[e.RowIndex];
                texMaKhoHang.Text = dataGridViewRow.Cells[0].Value +"";
                texTenKhoHang.Text = dataGridViewRow.Cells[1].Value + "";
                texDiaChi.Text = dataGridViewRow.Cells[2].Value + "";
                texDienThoai.Text = dataGridViewRow.Cells[3].Value + ""; 
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            texMaKhoHang.Text = "";
            texTenKhoHang.Text = "";
            texDiaChi.Text = "";
            texDienThoai.Text = "";
        }

        private void btnLuuKH_Click(object sender, EventArgs e)
        {
            if (texMaKhoHang.Text == "" || texMaKhoHang.Text == null)
            {
                MessageBox.Show("Mã Kho Hàng Không Được Để Trống");
                return;
            }
            else
            {
                KhoHang khoHang = new KhoHang()
                {
                    MaKhoHang = texMaKhoHang.Text,
                    TenKhoHang = texTenKhoHang.Text,
                    DiaChi = texDiaChi.Text,
                    SoDienThoai = texDienThoai.Text
                };
                HienThiKhoHangBLL hienThiKhoHangBLL = new HienThiKhoHangBLL();
                hienThiKhoHangBLL.ThemMoiKhoHang(khoHang);
                HienThiDanhSachKhoHang();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (texMaKhoHang.Text == "" || texMaKhoHang.Text == null)
            {
                MessageBox.Show("Mã Kho Hàng Không Được Để Trống");
                return;
            }
            else
            {
                KhoHang khoHang = new KhoHang()
                {
                    MaKhoHang = texMaKhoHang.Text,
                    TenKhoHang = texTenKhoHang.Text,
                    DiaChi = texDiaChi.Text,
                    SoDienThoai = texDienThoai.Text
                };
                HienThiKhoHangBLL hienThiKhoHangBLL = new HienThiKhoHangBLL();
                hienThiKhoHangBLL.ChinhSuaKhoHang(khoHang);
                HienThiDanhSachKhoHang();
            }
        }

        private void btnXoa1_Click(object sender, EventArgs e)
        {
            if (texMaKhoHang.Text == "" || texMaKhoHang.Text == null)
            {
                MessageBox.Show("Mã Kho Hàng Không Được Để Trống");
                return;
            }
            else
            {
                KhoHang khoHang = new KhoHang()
                {
                    MaKhoHang = texMaKhoHang.Text,
                    TenKhoHang = texTenKhoHang.Text,
                    DiaChi = texDiaChi.Text,
                    SoDienThoai = texDienThoai.Text
                };
                HienThiKhoHangBLL hienThiKhoHangBLL = new HienThiKhoHangBLL();
                hienThiKhoHangBLL.XoaKhoHang(khoHang);
                HienThiDanhSachKhoHang(); 
            }
        }

        private void buttonTimKiem_Click(object sender, EventArgs e)
        {

            HienThiKhoHangBLL hienThiKhoHangBLL = new HienThiKhoHangBLL();
            
            List<KhoHang> DanhSachKhoHang = new List<KhoHang>(); 
            if (radioMaKho.Checked)
            {

                DanhSachKhoHang = hienThiKhoHangBLL.HienThiKhoHangTheoMa(texTimKiemKho.Text);
                HienThiTimKiem(DanhSachKhoHang); 

            }
            else if (radiotenKho.Checked)
            {
                DanhSachKhoHang = hienThiKhoHangBLL.HienThiKhoHangTheoTen(texTimKiemKho.Text);
                HienThiTimKiem(DanhSachKhoHang);
            }
            else
            {
                MessageBox.Show("Bạn Cần Phải Chọn Cách Thức Tìm Kiếm"); 
            }
             
        }

        private void HienThiTimKiem(List<KhoHang> DanhSachKhoHang)
        {
            gvDanhSachKhoHang.Rows.Clear();
            foreach (KhoHang khoHang in DanhSachKhoHang)
            {
                DataGridViewRow dataGridViewRow = new DataGridViewRow();
                dataGridViewRow.CreateCells(gvDanhSachKhoHang);
                dataGridViewRow.Cells[0].Value = khoHang.MaKhoHang;
                dataGridViewRow.Cells[1].Value = khoHang.TenKhoHang;
                dataGridViewRow.Cells[2].Value = khoHang.DiaChi;
                dataGridViewRow.Cells[3].Value = khoHang.SoDienThoai;
                gvDanhSachKhoHang.Rows.Add(dataGridViewRow);
            }
        }

        private void btnDanhSach_Click(object sender, EventArgs e)
        {
            HienThiDanhSachKhoHang(); 
        }
    }
}
