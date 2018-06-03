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
    public partial class UCHoaDonNhap : UserControl
    {
        public UCHoaDonNhap()
        {
            InitializeComponent();
            HienThiCacNamTreeView();
            HienThiPhieuNhapBLL hienThiPhieuNhapBLL = new HienThiPhieuNhapBLL();
        }
        private void HienThiCacNamTreeView()
        {
            for (int i = 1; i < tvPhanLoaiHoaDon.Nodes.Count; i++)
            {
                for (int j = 0; j < tvPhanLoaiHoaDon.Nodes[i].Nodes.Count; j++)
                {
                    tvPhanLoaiHoaDon.Nodes[i].Nodes[j].Remove();
                }
            }
            LayNgayThangBLL layNgayThangBLL = new LayNgayThangBLL();

            foreach (NgayThang ngayThang in layNgayThangBLL.LayDanhSachCacNamPN())
            {
                string str1 = "Năm " + ngayThang.NgayThangNam.Year;
                TreeNode treeNode1 = new TreeNode(str1);
                foreach (NgayThang Thang in layNgayThangBLL.LayDanhSachCacThangTheoNamPN(ngayThang.NgayThangNam))
                {
                    string str2 = "Thang " + Thang.NgayThangNam.Month;
                    TreeNode treeNode2 = new TreeNode(str2);
                    DateTime dateTime = new DateTime(ngayThang.NgayThangNam.Year, Thang.NgayThangNam.Month, 1);
                    foreach (NgayThang Ngay in layNgayThangBLL.LayDanhSachCacNgayTheoThangNamPN(dateTime))
                    {
                        string str3 = "Ngày " + Ngay.NgayThangNam.Day;
                        TreeNode treeNode3 = new TreeNode(str3);
                        treeNode2.Nodes.Add(treeNode3);
                        NgayThang Date = new NgayThang()
                        {
                            NgayThangNam = new DateTime
                            (
                                ngayThang.NgayThangNam.Year,
                                Thang.NgayThangNam.Month,
                                Ngay.NgayThangNam.Day
                            )
                        };
                        treeNode3.Tag = Date;
                    }
                    treeNode1.Nodes.Add(treeNode2);
                }
                tvPhanLoaiHoaDon.Nodes[0].Nodes.Add(treeNode1);

            }
            HienThiNhaCungCapBLL HienThiNhaCungCapBLL = new HienThiNhaCungCapBLL();
            cbNhaCungCap.Items.Clear(); 
            foreach (NhaCungCap nhancungcap in HienThiNhaCungCapBLL.HienThiDanhSachNCC())
            {
                cbNhaCungCap.Items.Add(nhancungcap); 
            }
            HienThiKhoHangBLL hienThiKhoHangBLL = new HienThiKhoHangBLL();
            cbKhoHang.Items.Clear(); 
            foreach (KhoHang khoHang in hienThiKhoHangBLL.LayToanBoKhoHang())
            {
                cbKhoHang.Items.Add(khoHang); 
            }
            HienThiNhaSanXuatBLL hienThiNhaSanXuatBLL = new HienThiNhaSanXuatBLL();
        }

        public void HienThiDanhSachDonHang(List<PhieuNhap>DanhSach)
        {
            gvHoaDon.Rows.Clear(); 
            foreach(PhieuNhap item in DanhSach)
            {
                DataGridViewRow dataGridViewRow = new DataGridViewRow();
                dataGridViewRow.CreateCells(gvHoaDon);
                dataGridViewRow.Cells[0].Value = item.MaPhieuNhap;
                dataGridViewRow.Cells[1].Value = item.NhanVien;
                dataGridViewRow.Cells[2].Value = item.NhaCungCap;
                dataGridViewRow.Cells[3].Value = item.KhoHang;
                gvHoaDon.Rows.Add(dataGridViewRow);
                dataGridViewRow.Tag = item; 
            }
                
         }

        private DateTime DateTime = new DateTime(); 
        private void tvPhanLoaiHoaDon_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node != null)
            {
                if (e.Node.Level == 0)
                {
                    e.Node.ExpandAll();
                }
            }
            HienThiPhieuNhapBLL hienThiPhieuNhapBLL = new HienThiPhieuNhapBLL();
            if (e.Node.Level == 3)
            {
                NgayThang ngayThang = e.Node.Tag as NgayThang;
                HienThiDanhSachDonHang(hienThiPhieuNhapBLL.LayPhieuNhapTheoNgayThangNam(ngayThang.NgayThangNam));
                DateTime = ngayThang.NgayThangNam; 
            }
        }

        public void HienThiDanhSachSanPhamHD(List<CT_PhieuNhap> DanhSach)
        {
            gvSanPhamTheoHoaDon.Rows.Clear();
            foreach ( CT_PhieuNhap item in DanhSach)
            {
                DataGridViewRow dataGridViewRow = new DataGridViewRow();
                dataGridViewRow.CreateCells(gvSanPhamTheoHoaDon);
                dataGridViewRow.Cells[0].Value = item.TenSanPham;
                dataGridViewRow.Cells[1].Value = item.SoLuong;
                dataGridViewRow.Cells[2].Value = item.DonGia;
                dataGridViewRow.Cells[3].Value = item.TongTien;
                gvSanPhamTheoHoaDon.Rows.Add(dataGridViewRow);
            }

        }
        List<CT_PhieuNhap> DanhSachSanPhamTheoHoaDơn = new List<CT_PhieuNhap>();
        HienThiCT_PhieuNhapBLL HienThiCT_PhieuNhapBLL = new HienThiCT_PhieuNhapBLL(); 
        private void gvHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                DataGridViewRow dataGridViewRow = gvHoaDon.Rows[e.RowIndex];
                HienThiDanhSachSanPhamHD(HienThiCT_PhieuNhapBLL.HienThiDanhSachSPTheoMaPhieu(dataGridViewRow.Cells[0].Value + ""));
                texMaHoaDon.Text = dataGridViewRow.Cells[0].Value + ""; 
                CbNhanViens.Text = dataGridViewRow.Cells[1].Value + "";
                foreach(NhaCungCap nhacungcap in cbNhaCungCap.Items)
                {
                    if(nhacungcap.TenNhaCungCap == dataGridViewRow.Cells[2].Value + "")
                    {
                        cbNhaCungCap.SelectedItem = nhacungcap; 
                    }
                }
                foreach(KhoHang khoHang in cbKhoHang.Items)
                {
                    if(khoHang.TenKhoHang == dataGridViewRow.Cells[3].Value + "")
                    {
                        cbKhoHang.SelectedItem = khoHang;
                    }
                }

                DateNgayNhap.Value = DateTime;
                DanhSachSanPhamTheoHoaDơn = HienThiCT_PhieuNhapBLL.HienThiDanhSachSPTheoMaPhieu(texMaHoaDon.Text);
            }
        }


        
        private void btnLLuuSP_Click(object sender, EventArgs e)
        {
            
            CT_PhieuNhap cT_PhieuNhap = new CT_PhieuNhap()
            {
                MaPhieuNhap = texMaHoaDon.Text,
                SanPham = texMaSP.Text,
                TenSanPham = texTenSP.Text,
                SoLuong = int.Parse(texSoLuong.Text),
                GhiChu = " ",
                DonGia = double.Parse(texDonGiaNhap.Text),
                TongTien = double.Parse(texSoLuong.Text) * double.Parse(texDonGiaNhap.Text)
            };
            int k = 0;
            if (DanhSachSanPhamTheoHoaDơn.Count != 0)
            {
                foreach (CT_PhieuNhap sp in DanhSachSanPhamTheoHoaDơn)
                {
                    if (cT_PhieuNhap.SanPham == sp.SanPham && cT_PhieuNhap.MaPhieuNhap == sp.MaPhieuNhap)
                    {
                        sp.SoLuong += cT_PhieuNhap.SoLuong;
                        break;
                    }
                    k++;
                    if (k == DanhSachSanPhamTheoHoaDơn.Count && sp.SanPham != cT_PhieuNhap.SanPham && cT_PhieuNhap.MaPhieuNhap == sp.MaPhieuNhap)
                    {
                        DanhSachSanPhamTheoHoaDơn.Add(cT_PhieuNhap);
                        break;
                    }
                }
            }
            else
            {
                DanhSachSanPhamTheoHoaDơn.Add(cT_PhieuNhap);
            }
            HienThiDanhSachSanPhamHD(DanhSachSanPhamTheoHoaDơn); 
        }

        private void CapNhapLaiKhoHang()
        {
            KhoHang khoHang = cbKhoHang.SelectedItem as KhoHang;
            List<SanPham> DanhSach = new List<SanPham>();
            NhaCungCap nhacungcap = cbNhaCungCap.SelectedItem as NhaCungCap; 
            foreach(CT_PhieuNhap ct in DanhSachSanPhamTheoHoaDơn)
            {
                MessageBox.Show(ct.SanPham);
                SanPham sanPham = new SanPham()
                {
                    MaSanPham = ct.SanPham,
                    TenSanPham = ct.TenSanPham,
                    SoLuong = ct.SoLuong,
                    KhoHang = khoHang.MaKhoHang,
                    LoaiSanPham = "LSP0000",
                    NhaCungCap = nhacungcap.MaNhaCungCap,
                    DonGia = 0,
                    NhaSanXuat = "NSX0000"

                };
                DanhSach.Add(sanPham);
            }

            HienThiSanPhamBLL hienThiSanPhamBLL = new HienThiSanPhamBLL();
            foreach (SanPham sp1 in DanhSach)
            {
                List<SanPham> ketQua = hienThiSanPhamBLL.HienThiDanhSachSanPhamTheoMaSP(sp1.MaSanPham);
                if (ketQua.Count == 0)
                {
                    hienThiSanPhamBLL.ThemMoiSanPham(sp1);
                }
                else
                {
                    int SoLuongSP = ketQua[0].SoLuong + sp1.SoLuong;
                    hienThiSanPhamBLL.ChinhSuaSoLuongSanPham(sp1.MaSanPham, SoLuongSP);
                }
            }
        }

        private void cbKhoHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            HienThiNhanVienBLL hienThiNhanVienBLL = new HienThiNhanVienBLL(); 
            KhoHang khoHang = cbKhoHang.SelectedItem as KhoHang;
            CbNhanViens.Items.Clear(); 
            foreach (NhanVien NhanVien in hienThiNhanVienBLL.HienThiNhanVienTheoKho(khoHang.MaKhoHang))
            {
                CbNhanViens.Items.Add(NhanVien);
            }
            
        }


        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            texMaHoaDon.Text = "";
            cbKhoHang.Text = null;
            cbNhaCungCap.Text = null;
            CbNhanViens.Text = null;
            DateNgayNhap.Text = null; 
        }

        private void btbLuu_Click_1(object sender, EventArgs e)
        {
            HienThiPhieuNhapBLL hienThiPhieuNhapBLL = new HienThiPhieuNhapBLL();
            NhaCungCap nhaCungCap = cbNhaCungCap.SelectedItem as NhaCungCap;
            NhanVien nhanVien = CbNhanViens.SelectedItem as NhanVien;
            MessageBox.Show(nhanVien.MaNhanVien); 
            if(cbKhoHang.SelectedItem == null)
            {
                MessageBox.Show("Bạn Cần Chọn Kho Hàng Cần Nhập");
                return;
            }
            if (CbNhanViens.SelectedItem == null)
            {
                MessageBox.Show("Bạn Cần Chọn Nhân Viên");
                return;
            }

            if (cbNhaCungCap.SelectedItem == null)
            {
                MessageBox.Show("Bạn Cần Chọn SanPham");
                return;
            }
            PhieuNhap phieuNhap = new PhieuNhap()
            {
                MaPhieuNhap = texMaHoaDon.Text,
                NhaCungCap = nhaCungCap.MaNhaCungCap,
                NhanVien = nhanVien.MaNhanVien,
                NgayNhap = DateNgayNhap.Value
            };
            foreach (PhieuNhap Phieu in hienThiPhieuNhapBLL.HienThiToanBoDanhSachPhieuNhap())
            {
                if(phieuNhap.MaPhieuNhap == Phieu.MaPhieuNhap)
                {
                    MessageBox.Show("Mã Hóa Đơn Đã Tồn Tại Trong Hệ Thống");
                    return; 
                }
            }
            hienThiPhieuNhapBLL.ThemMoiPhieuNhap(phieuNhap);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            HienThiPhieuNhapBLL hienThiPhieuNhapBLL = new HienThiPhieuNhapBLL();
            hienThiPhieuNhapBLL.XoaThongTinPhieuNhap(texMaHoaDon.Text);
            HienThiDanhSachDonHang(hienThiPhieuNhapBLL.LayPhieuNhapTheoNgayThangNam(DateTime)); 
        }

        private void btnChinhSua_Click(object sender, EventArgs e)
        {
            HienThiPhieuNhapBLL hienThiPhieuNhapBLL = new HienThiPhieuNhapBLL();
            if (texMaHoaDon.Text == null)
            {
                MessageBox.Show("Bạn Cần Nhập Mã Hóa Đơn Trước Khi Chỉnh Sửa");
                return; 
            }
            PhieuNhap phieuNhap = new PhieuNhap() {
                MaPhieuNhap = texMaHoaDon.Text,
            };
            NhanVien nhanvien = CbNhanViens.SelectedItem as NhanVien;
            phieuNhap.NhanVien = nhanvien.MaNhanVien;
            NhaCungCap nhacungcap = cbNhaCungCap.SelectedItem as NhaCungCap; 
            phieuNhap.NhaCungCap = nhacungcap.MaNhaCungCap;
            phieuNhap.NgayNhap = DateNgayNhap.Value;
            hienThiPhieuNhapBLL.ChinhSuaThongTinPhieuNhap(phieuNhap);
            HienThiDanhSachDonHang(hienThiPhieuNhapBLL.LayPhieuNhapTheoNgayThangNam(DateTime));

        }

        private void btnXoaSP_Click(object sender, EventArgs e)
        {
            if(texMaSP.Text== null)
            {
                MessageBox.Show("Ban can Cap Nhap Ma San Pham Truoc Khi Xoa");
                return; 
            }
            if(texMaHoaDon.Text == null)
            {
                MessageBox.Show("Ban can Nhap Ma Hoa Don Truoc Khi Xoa");
                return; 
            }
            if(cbKhoHang.SelectedItem == null)
            {
                MessageBox.Show("Ban Can Chon Kho Hang Truoc Khi Xoa");
                return;

            }
            KhoHang khoHang = cbKhoHang.SelectedItem as KhoHang; 
            HienThiCT_PhieuNhapBLL hienThiCT_PhieuNhapBLL = new HienThiCT_PhieuNhapBLL();
            hienThiCT_PhieuNhapBLL.XoaCt_PhieuNhap(texMaHoaDon.Text, texMaSP.Text, khoHang,int.Parse(texSoLuong.Text));
            HienThiDanhSachSanPhamHD(hienThiCT_PhieuNhapBLL.HienThiDanhSachSPTheoMaPhieu(texMaHoaDon.Text));
        }

        

        private void gvSanPhamTheoHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex > -1)
            {
                HienThiSanPhamBLL hienThiSanPhamBLL = new HienThiSanPhamBLL(); 
                DataGridViewRow dataGridViewRow = gvSanPhamTheoHoaDon.Rows[e.RowIndex];
                foreach(SanPham sanPham in hienThiSanPhamBLL.HienThiDanhSachSanPham())
                {
                    if (sanPham.TenSanPham == dataGridViewRow.Cells[0].Value + "")
                    {
                        texMaSP.Text = sanPham.MaSanPham;
                        texTenSP.Text = sanPham.TenSanPham;
                        break; 
                    }
                }
                texSoLuong.Text = dataGridViewRow.Cells[1].Value + "";
                texDonGiaNhap.Text = dataGridViewRow.Cells[2].Value + "";
                texTongTien.Text = dataGridViewRow.Cells[3].Value + "";
                
            }
        }

        private void btnCapNhapKho_Click(object sender, EventArgs e)
        {
            CapNhapLaiKhoHang();
            HienThiCT_PhieuNhapBLL.XoaToanBoChiTietPhieuNhap(texMaHoaDon.Text); 
            foreach (CT_PhieuNhap ct in DanhSachSanPhamTheoHoaDơn)
            {
                HienThiCT_PhieuNhapBLL.ThemMoiCT_PhieuNhap(ct); 
            }
            
            DanhSachSanPhamTheoHoaDơn = HienThiCT_PhieuNhapBLL.HienThiDanhSachSPTheoMaPhieu(texMaHoaDon.Text);
        }

        private void btnSuaSP_Click(object sender, EventArgs e)
        {
            if(texMaHoaDon.Text == null || texMaHoaDon.Text == "")
            {
                MessageBox.Show("Bạn Cần Phải Nhập Hóa Đơn Để Thêm Sản Phâm");
                return; 
            }

            if (texMaSP.Text == null || texMaSP.Text == "")
            {
                MessageBox.Show("Bạn Cần Chọn Sản Phẩm Đền Thêm Vào Hóa Đơn");
                return;
            }
            CT_PhieuNhap cT_PhieuNhap = new CT_PhieuNhap()
            {
                MaPhieuNhap = texMaHoaDon.Text,
                SanPham = texMaSP.Text,
                TenSanPham = texTenSP.Text,
                SoLuong = int.Parse(texSoLuong.Text),
                GhiChu = " ",
                DonGia = double.Parse(texDonGiaNhap.Text),
                TongTien = double.Parse(texSoLuong.Text) * double.Parse(texDonGiaNhap.Text)
            };
            HienThiCT_PhieuNhapBLL.CapNhapThongTinCT_HoaDonNhap(cT_PhieuNhap); 
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (radioMaHD.Checked)
            {
                // tìm kiếm thông tin hóa đơn theo mã 
            }
            else if (radioNgay.Checked)
            {
                // tim kiếm thông tin hóa đơn theo ngày
            }

        }
    }
}


//private void tvPhanLoaiSanPham_AfterSelect(object sender, TreeViewEventArgs e)
//{
    

//    List<SanPham> DanhSachSanPham = new List<SanPham>();
//    if (e.Node.Level == 1)
//    {
//        if (tvPhanLoaiSanPham.Nodes[0].Nodes[0] == e.Node)
//        {
//            HienThiDanhSachSanPham();
//        }
//    }
//    for (int i = 0; i < tvPhanLoaiSanPham.Nodes[1].Nodes.Count; i++)
//    {
//        if (e.Node.Level == 1)
//        {
//            if (tvPhanLoaiSanPham.Nodes[1].Nodes[i] == e.Node)
//            {
//                KhoHang khoHang = e.Node.Tag as KhoHang;
//                DanhSachSanPham = hienThiSanPhamBLL.HienThiDanhSachSanPhamTheoKho(khoHang.MaKhoHang);
//                HienThiDanhSachSanPham(DanhSachSanPham);
//                break;
//            }
//        }
//    }

//    for (int i = 0; i < tvPhanLoaiSanPham.Nodes[2].Nodes.Count; i++)
//    {
//        if (e.Node.Level == 1)
//        {
//            if (tvPhanLoaiSanPham.Nodes[2].Nodes[i] == e.Node)
//            {
//                LoaiSanPham loaiSanPham = e.Node.Tag as LoaiSanPham;
//                DanhSachSanPham = hienThiSanPhamBLL.HienThiDanhSachSanPhamTheoLoaiSP(loaiSanPham.MaLoaiSanPham);
//                HienThiDanhSachSanPham(DanhSachSanPham);
//                break;
//            }

//        }
//    }

//    for (int i = 0; i < tvPhanLoaiSanPham.Nodes[3].Nodes.Count; i++)
//    {
//        if (e.Node.Level == 1)
//        {

//            if (tvPhanLoaiSanPham.Nodes[3].Nodes[i] == e.Node)
//            {
//                NhaCungCap nhaCungCap = e.Node.Tag as NhaCungCap;
//                DanhSachSanPham = hienThiSanPhamBLL.HienThiDanhSachSanPhamTheoNCC(nhaCungCap.MaNhaCungCap);
//                HienThiDanhSachSanPham(DanhSachSanPham);
//                break;
//            }
//        }
//    }

//    for (int i = 0; i < tvPhanLoaiSanPham.Nodes[4].Nodes.Count; i++)
//    {
//        if (e.Node.Level == 1)
//        {

//            if (tvPhanLoaiSanPham.Nodes[4].Nodes[i] == e.Node)
//            {
//                NhaSanXuat nhaSanXuat = e.Node.Tag as NhaSanXuat;
//                DanhSachSanPham = hienThiSanPhamBLL.HienThiDanhSachSanPhamTheoNSX(nhaSanXuat.MaNhaSanXuat);
//                HienThiDanhSachSanPham(DanhSachSanPham);
//                break;
//            }
//        }
//    }

  


