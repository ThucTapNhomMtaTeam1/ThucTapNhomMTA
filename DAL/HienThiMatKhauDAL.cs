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
        public int KiemTraDangNhap(string TaiKhoan , string MatKhau)
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
                    if(TaiKhoan == sqlDataReader[0].ToString())
                    {
                        if(MatKhau == sqlDataReader[1].ToString())
                        {
                            return  1; 
                        }
                        else if(MatKhau != sqlDataReader[1].ToString())
                        {
                            return 0;
                        }
                    } 
                }
                CloseDataBase();
                return -1;
            }
            catch 
            {
                return -2; 
            }
        }

        public List<TaiKhoan> HienThiDanhSachTaiKhoan()
        {
            try
            {
                List<TaiKhoan> DanhSach = new List<TaiKhoan>();
                OpenDataBase();
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandText = "LayThongTinTaiKhoan";
                sqlCommand.Connection = sqlConnection;
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    TaiKhoan taiKhoan = new TaiKhoan()
                    {
                        TenTaiKhoan = sqlDataReader[0] +"",
                        MatKhau = sqlDataReader[1].ToString(),
                        TenDayDu = sqlDataReader[2].ToString(),
                        GioiTinh = sqlDataReader[3].ToString(),
                        DienThoai = sqlDataReader[4].ToString(),
                        HienThi = bool.Parse(sqlDataReader[5].ToString())
                    };
                    DanhSach.Add(taiKhoan); 
                }
                CloseDataBase();
                return DanhSach;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public List<TaiKhoan> HienThiTaiKhoanTheoTen(string TenTaiKhoan)
        {
            try
            {
                List<TaiKhoan> DanhSach = new List<TaiKhoan>();
                OpenDataBase();
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandText = "LayThongTinTaiKhoanTheoTen";
                sqlCommand.Parameters.Add("@TenTaiKhoan", SqlDbType.VarChar).Value = TenTaiKhoan; 
                sqlCommand.Connection = sqlConnection;
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    TaiKhoan taiKhoan = new TaiKhoan()
                    {
                        TenTaiKhoan = sqlDataReader[0] + "",
                        MatKhau = sqlDataReader[1].ToString(),
                        TenDayDu = sqlDataReader[2].ToString(),
                        GioiTinh = sqlDataReader[3].ToString(),
                        DienThoai = sqlDataReader[4].ToString(),
                        HienThi = bool.Parse(sqlDataReader[5].ToString())
                    };
                    DanhSach.Add(taiKhoan);
                }
                CloseDataBase();
                return DanhSach;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<TaiKhoan> HienThiTaiKhoanTheoTenDayDu(string TenTaiKhoan)
        {
            try
            {
                List<TaiKhoan> DanhSach = new List<TaiKhoan>();
                OpenDataBase();
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandText = "LayThongTinTaiKhoanTheoTenDayDu";
                sqlCommand.Parameters.Add("@TenTaiKhoan", SqlDbType.NVarChar).Value = TenTaiKhoan;
                sqlCommand.Connection = sqlConnection;
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    TaiKhoan taiKhoan = new TaiKhoan()
                    {
                        TenTaiKhoan = sqlDataReader[0] + "",
                        MatKhau = sqlDataReader[1].ToString(),
                        TenDayDu = sqlDataReader[2].ToString(),
                        GioiTinh = sqlDataReader[3].ToString(),
                        DienThoai = sqlDataReader[4].ToString(),
                        HienThi = bool.Parse(sqlDataReader[5].ToString())
                    };
                    DanhSach.Add(taiKhoan);
                }
                CloseDataBase();
                return DanhSach;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool ThemThongTinNguoiDung(TaiKhoan taiKhoan)
        {
            try { 
                OpenDataBase();
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandText = "ThemMoiNguoiDung";
                sqlCommand.Connection = sqlConnection;
                sqlCommand.Parameters.Add("@TaiKhoan", SqlDbType.VarChar).Value = taiKhoan.TenTaiKhoan;
                sqlCommand.Parameters.Add("@MatKhau", SqlDbType.VarChar).Value = taiKhoan.MatKhau;
                sqlCommand.Parameters.Add("@TenDayDu", SqlDbType.NVarChar).Value = taiKhoan.TenDayDu;
                sqlCommand.Parameters.Add("@GioiTinh", SqlDbType.NVarChar).Value = taiKhoan.GioiTinh;
                sqlCommand.Parameters.Add("@SoDienThoai", SqlDbType.VarChar).Value = taiKhoan.DienThoai;
                sqlCommand.Parameters.Add("@HienThi", SqlDbType.Bit).Value = taiKhoan.HienThi; 
                int k = sqlCommand.ExecuteNonQuery();
                CloseDataBase();
                return k > 0;
               

            }
            catch(Exception ex)
            {
                throw ex; 
            }
        }

        public bool XoaThongTinNguoiDung(string TenTaiKhoan)
        {
            try
            {
                OpenDataBase();
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandText = "XoaNguoiDung";
                sqlCommand.Connection = sqlConnection;
                sqlCommand.Parameters.Add("@TaiKhoan", SqlDbType.VarChar).Value = TenTaiKhoan;
                int k = sqlCommand.ExecuteNonQuery();
                CloseDataBase();
                return k > 0;


            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public bool ChinhSuaThongTinNguoiDung(TaiKhoan taiKhoan)
        {
            try
            {
                OpenDataBase();
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandText = "SuaThongTinNguoiDung";
                sqlCommand.Connection = sqlConnection;
                sqlCommand.Parameters.Add("@TaiKhoan", SqlDbType.VarChar).Value = taiKhoan.TenTaiKhoan;
                sqlCommand.Parameters.Add("@MatKhau", SqlDbType.VarChar).Value = taiKhoan.MatKhau;
                sqlCommand.Parameters.Add("@TenDayDu", SqlDbType.NVarChar).Value = taiKhoan.TenDayDu;
                sqlCommand.Parameters.Add("@GioiTinh", SqlDbType.NVarChar).Value = taiKhoan.GioiTinh;
                sqlCommand.Parameters.Add("@SoDienThoai", SqlDbType.VarChar).Value = taiKhoan.DienThoai;
                sqlCommand.Parameters.Add("@HienThi", SqlDbType.Bit).Value = taiKhoan.HienThi;
                int k = sqlCommand.ExecuteNonQuery();
                CloseDataBase();
                return k > 0;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
