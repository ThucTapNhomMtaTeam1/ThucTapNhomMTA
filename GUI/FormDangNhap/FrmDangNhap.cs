using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.FormDangNhap
{
    public partial class FrmDangNhap : DevComponents.DotNetBar.Office2007RibbonForm
    {
        public FrmDangNhap()
        {
            InitializeComponent();
        }

        private void FrmDangNhap_Load(object sender, EventArgs e)
        {

        }

        private void btbDangNhap_Click(object sender, EventArgs e)
        {
            TaiKhoan taiKhoan = new TaiKhoan();
            taiKhoan.TenTaiKhoan = texUserName.Text;
            MaHoa maHoa = new MaHoa();
            //TexPass.UseSystemPasswordChar = true; 
            taiKhoan.MatKhau = maHoa.ToMD5(TexPass.Text);
            HienThiMatKhauBLL hienThiMatKhauBLL = new HienThiMatKhauBLL();
            int KetQua = hienThiMatKhauBLL.KiemTraDangNhap(taiKhoan.TenTaiKhoan,taiKhoan.MatKhau); 
            if(KetQua == 1)
            {
                
                frmQuanLyBanHang frmQuanLyBanHang = new frmQuanLyBanHang();
                frmQuanLyBanHang.Text = "Xin Chào : " + LayThongTinTaiKhoan(taiKhoan.TenTaiKhoan); 
                frmQuanLyBanHang.Show();
                this.Hide(); 
            }
            else if(KetQua ==0)
            {
                MessageBox.Show("Bạn Nhập Sai Mật Khâu");
                
            }
            else if (KetQua == -1)
            {
                MessageBox.Show("Tài Khoản Không Tồn Tại");

            }
            else if (KetQua == -2)
            {
                MessageBox.Show("Lỗi Kết Nối SQL");

            }
            FrmDangNhap frmDangNhap = new FrmDangNhap();
            frmDangNhap.Close(); 

        }

        private string LayThongTinTaiKhoan(string TenTaiKhoan)
        {
            string TenNguoiDung = null; 
            HienThiMatKhauBLL hienThiMatKhauBLL = new HienThiMatKhauBLL();
            foreach(TaiKhoan taikhoan in hienThiMatKhauBLL.HienThiTaiKhoanTheoTen(TenTaiKhoan))
            {
                 TenNguoiDung = taikhoan.TenDayDu;
                break; 
            }
            return TenNguoiDung; 
        }
        

        private void btnThoát_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn Muốn Thoát Khỏi Hệ Thống", "Xác Nhận",
               MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
