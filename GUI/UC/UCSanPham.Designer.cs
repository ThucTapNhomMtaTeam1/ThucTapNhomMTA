namespace GUI.UC
{
    partial class UCSanPham
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Danh Sách ");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Tất Cả Sản Phâm ", new System.Windows.Forms.TreeNode[] {
            treeNode1});
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Kho Hàng ");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Loại Sản Phẩm");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Nhà Phân Phối");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Nhà Sản Xuất");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCSanPham));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dotNetBarKhachHang = new DevComponents.DotNetBar.DotNetBarManager(this.components);
            this.dockSite4 = new DevComponents.DotNetBar.DockSite();
            this.bar2 = new DevComponents.DotNetBar.Bar();
            this.panelDockContainer2 = new DevComponents.DotNetBar.PanelDockContainer();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.panelEx2 = new DevComponents.DotNetBar.PanelEx();
            this.cbLoaiHang = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.cbNhaPhanPhoi = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.cbKhoHang = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.cbNhaSanXuat = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.btnTimKiem = new DevComponents.DotNetBar.ButtonX();
            this.btnXoa = new DevComponents.DotNetBar.ButtonX();
            this.btnChinhSua = new DevComponents.DotNetBar.ButtonX();
            this.btbLuu = new DevComponents.DotNetBar.ButtonX();
            this.btnThemMoi = new DevComponents.DotNetBar.ButtonX();
            this.radioCMT = new System.Windows.Forms.RadioButton();
            this.radioTen = new System.Windows.Forms.RadioButton();
            this.radioMa = new System.Windows.Forms.RadioButton();
            this.textGiaThanh = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.texSoLuong = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.texTenSanPham = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.texTimKiem = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.texMaSanPham = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblTimKiem = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.advPropertyGrid1 = new DevComponents.DotNetBar.AdvPropertyGrid();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.dockChiTietSanPham = new DevComponents.DotNetBar.DockContainerItem();
            this.dockSite1 = new DevComponents.DotNetBar.DockSite();
            this.bar1 = new DevComponents.DotNetBar.Bar();
            this.panelDockContainer1 = new DevComponents.DotNetBar.PanelDockContainer();
            this.tvPhanLoaiSanPham = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panelDockContainer3 = new DevComponents.DotNetBar.PanelDockContainer();
            this.panelEx3 = new DevComponents.DotNetBar.PanelEx();
            this.texTongGiaNhap = new DevComponents.DotNetBar.LabelX();
            this.texTongSP = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.dockPhanLoaiSanPham = new DevComponents.DotNetBar.DockContainerItem();
            this.dockThongKeSanPham = new DevComponents.DotNetBar.DockContainerItem();
            this.dockSite2 = new DevComponents.DotNetBar.DockSite();
            this.dockSite8 = new DevComponents.DotNetBar.DockSite();
            this.dockSite5 = new DevComponents.DotNetBar.DockSite();
            this.dockSite6 = new DevComponents.DotNetBar.DockSite();
            this.dockSite7 = new DevComponents.DotNetBar.DockSite();
            this.dockSite3 = new DevComponents.DotNetBar.DockSite();
            this.gvDanhSachSanPham = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.MaSanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dongia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KhoHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoaiSanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NhaCungCap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nhaSanXuat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.dockSite4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bar2)).BeginInit();
            this.bar2.SuspendLayout();
            this.panelDockContainer2.SuspendLayout();
            this.groupPanel1.SuspendLayout();
            this.panelEx2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.advPropertyGrid1)).BeginInit();
            this.dockSite1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bar1)).BeginInit();
            this.bar1.SuspendLayout();
            this.panelDockContainer1.SuspendLayout();
            this.panelDockContainer3.SuspendLayout();
            this.panelEx3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvDanhSachSanPham)).BeginInit();
            this.SuspendLayout();
            // 
            // dotNetBarKhachHang
            // 
            this.dotNetBarKhachHang.AutoDispatchShortcuts.Add(DevComponents.DotNetBar.eShortcut.F1);
            this.dotNetBarKhachHang.AutoDispatchShortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlC);
            this.dotNetBarKhachHang.AutoDispatchShortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlA);
            this.dotNetBarKhachHang.AutoDispatchShortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlV);
            this.dotNetBarKhachHang.AutoDispatchShortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlX);
            this.dotNetBarKhachHang.AutoDispatchShortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlZ);
            this.dotNetBarKhachHang.AutoDispatchShortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlY);
            this.dotNetBarKhachHang.AutoDispatchShortcuts.Add(DevComponents.DotNetBar.eShortcut.Del);
            this.dotNetBarKhachHang.AutoDispatchShortcuts.Add(DevComponents.DotNetBar.eShortcut.Ins);
            this.dotNetBarKhachHang.BottomDockSite = this.dockSite4;
            this.dotNetBarKhachHang.EnableFullSizeDock = false;
            this.dotNetBarKhachHang.LeftDockSite = this.dockSite1;
            this.dotNetBarKhachHang.ParentForm = null;
            this.dotNetBarKhachHang.ParentUserControl = this;
            this.dotNetBarKhachHang.RightDockSite = this.dockSite2;
            this.dotNetBarKhachHang.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003;
            this.dotNetBarKhachHang.ToolbarBottomDockSite = this.dockSite8;
            this.dotNetBarKhachHang.ToolbarLeftDockSite = this.dockSite5;
            this.dotNetBarKhachHang.ToolbarRightDockSite = this.dockSite6;
            this.dotNetBarKhachHang.ToolbarTopDockSite = this.dockSite7;
            this.dotNetBarKhachHang.TopDockSite = this.dockSite3;
            // 
            // dockSite4
            // 
            this.dockSite4.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.dockSite4.Controls.Add(this.bar2);
            this.dockSite4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dockSite4.DocumentDockContainer = new DevComponents.DotNetBar.DocumentDockContainer(new DevComponents.DotNetBar.DocumentBaseContainer[] {
            ((DevComponents.DotNetBar.DocumentBaseContainer)(new DevComponents.DotNetBar.DocumentBarContainer(this.bar2, 1439, 224)))}, DevComponents.DotNetBar.eOrientation.Vertical);
            this.dockSite4.Location = new System.Drawing.Point(0, 516);
            this.dockSite4.Name = "dockSite4";
            this.dockSite4.Size = new System.Drawing.Size(1439, 227);
            this.dockSite4.TabIndex = 4;
            this.dockSite4.TabStop = false;
            // 
            // bar2
            // 
            this.bar2.AccessibleDescription = "DotNetBar Bar (bar2)";
            this.bar2.AccessibleName = "DotNetBar Bar";
            this.bar2.AccessibleRole = System.Windows.Forms.AccessibleRole.ToolBar;
            this.bar2.AutoSyncBarCaption = true;
            this.bar2.CloseSingleTab = true;
            this.bar2.Controls.Add(this.panelDockContainer2);
            this.bar2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bar2.GrabHandleStyle = DevComponents.DotNetBar.eGrabHandleStyle.Caption;
            this.bar2.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.dockChiTietSanPham});
            this.bar2.LayoutType = DevComponents.DotNetBar.eLayoutType.DockContainer;
            this.bar2.Location = new System.Drawing.Point(0, 3);
            this.bar2.Name = "bar2";
            this.bar2.Size = new System.Drawing.Size(1439, 224);
            this.bar2.Stretch = true;
            this.bar2.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003;
            this.bar2.TabIndex = 0;
            this.bar2.TabStop = false;
            this.bar2.Text = "Chi Tiết Sản Phẩm ";
            // 
            // panelDockContainer2
            // 
            this.panelDockContainer2.Controls.Add(this.groupPanel1);
            this.panelDockContainer2.Controls.Add(this.treeView1);
            this.panelDockContainer2.Location = new System.Drawing.Point(3, 23);
            this.panelDockContainer2.Name = "panelDockContainer2";
            this.panelDockContainer2.Size = new System.Drawing.Size(1433, 198);
            this.panelDockContainer2.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelDockContainer2.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.panelDockContainer2.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.panelDockContainer2.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.panelDockContainer2.Style.GradientAngle = 90;
            this.panelDockContainer2.TabIndex = 0;
            // 
            // groupPanel1
            // 
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.panelEx2);
            this.groupPanel1.Controls.Add(this.advPropertyGrid1);
            this.groupPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupPanel1.Location = new System.Drawing.Point(0, 0);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(1433, 198);
            // 
            // 
            // 
            this.groupPanel1.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel1.Style.BackColorGradientAngle = 90;
            this.groupPanel1.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel1.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderBottomWidth = 1;
            this.groupPanel1.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel1.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderLeftWidth = 1;
            this.groupPanel1.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderRightWidth = 1;
            this.groupPanel1.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderTopWidth = 1;
            this.groupPanel1.Style.CornerDiameter = 4;
            this.groupPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel1.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanel1.TabIndex = 1;
            // 
            // panelEx2
            // 
            this.panelEx2.AutoScroll = true;
            this.panelEx2.AutoScrollMargin = new System.Drawing.Size(100, 100);
            this.panelEx2.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx2.Controls.Add(this.cbLoaiHang);
            this.panelEx2.Controls.Add(this.cbNhaPhanPhoi);
            this.panelEx2.Controls.Add(this.cbKhoHang);
            this.panelEx2.Controls.Add(this.cbNhaSanXuat);
            this.panelEx2.Controls.Add(this.btnTimKiem);
            this.panelEx2.Controls.Add(this.btnXoa);
            this.panelEx2.Controls.Add(this.btnChinhSua);
            this.panelEx2.Controls.Add(this.btbLuu);
            this.panelEx2.Controls.Add(this.btnThemMoi);
            this.panelEx2.Controls.Add(this.radioCMT);
            this.panelEx2.Controls.Add(this.radioTen);
            this.panelEx2.Controls.Add(this.radioMa);
            this.panelEx2.Controls.Add(this.textGiaThanh);
            this.panelEx2.Controls.Add(this.texSoLuong);
            this.panelEx2.Controls.Add(this.texTenSanPham);
            this.panelEx2.Controls.Add(this.texTimKiem);
            this.panelEx2.Controls.Add(this.texMaSanPham);
            this.panelEx2.Controls.Add(this.label9);
            this.panelEx2.Controls.Add(this.label11);
            this.panelEx2.Controls.Add(this.lblTimKiem);
            this.panelEx2.Controls.Add(this.label8);
            this.panelEx2.Controls.Add(this.label10);
            this.panelEx2.Controls.Add(this.label7);
            this.panelEx2.Controls.Add(this.label3);
            this.panelEx2.Controls.Add(this.label2);
            this.panelEx2.Controls.Add(this.label1);
            this.panelEx2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelEx2.Location = new System.Drawing.Point(0, 0);
            this.panelEx2.Name = "panelEx2";
            this.panelEx2.Size = new System.Drawing.Size(1427, 192);
            this.panelEx2.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx2.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx2.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx2.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx2.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx2.Style.GradientAngle = 90;
            this.panelEx2.TabIndex = 3;
            // 
            // cbLoaiHang
            // 
            this.cbLoaiHang.DisplayMember = "Text";
            this.cbLoaiHang.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbLoaiHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLoaiHang.FormattingEnabled = true;
            this.cbLoaiHang.ItemHeight = 16;
            this.cbLoaiHang.Location = new System.Drawing.Point(748, 47);
            this.cbLoaiHang.Name = "cbLoaiHang";
            this.cbLoaiHang.Size = new System.Drawing.Size(207, 22);
            this.cbLoaiHang.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbLoaiHang.TabIndex = 11;
            // 
            // cbNhaPhanPhoi
            // 
            this.cbNhaPhanPhoi.AutoCompleteCustomSource.AddRange(new string[] {
            "Nam "});
            this.cbNhaPhanPhoi.DisplayMember = "Text";
            this.cbNhaPhanPhoi.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbNhaPhanPhoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbNhaPhanPhoi.FormattingEnabled = true;
            this.cbNhaPhanPhoi.ItemHeight = 16;
            this.cbNhaPhanPhoi.Location = new System.Drawing.Point(748, 109);
            this.cbNhaPhanPhoi.Name = "cbNhaPhanPhoi";
            this.cbNhaPhanPhoi.Size = new System.Drawing.Size(207, 22);
            this.cbNhaPhanPhoi.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbNhaPhanPhoi.TabIndex = 11;
            // 
            // cbKhoHang
            // 
            this.cbKhoHang.DisplayMember = "Text";
            this.cbKhoHang.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbKhoHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbKhoHang.FormattingEnabled = true;
            this.cbKhoHang.ItemHeight = 16;
            this.cbKhoHang.Location = new System.Drawing.Point(748, 15);
            this.cbKhoHang.Name = "cbKhoHang";
            this.cbKhoHang.Size = new System.Drawing.Size(207, 22);
            this.cbKhoHang.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbKhoHang.TabIndex = 11;
            // 
            // cbNhaSanXuat
            // 
            this.cbNhaSanXuat.AutoCompleteCustomSource.AddRange(new string[] {
            "Nam "});
            this.cbNhaSanXuat.DisplayMember = "Text";
            this.cbNhaSanXuat.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbNhaSanXuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbNhaSanXuat.FormattingEnabled = true;
            this.cbNhaSanXuat.ItemHeight = 16;
            this.cbNhaSanXuat.Location = new System.Drawing.Point(748, 79);
            this.cbNhaSanXuat.Name = "cbNhaSanXuat";
            this.cbNhaSanXuat.Size = new System.Drawing.Size(207, 22);
            this.cbNhaSanXuat.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbNhaSanXuat.TabIndex = 11;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnTimKiem.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.Image = global::GUI.Properties.Resources.TimKiem;
            this.btnTimKiem.ImageFixedSize = new System.Drawing.Size(25, 25);
            this.btnTimKiem.Location = new System.Drawing.Point(1107, 154);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(104, 30);
            this.btnTimKiem.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnTimKiem.TabIndex = 6;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click_1);
            // 
            // btnXoa
            // 
            this.btnXoa.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnXoa.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Image = global::GUI.Properties.Resources.Actions_window_close_icon1;
            this.btnXoa.ImageFixedSize = new System.Drawing.Size(22, 22);
            this.btnXoa.Location = new System.Drawing.Point(932, 154);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(104, 30);
            this.btnXoa.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnXoa.TabIndex = 7;
            this.btnXoa.Text = "Xóa ";
            this.btnXoa.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnChinhSua
            // 
            this.btnChinhSua.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnChinhSua.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnChinhSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChinhSua.Image = global::GUI.Properties.Resources.bút;
            this.btnChinhSua.ImageFixedSize = new System.Drawing.Size(25, 25);
            this.btnChinhSua.Location = new System.Drawing.Point(748, 154);
            this.btnChinhSua.Name = "btnChinhSua";
            this.btnChinhSua.Size = new System.Drawing.Size(111, 30);
            this.btnChinhSua.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnChinhSua.TabIndex = 8;
            this.btnChinhSua.Text = "Chỉnh Sửa";
            this.btnChinhSua.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left;
            this.btnChinhSua.Click += new System.EventHandler(this.btnChinhSua_Click);
            // 
            // btbLuu
            // 
            this.btbLuu.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btbLuu.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btbLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btbLuu.Image = global::GUI.Properties.Resources.save_as;
            this.btbLuu.ImageFixedSize = new System.Drawing.Size(25, 25);
            this.btbLuu.Location = new System.Drawing.Point(567, 154);
            this.btbLuu.Name = "btbLuu";
            this.btbLuu.Size = new System.Drawing.Size(104, 30);
            this.btbLuu.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btbLuu.TabIndex = 9;
            this.btbLuu.Text = "Lưu ";
            this.btbLuu.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left;
            this.btbLuu.Click += new System.EventHandler(this.btbLuu_Click_1);
            // 
            // btnThemMoi
            // 
            this.btnThemMoi.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnThemMoi.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnThemMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemMoi.Image = global::GUI.Properties.Resources.Add;
            this.btnThemMoi.ImageFixedSize = new System.Drawing.Size(20, 20);
            this.btnThemMoi.Location = new System.Drawing.Point(355, 154);
            this.btnThemMoi.Name = "btnThemMoi";
            this.btnThemMoi.Size = new System.Drawing.Size(104, 30);
            this.btnThemMoi.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnThemMoi.TabIndex = 10;
            this.btnThemMoi.Text = "Thêm Mới";
            this.btnThemMoi.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left;
            // 
            // radioCMT
            // 
            this.radioCMT.AutoSize = true;
            this.radioCMT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioCMT.Location = new System.Drawing.Point(1118, 110);
            this.radioCMT.Name = "radioCMT";
            this.radioCMT.Size = new System.Drawing.Size(185, 20);
            this.radioCMT.TabIndex = 5;
            this.radioCMT.TabStop = true;
            this.radioCMT.Text = "Tìm Theo Số Luong SP";
            this.radioCMT.UseVisualStyleBackColor = true;
            // 
            // radioTen
            // 
            this.radioTen.AutoSize = true;
            this.radioTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioTen.Location = new System.Drawing.Point(1118, 85);
            this.radioTen.Name = "radioTen";
            this.radioTen.Size = new System.Drawing.Size(197, 20);
            this.radioTen.TabIndex = 4;
            this.radioTen.TabStop = true;
            this.radioTen.Text = "Tìm Theo Tên Sản Phẩm";
            this.radioTen.UseVisualStyleBackColor = true;
            // 
            // radioMa
            // 
            this.radioMa.AutoSize = true;
            this.radioMa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioMa.Location = new System.Drawing.Point(1118, 54);
            this.radioMa.Name = "radioMa";
            this.radioMa.Size = new System.Drawing.Size(195, 20);
            this.radioMa.TabIndex = 3;
            this.radioMa.TabStop = true;
            this.radioMa.Text = "Tìm Theo Mã Sản Phẩm ";
            this.radioMa.UseVisualStyleBackColor = true;
            // 
            // textGiaThanh
            // 
            // 
            // 
            // 
            this.textGiaThanh.Border.Class = "TextBoxBorder";
            this.textGiaThanh.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textGiaThanh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textGiaThanh.Location = new System.Drawing.Point(355, 107);
            this.textGiaThanh.Name = "textGiaThanh";
            this.textGiaThanh.Size = new System.Drawing.Size(207, 22);
            this.textGiaThanh.TabIndex = 2;
            // 
            // texSoLuong
            // 
            // 
            // 
            // 
            this.texSoLuong.Border.Class = "TextBoxBorder";
            this.texSoLuong.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.texSoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.texSoLuong.Location = new System.Drawing.Point(355, 75);
            this.texSoLuong.Name = "texSoLuong";
            this.texSoLuong.Size = new System.Drawing.Size(207, 22);
            this.texSoLuong.TabIndex = 2;
            // 
            // texTenSanPham
            // 
            // 
            // 
            // 
            this.texTenSanPham.Border.Class = "TextBoxBorder";
            this.texTenSanPham.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.texTenSanPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.texTenSanPham.Location = new System.Drawing.Point(355, 45);
            this.texTenSanPham.Name = "texTenSanPham";
            this.texTenSanPham.Size = new System.Drawing.Size(207, 22);
            this.texTenSanPham.TabIndex = 2;
            // 
            // texTimKiem
            // 
            // 
            // 
            // 
            this.texTimKiem.Border.Class = "TextBoxBorder";
            this.texTimKiem.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.texTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.texTimKiem.Location = new System.Drawing.Point(1118, 21);
            this.texTimKiem.Name = "texTimKiem";
            this.texTimKiem.Size = new System.Drawing.Size(207, 22);
            this.texTimKiem.TabIndex = 2;
            // 
            // texMaSanPham
            // 
            // 
            // 
            // 
            this.texMaSanPham.Border.Class = "TextBoxBorder";
            this.texMaSanPham.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.texMaSanPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.texMaSanPham.Location = new System.Drawing.Point(355, 18);
            this.texMaSanPham.Name = "texMaSanPham";
            this.texMaSanPham.Size = new System.Drawing.Size(207, 22);
            this.texMaSanPham.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(632, 115);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(110, 16);
            this.label9.TabIndex = 1;
            this.label9.Text = "Nhà Phân Phối";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(632, 85);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(101, 16);
            this.label11.TabIndex = 1;
            this.label11.Text = "Nhà Sản Xuất";
            // 
            // lblTimKiem
            // 
            this.lblTimKiem.AutoSize = true;
            this.lblTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimKiem.Location = new System.Drawing.Point(1036, 26);
            this.lblTimKiem.Name = "lblTimKiem";
            this.lblTimKiem.Size = new System.Drawing.Size(76, 16);
            this.lblTimKiem.TabIndex = 1;
            this.lblTimKiem.Text = "Tìm Kiếm ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(632, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 16);
            this.label8.TabIndex = 0;
            this.label8.Text = "Kho Hàng ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(632, 53);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 16);
            this.label10.TabIndex = 0;
            this.label10.Text = "Loại Hàng ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(238, 107);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 16);
            this.label7.TabIndex = 1;
            this.label7.Text = "Đơn Giá ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(238, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Số Lượng ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(238, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên Sản Phẩm ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(238, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Sản Phẩm ";
            // 
            // advPropertyGrid1
            // 
            this.advPropertyGrid1.GridLinesColor = System.Drawing.Color.WhiteSmoke;
            this.advPropertyGrid1.Location = new System.Drawing.Point(174, 34);
            this.advPropertyGrid1.Name = "advPropertyGrid1";
            this.advPropertyGrid1.Size = new System.Drawing.Size(8, 15);
            this.advPropertyGrid1.TabIndex = 0;
            this.advPropertyGrid1.Text = "advPropertyGrid1";
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(1433, 198);
            this.treeView1.TabIndex = 0;
            // 
            // dockChiTietSanPham
            // 
            this.dockChiTietSanPham.Control = this.panelDockContainer2;
            this.dockChiTietSanPham.Name = "dockChiTietSanPham";
            this.dockChiTietSanPham.Text = "Chi Tiết Sản Phẩm ";
            // 
            // dockSite1
            // 
            this.dockSite1.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.dockSite1.Controls.Add(this.bar1);
            this.dockSite1.Dock = System.Windows.Forms.DockStyle.Left;
            this.dockSite1.DocumentDockContainer = new DevComponents.DotNetBar.DocumentDockContainer(new DevComponents.DotNetBar.DocumentBaseContainer[] {
            ((DevComponents.DotNetBar.DocumentBaseContainer)(new DevComponents.DotNetBar.DocumentBarContainer(this.bar1, 347, 516)))}, DevComponents.DotNetBar.eOrientation.Horizontal);
            this.dockSite1.Location = new System.Drawing.Point(0, 0);
            this.dockSite1.Name = "dockSite1";
            this.dockSite1.Size = new System.Drawing.Size(350, 516);
            this.dockSite1.TabIndex = 1;
            this.dockSite1.TabStop = false;
            // 
            // bar1
            // 
            this.bar1.AccessibleDescription = "DotNetBar Bar (bar1)";
            this.bar1.AccessibleName = "DotNetBar Bar";
            this.bar1.AccessibleRole = System.Windows.Forms.AccessibleRole.ToolBar;
            this.bar1.AutoSyncBarCaption = true;
            this.bar1.CloseSingleTab = true;
            this.bar1.Controls.Add(this.panelDockContainer1);
            this.bar1.Controls.Add(this.panelDockContainer3);
            this.bar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bar1.GrabHandleStyle = DevComponents.DotNetBar.eGrabHandleStyle.Caption;
            this.bar1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.dockPhanLoaiSanPham,
            this.dockThongKeSanPham});
            this.bar1.LayoutType = DevComponents.DotNetBar.eLayoutType.DockContainer;
            this.bar1.Location = new System.Drawing.Point(0, 0);
            this.bar1.Name = "bar1";
            this.bar1.SelectedDockTab = 0;
            this.bar1.Size = new System.Drawing.Size(347, 516);
            this.bar1.Stretch = true;
            this.bar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003;
            this.bar1.TabIndex = 0;
            this.bar1.TabStop = false;
            this.bar1.Text = "Phân Loại Sản Phẩm ";
            // 
            // panelDockContainer1
            // 
            this.panelDockContainer1.Controls.Add(this.tvPhanLoaiSanPham);
            this.panelDockContainer1.Location = new System.Drawing.Point(3, 23);
            this.panelDockContainer1.Name = "panelDockContainer1";
            this.panelDockContainer1.Size = new System.Drawing.Size(341, 465);
            this.panelDockContainer1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelDockContainer1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.panelDockContainer1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.panelDockContainer1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.panelDockContainer1.Style.GradientAngle = 90;
            this.panelDockContainer1.TabIndex = 0;
            // 
            // tvPhanLoaiSanPham
            // 
            this.tvPhanLoaiSanPham.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tvPhanLoaiSanPham.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvPhanLoaiSanPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tvPhanLoaiSanPham.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tvPhanLoaiSanPham.ImageIndex = 0;
            this.tvPhanLoaiSanPham.ImageList = this.imageList1;
            this.tvPhanLoaiSanPham.Location = new System.Drawing.Point(0, 0);
            this.tvPhanLoaiSanPham.Name = "tvPhanLoaiSanPham";
            treeNode1.Name = "DanhSach";
            treeNode1.Text = "Danh Sách ";
            treeNode2.Name = "tatCaSanPham";
            treeNode2.Text = "Tất Cả Sản Phâm ";
            treeNode3.Name = "KhoHang";
            treeNode3.Text = "Kho Hàng ";
            treeNode4.Name = "loaiSanPham";
            treeNode4.Text = "Loại Sản Phẩm";
            treeNode5.Name = "nhaPhanPhoi";
            treeNode5.Text = "Nhà Phân Phối";
            treeNode6.Name = "nhaSanXuat";
            treeNode6.Text = "Nhà Sản Xuất";
            this.tvPhanLoaiSanPham.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode5,
            treeNode6});
            this.tvPhanLoaiSanPham.SelectedImageIndex = 1;
            this.tvPhanLoaiSanPham.Size = new System.Drawing.Size(341, 465);
            this.tvPhanLoaiSanPham.TabIndex = 4;
            this.tvPhanLoaiSanPham.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvPhanLoaiSanPham_AfterSelect);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Documents-icon.png");
            this.imageList1.Images.SetKeyName(1, "Open-512.png");
            // 
            // panelDockContainer3
            // 
            this.panelDockContainer3.Controls.Add(this.panelEx3);
            this.panelDockContainer3.Location = new System.Drawing.Point(3, 23);
            this.panelDockContainer3.Name = "panelDockContainer3";
            this.panelDockContainer3.Size = new System.Drawing.Size(341, 465);
            this.panelDockContainer3.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelDockContainer3.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.panelDockContainer3.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.panelDockContainer3.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.panelDockContainer3.Style.GradientAngle = 90;
            this.panelDockContainer3.TabIndex = 2;
            // 
            // panelEx3
            // 
            this.panelEx3.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx3.Controls.Add(this.texTongGiaNhap);
            this.panelEx3.Controls.Add(this.texTongSP);
            this.panelEx3.Controls.Add(this.labelX2);
            this.panelEx3.Controls.Add(this.labelX1);
            this.panelEx3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx3.Location = new System.Drawing.Point(0, 0);
            this.panelEx3.Name = "panelEx3";
            this.panelEx3.Size = new System.Drawing.Size(341, 465);
            this.panelEx3.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx3.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx3.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx3.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx3.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx3.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx3.Style.GradientAngle = 90;
            this.panelEx3.TabIndex = 1;
            // 
            // texTongGiaNhap
            // 
            this.texTongGiaNhap.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.texTongGiaNhap.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.texTongGiaNhap.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.texTongGiaNhap.Location = new System.Drawing.Point(110, 88);
            this.texTongGiaNhap.Name = "texTongGiaNhap";
            this.texTongGiaNhap.Size = new System.Drawing.Size(129, 23);
            this.texTongGiaNhap.TabIndex = 1;
            this.texTongGiaNhap.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // texTongSP
            // 
            this.texTongSP.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.texTongSP.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.texTongSP.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.texTongSP.Location = new System.Drawing.Point(110, 44);
            this.texTongSP.Name = "texTongSP";
            this.texTongSP.Size = new System.Drawing.Size(129, 23);
            this.texTongSP.TabIndex = 1;
            this.texTongSP.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX2.Location = new System.Drawing.Point(8, 88);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(84, 23);
            this.labelX2.TabIndex = 0;
            this.labelX2.Text = "Tổng Tiền";
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX1.Location = new System.Drawing.Point(8, 44);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(95, 23);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "Tổng Sản Phẩm";
            // 
            // dockPhanLoaiSanPham
            // 
            this.dockPhanLoaiSanPham.Control = this.panelDockContainer1;
            this.dockPhanLoaiSanPham.Name = "dockPhanLoaiSanPham";
            this.dockPhanLoaiSanPham.Text = "Phân Loại Sản Phẩm ";
            // 
            // dockThongKeSanPham
            // 
            this.dockThongKeSanPham.Control = this.panelDockContainer3;
            this.dockThongKeSanPham.Name = "dockThongKeSanPham";
            this.dockThongKeSanPham.Text = "Thống Kê Sản Phẩm ";
            // 
            // dockSite2
            // 
            this.dockSite2.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.dockSite2.Dock = System.Windows.Forms.DockStyle.Right;
            this.dockSite2.DocumentDockContainer = new DevComponents.DotNetBar.DocumentDockContainer();
            this.dockSite2.Location = new System.Drawing.Point(1439, 0);
            this.dockSite2.Name = "dockSite2";
            this.dockSite2.Size = new System.Drawing.Size(0, 516);
            this.dockSite2.TabIndex = 2;
            this.dockSite2.TabStop = false;
            // 
            // dockSite8
            // 
            this.dockSite8.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.dockSite8.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dockSite8.Location = new System.Drawing.Point(0, 743);
            this.dockSite8.Name = "dockSite8";
            this.dockSite8.Size = new System.Drawing.Size(1439, 0);
            this.dockSite8.TabIndex = 8;
            this.dockSite8.TabStop = false;
            // 
            // dockSite5
            // 
            this.dockSite5.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.dockSite5.Dock = System.Windows.Forms.DockStyle.Left;
            this.dockSite5.Location = new System.Drawing.Point(0, 0);
            this.dockSite5.Name = "dockSite5";
            this.dockSite5.Size = new System.Drawing.Size(0, 743);
            this.dockSite5.TabIndex = 5;
            this.dockSite5.TabStop = false;
            // 
            // dockSite6
            // 
            this.dockSite6.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.dockSite6.Dock = System.Windows.Forms.DockStyle.Right;
            this.dockSite6.Location = new System.Drawing.Point(1439, 0);
            this.dockSite6.Name = "dockSite6";
            this.dockSite6.Size = new System.Drawing.Size(0, 743);
            this.dockSite6.TabIndex = 6;
            this.dockSite6.TabStop = false;
            // 
            // dockSite7
            // 
            this.dockSite7.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.dockSite7.Dock = System.Windows.Forms.DockStyle.Top;
            this.dockSite7.Location = new System.Drawing.Point(0, 0);
            this.dockSite7.Name = "dockSite7";
            this.dockSite7.Size = new System.Drawing.Size(1439, 0);
            this.dockSite7.TabIndex = 7;
            this.dockSite7.TabStop = false;
            // 
            // dockSite3
            // 
            this.dockSite3.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.dockSite3.Dock = System.Windows.Forms.DockStyle.Top;
            this.dockSite3.DocumentDockContainer = new DevComponents.DotNetBar.DocumentDockContainer();
            this.dockSite3.Location = new System.Drawing.Point(0, 0);
            this.dockSite3.Name = "dockSite3";
            this.dockSite3.Size = new System.Drawing.Size(1439, 0);
            this.dockSite3.TabIndex = 3;
            this.dockSite3.TabStop = false;
            // 
            // gvDanhSachSanPham
            // 
            this.gvDanhSachSanPham.AllowUserToAddRows = false;
            this.gvDanhSachSanPham.AllowUserToDeleteRows = false;
            this.gvDanhSachSanPham.AllowUserToResizeRows = false;
            this.gvDanhSachSanPham.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvDanhSachSanPham.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvDanhSachSanPham.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gvDanhSachSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvDanhSachSanPham.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSanPham,
            this.TenSanPham,
            this.SoLuong,
            this.dongia,
            this.KhoHang,
            this.LoaiSanPham,
            this.NhaCungCap,
            this.nhaSanXuat});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gvDanhSachSanPham.DefaultCellStyle = dataGridViewCellStyle2;
            this.gvDanhSachSanPham.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvDanhSachSanPham.EnableHeadersVisualStyles = false;
            this.gvDanhSachSanPham.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.gvDanhSachSanPham.Location = new System.Drawing.Point(350, 0);
            this.gvDanhSachSanPham.Name = "gvDanhSachSanPham";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvDanhSachSanPham.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.gvDanhSachSanPham.RowHeadersVisible = false;
            this.gvDanhSachSanPham.Size = new System.Drawing.Size(1089, 516);
            this.gvDanhSachSanPham.TabIndex = 9;
            this.gvDanhSachSanPham.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvDanhSachSanPham_CellClick);
            // 
            // MaSanPham
            // 
            this.MaSanPham.HeaderText = "Mã Sản Phẩm ";
            this.MaSanPham.Name = "MaSanPham";
            // 
            // TenSanPham
            // 
            this.TenSanPham.HeaderText = "Tên Sản Phẩm ";
            this.TenSanPham.Name = "TenSanPham";
            // 
            // SoLuong
            // 
            this.SoLuong.HeaderText = "Số Lượng";
            this.SoLuong.Name = "SoLuong";
            // 
            // dongia
            // 
            this.dongia.HeaderText = "Đơn Giá";
            this.dongia.Name = "dongia";
            // 
            // KhoHang
            // 
            this.KhoHang.HeaderText = "Kho Hàng ";
            this.KhoHang.Name = "KhoHang";
            // 
            // LoaiSanPham
            // 
            this.LoaiSanPham.HeaderText = "Loại Sản Phẩm";
            this.LoaiSanPham.Name = "LoaiSanPham";
            // 
            // NhaCungCap
            // 
            this.NhaCungCap.HeaderText = "Nhà Cung Cấp ";
            this.NhaCungCap.Name = "NhaCungCap";
            // 
            // nhaSanXuat
            // 
            this.nhaSanXuat.HeaderText = "Nhà Sản Xuất";
            this.nhaSanXuat.Name = "nhaSanXuat";
            // 
            // imageList2
            // 
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList2.Images.SetKeyName(0, "catalog-icon.png");
            // 
            // UCSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gvDanhSachSanPham);
            this.Controls.Add(this.dockSite2);
            this.Controls.Add(this.dockSite1);
            this.Controls.Add(this.dockSite3);
            this.Controls.Add(this.dockSite4);
            this.Controls.Add(this.dockSite5);
            this.Controls.Add(this.dockSite6);
            this.Controls.Add(this.dockSite7);
            this.Controls.Add(this.dockSite8);
            this.Name = "UCSanPham";
            this.Size = new System.Drawing.Size(1439, 743);
            this.Load += new System.EventHandler(this.UCSanPham_Load);
            this.dockSite4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bar2)).EndInit();
            this.bar2.ResumeLayout(false);
            this.panelDockContainer2.ResumeLayout(false);
            this.groupPanel1.ResumeLayout(false);
            this.panelEx2.ResumeLayout(false);
            this.panelEx2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.advPropertyGrid1)).EndInit();
            this.dockSite1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bar1)).EndInit();
            this.bar1.ResumeLayout(false);
            this.panelDockContainer1.ResumeLayout(false);
            this.panelDockContainer3.ResumeLayout(false);
            this.panelEx3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvDanhSachSanPham)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.DotNetBarManager dotNetBarKhachHang;
        private DevComponents.DotNetBar.DockSite dockSite4;
        private DevComponents.DotNetBar.DockSite dockSite1;
        private DevComponents.DotNetBar.DockSite dockSite2;
        private DevComponents.DotNetBar.DockSite dockSite3;
        private DevComponents.DotNetBar.DockSite dockSite5;
        private DevComponents.DotNetBar.DockSite dockSite6;
        private DevComponents.DotNetBar.DockSite dockSite7;
        private DevComponents.DotNetBar.DockSite dockSite8;
        private DevComponents.DotNetBar.Controls.DataGridViewX gvDanhSachSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn dongia;
        private System.Windows.Forms.DataGridViewTextBoxColumn KhoHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoaiSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn NhaCungCap;
        private System.Windows.Forms.DataGridViewTextBoxColumn nhaSanXuat;
        private DevComponents.DotNetBar.Bar bar1;
        private DevComponents.DotNetBar.PanelDockContainer panelDockContainer3;
        private DevComponents.DotNetBar.PanelDockContainer panelDockContainer1;
        private DevComponents.DotNetBar.DockContainerItem dockPhanLoaiSanPham;
        private DevComponents.DotNetBar.DockContainerItem dockThongKeSanPham;
        private DevComponents.DotNetBar.Bar bar2;
        private DevComponents.DotNetBar.PanelDockContainer panelDockContainer2;
        private DevComponents.DotNetBar.DockContainerItem dockChiTietSanPham;
        private System.Windows.Forms.TreeView tvPhanLoaiSanPham;
        private System.Windows.Forms.ImageList imageList1;
        private DevComponents.DotNetBar.PanelEx panelEx3;
        private DevComponents.DotNetBar.LabelX texTongGiaNhap;
        private DevComponents.DotNetBar.LabelX texTongSP;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX1;
        private System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.TreeView treeView1;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private DevComponents.DotNetBar.PanelEx panelEx2;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbLoaiHang;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbNhaPhanPhoi;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbKhoHang;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbNhaSanXuat;
        private DevComponents.DotNetBar.ButtonX btnTimKiem;
        private DevComponents.DotNetBar.ButtonX btnXoa;
        private DevComponents.DotNetBar.ButtonX btnChinhSua;
        private DevComponents.DotNetBar.ButtonX btbLuu;
        private DevComponents.DotNetBar.ButtonX btnThemMoi;
        private System.Windows.Forms.RadioButton radioCMT;
        private System.Windows.Forms.RadioButton radioTen;
        private System.Windows.Forms.RadioButton radioMa;
        private DevComponents.DotNetBar.Controls.TextBoxX textGiaThanh;
        private DevComponents.DotNetBar.Controls.TextBoxX texSoLuong;
        private DevComponents.DotNetBar.Controls.TextBoxX texTenSanPham;
        private DevComponents.DotNetBar.Controls.TextBoxX texTimKiem;
        private DevComponents.DotNetBar.Controls.TextBoxX texMaSanPham;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblTimKiem;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevComponents.DotNetBar.AdvPropertyGrid advPropertyGrid1;
    }
}
