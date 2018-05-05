using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL; 

namespace BLL
{
    public class HienThiNhaCungCapBLL
    {
        HienThiNhaCungCapDAL HienThiNhaCungCapDAL = new HienThiNhaCungCapDAL(); 

        public List<NhaCungCap> HienThiDanhSachNCC()
        {
            return HienThiNhaCungCapDAL.HienThiDanhSachNCC(); 
        }
        public List<NhaCungCap> HienThiDanhSachNCCTheoTen(string TenNhaCungCap)
        {
            return HienThiNhaCungCapDAL.HienThiDanhSachNCCTheoTen(TenNhaCungCap); 
        }
        public List<NhaCungCap> HienThiDanhSachNCCTheoMa(string MaNhaCungCap)
        {
            return HienThiNhaCungCapDAL.HienThiDanhSachNCCTheoMa(MaNhaCungCap); 
        }


        public bool ThemMoiNhaCungCap(NhaCungCap nhaCungCap)
        {
            if(nhaCungCap.TenNhaCungCap == null || nhaCungCap.TenNhaCungCap == "")
            {
                nhaCungCap.TenNhaCungCap = ""; 
            }
            if (nhaCungCap.DiaChi == null || nhaCungCap.DiaChi == "")
            {
                nhaCungCap.DiaChi = "";
            }
            if (nhaCungCap.SoDienThoai == null || nhaCungCap.SoDienThoai == "")
            {
                nhaCungCap.SoDienThoai = "";
            }
            return  HienThiNhaCungCapDAL.ThemMoiNhaCungCap(nhaCungCap); 

        }

        public bool ChinhSuaNhaCungCap(NhaCungCap nhaCungCap)
        {
            if (nhaCungCap.TenNhaCungCap == null || nhaCungCap.TenNhaCungCap == "")
            {
                nhaCungCap.TenNhaCungCap = "";
            }
            if (nhaCungCap.DiaChi == null || nhaCungCap.DiaChi == "")
            {
                nhaCungCap.DiaChi = "";
            }
            if (nhaCungCap.SoDienThoai == null || nhaCungCap.SoDienThoai == "")
            {
                nhaCungCap.SoDienThoai = "";
            }
            return HienThiNhaCungCapDAL.ChinhSuaNhaCungCap(nhaCungCap);
        }

        public bool XoaNhaCungCap(string MaNhaCungCap)
        {
            return HienThiNhaCungCapDAL.XoaNhaCungCap(MaNhaCungCap); 
        }
    }
}
