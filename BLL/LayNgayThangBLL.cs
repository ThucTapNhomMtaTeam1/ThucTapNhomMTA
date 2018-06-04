using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class LayNgayThangBLL
    {
        LayNgayThangDAL layNgayThangDAL = new LayNgayThangDAL();
        public List<NgayThang> LayDanhSachCacNamPN()
        {
            return layNgayThangDAL.LayDanhSachCacNamPN();
        }

        public List<NgayThang> LayDanhSachCacThangTheoNamPN(DateTime DateTime)
        {
            return layNgayThangDAL.LayDanhSachCacThangTheoNamPN(DateTime);
        }
        public List<NgayThang> LayDanhSachCacNgayTheoThangNamPN(DateTime DateTime)
        {
            return layNgayThangDAL.LayDanhSachCacNgayTheoThangNamPN(DateTime);
        }

        public List<NgayThang> LayDanhSachCacNamPhieuXuat()
        {
            return layNgayThangDAL.LayDanhSachCacNamPhieuXuat();
        }

        public List<NgayThang> LayDanhSachCacThangTheoNamPhieuXuat(DateTime DateTime)
        {
            return layNgayThangDAL.LayDanhSachCacThangTheoNamPhieuXuat(DateTime);
        }

        public List<NgayThang> LayDanhSachCacNgayTheoThangNamPhieuXuat(DateTime DateTime)
        {
            return layNgayThangDAL.LayDanhSachCacNgayTheoThangNamPhieuXuat(DateTime);
        }
    }
}
