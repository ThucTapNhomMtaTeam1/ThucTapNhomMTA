using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class LoaiSanPham
    {
        public string MaLoaiSanPham
        {
            get;
            set; 
        }
        public string TenLoaiSanPham
        {
            get;
            set;
        }
        public string DonViTinh
        {
            get;
            set; 
        }
        public string GhiChu
        {
            get;
            set; 
        }
        public override string ToString()
        {
            return TenLoaiSanPham; 
        }
    }
}
