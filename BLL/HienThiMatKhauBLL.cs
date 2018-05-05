using DAL;
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
        public bool KiemTraDangNhap(string TaiKhoan, string MatKhau)
        {
            return HienThiMatKhauDAL.KiemTraDangNhap(TaiKhoan, MatKhau); 
        }
    }
}
