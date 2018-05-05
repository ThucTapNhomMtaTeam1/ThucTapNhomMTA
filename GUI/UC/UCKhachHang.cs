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
    public partial class UCKhachHang : UserControl
    {
        public UCKhachHang()
        {
            InitializeComponent();
        }

        private void labelX1_Click(object sender, EventArgs e)
        {

        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            texMaKhachHang.Text = "";
            texTenKhachHang.Text = "";
            dateNgaySinh.Text = ""; 
            
        }

        private void LoadDSLoaiNhanVien()
        {
            HienThiLoaiKhachHangBLL hienThiLoaiKhachHangBLL = new HienThiLoaiKhachHangBLL(); 
            for(int i = 0; i < tvPhanLoaiKhachHang.Nodes[0].Nodes[1].Nodes.Count; i++)
            {
                tvPhanLoaiKhachHang.Nodes[0].Nodes[1].Nodes[i].Remove();
            }

            foreach (LoaiKhachHang loaiKhachHang in hienThiLoaiKhachHangBLL.HienThiDanhSachLoaiKhachHang()) 
            {
                TreeNode treeNode = new TreeNode(loaiKhachHang.TenLoaiKhachHang);
                tvPhanLoaiKhachHang.Nodes[0].Nodes[1].Nodes.Add(treeNode);
                cbLoaiKhachHang.Items.Add(loaiKhachHang);
                treeNode.Tag = loaiKhachHang;
            }
        }

        private void UCKhachHang_Load(object sender, EventArgs e)
        {
            LoadDSLoaiNhanVien();
            HienThiDanhSachKhachHang();
            tvPhanLoaiKhachHang.ExpandAll(); 
        }

        private void HienThiDanhSachKhachHang()
        {
            HienThiKhachHangBLL hienThiKhachHangBLL = new HienThiKhachHangBLL(); 
            gvDanhSachKhachHang.Rows.Clear();
            int nam = 0, nu = 0, Tong = 0;
            foreach (KhachHang KhachHang in hienThiKhachHangBLL.HienThiDanhSachKhachHang())
            {
                DataGridViewRow dataGridViewRow = new DataGridViewRow();
                dataGridViewRow.CreateCells(gvDanhSachKhachHang);
                dataGridViewRow.Cells[0].Value = KhachHang.MaKhachHang;
                dataGridViewRow.Cells[1].Value = KhachHang.TenKhachHang;
                dataGridViewRow.Cells[2].Value = KhachHang.NgaySinh.ToString("dd/MM/yyyy");
                dataGridViewRow.Cells[3].Value = KhachHang.GioiTinh;
                dataGridViewRow.Cells[4].Value = KhachHang.DiaChi;
                dataGridViewRow.Cells[5].Value = KhachHang.DienThoai;
                dataGridViewRow.Cells[6].Value = KhachHang.LoaiKhachHang;
                dataGridViewRow.Cells[7].Value = KhachHang.ChungMinhThu;
                gvDanhSachKhachHang.Rows.Add(dataGridViewRow);
                if (KhachHang.GioiTinh == "Nam")
                {
                    nam++;
                }
                if (KhachHang.GioiTinh == "Nữ")
                {
                    nu++;
                }
                Tong++;
            }
            texTong.Text = Tong + "";
            texTongNam.Text = nam + "";
            TexTongNu.Text = nu + "";
        }

        private void gvDanhSachKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex > -1)
            {
                DataGridViewRow dataGridViewRow = gvDanhSachKhachHang.Rows[e.RowIndex];
                texMaKhachHang.Text = dataGridViewRow.Cells[0].Value + "";
                texTenKhachHang.Text = dataGridViewRow.Cells[1].Value + "";
                dateNgaySinh.Value = DoiNgay(dataGridViewRow.Cells[2].Value + ""); 
                cbGioiTinh.Text = dataGridViewRow.Cells[3].Value + "";
                texDiaChi.Text = dataGridViewRow.Cells[4].Value + "";
                texDienThoai.Text = dataGridViewRow.Cells[5].Value + "";
                texSoChungMinh.Text = dataGridViewRow.Cells[6].Value + ""; 
                for(int i = 0; i < cbLoaiKhachHang.Items.Count; i++)
                {
                    LoaiKhachHang loaiKhachHang = cbLoaiKhachHang.Items[i] as LoaiKhachHang;
                    if (loaiKhachHang.TenLoaiKhachHang == dataGridViewRow.Cells[7].Value + "")
                    {
                        cbLoaiKhachHang.SelectedItem = loaiKhachHang; 
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
            if(texMaKhachHang.Text == "" || texMaKhachHang.Text == null)
            {
                MessageBox.Show("Bạn Cần Nhập Mã Khách Hàng Trước Khi Thêm");
                return; 
            }
            else if (cbLoaiKhachHang.SelectedIndex == -1)
            {
                MessageBox.Show("Bạn Cần Chọn Loại Khách Hàng Trước Khi Thêm");
                return;
            }
            else
            {
                HienThiKhachHangBLL hienThiKhachHangBLL = new HienThiKhachHangBLL();
                KhachHang khachHang = new KhachHang()
                {
                    MaKhachHang = texMaKhachHang.Text,
                    TenKhachHang = texTenKhachHang.Text,
                    DiaChi = texDiaChi.Text,
                    ChungMinhThu = texSoChungMinh.Text,
                    DienThoai = texDienThoai.Text,
                    GioiTinh = cbGioiTinh.Text,
                    NgaySinh = dateNgaySinh.Value 
                }; 
                if(cbLoaiKhachHang.SelectedIndex != -1)
                {
                    LoaiKhachHang loaiKhachHang = cbLoaiKhachHang.SelectedItem as LoaiKhachHang;
                    khachHang.LoaiKhachHang = loaiKhachHang.MaLoaiKhachHang; 
                }
                hienThiKhachHangBLL.ThemMoiKhachHang(khachHang);
                if(LKH == null)
                {
                    HienThiDanhSachKhachHang(); 
                }
                else
                {
                    List<KhachHang> DanhSachKhachHang = new List<KhachHang>();
                    DanhSachKhachHang = hienThiKhachHangBLL.HienThiDanhSachKhachHangTheoLoai(LKH.MaLoaiKhachHang);
                    HienThiDanhSachKH(DanhSachKhachHang);
                }
            }
            
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            HienThiKhachHangBLL hienThiKhachHangBLL = new HienThiKhachHangBLL();
            List<KhachHang> DanhSachKhachHang = new List<KhachHang>(); 
            if (radioMaKH.Checked)
            {
                DanhSachKhachHang = hienThiKhachHangBLL.HienThiDanhSachKhachHangTheoMa(texTimKiem.Text);
                HienThiDanhSachKH(DanhSachKhachHang); 
            }
            else if (radioTenKH.Checked)
            {
                DanhSachKhachHang = hienThiKhachHangBLL.HienThiDanhSachKhachHangTheoTen(texTimKiem.Text);
                HienThiDanhSachKH(DanhSachKhachHang);
            }
            else if (radioCMTKH.Checked)
            {
                DanhSachKhachHang = hienThiKhachHangBLL.HienThiDanhSachKhachHangTheoCMT(texTimKiem.Text);
                HienThiDanhSachKH(DanhSachKhachHang);
            }
            else
            {
                MessageBox.Show("Bạn Cần Nhập Lựa Chọn Trước Khi Tìm Kiếm");
            }
        }

        private void HienThiDanhSachKH(List<KhachHang> danhSachKhachHang)
        {
            gvDanhSachKhachHang.Rows.Clear();
            int nam = 0, nu = 0, Tong = 0;
            foreach (KhachHang KhachHang in danhSachKhachHang)
            {
                DataGridViewRow dataGridViewRow = new DataGridViewRow();
                dataGridViewRow.CreateCells(gvDanhSachKhachHang);
                dataGridViewRow.Cells[0].Value = KhachHang.MaKhachHang;
                dataGridViewRow.Cells[1].Value = KhachHang.TenKhachHang;
                dataGridViewRow.Cells[2].Value = KhachHang.NgaySinh.ToString("dd/MM/yyyy");
                dataGridViewRow.Cells[3].Value = KhachHang.GioiTinh;
                dataGridViewRow.Cells[4].Value = KhachHang.DiaChi;
                dataGridViewRow.Cells[5].Value = KhachHang.DienThoai;
                dataGridViewRow.Cells[6].Value = KhachHang.LoaiKhachHang;
                dataGridViewRow.Cells[7].Value = KhachHang.ChungMinhThu;
                gvDanhSachKhachHang.Rows.Add(dataGridViewRow);
                if (KhachHang.GioiTinh == "Nam")
                {
                    nam++;
                }
                if (KhachHang.GioiTinh == "Nữ")
                {
                    nu++;
                }
                Tong++;
            }
            texTong.Text = Tong +"";
            texTongNam.Text = nam + "";
            TexTongNu.Text = nu+ ""; 
            
        }
        private LoaiKhachHang LKH = null; 

        private void tvPhanLoaiKhachHang_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if(e.Node!= null)
            {
                if(e.Node == tvPhanLoaiKhachHang.Nodes[0].Nodes[0])
                {
                    HienThiDanhSachKhachHang();
                   
                }
            }
            if(e.Node.Level == 2)
            {
                LoaiKhachHang loaikhachHang = e.Node.Tag as LoaiKhachHang;
                HienThiKhachHangBLL hienThiKhachHangBLL = new HienThiKhachHangBLL();
                List<KhachHang> DanhSachKhachHang = hienThiKhachHangBLL.HienThiDanhSachKhachHangTheoLoai(loaikhachHang.MaLoaiKhachHang);
                HienThiDanhSachKH(DanhSachKhachHang);
                LKH = loaikhachHang;
               
            }
            else
            {
                LKH = null;
                return; 
                
            }
        }

        private void btnChinhSua_Click(object sender, EventArgs e)
        {
            if (texMaKhachHang.Text == "" || texMaKhachHang.Text == null)
            {
                MessageBox.Show("Bạn Cần Nhập Mã Khách Hàng Trước Khi Thêm");
                return;
            }
            else if (cbLoaiKhachHang.SelectedIndex == -1)
            {
                MessageBox.Show("Bạn Cần Chọn Loại Khách Hàng Trước Khi Thêm");
                return;
            }
            else
            {
                HienThiKhachHangBLL hienThiKhachHangBLL = new HienThiKhachHangBLL();
                KhachHang khachHang = new KhachHang()
                {
                    MaKhachHang = texMaKhachHang.Text,
                    TenKhachHang = texTenKhachHang.Text,
                    DiaChi = texDiaChi.Text,
                    ChungMinhThu = texSoChungMinh.Text,
                    DienThoai = texDienThoai.Text,
                    GioiTinh = cbGioiTinh.Text,
                    NgaySinh = dateNgaySinh.Value
                };
                if (cbLoaiKhachHang.SelectedIndex != -1)
                {
                    LoaiKhachHang loaiKhachHang = cbLoaiKhachHang.SelectedItem as LoaiKhachHang;
                    khachHang.LoaiKhachHang = loaiKhachHang.MaLoaiKhachHang;
                }
                hienThiKhachHangBLL.SuaThongTinKhachHang(khachHang);
                if (LKH == null)
                {
                    HienThiDanhSachKhachHang();
                }
                else
                {
                    List<KhachHang> DanhSachKhachHang = new List<KhachHang>();
                    DanhSachKhachHang = hienThiKhachHangBLL.HienThiDanhSachKhachHangTheoLoai(LKH.MaLoaiKhachHang);
                    HienThiDanhSachKH(DanhSachKhachHang);
                }
            }
        }
    }
}
