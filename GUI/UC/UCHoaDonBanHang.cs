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
    public partial class UCHoaDonBanHang : UserControl
    {
        public UCHoaDonBanHang()
        {
            InitializeComponent();
            HienThiCacNamTreeView();

            HienThiLoaiKhachHangBLL hienThiLoaiKhachHangBLL = new HienThiLoaiKhachHangBLL();
            HienThiPhieuXuatBLL hienThiPhieuXuatBLL = new HienThiPhieuXuatBLL(); 
            foreach (LoaiKhachHang loaiKhachHang in hienThiLoaiKhachHangBLL.HienThiDanhSachLoaiKhachHang())
            {
                cbLoaiKhachHang.Items.Add(loaiKhachHang);
            }
            HienThiDanhSachDonHang(hienThiPhieuXuatBLL.LayToanBoPhieuXuat());

            
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

            foreach (NgayThang ngayThang in layNgayThangBLL.LayDanhSachCacNamPhieuXuat())
            {
                string str1 = "Năm " + ngayThang.NgayThangNam.Year;
                TreeNode treeNode1 = new TreeNode(str1);
                foreach (NgayThang Thang in layNgayThangBLL.LayDanhSachCacThangTheoNamPhieuXuat(ngayThang.NgayThangNam))
                {
                    string str2 = "Thang " + Thang.NgayThangNam.Month;
                    TreeNode treeNode2 = new TreeNode(str2);
                    DateTime dateTime = new DateTime(ngayThang.NgayThangNam.Year, Thang.NgayThangNam.Month, 1);
                    foreach (NgayThang Ngay in layNgayThangBLL.LayDanhSachCacNgayTheoThangNamPhieuXuat(dateTime))
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
            HienThiKhoHangBLL hienThiKhoHangBLL = new HienThiKhoHangBLL();
            cbKhoHang.Items.Clear();
            foreach (KhoHang khoHang in hienThiKhoHangBLL.LayToanBoKhoHang())
            {
                cbKhoHang.Items.Add(khoHang);
            }
        }


        public DateTime DateTime; 

        private void tvPhanLoaiHoaDon_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node != null)
            {
                if (e.Node.Level == 0)
                {
                    e.Node.ExpandAll();
                }
            }
            HienThiPhieuXuatBLL hienThiPhieuXuatBLL = new HienThiPhieuXuatBLL(); 
            if(e.Node.Level == 3)
            {
                NgayThang ngayThang = e.Node.Tag as NgayThang;
                HienThiDanhSachDonHang(hienThiPhieuXuatBLL.LayPhieuXuatTheoNgayThangNam(ngayThang.NgayThangNam));
                DateTime = ngayThang.NgayThangNam;
            }
        }

        private void HienThiDanhSachDonHang(List<PhieuXuat> list)
        {
            gvDanhSachHoaDon.Rows.Clear(); 
            
            foreach(PhieuXuat px in list)
            {
                DataGridViewRow dataGridViewRow = new DataGridViewRow();
                dataGridViewRow.CreateCells(gvDanhSachHoaDon);
                dataGridViewRow.Cells[0].Value = px.MaPhieuXuat;
                dataGridViewRow.Cells[1].Value = px.MaNhanVien;
                dataGridViewRow.Cells[2].Value = px.TenNhanVien;
                dataGridViewRow.Cells[3].Value = px.MaKhachHang;
                dataGridViewRow.Cells[4].Value = px.TenKhachHang;
                dataGridViewRow.Cells[5].Value = px.TenKhoHang;
                gvDanhSachHoaDon.Rows.Add(dataGridViewRow); 
            }
        }

        private void gvDanhSachHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex != -1)
            {
                DataGridViewRow dataGridViewRow = gvDanhSachHoaDon.Rows[e.RowIndex];
                texMaHoaDon.Text = dataGridViewRow.Cells[0].Value + "";
                foreach(KhoHang kh in cbKhoHang.Items )
                {
                    if(kh.TenKhoHang == dataGridViewRow.Cells[5].Value + "")
                    {
                        cbKhoHang.SelectedItem = kh; 
                    }
                }
                foreach(NhanVien nv in CbNhanViens.Items)
                {
                    if (nv.MaNhanVien == dataGridViewRow.Cells[1].Value + "")
                    {
                        CbNhanViens.SelectedItem = nv;
                    }
                }
                HienThiPhieuXuatBLL hienThiPhieuXuatBLL = new HienThiPhieuXuatBLL(); 

                foreach (PhieuXuat px in hienThiPhieuXuatBLL.LayToanBoPhieuXuat())
                {
                    if(px.MaPhieuXuat == dataGridViewRow.Cells[0].Value + "")
                    {
                        DateNgayXuat.Value = px.NgayXuat;
                        break; 
                    }
                }
                txtMaKhachHang.Text = dataGridViewRow.Cells[3].Value + "";
                HienThiKhachHangTheoMa(txtMaKhachHang.Text);
                HienThiCT_PhieuXuatBLL HienThiCT_PhieuXuatBLL = new HienThiCT_PhieuXuatBLL(); 
                HienThiDanhSachCT_PhieuXuat(HienThiCT_PhieuXuatBLL.HienThiChiTietPhieuXuatTheoMa
                    (dataGridViewRow.Cells[0].Value + "")); 
            }
        }

        private void cbKhoHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbKhoHang.SelectedIndex != -1)
            {
                HienThiNhanVienBLL hienThiNhanVienBLL = new HienThiNhanVienBLL();
                KhoHang khoHang = cbKhoHang.SelectedItem as KhoHang;
                CbNhanViens.Items.Clear();
                foreach (NhanVien NhanVien in hienThiNhanVienBLL.HienThiNhanVienTheoKho(khoHang.MaKhoHang))
                {
                    CbNhanViens.Items.Add(NhanVien);
                }
                HienThiSanPhamBLL hienThiSanPhamBLL = new HienThiSanPhamBLL();
                foreach (SanPham sa in hienThiSanPhamBLL.HienThiDanhSachSanPhamTheoKho(khoHang.MaKhoHang))
                {
                    cbNhanVien.Items.Add(sa);
                }
            }
            HienThiDanhSachSanPham();

        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            texMaHoaDon.Text = "";
            cbKhoHang.SelectedIndex = -1;
            CbNhanViens.Items.Clear(); 
            CbNhanViens.Text = "";
            DateNgayXuat.Text = "";
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            HienThiPhieuXuatBLL hienThiPhieuXuatBLL = new HienThiPhieuXuatBLL();
            bool k = hienThiPhieuXuatBLL.XoaThongTinPhieuXuat(texMaHoaDon.Text);
            if(k==false)
            {
                MessageBox.Show("Bạn Cần Nhập Mã Hóa Đơn Trước Khi Xóa"); 
            }
            else
            {
                MessageBox.Show("Xóa Sản Phẩm Thành Công ");
            }
        }

        private void ThemMoiKhachHang_Click(object sender, EventArgs e)
        {
            txtDiaChi.Enabled = true; txtDiaChi.Text = ""; 
            txtDienThoai.Enabled = true; txtDienThoai.Text = "";
            txtTenKhachHang.Enabled = true; txtTenKhachHang.Text = "";
            cbLoaiKhachHang.Enabled = true; cbLoaiKhachHang.SelectedIndex = -1; 
            textGioiTinh.Enabled = true; textGioiTinh.Text = "";
            txtMaKhachHang.Text = "";
        }

        public void HienThiKhachHangTheoMa(string MaKhachHang)
        {
            HienThiKhachHangBLL hienThiKhachHangBLL = new HienThiKhachHangBLL();
            List<KhachHang> DanhSach = hienThiKhachHangBLL.HienThiDanhSachKhachHang();
            int k = 0;
            foreach (KhachHang kh in DanhSach)
            {
                k++;
                if (kh.MaKhachHang.Trim() == MaKhachHang.Trim())
                {
                    txtDiaChi.Enabled = false; txtDiaChi.Text = kh.DiaChi;
                    txtDienThoai.Enabled = false; txtDienThoai.Text = kh.DienThoai;
                    txtTenKhachHang.Enabled = false; txtTenKhachHang.Text = kh.TenKhachHang;
                    textGioiTinh.Enabled = false; textGioiTinh.Text = kh.GioiTinh;
                    cbLoaiKhachHang.Enabled = false; cbLoaiKhachHang.Text = kh.LoaiKhachHang;
                    break;

                }
                if (k == DanhSach.Count && kh.MaKhachHang != txtMaKhachHang.Text)
                {
                    MessageBox.Show("Khách Hàng Không Tồn Tại ! Bạn Cần Tạo Mới Khách Hàng");
                }
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            HienThiKhachHangTheoMa(txtMaKhachHang.Text); 
        }

        private void btnLuuKhachHang_Click(object sender, EventArgs e)
        {
            HienThiKhachHangBLL hienThiKhachHangBLL = new HienThiKhachHangBLL();
            foreach (KhachHang kh in hienThiKhachHangBLL.HienThiDanhSachKhachHang())
            {
                if(kh.MaKhachHang.Trim() == txtMaKhachHang.Text.Trim())
                {
                    MessageBox.Show("khách hàng đã tồn tại trong hệ thống");
                    return; 
                }
            }
            if (txtMaKhachHang.Text.Trim() == "" || txtMaKhachHang.Text.Trim() == null)
            {
                MessageBox.Show("Bạn Cần Nhập Mã Khách Hàng Trước Khi Thêm");
                return;
            }
            else if (cbLoaiKhachHang.SelectedIndex == -1)
            {
                MessageBox.Show("Bạn Cần Chọn Loại Khách Hàng Trước Khi Thêm");
                return;
            }
            else
            {
                
                KhachHang khachHang = new KhachHang()
                {
                    MaKhachHang = txtMaKhachHang.Text,
                    TenKhachHang = txtTenKhachHang.Text,
                    DiaChi = txtDiaChi.Text,
                    ChungMinhThu = "Chưa Cập Nhâp",
                    DienThoai = txtDienThoai.Text,
                    GioiTinh = textGioiTinh.Text,
                    NgaySinh = new DateTime()
                };
                if (cbLoaiKhachHang.SelectedIndex != -1)
                {
                    LoaiKhachHang loaiKhachHang = cbLoaiKhachHang.SelectedItem as LoaiKhachHang;
                    khachHang.LoaiKhachHang = loaiKhachHang.MaLoaiKhachHang;
                }
                hienThiKhachHangBLL.ThemMoiKhachHang(khachHang);
                MessageBox.Show("Đã Thêm Mới Thành Công Khách Hàng"); 
            }
        }

        private void btbLuu_Click(object sender, EventArgs e)
        {
            if (txtMaKhachHang.Text.Trim() == "" || txtMaKhachHang.Text.Trim() == null)
            {
                MessageBox.Show("Bạn Cần Nhập Mã Khách Hàng Trước Khi Thêm");
                return;
            }
            if (cbKhoHang.SelectedIndex == -1)
            {
                MessageBox.Show("Bạn Cần Chọn Kho Hàng Cần Xuất Hóa Đơn");
                return;
            }
            if (CbNhanViens.SelectedIndex == -1)
            {
                MessageBox.Show("Bạn Chọn Nhân Viên Phụ Trách Hóa Đơn Đó");
                return;
            }
            if(texMaHoaDon.Text.Trim() == "" || texMaHoaDon.Text == null)
            {
                MessageBox.Show("Bạn Cần Nhập Mã Hóa Đơn Trước Khi Thêm");
                return;
            }
            if(DateNgayXuat.Value == null)
            {
                MessageBox.Show("Bạn Cần Chọn Ngày Thêm Hóa Đơn");
                return;
            }
            PhieuXuat phieuXuat = new PhieuXuat()
            {
                MaPhieuXuat = texMaHoaDon.Text,
                MaKhachHang = txtMaKhachHang.Text,
                NgayXuat = DateNgayXuat.Value
            };
            KhoHang khoHang = cbKhoHang.SelectedItem as KhoHang;
            phieuXuat.MaKhoHang = khoHang.MaKhoHang;
            NhanVien nhanVien = CbNhanViens.SelectedItem as NhanVien;
            phieuXuat.MaNhanVien = nhanVien.MaNhanVien;
            HienThiPhieuXuatBLL hienThiPhieuXuatBLL = new HienThiPhieuXuatBLL();
            hienThiPhieuXuatBLL.ThemMoiThongTinPhieuXuat(phieuXuat);
            HienThiDanhSachDonHang(hienThiPhieuXuatBLL.LayToanBoPhieuXuat()); 
        }

        private void btnChinhSua_Click(object sender, EventArgs e)
        {
            if (txtMaKhachHang.Text.Trim() == "" || txtMaKhachHang.Text.Trim() == null)
            {
                MessageBox.Show("Bạn Cần Nhập Mã Khách Hàng Trước Khi Thêm");
                return;
            }
            if (cbKhoHang.SelectedIndex == -1)
            {
                MessageBox.Show("Bạn Cần Chọn Kho Hàng Cần Xuất Hóa Đơn");
                return;
            }
            if (CbNhanViens.SelectedIndex == -1)
            {
                MessageBox.Show("Bạn Chọn Nhân Viên Phụ Trách Hóa Đơn Đó");
                return;
            }
            if (texMaHoaDon.Text.Trim() == "" || texMaHoaDon.Text == null)
            {
                MessageBox.Show("Bạn Cần Nhập Mã Hóa Đơn Trước Khi Thêm");
                return;
            }
            if (DateNgayXuat.Value == null)
            {
                MessageBox.Show("Bạn Cần Chọn Ngày Thêm Hóa Đơn");
                return;
            }
            PhieuXuat phieuXuat = new PhieuXuat()
            {
                MaPhieuXuat = texMaHoaDon.Text,
                MaKhachHang = txtMaKhachHang.Text,
                NgayXuat = DateNgayXuat.Value
            };
            KhoHang khoHang = cbKhoHang.SelectedItem as KhoHang;
            phieuXuat.MaKhoHang = khoHang.MaKhoHang;
            NhanVien nhanVien = CbNhanViens.SelectedItem as NhanVien;
            phieuXuat.MaNhanVien = nhanVien.MaNhanVien;
            HienThiPhieuXuatBLL hienThiPhieuXuatBLL = new HienThiPhieuXuatBLL();
            hienThiPhieuXuatBLL.CapNhapThongTinPhieuXuat(phieuXuat);
            HienThiDanhSachDonHang(hienThiPhieuXuatBLL.LayToanBoPhieuXuat());
        }

        //----------------------------------------------------------------------------------------------------

        public void HienThiDanhSachCT_PhieuXuat(List<CT_PhieuXuat> DanhSach)
        {
            gv_CT_PhieuXuat.Rows.Clear();

            foreach (CT_PhieuXuat px in DanhSach)
            {
                DataGridViewRow dataGridViewRow = new DataGridViewRow();
                dataGridViewRow.CreateCells(gv_CT_PhieuXuat);
                dataGridViewRow.Cells[0].Value = px.MaPhieuXuat;
                dataGridViewRow.Cells[1].Value = px.MaSanPham;
                dataGridViewRow.Cells[2].Value = px.TenSanPham;
                dataGridViewRow.Cells[3].Value = px.DonGia;
                dataGridViewRow.Cells[4].Value = px.SoLuong;
                dataGridViewRow.Cells[5].Value = px.TongTien;
                gv_CT_PhieuXuat.Rows.Add(dataGridViewRow);
            }
        }


        public void HienThiDanhSachSanPham()
        {
            if(cbKhoHang.SelectedIndex != -1)
            {
                
            }
        }

        private void cbNhanVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbNhanVien.SelectedIndex != -1)
            {
                SanPham sanPham = cbNhanVien.SelectedItem as SanPham ;
                texDonGiaBan.Text = sanPham.DonGia+"";
                texSoLuongTon.Text = sanPham.SoLuong + ""; 
            }
        }


        public List<CT_PhieuXuat> DanhSachDatHang = new List<CT_PhieuXuat>();

        private void btnLLuuSP_Click(object sender, EventArgs e)
        {
            int SoLuonSanPhamTon = int.Parse(texSoLuongTon.Text); 

            if (SoLuonSanPhamTon <= 0)
            {
                MessageBox.Show("Sản Phẩm Cần Mua Đã Hết Hàng");
                return; 
            }

            SanPham sanPham = cbNhanVien.SelectedItem as SanPham;
            CT_PhieuXuat cT_PhieuXuat = new CT_PhieuXuat()
            {
                MaPhieuXuat = texMaHoaDon.Text,
                MaSanPham = sanPham.MaSanPham,
                SoLuong = int.Parse(texSoLuongDat.Text),
                TongTien = double.Parse(texSoLuongDat.Text) * double.Parse(texDonGiaBan.Text),
                DonGia = double.Parse(texDonGiaBan.Text)
            };

            int k = 0;
            if (DanhSachDatHang.Count != 0)
            {
                foreach (CT_PhieuXuat sp in DanhSachDatHang)
                {
                    if (cT_PhieuXuat.MaSanPham == sp.MaSanPham && cT_PhieuXuat.MaPhieuXuat == sp.MaPhieuXuat)
                    {
                        SoLuonSanPhamTon -= cT_PhieuXuat.SoLuong;
                        texSoLuongTon.Text = SoLuonSanPhamTon + ""; 
                        sp.SoLuong += cT_PhieuXuat.SoLuong;
                        sp.TongTien += cT_PhieuXuat.TongTien; 
                        break;
                    }
                    k++;
                    if (k == DanhSachDatHang.Count && sp.MaPhieuXuat != cT_PhieuXuat.MaSanPham && cT_PhieuXuat.MaPhieuXuat == sp.MaPhieuXuat)
                    {
                        SoLuonSanPhamTon -= cT_PhieuXuat.SoLuong;
                        texSoLuongTon.Text = SoLuonSanPhamTon + "";
                        DanhSachDatHang.Add(cT_PhieuXuat);
                        break;
                    }
                }
            }
            else
            {
                SoLuonSanPhamTon -= cT_PhieuXuat.SoLuong;
                texSoLuongTon.Text = SoLuonSanPhamTon + "";
                DanhSachDatHang.Add(cT_PhieuXuat);
            }
            HienThiDanhSachCT_PhieuXuat(DanhSachDatHang); 
        }


        public void LuuThongTinHoaDon()
        {
            HienThiCT_PhieuXuatBLL hienThiCT_PhieuXuatBLL = new HienThiCT_PhieuXuatBLL(); 
            foreach (CT_PhieuXuat ct in DanhSachDatHang)
            {
                hienThiCT_PhieuXuatBLL.ThemMoiChiTietPhieuXuat(ct);  
            }

        }

        public void CapNhapNhapLaiKhoHang(string MaHoaDon,int SoLuongSP)
        {
            HienThiSanPhamBLL hienThiSanPhamBLL = new HienThiSanPhamBLL();
            hienThiSanPhamBLL.CapNhapSoLuongSanPham(MaHoaDon, SoLuongSP); 
        }

        private void btnThemMoiSP_Click(object sender, EventArgs e)
        {
            cbNhanVien.SelectedIndex = -1;
            texSoLuongTon.Text = "";
            texSoLuongDat.Text = "";
            texDonGiaBan.Text = "";
            texTongTien.Text = ""; 
        }

        private void btnCapNhapKhoHang_Click(object sender, EventArgs e)
        {
            if(cbKhoHang.SelectedIndex == -1)
            {
                MessageBox.Show("Cần Chọn Thông Tin Kho Hàng Cần Cập Nhập");
                return; 
            }
            if(cbNhanVien.SelectedIndex == -1)
            {
                MessageBox.Show("Cần Chọn Thông Tin Sản Phẩm Cần Cập Nhâp");
                return;
            }

            SanPham sanPham = cbNhanVien.SelectedItem as SanPham; 
            CapNhapNhapLaiKhoHang(sanPham.MaSanPham,int.Parse(texSoLuongTon.Text));
            LuuThongTinHoaDon(); 
        }
    }
}
