using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class HienThiPhieuXuatBLL
    {
        HienThiPhieuXuatDAL HienThiPhieuXuatDAL = new HienThiPhieuXuatDAL();

        public List<PhieuXuat> LayPhieuXuatTheoNgayThangNam(DateTime DateTime)
        {
            return HienThiPhieuXuatDAL.LayPhieuXuatTheoNgayThangNam(DateTime);
        }
        public List<PhieuXuat> LayThonTinPhieuXuatTheoMa(string MaPhieuXuat)
        {
            return HienThiPhieuXuatDAL.LayThonTinPhieuXuatTheoMa(MaPhieuXuat); 
        }


        public bool XoaThongTinPhieuXuat(string MaPhieuXuat)
        {
            if(MaPhieuXuat == null || MaPhieuXuat == "")
            {
                return false; 
            }
            return HienThiPhieuXuatDAL.XoaThongTinPhieuXuat(MaPhieuXuat);
        }

        public bool ThemMoiThongTinPhieuXuat(PhieuXuat phieuXuat)
        {
            foreach(PhieuXuat px in HienThiPhieuXuatDAL.LayToanBoPhieuXuat())
            {
                if(px.MaPhieuXuat == phieuXuat.MaPhieuXuat)
                {
                    return false; 
                }
            }
            return HienThiPhieuXuatDAL.ThemMoiThongTinPhieuXuat(phieuXuat); 
        }

        public bool CapNhapThongTinPhieuXuat(PhieuXuat phieuXuat)
        {
            return HienThiPhieuXuatDAL.CapNhapThongTinPhieuXuat(phieuXuat);
        }

        public List<PhieuXuat> LayToanBoPhieuXuat()
        {
            return HienThiPhieuXuatDAL.LayToanBoPhieuXuat();
        }


    }
}
