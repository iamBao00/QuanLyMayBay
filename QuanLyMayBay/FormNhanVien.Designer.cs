namespace QuanLyMayBay
{
    partial class FormNhanVien
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label mANVLabel;
            System.Windows.Forms.Label cALabel;
            System.Windows.Forms.Label lUONGLabel;
            System.Windows.Forms.Label sOCMNDLabel;
            System.Windows.Forms.Label hOTENLabel;
            System.Windows.Forms.Label sODIENTHOAILabel;
            System.Windows.Forms.Label label1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNhanVien));
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.bar4 = new DevExpress.XtraBars.Bar();
            this.bar5 = new DevExpress.XtraBars.Bar();
            this.bar6 = new DevExpress.XtraBars.Bar();
            this.bar7 = new DevExpress.XtraBars.Bar();
            this.bar8 = new DevExpress.XtraBars.Bar();
            this.bar9 = new DevExpress.XtraBars.Bar();
            this.bar10 = new DevExpress.XtraBars.Bar();
            this.bar11 = new DevExpress.XtraBars.Bar();
            this.barDockControl6 = new DevExpress.XtraBars.BarDockControl();
            this.barManager2 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar12 = new DevExpress.XtraBars.Bar();
            this.btnThem = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoa = new DevExpress.XtraBars.BarButtonItem();
            this.btnSua = new DevExpress.XtraBars.BarButtonItem();
            this.btnGhi = new DevExpress.XtraBars.BarButtonItem();
            this.btnHuy = new DevExpress.XtraBars.BarButtonItem();
            this.btnReload = new DevExpress.XtraBars.BarButtonItem();
            this.btnThoat = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControl4 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl5 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl8 = new DevExpress.XtraBars.BarDockControl();
            this.barButtonItem11 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem7 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem10 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem9 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem8 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem6 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem5 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonPX = new DevExpress.XtraBars.BarButtonItem();
            this.btnReloadPX = new DevExpress.XtraBars.BarButtonItem();
            this.btnPhucHoiPX = new DevExpress.XtraBars.BarButtonItem();
            this.btnHuyPX = new DevExpress.XtraBars.BarButtonItem();
            this.btnGhiPX = new DevExpress.XtraBars.BarButtonItem();
            this.btnSuaPX = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoaPX = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.btnThemPX = new DevExpress.XtraBars.BarButtonItem();
            this.btnThoatPX = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControl2 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl1 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl10 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl7 = new DevExpress.XtraBars.BarDockControl();
            this.dS = new QuanLyMayBay.DS();
            this.bds_ThongTinNhanVien = new System.Windows.Forms.BindingSource(this.components);
            this.thongTinNhanVienTableAdapter = new QuanLyMayBay.DSTableAdapters.ThongTinNhanVienTableAdapter();
            this.tableAdapterManager = new QuanLyMayBay.DSTableAdapters.TableAdapterManager();
            this.GC_TTNV = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMANV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLUONG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOCMND = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHOTEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDIACHI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSODIENTHOAI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.txtSDT = new DevExpress.XtraEditors.TextEdit();
            this.txtHoTen = new DevExpress.XtraEditors.TextEdit();
            this.txtDiaChi = new DevExpress.XtraEditors.TextEdit();
            this.txtCMND = new DevExpress.XtraEditors.TextEdit();
            this.txtLuong = new System.Windows.Forms.TextBox();
            this.txtCa = new DevExpress.XtraEditors.TextEdit();
            this.txtMaNV = new DevExpress.XtraEditors.TextEdit();
            this.bds_NhanVien = new System.Windows.Forms.BindingSource(this.components);
            this.nHANVIENTableAdapter = new QuanLyMayBay.DSTableAdapters.NHANVIENTableAdapter();
            this.nGUOIBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nGUOITableAdapter = new QuanLyMayBay.DSTableAdapters.NGUOITableAdapter();
            this.cHUYENVEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cHUYENVETableAdapter = new QuanLyMayBay.DSTableAdapters.CHUYENVETableAdapter();
            this.cHUYENVEBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.thêmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xóaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            mANVLabel = new System.Windows.Forms.Label();
            cALabel = new System.Windows.Forms.Label();
            lUONGLabel = new System.Windows.Forms.Label();
            sOCMNDLabel = new System.Windows.Forms.Label();
            hOTENLabel = new System.Windows.Forms.Label();
            sODIENTHOAILabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds_ThongTinNhanVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GC_TTNV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSDT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHoTen.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiaChi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCMND.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaNV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds_NhanVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nGUOIBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cHUYENVEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cHUYENVEBindingSource1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mANVLabel
            // 
            mANVLabel.AutoSize = true;
            mANVLabel.Location = new System.Drawing.Point(40, 31);
            mANVLabel.Name = "mANVLabel";
            mANVLabel.Size = new System.Drawing.Size(44, 16);
            mANVLabel.TabIndex = 0;
            mANVLabel.Text = "Mã NV";
            // 
            // cALabel
            // 
            cALabel.AutoSize = true;
            cALabel.Location = new System.Drawing.Point(40, 77);
            cALabel.Name = "cALabel";
            cALabel.Size = new System.Drawing.Size(27, 16);
            cALabel.TabIndex = 2;
            cALabel.Text = "Ca:";
            // 
            // lUONGLabel
            // 
            lUONGLabel.AutoSize = true;
            lUONGLabel.Location = new System.Drawing.Point(307, 124);
            lUONGLabel.Name = "lUONGLabel";
            lUONGLabel.Size = new System.Drawing.Size(42, 16);
            lUONGLabel.TabIndex = 4;
            lUONGLabel.Text = "Lương";
            // 
            // sOCMNDLabel
            // 
            sOCMNDLabel.AutoSize = true;
            sOCMNDLabel.Location = new System.Drawing.Point(40, 124);
            sOCMNDLabel.Name = "sOCMNDLabel";
            sOCMNDLabel.Size = new System.Drawing.Size(41, 16);
            sOCMNDLabel.TabIndex = 6;
            sOCMNDLabel.Text = "CMND";
            // 
            // hOTENLabel
            // 
            hOTENLabel.AutoSize = true;
            hOTENLabel.Location = new System.Drawing.Point(307, 31);
            hOTENLabel.Name = "hOTENLabel";
            hOTENLabel.Size = new System.Drawing.Size(48, 16);
            hOTENLabel.TabIndex = 10;
            hOTENLabel.Text = "Họ Tên";
            // 
            // sODIENTHOAILabel
            // 
            sODIENTHOAILabel.AutoSize = true;
            sODIENTHOAILabel.Location = new System.Drawing.Point(40, 172);
            sODIENTHOAILabel.Name = "sODIENTHOAILabel";
            sODIENTHOAILabel.Size = new System.Drawing.Size(32, 16);
            sODIENTHOAILabel.TabIndex = 12;
            sODIENTHOAILabel.Text = "SĐT";
            sODIENTHOAILabel.Click += new System.EventHandler(this.sODIENTHOAILabel_Click);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(307, 77);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(48, 16);
            label1.TabIndex = 14;
            label1.Text = "Địa Chỉ";
            label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // bar2
            // 
            this.bar2.BarAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 10F);
            this.bar2.BarAppearance.Normal.Options.UseFont = true;
            this.bar2.BarName = "Tools";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.FloatLocation = new System.Drawing.Point(432, 168);
            this.bar2.Offset = 10;
            this.bar2.Text = "Tools";
            // 
            // bar1
            // 
            this.bar1.BarAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 10F);
            this.bar1.BarAppearance.Normal.Options.UseFont = true;
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.FloatLocation = new System.Drawing.Point(432, 168);
            this.bar1.Offset = 10;
            this.bar1.Text = "Tools";
            // 
            // bar3
            // 
            this.bar3.BarAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 10F);
            this.bar3.BarAppearance.Normal.Options.UseFont = true;
            this.bar3.BarName = "Tools";
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar3.FloatLocation = new System.Drawing.Point(432, 168);
            this.bar3.Offset = 10;
            this.bar3.Text = "Tools";
            // 
            // bar4
            // 
            this.bar4.BarName = "Tools";
            this.bar4.DockCol = 0;
            this.bar4.DockRow = 0;
            this.bar4.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar4.Text = "Tools";
            // 
            // bar5
            // 
            this.bar5.BarName = "Tools";
            this.bar5.DockCol = 0;
            this.bar5.DockRow = 0;
            this.bar5.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar5.Text = "Tools";
            // 
            // bar6
            // 
            this.bar6.BarName = "Tools";
            this.bar6.DockCol = 0;
            this.bar6.DockRow = 0;
            this.bar6.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar6.Text = "Tools";
            // 
            // bar7
            // 
            this.bar7.BarName = "Tools";
            this.bar7.DockCol = 0;
            this.bar7.DockRow = 0;
            this.bar7.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar7.Text = "Tools";
            // 
            // bar8
            // 
            this.bar8.BarName = "Tools";
            this.bar8.DockCol = 0;
            this.bar8.DockRow = 0;
            this.bar8.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar8.Text = "Tools";
            // 
            // bar9
            // 
            this.bar9.BarName = "Tools";
            this.bar9.DockCol = 0;
            this.bar9.DockRow = 0;
            this.bar9.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar9.Text = "Tools";
            // 
            // bar10
            // 
            this.bar10.BarName = "Tools";
            this.bar10.DockCol = 0;
            this.bar10.DockRow = 0;
            this.bar10.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar10.Text = "Tools";
            // 
            // bar11
            // 
            this.bar11.BarName = "Tools";
            this.bar11.DockCol = 0;
            this.bar11.DockRow = 0;
            this.bar11.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar11.Text = "Tools";
            // 
            // barDockControl6
            // 
            this.barDockControl6.CausesValidation = false;
            this.barDockControl6.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControl6.Location = new System.Drawing.Point(0, 30);
            this.barDockControl6.Manager = this.barManager2;
            this.barDockControl6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControl6.Size = new System.Drawing.Size(0, 573);
            // 
            // barManager2
            // 
            this.barManager2.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar12});
            this.barManager2.DockControls.Add(this.barDockControl4);
            this.barManager2.DockControls.Add(this.barDockControl5);
            this.barManager2.DockControls.Add(this.barDockControl6);
            this.barManager2.DockControls.Add(this.barDockControl8);
            this.barManager2.Form = this;
            this.barManager2.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnThem,
            this.btnXoa,
            this.btnSua,
            this.btnGhi,
            this.btnReload,
            this.btnThoat,
            this.btnHuy});
            this.barManager2.MaxItemId = 9;
            // 
            // bar12
            // 
            this.bar12.BarAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 10F);
            this.bar12.BarAppearance.Normal.Options.UseFont = true;
            this.bar12.BarName = "Tools";
            this.bar12.DockCol = 0;
            this.bar12.DockRow = 0;
            this.bar12.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar12.FloatLocation = new System.Drawing.Point(432, 168);
            this.bar12.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThem, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnXoa, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnSua, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnGhi, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnHuy, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnReload, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThoat, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar12.Offset = 10;
            this.bar12.Text = "Tools";
            // 
            // btnThem
            // 
            this.btnThem.Caption = "Thêm";
            this.btnThem.Id = 0;
            this.btnThem.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnThem.ImageOptions.SvgImage")));
            this.btnThem.Name = "btnThem";
            this.btnThem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThemPN_ItemClick);
            // 
            // btnXoa
            // 
            this.btnXoa.Caption = "Xóa";
            this.btnXoa.Id = 1;
            this.btnXoa.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnXoa.ImageOptions.SvgImage")));
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXoa_ItemClick);
            // 
            // btnSua
            // 
            this.btnSua.Caption = "Sửa";
            this.btnSua.Id = 2;
            this.btnSua.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnSua.ImageOptions.SvgImage")));
            this.btnSua.Name = "btnSua";
            this.btnSua.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSua_ItemClick);
            // 
            // btnGhi
            // 
            this.btnGhi.Caption = "Ghi";
            this.btnGhi.Id = 3;
            this.btnGhi.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnGhi.ImageOptions.SvgImage")));
            this.btnGhi.Name = "btnGhi";
            this.btnGhi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnGhi_ItemClick);
            // 
            // btnHuy
            // 
            this.btnHuy.Caption = "Hủy thao tác";
            this.btnHuy.Id = 7;
            this.btnHuy.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnHuy.ImageOptions.SvgImage")));
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnHuy_ItemClick);
            // 
            // btnReload
            // 
            this.btnReload.Caption = "Reload";
            this.btnReload.Id = 5;
            this.btnReload.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnReload.ImageOptions.SvgImage")));
            this.btnReload.Name = "btnReload";
            this.btnReload.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnReload_ItemClick);
            // 
            // btnThoat
            // 
            this.btnThoat.Caption = "Thoát";
            this.btnThoat.Id = 6;
            this.btnThoat.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnThoat.ImageOptions.SvgImage")));
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThoat_ItemClick);
            // 
            // barDockControl4
            // 
            this.barDockControl4.CausesValidation = false;
            this.barDockControl4.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControl4.Location = new System.Drawing.Point(0, 0);
            this.barDockControl4.Manager = this.barManager2;
            this.barDockControl4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControl4.Size = new System.Drawing.Size(1128, 30);
            // 
            // barDockControl5
            // 
            this.barDockControl5.CausesValidation = false;
            this.barDockControl5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControl5.Location = new System.Drawing.Point(0, 603);
            this.barDockControl5.Manager = this.barManager2;
            this.barDockControl5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControl5.Size = new System.Drawing.Size(1128, 0);
            // 
            // barDockControl8
            // 
            this.barDockControl8.CausesValidation = false;
            this.barDockControl8.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControl8.Location = new System.Drawing.Point(1128, 30);
            this.barDockControl8.Manager = this.barManager2;
            this.barDockControl8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControl8.Size = new System.Drawing.Size(0, 573);
            // 
            // barButtonItem11
            // 
            this.barButtonItem11.Caption = "Chi tiết phiếu xuất";
            this.barButtonItem11.Id = 8;
            this.barButtonItem11.ItemAppearance.Normal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.barButtonItem11.ItemAppearance.Normal.Options.UseBackColor = true;
            this.barButtonItem11.Name = "barButtonItem11";
            // 
            // barButtonItem7
            // 
            this.barButtonItem7.Caption = "Hủy thao tác";
            this.barButtonItem7.Id = 7;
            this.barButtonItem7.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem7.ImageOptions.SvgImage")));
            this.barButtonItem7.Name = "barButtonItem7";
            // 
            // barButtonItem10
            // 
            this.barButtonItem10.Caption = "Thoát";
            this.barButtonItem10.Id = 6;
            this.barButtonItem10.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem10.ImageOptions.SvgImage")));
            this.barButtonItem10.Name = "barButtonItem10";
            // 
            // barButtonItem9
            // 
            this.barButtonItem9.Caption = "Reload";
            this.barButtonItem9.Id = 5;
            this.barButtonItem9.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem9.ImageOptions.SvgImage")));
            this.barButtonItem9.Name = "barButtonItem9";
            // 
            // barButtonItem8
            // 
            this.barButtonItem8.Caption = "Phục hồi";
            this.barButtonItem8.Id = 4;
            this.barButtonItem8.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem8.ImageOptions.SvgImage")));
            this.barButtonItem8.Name = "barButtonItem8";
            // 
            // barButtonItem6
            // 
            this.barButtonItem6.Caption = "Ghi";
            this.barButtonItem6.Id = 3;
            this.barButtonItem6.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem6.ImageOptions.SvgImage")));
            this.barButtonItem6.Name = "barButtonItem6";
            // 
            // barButtonItem5
            // 
            this.barButtonItem5.Caption = "Sửa";
            this.barButtonItem5.Id = 2;
            this.barButtonItem5.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem5.ImageOptions.SvgImage")));
            this.barButtonItem5.Name = "barButtonItem5";
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.Caption = "Xóa";
            this.barButtonItem4.Id = 1;
            this.barButtonItem4.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem4.ImageOptions.SvgImage")));
            this.barButtonItem4.Name = "barButtonItem4";
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Thêm";
            this.barButtonItem2.Id = 0;
            this.barButtonItem2.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem2.ImageOptions.SvgImage")));
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // barButtonPX
            // 
            this.barButtonPX.Caption = "Chi tiết phiếu xuất";
            this.barButtonPX.Id = 8;
            this.barButtonPX.ItemAppearance.Normal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.barButtonPX.ItemAppearance.Normal.Options.UseBackColor = true;
            this.barButtonPX.Name = "barButtonPX";
            // 
            // btnReloadPX
            // 
            this.btnReloadPX.Caption = "Reload";
            this.btnReloadPX.Id = 5;
            this.btnReloadPX.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnReloadPX.ImageOptions.SvgImage")));
            this.btnReloadPX.Name = "btnReloadPX";
            // 
            // btnPhucHoiPX
            // 
            this.btnPhucHoiPX.Caption = "Phục hồi";
            this.btnPhucHoiPX.Id = 4;
            this.btnPhucHoiPX.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnPhucHoiPX.ImageOptions.SvgImage")));
            this.btnPhucHoiPX.Name = "btnPhucHoiPX";
            // 
            // btnHuyPX
            // 
            this.btnHuyPX.Caption = "Hủy thao tác";
            this.btnHuyPX.Id = 7;
            this.btnHuyPX.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnHuyPX.ImageOptions.SvgImage")));
            this.btnHuyPX.Name = "btnHuyPX";
            // 
            // btnGhiPX
            // 
            this.btnGhiPX.Caption = "Ghi";
            this.btnGhiPX.Id = 3;
            this.btnGhiPX.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnGhiPX.ImageOptions.SvgImage")));
            this.btnGhiPX.Name = "btnGhiPX";
            // 
            // btnSuaPX
            // 
            this.btnSuaPX.Caption = "Sửa";
            this.btnSuaPX.Id = 2;
            this.btnSuaPX.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnSuaPX.ImageOptions.SvgImage")));
            this.btnSuaPX.Name = "btnSuaPX";
            // 
            // btnXoaPX
            // 
            this.btnXoaPX.Caption = "Xóa";
            this.btnXoaPX.Id = 1;
            this.btnXoaPX.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnXoaPX.ImageOptions.SvgImage")));
            this.btnXoaPX.Name = "btnXoaPX";
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "Thêm";
            this.barButtonItem3.Id = 0;
            this.barButtonItem3.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem3.ImageOptions.SvgImage")));
            this.barButtonItem3.Name = "barButtonItem3";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Thêm";
            this.barButtonItem1.Id = 0;
            this.barButtonItem1.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem1.ImageOptions.SvgImage")));
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // btnThemPX
            // 
            this.btnThemPX.Caption = "Thêm";
            this.btnThemPX.Id = 0;
            this.btnThemPX.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnThemPX.ImageOptions.SvgImage")));
            this.btnThemPX.Name = "btnThemPX";
            // 
            // btnThoatPX
            // 
            this.btnThoatPX.Caption = "Thoát";
            this.btnThoatPX.Id = 6;
            this.btnThoatPX.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnThoatPX.ImageOptions.SvgImage")));
            this.btnThoatPX.Name = "btnThoatPX";
            // 
            // barDockControl2
            // 
            this.barDockControl2.CausesValidation = false;
            this.barDockControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControl2.Location = new System.Drawing.Point(0, 30);
            this.barDockControl2.Manager = null;
            this.barDockControl2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControl2.Size = new System.Drawing.Size(1128, 0);
            // 
            // barDockControl1
            // 
            this.barDockControl1.CausesValidation = false;
            this.barDockControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControl1.Location = new System.Drawing.Point(0, 30);
            this.barDockControl1.Manager = null;
            this.barDockControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControl1.Size = new System.Drawing.Size(1128, 0);
            // 
            // barDockControl10
            // 
            this.barDockControl10.CausesValidation = false;
            this.barDockControl10.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControl10.Location = new System.Drawing.Point(1128, 30);
            this.barDockControl10.Manager = null;
            this.barDockControl10.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControl10.Size = new System.Drawing.Size(0, 573);
            // 
            // barDockControl7
            // 
            this.barDockControl7.CausesValidation = false;
            this.barDockControl7.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControl7.Location = new System.Drawing.Point(1128, 30);
            this.barDockControl7.Manager = null;
            this.barDockControl7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControl7.Size = new System.Drawing.Size(0, 573);
            // 
            // dS
            // 
            this.dS.DataSetName = "DS";
            this.dS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bds_ThongTinNhanVien
            // 
            this.bds_ThongTinNhanVien.DataMember = "ThongTinNhanVien";
            this.bds_ThongTinNhanVien.DataSource = this.dS;
            // 
            // thongTinNhanVienTableAdapter
            // 
            this.thongTinNhanVienTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CHUMAYBAYTableAdapter = null;
            this.tableAdapterManager.CHUYENVETableAdapter = null;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.DICHVUBAOTRITableAdapter = null;
            this.tableAdapterManager.DOANHNGHIEPTableAdapter = null;
            this.tableAdapterManager.LAITableAdapter = null;
            this.tableAdapterManager.LOAIMAYBAYTableAdapter = null;
            this.tableAdapterManager.MAYBAYTableAdapter = null;
            this.tableAdapterManager.NGUOITableAdapter = null;
            this.tableAdapterManager.NHACHUAMAYBAYTableAdapter = null;
            this.tableAdapterManager.NHANVIENTableAdapter = null;
            this.tableAdapterManager.PHICONGTableAdapter = null;
            this.tableAdapterManager.SOHUUTableAdapter = null;
            this.tableAdapterManager.ThongTinNhanVienTableAdapter = null;
            this.tableAdapterManager.ThongTinPhiCongTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QuanLyMayBay.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // GC_TTNV
            // 
            this.GC_TTNV.DataSource = this.bds_ThongTinNhanVien;
            this.GC_TTNV.Dock = System.Windows.Forms.DockStyle.Top;
            this.GC_TTNV.Location = new System.Drawing.Point(0, 30);
            this.GC_TTNV.MainView = this.gridView1;
            this.GC_TTNV.MenuManager = this.barManager2;
            this.GC_TTNV.Name = "GC_TTNV";
            this.GC_TTNV.Size = new System.Drawing.Size(1128, 220);
            this.GC_TTNV.TabIndex = 12;
            this.GC_TTNV.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMANV,
            this.colCA,
            this.colLUONG,
            this.colSOCMND,
            this.colHOTEN,
            this.colDIACHI,
            this.colSODIENTHOAI});
            this.gridView1.GridControl = this.GC_TTNV;
            this.gridView1.Name = "gridView1";
            // 
            // colMANV
            // 
            this.colMANV.FieldName = "MANV";
            this.colMANV.MinWidth = 25;
            this.colMANV.Name = "colMANV";
            this.colMANV.Visible = true;
            this.colMANV.VisibleIndex = 0;
            this.colMANV.Width = 94;
            // 
            // colCA
            // 
            this.colCA.FieldName = "CA";
            this.colCA.MinWidth = 25;
            this.colCA.Name = "colCA";
            this.colCA.Visible = true;
            this.colCA.VisibleIndex = 1;
            this.colCA.Width = 94;
            // 
            // colLUONG
            // 
            this.colLUONG.FieldName = "LUONG";
            this.colLUONG.MinWidth = 25;
            this.colLUONG.Name = "colLUONG";
            this.colLUONG.Visible = true;
            this.colLUONG.VisibleIndex = 2;
            this.colLUONG.Width = 94;
            // 
            // colSOCMND
            // 
            this.colSOCMND.FieldName = "SOCMND";
            this.colSOCMND.MinWidth = 25;
            this.colSOCMND.Name = "colSOCMND";
            this.colSOCMND.Visible = true;
            this.colSOCMND.VisibleIndex = 3;
            this.colSOCMND.Width = 94;
            // 
            // colHOTEN
            // 
            this.colHOTEN.FieldName = "HOTEN";
            this.colHOTEN.MinWidth = 25;
            this.colHOTEN.Name = "colHOTEN";
            this.colHOTEN.Visible = true;
            this.colHOTEN.VisibleIndex = 4;
            this.colHOTEN.Width = 94;
            // 
            // colDIACHI
            // 
            this.colDIACHI.FieldName = "DIACHI";
            this.colDIACHI.MinWidth = 25;
            this.colDIACHI.Name = "colDIACHI";
            this.colDIACHI.Visible = true;
            this.colDIACHI.VisibleIndex = 5;
            this.colDIACHI.Width = 94;
            // 
            // colSODIENTHOAI
            // 
            this.colSODIENTHOAI.FieldName = "SODIENTHOAI";
            this.colSODIENTHOAI.MinWidth = 25;
            this.colSODIENTHOAI.Name = "colSODIENTHOAI";
            this.colSODIENTHOAI.Visible = true;
            this.colSODIENTHOAI.VisibleIndex = 6;
            this.colSODIENTHOAI.Width = 94;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.txtSDT);
            this.panelControl1.Controls.Add(label1);
            this.panelControl1.Controls.Add(sODIENTHOAILabel);
            this.panelControl1.Controls.Add(hOTENLabel);
            this.panelControl1.Controls.Add(this.txtHoTen);
            this.panelControl1.Controls.Add(this.txtDiaChi);
            this.panelControl1.Controls.Add(sOCMNDLabel);
            this.panelControl1.Controls.Add(this.txtCMND);
            this.panelControl1.Controls.Add(lUONGLabel);
            this.panelControl1.Controls.Add(this.txtLuong);
            this.panelControl1.Controls.Add(cALabel);
            this.panelControl1.Controls.Add(this.txtCa);
            this.panelControl1.Controls.Add(mANVLabel);
            this.panelControl1.Controls.Add(this.txtMaNV);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 250);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1128, 353);
            this.panelControl1.TabIndex = 13;
            // 
            // txtSDT
            // 
            this.txtSDT.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bds_ThongTinNhanVien, "SODIENTHOAI", true));
            this.txtSDT.Location = new System.Drawing.Point(90, 169);
            this.txtSDT.MenuManager = this.barManager2;
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(156, 22);
            this.txtSDT.TabIndex = 15;
            // 
            // txtHoTen
            // 
            this.txtHoTen.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bds_ThongTinNhanVien, "HOTEN", true));
            this.txtHoTen.Location = new System.Drawing.Point(365, 28);
            this.txtHoTen.MenuManager = this.barManager2;
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(270, 22);
            this.txtHoTen.TabIndex = 11;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bds_ThongTinNhanVien, "DIACHI", true));
            this.txtDiaChi.Location = new System.Drawing.Point(365, 74);
            this.txtDiaChi.MenuManager = this.barManager2;
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(270, 22);
            this.txtDiaChi.TabIndex = 9;
            // 
            // txtCMND
            // 
            this.txtCMND.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bds_ThongTinNhanVien, "SOCMND", true));
            this.txtCMND.Location = new System.Drawing.Point(90, 121);
            this.txtCMND.MenuManager = this.barManager2;
            this.txtCMND.Name = "txtCMND";
            this.txtCMND.Size = new System.Drawing.Size(156, 22);
            this.txtCMND.TabIndex = 7;
            // 
            // txtLuong
            // 
            this.txtLuong.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bds_ThongTinNhanVien, "LUONG", true));
            this.txtLuong.Location = new System.Drawing.Point(365, 124);
            this.txtLuong.Name = "txtLuong";
            this.txtLuong.Size = new System.Drawing.Size(270, 23);
            this.txtLuong.TabIndex = 5;
            // 
            // txtCa
            // 
            this.txtCa.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bds_ThongTinNhanVien, "CA", true));
            this.txtCa.Location = new System.Drawing.Point(90, 71);
            this.txtCa.MenuManager = this.barManager2;
            this.txtCa.Name = "txtCa";
            this.txtCa.Size = new System.Drawing.Size(156, 22);
            this.txtCa.TabIndex = 3;
            this.txtCa.EditValueChanged += new System.EventHandler(this.cATextEdit_EditValueChanged);
            // 
            // txtMaNV
            // 
            this.txtMaNV.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bds_ThongTinNhanVien, "MANV", true));
            this.txtMaNV.Location = new System.Drawing.Point(90, 25);
            this.txtMaNV.MenuManager = this.barManager2;
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(156, 22);
            this.txtMaNV.TabIndex = 1;
            this.txtMaNV.EditValueChanged += new System.EventHandler(this.txtMaNV_EditValueChanged);
            // 
            // bds_NhanVien
            // 
            this.bds_NhanVien.DataMember = "NHANVIEN";
            this.bds_NhanVien.DataSource = this.dS;
            // 
            // nHANVIENTableAdapter
            // 
            this.nHANVIENTableAdapter.ClearBeforeFill = true;
            // 
            // nGUOIBindingSource
            // 
            this.nGUOIBindingSource.DataMember = "NGUOI";
            this.nGUOIBindingSource.DataSource = this.dS;
            // 
            // nGUOITableAdapter
            // 
            this.nGUOITableAdapter.ClearBeforeFill = true;
            // 
            // cHUYENVEBindingSource
            // 
            this.cHUYENVEBindingSource.DataMember = "CHUYENVE";
            this.cHUYENVEBindingSource.DataSource = this.dS;
            // 
            // cHUYENVETableAdapter
            // 
            this.cHUYENVETableAdapter.ClearBeforeFill = true;
            // 
            // cHUYENVEBindingSource1
            // 
            this.cHUYENVEBindingSource1.DataMember = "FK_CHUYENVE_NHANVIEN";
            this.cHUYENVEBindingSource1.DataSource = this.bds_NhanVien;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thêmToolStripMenuItem,
            this.xóaToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(116, 52);
            // 
            // thêmToolStripMenuItem
            // 
            this.thêmToolStripMenuItem.Name = "thêmToolStripMenuItem";
            this.thêmToolStripMenuItem.Size = new System.Drawing.Size(115, 24);
            this.thêmToolStripMenuItem.Text = "Thêm";
            // 
            // xóaToolStripMenuItem
            // 
            this.xóaToolStripMenuItem.Name = "xóaToolStripMenuItem";
            this.xóaToolStripMenuItem.Size = new System.Drawing.Size(115, 24);
            this.xóaToolStripMenuItem.Text = "Xóa";
            // 
            // FormNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1128, 603);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.GC_TTNV);
            this.Controls.Add(this.barDockControl2);
            this.Controls.Add(this.barDockControl1);
            this.Controls.Add(this.barDockControl10);
            this.Controls.Add(this.barDockControl7);
            this.Controls.Add(this.barDockControl6);
            this.Controls.Add(this.barDockControl8);
            this.Controls.Add(this.barDockControl5);
            this.Controls.Add(this.barDockControl4);
            this.Name = "FormNhanVien";
            this.Text = "FormNhanVien";
            this.Load += new System.EventHandler(this.FormNhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds_ThongTinNhanVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GC_TTNV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSDT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHoTen.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiaChi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCMND.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaNV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds_NhanVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nGUOIBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cHUYENVEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cHUYENVEBindingSource1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.Bar bar4;
        private DevExpress.XtraBars.Bar bar5;
        private DevExpress.XtraBars.Bar bar6;
        private DevExpress.XtraBars.Bar bar7;
        private DevExpress.XtraBars.Bar bar8;
        private DevExpress.XtraBars.Bar bar9;
        private DevExpress.XtraBars.Bar bar10;
        private DevExpress.XtraBars.Bar bar11;
        private DevExpress.XtraBars.BarDockControl barDockControl2;
        private DevExpress.XtraBars.BarDockControl barDockControl1;
        private DevExpress.XtraBars.BarDockControl barDockControl10;
        private DevExpress.XtraBars.BarDockControl barDockControl7;
        private DevExpress.XtraBars.BarDockControl barDockControl6;
        private DevExpress.XtraBars.BarManager barManager2;
        private DevExpress.XtraBars.Bar bar12;
        private DevExpress.XtraBars.BarButtonItem btnThem;
        private DevExpress.XtraBars.BarButtonItem btnXoa;
        private DevExpress.XtraBars.BarButtonItem btnSua;
        private DevExpress.XtraBars.BarButtonItem btnGhi;
        private DevExpress.XtraBars.BarButtonItem btnHuy;
        private DevExpress.XtraBars.BarButtonItem btnReload;
        private DevExpress.XtraBars.BarButtonItem btnThoat;
        private DevExpress.XtraBars.BarDockControl barDockControl4;
        private DevExpress.XtraBars.BarDockControl barDockControl5;
        private DevExpress.XtraBars.BarDockControl barDockControl8;
        private DevExpress.XtraBars.BarButtonItem barButtonItem11;
        private DevExpress.XtraBars.BarButtonItem barButtonItem7;
        private DevExpress.XtraBars.BarButtonItem barButtonItem10;
        private DevExpress.XtraBars.BarButtonItem barButtonItem9;
        private DevExpress.XtraBars.BarButtonItem barButtonItem8;
        private DevExpress.XtraBars.BarButtonItem barButtonItem6;
        private DevExpress.XtraBars.BarButtonItem barButtonItem5;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem barButtonPX;
        private DevExpress.XtraBars.BarButtonItem btnReloadPX;
        private DevExpress.XtraBars.BarButtonItem btnPhucHoiPX;
        private DevExpress.XtraBars.BarButtonItem btnHuyPX;
        private DevExpress.XtraBars.BarButtonItem btnGhiPX;
        private DevExpress.XtraBars.BarButtonItem btnSuaPX;
        private DevExpress.XtraBars.BarButtonItem btnXoaPX;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem btnThemPX;
        private DevExpress.XtraBars.BarButtonItem btnThoatPX;
        private System.Windows.Forms.BindingSource bds_ThongTinNhanVien;
        private DS dS;
        private DSTableAdapters.ThongTinNhanVienTableAdapter thongTinNhanVienTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.TextEdit txtHoTen;
        private DevExpress.XtraEditors.TextEdit txtDiaChi;
        private DevExpress.XtraEditors.TextEdit txtCMND;
        private System.Windows.Forms.TextBox txtLuong;
        private DevExpress.XtraEditors.TextEdit txtCa;
        private DevExpress.XtraEditors.TextEdit txtMaNV;
        private DevExpress.XtraGrid.GridControl GC_TTNV;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMANV;
        private DevExpress.XtraGrid.Columns.GridColumn colCA;
        private DevExpress.XtraGrid.Columns.GridColumn colLUONG;
        private DevExpress.XtraGrid.Columns.GridColumn colSOCMND;
        private DevExpress.XtraGrid.Columns.GridColumn colHOTEN;
        private DevExpress.XtraGrid.Columns.GridColumn colDIACHI;
        private DevExpress.XtraGrid.Columns.GridColumn colSODIENTHOAI;
        private System.Windows.Forms.BindingSource bds_NhanVien;
        private DSTableAdapters.NHANVIENTableAdapter nHANVIENTableAdapter;
        private System.Windows.Forms.BindingSource nGUOIBindingSource;
        private DSTableAdapters.NGUOITableAdapter nGUOITableAdapter;
        private DevExpress.XtraEditors.TextEdit txtSDT;
        private System.Windows.Forms.BindingSource cHUYENVEBindingSource;
        private DSTableAdapters.CHUYENVETableAdapter cHUYENVETableAdapter;
        private System.Windows.Forms.BindingSource cHUYENVEBindingSource1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem thêmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xóaToolStripMenuItem;
    }
}