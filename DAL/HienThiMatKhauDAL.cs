using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class HienThiMatKhauDAL : AccessDataBase
    {
        public bool KiemTraDangNhap(string TaiKhoan , string MatKhau)
        {
            try
            {
                OpenDataBase();
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.CommandType = CommandType.Text;
                sqlCommand.CommandText = "select * from TaiKhoan";
                sqlCommand.Connection = sqlConnection;
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    if(TaiKhoan == sqlDataReader[0].ToString()
                        && MatKhau == sqlDataReader[1].ToString())
                    {
                        return true; 
                    }
                    else
                    {
                        return false; 
                    }
                }
                CloseDataBase();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}

