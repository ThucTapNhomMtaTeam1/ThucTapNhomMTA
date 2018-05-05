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
    public class HienThiLoaiKhachHangDAL: AccessDataBase
    {
        public List<LoaiKhachHang> HienThiDanhSachLoaiKhachHang()
        {
            OpenDataBase();
            List<LoaiKhachHang> DanhSachLoaiKhachHang = new List<LoaiKhachHang>(); 
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.CommandText = "HienThiDanhSachLoaiKhachHang";
            sqlCommand.Connection = sqlConnection;
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            while (sqlDataReader.Read())
            {
                LoaiKhachHang loaiKhachHang = new LoaiKhachHang()
                {
                    MaLoaiKhachHang = sqlDataReader[0].ToString(),
                    TenLoaiKhachHang = sqlDataReader[1].ToString(),
                    KhuyenMai = sqlDataReader[2].ToString(),
                };
                DanhSachLoaiKhachHang.Add(loaiKhachHang); 
            }
            sqlDataReader.Close();
            return DanhSachLoaiKhachHang; 
        }

        public List<LoaiKhachHang> HienThiDanhSachLKHTheoTen(string TenLoaiKhachHang)
        {
            OpenDataBase();
            List<LoaiKhachHang> DanhSachLoaiKhachHang = new List<LoaiKhachHang>();
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.CommandText = "HienThiDanhSachLKHTheoTen";
            sqlCommand.Connection = sqlConnection;
            sqlCommand.Parameters.Add("@TenLoaiKhachHang", SqlDbType.NVarChar).Value = TenLoaiKhachHang; 
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            while (sqlDataReader.Read())
            {
                LoaiKhachHang loaiKhachHang = new LoaiKhachHang()
                {
                    MaLoaiKhachHang = sqlDataReader[0].ToString(),
                    TenLoaiKhachHang = sqlDataReader[1].ToString(),
                    KhuyenMai = sqlDataReader[2].ToString(),
                };
                DanhSachLoaiKhachHang.Add(loaiKhachHang);
            }
            sqlDataReader.Close();
            return DanhSachLoaiKhachHang;
        }

        public List<LoaiKhachHang> HienThiDanhSachLKHTheoMa(string MaLoaiKhachHang)
        {
            OpenDataBase();
            List<LoaiKhachHang> DanhSachLoaiKhachHang = new List<LoaiKhachHang>();
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.CommandText = "HienThiDanhSachLKHTheoMa";
            sqlCommand.Connection = sqlConnection;
            sqlCommand.Parameters.Add("@MaLoaiKhachHang", SqlDbType.Char).Value = MaLoaiKhachHang;
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            while (sqlDataReader.Read())
            {
                LoaiKhachHang loaiKhachHang = new LoaiKhachHang()
                {
                    MaLoaiKhachHang = sqlDataReader[0].ToString(),
                    TenLoaiKhachHang = sqlDataReader[1].ToString(),
                    KhuyenMai = sqlDataReader[2].ToString(),
                };
                DanhSachLoaiKhachHang.Add(loaiKhachHang);
            }
            sqlDataReader.Close();
            return DanhSachLoaiKhachHang;
        }

        public bool XoaLoaiKhachHang(string MaLoaiKhachHang)
        {
            OpenDataBase();
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.CommandText = "XoaLoaiKhachHang";
            sqlCommand.Connection = sqlConnection;
            sqlCommand.Parameters.Add("@MaLoaiKhachHang", SqlDbType.Char).Value = MaLoaiKhachHang;
            int k = sqlCommand.ExecuteNonQuery();
            return k > 0;
        }

        public bool ThemLoaiKhachHang(LoaiKhachHang loaiKhachHang)
        {
            OpenDataBase();
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.CommandText = "ThemLoaiKhachHang";
            sqlCommand.Connection = sqlConnection;
            sqlCommand.Parameters.Add("@MaLoaiKhachHang", SqlDbType.Char).Value = loaiKhachHang.MaLoaiKhachHang;
            sqlCommand.Parameters.Add("@TenLoaiKhachHang", SqlDbType.Char).Value = loaiKhachHang.TenLoaiKhachHang;
            sqlCommand.Parameters.Add("@KhuyenMai", SqlDbType.Char).Value = loaiKhachHang.KhuyenMai;
            int k = sqlCommand.ExecuteNonQuery();
            return k > 0;
        }

        public bool SuaLoaiKhachHang(LoaiKhachHang loaiKhachHang)
        {
            OpenDataBase();
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.CommandText = "SuaLoaiKhachHang";
            sqlCommand.Connection = sqlConnection;
            sqlCommand.Parameters.Add("@MaLoaiKhachHang", SqlDbType.Char).Value = loaiKhachHang.MaLoaiKhachHang;
            sqlCommand.Parameters.Add("@TenLoaiKhachHang", SqlDbType.Char).Value = loaiKhachHang.TenLoaiKhachHang;
            sqlCommand.Parameters.Add("@KhuyenMai", SqlDbType.Char).Value = loaiKhachHang.KhuyenMai;
            int k = sqlCommand.ExecuteNonQuery();
            return k > 0;
        }

    }
}
