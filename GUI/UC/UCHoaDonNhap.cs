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
        

        //    HienThiNhanVienBLL hienThiNhanVienBLL = new HienThiNhanVienBLL(); 

        //    foreach(NhanVien nhanvien in hienThiNhanVienBLL.LayToanBoNhanVien())
        //    {
        //        TreeNode treeNode = new TreeNode(nhanvien.TenNhanVien);
        //        tvPhanLoaiHoaDon.Nodes[1].Nodes.Add(treeNode);
        //        treeNode.Tag = nhanvien;
        //    }


        //    HienThiKhoHangBLL hienThiKhoHangBLL = new HienThiKhoHangBLL();
        //    foreach (KhoHang khoHang in hienThiKhoHangBLL.LayToanBoKhoHang())
        //    {
        //        TreeNode treeNode = new TreeNode(khoHang.TenKhoHang);
        //        tvPhanLoaiHoaDon.Nodes[2].Nodes.Add(treeNode);
        //        treeNode.Tag = khoHang;
        //    }

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
                gvHoaDon.Rows.Add(dataGridViewRow);
            }
                
         }

       
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
            }
        }

        public void HienThiDanhSachSanPhamHD(List<CT_PhieuNhap> DanhSach)
        {
            gvSanPhamTheoHoaDon.Rows.Clear();
            foreach ( CT_PhieuNhap item in DanhSach)
            {
                DataGridViewRow dataGridViewRow = new DataGridViewRow();
                dataGridViewRow.CreateCells(gvSanPhamTheoHoaDon);
                dataGridViewRow.Cells[0].Value = item.SanPham;
                dataGridViewRow.Cells[1].Value = item.SoLuong;
                dataGridViewRow.Cells[2].Value = item.DonGia;
                dataGridViewRow.Cells[3].Value = item.TongTien;
                gvSanPhamTheoHoaDon.Rows.Add(dataGridViewRow);
            }

        }
        HienThiCT_PhieuNhapBLL HienThiCT_PhieuNhapBLL = new HienThiCT_PhieuNhapBLL(); 
        private void gvHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                DataGridViewRow dataGridViewRow = gvHoaDon.Rows[e.RowIndex];
                HienThiDanhSachSanPhamHD(HienThiCT_PhieuNhapBLL.HienThiDanhSachSPTheoMaPhieu(dataGridViewRow.Cells[0].Value + "")); 
                
            }
        }

        private void btbLuu_Click(object sender, EventArgs e)
        {

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

  


