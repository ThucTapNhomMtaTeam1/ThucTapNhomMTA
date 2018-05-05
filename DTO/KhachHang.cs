using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class KhachHang
    {
        public string MaKhachHang
        {
            get;
            set;
        }
        public string TenKhachHang
        { 
            get;
            set;
        }
        public DateTime NgaySinh
        {
            get;
            set;
        }
        public string GioiTinh
        {
            get;
            set;
        }
        public string DiaChi
        {
            get;
            set;
        }

        public string ChungMinhThu
        {
            get;
            set;
        }

        public string LoaiKhachHang
        {
            get;
            set;
        }

        public string DienThoai
        {
            get;
            set;
        }
        public override string ToString()
        {
            return TenKhachHang; 
        }

    }
}
