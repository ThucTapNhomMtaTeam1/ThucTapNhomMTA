using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NhanVien
    {
        public string MaNhanVien
        {
            get;
            set;
        }
        public string TenNhanVien
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

        public string SoDienThoai
        {
            get;
            set;
        }

        public string Email
        {
            get;
            set;
        }

        public string ChucVu
        {
            get;
            set;
        }

        public string TienLuong
        {
            get;
            set;
        }
        public DateTime NgayVaoLam
        {
            get;
            set;
        }
        public string KhoHang
        {
            get;
            set;
        }
        public string ChungMinhThu
        {
            get;
            set;
        }

        public override string ToString()
        {
            return TenNhanVien; 
        }
    }
}
