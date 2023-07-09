namespace QuanLyMayBay
{
    partial class frmMayBay
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
            System.Windows.Forms.Label mADANGKYLabel;
            System.Windows.Forms.Label mADANGKYLabel1;
            System.Windows.Forms.Label mACHULabel;
            System.Windows.Forms.Label nGAYBATDAULabel;
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btnThem = new DevExpress.XtraBars.BarButtonItem();
            this.btnHieuChinh = new DevExpress.XtraBars.BarButtonItem();
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
            this.bdsMB = new System.Windows.Forms.BindingSource(this.components);
            this.mAYBAYTableAdapter = new QuanLyMayBay.DSTableAdapters.MAYBAYTableAdapter();
            this.tableAdapterManager = new QuanLyMayBay.DSTableAdapters.TableAdapterManager();
            this.gcMayBay = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMADANGKY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMALOAI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMANHACHUA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtMaDK = new DevExpress.XtraEditors.TextEdit();
            this.txtMaNC = new System.Windows.Forms.TextBox();
            this.txtMaLoai = new System.Windows.Forms.TextBox();
            this.cmb_NhaChuaMB = new System.Windows.Forms.ComboBox();
            this.bds_cb_NhaChuaMayBay = new System.Windows.Forms.BindingSource(this.components);
            this.cmb_LoaiMB = new System.Windows.Forms.ComboBox();
            this.bds_cb_loaiMB = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cB_LOAIMAYBAYTableAdapter = new QuanLyMayBay.DSTableAdapters.CB_LOAIMAYBAYTableAdapter();
            this.cB_NHACHUAMAYBAYTableAdapter = new QuanLyMayBay.DSTableAdapters.CB_NHACHUAMAYBAYTableAdapter();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbMACHU = new System.Windows.Forms.ComboBox();
            this.bdsCMB = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.cHUMAYBAYTableAdapter = new QuanLyMayBay.DSTableAdapters.CHUMAYBAYTableAdapter();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnTHEMSH = new System.Windows.Forms.ToolStripMenuItem();
            this.btnXOASH = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSUASH = new System.Windows.Forms.ToolStripMenuItem();
            this.btnGHISH = new System.Windows.Forms.ToolStripMenuItem();
            this.btnHUYSH = new System.Windows.Forms.ToolStripMenuItem();
            this.bdsSOHUU = new System.Windows.Forms.BindingSource(this.components);
            this.sOHUUTableAdapter = new QuanLyMayBay.DSTableAdapters.SOHUUTableAdapter();
            this.gcSOHUU = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtMDKSOHUU = new DevExpress.XtraEditors.TextEdit();
            this.txtMACHU = new DevExpress.XtraEditors.TextEdit();
            this.txtNGAYBD = new DevExpress.XtraEditors.DateEdit();
            mADANGKYLabel = new System.Windows.Forms.Label();
            mADANGKYLabel1 = new System.Windows.Forms.Label();
            mACHULabel = new System.Windows.Forms.Label();
            nGAYBATDAULabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsMB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcMayBay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaDK.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds_cb_NhaChuaMayBay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds_cb_loaiMB)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCMB)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsSOHUU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcSOHUU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMDKSOHUU.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMACHU.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNGAYBD.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNGAYBD.Properties.CalendarTimeProperties)).BeginInit();
            this.SuspendLayout();
            // 
            // mADANGKYLabel
            // 
            mADANGKYLabel.AutoSize = true;
            mADANGKYLabel.Location = new System.Drawing.Point(92, 40);
            mADANGKYLabel.Name = "mADANGKYLabel";
            mADANGKYLabel.Size = new System.Drawing.Size(80, 16);
            mADANGKYLabel.TabIndex = 0;
            mADANGKYLabel.Text = "Mã đăng ký:";
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
            this.btnHieuChinh,
            this.btnXoa,
            this.btnGhi,
            this.btnPhucHoi,
            this.btnReload,
            this.btnThoat});
            this.barManager1.MaxItemId = 7;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnThem),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnHieuChinh),
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
            this.btnThem.Name = "btnThem";
            this.btnThem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThem_ItemClick);
            // 
            // btnHieuChinh
            // 
            this.btnHieuChinh.Caption = "Hiệu chỉnh";
            this.btnHieuChinh.Id = 1;
            this.btnHieuChinh.Name = "btnHieuChinh";
            this.btnHieuChinh.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnHieuChinh_ItemClick);
            // 
            // btnXoa
            // 
            this.btnXoa.Caption = "Xóa";
            this.btnXoa.Id = 2;
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXoa_ItemClick);
            // 
            // btnGhi
            // 
            this.btnGhi.Caption = "Ghi";
            this.btnGhi.Id = 3;
            this.btnGhi.Name = "btnGhi";
            this.btnGhi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnGhi_ItemClick);
            // 
            // btnPhucHoi
            // 
            this.btnPhucHoi.Caption = "Hủy Thao Tác";
            this.btnPhucHoi.Id = 4;
            this.btnPhucHoi.Name = "btnPhucHoi";
            this.btnPhucHoi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPhucHoi_ItemClick);
            // 
            // btnReload
            // 
            this.btnReload.Caption = "Reload";
            this.btnReload.Id = 5;
            this.btnReload.Name = "btnReload";
            this.btnReload.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnReload_ItemClick);
            // 
            // btnThoat
            // 
            this.btnThoat.Caption = "Thoát";
            this.btnThoat.Id = 6;
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThoat_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1333, 25);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 539);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1333, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 25);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 514);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1333, 25);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 514);
            // 
            // DS
            // 
            this.DS.DataSetName = "DS";
            this.DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsMB
            // 
            this.bdsMB.DataMember = "MAYBAY";
            this.bdsMB.DataSource = this.DS;
            // 
            // mAYBAYTableAdapter
            // 
            this.mAYBAYTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CHUMAYBAYTableAdapter = null;
            this.tableAdapterManager.CHUYENVETableAdapter = null;
            this.tableAdapterManager.DICHVUBAOTRITableAdapter = null;
            this.tableAdapterManager.DOANHNGHIEPTableAdapter = null;
            this.tableAdapterManager.LAITableAdapter = null;
            this.tableAdapterManager.LOAIMAYBAYTableAdapter = null;
            this.tableAdapterManager.MAYBAYTableAdapter = this.mAYBAYTableAdapter;
            this.tableAdapterManager.NGUOITableAdapter = null;
            this.tableAdapterManager.NHACHUAMAYBAYTableAdapter = null;
            this.tableAdapterManager.NHANVIENTableAdapter = null;
            this.tableAdapterManager.PHICONGTableAdapter = null;
            this.tableAdapterManager.SOHUUTableAdapter = null;
            this.tableAdapterManager.ThongTinNhanVienTableAdapter = null;
            this.tableAdapterManager.ThongTinPhiCongTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QuanLyMayBay.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // gcMayBay
            // 
            this.gcMayBay.DataSource = this.bdsMB;
            this.gcMayBay.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcMayBay.Location = new System.Drawing.Point(0, 25);
            this.gcMayBay.MainView = this.gridView1;
            this.gcMayBay.MenuManager = this.barManager1;
            this.gcMayBay.Name = "gcMayBay";
            this.gcMayBay.Size = new System.Drawing.Size(1333, 220);
            this.gcMayBay.TabIndex = 5;
            this.gcMayBay.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMADANGKY,
            this.colMALOAI,
            this.colMANHACHUA});
            this.gridView1.GridControl = this.gcMayBay;
            this.gridView1.Name = "gridView1";
            // 
            // colMADANGKY
            // 
            this.colMADANGKY.FieldName = "MADANGKY";
            this.colMADANGKY.MinWidth = 25;
            this.colMADANGKY.Name = "colMADANGKY";
            this.colMADANGKY.Visible = true;
            this.colMADANGKY.VisibleIndex = 0;
            this.colMADANGKY.Width = 94;
            // 
            // colMALOAI
            // 
            this.colMALOAI.FieldName = "MALOAI";
            this.colMALOAI.MinWidth = 25;
            this.colMALOAI.Name = "colMALOAI";
            this.colMALOAI.Visible = true;
            this.colMALOAI.VisibleIndex = 1;
            this.colMALOAI.Width = 94;
            // 
            // colMANHACHUA
            // 
            this.colMANHACHUA.FieldName = "MANHACHUA";
            this.colMANHACHUA.MinWidth = 25;
            this.colMANHACHUA.Name = "colMANHACHUA";
            this.colMANHACHUA.Visible = true;
            this.colMANHACHUA.VisibleIndex = 2;
            this.colMANHACHUA.Width = 94;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtMaDK);
            this.groupBox1.Controls.Add(this.txtMaNC);
            this.groupBox1.Controls.Add(this.txtMaLoai);
            this.groupBox1.Controls.Add(this.cmb_NhaChuaMB);
            this.groupBox1.Controls.Add(this.cmb_LoaiMB);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(mADANGKYLabel);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(0, 245);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(474, 294);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtMaDK
            // 
            this.txtMaDK.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsMB, "MADANGKY", true));
            this.txtMaDK.Location = new System.Drawing.Point(184, 37);
            this.txtMaDK.MenuManager = this.barManager1;
            this.txtMaDK.Name = "txtMaDK";
            this.txtMaDK.Size = new System.Drawing.Size(140, 22);
            this.txtMaDK.TabIndex = 13;
            // 
            // txtMaNC
            // 
            this.txtMaNC.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsMB, "MANHACHUA", true));
            this.txtMaNC.Location = new System.Drawing.Point(188, 207);
            this.txtMaNC.Name = "txtMaNC";
            this.txtMaNC.ReadOnly = true;
            this.txtMaNC.Size = new System.Drawing.Size(100, 22);
            this.txtMaNC.TabIndex = 12;
            this.txtMaNC.Visible = false;
            // 
            // txtMaLoai
            // 
            this.txtMaLoai.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsMB, "MALOAI", true));
            this.txtMaLoai.Location = new System.Drawing.Point(188, 167);
            this.txtMaLoai.Name = "txtMaLoai";
            this.txtMaLoai.ReadOnly = true;
            this.txtMaLoai.Size = new System.Drawing.Size(100, 22);
            this.txtMaLoai.TabIndex = 11;
            this.txtMaLoai.Visible = false;
            // 
            // cmb_NhaChuaMB
            // 
            this.cmb_NhaChuaMB.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bds_cb_NhaChuaMayBay, "NHACHUA", true));
            this.cmb_NhaChuaMB.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bdsMB, "MANHACHUA", true));
            this.cmb_NhaChuaMB.DataSource = this.bds_cb_NhaChuaMayBay;
            this.cmb_NhaChuaMB.DisplayMember = "NHACHUA";
            this.cmb_NhaChuaMB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_NhaChuaMB.Location = new System.Drawing.Point(184, 117);
            this.cmb_NhaChuaMB.Name = "cmb_NhaChuaMB";
            this.cmb_NhaChuaMB.Size = new System.Drawing.Size(241, 24);
            this.cmb_NhaChuaMB.TabIndex = 10;
            this.cmb_NhaChuaMB.ValueMember = "MANHACHUA";
            this.cmb_NhaChuaMB.SelectedIndexChanged += new System.EventHandler(this.cmbNhaChuaMB_SelectedIndexChanged);
            // 
            // bds_cb_NhaChuaMayBay
            // 
            this.bds_cb_NhaChuaMayBay.DataMember = "CB_NHACHUAMAYBAY";
            this.bds_cb_NhaChuaMayBay.DataSource = this.DS;
            // 
            // cmb_LoaiMB
            // 
            this.cmb_LoaiMB.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bds_cb_loaiMB, "LOAI", true));
            this.cmb_LoaiMB.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bdsMB, "MALOAI", true));
            this.cmb_LoaiMB.DataSource = this.bds_cb_loaiMB;
            this.cmb_LoaiMB.DisplayMember = "LOAI";
            this.cmb_LoaiMB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_LoaiMB.FormattingEnabled = true;
            this.cmb_LoaiMB.Location = new System.Drawing.Point(184, 79);
            this.cmb_LoaiMB.Name = "cmb_LoaiMB";
            this.cmb_LoaiMB.Size = new System.Drawing.Size(241, 24);
            this.cmb_LoaiMB.TabIndex = 9;
            this.cmb_LoaiMB.ValueMember = "MALOAI";
            this.cmb_LoaiMB.SelectedIndexChanged += new System.EventHandler(this.lOAIComboBox_SelectedIndexChanged);
            // 
            // bds_cb_loaiMB
            // 
            this.bds_cb_loaiMB.DataMember = "CB_LOAIMAYBAY";
            this.bds_cb_loaiMB.DataSource = this.DS;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(105, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nhà chứa:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Loại máy bay:";
            // 
            // cB_LOAIMAYBAYTableAdapter
            // 
            this.cB_LOAIMAYBAYTableAdapter.ClearBeforeFill = true;
            // 
            // cB_NHACHUAMAYBAYTableAdapter
            // 
            this.cB_NHACHUAMAYBAYTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(nGAYBATDAULabel);
            this.groupBox2.Controls.Add(this.txtNGAYBD);
            this.groupBox2.Controls.Add(mACHULabel);
            this.groupBox2.Controls.Add(this.txtMACHU);
            this.groupBox2.Controls.Add(mADANGKYLabel1);
            this.groupBox2.Controls.Add(this.txtMDKSOHUU);
            this.groupBox2.Controls.Add(this.cmbMACHU);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox2.Location = new System.Drawing.Point(474, 245);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(304, 294);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            // 
            // cmbMACHU
            // 
            this.cmbMACHU.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bdsSOHUU, "MACHU", true));
            this.cmbMACHU.DataSource = this.bdsCMB;
            this.cmbMACHU.DisplayMember = "MACHU";
            this.cmbMACHU.FormattingEnabled = true;
            this.cmbMACHU.Location = new System.Drawing.Point(147, 68);
            this.cmbMACHU.Name = "cmbMACHU";
            this.cmbMACHU.Size = new System.Drawing.Size(125, 24);
            this.cmbMACHU.TabIndex = 7;
            this.cmbMACHU.ValueMember = "MACHU";
            this.cmbMACHU.SelectedIndexChanged += new System.EventHandler(this.cmbMACHU_SelectedIndexChanged);
            // 
            // bdsCMB
            // 
            this.bdsCMB.DataMember = "CHUMAYBAY";
            this.bdsCMB.DataSource = this.DS;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Mã chủ:";
            // 
            // cHUMAYBAYTableAdapter
            // 
            this.cHUMAYBAYTableAdapter.ClearBeforeFill = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnTHEMSH,
            this.btnXOASH,
            this.btnSUASH,
            this.btnGHISH,
            this.btnHUYSH});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(163, 124);
            // 
            // btnTHEMSH
            // 
            this.btnTHEMSH.Name = "btnTHEMSH";
            this.btnTHEMSH.Size = new System.Drawing.Size(162, 24);
            this.btnTHEMSH.Text = "Thêm";
            this.btnTHEMSH.Click += new System.EventHandler(this.btnThemSH_Click_1);
            // 
            // btnXOASH
            // 
            this.btnXOASH.Name = "btnXOASH";
            this.btnXOASH.Size = new System.Drawing.Size(162, 24);
            this.btnXOASH.Text = "Xóa";
            this.btnXOASH.Click += new System.EventHandler(this.btnXOASH_Click_1);
            // 
            // btnSUASH
            // 
            this.btnSUASH.Name = "btnSUASH";
            this.btnSUASH.Size = new System.Drawing.Size(162, 24);
            this.btnSUASH.Text = "Sửa";
            this.btnSUASH.Click += new System.EventHandler(this.btnSUASH_Click);
            // 
            // btnGHISH
            // 
            this.btnGHISH.Name = "btnGHISH";
            this.btnGHISH.Size = new System.Drawing.Size(162, 24);
            this.btnGHISH.Text = "Ghi";
            this.btnGHISH.Click += new System.EventHandler(this.btnGHISH_Click);
            // 
            // btnHUYSH
            // 
            this.btnHUYSH.Name = "btnHUYSH";
            this.btnHUYSH.Size = new System.Drawing.Size(162, 24);
            this.btnHUYSH.Text = "Hủy thao tác";
            this.btnHUYSH.Click += new System.EventHandler(this.btnHUYSH_Click);
            // 
            // bdsSOHUU
            // 
            this.bdsSOHUU.DataMember = "FK_SOHUU_MAYBAY";
            this.bdsSOHUU.DataSource = this.bdsMB;
            // 
            // sOHUUTableAdapter
            // 
            this.sOHUUTableAdapter.ClearBeforeFill = true;
            // 
            // gcSOHUU
            // 
            this.gcSOHUU.AutoGenerateColumns = false;
            this.gcSOHUU.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gcSOHUU.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.gcSOHUU.ContextMenuStrip = this.contextMenuStrip1;
            this.gcSOHUU.DataSource = this.bdsSOHUU;
            this.gcSOHUU.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcSOHUU.Location = new System.Drawing.Point(778, 245);
            this.gcSOHUU.Name = "gcSOHUU";
            this.gcSOHUU.RowHeadersWidth = 51;
            this.gcSOHUU.RowTemplate.Height = 24;
            this.gcSOHUU.Size = new System.Drawing.Size(555, 294);
            this.gcSOHUU.TabIndex = 23;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MADANGKY";
            this.dataGridViewTextBoxColumn1.HeaderText = "MADANGKY";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "MACHU";
            this.dataGridViewTextBoxColumn2.HeaderText = "MACHU";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "NGAYBATDAU";
            this.dataGridViewTextBoxColumn3.HeaderText = "NGAYBATDAU";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // mADANGKYLabel1
            // 
            mADANGKYLabel1.AutoSize = true;
            mADANGKYLabel1.Location = new System.Drawing.Point(18, 32);
            mADANGKYLabel1.Name = "mADANGKYLabel1";
            mADANGKYLabel1.Size = new System.Drawing.Size(86, 16);
            mADANGKYLabel1.TabIndex = 7;
            mADANGKYLabel1.Text = "MADANGKY:";
            // 
            // txtMDKSOHUU
            // 
            this.txtMDKSOHUU.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsSOHUU, "MADANGKY", true));
            this.txtMDKSOHUU.Enabled = false;
            this.txtMDKSOHUU.Location = new System.Drawing.Point(147, 29);
            this.txtMDKSOHUU.MenuManager = this.barManager1;
            this.txtMDKSOHUU.Name = "txtMDKSOHUU";
            this.txtMDKSOHUU.Size = new System.Drawing.Size(125, 22);
            this.txtMDKSOHUU.TabIndex = 8;
            // 
            // mACHULabel
            // 
            mACHULabel.AutoSize = true;
            mACHULabel.Location = new System.Drawing.Point(45, 243);
            mACHULabel.Name = "mACHULabel";
            mACHULabel.Size = new System.Drawing.Size(0, 16);
            mACHULabel.TabIndex = 8;
            // 
            // txtMACHU
            // 
            this.txtMACHU.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsSOHUU, "MACHU", true));
            this.txtMACHU.Enabled = false;
            this.txtMACHU.Location = new System.Drawing.Point(131, 240);
            this.txtMACHU.MenuManager = this.barManager1;
            this.txtMACHU.Name = "txtMACHU";
            this.txtMACHU.Size = new System.Drawing.Size(125, 22);
            this.txtMACHU.TabIndex = 9;
            this.txtMACHU.Visible = false;
            // 
            // nGAYBATDAULabel
            // 
            nGAYBATDAULabel.AutoSize = true;
            nGAYBATDAULabel.Location = new System.Drawing.Point(21, 117);
            nGAYBATDAULabel.Name = "nGAYBATDAULabel";
            nGAYBATDAULabel.Size = new System.Drawing.Size(104, 16);
            nGAYBATDAULabel.TabIndex = 9;
            nGAYBATDAULabel.Text = "NGAYBATDAU:";
            // 
            // txtNGAYBD
            // 
            this.txtNGAYBD.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsSOHUU, "NGAYBATDAU", true));
            this.txtNGAYBD.EditValue = null;
            this.txtNGAYBD.Location = new System.Drawing.Point(147, 114);
            this.txtNGAYBD.MenuManager = this.barManager1;
            this.txtNGAYBD.Name = "txtNGAYBD";
            this.txtNGAYBD.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtNGAYBD.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtNGAYBD.Size = new System.Drawing.Size(125, 22);
            this.txtNGAYBD.TabIndex = 10;
            // 
            // frmMayBay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1333, 539);
            this.Controls.Add(this.gcSOHUU);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gcMayBay);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmMayBay";
            this.Text = "frmMayBay";
            this.Load += new System.EventHandler(this.frmMayBay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsMB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcMayBay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaDK.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds_cb_NhaChuaMayBay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds_cb_loaiMB)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCMB)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bdsSOHUU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcSOHUU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMDKSOHUU.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMACHU.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNGAYBD.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNGAYBD.Properties)).EndInit();
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
        private DevExpress.XtraBars.BarButtonItem btnHieuChinh;
        private DevExpress.XtraBars.BarButtonItem btnXoa;
        private DevExpress.XtraBars.BarButtonItem btnGhi;
        private DevExpress.XtraBars.BarButtonItem btnPhucHoi;
        private DevExpress.XtraBars.BarButtonItem btnReload;
        private DevExpress.XtraBars.BarButtonItem btnThoat;
        private System.Windows.Forms.BindingSource bdsMB;
        private DS DS;
        private DSTableAdapters.MAYBAYTableAdapter mAYBAYTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraGrid.GridControl gcMayBay;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMADANGKY;
        private DevExpress.XtraGrid.Columns.GridColumn colMALOAI;
        private DevExpress.XtraGrid.Columns.GridColumn colMANHACHUA;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource bds_cb_loaiMB;
        private DSTableAdapters.CB_LOAIMAYBAYTableAdapter cB_LOAIMAYBAYTableAdapter;
        private System.Windows.Forms.ComboBox cmb_LoaiMB;
        private System.Windows.Forms.BindingSource bds_cb_NhaChuaMayBay;
        private DSTableAdapters.CB_NHACHUAMAYBAYTableAdapter cB_NHACHUAMAYBAYTableAdapter;
        private System.Windows.Forms.ComboBox cmb_NhaChuaMB;
        private System.Windows.Forms.TextBox txtMaNC;
        private System.Windows.Forms.TextBox txtMaLoai;
        private DevExpress.XtraEditors.TextEdit txtMaDK;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmbMACHU;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.BindingSource bdsCMB;
        private DSTableAdapters.CHUMAYBAYTableAdapter cHUMAYBAYTableAdapter;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btnTHEMSH;
        private System.Windows.Forms.ToolStripMenuItem btnXOASH;
        private System.Windows.Forms.ToolStripMenuItem btnGHISH;
        private System.Windows.Forms.ToolStripMenuItem btnHUYSH;
        private System.Windows.Forms.ToolStripMenuItem btnSUASH;
        private System.Windows.Forms.BindingSource bdsSOHUU;
        private DSTableAdapters.SOHUUTableAdapter sOHUUTableAdapter;
        private System.Windows.Forms.DataGridView gcSOHUU;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DevExpress.XtraEditors.DateEdit txtNGAYBD;
        private DevExpress.XtraEditors.TextEdit txtMACHU;
        private DevExpress.XtraEditors.TextEdit txtMDKSOHUU;
    }
}