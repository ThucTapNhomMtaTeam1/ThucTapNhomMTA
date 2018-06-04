using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class HienThiPhieuNhapBLL
    {
        HienThiPhieuNhapDAL HienThiPhieuNhapDAL = new HienThiPhieuNhapDAL(); 
        public List<PhieuNhap> LayPhieuNhapTheoNgayThangNam(DateTime DateTime)
        {
            return HienThiPhieuNhapDAL.LayPhieuNhapTheoNgayThangNam(DateTime); 
        }
        public bool ThemMoiPhieuNhap(PhieuNhap phieuNhap)
        {
           return  HienThiPhieuNhapDAL.ThemMoiPhieuNhap(phieuNhap); 
        }
        public List<PhieuNhap> HienThiToanBoDanhSachPhieuNhap()
        {
            return HienThiPhieuNhapDAL.HienThiToanBoDanhSachPhieuNhap(); 
        }
        public bool XoaThongTinPhieuNhap(string MaPhieuNhap)
        {
            if(MaPhieuNhap == null)
            {
                return false; 
            }
            return HienThiPhieuNhapDAL.XoaThongTinPhieuNhap(MaPhieuNhap); 
        }

        public bool ChinhSuaThongTinPhieuNhap(PhieuNhap phieuNhap)
        {

            return HienThiPhieuNhapDAL.SuaThongTinPhieuNhap(phieuNhap); 
        }

        public List<PhieuNhap> LayThongTinPhieuNhapTheoMa(string MaSanPham)
        {
            return HienThiPhieuNhapDAL.LayThongTinPhieuNhapTheoMa(MaSanPham); 
        }
    }
}
