using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class HienThiMatKhauBLL
    {
        HienThiMatKhauDAL HienThiMatKhauDAL = new HienThiMatKhauDAL(); 
        public int KiemTraDangNhap(string TaiKhoan, string MatKhau)
        {
            return HienThiMatKhauDAL.KiemTraDangNhap(TaiKhoan, MatKhau); 
        }

        public List<TaiKhoan> HienThiDanhSachTaiKhoan()
        {
            return  HienThiMatKhauDAL.HienThiDanhSachTaiKhoan(); 
        }

        public List<TaiKhoan> HienThiTaiKhoanTheoTen(string TenTaiKhoan)
        {
            return HienThiMatKhauDAL.HienThiTaiKhoanTheoTen(TenTaiKhoan); 
        }

        public List<TaiKhoan> HienThiTaiKhoanTheoTenDayDu(string TenTaiKhoan)
        {
            return HienThiMatKhauDAL.HienThiTaiKhoanTheoTenDayDu(TenTaiKhoan);
        }

        public bool ThemThongTinNguoiDung(TaiKhoan taiKhoan)
        {
            KiemTraTaiKhoan(taiKhoan); 
            return HienThiMatKhauDAL.ThemThongTinNguoiDung(taiKhoan);
        }

        public bool XoaThongTinNguoiDung(string TenTaiKhoan)
        {
            return HienThiMatKhauDAL.XoaThongTinNguoiDung(TenTaiKhoan);
        }


        public bool ChinhSuaThongTinNguoiDung(TaiKhoan taiKhoan)
        {
            KiemTraTaiKhoan(taiKhoan);
            return HienThiMatKhauDAL.ChinhSuaThongTinNguoiDung(taiKhoan);
        }

        public void KiemTraTaiKhoan(TaiKhoan taiKhoan)
        {
            if (taiKhoan.TenDayDu == null)
            {
                taiKhoan.TenDayDu = "";
            }
            if (taiKhoan.GioiTinh == null)
            {
                taiKhoan.GioiTinh = "";
            }
            if (taiKhoan.DienThoai == null)
            {
                taiKhoan.DienThoai = "";
            }
        }
    }


}
