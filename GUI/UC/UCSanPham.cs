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
    public partial class UCSanPham : UserControl
    {
        public UCSanPham()
        {
            InitializeComponent();
        }

        private void UCSanPham_Load(object sender, EventArgs e)
        {
            HienThiCacDanhMucTreeView();
            HienThiDanhSachSanPham(); 
        }

        private void HienThiDanhSachSanPham()
        {
            HienThiSanPhamBLL hienThiSanPhamBLL = new HienThiSanPhamBLL();
            gvDanhSachSanPham.Rows.Clear();
            double tongTien = 0; int SoLuongSanPham = 0;
            foreach (SanPham sanPham in hienThiSanPhamBLL.HienThiDanhSachSanPham())
            {
                DataGridViewRow dataGridViewRow = new DataGridViewRow();
                dataGridViewRow.CreateCells(gvDanhSachSanPham);
                dataGridViewRow.Cells[0].Value = sanPham.MaSanPham;
                dataGridViewRow.Cells[1].Value = sanPham.TenSanPham;
                dataGridViewRow.Cells[2].Value = sanPham.SoLuong;
                dataGridViewRow.Cells[3].Value = sanPham.DonGia;
                dataGridViewRow.Cells[4].Value = sanPham.KhoHang;
                dataGridViewRow.Cells[5].Value = sanPham.LoaiSanPham;
                dataGridViewRow.Cells[6].Value = sanPham.NhaCungCap;
                dataGridViewRow.Cells[7].Value = sanPham.NhaSanXuat;
                gvDanhSachSanPham.Rows.Add(dataGridViewRow);
                SoLuongSanPham++;
                tongTien = tongTien + sanPham.DonGia;
            }
            texTongSP.Text = SoLuongSanPham + "";
            texTongGiaNhap.Text = tongTien + "";
        }

        private void HienThiCacDanhMucTreeView()
        {
           
            for(int i = 1; i < tvPhanLoaiSanPham.Nodes.Count; i++)
            {
                for (int j = 0; j < tvPhanLoaiSanPham.Nodes[i].Nodes.Count; j++)
                {
                    tvPhanLoaiSanPham.Nodes[i].Nodes[j].Remove(); 
                }
            }
            HienThiLoaiSanPhamBLL hienThiLoaiSanPhamBLL = new HienThiLoaiSanPhamBLL();
            foreach (LoaiSanPham LoaiSanPham in hienThiLoaiSanPhamBLL.HienThiDanhSachLoaiSanPham())
            {
                TreeNode treeNode = new TreeNode(LoaiSanPham.TenLoaiSanPham);
                tvPhanLoaiSanPham.Nodes[2].Nodes.Add(treeNode);
                cbLoaiHang.Items.Add(LoaiSanPham);
                treeNode.Tag = LoaiSanPham; 
            }
            HienThiKhoHangBLL hienThiKhoHangBLL = new HienThiKhoHangBLL(); 
            foreach(KhoHang khoHang in hienThiKhoHangBLL.LayToanBoKhoHang())
            {
                TreeNode treeNode = new TreeNode(khoHang.TenKhoHang);
                tvPhanLoaiSanPham.Nodes[1].Nodes.Add(treeNode);
                cbKhoHang.Items.Add(khoHang);
                treeNode.Tag = khoHang;
            }
            HienThiNhaCungCapBLL hienThiNhaCungCapBLL = new HienThiNhaCungCapBLL(); 
            foreach(NhaCungCap NhaCungCap in hienThiNhaCungCapBLL.HienThiDanhSachNCC())
            {
                TreeNode treeNode = new TreeNode(NhaCungCap.TenNhaCungCap);
                tvPhanLoaiSanPham.Nodes[3].Nodes.Add(treeNode);
                cbNhaPhanPhoi.Items.Add(NhaCungCap);
                treeNode.Tag = NhaCungCap;
            }
            HienThiNhaSanXuatBLL hienThiNhaSanXuatBLL = new HienThiNhaSanXuatBLL(); 
            foreach(NhaSanXuat nhaSanXuat in hienThiNhaSanXuatBLL.HienThiDanhSachNSX())
            {
                TreeNode treeNode = new TreeNode("Nhà Sản Xuất " + nhaSanXuat.TenNhaSanXuat);
                tvPhanLoaiSanPham.Nodes[4].Nodes.Add(treeNode);
                cbNhaSanXuat.Items.Add(nhaSanXuat);
                treeNode.Tag = nhaSanXuat;
            }
            //HienThiNhaSanXuatBLL hienSoLuongBLL = new HienThiNhaSanXuatBLL();
            //foreach (S soluong in hienThiNhaSanXuatBLL.HienThiDanhSachNSX())
            //{
            //    TreeNode treeNode = new TreeNode("So Luong " + nhaSanXuat.TenNhaSanXuat);
            //    tvPhanLoaiSanPham.Nodes[4].Nodes.Add(treeNode);
            //    cbNhaSanXuat.Items.Add(nhaSanXuat);
            //    treeNode.Tag = nhaSanXuat;
            //}
        }

        private void tvPhanLoaiSanPham_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node != null)
            {
               if(e.Node.Level == 0)
                {
                    e.Node.ExpandAll(); 
                }
            }
            HienThiSanPhamBLL hienThiSanPhamBLL = new HienThiSanPhamBLL();
            List<SanPham> DanhSachSanPham = new List<SanPham>(); 
            if(e.Node.Level == 1)
            {
                if(tvPhanLoaiSanPham.Nodes[0].Nodes[0]== e.Node)
                {
                    HienThiDanhSachSanPham(); 
                }
            }
            for (int i = 0; i < tvPhanLoaiSanPham.Nodes[1].Nodes.Count; i++)
            {
                if (e.Node.Level == 1)
                {
                    if (tvPhanLoaiSanPham.Nodes[1].Nodes[i] == e.Node)
                    {
                        KhoHang khoHang = e.Node.Tag as KhoHang;
                        DanhSachSanPham = hienThiSanPhamBLL.HienThiDanhSachSanPhamTheoKho(khoHang.MaKhoHang);
                        HienThiDanhSachSanPham(DanhSachSanPham);
                        break;
                    }
                }
            }

            for(int i = 0; i < tvPhanLoaiSanPham.Nodes[2].Nodes.Count; i++)
            {
                if(e.Node.Level == 1)
                {
                    if (tvPhanLoaiSanPham.Nodes[2].Nodes[i] == e.Node)
                    {
                        LoaiSanPham loaiSanPham = e.Node.Tag as LoaiSanPham;
                        DanhSachSanPham = hienThiSanPhamBLL.HienThiDanhSachSanPhamTheoLoaiSP(loaiSanPham.MaLoaiSanPham);
                        HienThiDanhSachSanPham(DanhSachSanPham);
                        break;
                    }
                    
                }
            }

            for (int i = 0; i < tvPhanLoaiSanPham.Nodes[3].Nodes.Count; i++)
            {
                if (e.Node.Level == 1)
                {
                    
                    if (tvPhanLoaiSanPham.Nodes[3].Nodes[i] == e.Node)
                    {
                        NhaCungCap nhaCungCap = e.Node.Tag as NhaCungCap;
                        DanhSachSanPham = hienThiSanPhamBLL.HienThiDanhSachSanPhamTheoNCC(nhaCungCap.MaNhaCungCap);
                        HienThiDanhSachSanPham(DanhSachSanPham);
                        break;
                    }
                }
            }

            for (int i = 0; i < tvPhanLoaiSanPham.Nodes[4].Nodes.Count; i++)
            {
                if (e.Node.Level == 1)
                {

                    if (tvPhanLoaiSanPham.Nodes[4].Nodes[i] == e.Node)
                    {
                        NhaSanXuat nhaSanXuat = e.Node.Tag as NhaSanXuat;
                        DanhSachSanPham = hienThiSanPhamBLL.HienThiDanhSachSanPhamTheoNSX(nhaSanXuat.MaNhaSanXuat);
                        HienThiDanhSachSanPham(DanhSachSanPham);
                        break;
                    }
                }
            }

            //for (int i = 0; i < tvPhanLoaiSanPham.Nodes[5].Nodes.Count; i++)
            //{
            //    if (e.Node.Level == 1)
            //    {

            //        if (tvPhanLoaiSanPham.Nodes[5].Nodes[i] == e.Node)
            //        {
            //            SanPham soluong = e.Node.Tag as SanPham;
            //            DanhSachSanPham = hienThiSanPhamBLL.HienThiDanhSachSanPhamTheSoLuong(soluong.SoLuong);
            //            HienThiDanhSachSanPham(DanhSachSanPham);
            //            break;
            //        }
            //    }
            //}
            /*
            if (e.Node.Level == 2)
            {
                KhoHang khoHang = e.Node.Tag as KhoHang;
                HienThiDanhSachNhanVienTheoKhoHang(khoHang);
                KKhoHang = khoHang;
            }
            else
            {
                KKhoHang = null;
                return;
            }
            */
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            texMaSanPham.Text = "";
            texTenSanPham.Text = "";
            textGiaThanh.Text = "";
            texSoLuong.Text = "";
            cbKhoHang.SelectedItem = null;
            cbLoaiHang.SelectedItem = null;
            cbNhaPhanPhoi.SelectedItem = null;
            cbNhaSanXuat.SelectedItem = null; 
        }

       
        private void HienThiDanhSachSanPham(List<SanPham> danhSachSanPham)
        {
            double tongTien = 0; int SoLuongSanPham = 0; 
            gvDanhSachSanPham.Rows.Clear(); 
            foreach(SanPham sanPham in danhSachSanPham)
            {
                DataGridViewRow dataGridViewRow = new DataGridViewRow();
                dataGridViewRow.CreateCells(gvDanhSachSanPham);
                dataGridViewRow.Cells[0].Value = sanPham.MaSanPham;
                dataGridViewRow.Cells[1].Value = sanPham.TenSanPham;
                dataGridViewRow.Cells[2].Value = sanPham.SoLuong;
                dataGridViewRow.Cells[3].Value = sanPham.DonGia;
                dataGridViewRow.Cells[4].Value = sanPham.KhoHang;
                dataGridViewRow.Cells[5].Value = sanPham.LoaiSanPham;
                dataGridViewRow.Cells[6].Value = sanPham.NhaCungCap;
                dataGridViewRow.Cells[7].Value = sanPham.NhaSanXuat;
                gvDanhSachSanPham.Rows.Add(dataGridViewRow);
                SoLuongSanPham++;
                tongTien = tongTien + sanPham.DonGia; 
            }
            texTongSP.Text = SoLuongSanPham + "";
            texTongGiaNhap.Text = tongTien + ""; 
        }

        private void gvDanhSachSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > 1)
            {
                DataGridViewRow dataGridViewRow = gvDanhSachSanPham.Rows[e.RowIndex];
                texMaSanPham.Text = dataGridViewRow.Cells[0].Value + ""; 
                texTenSanPham.Text = dataGridViewRow.Cells[1].Value + "";
                texSoLuong.Text = dataGridViewRow.Cells[2].Value + "";
                textGiaThanh.Text = dataGridViewRow.Cells[3].Value + ""; 
                for(int i  = 0; i < cbKhoHang.Items.Count; i++)
                {
                    KhoHang khoHang = cbKhoHang.Items[i] as KhoHang; 
                    if(khoHang.TenKhoHang == dataGridViewRow.Cells[4].Value + "")
                    {
                        cbKhoHang.SelectedItem = khoHang; 
                    }
                }
                for (int i = 0; i < cbLoaiHang.Items.Count; i++)
                {
                    LoaiSanPham loaiSanPham = cbLoaiHang.Items[i] as LoaiSanPham;
                    if (loaiSanPham.TenLoaiSanPham == dataGridViewRow.Cells[5].Value + "")
                    {
                        cbLoaiHang.SelectedItem = loaiSanPham;
                    }
                }

                for (int i = 0; i < cbNhaPhanPhoi.Items.Count; i++)
                {
                    NhaCungCap nhaCungCap = cbNhaPhanPhoi.Items[i] as NhaCungCap;
                    if (nhaCungCap.TenNhaCungCap == dataGridViewRow.Cells[6].Value + "")
                    {
                        cbNhaPhanPhoi.SelectedItem = nhaCungCap;
                    }
                }

                for (int i = 0; i < cbNhaSanXuat.Items.Count; i++)
                {
                    NhaSanXuat nhaSanXuat = cbNhaSanXuat.Items[i] as NhaSanXuat;
                    if (nhaSanXuat.TenNhaSanXuat == dataGridViewRow.Cells[7].Value + "")
                    {
                        cbNhaSanXuat.SelectedItem = nhaSanXuat;
                    }
                }
            }
        }

       
        private void btnChinhSua_Click(object sender, EventArgs e)
        {
            if (texSoLuong.Text == null || texSoLuong.Text == "")
            {
                texSoLuong.Text = "0";
            }

            if (textGiaThanh.Text == null || textGiaThanh.Text == "")
            {
                textGiaThanh.Text = "0";
            }
            if (texMaSanPham.Text == null)
            {
                MessageBox.Show("Bạn Cần Nhập Mã Sản Phâm Trước Khi Lưu");
                return;
            }
            else if (cbKhoHang.SelectedIndex == -1)
            {
                MessageBox.Show("Bạn Cần Chọn Kho Hàng Trước Khi Lưu");
                return;
            }
            else if (cbLoaiHang.SelectedIndex == -1)
            {
                MessageBox.Show("Bạn Cần Chọn Loại Hàng Trước Khi Lưu");
                return;
            }
            else if (cbNhaSanXuat.SelectedIndex == -1)
            {
                MessageBox.Show("Bạn Cần Chọn Nhà Sản Xuất Trước Khi Lưu");
                return;
            }
            else if (cbNhaPhanPhoi.SelectedIndex == -1)
            {
                MessageBox.Show("Bạn Cần Chọn Nhà Cung Cấp Trước Khi Lưu");
                return;
            }

            if (texTenSanPham.Text == null || texTenSanPham.Text == "")
            {
                texTenSanPham.Text = "-";
            }

            HienThiSanPhamBLL hienThiSanPhamBLL = new HienThiSanPhamBLL();
            SanPham sanPham = new SanPham()
            {
                LoaiSanPham = cbLoaiHang.Text,
                TenSanPham = texTenSanPham.Text,
                SoLuong = int.Parse(texSoLuong.Text),
                DonGia = double.Parse(texSoLuong.Text),
                MaSanPham = texMaSanPham.Text,
                KhoHang = cbKhoHang.Text,
                NhaCungCap = cbNhaPhanPhoi.Text,
                NhaSanXuat = cbNhaSanXuat.Text 
            };
            hienThiSanPhamBLL.ChinhSuaThongtinSanPham(sanPham); 

        }

        private void btbLuu_Click_1(object sender, EventArgs e)
        {
            if (texSoLuong.Text == null || texSoLuong.Text == "")
            {
                texSoLuong.Text = "0";
            }

            if (textGiaThanh.Text == null || textGiaThanh.Text == "")
            {
                textGiaThanh.Text = "0";
            }
            if (texMaSanPham.Text == null)
            {
                MessageBox.Show("Bạn Cần Nhập Mã Sản Phâm Trước Khi Lưu");
                return;
            }
            else if (cbKhoHang.SelectedIndex == -1)
            {
                MessageBox.Show("Bạn Cần Chọn Kho Hàng Trước Khi Lưu");
                return;
            }
            else if (cbLoaiHang.SelectedIndex == -1)
            {
                MessageBox.Show("Bạn Cần Chọn Loại Hàng Trước Khi Lưu");
                return;
            }
            else if (cbNhaSanXuat.SelectedIndex == -1)
            {
                MessageBox.Show("Bạn Cần Chọn Nhà Sản Xuất Trước Khi Lưu");
                return;
            }
            else if (cbNhaPhanPhoi.SelectedIndex == -1)
            {
                MessageBox.Show("Bạn Cần Chọn Nhà Cung Cấp Trước Khi Lưu");
                return;
            }

            if (texTenSanPham.Text == null || texTenSanPham.Text == "")
            {
                texTenSanPham.Text = "-";
            }

            HienThiSanPhamBLL hienThiSanPhamBLL = new HienThiSanPhamBLL();
            SanPham sanPham = new SanPham()
            {
                LoaiSanPham = cbLoaiHang.Text,
                TenSanPham = texTenSanPham.Text,
                SoLuong = int.Parse(texSoLuong.Text),
                DonGia = double.Parse(texSoLuong.Text),
                MaSanPham = texMaSanPham.Text,
                KhoHang = cbKhoHang.Text,
                NhaCungCap = cbNhaPhanPhoi.Text,
                NhaSanXuat = cbNhaSanXuat.Text
            };
            hienThiSanPhamBLL.ThemMoiSanPham(sanPham);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (texMaSanPham.Text == null)
            {
                MessageBox.Show("Bạn Cần Nhập Mã Sản Phâm Trước Khi Xóa");
                return;
            }
            HienThiSanPhamBLL hienThiSanPhamBLL = new HienThiSanPhamBLL();
            hienThiSanPhamBLL.XoaSanPham(texMaSanPham.Text); 
        }

        private void btnTimKiem_Click_1(object sender, EventArgs e)
        {
            List<SanPham> DanhSachSanPham = new List<SanPham>();
            HienThiSanPhamBLL hienThiSanPhamBLL = new HienThiSanPhamBLL();
            if (radioMa.Checked)
            {
                DanhSachSanPham = hienThiSanPhamBLL.HienThiDanhSachSanPhamTheoMaSP(texTimKiem.Text);
                HienThiDanhSachSanPham(DanhSachSanPham);
            }
            else if (radioTen.Checked)
            {
                DanhSachSanPham = hienThiSanPhamBLL.HienThiDanhSachSanPhamTheoTenSP(texTimKiem.Text);
                HienThiDanhSachSanPham(DanhSachSanPham);
            }
            else if (radioCMT.Checked)
            {
                int SoLuong = int.Parse(texTimKiem.Text);
                DanhSachSanPham = hienThiSanPhamBLL.HienThiDanhSachSanPhamTheoSoLuong(SoLuong);
                HienThiDanhSachSanPham(DanhSachSanPham);
            }
            else
            {
                MessageBox.Show("Ban cần nhập Lựa Chọn Trước Khi Tìm Kiếm");
            }
        }
    }
}
/*

           HienThiLoaiKhachHangBLL hienThiLoaiKhachHangBLL = new HienThiLoaiKhachHangBLL(); 
           for(int i = 0; i < tvPhanLoaiKhachHang.Nodes[0].Nodes[1].Nodes.Count; i++)
           {
               tvPhanLoaiKhachHang.Nodes[0].Nodes[1].Nodes[i].Remove();
           }

           foreach (LoaiKhachHang loaiKhachHang in hienThiLoaiKhachHangBLL.HienThiDanhSachLoaiKhachHang()) 
           {
               TreeNode treeNode = new TreeNode(loaiKhachHang.TenLoaiKhachHang);
               tvPhanLoaiKhachHang.Nodes[0].Nodes[1].Nodes.Add(treeNode);
               cbLoaiKhachHang.Items.Add(loaiKhachHang);
               treeNode.Tag = loaiKhachHang;
           }
            */
