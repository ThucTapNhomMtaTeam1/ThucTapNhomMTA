using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class LayNgayThangDAL : AccessDataBase
    {
        public List<NgayThang> LayDanhSachCacNamPN()
        {
            try
            {
                List<NgayThang> DanhSach = new List<NgayThang>();
                OpenDataBase();
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandText = "LayDanhSachNamPN";
                sqlCommand.Connection = sqlConnection;
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    DateTime dateTime = new DateTime(int.Parse(sqlDataReader[0].ToString()), 1, 1);
                    DanhSach.Add(new NgayThang { NgayThangNam = dateTime });
                }
                sqlDataReader.Close();
                return DanhSach;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<NgayThang> LayDanhSachCacThangTheoNamPN(DateTime DateTime)
        {
            try
            {
                List<NgayThang> DanhSach = new List<NgayThang>();
                OpenDataBase();
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandText = "ThangTheoNamPN";
                sqlCommand.Parameters.Add("@Nam", SqlDbType.DateTime).Value = DateTime; 
                sqlCommand.Connection = sqlConnection;
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    DateTime dateTime = new DateTime(DateTime.Year, int.Parse(sqlDataReader[0].ToString()), 1);
                    DanhSach.Add(new NgayThang { NgayThangNam = dateTime });
                }
                sqlDataReader.Close();
                return DanhSach;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<NgayThang> LayDanhSachCacNgayTheoThangNamPN(DateTime DateTime)
        {
            try
            {
                List<NgayThang> DanhSach = new List<NgayThang>();
                OpenDataBase();
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandText = "LayNgayTheoThangNam";
                sqlCommand.Parameters.Add("@Nam", SqlDbType.DateTime).Value = DateTime;
                sqlCommand.Connection = sqlConnection;
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    DateTime dateTime = new DateTime(DateTime.Year, DateTime.Month, int.Parse(sqlDataReader[0].ToString()));
                    DanhSach.Add(new NgayThang { NgayThangNam = dateTime });
                }
                sqlDataReader.Close();
                return DanhSach;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<NgayThang> LayDanhSachCacNamPhieuXuat()
        {
            try
            {
                List<NgayThang> DanhSach = new List<NgayThang>();
                OpenDataBase();
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandText = "LayDanhSachNamPhieuXuat";
                sqlCommand.Connection = sqlConnection;
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    DateTime dateTime = new DateTime(int.Parse(sqlDataReader[0].ToString()), 1, 1);
                    DanhSach.Add(new NgayThang { NgayThangNam = dateTime });
                }
                sqlDataReader.Close();
                return DanhSach;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<NgayThang> LayDanhSachCacThangTheoNamPhieuXuat(DateTime DateTime)
        {
            try
            {
                List<NgayThang> DanhSach = new List<NgayThang>();
                OpenDataBase();
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandText = "LayThangCuaPhieuXuatTheoNam";
                sqlCommand.Parameters.Add("@Nam", SqlDbType.DateTime).Value = DateTime;
                sqlCommand.Connection = sqlConnection;
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    DateTime dateTime = new DateTime(DateTime.Year, int.Parse(sqlDataReader[0].ToString()), 1);
                    DanhSach.Add(new NgayThang { NgayThangNam = dateTime });
                }
                sqlDataReader.Close();
                return DanhSach;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<NgayThang> LayDanhSachCacNgayTheoThangNamPhieuXuat(DateTime DateTime)
        {
            try
            {
                List<NgayThang> DanhSach = new List<NgayThang>();
                OpenDataBase();
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandText = "LayNgayTheoThangNamCuaPhieuXuat";
                sqlCommand.Parameters.Add("@Nam", SqlDbType.DateTime).Value = DateTime;
                sqlCommand.Connection = sqlConnection;
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    DateTime dateTime = new DateTime(DateTime.Year, DateTime.Month, int.Parse(sqlDataReader[0].ToString()));
                    DanhSach.Add(new NgayThang { NgayThangNam = dateTime });
                }
                sqlDataReader.Close();
                return DanhSach;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }

   
}
/*
 
     public List<NhanVien> LayToanBoNhanVien()
        {
            try
            {
                List<NhanVien> DanhSachNhanVien = new List<NhanVien>();
                OpenDataBase();//kết nối tới có sở dữ liệu 
                SqlCommand sqlCommand = new SqlCommand();

                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandText = "HienThiDanhSachNhanVien";
                sqlCommand.Connection = sqlConnection;
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    NhanVien nhanVien = new NhanVien()
                    {
                        MaNhanVien = sqlDataReader.GetString(0),
                        TenNhanVien = sqlDataReader.GetString(1),
                        ChungMinhThu = sqlDataReader.GetString(2),
                        NgaySinh = sqlDataReader.GetDateTime(3),
                        GioiTinh = sqlDataReader.GetString(4),
                        DiaChi = sqlDataReader.GetString(5),
                        SoDienThoai = sqlDataReader.GetString(6),
                        Email = sqlDataReader.GetString(7),
                        ChucVu = sqlDataReader.GetString(8),
                        TienLuong = sqlDataReader.GetSqlMoney(9)+"",
                        KhoHang = sqlDataReader.GetString(11),
                        NgayVaoLam = sqlDataReader.GetDateTime(10)
                        
                    };
                    DanhSachNhanVien.Add(nhanVien);

                }
                sqlDataReader.Close();
                return DanhSachNhanVien;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
     
     */
