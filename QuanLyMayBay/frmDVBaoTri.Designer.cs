namespace QuanLyMayBay
{
    partial class frmDVBaoTri
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
            System.Windows.Forms.Label iDDVBTLabel;
            System.Windows.Forms.Label nGAYGIOLabel;
            System.Windows.Forms.Label sOGIOBAOTRILabel;
            System.Windows.Forms.Label cONGVIECLabel;
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
            this.bdsDVBT = new System.Windows.Forms.BindingSource(this.components);
            this.dICHVUBAOTRITableAdapter = new QuanLyMayBay.DSTableAdapters.DICHVUBAOTRITableAdapter();
            this.tableAdapterManager = new QuanLyMayBay.DSTableAdapters.TableAdapterManager();
            this.mAYBAYTableAdapter = new QuanLyMayBay.DSTableAdapters.MAYBAYTableAdapter();
            this.nHANVIENTableAdapter = new QuanLyMayBay.DSTableAdapters.NHANVIENTableAdapter();
            this.gcDVBT = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIDDVBT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMANV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMADANGKY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAYGIO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOGIOBAOTRI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCONGVIEC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.maNVCheckSua = new DevExpress.XtraEditors.TextEdit();
            this.cmbMaDK = new System.Windows.Forms.ComboBox();
            this.getCacMayBayMaNhanVienChuyenVeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCongViec = new DevExpress.XtraEditors.TextEdit();
            this.txtSoGioBT = new DevExpress.XtraEditors.SpinEdit();
            this.dtpNgayGio = new DevExpress.XtraEditors.DateEdit();
            this.txtMaDK = new DevExpress.XtraEditors.TextEdit();
            this.txtMaNV = new DevExpress.XtraEditors.TextEdit();
            this.txtIDDVBT = new DevExpress.XtraEditors.TextEdit();
            this.bdsMB = new System.Windows.Forms.BindingSource(this.components);
            this.bdsNV = new System.Windows.Forms.BindingSource(this.components);
            this.getCacMayBayMaNhanVienChuyenVeTableAdapter = new QuanLyMayBay.DSTableAdapters.GetCacMayBayMaNhanVienChuyenVeTableAdapter();
            iDDVBTLabel = new System.Windows.Forms.Label();
            nGAYGIOLabel = new System.Windows.Forms.Label();
            sOGIOBAOTRILabel = new System.Windows.Forms.Label();
            cONGVIECLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDVBT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDVBT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maNVCheckSua.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getCacMayBayMaNhanVienChuyenVeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCongViec.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoGioBT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpNgayGio.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpNgayGio.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaDK.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaNV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIDDVBT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsMB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsNV)).BeginInit();
            this.SuspendLayout();
            // 
            // iDDVBTLabel
            // 
            iDDVBTLabel.AutoSize = true;
            iDDVBTLabel.Location = new System.Drawing.Point(96, 30);
            iDDVBTLabel.Name = "iDDVBTLabel";
            iDDVBTLabel.Size = new System.Drawing.Size(55, 16);
            iDDVBTLabel.TabIndex = 0;
            iDDVBTLabel.Text = "IDDVBT:";
            // 
            // nGAYGIOLabel
            // 
            nGAYGIOLabel.AutoSize = true;
            nGAYGIOLabel.Location = new System.Drawing.Point(378, 30);
            nGAYGIOLabel.Name = "nGAYGIOLabel";
            nGAYGIOLabel.Size = new System.Drawing.Size(40, 16);
            nGAYGIOLabel.TabIndex = 6;
            nGAYGIOLabel.Text = "Ngày:";
            // 
            // sOGIOBAOTRILabel
            // 
            sOGIOBAOTRILabel.AutoSize = true;
            sOGIOBAOTRILabel.Location = new System.Drawing.Point(378, 66);
            sOGIOBAOTRILabel.Name = "sOGIOBAOTRILabel";
            sOGIOBAOTRILabel.Size = new System.Drawing.Size(89, 16);
            sOGIOBAOTRILabel.TabIndex = 8;
            sOGIOBAOTRILabel.Text = "Số giờ bảo trì:";
            // 
            // cONGVIECLabel
            // 
            cONGVIECLabel.AutoSize = true;
            cONGVIECLabel.Location = new System.Drawing.Point(378, 106);
            cONGVIECLabel.Name = "cONGVIECLabel";
            cONGVIECLabel.Size = new System.Drawing.Size(67, 16);
            cONGVIECLabel.TabIndex = 10;
            cONGVIECLabel.Text = "Công việc:";
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
            this.barDockControlTop.Size = new System.Drawing.Size(1064, 25);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 468);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1064, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 25);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 443);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1064, 25);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 443);
            // 
            // DS
            // 
            this.DS.DataSetName = "DS";
            this.DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsDVBT
            // 
            this.bdsDVBT.DataMember = "DICHVUBAOTRI";
            this.bdsDVBT.DataSource = this.DS;
            // 
            // dICHVUBAOTRITableAdapter
            // 
            this.dICHVUBAOTRITableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CHUMAYBAYTableAdapter = null;
            this.tableAdapterManager.CHUYENVETableAdapter = null;
            this.tableAdapterManager.DICHVUBAOTRITableAdapter = this.dICHVUBAOTRITableAdapter;
            this.tableAdapterManager.DOANHNGHIEPTableAdapter = null;
            this.tableAdapterManager.LAITableAdapter = null;
            this.tableAdapterManager.LOAIMAYBAYTableAdapter = null;
            this.tableAdapterManager.MAYBAYTableAdapter = this.mAYBAYTableAdapter;
            this.tableAdapterManager.NGUOITableAdapter = null;
            this.tableAdapterManager.NHACHUAMAYBAYTableAdapter = null;
            this.tableAdapterManager.NHANVIENTableAdapter = this.nHANVIENTableAdapter;
            this.tableAdapterManager.PHICONGTableAdapter = null;
            this.tableAdapterManager.SOHUUTableAdapter = null;
            this.tableAdapterManager.ThongTinNhanVienTableAdapter = null;
            this.tableAdapterManager.ThongTinPhiCongTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QuanLyMayBay.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // mAYBAYTableAdapter
            // 
            this.mAYBAYTableAdapter.ClearBeforeFill = true;
            // 
            // nHANVIENTableAdapter
            // 
            this.nHANVIENTableAdapter.ClearBeforeFill = true;
            // 
            // gcDVBT
            // 
            this.gcDVBT.DataSource = this.bdsDVBT;
            this.gcDVBT.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcDVBT.Location = new System.Drawing.Point(0, 25);
            this.gcDVBT.MainView = this.gridView1;
            this.gcDVBT.MenuManager = this.barManager1;
            this.gcDVBT.Name = "gcDVBT";
            this.gcDVBT.Size = new System.Drawing.Size(1064, 223);
            this.gcDVBT.TabIndex = 5;
            this.gcDVBT.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIDDVBT,
            this.colMANV,
            this.colMADANGKY,
            this.colNGAYGIO,
            this.colSOGIOBAOTRI,
            this.colCONGVIEC});
            this.gridView1.GridControl = this.gcDVBT;
            this.gridView1.Name = "gridView1";
            // 
            // colIDDVBT
            // 
            this.colIDDVBT.FieldName = "IDDVBT";
            this.colIDDVBT.MinWidth = 25;
            this.colIDDVBT.Name = "colIDDVBT";
            this.colIDDVBT.Visible = true;
            this.colIDDVBT.VisibleIndex = 0;
            this.colIDDVBT.Width = 94;
            // 
            // colMANV
            // 
            this.colMANV.FieldName = "MANV";
            this.colMANV.MinWidth = 25;
            this.colMANV.Name = "colMANV";
            this.colMANV.Visible = true;
            this.colMANV.VisibleIndex = 1;
            this.colMANV.Width = 94;
            // 
            // colMADANGKY
            // 
            this.colMADANGKY.FieldName = "MADANGKY";
            this.colMADANGKY.MinWidth = 25;
            this.colMADANGKY.Name = "colMADANGKY";
            this.colMADANGKY.Visible = true;
            this.colMADANGKY.VisibleIndex = 2;
            this.colMADANGKY.Width = 94;
            // 
            // colNGAYGIO
            // 
            this.colNGAYGIO.FieldName = "NGAYGIO";
            this.colNGAYGIO.MinWidth = 25;
            this.colNGAYGIO.Name = "colNGAYGIO";
            this.colNGAYGIO.Visible = true;
            this.colNGAYGIO.VisibleIndex = 3;
            this.colNGAYGIO.Width = 94;
            // 
            // colSOGIOBAOTRI
            // 
            this.colSOGIOBAOTRI.FieldName = "SOGIOBAOTRI";
            this.colSOGIOBAOTRI.MinWidth = 25;
            this.colSOGIOBAOTRI.Name = "colSOGIOBAOTRI";
            this.colSOGIOBAOTRI.Visible = true;
            this.colSOGIOBAOTRI.VisibleIndex = 4;
            this.colSOGIOBAOTRI.Width = 94;
            // 
            // colCONGVIEC
            // 
            this.colCONGVIEC.FieldName = "CONGVIEC";
            this.colCONGVIEC.MinWidth = 25;
            this.colCONGVIEC.Name = "colCONGVIEC";
            this.colCONGVIEC.Visible = true;
            this.colCONGVIEC.VisibleIndex = 5;
            this.colCONGVIEC.Width = 94;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.maNVCheckSua);
            this.panelControl1.Controls.Add(this.cmbMaDK);
            this.panelControl1.Controls.Add(this.label2);
            this.panelControl1.Controls.Add(this.label1);
            this.panelControl1.Controls.Add(cONGVIECLabel);
            this.panelControl1.Controls.Add(this.txtCongViec);
            this.panelControl1.Controls.Add(sOGIOBAOTRILabel);
            this.panelControl1.Controls.Add(this.txtSoGioBT);
            this.panelControl1.Controls.Add(nGAYGIOLabel);
            this.panelControl1.Controls.Add(this.dtpNgayGio);
            this.panelControl1.Controls.Add(this.txtMaDK);
            this.panelControl1.Controls.Add(this.txtMaNV);
            this.panelControl1.Controls.Add(iDDVBTLabel);
            this.panelControl1.Controls.Add(this.txtIDDVBT);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 248);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1064, 220);
            this.panelControl1.TabIndex = 6;
            this.panelControl1.Paint += new System.Windows.Forms.PaintEventHandler(this.panelControl1_Paint);
            // 
            // maNVCheckSua
            // 
            this.maNVCheckSua.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsDVBT, "MANV", true));
            this.maNVCheckSua.Location = new System.Drawing.Point(863, 42);
            this.maNVCheckSua.MenuManager = this.barManager1;
            this.maNVCheckSua.Name = "maNVCheckSua";
            this.maNVCheckSua.Size = new System.Drawing.Size(125, 22);
            this.maNVCheckSua.TabIndex = 17;
            this.maNVCheckSua.Visible = false;
            // 
            // cmbMaDK
            // 
            this.cmbMaDK.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.getCacMayBayMaNhanVienChuyenVeBindingSource, "MADANGKY", true));
            this.cmbMaDK.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bdsDVBT, "MADANGKY", true));
            this.cmbMaDK.DataSource = this.getCacMayBayMaNhanVienChuyenVeBindingSource;
            this.cmbMaDK.DisplayMember = "MADANGKY";
            this.cmbMaDK.FormattingEnabled = true;
            this.cmbMaDK.Location = new System.Drawing.Point(175, 106);
            this.cmbMaDK.Name = "cmbMaDK";
            this.cmbMaDK.Size = new System.Drawing.Size(125, 24);
            this.cmbMaDK.TabIndex = 16;
            this.cmbMaDK.ValueMember = "MADANGKY";
            this.cmbMaDK.SelectedIndexChanged += new System.EventHandler(this.cmbMaDK_SelectedIndexChanged);
            // 
            // getCacMayBayMaNhanVienChuyenVeBindingSource
            // 
            this.getCacMayBayMaNhanVienChuyenVeBindingSource.DataMember = "GetCacMayBayMaNhanVienChuyenVe";
            this.getCacMayBayMaNhanVienChuyenVeBindingSource.DataSource = this.DS;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(74, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "Mã đăng ký:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "Mã nhân viên:";
            // 
            // txtCongViec
            // 
            this.txtCongViec.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsDVBT, "CONGVIEC", true));
            this.txtCongViec.Location = new System.Drawing.Point(482, 100);
            this.txtCongViec.MenuManager = this.barManager1;
            this.txtCongViec.Name = "txtCongViec";
            this.txtCongViec.Size = new System.Drawing.Size(255, 22);
            this.txtCongViec.TabIndex = 11;
            // 
            // txtSoGioBT
            // 
            this.txtSoGioBT.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsDVBT, "SOGIOBAOTRI", true));
            this.txtSoGioBT.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtSoGioBT.Location = new System.Drawing.Point(482, 62);
            this.txtSoGioBT.MenuManager = this.barManager1;
            this.txtSoGioBT.Name = "txtSoGioBT";
            this.txtSoGioBT.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtSoGioBT.Properties.MaxValue = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.txtSoGioBT.Properties.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtSoGioBT.Size = new System.Drawing.Size(125, 24);
            this.txtSoGioBT.TabIndex = 9;
            // 
            // dtpNgayGio
            // 
            this.dtpNgayGio.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsDVBT, "NGAYGIO", true));
            this.dtpNgayGio.EditValue = null;
            this.dtpNgayGio.Location = new System.Drawing.Point(482, 27);
            this.dtpNgayGio.MenuManager = this.barManager1;
            this.dtpNgayGio.Name = "dtpNgayGio";
            this.dtpNgayGio.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpNgayGio.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpNgayGio.Size = new System.Drawing.Size(125, 22);
            this.dtpNgayGio.TabIndex = 7;
            // 
            // txtMaDK
            // 
            this.txtMaDK.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsDVBT, "MADANGKY", true));
            this.txtMaDK.Enabled = false;
            this.txtMaDK.Location = new System.Drawing.Point(175, 156);
            this.txtMaDK.MenuManager = this.barManager1;
            this.txtMaDK.Name = "txtMaDK";
            this.txtMaDK.Size = new System.Drawing.Size(125, 22);
            this.txtMaDK.TabIndex = 5;
            this.txtMaDK.Visible = false;
            // 
            // txtMaNV
            // 
            this.txtMaNV.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsDVBT, "MANV", true));
            this.txtMaNV.Enabled = false;
            this.txtMaNV.Location = new System.Drawing.Point(178, 64);
            this.txtMaNV.MenuManager = this.barManager1;
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(122, 22);
            this.txtMaNV.TabIndex = 3;
            this.txtMaNV.EditValueChanged += new System.EventHandler(this.txtMaNV_EditValueChanged);
            // 
            // txtIDDVBT
            // 
            this.txtIDDVBT.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsDVBT, "IDDVBT", true));
            this.txtIDDVBT.Location = new System.Drawing.Point(178, 27);
            this.txtIDDVBT.MenuManager = this.barManager1;
            this.txtIDDVBT.Name = "txtIDDVBT";
            this.txtIDDVBT.Size = new System.Drawing.Size(121, 22);
            this.txtIDDVBT.TabIndex = 1;
            // 
            // bdsMB
            // 
            this.bdsMB.DataMember = "MAYBAY";
            this.bdsMB.DataSource = this.DS;
            // 
            // bdsNV
            // 
            this.bdsNV.DataMember = "NHANVIEN";
            this.bdsNV.DataSource = this.DS;
            // 
            // getCacMayBayMaNhanVienChuyenVeTableAdapter
            // 
            this.getCacMayBayMaNhanVienChuyenVeTableAdapter.ClearBeforeFill = true;
            // 
            // frmDVBaoTri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1064, 468);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.gcDVBT);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmDVBaoTri";
            this.Text = "frmDVBaoTri";
            this.Load += new System.EventHandler(this.frmDVBaoTri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDVBT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDVBT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maNVCheckSua.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getCacMayBayMaNhanVienChuyenVeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCongViec.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoGioBT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpNgayGio.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpNgayGio.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaDK.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaNV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIDDVBT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsMB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsNV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem btnThem;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem btnHieuChinh;
        private DevExpress.XtraBars.BarButtonItem btnXoa;
        private DevExpress.XtraBars.BarButtonItem btnGhi;
        private DevExpress.XtraBars.BarButtonItem btnPhucHoi;
        private DevExpress.XtraBars.BarButtonItem btnReload;
        private DevExpress.XtraBars.BarButtonItem btnThoat;
        private System.Windows.Forms.BindingSource bdsDVBT;
        private DS DS;
        private DSTableAdapters.DICHVUBAOTRITableAdapter dICHVUBAOTRITableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.TextEdit txtCongViec;
        private DevExpress.XtraEditors.SpinEdit txtSoGioBT;
        private DevExpress.XtraEditors.DateEdit dtpNgayGio;
        private DevExpress.XtraEditors.TextEdit txtMaDK;
        private DevExpress.XtraEditors.TextEdit txtMaNV;
        private DevExpress.XtraEditors.TextEdit txtIDDVBT;
        private DevExpress.XtraGrid.GridControl gcDVBT;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colIDDVBT;
        private DevExpress.XtraGrid.Columns.GridColumn colMANV;
        private DevExpress.XtraGrid.Columns.GridColumn colMADANGKY;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAYGIO;
        private DevExpress.XtraGrid.Columns.GridColumn colSOGIOBAOTRI;
        private DevExpress.XtraGrid.Columns.GridColumn colCONGVIEC;
        private DSTableAdapters.NHANVIENTableAdapter nHANVIENTableAdapter;
        private System.Windows.Forms.BindingSource bdsNV;
        private DSTableAdapters.MAYBAYTableAdapter mAYBAYTableAdapter;
        private System.Windows.Forms.BindingSource bdsMB;
        private System.Windows.Forms.BindingSource getCacMayBayMaNhanVienChuyenVeBindingSource;
        private DSTableAdapters.GetCacMayBayMaNhanVienChuyenVeTableAdapter getCacMayBayMaNhanVienChuyenVeTableAdapter;
        private System.Windows.Forms.ComboBox cmbMaDK;
        private DevExpress.XtraEditors.TextEdit maNVCheckSua;
    }
}