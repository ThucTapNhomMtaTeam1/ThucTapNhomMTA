using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NhaCungCap
    {
        public string  MaNhaCungCap
        {
            get;
            set; 
        }
        public string TenNhaCungCap
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
            return TenNhaCungCap; 
        }
    }
}
