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
    public class HienThiNhanVienDAL: AccessDataBase
    {
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
        public List<NhanVien> HienThiNhanVienTheoKho(string MaKhoHang)
        {
            try
            {
                List<NhanVien> DanhSachNhanVien = new List<NhanVien>();
                OpenDataBase();
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandText = "HienThiDanhSachNhanVienTheoKho";
                sqlCommand.Connection = sqlConnection;
                sqlCommand.Parameters.Add("@MaKhoHang", SqlDbType.Char).Value = MaKhoHang;
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
                        TienLuong = sqlDataReader.GetSqlMoney(9) + "",
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
        public bool ThemMoiNhanVien(NhanVien nhanVien)
        {
            try
            {
                OpenDataBase();
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandText = "ThemMoiNhanVien";
                sqlCommand.Connection = sqlConnection;
                sqlCommand.Parameters.Add("@MaNhanVien", SqlDbType.Char).Value = nhanVien.MaNhanVien;
                sqlCommand.Parameters.Add("@TenNhanVIen", SqlDbType.NVarChar).Value = nhanVien.TenNhanVien;
                sqlCommand.Parameters.Add("@ChungMinhThu", SqlDbType.Char).Value = nhanVien.ChungMinhThu;
                sqlCommand.Parameters.Add("@NgaySinh", SqlDbType.DateTime).Value = nhanVien.NgaySinh;
                sqlCommand.Parameters.Add("@GioiTinh", SqlDbType.NVarChar).Value = nhanVien.GioiTinh;
                sqlCommand.Parameters.Add("@DiaChi", SqlDbType.NVarChar).Value = nhanVien.DiaChi;
                sqlCommand.Parameters.Add("@Email", SqlDbType.Char).Value = nhanVien.Email;
                sqlCommand.Parameters.Add("@SoDienThoai", SqlDbType.Char).Value = nhanVien.SoDienThoai;
                sqlCommand.Parameters.Add("@ChucVu", SqlDbType.NVarChar).Value = nhanVien.ChucVu;
                sqlCommand.Parameters.Add("@TienLuong", SqlDbType.Money).Value = nhanVien.TienLuong;
                sqlCommand.Parameters.Add("@NgayVaoLam", SqlDbType.DateTime).Value = nhanVien.NgayVaoLam;
                sqlCommand.Parameters.Add("@KhoHang", SqlDbType.Char).Value = nhanVien.KhoHang;
                int k = sqlCommand.ExecuteNonQuery();
                return k > 0;
            }
            catch (Exception ex)
            {
                throw ex; 
            }
        }
        public bool SuaThongTinNhanVien(NhanVien nhanVien)
        {
            try
            {
                OpenDataBase();
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandText = "SuaThongTinNhanVien";
                sqlCommand.Connection = sqlConnection;
                sqlCommand.Parameters.Add("@MaNhanVien", SqlDbType.Char).Value = nhanVien.MaNhanVien;
                sqlCommand.Parameters.Add("@TenNhanVIen", SqlDbType.NVarChar).Value = nhanVien.TenNhanVien;
                sqlCommand.Parameters.Add("@ChungMinhThu", SqlDbType.Char).Value = nhanVien.ChungMinhThu;
                sqlCommand.Parameters.Add("@NgaySinh", SqlDbType.DateTime).Value = nhanVien.NgaySinh;
                sqlCommand.Parameters.Add("@GioiTinh", SqlDbType.NVarChar).Value = nhanVien.GioiTinh;
                sqlCommand.Parameters.Add("@DiaChi", SqlDbType.NVarChar).Value = nhanVien.DiaChi;
                sqlCommand.Parameters.Add("@Email", SqlDbType.Char).Value = nhanVien.Email;
                sqlCommand.Parameters.Add("@SoDienThoai", SqlDbType.Char).Value = nhanVien.SoDienThoai;
                sqlCommand.Parameters.Add("@ChucVu", SqlDbType.NVarChar).Value = nhanVien.ChucVu;
                sqlCommand.Parameters.Add("@TienLuong", SqlDbType.Money).Value = nhanVien.TienLuong;
                sqlCommand.Parameters.Add("@NgayVaoLam", SqlDbType.DateTime).Value = nhanVien.NgayVaoLam;
                sqlCommand.Parameters.Add("@KhoHang", SqlDbType.Char).Value = nhanVien.KhoHang;
                int k = sqlCommand.ExecuteNonQuery();
                return k > 0;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool XoaThongTinNhanVien(string MaNhanVien)
        {
            try
            {
                OpenDataBase();
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandText = "XoaThongTinNhanVien";
                sqlCommand.Connection = sqlConnection;
                sqlCommand.Parameters.Add("@MaNhanVien", SqlDbType.Char).Value = MaNhanVien;
                int k = sqlCommand.ExecuteNonQuery();
                return k > 0;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<NhanVien> TimKiemNhanVienTheoMa(string MaNhanVien)
        {
            try
            {
                List<NhanVien> DanhSachNhanVien = new List<NhanVien>();
                OpenDataBase();
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandText = "TimKiemNhanVienTheoMa";
                sqlCommand.Connection = sqlConnection;
                sqlCommand.Parameters.Add("@MaNhanVien", SqlDbType.Char).Value = MaNhanVien;
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
                        TienLuong = sqlDataReader.GetSqlMoney(9) + "",
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
        public List<NhanVien> TimKiemNhanVienTheoTen(string HoVaTen)
        {
            try
            {
                List<NhanVien> DanhSachNhanVien = new List<NhanVien>();
                OpenDataBase();
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandText = "TimKiemNhanVienTheoTen";
                sqlCommand.Connection = sqlConnection;
                sqlCommand.Parameters.Add("@TenNhanVien", SqlDbType.NVarChar).Value = HoVaTen;
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
                        TienLuong = sqlDataReader.GetSqlMoney(9) + "",
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
        public List<NhanVien> TimKiemSinhvienTheoCMT(string ChungMinhThu)
        {
            try
            {
                List<NhanVien> DanhSachNhanVien = new List<NhanVien>();
                OpenDataBase();
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandText = "TimKiemSinhVienTheoCMT";
                sqlCommand.Connection = sqlConnection;
                sqlCommand.Parameters.Add("@ChungMinhThu", SqlDbType.Char).Value = ChungMinhThu;
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
                        TienLuong = sqlDataReader.GetSqlMoney(9) + "",
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
    }
}

