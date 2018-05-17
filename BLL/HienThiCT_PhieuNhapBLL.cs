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
    }
}
