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
    public class HienThiPhieuXuatDAL :AccessDataBase
    {
        public List<PhieuXuat> LayPhieuXuatTheoNgayThangNam(DateTime DateTime)
        {
            try
            {
                List<PhieuXuat> DanhSach = new List<PhieuXuat>();
                OpenDataBase();
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandText = "LayPhieuXuatTheoNgayThangNam";
                sqlCommand.Parameters.Add("@Nam", SqlDbType.DateTime).Value = DateTime;
                sqlCommand.Connection = sqlConnection;
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    DanhSach.Add(new PhieuXuat
                    {
                        MaPhieuXuat = sqlDataReader[0].ToString(),
                        MaNhanVien = sqlDataReader[1].ToString(),
                        TenNhanVien = sqlDataReader[2].ToString(),
                        MaKhachHang = sqlDataReader[3].ToString(),
                        TenKhachHang = sqlDataReader[4].ToString(),
                        NgayXuat = DateTime.Parse(sqlDataReader[5].ToString()),
                        MaKhoHang = sqlDataReader[6].ToString(),
                        TenKhoHang = sqlDataReader[7].ToString()
                    });
                }
                sqlDataReader.Close();
                return DanhSach;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<PhieuXuat> LayToanBoPhieuXuat()
        {
            try
            {
                List<PhieuXuat> DanhSach = new List<PhieuXuat>();
                OpenDataBase();
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandText = "HienThiToanBoPhieuXuat";
                sqlCommand.Connection = sqlConnection;
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    DanhSach.Add(new PhieuXuat
                    {
                        MaPhieuXuat = sqlDataReader[0].ToString(),
                        MaNhanVien = sqlDataReader[1].ToString(),
                        TenNhanVien = sqlDataReader[2].ToString(),
                        MaKhachHang = sqlDataReader[3].ToString(),
                        TenKhachHang = sqlDataReader[4].ToString(),
                        NgayXuat = DateTime.Parse(sqlDataReader[5].ToString()),
                        MaKhoHang = sqlDataReader[6].ToString(),
                        TenKhoHang = sqlDataReader[7].ToString()
                    });
                }
                sqlDataReader.Close();
                return DanhSach;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool XoaThongTinPhieuXuat(string MaPhieuXuat)
        {
            try
            {
                List<PhieuXuat> DanhSach = new List<PhieuXuat>();
                OpenDataBase();
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandText = "XoaPhieuXuatTheoMa";
                sqlCommand.Parameters.Add("@MaPhieuXuat", SqlDbType.Char).Value = MaPhieuXuat;
                sqlCommand.Connection = sqlConnection;
                int k =  sqlCommand.ExecuteNonQuery();
                return true;
            }
            catch  
            {
                return false;
            }
        }

        public bool ThemMoiThongTinPhieuXuat(PhieuXuat phieuXuat)
        {
            try
            {
                List<PhieuXuat> DanhSach = new List<PhieuXuat>();
                OpenDataBase();
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandText = "ThemMoiPhieuXuats";
                sqlCommand.Parameters.Add("@MaPhieuXuat", SqlDbType.Char).Value = phieuXuat.MaPhieuXuat;
                sqlCommand.Parameters.Add("@MaNhanVien", SqlDbType.Char).Value = phieuXuat.MaNhanVien;
                sqlCommand.Parameters.Add("@MaKhoHang", SqlDbType.Char).Value = phieuXuat.MaKhoHang;
                sqlCommand.Parameters.Add("@MaKhachHang", SqlDbType.Char).Value = phieuXuat.MaKhachHang;
                sqlCommand.Parameters.Add("@NgayXuat", SqlDbType.DateTime).Value = phieuXuat.NgayXuat;
                sqlCommand.Connection = sqlConnection;
                int k = sqlCommand.ExecuteNonQuery();
                return true;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public bool CapNhapThongTinPhieuXuat(PhieuXuat phieuXuat)
        {
            try
            {
                List<PhieuXuat> DanhSach = new List<PhieuXuat>();
                OpenDataBase();
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandText = "CapNhapPhieuXuats";
                sqlCommand.Parameters.Add("@MaPhieuXuat", SqlDbType.Char).Value = phieuXuat.MaPhieuXuat;
                sqlCommand.Parameters.Add("@MaNhanVien", SqlDbType.Char).Value = phieuXuat.MaNhanVien;
                sqlCommand.Parameters.Add("@MaKhoHang", SqlDbType.Char).Value = phieuXuat.MaKhoHang;
                sqlCommand.Parameters.Add("@MaKhachHang", SqlDbType.Char).Value = phieuXuat.MaKhachHang;
                sqlCommand.Parameters.Add("@NgayXuat", SqlDbType.DateTime).Value = phieuXuat.NgayXuat;
                sqlCommand.Connection = sqlConnection;
                int k = sqlCommand.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<PhieuXuat> LayThonTinPhieuXuatTheoMa(string MaPhieuXuat)
        {
            try
            {
                List<PhieuXuat> DanhSach = new List<PhieuXuat>();
                OpenDataBase();
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandText = "TimKiemTheoMas";
                sqlCommand.Parameters.Add("@MaPhieuXuat", SqlDbType.Char).Value = MaPhieuXuat;
                sqlCommand.Connection = sqlConnection;
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    DanhSach.Add(new PhieuXuat
                    {
                        MaPhieuXuat = sqlDataReader[0].ToString(),
                        MaNhanVien = sqlDataReader[1].ToString(),
                        TenNhanVien = sqlDataReader[2].ToString(),
                        MaKhachHang = sqlDataReader[3].ToString(),
                        TenKhachHang = sqlDataReader[4].ToString(),
                        NgayXuat = DateTime.Parse(sqlDataReader[5].ToString()),
                        MaKhoHang = sqlDataReader[6].ToString(),
                        TenKhoHang = sqlDataReader[7].ToString()
                    });
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
