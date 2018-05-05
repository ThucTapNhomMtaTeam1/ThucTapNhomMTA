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
    public partial class UCNhanVien : UserControl
    {
        public UCNhanVien()
        {
            InitializeComponent();
        }

        private void UCNhanVien_Load(object sender, EventArgs e)
        {
            tvPhanLoaiNhanVien.ExpandAll();
            HienThiDanhSachNhanVien();
            HienThiDanhSachKhoHang();
            tvPhanLoaiNhanVien.Nodes[0].Nodes[1].ExpandAll();
        }

        private void HienThiDanhSachNhanVien()
        {
            HienThiNhanVienBLL hienThiNhanVienBLL = new HienThiNhanVienBLL(); 
            gvDanhSachNhanVien.Rows.Clear();
            int nam = 0, nu = 0, Tong = 0;
            foreach (NhanVien nhanVien in hienThiNhanVienBLL.LayToanBoNhanVien())
            {
                DataGridViewRow dataGridViewRow = new DataGridViewRow();
                dataGridViewRow.CreateCells(gvDanhSachNhanVien);
                dataGridViewRow.Cells[0].Value = nhanVien.MaNhanVien;
                dataGridViewRow.Cells[1].Value = nhanVien.TenNhanVien;
                dataGridViewRow.Cells[2].Value = nhanVien.ChungMinhThu; 
                dataGridViewRow.Cells[3].Value = nhanVien.NgaySinh.ToString("dd/MM/yyyy");
                dataGridViewRow.Cells[4].Value = nhanVien.GioiTinh;
                dataGridViewRow.Cells[5].Value = nhanVien.DiaChi;
                dataGridViewRow.Cells[6].Value = nhanVien.SoDienThoai;
                dataGridViewRow.Cells[7].Value = nhanVien.Email;
                dataGridViewRow.Cells[8].Value = nhanVien.ChucVu;
                dataGridViewRow.Cells[9].Value = nhanVien.TienLuong;
                dataGridViewRow.Cells[10].Value = nhanVien.NgayVaoLam.ToString("dd/MM/yyyy");
                dataGridViewRow.Cells[11].Value = nhanVien.KhoHang; 
                gvDanhSachNhanVien.Rows.Add(dataGridViewRow);
                if (nhanVien.GioiTinh == "Nam")
                {
                    nam++;
                }
                if (nhanVien.GioiTinh == "Nữ")
                {
                    nu++;
                }
                Tong++;
            }
            texTongNam.Text = nam + "";
            TexTongNu.Text = nu + "";
            texTongNhanVien.Text = Tong + "";
        }

        private void HienThiDanhSachKhoHang()
        {
            HienThiKhoHangBLL hienThiKhoHangBLL = new HienThiKhoHangBLL(); 
            for(int i = 0; i < tvPhanLoaiNhanVien.Nodes[0].Nodes[1].Nodes.Count; i++)
            {
                tvPhanLoaiNhanVien.Nodes[0].Nodes[1].Nodes[i].Remove();
            }
            foreach (KhoHang khoHang in hienThiKhoHangBLL.LayToanBoKhoHang())
            {
                TreeNode treeNode = new TreeNode(khoHang.TenKhoHang);
                tvPhanLoaiNhanVien.Nodes[0].Nodes[1].Nodes.Add(treeNode);
                cbKhoHang.Items.Add(khoHang);
                treeNode.Tag = khoHang;
            }
        }

        KhoHang KKhoHang = null;

        private void tvPhanLoaiNhanVien_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if(e.Node != null)
            {
                KKhoHang = null; 
                if (e.Node == tvPhanLoaiNhanVien.Nodes[0].Nodes[0])
                {
                    HienThiDanhSachNhanVien();
                    
                }
            }

            if (e.Node.Level == 2)
            {
                KhoHang khoHang = e.Node.Tag as KhoHang;
                HienThiDanhSachNhanVienTheoKhoHang(khoHang);
                KKhoHang = khoHang; 
            }
            else
            {
                KKhoHang = null; 
                return;
            }
        }

        private void HienThiDanhSachNhanVienTheoKhoHang(KhoHang khoHang)
        {
            int nam = 0, nu = 0, Tong = 0;
            HienThiNhanVienBLL hienThiNhanVienBLL = new HienThiNhanVienBLL();
            gvDanhSachNhanVien.Rows.Clear();
            foreach (NhanVien nhanVien in hienThiNhanVienBLL.HienThiNhanVienTheoKho(khoHang.MaKhoHang))
            {
                DataGridViewRow dataGridViewRow = new DataGridViewRow();
                dataGridViewRow.CreateCells(gvDanhSachNhanVien);
                dataGridViewRow.Cells[0].Value = nhanVien.MaNhanVien;
                dataGridViewRow.Cells[1].Value = nhanVien.TenNhanVien;
                dataGridViewRow.Cells[2].Value = nhanVien.ChungMinhThu;
                dataGridViewRow.Cells[3].Value = nhanVien.NgaySinh.ToString("dd/MM/yyyy");
                dataGridViewRow.Cells[4].Value = nhanVien.GioiTinh;
                dataGridViewRow.Cells[5].Value = nhanVien.DiaChi;
                dataGridViewRow.Cells[6].Value = nhanVien.SoDienThoai;
                dataGridViewRow.Cells[7].Value = nhanVien.Email;
                dataGridViewRow.Cells[8].Value = nhanVien.ChucVu;
                dataGridViewRow.Cells[9].Value = nhanVien.TienLuong;
                dataGridViewRow.Cells[10].Value = nhanVien.NgayVaoLam.ToString("dd/MM/yyyy");
                dataGridViewRow.Cells[11].Value = nhanVien.KhoHang;
                gvDanhSachNhanVien.Rows.Add(dataGridViewRow);

                // Hiển Thị Thống Kê 
                
                if(nhanVien.GioiTinh == "Nam")
                {
                    nam++; 
                }
                if(nhanVien.GioiTinh == "Nữ")
                {
                    nu++; 
                }
                Tong++; 
            }
            texTongNam.Text = nam+"";
            TexTongNu.Text = nu + "";
            texTongNhanVien.Text = Tong+ ""; 

        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            texDiaChi.Text = "";
            texDienThoai.Text = "";
            texMaNhanVien.Text = "";
            texTenNhanVien.Text = "";
            texCMT.Text = "";
            cbChucVu.Text = "";
            cbGioiTinh.Text = "";
            cbKhoHang.Text = "";
            texTienLuong.Text = "";
            texEmail.Text = "";
            dateNgaySinh.Text = "";
            dateNgayVaoLam.Text = ""; 
        }

        private void gvDanhSachNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                DataGridViewRow dataGridViewRow = gvDanhSachNhanVien.Rows[e.RowIndex];
                texMaNhanVien.Text = dataGridViewRow.Cells[0].Value + "";
                texTenNhanVien.Text = dataGridViewRow.Cells[1].Value + "";
                texCMT.Text = dataGridViewRow.Cells[2].Value + "";
                dateNgaySinh.Value = DoiNgay(dataGridViewRow.Cells[3].Value + "");
                cbGioiTinh.Text = dataGridViewRow.Cells[4].Value + "";
                texDiaChi.Text = dataGridViewRow.Cells[5].Value + "";
                texDienThoai.Text = dataGridViewRow.Cells[6].Value + "";
                texEmail.Text = dataGridViewRow.Cells[7].Value + "";
                cbChucVu.Text = dataGridViewRow.Cells[8].Value + "";
                texTienLuong.Text = dataGridViewRow.Cells[9].Value + "";
                dateNgayVaoLam.Value = DoiNgay(dataGridViewRow.Cells[10].Value + "");
                for (int i = 0; i < cbKhoHang.Items.Count; i++)
                {
                    KhoHang khoHang = cbKhoHang.Items[i] as KhoHang;
                    if (khoHang.TenKhoHang == dataGridViewRow.Cells[11].Value + "")
                    {
                        cbKhoHang.SelectedItem = khoHang;
                        break;
                    }

                }
            }
        }

        private DateTime DoiNgay(string value)
        {
            string[] Arr = value.Split('/');
            int Ngay = int.Parse(Arr[0]);
            int Thang = int.Parse(Arr[1]);
            int Nam = int.Parse(Arr[2]);
            DateTime dateTime = new DateTime(Nam, Thang, Ngay);
            return dateTime; 
        }

        private void btbLuu_Click(object sender, EventArgs e)
        {
            if(texMaNhanVien.Text == "" || texMaNhanVien.Text == null)
            {
                MessageBox.Show("Bạn Cần Nhập Mật Khẩu Trước Khi Lưu");
                return; 
            }
            if (cbGioiTinh.Text == "" || cbGioiTinh.Text == null)
            {
                MessageBox.Show("Bạn Cần Chọn Giới Tính Trước Khi Lưu");
                return;
            }
            if (cbChucVu.Text == "" || cbChucVu.Text == null)
            {
                MessageBox.Show("Bạn cần Chọn Chức Vụ Trước Khi Lưu");
                return;
            }
            if (cbKhoHang.Text == "" || cbKhoHang.Text == null)
            {
                MessageBox.Show("Bạn cần Chọn  Kho Hàng Trước Khi Lưu ");
                return;
            }
            NhanVien nhanVien = new NhanVien()
            {
                MaNhanVien = texMaNhanVien.Text,
                TenNhanVien = texTenNhanVien.Text,
                ChungMinhThu = texCMT.Text,
                NgaySinh = dateNgaySinh.Value,
                GioiTinh = cbGioiTinh.Text,
                DiaChi = texDiaChi.Text,
                SoDienThoai = texDienThoai.Text,
                Email = texEmail.Text,
                ChucVu = cbChucVu.Text,
                TienLuong = texTienLuong.Text,
                NgayVaoLam = dateNgayVaoLam.Value
            }; 
            if(cbKhoHang.SelectedIndex != -1)
            {
                KhoHang khoHang = cbKhoHang.SelectedItem as KhoHang;
                nhanVien.KhoHang = khoHang.MaKhoHang; 
            }
            HienThiNhanVienBLL hienThiNhanVienBLL = new HienThiNhanVienBLL();
            hienThiNhanVienBLL.ThemMoiNhanVien(nhanVien);
            if (KKhoHang != null)
            {
                HienThiDanhSachNhanVienTheoKhoHang(KKhoHang);
            }
            else
            {
                HienThiDanhSachNhanVien();
            }

        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            HienThiNhanVienBLL hienThiNhanVienBLL = new HienThiNhanVienBLL();
            List<NhanVien> DanhSachNhanVien = new List<NhanVien>(); 
            if (radioMa.Checked)
            {
                DanhSachNhanVien = hienThiNhanVienBLL.TimKiemNhanVienTheoMa(texTimKiem.Text);   
            }
            else if (radioTen.Checked)
            {
                DanhSachNhanVien = hienThiNhanVienBLL.TimKiemNhanVienTheoTen(texTimKiem.Text); 
            }
            else if (radioCMT.Checked)
            {
                DanhSachNhanVien = hienThiNhanVienBLL.TimKiemSinhvienTheoCMT(texTimKiem.Text); 
            }
            gvDanhSachNhanVien.Rows.Clear();
            int nam = 0, nu = 0, Tong = 0;
            foreach (NhanVien nhanVien in DanhSachNhanVien)
            {
                DataGridViewRow dataGridViewRow = new DataGridViewRow();
                dataGridViewRow.CreateCells(gvDanhSachNhanVien);
                dataGridViewRow.Cells[0].Value = nhanVien.MaNhanVien;
                dataGridViewRow.Cells[1].Value = nhanVien.TenNhanVien;
                dataGridViewRow.Cells[2].Value = nhanVien.ChungMinhThu;
                dataGridViewRow.Cells[3].Value = nhanVien.NgaySinh.ToString("dd/MM/yyyy");
                dataGridViewRow.Cells[4].Value = nhanVien.GioiTinh;
                dataGridViewRow.Cells[5].Value = nhanVien.DiaChi;
                dataGridViewRow.Cells[6].Value = nhanVien.SoDienThoai;
                dataGridViewRow.Cells[7].Value = nhanVien.Email;
                dataGridViewRow.Cells[8].Value = nhanVien.ChucVu;
                dataGridViewRow.Cells[9].Value = nhanVien.TienLuong;
                dataGridViewRow.Cells[10].Value = nhanVien.NgayVaoLam.ToString("dd/MM/yyyy");
                dataGridViewRow.Cells[11].Value = nhanVien.KhoHang;
                gvDanhSachNhanVien.Rows.Add(dataGridViewRow);
                if (nhanVien.GioiTinh == "Nam")
                {
                    nam++;
                }
                if (nhanVien.GioiTinh == "Nữ")
                {
                    nu++;
                }
                Tong++;
            }
            texTongNam.Text = nam + "";
            TexTongNu.Text = nu + "";
            texTongNhanVien.Text = Tong + "";
        }

        private void btnChinhSua_Click(object sender, EventArgs e)
        {
            if (texMaNhanVien.Text == "" || texMaNhanVien.Text == null)
            {
                MessageBox.Show("Bạn Cần Nhập Mật Khẩu Trước Khi Lưu");
                return;
            }
            if (cbGioiTinh.Text == "" || cbGioiTinh.Text == null)
            {
                MessageBox.Show("Bạn Cần Chọn Giới Tính Trước Khi Lưu");
                return;
            }
            if (cbChucVu.Text == "" || cbChucVu.Text == null)
            {
                MessageBox.Show("Bạn cần Chọn Chức Vụ Trước Khi Lưu");
                return;
            }
            if (cbKhoHang.Text == "" || cbKhoHang.Text == null)
            {
                MessageBox.Show("Bạn cần Chọn  Kho Hàng Trước Khi Lưu ");
                return;
            }
            NhanVien nhanVien = new NhanVien()
            {
                MaNhanVien = texMaNhanVien.Text,
                TenNhanVien = texTenNhanVien.Text,
                ChungMinhThu = texCMT.Text,
                NgaySinh = dateNgaySinh.Value,
                GioiTinh = cbGioiTinh.Text,
                DiaChi = texDiaChi.Text,
                SoDienThoai = texDienThoai.Text,
                Email = texEmail.Text,
                ChucVu = cbChucVu.Text,
                TienLuong = texTienLuong.Text,
                NgayVaoLam = dateNgayVaoLam.Value
            };
            if (cbKhoHang.SelectedIndex != -1)
            {
                KhoHang khoHang = cbKhoHang.SelectedItem as KhoHang;
                nhanVien.KhoHang = khoHang.MaKhoHang;
            }
            HienThiNhanVienBLL hienThiNhanVienBLL = new HienThiNhanVienBLL();
            hienThiNhanVienBLL.SuaThongTinNhanVien(nhanVien);
            if (KKhoHang != null)
            {
                HienThiDanhSachNhanVienTheoKhoHang(KKhoHang);
            }
            else
            {
                HienThiDanhSachNhanVien();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (texMaNhanVien.Text == "" || texMaNhanVien == null)
            {
                MessageBox.Show("Bạn Chưa Chọn Nhân Viên Cần Xóa");
            }
            else
            {
                HienThiNhanVienBLL hienThiNhanVienBLL = new HienThiNhanVienBLL();
                hienThiNhanVienBLL.XoaThongTinNhanVien(texMaNhanVien.Text);
                if (KKhoHang != null)
                {
                    HienThiDanhSachNhanVienTheoKhoHang(KKhoHang);
                }
                else
                {
                    HienThiDanhSachNhanVien();
                }

            }
        }
    }
}
