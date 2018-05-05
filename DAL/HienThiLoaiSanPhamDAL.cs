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
    public class HienThiLoaiSanPhamDAL : AccessDataBase
    {
        public List<LoaiSanPham> HienThiDanhSachLoaiSanPham()
        {
            try
            {
                List<LoaiSanPham> DanhSachLSP = new List<LoaiSanPham>();
                OpenDataBase();
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandText = "HienThiDanhSachLoaiSanPham";
                sqlCommand.Connection = sqlConnection;
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    LoaiSanPham loaiSanPham = new LoaiSanPham()
                    {
                        MaLoaiSanPham = sqlDataReader[0] + "",
                        TenLoaiSanPham = sqlDataReader[1] + "",
                        DonViTinh = sqlDataReader[2] + "",
                        GhiChu = sqlDataReader[3] + ""
                    };
                    DanhSachLSP.Add(loaiSanPham);
                }
                CloseDataBase();
                return DanhSachLSP;
            }
            catch(Exception ex)
            {
                throw ex; 
            }
        }

        public List<LoaiSanPham> HienThiDanhSachLoaiSanPhamTheoTen(string TenLoaiSanPham)
        {
            try
            {
                List<LoaiSanPham> DanhSachLSP = new List<LoaiSanPham>();
                OpenDataBase();
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandText = "HienThiDanhSachLoaiSanPhamTheoTen";
                sqlCommand.Connection = sqlConnection;
                sqlCommand.Parameters.Add("@TenLoaiSanPham", SqlDbType.NVarChar).Value = TenLoaiSanPham; 
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    LoaiSanPham loaiSanPham = new LoaiSanPham()
                    {
                        MaLoaiSanPham = sqlDataReader[0] + "",
                        TenLoaiSanPham = sqlDataReader[1] + "",
                        DonViTinh = sqlDataReader[2] + "",
                        GhiChu = sqlDataReader[3] + ""
                    };
                    DanhSachLSP.Add(loaiSanPham);
                }
                CloseDataBase();
                return DanhSachLSP;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<LoaiSanPham> HienThiDanhSachLoaiSanPhamTheoMa(string MaLoaiSanPham)
        {
            try
            {
                List<LoaiSanPham> DanhSachLSP = new List<LoaiSanPham>();
                OpenDataBase();
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandText = "HienThiDanhSachLoaiSanPhamTheoMa";
                sqlCommand.Connection = sqlConnection;
                sqlCommand.Parameters.Add("@MaLoaiSanPham", SqlDbType.NVarChar).Value = MaLoaiSanPham;
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    LoaiSanPham loaiSanPham = new LoaiSanPham()
                    {
                        MaLoaiSanPham = sqlDataReader[0] + "",
                        TenLoaiSanPham = sqlDataReader[1] + "",
                        DonViTinh = sqlDataReader[2] + "",
                        GhiChu = sqlDataReader[3] + ""
                    };
                    DanhSachLSP.Add(loaiSanPham);
                }
                CloseDataBase();
                return DanhSachLSP;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool ThemMoiLoaiSanPham(LoaiSanPham loaiSanPham)
        {
            OpenDataBase();
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.CommandText = "ThemMoiLoaiSanPham";
            sqlCommand.Connection = sqlConnection;
            sqlCommand.Parameters.Add("@MaLoaiSanPham", SqlDbType.Char).Value = loaiSanPham.MaLoaiSanPham;
            sqlCommand.Parameters.Add("@TenLoaiSanPham", SqlDbType.NVarChar).Value = loaiSanPham.TenLoaiSanPham;
            sqlCommand.Parameters.Add("@DonViTinh", SqlDbType.NVarChar).Value = loaiSanPham.DonViTinh;
            sqlCommand.Parameters.Add("@GhiChu", SqlDbType.NVarChar).Value = loaiSanPham.GhiChu;
            int k = sqlCommand.ExecuteNonQuery();
            return k > 0; 
        }


        public bool XoaLoaiSanPham(string  MaLoaiSanPham)
        {
            OpenDataBase();
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.CommandText = "XoaLoaiSanPham";
            sqlCommand.Connection = sqlConnection;
            sqlCommand.Parameters.Add("@MaLoaiSanPham", SqlDbType.Char).Value = MaLoaiSanPham;
            int k = sqlCommand.ExecuteNonQuery();
            return k > 0;
        }


        public bool SuaThongTinLoaiSanPham(LoaiSanPham loaiSanPham)
        {
            OpenDataBase();
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.CommandText = "ThemMoiLoaiSanPham";
            sqlCommand.Connection = sqlConnection;
            sqlCommand.Parameters.Add("@MaLoaiSanPham", SqlDbType.Char).Value = loaiSanPham.MaLoaiSanPham;
            sqlCommand.Parameters.Add("@TenLoaiSanPham", SqlDbType.NVarChar).Value = loaiSanPham.TenLoaiSanPham;
            sqlCommand.Parameters.Add("@DonViTinh", SqlDbType.NVarChar).Value = loaiSanPham.DonViTinh;
            sqlCommand.Parameters.Add("@GhiChu", SqlDbType.NVarChar).Value = loaiSanPham.GhiChu;
            int k = sqlCommand.ExecuteNonQuery();
            return k > 0;
        }

    }
}
