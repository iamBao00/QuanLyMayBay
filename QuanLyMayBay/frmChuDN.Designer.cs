namespace QuanLyMayBay
{
    partial class frmChuDN
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
            System.Windows.Forms.Label mACHULabel;
            System.Windows.Forms.Label mADOANHNGHIEPLabel;
            System.Windows.Forms.Label tENDOANHNGHIEPLabel;
            System.Windows.Forms.Label tENNGUOIDAIDIENLabel;
            System.Windows.Forms.Label dIACHILabel;
            System.Windows.Forms.Label sODIENTHOAILabel;
            System.Windows.Forms.Label mACHULabel1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChuDN));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btnThem = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoa = new DevExpress.XtraBars.BarButtonItem();
            this.btnGhi = new DevExpress.XtraBars.BarButtonItem();
            this.btnPhucHoi = new DevExpress.XtraBars.BarButtonItem();
            this.btnReload = new DevExpress.XtraBars.BarButtonItem();
            this.btnThoat = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.DS = new QuanLyMayBay.DS();
            this.bdsCMB = new System.Windows.Forms.BindingSource(this.components);
            this.cHUMAYBAYTableAdapter = new QuanLyMayBay.DSTableAdapters.CHUMAYBAYTableAdapter();
            this.tableAdapterManager = new QuanLyMayBay.DSTableAdapters.TableAdapterManager();
            this.dOANHNGHIEPTableAdapter = new QuanLyMayBay.DSTableAdapters.DOANHNGHIEPTableAdapter();
            this.gcChu = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.bdsDN = new System.Windows.Forms.BindingSource(this.components);
            this.gcDoanhNghiep = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnThemDN = new System.Windows.Forms.ToolStripMenuItem();
            this.btnHieuChinhDN = new System.Windows.Forms.ToolStripMenuItem();
            this.btnXoaDN = new System.Windows.Forms.ToolStripMenuItem();
            this.btnGhiDN = new System.Windows.Forms.ToolStripMenuItem();
            this.btnPhucHoiDN = new System.Windows.Forms.ToolStripMenuItem();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.txtMaChu = new DevExpress.XtraEditors.TextEdit();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.txtMaChuDN = new DevExpress.XtraEditors.TextEdit();
            this.txtSDT = new DevExpress.XtraEditors.TextEdit();
            this.txtDiaChi = new DevExpress.XtraEditors.TextEdit();
            this.txtTenNDD = new DevExpress.XtraEditors.TextEdit();
            this.txtTenDN = new DevExpress.XtraEditors.TextEdit();
            this.txtMaDN = new DevExpress.XtraEditors.TextEdit();
            mACHULabel = new System.Windows.Forms.Label();
            mADOANHNGHIEPLabel = new System.Windows.Forms.Label();
            tENDOANHNGHIEPLabel = new System.Windows.Forms.Label();
            tENNGUOIDAIDIENLabel = new System.Windows.Forms.Label();
            dIACHILabel = new System.Windows.Forms.Label();
            sODIENTHOAILabel = new System.Windows.Forms.Label();
            mACHULabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCMB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcChu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDoanhNghiep)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaChu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaChuDN.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSDT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiaChi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenNDD.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenDN.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaDN.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // mACHULabel
            // 
            mACHULabel.AutoSize = true;
            mACHULabel.Location = new System.Drawing.Point(9, 34);
            mACHULabel.Name = "mACHULabel";
            mACHULabel.Size = new System.Drawing.Size(53, 16);
            mACHULabel.TabIndex = 0;
            mACHULabel.Text = "Mã chủ:";
            // 
            // mADOANHNGHIEPLabel
            // 
            mADOANHNGHIEPLabel.AutoSize = true;
            mADOANHNGHIEPLabel.Location = new System.Drawing.Point(56, 33);
            mADOANHNGHIEPLabel.Name = "mADOANHNGHIEPLabel";
            mADOANHNGHIEPLabel.Size = new System.Drawing.Size(110, 16);
            mADOANHNGHIEPLabel.TabIndex = 0;
            mADOANHNGHIEPLabel.Text = "Mã doanh nghiệp:";
            // 
            // tENDOANHNGHIEPLabel
            // 
            tENDOANHNGHIEPLabel.AutoSize = true;
            tENDOANHNGHIEPLabel.Location = new System.Drawing.Point(51, 64);
            tENDOANHNGHIEPLabel.Name = "tENDOANHNGHIEPLabel";
            tENDOANHNGHIEPLabel.Size = new System.Drawing.Size(115, 16);
            tENDOANHNGHIEPLabel.TabIndex = 2;
            tENDOANHNGHIEPLabel.Text = "Tên doanh nghiệp:";
            // 
            // tENNGUOIDAIDIENLabel
            // 
            tENNGUOIDAIDIENLabel.AutoSize = true;
            tENNGUOIDAIDIENLabel.Location = new System.Drawing.Point(49, 98);
            tENNGUOIDAIDIENLabel.Name = "tENNGUOIDAIDIENLabel";
            tENNGUOIDAIDIENLabel.Size = new System.Drawing.Size(119, 16);
            tENNGUOIDAIDIENLabel.TabIndex = 4;
            tENNGUOIDAIDIENLabel.Text = "Tên người đại diện:";
            // 
            // dIACHILabel
            // 
            dIACHILabel.AutoSize = true;
            dIACHILabel.Location = new System.Drawing.Point(439, 30);
            dIACHILabel.Name = "dIACHILabel";
            dIACHILabel.Size = new System.Drawing.Size(51, 16);
            dIACHILabel.TabIndex = 6;
            dIACHILabel.Text = "Địa chỉ:";
            // 
            // sODIENTHOAILabel
            // 
            sODIENTHOAILabel.AutoSize = true;
            sODIENTHOAILabel.Location = new System.Drawing.Point(406, 64);
            sODIENTHOAILabel.Name = "sODIENTHOAILabel";
            sODIENTHOAILabel.Size = new System.Drawing.Size(87, 16);
            sODIENTHOAILabel.TabIndex = 8;
            sODIENTHOAILabel.Text = "Số điện thoại:";
            // 
            // mACHULabel1
            // 
            mACHULabel1.AutoSize = true;
            mACHULabel1.Location = new System.Drawing.Point(440, 98);
            mACHULabel1.Name = "mACHULabel1";
            mACHULabel1.Size = new System.Drawing.Size(53, 16);
            mACHULabel1.TabIndex = 10;
            mACHULabel1.Text = "Mã chủ:";
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnThem,
            this.btnXoa,
            this.btnGhi,
            this.btnPhucHoi,
            this.btnReload,
            this.btnThoat});
            this.barManager1.MaxItemId = 6;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnThem),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnXoa),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnGhi),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnPhucHoi),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnReload),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnThoat)});
            this.bar1.Text = "Tools";
            // 
            // btnThem
            // 
            this.btnThem.Caption = "Thêm";
            this.btnThem.Id = 0;
            this.btnThem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.ImageOptions.Image")));
            this.btnThem.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnThem.ImageOptions.LargeImage")));
            this.btnThem.Name = "btnThem";
            this.btnThem.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnThem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThem_ItemClick);
            // 
            // btnXoa
            // 
            this.btnXoa.Caption = "Xóa";
            this.btnXoa.Id = 1;
            this.btnXoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.Image")));
            this.btnXoa.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.LargeImage")));
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnXoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXoa_ItemClick);
            // 
            // btnGhi
            // 
            this.btnGhi.Caption = "Ghi";
            this.btnGhi.Id = 2;
            this.btnGhi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGhi.ImageOptions.Image")));
            this.btnGhi.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnGhi.ImageOptions.LargeImage")));
            this.btnGhi.Name = "btnGhi";
            this.btnGhi.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnGhi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnGhi_ItemClick);
            // 
            // btnPhucHoi
            // 
            this.btnPhucHoi.Caption = "Phục hồi";
            this.btnPhucHoi.Id = 3;
            this.btnPhucHoi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPhucHoi.ImageOptions.Image")));
            this.btnPhucHoi.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnPhucHoi.ImageOptions.LargeImage")));
            this.btnPhucHoi.Name = "btnPhucHoi";
            this.btnPhucHoi.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnPhucHoi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPhucHoi_ItemClick);
            // 
            // btnReload
            // 
            this.btnReload.Caption = "Reload";
            this.btnReload.Id = 4;
            this.btnReload.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnReload.ImageOptions.Image")));
            this.btnReload.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnReload.ImageOptions.LargeImage")));
            this.btnReload.Name = "btnReload";
            this.btnReload.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnReload.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnReload_ItemClick);
            // 
            // btnThoat
            // 
            this.btnThoat.Caption = "Thoát";
            this.btnThoat.Id = 5;
            this.btnThoat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.ImageOptions.Image")));
            this.btnThoat.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnThoat.ImageOptions.LargeImage")));
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThoat_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1138, 30);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 530);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1138, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 30);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 500);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1138, 30);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 500);
            // 
            // DS
            // 
            this.DS.DataSetName = "DS";
            this.DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsCMB
            // 
            this.bdsCMB.DataMember = "CHUMAYBAY";
            this.bdsCMB.DataSource = this.DS;
            // 
            // cHUMAYBAYTableAdapter
            // 
            this.cHUMAYBAYTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CHUMAYBAYTableAdapter = this.cHUMAYBAYTableAdapter;
            this.tableAdapterManager.CHUYENVETableAdapter = null;
            this.tableAdapterManager.DICHVUBAOTRITableAdapter = null;
            this.tableAdapterManager.DOANHNGHIEPTableAdapter = this.dOANHNGHIEPTableAdapter;
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
            // dOANHNGHIEPTableAdapter
            // 
            this.dOANHNGHIEPTableAdapter.ClearBeforeFill = true;
            // 
            // gcChu
            // 
            this.gcChu.DataSource = this.bdsCMB;
            this.gcChu.Location = new System.Drawing.Point(0, 31);
            this.gcChu.MainView = this.gridView1;
            this.gcChu.MenuManager = this.barManager1;
            this.gcChu.Name = "gcChu";
            this.gcChu.Size = new System.Drawing.Size(181, 260);
            this.gcChu.TabIndex = 5;
            this.gcChu.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gcChu;
            this.gridView1.Name = "gridView1";
            // 
            // bdsDN
            // 
            this.bdsDN.DataMember = "FK_DOANHNGHIEP_NGUOICHU";
            this.bdsDN.DataSource = this.bdsCMB;
            // 
            // gcDoanhNghiep
            // 
            this.gcDoanhNghiep.AutoGenerateColumns = false;
            this.gcDoanhNghiep.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gcDoanhNghiep.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.gcDoanhNghiep.ContextMenuStrip = this.contextMenuStrip1;
            this.gcDoanhNghiep.DataSource = this.bdsDN;
            this.gcDoanhNghiep.Location = new System.Drawing.Point(207, 71);
            this.gcDoanhNghiep.Name = "gcDoanhNghiep";
            this.gcDoanhNghiep.RowHeadersWidth = 51;
            this.gcDoanhNghiep.RowTemplate.Height = 24;
            this.gcDoanhNghiep.Size = new System.Drawing.Size(931, 220);
            this.gcDoanhNghiep.TabIndex = 5;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MADOANHNGHIEP";
            this.dataGridViewTextBoxColumn1.HeaderText = "MADOANHNGHIEP";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "TENDOANHNGHIEP";
            this.dataGridViewTextBoxColumn2.HeaderText = "TENDOANHNGHIEP";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "TENNGUOIDAIDIEN";
            this.dataGridViewTextBoxColumn3.HeaderText = "TENNGUOIDAIDIEN";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "DIACHI";
            this.dataGridViewTextBoxColumn4.HeaderText = "DIACHI";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "SODIENTHOAI";
            this.dataGridViewTextBoxColumn5.HeaderText = "SODIENTHOAI";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "MACHU";
            this.dataGridViewTextBoxColumn6.HeaderText = "MACHU";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnThemDN,
            this.btnHieuChinhDN,
            this.btnXoaDN,
            this.btnGhiDN,
            this.btnPhucHoiDN});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(149, 124);
            // 
            // btnThemDN
            // 
            this.btnThemDN.Name = "btnThemDN";
            this.btnThemDN.Size = new System.Drawing.Size(148, 24);
            this.btnThemDN.Text = "Thêm";
            this.btnThemDN.Click += new System.EventHandler(this.btnThemDN_Click);
            // 
            // btnHieuChinhDN
            // 
            this.btnHieuChinhDN.Name = "btnHieuChinhDN";
            this.btnHieuChinhDN.Size = new System.Drawing.Size(148, 24);
            this.btnHieuChinhDN.Text = "Hiệu chỉnh";
            this.btnHieuChinhDN.Click += new System.EventHandler(this.btnHieuChinhDN_Click);
            // 
            // btnXoaDN
            // 
            this.btnXoaDN.Name = "btnXoaDN";
            this.btnXoaDN.Size = new System.Drawing.Size(148, 24);
            this.btnXoaDN.Text = "Xóa";
            this.btnXoaDN.Click += new System.EventHandler(this.btnXoaDN_Click);
            // 
            // btnGhiDN
            // 
            this.btnGhiDN.Name = "btnGhiDN";
            this.btnGhiDN.Size = new System.Drawing.Size(148, 24);
            this.btnGhiDN.Text = "Ghi";
            this.btnGhiDN.Click += new System.EventHandler(this.btnGhiDN_Click);
            // 
            // btnPhucHoiDN
            // 
            this.btnPhucHoiDN.Name = "btnPhucHoiDN";
            this.btnPhucHoiDN.Size = new System.Drawing.Size(148, 24);
            this.btnPhucHoiDN.Text = "Phục hồi";
            this.btnPhucHoiDN.Click += new System.EventHandler(this.btnPhucHoiDN_Click);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(mACHULabel);
            this.panelControl1.Controls.Add(this.txtMaChu);
            this.panelControl1.Location = new System.Drawing.Point(4, 350);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(181, 177);
            this.panelControl1.TabIndex = 6;
            // 
            // txtMaChu
            // 
            this.txtMaChu.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsCMB, "MACHU", true));
            this.txtMaChu.Location = new System.Drawing.Point(64, 31);
            this.txtMaChu.MenuManager = this.barManager1;
            this.txtMaChu.Name = "txtMaChu";
            this.txtMaChu.Size = new System.Drawing.Size(82, 22);
            this.txtMaChu.TabIndex = 1;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(mACHULabel1);
            this.panelControl2.Controls.Add(this.txtMaChuDN);
            this.panelControl2.Controls.Add(sODIENTHOAILabel);
            this.panelControl2.Controls.Add(this.txtSDT);
            this.panelControl2.Controls.Add(dIACHILabel);
            this.panelControl2.Controls.Add(this.txtDiaChi);
            this.panelControl2.Controls.Add(tENNGUOIDAIDIENLabel);
            this.panelControl2.Controls.Add(this.txtTenNDD);
            this.panelControl2.Controls.Add(tENDOANHNGHIEPLabel);
            this.panelControl2.Controls.Add(this.txtTenDN);
            this.panelControl2.Controls.Add(mADOANHNGHIEPLabel);
            this.panelControl2.Controls.Add(this.txtMaDN);
            this.panelControl2.Location = new System.Drawing.Point(204, 350);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(696, 177);
            this.panelControl2.TabIndex = 7;
            // 
            // txtMaChuDN
            // 
            this.txtMaChuDN.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsDN, "MACHU", true));
            this.txtMaChuDN.Enabled = false;
            this.txtMaChuDN.Location = new System.Drawing.Point(527, 95);
            this.txtMaChuDN.MenuManager = this.barManager1;
            this.txtMaChuDN.Name = "txtMaChuDN";
            this.txtMaChuDN.Size = new System.Drawing.Size(125, 22);
            this.txtMaChuDN.TabIndex = 11;
            // 
            // txtSDT
            // 
            this.txtSDT.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsDN, "SODIENTHOAI", true));
            this.txtSDT.Location = new System.Drawing.Point(527, 61);
            this.txtSDT.MenuManager = this.barManager1;
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(125, 22);
            this.txtSDT.TabIndex = 9;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsDN, "DIACHI", true));
            this.txtDiaChi.Location = new System.Drawing.Point(527, 27);
            this.txtDiaChi.MenuManager = this.barManager1;
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(125, 22);
            this.txtDiaChi.TabIndex = 7;
            // 
            // txtTenNDD
            // 
            this.txtTenNDD.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsDN, "TENNGUOIDAIDIEN", true));
            this.txtTenNDD.Location = new System.Drawing.Point(207, 95);
            this.txtTenNDD.MenuManager = this.barManager1;
            this.txtTenNDD.Name = "txtTenNDD";
            this.txtTenNDD.Size = new System.Drawing.Size(125, 22);
            this.txtTenNDD.TabIndex = 5;
            // 
            // txtTenDN
            // 
            this.txtTenDN.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsDN, "TENDOANHNGHIEP", true));
            this.txtTenDN.Location = new System.Drawing.Point(208, 61);
            this.txtTenDN.MenuManager = this.barManager1;
            this.txtTenDN.Name = "txtTenDN";
            this.txtTenDN.Size = new System.Drawing.Size(125, 22);
            this.txtTenDN.TabIndex = 3;
            // 
            // txtMaDN
            // 
            this.txtMaDN.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsDN, "MADOANHNGHIEP", true));
            this.txtMaDN.Location = new System.Drawing.Point(208, 30);
            this.txtMaDN.MenuManager = this.barManager1;
            this.txtMaDN.Name = "txtMaDN";
            this.txtMaDN.Size = new System.Drawing.Size(125, 22);
            this.txtMaDN.TabIndex = 1;
            // 
            // frmChuDN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1138, 530);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.gcDoanhNghiep);
            this.Controls.Add(this.gcChu);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmChuDN";
            this.Text = "frmChuDN";
            this.Load += new System.EventHandler(this.frmChuDN_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCMB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcChu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDoanhNghiep)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaChu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaChuDN.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSDT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiaChi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenNDD.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenDN.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaDN.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem btnThem;
        private DevExpress.XtraBars.BarButtonItem btnXoa;
        private DevExpress.XtraBars.BarButtonItem btnGhi;
        private DevExpress.XtraBars.BarButtonItem btnPhucHoi;
        private DevExpress.XtraBars.BarButtonItem btnReload;
        private DevExpress.XtraBars.BarButtonItem btnThoat;
        private System.Windows.Forms.BindingSource bdsCMB;
        private DS DS;
        private DSTableAdapters.CHUMAYBAYTableAdapter cHUMAYBAYTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl gcChu;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DSTableAdapters.DOANHNGHIEPTableAdapter dOANHNGHIEPTableAdapter;
        private System.Windows.Forms.BindingSource bdsDN;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.DataGridView gcDoanhNghiep;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DevExpress.XtraEditors.TextEdit txtMaChu;
        private DevExpress.XtraEditors.TextEdit txtMaChuDN;
        private DevExpress.XtraEditors.TextEdit txtSDT;
        private DevExpress.XtraEditors.TextEdit txtDiaChi;
        private DevExpress.XtraEditors.TextEdit txtTenNDD;
        private DevExpress.XtraEditors.TextEdit txtTenDN;
        private DevExpress.XtraEditors.TextEdit txtMaDN;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btnThemDN;
        private System.Windows.Forms.ToolStripMenuItem btnHieuChinhDN;
        private System.Windows.Forms.ToolStripMenuItem btnXoaDN;
        private System.Windows.Forms.ToolStripMenuItem btnGhiDN;
        private System.Windows.Forms.ToolStripMenuItem btnPhucHoiDN;
    }
}