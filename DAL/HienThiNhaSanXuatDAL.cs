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
    public class HienThiNhaSanXuatDAL :AccessDataBase
    {
        public List<NhaSanXuat> HienThiDanhSachNSX()
        {
            try
            {
                List<NhaSanXuat> DanhSachNSX = new List<NhaSanXuat>();
                OpenDataBase();
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandText = "HienThiNhaSanXuat";
                sqlCommand.Connection = sqlConnection;
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    NhaSanXuat nhaSanXuat = new NhaSanXuat()
                    {
                        MaNhaSanXuat = sqlDataReader[0].ToString(),
                        TenNhaSanXuat = sqlDataReader[1].ToString(),
                        QuocGia = sqlDataReader[2].ToString()
                    };
                    DanhSachNSX.Add(nhaSanXuat);
                }
                CloseDataBase();
                return DanhSachNSX;
            }
            catch (Exception ex)
            {
                throw ex; 
            }
        }


        public List<NhaSanXuat> HienThiDanhSachNSXTheoTen(string TenNhaSanXuat)
        {
            try
            {
                List<NhaSanXuat> DanhSachNSX = new List<NhaSanXuat>();
                OpenDataBase();
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandText = "HienThiDanhSachNSXTheoTen";
                sqlCommand.Connection = sqlConnection;
                sqlCommand.Parameters.Add("@TenNhaSanXuat", SqlDbType.NVarChar).Value = TenNhaSanXuat; 
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    NhaSanXuat nhaSanXuat = new NhaSanXuat()
                    {
                        MaNhaSanXuat = sqlDataReader[0].ToString(),
                        TenNhaSanXuat = sqlDataReader[1].ToString(),
                        QuocGia = sqlDataReader[2].ToString()
                    };
                    DanhSachNSX.Add(nhaSanXuat);
                }
                CloseDataBase();
                return DanhSachNSX;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<NhaSanXuat> HienThiDanhSachNSXTheoMa(string MaNhaSanXuat)
        {
            try
            {
                List<NhaSanXuat> DanhSachNSX = new List<NhaSanXuat>();
                OpenDataBase();
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandText = "HienThiDanhSachNSXTheoMa";
                sqlCommand.Connection = sqlConnection;
                sqlCommand.Parameters.Add("@MaNhaSanXuat", SqlDbType.Char).Value = MaNhaSanXuat;
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    NhaSanXuat nhaSanXuat = new NhaSanXuat()
                    {
                        MaNhaSanXuat = sqlDataReader[0].ToString(),
                        TenNhaSanXuat = sqlDataReader[1].ToString(),
                        QuocGia = sqlDataReader[2].ToString()
                    };
                    DanhSachNSX.Add(nhaSanXuat);
                }
                CloseDataBase();
                return DanhSachNSX;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<NhaSanXuat> HienThiDanhSachNSXTheoQuocGia(string QuocGia)
        {
            try
            {
                List<NhaSanXuat> DanhSachNSX = new List<NhaSanXuat>();
                OpenDataBase();
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandText = "HienThiDanhSachNSXTheoQuocGia";
                sqlCommand.Connection = sqlConnection;
                sqlCommand.Parameters.Add("@QuocGia", SqlDbType.NVarChar).Value = QuocGia;
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    NhaSanXuat nhaSanXuat = new NhaSanXuat()
                    {
                        MaNhaSanXuat = sqlDataReader[0].ToString(),
                        TenNhaSanXuat = sqlDataReader[1].ToString(),
                        QuocGia = sqlDataReader[2].ToString()
                    };
                    DanhSachNSX.Add(nhaSanXuat);
                }
                CloseDataBase();
                return DanhSachNSX;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool ThemMoiNhaSanXuat(NhaSanXuat nhaSanXuat)
        {
            try
            {
                OpenDataBase();
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandText = "ThemNhaSanXuat";
                sqlCommand.Connection = sqlConnection;
                sqlCommand.Parameters.Add("@MaNhaSanXuat", SqlDbType.Char).Value = nhaSanXuat.MaNhaSanXuat;
                sqlCommand.Parameters.Add("@TenNhaSanXuat", SqlDbType.NVarChar).Value = nhaSanXuat.TenNhaSanXuat;
                sqlCommand.Parameters.Add("@QuocGia", SqlDbType.NVarChar).Value = nhaSanXuat.QuocGia;
                int k = sqlCommand.ExecuteNonQuery();
                return k > 0; 
            }
            catch(Exception ex)
            {
                throw ex; 
            }
        }

        public bool SuaThongTinNXX(NhaSanXuat nhaSanXuat)
        {
            try
            {
                OpenDataBase();
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandText = "XoaThongTinNSX";
                sqlCommand.Connection = sqlConnection;
                sqlCommand.Parameters.Add("@MaNhaSanXuat", SqlDbType.Char).Value = nhaSanXuat.MaNhaSanXuat;
                sqlCommand.Parameters.Add("@TenNhaSanXuat", SqlDbType.NVarChar).Value = nhaSanXuat.TenNhaSanXuat;
                sqlCommand.Parameters.Add("@QuocGia", SqlDbType.NVarChar).Value = nhaSanXuat.QuocGia;
                int k = sqlCommand.ExecuteNonQuery();
                return k > 0;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool XoaThongTinNXX(string MaNhaSanXuat)
        {
            try
            {
                OpenDataBase();
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandText = "XoaThongTinNSX";
                sqlCommand.Connection = sqlConnection;
                sqlCommand.Parameters.Add("@MaNhaSanXuat", SqlDbType.Char).Value = MaNhaSanXuat;
                int k = sqlCommand.ExecuteNonQuery();
                return k > 0;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
