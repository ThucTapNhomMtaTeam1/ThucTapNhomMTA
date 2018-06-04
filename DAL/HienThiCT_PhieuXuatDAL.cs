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
    public class HienThiCT_PhieuXuatDAL : AccessDataBase
    {
        public List<CT_PhieuXuat> HienThiPhieuXuatTheoMaPhieuXuat(string MaPhieuXuat)
        {
            
            try
            {
                OpenDataBase();
                SqlCommand sqlCommand = new SqlCommand();
                List<CT_PhieuXuat> DanhSach = new List<CT_PhieuXuat>();
                sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                sqlCommand.CommandText = "HienThiChiTietPhieuXuatTheoMa";
                sqlCommand.Parameters.Add("@MaPhieuXuat", SqlDbType.Char).Value = MaPhieuXuat;
                sqlCommand.Connection = sqlConnection;
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    DanhSach.Add(new CT_PhieuXuat
                    {
                        MaPhieuXuat = sqlDataReader[0].ToString(),
                        MaSanPham = sqlDataReader[1].ToString(),
                        TenSanPham = sqlDataReader[2].ToString(),
                        SoLuong = int.Parse(sqlDataReader[4].ToString()),
                        DonGia = double.Parse(sqlDataReader[3].ToString()),
                        TongTien = double.Parse(sqlDataReader[5].ToString())
                    }); 
                }
                CloseDataBase();
                sqlDataReader.Close();
                return DanhSach;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public bool ThemMoiChiTietPhieuXuat(CT_PhieuXuat cT_PphieuXuat)
        {
            try
            {
                OpenDataBase();
                SqlCommand sqlCommand = new SqlCommand();
                List<CT_PhieuXuat> DanhSach = new List<CT_PhieuXuat>();
                sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                sqlCommand.CommandText = "ThemMoiThongTinPhieuXuat";
                sqlCommand.Parameters.Add("@MaPhieuXuat", SqlDbType.Char).Value = cT_PphieuXuat.MaPhieuXuat;
                sqlCommand.Parameters.Add("@MaSanPham", SqlDbType.Char).Value = cT_PphieuXuat.MaSanPham;
                sqlCommand.Parameters.Add("@SoLuong", SqlDbType.Int).Value = cT_PphieuXuat.SoLuong;
                sqlCommand.Parameters.Add("@TongTien", SqlDbType.Money).Value = cT_PphieuXuat.TongTien;
                sqlCommand.Parameters.Add("@GiaKhuyenMai", SqlDbType.Money).Value = 0;
                sqlCommand.Parameters.Add("@GhiChu", SqlDbType.Char).Value = " ";
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
