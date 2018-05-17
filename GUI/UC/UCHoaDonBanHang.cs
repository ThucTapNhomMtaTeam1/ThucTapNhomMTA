using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DTO;

namespace GUI.UC
{
    public partial class UCHoaDonBanHang : UserControl
    {
        public UCHoaDonBanHang()
        {
            InitializeComponent();
        }
        private void HienThiCacNamTreeView()
        {
            for (int i = 1; i < tvPhanLoaiHoaDon.Nodes.Count; i++)
            {
                for (int j = 0; j < tvPhanLoaiHoaDon.Nodes[i].Nodes.Count; j++)
                {
                    tvPhanLoaiHoaDon.Nodes[i].Nodes[j].Remove();
                }
            }
            LayNgayThangBLL layNgayThangBLL = new LayNgayThangBLL();

            foreach (NgayThang ngayThang in layNgayThangBLL.LayDanhSachCacNamPN())
            {
                string str1 = "Năm " + ngayThang.NgayThangNam.Year;
                TreeNode treeNode1 = new TreeNode(str1);
                foreach (NgayThang Thang in layNgayThangBLL.LayDanhSachCacThangTheoNamPN(ngayThang.NgayThangNam))
                {
                    string str2 = "Thang " + Thang.NgayThangNam.Month;
                    TreeNode treeNode2 = new TreeNode(str2);
                    DateTime dateTime = new DateTime(ngayThang.NgayThangNam.Year, Thang.NgayThangNam.Month, 1);
                    foreach (NgayThang Ngay in layNgayThangBLL.LayDanhSachCacNgayTheoThangNamPN(dateTime))
                    {
                        string str3 = "Ngày " + Ngay.NgayThangNam.Day;
                        TreeNode treeNode3 = new TreeNode(str3);
                        treeNode2.Nodes.Add(treeNode3);
                        NgayThang Date = new NgayThang()
                        {
                            NgayThangNam = new DateTime
                            (
                                ngayThang.NgayThangNam.Year,
                                Thang.NgayThangNam.Month,
                                Ngay.NgayThangNam.Day
                            )
                        };
                        treeNode3.Tag = Date;
                    }
                    treeNode1.Nodes.Add(treeNode2);
                }
                tvPhanLoaiHoaDon.Nodes[0].Nodes.Add(treeNode1);

            }
        }
    




            private void labelX3_Click(object sender, EventArgs e)
        {

        }

        private void labelX15_Click(object sender, EventArgs e)
        {

        }

        private void labelX21_Click(object sender, EventArgs e)
        {

        }

        private void labelX2_Click(object sender, EventArgs e)
        {

        }

        private void panelEx3_Click(object sender, EventArgs e)
        {

        }

        private void btnSuaSP_Click(object sender, EventArgs e)
        {

        }

        private void btnLLuuSP_Click(object sender, EventArgs e)
        {

        }

        private void cbKhoHang_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {

        }
    }
}
