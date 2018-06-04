using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class HienThiCT_PhieuXuatBLL
    {
        HienThiCT_PhieuXuatDAL hienThiCT_PhieuXuatDAL = new HienThiCT_PhieuXuatDAL(); 
        public List<CT_PhieuXuat> HienThiChiTietPhieuXuatTheoMa(string MaPhieuXuat)
        {
            return hienThiCT_PhieuXuatDAL.HienThiPhieuXuatTheoMaPhieuXuat(MaPhieuXuat); 
        }

        public bool ThemMoiChiTietPhieuXuat(CT_PhieuXuat CT_PphieuXuat)
        {
            return hienThiCT_PhieuXuatDAL.ThemMoiChiTietPhieuXuat(CT_PphieuXuat); 
        }
    }
}
