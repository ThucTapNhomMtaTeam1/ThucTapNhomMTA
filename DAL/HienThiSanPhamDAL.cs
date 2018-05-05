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
    public class HienThiSanPhamDAL: AccessDataBase
    {
        public List<SanPham> HienThiDanhSachSanPham()
        {
            try
            {
                OpenDataBase();
                SqlCommand sqlCommand = new SqlCommand();
                List<SanPham> DanhSachSP = new List<SanPham>();
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandText = "HienThiDanhSachSanPham";
                sqlCommand.Connection = sqlConnection;
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    SanPham sanPham = new SanPham()
                    {
                        MaSanPham = sqlDataReader[0].ToString(),
                        TenSanPham = sqlDataReader[1].ToString(),
                        SoLuong = int.Parse(sqlDataReader[2].ToString()),
                        DonGia = double.Parse(sqlDataReader[3].ToString()),
                        KhoHang = sqlDataReader[4].ToString(),
                        LoaiSanPham = sqlDataReader[5].ToString(),
                        NhaCungCap = sqlDataReader[6].ToString(),
                        NhaSanXuat = sqlDataReader[7].ToString(),
                    };
                    DanhSachSP.Add(sanPham);
                }
                CloseDataBase();
                sqlDataReader.Close();
                return DanhSachSP;
            }
            catch(Exception ex)
            {
                throw ex; 
            }

        }

        public List<SanPham> HienThiDanhSachSanPhamTheoKho(string MaKhoHang)
        {
            try
            {
                OpenDataBase();
                SqlCommand sqlCommand = new SqlCommand();
                List<SanPham> DanhSachSP = new List<SanPham>();
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandText = "HienThiDanhSachSanPhamTheoKho";
                sqlCommand.Connection = sqlConnection;
                sqlCommand.Parameters.Add("@MaKhoHang", SqlDbType.Char).Value = MaKhoHang;
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    SanPham sanPham = new SanPham()
                    {
                        MaSanPham = sqlDataReader[0].ToString(),
                        TenSanPham = sqlDataReader[1].ToString(),
                        SoLuong = int.Parse(sqlDataReader[2].ToString()),
                        DonGia = double.Parse(sqlDataReader[3].ToString()),
                        KhoHang = sqlDataReader[4].ToString(),
                        LoaiSanPham = sqlDataReader[5].ToString(),
                        NhaCungCap = sqlDataReader[6].ToString(),
                        NhaSanXuat = sqlDataReader[7].ToString(),
                    };
                    DanhSachSP.Add(sanPham);
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

        public List<SanPham> HienThiDanhSachSanPhamTheoLoaiSP(string MaLoaiSanPham)
        {
            try
            {
                OpenDataBase();
                SqlCommand sqlCommand = new SqlCommand();
                List<SanPham> DanhSachSP = new List<SanPham>();
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandText = "HienThiDanhSachSanPhamTheoLoaiSP";
                sqlCommand.Connection = sqlConnection;
                sqlCommand.Parameters.Add("@MaLoaiSanPham", SqlDbType.Char).Value = MaLoaiSanPham;
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    SanPham sanPham = new SanPham()
                    {
                        MaSanPham = sqlDataReader[0].ToString(),
                        TenSanPham = sqlDataReader[1].ToString(),
                        SoLuong = int.Parse(sqlDataReader[2].ToString()),
                        DonGia = double.Parse(sqlDataReader[3].ToString()),
                        KhoHang = sqlDataReader[4].ToString(),
                        LoaiSanPham = sqlDataReader[5].ToString(),
                        NhaCungCap = sqlDataReader[6].ToString(),
                        NhaSanXuat = sqlDataReader[7].ToString(),
                    };
                    DanhSachSP.Add(sanPham);
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

        public List<SanPham> HienThiDanhSachSanPhamTheoNSX(string MaNhaSanXuat)
        {
            try
            {
                OpenDataBase();
                SqlCommand sqlCommand = new SqlCommand();
                List<SanPham> DanhSachSP = new List<SanPham>();
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandText = "HienThiDanhSachSanPhamTheoNSX";
                sqlCommand.Connection = sqlConnection;
                sqlCommand.Parameters.Add("@MaNhaSanXuat", SqlDbType.Char).Value = MaNhaSanXuat;
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    SanPham sanPham = new SanPham()
                    {
                        MaSanPham = sqlDataReader[0].ToString(),
                        TenSanPham = sqlDataReader[1].ToString(),
                        SoLuong = int.Parse(sqlDataReader[2].ToString()),
                        DonGia = double.Parse(sqlDataReader[3].ToString()),
                        KhoHang = sqlDataReader[4].ToString(),
                        LoaiSanPham = sqlDataReader[5].ToString(),
                        NhaCungCap = sqlDataReader[6].ToString(),
                        NhaSanXuat = sqlDataReader[7].ToString(),
                    };
                    DanhSachSP.Add(sanPham);
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

        public List<SanPham> HienThiDanhSachSanPhamTheoNCC(string MaNhaCungCap)
        {
            try
            {
                OpenDataBase();
                SqlCommand sqlCommand = new SqlCommand();
                List<SanPham> DanhSachSP = new List<SanPham>();
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandText = "HienThiDanhSachSanPhamTheoNCC";
                sqlCommand.Connection = sqlConnection;
                sqlCommand.Parameters.Add("@MaNhaCungCap", SqlDbType.Char).Value = MaNhaCungCap;
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    SanPham sanPham = new SanPham()
                    {
                        MaSanPham = sqlDataReader[0].ToString(),
                        TenSanPham = sqlDataReader[1].ToString(),
                        SoLuong = int.Parse(sqlDataReader[2].ToString()),
                        DonGia = double.Parse(sqlDataReader[3].ToString()),
                        KhoHang = sqlDataReader[4].ToString(),
                        LoaiSanPham = sqlDataReader[5].ToString(),
                        NhaCungCap = sqlDataReader[6].ToString(),
                        NhaSanXuat = sqlDataReader[7].ToString(),
                    };
                    DanhSachSP.Add(sanPham);
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

        public List<SanPham> HienThiDanhSachSanPhamTheoMaSP(string MaSanPham)
        {
            try
            {
                OpenDataBase();
                SqlCommand sqlCommand = new SqlCommand();
                List<SanPham> DanhSachSP = new List<SanPham>();
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandText = "HienThiDanhSachSanPhamTheoMaSP";
                sqlCommand.Connection = sqlConnection;
                sqlCommand.Parameters.Add("@MaSanPham", SqlDbType.Char).Value = MaSanPham;
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    SanPham sanPham = new SanPham()
                    {
                        MaSanPham = sqlDataReader[0].ToString(),
                        TenSanPham = sqlDataReader[1].ToString(),
                        SoLuong = int.Parse(sqlDataReader[2].ToString()),
                        DonGia = double.Parse(sqlDataReader[3].ToString()),
                        KhoHang = sqlDataReader[4].ToString(),
                        LoaiSanPham = sqlDataReader[5].ToString(),
                        NhaCungCap = sqlDataReader[6].ToString(),
                        NhaSanXuat = sqlDataReader[7].ToString(),
                    };
                    DanhSachSP.Add(sanPham);
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

        public List<SanPham> HienThiDanhSachSanPhamTheoTenSP(string TenSanPham)
        {
            try
            {
                OpenDataBase();
                SqlCommand sqlCommand = new SqlCommand();
                List<SanPham> DanhSachSP = new List<SanPham>();
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandText = "HienThiDanhSachSanPhamTheoTenSP";
                sqlCommand.Connection = sqlConnection;
                sqlCommand.Parameters.Add("@TenSanPham", SqlDbType.Char).Value = TenSanPham;
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    SanPham sanPham = new SanPham()
                    {
                        MaSanPham = sqlDataReader[0].ToString(),
                        TenSanPham = sqlDataReader[1].ToString(),
                        SoLuong = int.Parse(sqlDataReader[2].ToString()),
                        DonGia = double.Parse(sqlDataReader[3].ToString()),
                        KhoHang = sqlDataReader[4].ToString(),
                        LoaiSanPham = sqlDataReader[5].ToString(),
                        NhaCungCap = sqlDataReader[6].ToString(),
                        NhaSanXuat = sqlDataReader[7].ToString(),
                    };
                    DanhSachSP.Add(sanPham);
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

        public List<SanPham> HienThiDanhSachSanPhamTheoSoLuong(int SoLuong)
        {
            try
            {
                OpenDataBase();
                SqlCommand sqlCommand = new SqlCommand();
                List<SanPham> DanhSachSP = new List<SanPham>();
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandText = "HienThiDanhSachSanPhamTheoSoLuong";
                sqlCommand.Connection = sqlConnection;
                sqlCommand.Parameters.Add("@SoLuong", SqlDbType.Int).Value = SoLuong;
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    SanPham sanPham = new SanPham()
                    {
                        MaSanPham = sqlDataReader[0].ToString(),
                        TenSanPham = sqlDataReader[1].ToString(),
                        SoLuong = int.Parse(sqlDataReader[2].ToString()),
                        DonGia = double.Parse(sqlDataReader[3].ToString()),
                        KhoHang = sqlDataReader[4].ToString(),
                        LoaiSanPham = sqlDataReader[5].ToString(),
                        NhaCungCap = sqlDataReader[6].ToString(),
                        NhaSanXuat = sqlDataReader[7].ToString(),
                    };
                    DanhSachSP.Add(sanPham);
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

        public bool ThemMoiSanPham(SanPham sanPham)
        {
            try
            {
                OpenDataBase();
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandText = "ThemMoiSanPham";
                sqlCommand.Connection = sqlConnection;
                sqlCommand.Parameters.Add("@MaSanPham", SqlDbType.Char).Value = sanPham.MaSanPham;
                sqlCommand.Parameters.Add("@TenSanPham", SqlDbType.NVarChar).Value = sanPham.TenSanPham;
                sqlCommand.Parameters.Add("@SoLuong", SqlDbType.Int).Value = sanPham.SoLuong;
                sqlCommand.Parameters.Add("@DonGia", SqlDbType.Money).Value = sanPham.DonGia;
                sqlCommand.Parameters.Add("@MaKhoHang", SqlDbType.Char).Value = sanPham.KhoHang;
                sqlCommand.Parameters.Add("@MaLoaiSanPham", SqlDbType.Char).Value = sanPham.LoaiSanPham;
                sqlCommand.Parameters.Add("@MaNhaCungcap", SqlDbType.Char).Value = sanPham.NhaCungCap;
                sqlCommand.Parameters.Add("@MaNhaSanXuat", SqlDbType.Char).Value = sanPham.NhaSanXuat;
                int k = sqlCommand.ExecuteNonQuery();
                CloseDataBase();
                return k > 0;
            }
            catch (Exception ex)
            {
                throw ex;
            }
           
        }

        public bool ChinhSuaThongtinSanPham(SanPham sanPham)
        {
            try
            {
                OpenDataBase();
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandText = "ChinhSuaThongtinSanPham";
                sqlCommand.Connection = sqlConnection;
                sqlCommand.Parameters.Add("@MaSanPham", SqlDbType.Char).Value = sanPham.MaSanPham;
                sqlCommand.Parameters.Add("@TenSanPham", SqlDbType.NVarChar).Value = sanPham.TenSanPham;
                sqlCommand.Parameters.Add("@SoLuong", SqlDbType.Int).Value = sanPham.SoLuong;
                sqlCommand.Parameters.Add("@DonGia", SqlDbType.Money).Value = sanPham.DonGia;
                sqlCommand.Parameters.Add("@MaKhoHang", SqlDbType.Char).Value = sanPham.KhoHang;
                sqlCommand.Parameters.Add("@MaLoaiSanPham", SqlDbType.Char).Value = sanPham.LoaiSanPham;
                sqlCommand.Parameters.Add("@MaNhaCungcap", SqlDbType.Char).Value = sanPham.NhaCungCap;
                sqlCommand.Parameters.Add("@MaNhaSanXuat", SqlDbType.Char).Value = sanPham.NhaSanXuat;
                int k = sqlCommand.ExecuteNonQuery();
                CloseDataBase();
                return k > 0;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            
        }


        public bool XoaSanPham(string MaSanPham)
        {
            try
            {
                OpenDataBase();
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandText = "XoaSanPham";
                sqlCommand.Connection = sqlConnection;
                sqlCommand.Parameters.Add("@MaSanPham", SqlDbType.Char).Value = MaSanPham;
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
