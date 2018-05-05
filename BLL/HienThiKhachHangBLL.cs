using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
    public class HienThiKhachHangBLL
    {
        HienThiKhachHangDAL HienThiKhachHangDAL = new HienThiKhachHangDAL(); 
        public List<KhachHang> HienThiDanhSachKhachHang()
        {
            return HienThiKhachHangDAL.HienThiDanhSachKhachHang(); 
        }

        public List<KhachHang> HienThiDanhSachKhachHangTheoLoai(string MaLoaiKhachHang)
        {
            return HienThiKhachHangDAL.HienThiDanhSachKhachHangTheoLoai(MaLoaiKhachHang); 
        }

        public List<KhachHang> HienThiDanhSachKhachHangTheoMa(string MaKhachHang)
        {
            return HienThiKhachHangDAL.HienThiDanhSachKhachHangTheoMa(MaKhachHang); 
        }

        public List<KhachHang> HienThiDanhSachKhachHangTheoTen(string TenKhachHang)
        {
            return HienThiKhachHangDAL.HienThiDanhSachKhachHangTheoTen(TenKhachHang); 
        }

        public List<KhachHang> HienThiDanhSachKhachHangTheoCMT(string ChungMinhThu)
        {
            return HienThiKhachHangDAL.HienThiDanhSachKhachHangTheoCMT(ChungMinhThu); 
        }

        public bool ThemMoiKhachHang(KhachHang khachHang)
        {
            if(khachHang.TenKhachHang ==""||khachHang.TenKhachHang ==null)
            {
                khachHang.TenKhachHang = "-"; 
            }
            if (khachHang.DiaChi == "" || khachHang.DiaChi == null)
            {
                khachHang.DiaChi = "-";
            }
            if (khachHang.DienThoai == "" || khachHang.DienThoai == null)
            {
                khachHang.DienThoai = "-";
            }
            if (khachHang.ChungMinhThu == "" || khachHang.ChungMinhThu == null)
            {
                khachHang.DienThoai = "-";
            }
            if (khachHang.GioiTinh == "" || khachHang.GioiTinh == null)
            {
                khachHang.GioiTinh = "-";
            }
            if (khachHang.NgaySinh == null)
            {
                khachHang.NgaySinh = new DateTime(1,1,1);
            }
           return  HienThiKhachHangDAL.ThemMoiKhachHang(khachHang); 
            
        }

        public bool SuaThongTinKhachHang(KhachHang khachHang)
        {
            if (khachHang.TenKhachHang == "" || khachHang.TenKhachHang == null)
            {
                khachHang.TenKhachHang = "-";
            }
            if (khachHang.DiaChi == "" || khachHang.DiaChi == null)
            {
                khachHang.DiaChi = "-";
            }
            if (khachHang.DienThoai == "" || khachHang.DienThoai == null)
            {
                khachHang.DienThoai = "-";
            }
            if (khachHang.ChungMinhThu == "" || khachHang.ChungMinhThu == null)
            {
                khachHang.DienThoai = "-";
            }
            if (khachHang.GioiTinh == "" || khachHang.GioiTinh == null)
            {
                khachHang.GioiTinh = "-";
            }
            if (khachHang.NgaySinh == null)
            {
                khachHang.NgaySinh = new DateTime(1, 1, 1);
            }
            return HienThiKhachHangDAL.SuaThongTinKhachHang(khachHang);
        }

        public bool XoaThongTinKhachHang(string MaKhachHang)
        {
            return HienThiKhachHangDAL.XoaThongTinKhachHang(MaKhachHang); 
        }
    }
}
