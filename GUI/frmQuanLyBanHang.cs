using DevComponents.DotNetBar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmQuanLyBanHang : DevComponents.DotNetBar.Office2007RibbonForm
    {
        public frmQuanLyBanHang()
        {
            InitializeComponent();
        }

        private void frmQuanLyBanHang_Load(object sender, EventArgs e)
        {

        }

        private void DongTab()
        {
            TabItem tabItem = TabHeThong.SelectedTab;
            DialogResult dialogResult = MessageBox.Show("Bạn Có Chắc Chắn Đóng Trang : " + tabItem.Text,
                "Xác Nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                if (TabHeThong.SelectedTabIndex != 0)
                {
                    TabHeThong.Tabs.Remove(tabItem); // xóa theo tab được chọn 
                }
            }
        }

        private void AddNewTab(string NameTab, UserControl userControl)
        {
            foreach (TabItem tabItem in TabHeThong.Tabs)
            {
                if (tabItem.Text == NameTab)
                {
                    TabHeThong.SelectedTab = tabItem;
                    return;
                }
            }
            TabControlPanel tabControlPanel = new TabControlPanel();
        }

        private void addtab(string tabname, UserControl control)
        {
            foreach (TabItem tabPage in TabHeThong.Tabs)
            {
                if (tabPage.Text == tabname)
                {
                    TabHeThong.SelectedTab = tabPage;
                    return;
                }
            }
            TabControlPanel newtabpannel = new DevComponents.DotNetBar.TabControlPanel();
            TabItem newtab = new TabItem(this.components);
            newtabpannel.Dock = System.Windows.Forms.DockStyle.Fill;
            newtabpannel.Location = new System.Drawing.Point(0, 26);
            newtabpannel.Name = tabname;
            newtabpannel.Padding = new System.Windows.Forms.Padding(1);
            newtabpannel.Size = new System.Drawing.Size(1230, 384);
            newtabpannel.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(179)))), ((int)(((byte)(231)))));
            newtabpannel.Style.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(237)))), ((int)(((byte)(254)))));
            newtabpannel.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            newtabpannel.Style.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(97)))), ((int)(((byte)(156)))));
            newtabpannel.Style.BorderSide = ((DevComponents.DotNetBar.eBorderSide)(((DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right)
                                        | DevComponents.DotNetBar.eBorderSide.Bottom)));
            newtabpannel.Style.GradientAngle = 90;
            newtabpannel.TabIndex = 2;

            newtabpannel.TabItem = newtab;
            Random ran = new Random();
            newtab.Name = tabname + ran.Next(100000) + ran.Next(22342);

            newtab.AttachedControl = newtabpannel;
            newtab.Text = tabname;
            newtab.CloseButtonVisible = true;
            control.Dock = DockStyle.Fill;
            newtabpannel.Controls.Add(control);
            TabHeThong.Controls.Add(newtabpannel);
            TabHeThong.Tabs.Add(newtab);
            TabHeThong.SelectedTab = newtab;
        }

        private void ribbonControl1_Click(object sender, EventArgs e)
        {

        }

        private void MenuItemDongTrang_Click(object sender, EventArgs e)
        {
            DongTab();
        }

        private void MenuItemDongTrangKhac_Click(object sender, EventArgs e)
        {
            int index = TabHeThong.SelectedTabIndex;
            DialogResult dialogResult = MessageBox.Show("Bạn Có Muốn Đóng Tất Cả Các Trang Khác", "Xác Nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                for (int i = TabHeThong.Tabs.Count - 1; i > 0; i--)
                {
                    if (index != i)
                    {
                        TabHeThong.Tabs.RemoveAt(i);
                    }
                }
                TabHeThong.Refresh();
            }
        }

        private void MenuItemDongTatCa_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn Có Muốn Đóng Tất Cả Các Trang", "Xác Nhận",
               MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                for (int i = TabHeThong.Tabs.Count - 1; i > 0; i--)
                {
                    TabHeThong.Tabs.RemoveAt(i);
                }
                TabHeThong.Refresh();
            }
        }

        private void MenuItemThoat_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn Muốn Thoát Khỏi Hệ Thống", "Xác Nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnNhaSanSuat_Click(object sender, EventArgs e)
        {
        }

        private void ribbonTabItem1_Click(object sender, EventArgs e)
        {

        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {

        }
    }
}
