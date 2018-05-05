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
    public class HienThiKhoHangDAL: AccessDataBase
    {
        public List<KhoHang> LayToanBoKhoHang()
        {
            try
            {
                List<KhoHang> DanhSachKhoHang = new List<KhoHang>();
                OpenDataBase();
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandText = "HienThiDanhSachKhoHang";
                sqlCommand.Connection = sqlConnection;
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    KhoHang khoHang = new KhoHang()
                    {
                        MaKhoHang = sqlDataReader.GetString(0),
                        TenKhoHang = sqlDataReader.GetString(1),
                        DiaChi = sqlDataReader.GetString(2),
                        SoDienThoai = sqlDataReader.GetString(3)
                    };
                    DanhSachKhoHang.Add(khoHang); 
                }
                sqlDataReader.Close();
                return DanhSachKhoHang;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public List<KhoHang> HienThiKhoHangTheoMa(string MaKhoHang)
        {
            try
            {
                List<KhoHang> DanhSachKhoHang = new List<KhoHang>();
                OpenDataBase();
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandText = "TimKiemKhoHangTheoMa";
                sqlCommand.Connection = sqlConnection;
                sqlCommand.Parameters.Add("@MaKhoHang", SqlDbType.Char).Value = MaKhoHang; 
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    KhoHang khoHang = new KhoHang()
                    {
                        MaKhoHang = sqlDataReader.GetString(0),
                        TenKhoHang = sqlDataReader.GetString(1),
                        DiaChi = sqlDataReader.GetString(2),
                        SoDienThoai = sqlDataReader.GetString(3)
                    };
                    DanhSachKhoHang.Add(khoHang); 
                }
                sqlDataReader.Close();
                return DanhSachKhoHang;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public List<KhoHang> HienThiKhoHangTheoTen(string TenKhoHang)
        {
            try
            {
                List<KhoHang> DanhSachKhoHang = new List<KhoHang>();
                OpenDataBase();
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandText = "TimKiemKhoHangTheoTen";
                sqlCommand.Parameters.Add("@TenKhoHang", SqlDbType.NVarChar).Value = TenKhoHang;
                sqlCommand.Connection = sqlConnection;
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    KhoHang khoHang = new KhoHang()
                    {
                        MaKhoHang = sqlDataReader.GetString(0),
                        TenKhoHang = sqlDataReader.GetString(1),
                        DiaChi = sqlDataReader.GetString(2),
                        SoDienThoai = sqlDataReader.GetString(3)
                    };
                    DanhSachKhoHang.Add(khoHang);
                }
                sqlDataReader.Close();
                return DanhSachKhoHang;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public bool ThemMoiKhoHang(KhoHang khoHang)
        {
            OpenDataBase();
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.CommandText = "ThemMoiKhoHang";
            sqlCommand.Connection = sqlConnection;
            sqlCommand.Parameters.Add("@MaKhoHang", SqlDbType.Char).Value = khoHang.MaKhoHang;
            sqlCommand.Parameters.Add("@TenKhoHang", SqlDbType.NVarChar).Value = khoHang.TenKhoHang;
            sqlCommand.Parameters.Add("@DiaChi", SqlDbType.NVarChar).Value = khoHang.DiaChi;
            sqlCommand.Parameters.Add("@DienThoai", SqlDbType.Char).Value = khoHang.SoDienThoai;
            int k = sqlCommand.ExecuteNonQuery();
            return k > 0; 
        }

        public bool XoaKhoHang(KhoHang khoHang)
        {
            OpenDataBase();
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.CommandText = "XoaKhoHang ";
            sqlCommand.Connection = sqlConnection;
            sqlCommand.Parameters.Add("@MaKhoHang", SqlDbType.Char).Value = khoHang.MaKhoHang;
            int k = sqlCommand.ExecuteNonQuery();
            return k > 0;
        }

        public bool ChinhSuaKhoHang(KhoHang khoHang)
        {
            OpenDataBase();
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.CommandText = "SuaThongTinKhoHang";
            sqlCommand.Connection = sqlConnection;
            sqlCommand.Parameters.Add("@MaKhoHang", SqlDbType.Char).Value = khoHang.MaKhoHang;
            sqlCommand.Parameters.Add("@TenKhoHang", SqlDbType.NVarChar).Value = khoHang.TenKhoHang;
            sqlCommand.Parameters.Add("@DiaChi", SqlDbType.NVarChar).Value = khoHang.DiaChi;
            sqlCommand.Parameters.Add("@DienThoai", SqlDbType.Char).Value = khoHang.SoDienThoai;
            int k = sqlCommand.ExecuteNonQuery();
            return k > 0;
        }
    }
}
