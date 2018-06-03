using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class HienThiCT_PhieuNhapBLL
    {
        HienThiCT_PhieuNhapDAL hienThiCT_PhieuNhapDAL = new HienThiCT_PhieuNhapDAL(); 
        public List<CT_PhieuNhap> HienThiDanhSachSPTheoMaPhieu(string MaPhieuNhap)
        {
            return hienThiCT_PhieuNhapDAL.HienThiDanhSachSPTheoMaPhieu(MaPhieuNhap); 
        }
        public bool ThemMoiCT_PhieuNhap(CT_PhieuNhap cT_PhieuNhap)
        {
            return hienThiCT_PhieuNhapDAL.ThemMoiCT_PhieuNhap(cT_PhieuNhap); 
        }

        public bool XoaCt_PhieuNhap(string MaPhieuNhap,string MaSanPham,KhoHang khoHang,int SoLuong)
        {
            CapNhapKhoHangKhiXoa(khoHang, MaSanPham,SoLuong);
            return hienThiCT_PhieuNhapDAL.XoaCt_PhieuNhap(MaPhieuNhap,MaSanPham);
            

        }
        private void CapNhapKhoHangKhiXoa(KhoHang khoHang, string MaSanPham ,int SoLuong)
        {
            HienThiSanPhamBLL HienThiSanPhamBLL = new HienThiSanPhamBLL();
            foreach (SanPham SanPham in HienThiSanPhamBLL.HienThiDanhSachSanPhamTheoKho(khoHang.MaKhoHang))
            {
                if (SanPham.MaSanPham == MaSanPham)
                {
                    SanPham.SoLuong = SanPham.SoLuong - SoLuong;
                    HienThiSanPhamBLL.ChinhSuaThongtinSanPham(SanPham);
                    break; 
                }
            }
        }

        public bool SuaCt_PhieuNhap(CT_PhieuNhap cT_PhieuNhap)
        {
            return hienThiCT_PhieuNhapDAL.SuaCt_PhieuNhap(cT_PhieuNhap);
        }

        public void XoaToanBoChiTietPhieuNhap(string MaPhieuNhap)
        {
            hienThiCT_PhieuNhapDAL.XoaToanBoChiTietPhieuNhap(MaPhieuNhap); 
        }

        public void CapNhapThongTinCT_HoaDonNhap(CT_PhieuNhap cT_PhieuNhap)
        {
            if(cT_PhieuNhap.SoLuong == null)
            {
                cT_PhieuNhap.SoLuong = 0; 
            }
            if(cT_PhieuNhap.GhiChu == null)
            {
                cT_PhieuNhap.GhiChu = " "; 
            }
            if(cT_PhieuNhap.TongTien == null)
            {
                cT_PhieuNhap.TongTien = 0;
            }
            if (cT_PhieuNhap.DonGia == null)
            {
                cT_PhieuNhap.DonGia = 0;
            }
            hienThiCT_PhieuNhapDAL.CapNhapThongTinCT_HoaDonNhap(cT_PhieuNhap); 
        }
    }
}
