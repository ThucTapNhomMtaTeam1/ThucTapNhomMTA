﻿using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class HienThiCT_PhieuNhapDAL:AccessDataBase
    {
        public List<CT_PhieuNhap> HienThiDanhSachSPTheoMaPhieu(string MaPhieuNhap)
        {

            try
            {
                OpenDataBase();
                SqlCommand sqlCommand = new SqlCommand();
                List<CT_PhieuNhap> DanhSachSP = new List<CT_PhieuNhap>();
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandText = "HienThiTC_PhieuNhapTheoHoaDon2";
                sqlCommand.Parameters.Add("@MaHoaDon", SqlDbType.Char).Value = MaPhieuNhap; 
                sqlCommand.Connection = sqlConnection;
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    DanhSachSP.Add
                        (
                           new CT_PhieuNhap()
                           {
                               MaPhieuNhap = sqlDataReader[0].ToString(),
                               SanPham = sqlDataReader[1].ToString(),
                               TenSanPham = sqlDataReader[2].ToString(),
                               SoLuong = int.Parse(sqlDataReader[3].ToString()),
                               DonGia = double.Parse(sqlDataReader[4].ToString()),
                               TongTien = double.Parse(sqlDataReader[5].ToString()),
                               GhiChu = sqlDataReader[6].ToString()
                           }
                        ); 
                }
                CloseDataBase();
                sqlDataReader.Close();
                return DanhSachSP;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void XoaToanBoChiTietPhieuNhap(string maPhieuNhap)
        {
            OpenDataBase();
            SqlCommand sqlCommand = new SqlCommand();
            List<CT_PhieuNhap> DanhSachSP = new List<CT_PhieuNhap>();
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.CommandText = "delete from CT_PhieuNhap where MaPhieuNhap = '"+ maPhieuNhap+ "'";
            sqlCommand.Connection = sqlConnection;
            int k = sqlCommand.ExecuteNonQuery();
        }

        public bool CapNhapThongTinCT_HoaDonNhap(CT_PhieuNhap cT_PhieuNhap)
        {
            try
            {
                OpenDataBase();
                SqlCommand sqlCommand = new SqlCommand();
                List<CT_PhieuNhap> DanhSachSP = new List<CT_PhieuNhap>();
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandText = "CapNhapCT_PhieuNhap";
                sqlCommand.Parameters.Add("@MaPhieuNhap", SqlDbType.Char).Value = cT_PhieuNhap.MaPhieuNhap;
                sqlCommand.Parameters.Add("@MaSanPham", SqlDbType.Char).Value = cT_PhieuNhap.SanPham;
                sqlCommand.Parameters.Add("@SoLuong", SqlDbType.Int).Value = cT_PhieuNhap.SoLuong;
                sqlCommand.Parameters.Add("@DonGiaNhap", SqlDbType.Money).Value = cT_PhieuNhap.DonGia;
                sqlCommand.Parameters.Add("@TongTien", SqlDbType.Money).Value = cT_PhieuNhap.TongTien;
                sqlCommand.Parameters.Add("@GhiChu", SqlDbType.NVarChar).Value = cT_PhieuNhap.GhiChu;
                sqlCommand.Connection = sqlConnection;
                int k = sqlCommand.ExecuteNonQuery();
                return true; 
            }
            catch (Exception ex)
            {
                return false; 
            }
        }

        public bool ThemMoiCT_PhieuNhap(CT_PhieuNhap cT_PhieuNhap)
        {

            try
            {
                OpenDataBase();
                SqlCommand sqlCommand = new SqlCommand();
                List<CT_PhieuNhap> DanhSachSP = new List<CT_PhieuNhap>();
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandText = "ThemMoiCT_PhieuNhap";
                sqlCommand.Parameters.Add("@MaPhieuNhap", SqlDbType.Char).Value = cT_PhieuNhap.MaPhieuNhap;
                sqlCommand.Parameters.Add("@MaSanPham", SqlDbType.Char).Value = cT_PhieuNhap.SanPham;
                sqlCommand.Parameters.Add("@SoLuong", SqlDbType.Int).Value = cT_PhieuNhap.SoLuong;
                sqlCommand.Parameters.Add("@DonGiaNhap", SqlDbType.Money).Value = cT_PhieuNhap.DonGia;
                sqlCommand.Parameters.Add("@TongTien", SqlDbType.Money).Value = cT_PhieuNhap.TongTien;
                sqlCommand.Parameters.Add("@GhiChu", SqlDbType.NVarChar).Value = cT_PhieuNhap.GhiChu;
                sqlCommand.Connection = sqlConnection;
                int k = sqlCommand.ExecuteNonQuery();
                return k > 0;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool XoaCt_PhieuNhap(string MaPhieuNhap, string MaSanPham)
        {

            try
            {
                OpenDataBase();
                SqlCommand sqlCommand = new SqlCommand();
                List<CT_PhieuNhap> DanhSachSP = new List<CT_PhieuNhap>();
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandText = "XoaChiTietPhieuNhap";
                sqlCommand.Parameters.Add("@MaPhieuNhap", SqlDbType.Char).Value = MaPhieuNhap;
                sqlCommand.Parameters.Add("@MaSanPham", SqlDbType.Char).Value = MaSanPham;
                sqlCommand.Connection = sqlConnection;
                int k = sqlCommand.ExecuteNonQuery();
                return k > 0;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool SuaCt_PhieuNhap(CT_PhieuNhap cT_PhieuNhap)
        {

            try
            {
                OpenDataBase();
                SqlCommand sqlCommand = new SqlCommand();
                List<CT_PhieuNhap> DanhSachSP = new List<CT_PhieuNhap>();
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandText = "CapNhapchiTietPhieuNhap";
                sqlCommand.Parameters.Add("@MaPhieuNhap", SqlDbType.Char).Value = cT_PhieuNhap.MaPhieuNhap;
                sqlCommand.Parameters.Add("@MaSanPham", SqlDbType.Char).Value = cT_PhieuNhap.SanPham;
                sqlCommand.Parameters.Add("@SoLuong", SqlDbType.Int).Value = cT_PhieuNhap.SoLuong;
                sqlCommand.Parameters.Add("@DonGiaNhap", SqlDbType.Money).Value = cT_PhieuNhap.DonGia;
                sqlCommand.Parameters.Add("@TongTien", SqlDbType.Money).Value = cT_PhieuNhap.TongTien;
                sqlCommand.Parameters.Add("@GhiChu", SqlDbType.NVarChar).Value = " ";
                sqlCommand.Connection = sqlConnection;
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
