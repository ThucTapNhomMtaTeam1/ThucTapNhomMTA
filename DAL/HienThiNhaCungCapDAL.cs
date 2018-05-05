using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DTO; 
namespace DAL
{
    public class HienThiNhaCungCapDAL : AccessDataBase
    {
        public List<NhaCungCap> HienThiDanhSachNCC()
        {
            try
            {
                List<NhaCungCap> DanhSachNCC = new List<NhaCungCap>();
                OpenDataBase();
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandText = "HienThiNhaCungCap";
                sqlCommand.Connection = sqlConnection;
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    NhaCungCap nhaCungCap = new NhaCungCap()
                    {
                        MaNhaCungCap = sqlDataReader[0].ToString(),
                        TenNhaCungCap = sqlDataReader[1].ToString(),
                        DiaChi = sqlDataReader[2].ToString(),
                        SoDienThoai = sqlDataReader[3].ToString()
                    };
                    DanhSachNCC.Add(nhaCungCap);
                }
                CloseDataBase();
                return DanhSachNCC;
            }
            catch(Exception ex)
            {
                throw ex; 
            }
        }
        public List<NhaCungCap> HienThiDanhSachNCCTheoTen(string TenNhaCungCap)
        {
            try
            {
                List<NhaCungCap> DanhSachNCC = new List<NhaCungCap>();
                OpenDataBase();
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandText = "HienThiNhaCungCapTheoTen";
                sqlCommand.Connection = sqlConnection;
                sqlCommand.Parameters.Add("@TenNhaCungCap", SqlDbType.NVarChar).Value = TenNhaCungCap;  
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    NhaCungCap nhaCungCap = new NhaCungCap()
                    {
                        MaNhaCungCap = sqlDataReader[0].ToString(),
                        TenNhaCungCap = sqlDataReader[1].ToString(),
                        DiaChi = sqlDataReader[2].ToString(),
                        SoDienThoai = sqlDataReader[3].ToString()
                    };
                    DanhSachNCC.Add(nhaCungCap);
                }
                CloseDataBase();
                return DanhSachNCC;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public List<NhaCungCap> HienThiDanhSachNCCTheoMa(string MaNhaCungCap)
        {
            try
            {
                List<NhaCungCap> DanhSachNCC = new List<NhaCungCap>();
                OpenDataBase();
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandText = "HienThiNhaCungCapTheoMa";
                sqlCommand.Connection = sqlConnection;
                sqlCommand.Parameters.Add("@MaNhaCungCap", SqlDbType.Char).Value = MaNhaCungCap;
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    NhaCungCap nhaCungCap = new NhaCungCap()
                    {
                        MaNhaCungCap = sqlDataReader[0].ToString(),
                        TenNhaCungCap = sqlDataReader[1].ToString(),
                        DiaChi = sqlDataReader[2].ToString(),
                        SoDienThoai = sqlDataReader[3].ToString()
                    };
                    DanhSachNCC.Add(nhaCungCap);
                }
                CloseDataBase();
                return DanhSachNCC;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool ThemMoiNhaCungCap(NhaCungCap nhaCungCap)
        {
            OpenDataBase();
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.CommandText = "ThemNhaCungcap";
            sqlCommand.Connection = sqlConnection;
            sqlCommand.Parameters.Add("@MaNhaCungCap", SqlDbType.Char).Value = nhaCungCap.MaNhaCungCap;
            sqlCommand.Parameters.Add("@TenNhaCungCap", SqlDbType.NVarChar).Value = nhaCungCap.TenNhaCungCap;
            sqlCommand.Parameters.Add("@DiaChi", SqlDbType.NVarChar).Value = nhaCungCap.DiaChi;
            sqlCommand.Parameters.Add("@DienThoai", SqlDbType.Char).Value = nhaCungCap.SoDienThoai;
            int k = sqlCommand.ExecuteNonQuery();
            return k > 0; 
          
        }

        public bool ChinhSuaNhaCungCap(NhaCungCap nhaCungCap)
        {
            OpenDataBase();
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.CommandText = "ChinhSuaNhaCungcap";
            sqlCommand.Connection = sqlConnection;
            sqlCommand.Parameters.Add("@MaNhaCungCap", SqlDbType.Char).Value = nhaCungCap.MaNhaCungCap;
            sqlCommand.Parameters.Add("@TenNhaCungCap", SqlDbType.NVarChar).Value = nhaCungCap.TenNhaCungCap;
            sqlCommand.Parameters.Add("@DiaChi", SqlDbType.NVarChar).Value = nhaCungCap.DiaChi;
            sqlCommand.Parameters.Add("@DienThoai", SqlDbType.Char).Value = nhaCungCap.SoDienThoai;
            int k = sqlCommand.ExecuteNonQuery();
            return k > 0;

        }

        public bool XoaNhaCungCap(string MaNhaCungCap)
        {
            OpenDataBase();
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.CommandText = "XoaNhaCungcap";
            sqlCommand.Connection = sqlConnection;
            sqlCommand.Parameters.Add("@MaNhaCungCap", SqlDbType.Char).Value = MaNhaCungCap;
          
            int k = sqlCommand.ExecuteNonQuery();
            return k > 0;

        }

    }
}
