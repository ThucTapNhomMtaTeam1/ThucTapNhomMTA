using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO; 

namespace BLL
{
    public class HienThiLoaiSanPhamBLL
    {
        HienThiLoaiSanPhamDAL HienThiLoaiSanPhamDAL = new HienThiLoaiSanPhamDAL();
        public List<LoaiSanPham> HienThiDanhSachLoaiSanPham()
        {
            return HienThiLoaiSanPhamDAL.HienThiDanhSachLoaiSanPham(); 
        }

        public List<LoaiSanPham> HienThiDanhSachLoaiSanPhamTheoTen(string TenLoaiSanPham)
        {
            return HienThiLoaiSanPhamDAL.HienThiDanhSachLoaiSanPhamTheoTen(TenLoaiSanPham);
        }

        public List<LoaiSanPham> HienThiDanhSachLoaiSanPhamTheoMa(string MaLoaiSanPham)
        {
            return HienThiLoaiSanPhamDAL.HienThiDanhSachLoaiSanPhamTheoMa(MaLoaiSanPham);
        }

        public bool ThemMoiLoaiSanPham(LoaiSanPham loaiSanPham)
        {
            if(loaiSanPham.TenLoaiSanPham == "" || loaiSanPham.MaLoaiSanPham == null)
            {
                loaiSanPham.TenLoaiSanPham = "-"; 
            }

            if (loaiSanPham.DonViTinh == "" || loaiSanPham.DonViTinh == null)
            {
                loaiSanPham.DonViTinh = "-";
            }

            if (loaiSanPham.GhiChu == "" || loaiSanPham.GhiChu == null)
            {
                loaiSanPham.GhiChu = "-";
            }

            return HienThiLoaiSanPhamDAL.ThemMoiLoaiSanPham(loaiSanPham); 
        }


        public bool XoaLoaiSanPham(string MaLoaiSanPham)
        {
            return HienThiLoaiSanPhamDAL.XoaLoaiSanPham(MaLoaiSanPham); 
        }


        public bool SuaThongTinLoaiSanPham(LoaiSanPham loaiSanPham)
        {
            if (loaiSanPham.TenLoaiSanPham == "" || loaiSanPham.MaLoaiSanPham == null)
            {
                loaiSanPham.TenLoaiSanPham = "-";
            }

            if (loaiSanPham.DonViTinh == "" || loaiSanPham.DonViTinh == null)
            {
                loaiSanPham.DonViTinh = "-";
            }

            if (loaiSanPham.GhiChu == "" || loaiSanPham.GhiChu == null)
            {
                loaiSanPham.GhiChu = "-";
            }

            return HienThiLoaiSanPhamDAL.SuaThongTinLoaiSanPham(loaiSanPham);

        }


    }
}
