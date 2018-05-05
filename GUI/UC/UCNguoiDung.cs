using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BLL; 

namespace GUI.UC
{
    public partial class UCNguoiDung : UserControl
    {
        public UCNguoiDung()
        {
            InitializeComponent();
            HienThiMatKhauBLL hienThiMatKhauBLL = new HienThiMatKhauBLL();
            HienThiNguoiDung(hienThiMatKhauBLL.HienThiDanhSachTaiKhoan()); 
        }

        private void HienThiNguoiDung(List<TaiKhoan> DanhSach)
        {
            
            GVNguoiDung.Rows.Clear(); 
            foreach(TaiKhoan taikhoan in DanhSach)
            {
                DataGridViewRow dataGridViewRow = new DataGridViewRow();
                dataGridViewRow.CreateCells(GVNguoiDung);
                dataGridViewRow.Cells[0].Value = taikhoan.TenTaiKhoan;
                dataGridViewRow.Cells[1].Value = taikhoan.MatKhau;
                dataGridViewRow.Cells[2].Value = taikhoan.TenDayDu;
                dataGridViewRow.Cells[3].Value = taikhoan.GioiTinh;
                dataGridViewRow.Cells[4].Value = taikhoan.DienThoai;
                dataGridViewRow.Cells[5].Value = taikhoan.HienThi;
                GVNguoiDung.Rows.Add(dataGridViewRow); 

            }

        }




        private void bar1_ItemClick(object sender, EventArgs e)
        {

        }

        private void gvNguoiDung_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void labelX5_Click(object sender, EventArgs e)
        {

        }

        private void buttonTimKiem_Click(object sender, EventArgs e)
        {
            HienThiMatKhauBLL hienThiMatKhauBLL = new HienThiMatKhauBLL();
            if (radioTaiKhoan.Checked)
            {
                HienThiNguoiDung(hienThiMatKhauBLL.HienThiTaiKhoanTheoTen(texTimKiem.Text)); 
            }
            if (radiotenDayDu.Checked)
            {
                HienThiNguoiDung(hienThiMatKhauBLL.HienThiTaiKhoanTheoTenDayDu(texTimKiem.Text));
            }
        }

        private void btnDanhSach_Click(object sender, EventArgs e)
        {
            HienThiMatKhauBLL hienThiMatKhauBLL = new HienThiMatKhauBLL();
            HienThiNguoiDung(hienThiMatKhauBLL.HienThiDanhSachTaiKhoan());
        }

        private void TexTaiKhoan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow dataGridViewRow = GVNguoiDung.Rows[e.RowIndex];
            TexTaiKhoan.Text = dataGridViewRow.Cells[0].Value + "";
            TexMatKhau.Text =  "";
            TexTenDayDu.Text = dataGridViewRow.Cells[2].Value + "";
            texGioitinh.Text = dataGridViewRow.Cells[3].Value + "";
            texDienThoai.Text = dataGridViewRow.Cells[4].Value + "";
            cbHienThi.Text = dataGridViewRow.Cells[5].Value + "";

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            TexTaiKhoan.Text =  "";
            TexMatKhau.Text =  "";
            TexTenDayDu.Text = "";
            texGioitinh.Text = "";
            texDienThoai.Text = "";
            cbHienThi.Text = "";
        }

        private void btnLuuKH_Click(object sender, EventArgs e)
        {
            TaiKhoan TaiKhoan = new TaiKhoan()
            {
                TenDayDu = TexTenDayDu.Text + "",
                GioiTinh = texGioitinh.Text + "",
                DienThoai = texDienThoai.Text + ""
            };
            HienThiMatKhauBLL hienThiMatKhauBLL = new HienThiMatKhauBLL();
            
            foreach (TaiKhoan taikhoan in hienThiMatKhauBLL.HienThiDanhSachTaiKhoan())
            {
                if(taikhoan.TenTaiKhoan == TexTaiKhoan.Text)
                {
                    MessageBox.Show("Tài Khoản Đã Tồn Tại");
                    return;
                }
                else
                {
                    TaiKhoan.TenTaiKhoan = TexTaiKhoan.Text;
                    
                }
            }
            if (TexMatKhau.Text == "")
            {
                MessageBox.Show("Bạn Cần Nhập  Mật Khẩu");
                return;
            }
            else
            {
                MaHoa maHoa = new MaHoa();
                TaiKhoan.MatKhau = maHoa.ToMD5(TexMatKhau.Text);
            }


            if (cbHienThi.Text == "")
            {
                MessageBox.Show("Chưa Chọn Hiển Thị");
                return;
            }
            else
            {
                TaiKhoan.HienThi = bool.Parse(cbHienThi.Text); 
            }
            hienThiMatKhauBLL.ThemThongTinNguoiDung(TaiKhoan);
            TexTaiKhoan.Text = "";
            TexMatKhau.Text = "";
            TexTenDayDu.Text = "";
            texGioitinh.Text = "";
            texDienThoai.Text = "";
            cbHienThi.Text = "";
            HienThiNguoiDung(hienThiMatKhauBLL.HienThiDanhSachTaiKhoan());

        }

        private void btnSua_Click(object sender, EventArgs e)
        {



            HienThiMatKhauBLL hienThiMatKhauBLL = new HienThiMatKhauBLL();
            TaiKhoan TaiKhoan = new TaiKhoan()
            {
                TenDayDu = TexTenDayDu.Text + "",
                GioiTinh = texGioitinh.Text + "",
                DienThoai = texDienThoai.Text + ""
            };

            foreach (TaiKhoan taikhoan in hienThiMatKhauBLL.HienThiDanhSachTaiKhoan())
            {
                if (taikhoan.TenTaiKhoan == TexTaiKhoan.Text)
                {
                    TaiKhoan.TenTaiKhoan = TexTaiKhoan.Text;
                    break; 

                }
                
            }


            if (TexMatKhau.Text == "")
            {
                MessageBox.Show("Bạn Cần Nhập  Mật Khẩu");
                return; 
            }
            else
            {
                MaHoa maHoa = new MaHoa();
                TaiKhoan.MatKhau = maHoa.ToMD5(TexMatKhau.Text);
            }

            if (cbHienThi.Text == "")
            {
                MessageBox.Show("Chưa Chọn Hiển Thị");
                return;
            }



            else
            {
                TaiKhoan.HienThi = bool.Parse(cbHienThi.Text);
            }
            hienThiMatKhauBLL.ChinhSuaThongTinNguoiDung(TaiKhoan);
            TexTaiKhoan.Text = "";
            TexMatKhau.Text = "";
            TexTenDayDu.Text = "";
            texGioitinh.Text = "";
            texDienThoai.Text = "";
            cbHienThi.Text = "";
            HienThiNguoiDung(hienThiMatKhauBLL.HienThiDanhSachTaiKhoan());
        }
    }
}
