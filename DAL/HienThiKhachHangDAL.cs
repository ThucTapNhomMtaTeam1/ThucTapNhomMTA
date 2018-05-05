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
    public class HienThiKhachHangDAL:AccessDataBase
    {
        public List<KhachHang> HienThiDanhSachKhachHang()
        {
            try
            {
                List<KhachHang> DanhSachKhachHang = new List<KhachHang>();
                OpenDataBase();
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandText = "HienThiDanhSachKhachHang";
                sqlCommand.Connection = sqlConnection;
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    KhachHang khachHang = new KhachHang()
                    {
                        MaKhachHang = sqlDataReader[0].ToString(),
                        TenKhachHang = sqlDataReader[1].ToString(),
                        NgaySinh = DateTime.Parse(sqlDataReader[2].ToString()),
                        GioiTinh = sqlDataReader[3].ToString(),
                        DiaChi = sqlDataReader[4].ToString(),
                        DienThoai = sqlDataReader[5].ToString(),
                        LoaiKhachHang = sqlDataReader[6].ToString(),
                        ChungMinhThu = sqlDataReader[7].ToString(),
                    };
                    DanhSachKhachHang.Add(khachHang);
                }
                sqlDataReader.Close();
                CloseDataBase();
                return DanhSachKhachHang;
            }
            catch(Exception ex)
            {
                throw ex; 
            }
        }

        public List<KhachHang> HienThiDanhSachKhachHangTheoLoai(string MaLoaiKhachHang)
        {
            try
            {
                List<KhachHang> DanhSachKhachHang = new List<KhachHang>();
                OpenDataBase();
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandText = "HienThiDanhSachKhachHangTheoLoai";
                sqlCommand.Connection = sqlConnection;
                sqlCommand.Parameters.Add("@MaLoaiKhachHang", SqlDbType.Char).Value = MaLoaiKhachHang;
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    KhachHang khachHang = new KhachHang()
                    {
                        MaKhachHang = sqlDataReader[0].ToString(),
                        TenKhachHang = sqlDataReader[1].ToString(),
                        NgaySinh = DateTime.Parse(sqlDataReader[2].ToString()),
                        GioiTinh = sqlDataReader[3].ToString(),
                        DiaChi = sqlDataReader[4].ToString(),
                        DienThoai = sqlDataReader[5].ToString(),
                        LoaiKhachHang = sqlDataReader[6].ToString(),
                        ChungMinhThu = sqlDataReader[7].ToString(),
                    };
                    DanhSachKhachHang.Add(khachHang);
                }
                sqlDataReader.Close();
                CloseDataBase();
                return DanhSachKhachHang;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            
        }

        public List<KhachHang> HienThiDanhSachKhachHangTheoMa(string MaKhachHang)
        {
            try
            {
                List<KhachHang> DanhSachKhachHang = new List<KhachHang>();
                OpenDataBase();
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandText = "HienThiDanhSachKhachHangTheoMa";
                sqlCommand.Connection = sqlConnection;
                sqlCommand.Parameters.Add("@MaKhachHang", SqlDbType.Char).Value = MaKhachHang;
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    KhachHang khachHang = new KhachHang()
                    {
                        MaKhachHang = sqlDataReader[0].ToString(),
                        TenKhachHang = sqlDataReader[1].ToString(),
                        NgaySinh = DateTime.Parse(sqlDataReader[2].ToString()),
                        GioiTinh = sqlDataReader[3].ToString(),
                        DiaChi = sqlDataReader[4].ToString(),
                        DienThoai = sqlDataReader[5].ToString(),
                        LoaiKhachHang = sqlDataReader[6].ToString(),
                        ChungMinhThu = sqlDataReader[7].ToString(),
                    };
                    DanhSachKhachHang.Add(khachHang);
                }
                sqlDataReader.Close();
                CloseDataBase();
                return DanhSachKhachHang;
            }
            catch (Exception ex)
            {
                throw ex;
            }       
            
        }

        public List<KhachHang> HienThiDanhSachKhachHangTheoTen(string TenKhachHang)
        {
            try
            {
                List<KhachHang> DanhSachKhachHang = new List<KhachHang>();
                OpenDataBase();
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandText = "HienThiDanhSachKhachHangTheoTen";
                sqlCommand.Connection = sqlConnection;
                sqlCommand.Parameters.Add("@TenKhachHang", SqlDbType.NVarChar).Value = TenKhachHang;
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    KhachHang khachHang = new KhachHang()
                    {
                        MaKhachHang = sqlDataReader[0].ToString(),
                        TenKhachHang = sqlDataReader[1].ToString(),
                        NgaySinh = DateTime.Parse(sqlDataReader[2].ToString()),
                        GioiTinh = sqlDataReader[3].ToString(),
                        DiaChi = sqlDataReader[4].ToString(),
                        DienThoai = sqlDataReader[5].ToString(),
                        LoaiKhachHang = sqlDataReader[6].ToString(),
                        ChungMinhThu = sqlDataReader[7].ToString(),
                    };
                    DanhSachKhachHang.Add(khachHang);
                }
                sqlDataReader.Close();
                CloseDataBase();
                return DanhSachKhachHang;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            
        }

        public List<KhachHang> HienThiDanhSachKhachHangTheoCMT(string ChungMinhThu)
        {
            try
            {
                List<KhachHang> DanhSachKhachHang = new List<KhachHang>();
                OpenDataBase();
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandText = "HienThiDanhSachKhachHangTheoCMT";
                sqlCommand.Connection = sqlConnection;
                sqlCommand.Parameters.Add("@ChungMinhThu", SqlDbType.Char).Value = ChungMinhThu;
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    KhachHang khachHang = new KhachHang()
                    {
                        MaKhachHang = sqlDataReader[0].ToString(),
                        TenKhachHang = sqlDataReader[1].ToString(),
                        NgaySinh = DateTime.Parse(sqlDataReader[2].ToString()),
                        GioiTinh = sqlDataReader[3].ToString(),
                        DiaChi = sqlDataReader[4].ToString(),
                        DienThoai = sqlDataReader[5].ToString(),
                        LoaiKhachHang = sqlDataReader[6].ToString(),
                        ChungMinhThu = sqlDataReader[7].ToString(),
                    };
                    DanhSachKhachHang.Add(khachHang);
                }
                sqlDataReader.Close();
                CloseDataBase();
                return DanhSachKhachHang;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            
        }

        public bool ThemMoiKhachHang (KhachHang khachHang)
        {

            try
            {
                OpenDataBase();
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandText = "ThemMoiKhachHang";
                sqlCommand.Connection = sqlConnection;
                sqlCommand.Parameters.Add("@MaKhachHang", SqlDbType.Char).Value = khachHang.MaKhachHang;
                sqlCommand.Parameters.Add("@TenKhachHang", SqlDbType.NVarChar).Value = khachHang.TenKhachHang;
                sqlCommand.Parameters.Add("@ChungMinhThu", SqlDbType.Char).Value = khachHang.ChungMinhThu;
                sqlCommand.Parameters.Add("@NgaySinh", SqlDbType.DateTime).Value = khachHang.NgaySinh;
                sqlCommand.Parameters.Add("@GioiTinh", SqlDbType.NVarChar).Value = khachHang.GioiTinh;
                sqlCommand.Parameters.Add("@DiaChi", SqlDbType.NVarChar).Value = khachHang.DiaChi;
                sqlCommand.Parameters.Add("@SoDienThoai", SqlDbType.Char).Value = khachHang.DienThoai;
                sqlCommand.Parameters.Add("@MaLoaiKhachHang", SqlDbType.Char).Value = khachHang.LoaiKhachHang;
                int k = sqlCommand.ExecuteNonQuery();
                return k > 0;
            }
            catch (Exception ex)
            {
                throw ex;
            }
 
            
        }

        public bool SuaThongTinKhachHang(KhachHang khachHang)
        {

            try
            {
                OpenDataBase();
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandText = "SuaThongTinKhachHang";
                sqlCommand.Connection = sqlConnection;
                sqlCommand.Parameters.Add("@MaKhachHang", SqlDbType.Char).Value = khachHang.MaKhachHang;
                sqlCommand.Parameters.Add("@TenKhachHang", SqlDbType.NVarChar).Value = khachHang.TenKhachHang;
                sqlCommand.Parameters.Add("@ChungMinhThu", SqlDbType.Char).Value = khachHang.ChungMinhThu;
                sqlCommand.Parameters.Add("@NgaySinh", SqlDbType.DateTime).Value = khachHang.NgaySinh;
                sqlCommand.Parameters.Add("@GioiTinh", SqlDbType.NVarChar).Value = khachHang.GioiTinh;
                sqlCommand.Parameters.Add("@DiaChi", SqlDbType.NVarChar).Value = khachHang.DiaChi;
                sqlCommand.Parameters.Add("@SoDienThoai", SqlDbType.Char).Value = khachHang.DienThoai;
                sqlCommand.Parameters.Add("@MaLoaiKhachHang", SqlDbType.Char).Value = khachHang.LoaiKhachHang;
                int k = sqlCommand.ExecuteNonQuery();
                return k > 0;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            
            
        }

        public bool XoaThongTinKhachHang(string MaKhachHang)
        {

            try
            {
                OpenDataBase();
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandText = "XoaThongTinKhachHang";
                sqlCommand.Connection = sqlConnection;
                sqlCommand.Parameters.Add("@MaKhachHang", SqlDbType.Char).Value = MaKhachHang;
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
