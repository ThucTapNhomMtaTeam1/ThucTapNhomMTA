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
    }
}
