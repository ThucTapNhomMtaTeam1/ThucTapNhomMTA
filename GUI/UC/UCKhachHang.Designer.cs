namespace GUI.UC
{
    partial class UCKhachHang
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Tất Cả Khách Hang");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Loại Khách Hàng");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Danh Sách Khách Hàng ", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCKhachHang));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dotNetBarKhachHang = new DevComponents.DotNetBar.DotNetBarManager(this.components);
            this.dockSite4 = new DevComponents.DotNetBar.DockSite();
            this.bar2 = new DevComponents.DotNetBar.Bar();
            this.panelDockContainer2 = new DevComponents.DotNetBar.PanelDockContainer();
            this.panelEx2 = new DevComponents.DotNetBar.PanelEx();
            this.dateNgaySinh = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.cbGioiTinh = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.comboItem3 = new DevComponents.Editors.ComboItem();
            this.comboItem1 = new DevComponents.Editors.ComboItem();
            this.cbLoaiKhachHang = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.btnTimKiem = new DevComponents.DotNetBar.ButtonX();
            this.btnXoa = new DevComponents.DotNetBar.ButtonX();
            this.btnChinhSua = new DevComponents.DotNetBar.ButtonX();
            this.btbLuu = new DevComponents.DotNetBar.ButtonX();
            this.btnThemMoi = new DevComponents.DotNetBar.ButtonX();
            this.radioCMTKH = new System.Windows.Forms.RadioButton();
            this.radioTenKH = new System.Windows.Forms.RadioButton();
            this.radioMaKH = new System.Windows.Forms.RadioButton();
            this.texSoChungMinh = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.texDienThoai = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.texTenKhachHang = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.texTimKiem = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.texDiaChi = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.texMaKhachHang = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblTimKiem = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dockContainerItem2 = new DevComponents.DotNetBar.DockContainerItem();
            this.dockSite1 = new DevComponents.DotNetBar.DockSite();
            this.bar1 = new DevComponents.DotNetBar.Bar();
            this.panelDockContainer1 = new DevComponents.DotNetBar.PanelDockContainer();
            this.tvPhanLoaiKhachHang = new System.Windows.Forms.TreeView();
            this.imgtreekhachhang = new System.Windows.Forms.ImageList(this.components);
            this.panelDockContainer3 = new DevComponents.DotNetBar.PanelDockContainer();
            this.panelEx3 = new DevComponents.DotNetBar.PanelEx();
            this.TexTongNu = new DevComponents.DotNetBar.LabelX();
            this.texTongNam = new DevComponents.DotNetBar.LabelX();
            this.texTong = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.dockLoaiKhachHang = new DevComponents.DotNetBar.DockContainerItem();
            this.dockThongKeKH = new DevComponents.DotNetBar.DockContainerItem();
            this.dockSite2 = new DevComponents.DotNetBar.DockSite();
            this.dockSite8 = new DevComponents.DotNetBar.DockSite();
            this.dockSite5 = new DevComponents.DotNetBar.DockSite();
            this.dockSite6 = new DevComponents.DotNetBar.DockSite();
            this.dockSite7 = new DevComponents.DotNetBar.DockSite();
            this.dockSite3 = new DevComponents.DotNetBar.DockSite();
            this.gvDanhSachKhachHang = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.MaKhachHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenKhachHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DienThoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChungMinhThu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoaiKhachHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dockSite4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bar2)).BeginInit();
            this.bar2.SuspendLayout();
            this.panelDockContainer2.SuspendLayout();
            this.panelEx2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateNgaySinh)).BeginInit();
            this.dockSite1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bar1)).BeginInit();
            this.bar1.SuspendLayout();
            this.panelDockContainer1.SuspendLayout();
            this.panelDockContainer3.SuspendLayout();
            this.panelEx3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvDanhSachKhachHang)).BeginInit();
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
            ((DevComponents.DotNetBar.DocumentBaseContainer)(new DevComponents.DotNetBar.DocumentBarContainer(this.bar2, 1464, 261)))}, DevComponents.DotNetBar.eOrientation.Vertical);
            this.dockSite4.Location = new System.Drawing.Point(0, 510);
            this.dockSite4.Name = "dockSite4";
            this.dockSite4.Size = new System.Drawing.Size(1464, 264);
            this.dockSite4.TabIndex = 14;
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
            this.dockContainerItem2});
            this.bar2.LayoutType = DevComponents.DotNetBar.eLayoutType.DockContainer;
            this.bar2.Location = new System.Drawing.Point(0, 3);
            this.bar2.Name = "bar2";
            this.bar2.Size = new System.Drawing.Size(1464, 261);
            this.bar2.Stretch = true;
            this.bar2.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003;
            this.bar2.TabIndex = 0;
            this.bar2.TabStop = false;
            this.bar2.Text = "dockContainerItem2";
            // 
            // panelDockContainer2
            // 
            this.panelDockContainer2.Controls.Add(this.panelEx2);
            this.panelDockContainer2.Location = new System.Drawing.Point(3, 23);
            this.panelDockContainer2.Name = "panelDockContainer2";
            this.panelDockContainer2.Size = new System.Drawing.Size(1458, 235);
            this.panelDockContainer2.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelDockContainer2.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.panelDockContainer2.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.panelDockContainer2.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.panelDockContainer2.Style.GradientAngle = 90;
            this.panelDockContainer2.TabIndex = 0;
            // 
            // panelEx2
            // 
            this.panelEx2.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx2.Controls.Add(this.dateNgaySinh);
            this.panelEx2.Controls.Add(this.cbGioiTinh);
            this.panelEx2.Controls.Add(this.cbLoaiKhachHang);
            this.panelEx2.Controls.Add(this.btnTimKiem);
            this.panelEx2.Controls.Add(this.btnXoa);
            this.panelEx2.Controls.Add(this.btnChinhSua);
            this.panelEx2.Controls.Add(this.btbLuu);
            this.panelEx2.Controls.Add(this.btnThemMoi);
            this.panelEx2.Controls.Add(this.radioCMTKH);
            this.panelEx2.Controls.Add(this.radioTenKH);
            this.panelEx2.Controls.Add(this.radioMaKH);
            this.panelEx2.Controls.Add(this.texSoChungMinh);
            this.panelEx2.Controls.Add(this.texDienThoai);
            this.panelEx2.Controls.Add(this.texTenKhachHang);
            this.panelEx2.Controls.Add(this.texTimKiem);
            this.panelEx2.Controls.Add(this.texDiaChi);
            this.panelEx2.Controls.Add(this.texMaKhachHang);
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
            this.panelEx2.Size = new System.Drawing.Size(1458, 235);
            this.panelEx2.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx2.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx2.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx2.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx2.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx2.Style.GradientAngle = 90;
            this.panelEx2.TabIndex = 2;
            // 
            // dateNgaySinh
            // 
            // 
            // 
            // 
            this.dateNgaySinh.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dateNgaySinh.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dateNgaySinh.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dateNgaySinh.ButtonDropDown.Visible = true;
            this.dateNgaySinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateNgaySinh.IsPopupCalendarOpen = false;
            this.dateNgaySinh.Location = new System.Drawing.Point(365, 77);
            // 
            // 
            // 
            this.dateNgaySinh.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dateNgaySinh.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dateNgaySinh.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            this.dateNgaySinh.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dateNgaySinh.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dateNgaySinh.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dateNgaySinh.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dateNgaySinh.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dateNgaySinh.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dateNgaySinh.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dateNgaySinh.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dateNgaySinh.MonthCalendar.DisplayMonth = new System.DateTime(2018, 3, 1, 0, 0, 0, 0);
            this.dateNgaySinh.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.dateNgaySinh.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dateNgaySinh.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dateNgaySinh.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dateNgaySinh.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dateNgaySinh.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dateNgaySinh.MonthCalendar.TodayButtonVisible = true;
            this.dateNgaySinh.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.dateNgaySinh.Name = "dateNgaySinh";
            this.dateNgaySinh.Size = new System.Drawing.Size(207, 22);
            this.dateNgaySinh.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dateNgaySinh.TabIndex = 12;
            // 
            // cbGioiTinh
            // 
            this.cbGioiTinh.AutoCompleteCustomSource.AddRange(new string[] {
            "Nam "});
            this.cbGioiTinh.DisplayMember = "Text";
            this.cbGioiTinh.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbGioiTinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbGioiTinh.FormattingEnabled = true;
            this.cbGioiTinh.ItemHeight = 16;
            this.cbGioiTinh.Items.AddRange(new object[] {
            this.comboItem3,
            this.comboItem1});
            this.cbGioiTinh.Location = new System.Drawing.Point(365, 107);
            this.cbGioiTinh.Name = "cbGioiTinh";
            this.cbGioiTinh.Size = new System.Drawing.Size(207, 22);
            this.cbGioiTinh.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbGioiTinh.TabIndex = 11;
            // 
            // comboItem3
            // 
            this.comboItem3.Text = "Nam ";
            // 
            // comboItem1
            // 
            this.comboItem1.Text = "Nữ";
            // 
            // cbLoaiKhachHang
            // 
            this.cbLoaiKhachHang.AutoCompleteCustomSource.AddRange(new string[] {
            "Nam "});
            this.cbLoaiKhachHang.DisplayMember = "Text";
            this.cbLoaiKhachHang.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbLoaiKhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLoaiKhachHang.FormattingEnabled = true;
            this.cbLoaiKhachHang.ItemHeight = 16;
            this.cbLoaiKhachHang.Location = new System.Drawing.Point(763, 108);
            this.cbLoaiKhachHang.Name = "cbLoaiKhachHang";
            this.cbLoaiKhachHang.Size = new System.Drawing.Size(207, 22);
            this.cbLoaiKhachHang.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbLoaiKhachHang.TabIndex = 11;
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
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
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
            this.btbLuu.Click += new System.EventHandler(this.btbLuu_Click);
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
            this.btnThemMoi.Click += new System.EventHandler(this.btnThemMoi_Click);
            // 
            // radioCMTKH
            // 
            this.radioCMTKH.AutoSize = true;
            this.radioCMTKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioCMTKH.Location = new System.Drawing.Point(1118, 110);
            this.radioCMTKH.Name = "radioCMTKH";
            this.radioCMTKH.Size = new System.Drawing.Size(198, 20);
            this.radioCMTKH.TabIndex = 5;
            this.radioCMTKH.TabStop = true;
            this.radioCMTKH.Text = "Tìm Theo Số Chứng Minh";
            this.radioCMTKH.UseVisualStyleBackColor = true;
            // 
            // radioTenKH
            // 
            this.radioTenKH.AutoSize = true;
            this.radioTenKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioTenKH.Location = new System.Drawing.Point(1118, 85);
            this.radioTenKH.Name = "radioTenKH";
            this.radioTenKH.Size = new System.Drawing.Size(210, 20);
            this.radioTenKH.TabIndex = 4;
            this.radioTenKH.TabStop = true;
            this.radioTenKH.Text = "Tìm Theo Tên Khách Hàng";
            this.radioTenKH.UseVisualStyleBackColor = true;
            // 
            // radioMaKH
            // 
            this.radioMaKH.AutoSize = true;
            this.radioMaKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioMaKH.Location = new System.Drawing.Point(1118, 54);
            this.radioMaKH.Name = "radioMaKH";
            this.radioMaKH.Size = new System.Drawing.Size(204, 20);
            this.radioMaKH.TabIndex = 3;
            this.radioMaKH.TabStop = true;
            this.radioMaKH.Text = "Tìm Theo Mã Khách Hàng";
            this.radioMaKH.UseVisualStyleBackColor = true;
            // 
            // texSoChungMinh
            // 
            // 
            // 
            // 
            this.texSoChungMinh.Border.Class = "TextBoxBorder";
            this.texSoChungMinh.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.texSoChungMinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.texSoChungMinh.Location = new System.Drawing.Point(763, 79);
            this.texSoChungMinh.Name = "texSoChungMinh";
            this.texSoChungMinh.Size = new System.Drawing.Size(207, 22);
            this.texSoChungMinh.TabIndex = 2;
            // 
            // texDienThoai
            // 
            // 
            // 
            // 
            this.texDienThoai.Border.Class = "TextBoxBorder";
            this.texDienThoai.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.texDienThoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.texDienThoai.Location = new System.Drawing.Point(763, 48);
            this.texDienThoai.Name = "texDienThoai";
            this.texDienThoai.Size = new System.Drawing.Size(207, 22);
            this.texDienThoai.TabIndex = 2;
            // 
            // texTenKhachHang
            // 
            // 
            // 
            // 
            this.texTenKhachHang.Border.Class = "TextBoxBorder";
            this.texTenKhachHang.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.texTenKhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.texTenKhachHang.Location = new System.Drawing.Point(365, 45);
            this.texTenKhachHang.Name = "texTenKhachHang";
            this.texTenKhachHang.Size = new System.Drawing.Size(207, 22);
            this.texTenKhachHang.TabIndex = 2;
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
            // texDiaChi
            // 
            // 
            // 
            // 
            this.texDiaChi.Border.Class = "TextBoxBorder";
            this.texDiaChi.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.texDiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.texDiaChi.Location = new System.Drawing.Point(763, 21);
            this.texDiaChi.Name = "texDiaChi";
            this.texDiaChi.Size = new System.Drawing.Size(207, 22);
            this.texDiaChi.TabIndex = 2;
            // 
            // texMaKhachHang
            // 
            // 
            // 
            // 
            this.texMaKhachHang.Border.Class = "TextBoxBorder";
            this.texMaKhachHang.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.texMaKhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.texMaKhachHang.Location = new System.Drawing.Point(365, 18);
            this.texMaKhachHang.Name = "texMaKhachHang";
            this.texMaKhachHang.Size = new System.Drawing.Size(207, 22);
            this.texMaKhachHang.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(632, 115);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(125, 16);
            this.label9.TabIndex = 1;
            this.label9.Text = "Loại Khách Hàng";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(632, 85);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(110, 16);
            this.label11.TabIndex = 1;
            this.label11.Text = "Số Chứng Minh";
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
            this.label8.Size = new System.Drawing.Size(61, 16);
            this.label8.TabIndex = 0;
            this.label8.Text = "Địa Chỉ ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(632, 53);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(87, 16);
            this.label10.TabIndex = 0;
            this.label10.Text = "Điện Thoại ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(238, 107);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 16);
            this.label7.TabIndex = 1;
            this.label7.Text = "Giới Tính ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(238, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Ngày Sinh ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(238, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên Khách Hàng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(238, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Khách Hàng";
            // 
            // dockContainerItem2
            // 
            this.dockContainerItem2.Control = this.panelDockContainer2;
            this.dockContainerItem2.Name = "dockContainerItem2";
            this.dockContainerItem2.Text = "dockContainerItem2";
            // 
            // dockSite1
            // 
            this.dockSite1.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.dockSite1.Controls.Add(this.bar1);
            this.dockSite1.Dock = System.Windows.Forms.DockStyle.Left;
            this.dockSite1.DocumentDockContainer = new DevComponents.DotNetBar.DocumentDockContainer(new DevComponents.DotNetBar.DocumentBaseContainer[] {
            ((DevComponents.DotNetBar.DocumentBaseContainer)(new DevComponents.DotNetBar.DocumentBarContainer(this.bar1, 301, 510)))}, DevComponents.DotNetBar.eOrientation.Horizontal);
            this.dockSite1.Location = new System.Drawing.Point(0, 0);
            this.dockSite1.Name = "dockSite1";
            this.dockSite1.Size = new System.Drawing.Size(304, 510);
            this.dockSite1.TabIndex = 11;
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
            this.dockLoaiKhachHang,
            this.dockThongKeKH});
            this.bar1.LayoutType = DevComponents.DotNetBar.eLayoutType.DockContainer;
            this.bar1.Location = new System.Drawing.Point(0, 0);
            this.bar1.Name = "bar1";
            this.bar1.SelectedDockTab = 0;
            this.bar1.Size = new System.Drawing.Size(301, 510);
            this.bar1.Stretch = true;
            this.bar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003;
            this.bar1.TabIndex = 0;
            this.bar1.TabStop = false;
            this.bar1.Text = "Loại Khách Hàng";
            // 
            // panelDockContainer1
            // 
            this.panelDockContainer1.Controls.Add(this.tvPhanLoaiKhachHang);
            this.panelDockContainer1.Location = new System.Drawing.Point(3, 23);
            this.panelDockContainer1.Name = "panelDockContainer1";
            this.panelDockContainer1.Size = new System.Drawing.Size(295, 459);
            this.panelDockContainer1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelDockContainer1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.panelDockContainer1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.panelDockContainer1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.panelDockContainer1.Style.GradientAngle = 90;
            this.panelDockContainer1.TabIndex = 0;
            // 
            // tvPhanLoaiKhachHang
            // 
            this.tvPhanLoaiKhachHang.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tvPhanLoaiKhachHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvPhanLoaiKhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tvPhanLoaiKhachHang.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tvPhanLoaiKhachHang.ImageIndex = 0;
            this.tvPhanLoaiKhachHang.ImageList = this.imgtreekhachhang;
            this.tvPhanLoaiKhachHang.Location = new System.Drawing.Point(0, 0);
            this.tvPhanLoaiKhachHang.Name = "tvPhanLoaiKhachHang";
            treeNode1.Name = "TatCa";
            treeNode1.Text = "Tất Cả Khách Hang";
            treeNode2.Name = "LoaiKhachHang";
            treeNode2.Text = "Loại Khách Hàng";
            treeNode3.Name = "DanhSachKhachHang";
            treeNode3.Text = "Danh Sách Khách Hàng ";
            this.tvPhanLoaiKhachHang.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode3});
            this.tvPhanLoaiKhachHang.SelectedImageIndex = 2;
            this.tvPhanLoaiKhachHang.Size = new System.Drawing.Size(295, 459);
            this.tvPhanLoaiKhachHang.TabIndex = 5;
            this.tvPhanLoaiKhachHang.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvPhanLoaiKhachHang_AfterSelect);
            // 
            // imgtreekhachhang
            // 
            this.imgtreekhachhang.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgtreekhachhang.ImageStream")));
            this.imgtreekhachhang.TransparentColor = System.Drawing.Color.Transparent;
            this.imgtreekhachhang.Images.SetKeyName(0, "Documents-icon.png");
            this.imgtreekhachhang.Images.SetKeyName(1, "Hopstarter-Mac-Folders-Documents.ico");
            this.imgtreekhachhang.Images.SetKeyName(2, "Open-512.png");
            // 
            // panelDockContainer3
            // 
            this.panelDockContainer3.Controls.Add(this.panelEx3);
            this.panelDockContainer3.Location = new System.Drawing.Point(3, 23);
            this.panelDockContainer3.Name = "panelDockContainer3";
            this.panelDockContainer3.Size = new System.Drawing.Size(295, 459);
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
            this.panelEx3.Controls.Add(this.TexTongNu);
            this.panelEx3.Controls.Add(this.texTongNam);
            this.panelEx3.Controls.Add(this.texTong);
            this.panelEx3.Controls.Add(this.labelX3);
            this.panelEx3.Controls.Add(this.labelX2);
            this.panelEx3.Controls.Add(this.labelX1);
            this.panelEx3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx3.Location = new System.Drawing.Point(0, 0);
            this.panelEx3.Name = "panelEx3";
            this.panelEx3.Size = new System.Drawing.Size(295, 459);
            this.panelEx3.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx3.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx3.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx3.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx3.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx3.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx3.Style.GradientAngle = 90;
            this.panelEx3.TabIndex = 1;
            // 
            // TexTongNu
            // 
            this.TexTongNu.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.TexTongNu.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TexTongNu.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TexTongNu.Location = new System.Drawing.Point(99, 130);
            this.TexTongNu.Name = "TexTongNu";
            this.TexTongNu.Size = new System.Drawing.Size(129, 23);
            this.TexTongNu.TabIndex = 1;
            this.TexTongNu.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // texTongNam
            // 
            this.texTongNam.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.texTongNam.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.texTongNam.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.texTongNam.Location = new System.Drawing.Point(99, 88);
            this.texTongNam.Name = "texTongNam";
            this.texTongNam.Size = new System.Drawing.Size(129, 23);
            this.texTongNam.TabIndex = 1;
            this.texTongNam.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // texTong
            // 
            this.texTong.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.texTong.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.texTong.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.texTong.Location = new System.Drawing.Point(99, 43);
            this.texTong.Name = "texTong";
            this.texTong.Size = new System.Drawing.Size(129, 23);
            this.texTong.TabIndex = 1;
            this.texTong.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX3.Location = new System.Drawing.Point(8, 130);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(59, 23);
            this.labelX3.TabIndex = 0;
            this.labelX3.Text = "Tổng Nữ ";
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
            this.labelX2.Size = new System.Drawing.Size(75, 23);
            this.labelX2.TabIndex = 0;
            this.labelX2.Text = "Tổng Nam ";
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX1.Location = new System.Drawing.Point(8, 43);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(104, 23);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "Tổng KH";
            this.labelX1.Click += new System.EventHandler(this.labelX1_Click);
            // 
            // dockLoaiKhachHang
            // 
            this.dockLoaiKhachHang.Control = this.panelDockContainer1;
            this.dockLoaiKhachHang.Name = "dockLoaiKhachHang";
            this.dockLoaiKhachHang.Text = "Loại Khách Hàng";
            // 
            // dockThongKeKH
            // 
            this.dockThongKeKH.Control = this.panelDockContainer3;
            this.dockThongKeKH.Name = "dockThongKeKH";
            this.dockThongKeKH.Text = "Thống Kê Khách Hàng";
            // 
            // dockSite2
            // 
            this.dockSite2.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.dockSite2.Dock = System.Windows.Forms.DockStyle.Right;
            this.dockSite2.DocumentDockContainer = new DevComponents.DotNetBar.DocumentDockContainer();
            this.dockSite2.Location = new System.Drawing.Point(1464, 0);
            this.dockSite2.Name = "dockSite2";
            this.dockSite2.Size = new System.Drawing.Size(0, 510);
            this.dockSite2.TabIndex = 12;
            this.dockSite2.TabStop = false;
            // 
            // dockSite8
            // 
            this.dockSite8.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.dockSite8.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dockSite8.Location = new System.Drawing.Point(0, 774);
            this.dockSite8.Name = "dockSite8";
            this.dockSite8.Size = new System.Drawing.Size(1464, 0);
            this.dockSite8.TabIndex = 18;
            this.dockSite8.TabStop = false;
            // 
            // dockSite5
            // 
            this.dockSite5.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.dockSite5.Dock = System.Windows.Forms.DockStyle.Left;
            this.dockSite5.Location = new System.Drawing.Point(0, 0);
            this.dockSite5.Name = "dockSite5";
            this.dockSite5.Size = new System.Drawing.Size(0, 774);
            this.dockSite5.TabIndex = 15;
            this.dockSite5.TabStop = false;
            // 
            // dockSite6
            // 
            this.dockSite6.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.dockSite6.Dock = System.Windows.Forms.DockStyle.Right;
            this.dockSite6.Location = new System.Drawing.Point(1464, 0);
            this.dockSite6.Name = "dockSite6";
            this.dockSite6.Size = new System.Drawing.Size(0, 774);
            this.dockSite6.TabIndex = 16;
            this.dockSite6.TabStop = false;
            // 
            // dockSite7
            // 
            this.dockSite7.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.dockSite7.Dock = System.Windows.Forms.DockStyle.Top;
            this.dockSite7.Location = new System.Drawing.Point(0, 0);
            this.dockSite7.Name = "dockSite7";
            this.dockSite7.Size = new System.Drawing.Size(1464, 0);
            this.dockSite7.TabIndex = 17;
            this.dockSite7.TabStop = false;
            // 
            // dockSite3
            // 
            this.dockSite3.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.dockSite3.Dock = System.Windows.Forms.DockStyle.Top;
            this.dockSite3.DocumentDockContainer = new DevComponents.DotNetBar.DocumentDockContainer();
            this.dockSite3.Location = new System.Drawing.Point(0, 0);
            this.dockSite3.Name = "dockSite3";
            this.dockSite3.Size = new System.Drawing.Size(1464, 0);
            this.dockSite3.TabIndex = 13;
            this.dockSite3.TabStop = false;
            // 
            // gvDanhSachKhachHang
            // 
            this.gvDanhSachKhachHang.AllowUserToAddRows = false;
            this.gvDanhSachKhachHang.AllowUserToDeleteRows = false;
            this.gvDanhSachKhachHang.AllowUserToResizeRows = false;
            this.gvDanhSachKhachHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvDanhSachKhachHang.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvDanhSachKhachHang.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.gvDanhSachKhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvDanhSachKhachHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaKhachHang,
            this.TenKhachHang,
            this.NgaySinh,
            this.gioiTinh,
            this.DiaChi,
            this.DienThoai,
            this.ChungMinhThu,
            this.LoaiKhachHang});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gvDanhSachKhachHang.DefaultCellStyle = dataGridViewCellStyle8;
            this.gvDanhSachKhachHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvDanhSachKhachHang.EnableHeadersVisualStyles = false;
            this.gvDanhSachKhachHang.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.gvDanhSachKhachHang.Location = new System.Drawing.Point(304, 0);
            this.gvDanhSachKhachHang.Name = "gvDanhSachKhachHang";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvDanhSachKhachHang.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.gvDanhSachKhachHang.RowHeadersVisible = false;
            this.gvDanhSachKhachHang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvDanhSachKhachHang.Size = new System.Drawing.Size(1160, 510);
            this.gvDanhSachKhachHang.TabIndex = 19;
            this.gvDanhSachKhachHang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvDanhSachKhachHang_CellClick);
            // 
            // MaKhachHang
            // 
            this.MaKhachHang.HeaderText = "Mã Khách Hàng ";
            this.MaKhachHang.Name = "MaKhachHang";
            // 
            // TenKhachHang
            // 
            this.TenKhachHang.HeaderText = "Tên Khách Hàng ";
            this.TenKhachHang.Name = "TenKhachHang";
            // 
            // NgaySinh
            // 
            this.NgaySinh.HeaderText = "Ngày Sinh ";
            this.NgaySinh.Name = "NgaySinh";
            // 
            // gioiTinh
            // 
            this.gioiTinh.HeaderText = "Giới Tính";
            this.gioiTinh.Name = "gioiTinh";
            // 
            // DiaChi
            // 
            this.DiaChi.HeaderText = "Địa Chỉ ";
            this.DiaChi.Name = "DiaChi";
            // 
            // DienThoai
            // 
            this.DienThoai.HeaderText = "Điện Thoại";
            this.DienThoai.Name = "DienThoai";
            // 
            // ChungMinhThu
            // 
            this.ChungMinhThu.HeaderText = "Chứng Minh Thư";
            this.ChungMinhThu.Name = "ChungMinhThu";
            // 
            // LoaiKhachHang
            // 
            this.LoaiKhachHang.HeaderText = "Loại Khách Hàng";
            this.LoaiKhachHang.Name = "LoaiKhachHang";
            // 
            // UCKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gvDanhSachKhachHang);
            this.Controls.Add(this.dockSite2);
            this.Controls.Add(this.dockSite1);
            this.Controls.Add(this.dockSite3);
            this.Controls.Add(this.dockSite4);
            this.Controls.Add(this.dockSite5);
            this.Controls.Add(this.dockSite6);
            this.Controls.Add(this.dockSite7);
            this.Controls.Add(this.dockSite8);
            this.Name = "UCKhachHang";
            this.Size = new System.Drawing.Size(1464, 774);
            this.Load += new System.EventHandler(this.UCKhachHang_Load);
            this.dockSite4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bar2)).EndInit();
            this.bar2.ResumeLayout(false);
            this.panelDockContainer2.ResumeLayout(false);
            this.panelEx2.ResumeLayout(false);
            this.panelEx2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateNgaySinh)).EndInit();
            this.dockSite1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bar1)).EndInit();
            this.bar1.ResumeLayout(false);
            this.panelDockContainer1.ResumeLayout(false);
            this.panelDockContainer3.ResumeLayout(false);
            this.panelEx3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvDanhSachKhachHang)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.DotNetBarManager dotNetBarKhachHang;
        private DevComponents.DotNetBar.DockSite dockSite4;
        private DevComponents.DotNetBar.Bar bar2;
        private DevComponents.DotNetBar.PanelDockContainer panelDockContainer2;
        private DevComponents.DotNetBar.DockContainerItem dockContainerItem2;
        private DevComponents.DotNetBar.DockSite dockSite1;
        private DevComponents.DotNetBar.Bar bar1;
        private DevComponents.DotNetBar.PanelDockContainer panelDockContainer3;
        private DevComponents.DotNetBar.PanelDockContainer panelDockContainer1;
        private DevComponents.DotNetBar.DockContainerItem dockLoaiKhachHang;
        private DevComponents.DotNetBar.DockContainerItem dockThongKeKH;
        private DevComponents.DotNetBar.Controls.DataGridViewX gvDanhSachKhachHang;
        private DevComponents.DotNetBar.DockSite dockSite2;
        private DevComponents.DotNetBar.DockSite dockSite3;
        private DevComponents.DotNetBar.DockSite dockSite5;
        private DevComponents.DotNetBar.DockSite dockSite6;
        private DevComponents.DotNetBar.DockSite dockSite7;
        private DevComponents.DotNetBar.DockSite dockSite8;
        private DevComponents.DotNetBar.PanelEx panelEx2;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dateNgaySinh;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbGioiTinh;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbLoaiKhachHang;
        private DevComponents.DotNetBar.ButtonX btnTimKiem;
        private DevComponents.DotNetBar.ButtonX btnXoa;
        private DevComponents.DotNetBar.ButtonX btnChinhSua;
        private DevComponents.DotNetBar.ButtonX btbLuu;
        private DevComponents.DotNetBar.ButtonX btnThemMoi;
        private System.Windows.Forms.RadioButton radioCMTKH;
        private System.Windows.Forms.RadioButton radioTenKH;
        private System.Windows.Forms.RadioButton radioMaKH;
        private DevComponents.DotNetBar.Controls.TextBoxX texSoChungMinh;
        private DevComponents.DotNetBar.Controls.TextBoxX texDienThoai;
        private DevComponents.DotNetBar.Controls.TextBoxX texTenKhachHang;
        private DevComponents.DotNetBar.Controls.TextBoxX texTimKiem;
        private DevComponents.DotNetBar.Controls.TextBoxX texDiaChi;
        private DevComponents.DotNetBar.Controls.TextBoxX texMaKhachHang;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblTimKiem;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TreeView tvPhanLoaiKhachHang;
        private System.Windows.Forms.ImageList imgtreekhachhang;
        private DevComponents.DotNetBar.PanelEx panelEx3;
        private DevComponents.DotNetBar.LabelX TexTongNu;
        private DevComponents.DotNetBar.LabelX texTongNam;
        private DevComponents.DotNetBar.LabelX texTong;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.Editors.ComboItem comboItem3;
        private DevComponents.Editors.ComboItem comboItem1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKhachHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenKhachHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn gioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn DienThoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChungMinhThu;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoaiKhachHang;
    }
}
