using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class HienThiBaoHanhDAL : AccessDataBase
    {
        public List<BaoHanh> HienThiDanhSachBaoHanh()
        {
            try
            {

                OpenDataBase();
                SqlCommand sqlCommand = new SqlCommand();
                List<BaoHanh> DanhSachBaoHanh = new List<BaoHanh>();
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandText = "HienThiDanhSachBaoHanh";
                sqlCommand.Connection = sqlConnection;
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    BaoHanh baoHanh = new BaoHanh()
                    {
                        MaBaoHanh = sqlDataReader.GetString(0),
                        TenSanPham = sqlDataReader.GetString(1),
                        MaMay = sqlDataReader.GetString(2),
                        MaHoaDon = sqlDataReader.GetString(3),
                        MaPhieuXuat = sqlDataReader.GetString(4),
                        MaKhachHang = sqlDataReader.GetString(5),
                        NgayBatDau = sqlDataReader.GetDateTime(6),
                        NgayHetHan = sqlDataReader.GetDateTime(7)

                    };
                    DanhSachBaoHanh.Add(baoHanh);

                }
                CloseDataBase();
                sqlDataReader.Close();
                return DanhSachBaoHanh;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public bool ThemMoiBaoHanh(BaoHanh baoHanh)
        {
            try
            {

                OpenDataBase();
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandText = "ThemMoiBaoHanh";
                sqlCommand.Connection = sqlConnection;
                sqlCommand.Parameters.Add("@MaBaoHanh", SqlDbType.Char).Value = baoHanh.MaBaoHanh;
                sqlCommand.Parameters.Add("@MaMay", SqlDbType.Char).Value = baoHanh.MaMay;
                //sqlCommand.Parameters.Add("@MaHoaDon", SqlDbType.Char).Value = baoHanh.MaHoaDon;
                sqlCommand.Parameters.Add("@MaPhieuXuat", SqlDbType.Char).Value = baoHanh.MaPhieuXuat;
                //sqlCommand.Parameters.Add("@MaKhachHang", SqlDbType.Char).Value = baoHanh.MaKhachHang;
                sqlCommand.Parameters.Add("@NgayBatDau", SqlDbType.DateTime).Value = baoHanh.NgayBatDau;
                sqlCommand.Parameters.Add("@NgayHetHan", SqlDbType.DateTime).Value = baoHanh.NgayHetHan;

                int k = sqlCommand.ExecuteNonQuery();
                return k > 0;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool ThayDoiThongTinBaoHanhDAL(BaoHanh baoHanh)
        {
            try
            {
                OpenDataBase();
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandText = "ChinhSuaThongTinBaoHanh";
                sqlCommand.Connection = sqlConnection;
                sqlCommand.Parameters.Add("@MaBaoHanh", SqlDbType.Char).Value = baoHanh.MaBaoHanh;
                sqlCommand.Parameters.Add("@MaMay", SqlDbType.Char).Value = baoHanh.MaMay;
                sqlCommand.Parameters.Add("@MaPhieuXuat", SqlDbType.Char).Value = baoHanh.MaPhieuXuat;
                sqlCommand.Parameters.Add("@NgayBatDau", SqlDbType.DateTime).Value = baoHanh.NgayBatDau;
                sqlCommand.Parameters.Add("@NgayHetHan", SqlDbType.DateTime).Value = baoHanh.NgayHetHan;

                int k = sqlCommand.ExecuteNonQuery();
                CloseDataBase();
                return k > 0;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool XoaBaoHanh(string MaBaoHanh)
        {
            try
            {
                OpenDataBase();
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandText = "XoaBaoHanh";
                sqlCommand.Connection = sqlConnection;
                sqlCommand.Parameters.Add("@MaBaoHanh", SqlDbType.Char).Value = MaBaoHanh;
                int k = sqlCommand.ExecuteNonQuery();
                CloseDataBase();
                return k > 0;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<BaoHanh> HienThiDanhSachBaoHanhTheoMaBH(string MaBaoHanh)
        {
            try
            {
                OpenDataBase();
                SqlCommand sqlCommand = new SqlCommand();
                List<BaoHanh> DanhSachBH = new List<BaoHanh>();
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandText = "HienThiDanhSachSanPhamTheoMaBH";
                sqlCommand.Connection = sqlConnection;
                sqlCommand.Parameters.Add("@MaBaoHanh", SqlDbType.Char).Value = MaBaoHanh;
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    BaoHanh baoHanh = new BaoHanh()
                    {
                        MaBaoHanh = sqlDataReader.GetString(0),
                        TenSanPham = sqlDataReader.GetString(1),
                        MaMay = sqlDataReader.GetString(2),
                        MaHoaDon = sqlDataReader.GetString(3),
                        MaPhieuXuat = sqlDataReader.GetString(4),
                        MaKhachHang = sqlDataReader.GetString(5),
                        NgayBatDau = sqlDataReader.GetDateTime(6),
                        NgayHetHan = sqlDataReader.GetDateTime(7)
                    };
                    DanhSachBH.Add(baoHanh);
                }
                CloseDataBase();
                sqlDataReader.Close();
                return DanhSachBH;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<BaoHanh> HienThiDanhSachBaoHanhTheoMaMay(string MaMay)
        {
            try
            {
                OpenDataBase();
                SqlCommand sqlCommand = new SqlCommand();
                List<BaoHanh> DanhSachBH = new List<BaoHanh>();
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandText = "HienThiDanhSachSanPhamTheoMaMay";
                sqlCommand.Connection = sqlConnection;
                sqlCommand.Parameters.Add("@MaMay", SqlDbType.Char).Value = MaMay;
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    BaoHanh baoHanh = new BaoHanh()
                    {
                        MaBaoHanh = sqlDataReader.GetString(0),
                        TenSanPham = sqlDataReader.GetString(1),
                        MaMay = sqlDataReader.GetString(2),
                        MaHoaDon = sqlDataReader.GetString(3),
                        MaPhieuXuat = sqlDataReader.GetString(4),
                        MaKhachHang = sqlDataReader.GetString(5),
                        NgayBatDau = sqlDataReader.GetDateTime(6),
                        NgayHetHan = sqlDataReader.GetDateTime(7)
                    };
                    DanhSachBH.Add(baoHanh);
                }
                CloseDataBase();
                sqlDataReader.Close();
                return DanhSachBH;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<BaoHanh> HienThiDanhSachBaoHanhTheoNgayBatDau(string NgayBatDau)
        {
            try
            {
                OpenDataBase();
                SqlCommand sqlCommand = new SqlCommand();
                List<BaoHanh> DanhSachBH = new List<BaoHanh>();
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandText = "HienThiDanhSachBaoHanhTheoNgayBatDau";
                sqlCommand.Connection = sqlConnection;
                sqlCommand.Parameters.Add("@NgayBatDau", SqlDbType.DateTime).Value = NgayBatDau;
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    BaoHanh baoHanh = new BaoHanh()
                    {
                        MaBaoHanh = sqlDataReader.GetString(0),
                        TenSanPham = sqlDataReader.GetString(1),
                        MaMay = sqlDataReader.GetString(2),
                        MaHoaDon = sqlDataReader.GetString(3),
                        MaPhieuXuat = sqlDataReader.GetString(4),
                        MaKhachHang = sqlDataReader.GetString(5),
                        NgayBatDau = sqlDataReader.GetDateTime(6),
                        NgayHetHan = sqlDataReader.GetDateTime(7)
                    };
                    DanhSachBH.Add(baoHanh);
                }
                CloseDataBase();
                sqlDataReader.Close();
                return DanhSachBH;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<BaoHanh> HienThiDanhSachBaoHanhTheoNgayHetHan(string NgayHetHan)
        {
            try
            {
                OpenDataBase();
                SqlCommand sqlCommand = new SqlCommand();
                List<BaoHanh> DanhSachBH = new List<BaoHanh>();
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandText = "HienThiDanhSachBaoHanhTheoNgayHetHan";
                sqlCommand.Connection = sqlConnection;
                sqlCommand.Parameters.Add("@NgayHetHan", SqlDbType.DateTime).Value = NgayHetHan;
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    BaoHanh baoHanh = new BaoHanh()
                    {
                        MaBaoHanh = sqlDataReader.GetString(0),
                        TenSanPham = sqlDataReader.GetString(1),
                        MaMay = sqlDataReader.GetString(2),
                        MaHoaDon = sqlDataReader.GetString(3),
                        MaPhieuXuat = sqlDataReader.GetString(4),
                        MaKhachHang = sqlDataReader.GetString(5),
                        NgayBatDau = sqlDataReader.GetDateTime(6),
                        NgayHetHan = sqlDataReader.GetDateTime(7)
                    };
                    DanhSachBH.Add(baoHanh);
                }
                CloseDataBase();
                sqlDataReader.Close();
                return DanhSachBH;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<BaoHanh> HienThiDanhSachBaoHanhTheoMaPhieuXuat(string MaPhieuXuat)
        {
            try
            {
                OpenDataBase();
                SqlCommand sqlCommand = new SqlCommand();
                List<BaoHanh> DanhSachBH = new List<BaoHanh>();
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandText = "HienThiDanhSachBaoHanhTheoMaPhieuXuat";
                sqlCommand.Connection = sqlConnection;
                sqlCommand.Parameters.Add("@MaPhieuXuat", SqlDbType.Char).Value = MaPhieuXuat;
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    BaoHanh baoHanh = new BaoHanh()
                    {
                        MaBaoHanh = sqlDataReader.GetString(0),
                        TenSanPham = sqlDataReader.GetString(1),
                        MaMay = sqlDataReader.GetString(2),
                        MaHoaDon = sqlDataReader.GetString(3),
                        MaPhieuXuat = sqlDataReader.GetString(4),
                        MaKhachHang = sqlDataReader.GetString(5),
                        NgayBatDau = sqlDataReader.GetDateTime(6),
                        NgayHetHan = sqlDataReader.GetDateTime(7)
                    };
                    DanhSachBH.Add(baoHanh);
                }
                CloseDataBase();
                sqlDataReader.Close();
                return DanhSachBH;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }

}



