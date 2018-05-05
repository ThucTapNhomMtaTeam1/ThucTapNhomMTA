using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL; 
namespace BLL
{
    public class HienThiNhaSanXuatBLL
    {

        HienThiNhaSanXuatDAL HienThiNhaSanXuatDAL = new HienThiNhaSanXuatDAL(); 
        public List<NhaSanXuat> HienThiDanhSachNSX()
        {
            return HienThiNhaSanXuatDAL.HienThiDanhSachNSX(); 
        }

        public List<NhaSanXuat> HienThiDanhSachNSXTheoTen(string TenNhaSanXuat)
        {
            return HienThiNhaSanXuatDAL.HienThiDanhSachNSXTheoTen(TenNhaSanXuat); 
        }

        public List<NhaSanXuat> HienThiDanhSachNSXTheoMa(string MaNhaSanXuat)
        {
            return HienThiNhaSanXuatDAL.HienThiDanhSachNSXTheoMa(MaNhaSanXuat); 
        }

        public List<NhaSanXuat> HienThiDanhSachNSXTheoQuocGia(string QuocGia)
        {
            return HienThiNhaSanXuatDAL.HienThiDanhSachNSXTheoQuocGia(QuocGia); 
        }
        public bool ThemMoiNhaSanXuat(NhaSanXuat nhaSanXuat)
        {
            if(nhaSanXuat.TenNhaSanXuat ==""||nhaSanXuat.TenNhaSanXuat == null)
            {
                nhaSanXuat.TenNhaSanXuat = "-"; 
            }
            if (nhaSanXuat.QuocGia == "" || nhaSanXuat.QuocGia == null)
            {
                nhaSanXuat.QuocGia = "-";
            }
            return HienThiNhaSanXuatDAL.ThemMoiNhaSanXuat(nhaSanXuat); 
        }

        public bool SuaThongTinNXX(NhaSanXuat nhaSanXuat)
        {
            if (nhaSanXuat.TenNhaSanXuat == "" || nhaSanXuat.TenNhaSanXuat == null)
            {
                nhaSanXuat.TenNhaSanXuat = "-";
            }
            if (nhaSanXuat.QuocGia == "" || nhaSanXuat.QuocGia == null)
            {
                nhaSanXuat.QuocGia = "-";
            }
            return HienThiNhaSanXuatDAL.SuaThongTinNXX(nhaSanXuat);
        }

        public bool XoaThongTinNXX(string MaNhaSanXuat)
        {
            return HienThiNhaSanXuatDAL.XoaThongTinNXX(MaNhaSanXuat); 
        }
    }
}
