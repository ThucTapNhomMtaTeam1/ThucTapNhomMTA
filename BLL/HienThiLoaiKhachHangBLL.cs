using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL; 

namespace BLL
{
    public class HienThiLoaiKhachHangBLL
    {
        HienThiLoaiKhachHangDAL HienThiLoaiKhachHangDAL = new HienThiLoaiKhachHangDAL();
        public List<LoaiKhachHang> HienThiDanhSachLoaiKhachHang()
        {
            return HienThiLoaiKhachHangDAL.HienThiDanhSachLoaiKhachHang(); 
        }

        public List<LoaiKhachHang> HienThiDanhSachLKHTheoTen(string TenLoaiKhachHang)
        {
            return HienThiLoaiKhachHangDAL.HienThiDanhSachLKHTheoTen(TenLoaiKhachHang); 
        }

        public List<LoaiKhachHang> HienThiDanhSachLKHTheoMa(string MaLoaiKhachHang)
        {
            return HienThiLoaiKhachHangDAL.HienThiDanhSachLKHTheoMa(MaLoaiKhachHang); 
        }

        public bool XoaLoaiKhachHang(string MaLoaiKhachHang)
        {
            return HienThiLoaiKhachHangDAL.XoaLoaiKhachHang(MaLoaiKhachHang); 
        }

        public bool ThemLoaiKhachHang(LoaiKhachHang loaiKhachHang)
        {
            if(loaiKhachHang.TenLoaiKhachHang == "" || loaiKhachHang.TenLoaiKhachHang == null)
            {
                loaiKhachHang.TenLoaiKhachHang = "-"; 
            }

            if (loaiKhachHang.KhuyenMai == "" || loaiKhachHang.KhuyenMai == null)
            {
                loaiKhachHang.KhuyenMai = "-";
            }

            return HienThiLoaiKhachHangDAL.ThemLoaiKhachHang(loaiKhachHang); 
        }

        public bool SuaLoaiKhachHang(LoaiKhachHang loaiKhachHang)
        {
            if (loaiKhachHang.TenLoaiKhachHang == "" || loaiKhachHang.TenLoaiKhachHang == null)
            {
                loaiKhachHang.TenLoaiKhachHang = "-";
            }

            if (loaiKhachHang.KhuyenMai == "" || loaiKhachHang.KhuyenMai == null)
            {
                loaiKhachHang.KhuyenMai = "-";
            }

            return HienThiLoaiKhachHangDAL.SuaLoaiKhachHang(loaiKhachHang);
        }

    }
}
