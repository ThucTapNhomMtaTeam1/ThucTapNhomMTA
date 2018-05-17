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
                sqlCommand.CommandText = "HienThiTC_PhieuNhapTheoHoaDon1";
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
                               SoLuong = int.Parse(sqlDataReader[2].ToString()),
                               DonGia = double.Parse(sqlDataReader[3].ToString()),
                               TongTien = double.Parse(sqlDataReader[4].ToString()),
                               GhiChu = sqlDataReader[5].ToString()
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
    }
}
