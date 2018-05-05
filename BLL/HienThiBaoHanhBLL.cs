using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
    public class HienThiBaoHanhBLL
    {
        HienThiBaoHanhDAL hienThiBaoHanhDAL = new HienThiBaoHanhDAL();
        public List<BaoHanh> LayToanBoBaoHanh()
        {
            return hienThiBaoHanhDAL.HienThiDanhSachBaoHanh();
        }
        public bool ThemBaoHanh(BaoHanh baoHanh)
        {
            return hienThiBaoHanhDAL.ThemMoiBaoHanh(baoHanh);
        }
        public bool XoaBaoHanh(string MaBaoHanh)
        {
            return hienThiBaoHanhDAL.XoaBaoHanh(MaBaoHanh);
        }
        public bool ThayDoiThongTinBaoHanhDAL(BaoHanh baoHanh)
        {
            return hienThiBaoHanhDAL.ThayDoiThongTinBaoHanhDAL(baoHanh);
        }
        public List<BaoHanh> HienThiDanhSachBaoHanhTheoMaBH(string MaBaoHanh)
        {
            return hienThiBaoHanhDAL.HienThiDanhSachBaoHanhTheoMaBH(MaBaoHanh);
        }
        public List<BaoHanh> HienThiDanhSachBaoHanhTheoMaMay(string MaBaoHanh)
        {
            return hienThiBaoHanhDAL.HienThiDanhSachBaoHanhTheoMaMay(MaBaoHanh);
        }
        public List<BaoHanh> HienThiDanhSachBaoHanhTheoMaPhieuXuat(string MaBaoHanh)
        {
            return hienThiBaoHanhDAL.HienThiDanhSachBaoHanhTheoMaPhieuXuat(MaBaoHanh);
        }
        public List<BaoHanh> HienThiDanhSachBaoHanhTheoNgayHetHan(string MaBaoHanh)
        {
            return hienThiBaoHanhDAL.HienThiDanhSachBaoHanhTheoNgayHetHan(MaBaoHanh);
        }
        public List<BaoHanh> HienThiDanhSachBaoHanhTheoNgayBatDau(string MaBaoHanh)
        {
            return hienThiBaoHanhDAL.HienThiDanhSachBaoHanhTheoNgayBatDau(MaBaoHanh);

        }
    }
}
