using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NhaSanXuat
    {
        public string MaNhaSanXuat
        {
            get;
            set; 
        }
        public string TenNhaSanXuat
        {
            get;
            set;
        }
        public string QuocGia
        {
            get;
            set;
        }
        public override string ToString()
        {
            return TenNhaSanXuat; 
        }
        
    }
}
