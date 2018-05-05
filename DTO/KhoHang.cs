using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class KhoHang
    {
        public string MaKhoHang
        {
            get;
            set; 
        }
        public string TenKhoHang
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
        public override string ToString()
        {
            return TenKhoHang; 
        }
    }
}
