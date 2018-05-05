using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO; 

namespace BLL
{
    public class HienThiSanPhamBLL
    {
        HienThiSanPhamDAL hienThiSanPhamDAL = new HienThiSanPhamDAL();
        public List<SanPham> HienThiDanhSachSanPham()
        {
            return hienThiSanPhamDAL.HienThiDanhSachSanPham();
        }

        public List<SanPham> HienThiDanhSachSanPhamTheoKho(string MaKhoHang)
        {
            return hienThiSanPhamDAL.HienThiDanhSachSanPhamTheoKho(MaKhoHang);
        }

        public List<SanPham> HienThiDanhSachSanPhamTheoLoaiSP(string MaLoaiSanPham)
        {
            return hienThiSanPhamDAL.HienThiDanhSachSanPhamTheoLoaiSP(MaLoaiSanPham);
        }

        public List<SanPham> HienThiDanhSachSanPhamTheoNSX(string MaNhaSanXuat)
        {
            return hienThiSanPhamDAL.HienThiDanhSachSanPhamTheoNSX(MaNhaSanXuat);
        }

        public List<SanPham> HienThiDanhSachSanPhamTheoNCC(string MaNhaCungCap)
        {
            return hienThiSanPhamDAL.HienThiDanhSachSanPhamTheoNCC(MaNhaCungCap);
        }

        public List<SanPham> HienThiDanhSachSanPhamTheoMaSP(string MaSanPham)
        {
            return hienThiSanPhamDAL.HienThiDanhSachSanPhamTheoMaSP(MaSanPham);
        }

        public List<SanPham> HienThiDanhSachSanPhamTheoTenSP(string TenSanPham)
        {
            return hienThiSanPhamDAL.HienThiDanhSachSanPhamTheoTenSP(TenSanPham);
        }

        public List<SanPham> HienThiDanhSachSanPhamTheoSoLuong(int SoLuong)
        {
            return hienThiSanPhamDAL.HienThiDanhSachSanPhamTheoSoLuong(SoLuong);
        }

        public bool ThemMoiSanPham(SanPham sanPham)
        {
            return hienThiSanPhamDAL.ThemMoiSanPham(sanPham);
        }

        public bool ChinhSuaThongtinSanPham(SanPham sanPham)
        {
            return hienThiSanPhamDAL.ChinhSuaThongtinSanPham(sanPham);
        }

        public bool XoaSanPham(string MaSanPham)
        {
            return hienThiSanPhamDAL.XoaSanPham(MaSanPham);
        }
    }
}
