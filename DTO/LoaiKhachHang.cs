using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class LoaiKhachHang
    {
        public string MaLoaiKhachHang
        {
            get;
            set;
        }
        public string TenLoaiKhachHang
        {
            get;
            set;
        }
        public string KhuyenMai
        {
            get;
            set;
        }
        public override string ToString()
        {
            return TenLoaiKhachHang;
        }
    }
}
