using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
    public class HienThiNhanVienBLL
    {
        HienThiNhanVienDAL HienThiNhanVienDAL = new HienThiNhanVienDAL(); 
        public List<NhanVien> LayToanBoNhanVien()
        {
            return HienThiNhanVienDAL.LayToanBoNhanVien(); 
        }
        public List<NhanVien> HienThiNhanVienTheoKho(string MaNhanVien)
        {
            return HienThiNhanVienDAL.HienThiNhanVienTheoKho(MaNhanVien); 
        }

        public bool ThemMoiNhanVien(NhanVien nhanVien)
        {
            if(nhanVien.TenNhanVien == "" || nhanVien.TenNhanVien == null)
            {
                nhanVien.TenNhanVien = "-"; 
            }
            if (nhanVien.GioiTinh == "" || nhanVien.GioiTinh == null)
            {
                nhanVien.GioiTinh = "-";
            }

            if (nhanVien.ChucVu== "" || nhanVien.ChucVu == null)
            {
                nhanVien.ChucVu = "-";
            }

            if (nhanVien.Email == "" || nhanVien.Email == null)
            {
                nhanVien.Email = "-";
            }

            if (nhanVien.SoDienThoai == "" || nhanVien.SoDienThoai == null)
            {
                nhanVien.SoDienThoai = "-";
            }
            if (nhanVien.DiaChi == "" || nhanVien.DiaChi == null)
            {
                nhanVien.DiaChi = "-";
            }
            
            return HienThiNhanVienDAL.ThemMoiNhanVien(nhanVien); 
        }


        public List<NhanVien> TimKiemNhanVienTheoMa(string MaNhanVien)
        {
            return HienThiNhanVienDAL.TimKiemNhanVienTheoMa(MaNhanVien); 
        }

        public List<NhanVien> TimKiemNhanVienTheoTen(string HoVaTen)
        {
            return HienThiNhanVienDAL.TimKiemNhanVienTheoTen(HoVaTen); 
        }

        public List<NhanVien> TimKiemSinhvienTheoCMT(string ChungMinhThu)
        {
            return HienThiNhanVienDAL.TimKiemSinhvienTheoCMT(ChungMinhThu); 
        }

        public bool XoaThongTinNhanVien(string MaNhanVien)
        {
            return HienThiNhanVienDAL.XoaThongTinNhanVien(MaNhanVien); 
        }

        public bool SuaThongTinNhanVien(NhanVien nhanVien)
        {
            if (nhanVien.TenNhanVien == "" || nhanVien.TenNhanVien == null)
            {
                nhanVien.TenNhanVien = "-";
            }
            if (nhanVien.GioiTinh == "" || nhanVien.GioiTinh == null)
            {
                nhanVien.GioiTinh = "-";
            }

            if (nhanVien.ChucVu == "" || nhanVien.ChucVu == null)
            {
                nhanVien.ChucVu = "-";
            }

            if (nhanVien.Email == "" || nhanVien.Email == null)
            {
                nhanVien.Email = "-";
            }

            if (nhanVien.SoDienThoai == "" || nhanVien.SoDienThoai == null)
            {
                nhanVien.SoDienThoai = "-";
            }
            if (nhanVien.DiaChi == "" || nhanVien.DiaChi == null)
            {
                nhanVien.DiaChi = "-";
            }
            return HienThiNhanVienDAL.SuaThongTinNhanVien(nhanVien); 
        }
    }


}
