using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO; 

namespace BLL
{
    public class HienThiKhoHangBLL
    {
        HienThiKhoHangDAL HienThiKhoHangDAL = new HienThiKhoHangDAL(); 
        public List<KhoHang> LayToanBoKhoHang()
        {
            return HienThiKhoHangDAL.LayToanBoKhoHang(); 
        }

        public bool ThemMoiKhoHang(KhoHang khoHang)
        {
            if(khoHang.TenKhoHang =="" || khoHang.TenKhoHang == null)
            {
                khoHang.TenKhoHang = "-"; 
            }

            if (khoHang.DiaChi == "" || khoHang.DiaChi == null)
            {
                khoHang.DiaChi = "-";
            }

            if (khoHang.SoDienThoai == "" || khoHang.SoDienThoai == null)
            {
                khoHang.SoDienThoai = "-";
            }
            return HienThiKhoHangDAL.ThemMoiKhoHang(khoHang); 
        }

        public bool XoaKhoHang(KhoHang khoHang)
        {
            return HienThiKhoHangDAL.XoaKhoHang(khoHang); 
        }

        public bool ChinhSuaKhoHang(KhoHang khoHang)
        {
            if (khoHang.TenKhoHang == "" || khoHang.TenKhoHang == null)
            {
                khoHang.TenKhoHang = "-";
            }

            if (khoHang.DiaChi == "" || khoHang.DiaChi == null)
            {
                khoHang.DiaChi = "-";
            }

            if (khoHang.SoDienThoai == "" || khoHang.SoDienThoai == null)
            {
                khoHang.SoDienThoai = "-";
            }
            return HienThiKhoHangDAL.ChinhSuaKhoHang(khoHang);
        }

        public List<KhoHang> HienThiKhoHangTheoMa(string MaKhoHang)
        {
            return HienThiKhoHangDAL.HienThiKhoHangTheoMa(MaKhoHang); 
        }

        public List<KhoHang> HienThiKhoHangTheoTen(string TenKhoHang)
        {
            return HienThiKhoHangDAL.HienThiKhoHangTheoTen(TenKhoHang);
        }
    }


}
