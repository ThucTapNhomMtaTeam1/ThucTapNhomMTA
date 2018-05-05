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
    public partial class UCNhaCungCap : UserControl
    {
        public UCNhaCungCap()
        {
            InitializeComponent();
        }

        private void UCNhaCungCap_Load(object sender, EventArgs e)
        {
            HienThiDanhSachNCC(); 
        }

        private void HienThiDanhSachNCC()
        {
            HienThiNhaCungCapBLL hienThiNhaCungCapBLL = new HienThiNhaCungCapBLL();
            gvNhaCungCap.Rows.Clear(); 
            foreach(NhaCungCap nhaCungCap in hienThiNhaCungCapBLL.HienThiDanhSachNCC())
            {
                DataGridViewRow dataGridViewRow = new DataGridViewRow();
                dataGridViewRow.CreateCells(gvNhaCungCap);
                dataGridViewRow.Cells[0].Value = nhaCungCap.MaNhaCungCap;
                dataGridViewRow.Cells[1].Value = nhaCungCap.TenNhaCungCap;
                dataGridViewRow.Cells[2].Value = nhaCungCap.DiaChi;
                dataGridViewRow.Cells[3].Value = nhaCungCap.SoDienThoai;
                gvNhaCungCap.Rows.Add(dataGridViewRow); 
            }
        }

        private void gvNhaCungCap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                DataGridViewRow dataGridViewRow = gvNhaCungCap.Rows[e.RowIndex];
                texMaNhaCungCap.Text = dataGridViewRow.Cells[0].Value + "";
                texTenNhaCC.Text = dataGridViewRow.Cells[1].Value + "";
                texDiaChi.Text = dataGridViewRow.Cells[2].Value + "";
                texDienThoai.Text = dataGridViewRow.Cells[3].Value + "";
            }
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            texMaNhaCungCap.Text = "";
            texTenNhaCC.Text = "";
            texDiaChi.Text = "";
            texDienThoai.Text ="";
        }

        private void btnDanhSach_Click(object sender, EventArgs e)
        {
            HienThiDanhSachNCC(); 
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            HienThiNhaCungCapBLL hienThiNhaCungCapBLL = new HienThiNhaCungCapBLL();
            List<NhaCungCap> DanhSachNhaCungCap = new List<NhaCungCap>(); 
            
            if (radioMa.Checked)
            {
                DanhSachNhaCungCap = hienThiNhaCungCapBLL.HienThiDanhSachNCCTheoMa(texTimKiem.Text);
                HienThiDanhSach(DanhSachNhaCungCap); 
            }
            else if (radioTen.Checked)
            {
                DanhSachNhaCungCap = hienThiNhaCungCapBLL.HienThiDanhSachNCCTheoTen(texTimKiem.Text);
                HienThiDanhSach(DanhSachNhaCungCap);
            }
            else
            {
                MessageBox.Show("Bạn Cần Nhập Lựa Chọn Trước Khi Tìm Kiếm"); 
            }
        }

        private void HienThiDanhSach(List<NhaCungCap> danhSachNhaCungCap)
        {
            gvNhaCungCap.Rows.Clear();
            foreach (NhaCungCap nhaCungCap in danhSachNhaCungCap)
            {
                DataGridViewRow dataGridViewRow = new DataGridViewRow();
                dataGridViewRow.CreateCells(gvNhaCungCap);
                dataGridViewRow.Cells[0].Value = nhaCungCap.MaNhaCungCap;
                dataGridViewRow.Cells[1].Value = nhaCungCap.TenNhaCungCap;
                dataGridViewRow.Cells[2].Value = nhaCungCap.DiaChi;
                dataGridViewRow.Cells[3].Value = nhaCungCap.SoDienThoai;
                gvNhaCungCap.Rows.Add(dataGridViewRow);
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if(texMaNhaCungCap.Text == ""||texMaNhaCungCap.Text ==null)
            {
                MessageBox.Show("Mã Nhà Cung Cấp Không Được Để Trống"); 
            }
            else
            {
                NhaCungCap nhaCungCap = new NhaCungCap()
                {
                    MaNhaCungCap = texMaNhaCungCap.Text,
                    TenNhaCungCap = texTenNhaCC.Text,
                    DiaChi = texDiaChi.Text,
                    SoDienThoai = texDienThoai.Text
                };
                HienThiNhaCungCapBLL hienThiNhaCungCapBLL = new HienThiNhaCungCapBLL();
                hienThiNhaCungCapBLL.ThemMoiNhaCungCap(nhaCungCap);
                HienThiDanhSachNCC(); 

            }

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (texMaNhaCungCap.Text == "" || texMaNhaCungCap.Text == null)
            {
                MessageBox.Show("Mã Nhà Cung Cấp Không Được Để Trống");
            }
            else
            {
                HienThiNhaCungCapBLL hienThiNhaCungCapBLL = new HienThiNhaCungCapBLL();
                hienThiNhaCungCapBLL.XoaNhaCungCap(texMaNhaCungCap.Text);
                HienThiDanhSachNCC();
            }
        }

        private void btnChinhSua_Click(object sender, EventArgs e)
        {
            if (texMaNhaCungCap.Text == "" || texMaNhaCungCap.Text == null)
            {
                MessageBox.Show("Mã Nhà Cung Cấp Không Được Để Trống");
            }
            else
            {
                NhaCungCap nhaCungCap = new NhaCungCap()
                {
                    MaNhaCungCap = texMaNhaCungCap.Text,
                    TenNhaCungCap = texTenNhaCC.Text,
                    DiaChi = texDiaChi.Text,
                    SoDienThoai = texDienThoai.Text
                };
                HienThiNhaCungCapBLL hienThiNhaCungCapBLL = new HienThiNhaCungCapBLL();
                hienThiNhaCungCapBLL.ChinhSuaNhaCungCap(nhaCungCap);
                HienThiDanhSachNCC();

            }
        }
    }
}
