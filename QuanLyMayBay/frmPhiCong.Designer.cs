namespace QuanLyMayBay
{
    partial class frmPhiCong
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
            System.Windows.Forms.Label sOCMNDLabel;
            System.Windows.Forms.Label hOTENLabel;
            System.Windows.Forms.Label dIACHILabel;
            System.Windows.Forms.Label sODIENTHOAILabel;
            System.Windows.Forms.Label sOCMNDLabel1;
            System.Windows.Forms.Label mASOBANGLabel;
            System.Windows.Forms.Label nGAYCAPLabel;
            System.Windows.Forms.Label mAPHICONGLabel;
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
            this.bdsNguoi = new System.Windows.Forms.BindingSource(this.components);
            this.nGUOITableAdapter = new QuanLyMayBay.DSTableAdapters.NGUOITableAdapter();
            this.tableAdapterManager = new QuanLyMayBay.DSTableAdapters.TableAdapterManager();
            this.pHICONGTableAdapter = new QuanLyMayBay.DSTableAdapters.PHICONGTableAdapter();
            this.gcNguoi = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSOCMND = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHOTEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDIACHI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSODIENTHOAI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMACHU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.txtSDT = new DevExpress.XtraEditors.TextEdit();
            this.txtDiaChi = new DevExpress.XtraEditors.TextEdit();
            this.txtHoTen = new DevExpress.XtraEditors.TextEdit();
            this.txtSCMND = new DevExpress.XtraEditors.TextEdit();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.txtMaPC = new DevExpress.XtraEditors.TextEdit();
            this.bdsPC = new System.Windows.Forms.BindingSource(this.components);
            this.dtpNgay = new DevExpress.XtraEditors.DateEdit();
            this.txtMaSoBang = new DevExpress.XtraEditors.TextEdit();
            this.txtSCMNDPC = new DevExpress.XtraEditors.TextEdit();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnThemPC = new System.Windows.Forms.ToolStripMenuItem();
            this.btnHieuChinhPC = new System.Windows.Forms.ToolStripMenuItem();
            this.btnXoaPC = new System.Windows.Forms.ToolStripMenuItem();
            this.btnGhiPC = new System.Windows.Forms.ToolStripMenuItem();
            this.btnPhucHoiPC = new System.Windows.Forms.ToolStripMenuItem();
            this.bdsLai = new System.Windows.Forms.BindingSource(this.components);
            this.lAITableAdapter = new QuanLyMayBay.DSTableAdapters.LAITableAdapter();
            this.pHICONGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gcPC = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            sOCMNDLabel = new System.Windows.Forms.Label();
            hOTENLabel = new System.Windows.Forms.Label();
            dIACHILabel = new System.Windows.Forms.Label();
            sODIENTHOAILabel = new System.Windows.Forms.Label();
            sOCMNDLabel1 = new System.Windows.Forms.Label();
            mASOBANGLabel = new System.Windows.Forms.Label();
            nGAYCAPLabel = new System.Windows.Forms.Label();
            mAPHICONGLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsNguoi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcNguoi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSDT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiaChi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHoTen.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSCMND.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaPC.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsPC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpNgay.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpNgay.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaSoBang.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSCMNDPC.Properties)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLai)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHICONGBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcPC)).BeginInit();
            this.SuspendLayout();
            // 
            // sOCMNDLabel
            // 
            sOCMNDLabel.AutoSize = true;
            sOCMNDLabel.Location = new System.Drawing.Point(24, 29);
            sOCMNDLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            sOCMNDLabel.Name = "sOCMNDLabel";
            sOCMNDLabel.Size = new System.Drawing.Size(65, 16);
            sOCMNDLabel.TabIndex = 0;
            sOCMNDLabel.Text = "Số CMND:";
            // 
            // hOTENLabel
            // 
            hOTENLabel.AutoSize = true;
            hOTENLabel.Location = new System.Drawing.Point(38, 76);
            hOTENLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            hOTENLabel.Name = "hOTENLabel";
            hOTENLabel.Size = new System.Drawing.Size(49, 16);
            hOTENLabel.TabIndex = 2;
            hOTENLabel.Text = "Họ tên:";
            // 
            // dIACHILabel
            // 
            dIACHILabel.AutoSize = true;
            dIACHILabel.Location = new System.Drawing.Point(38, 124);
            dIACHILabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            dIACHILabel.Name = "dIACHILabel";
            dIACHILabel.Size = new System.Drawing.Size(51, 16);
            dIACHILabel.TabIndex = 4;
            dIACHILabel.Text = "Địa chỉ:";
            // 
            // sODIENTHOAILabel
            // 
            sODIENTHOAILabel.AutoSize = true;
            sODIENTHOAILabel.Location = new System.Drawing.Point(54, 174);
            sODIENTHOAILabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            sODIENTHOAILabel.Name = "sODIENTHOAILabel";
            sODIENTHOAILabel.Size = new System.Drawing.Size(36, 16);
            sODIENTHOAILabel.TabIndex = 6;
            sODIENTHOAILabel.Text = "SDT:";
            // 
            // sOCMNDLabel1
            // 
            sOCMNDLabel1.AutoSize = true;
            sOCMNDLabel1.Location = new System.Drawing.Point(46, 29);
            sOCMNDLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            sOCMNDLabel1.Name = "sOCMNDLabel1";
            sOCMNDLabel1.Size = new System.Drawing.Size(65, 16);
            sOCMNDLabel1.TabIndex = 0;
            sOCMNDLabel1.Text = "Số CMND:";
            // 
            // mASOBANGLabel
            // 
            mASOBANGLabel.AutoSize = true;
            mASOBANGLabel.Location = new System.Drawing.Point(28, 75);
            mASOBANGLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            mASOBANGLabel.Name = "mASOBANGLabel";
            mASOBANGLabel.Size = new System.Drawing.Size(78, 16);
            mASOBANGLabel.TabIndex = 2;
            mASOBANGLabel.Text = "Mã số bằng:";
            // 
            // nGAYCAPLabel
            // 
            nGAYCAPLabel.AutoSize = true;
            nGAYCAPLabel.Location = new System.Drawing.Point(42, 122);
            nGAYCAPLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            nGAYCAPLabel.Name = "nGAYCAPLabel";
            nGAYCAPLabel.Size = new System.Drawing.Size(64, 16);
            nGAYCAPLabel.TabIndex = 4;
            nGAYCAPLabel.Text = "Ngày cấp:";
            // 
            // mAPHICONGLabel
            // 
            mAPHICONGLabel.AutoSize = true;
            mAPHICONGLabel.Location = new System.Drawing.Point(20, 170);
            mAPHICONGLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            mAPHICONGLabel.Name = "mAPHICONGLabel";
            mAPHICONGLabel.Size = new System.Drawing.Size(81, 16);
            mAPHICONGLabel.TabIndex = 6;
            mAPHICONGLabel.Text = "Mã phi công:";
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
            this.btnPhucHoi.Caption = "Phục hồi";
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
            this.barDockControlTop.Size = new System.Drawing.Size(1081, 25);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 411);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1081, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 25);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 386);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1081, 25);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 386);
            // 
            // DS
            // 
            this.DS.DataSetName = "DS";
            this.DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsNguoi
            // 
            this.bdsNguoi.DataMember = "NGUOI";
            this.bdsNguoi.DataSource = this.DS;
            // 
            // nGUOITableAdapter
            // 
            this.nGUOITableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.MAYBAYTableAdapter = null;
            this.tableAdapterManager.NGUOITableAdapter = this.nGUOITableAdapter;
            this.tableAdapterManager.NHACHUAMAYBAYTableAdapter = null;
            this.tableAdapterManager.NHANVIENTableAdapter = null;
            this.tableAdapterManager.PHICONGTableAdapter = this.pHICONGTableAdapter;
            this.tableAdapterManager.SOHUUTableAdapter = null;
            this.tableAdapterManager.ThongTinNhanVienTableAdapter = null;
            this.tableAdapterManager.ThongTinPhiCongTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QuanLyMayBay.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // pHICONGTableAdapter
            // 
            this.pHICONGTableAdapter.ClearBeforeFill = true;
            // 
            // gcNguoi
            // 
            this.gcNguoi.DataSource = this.bdsNguoi;
            this.gcNguoi.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcNguoi.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gcNguoi.Location = new System.Drawing.Point(0, 25);
            this.gcNguoi.MainView = this.gridView1;
            this.gcNguoi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gcNguoi.MenuManager = this.barManager1;
            this.gcNguoi.Name = "gcNguoi";
            this.gcNguoi.Size = new System.Drawing.Size(1081, 199);
            this.gcNguoi.TabIndex = 5;
            this.gcNguoi.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSOCMND,
            this.colHOTEN,
            this.colDIACHI,
            this.colSODIENTHOAI,
            this.colMACHU});
            this.gridView1.DetailHeight = 437;
            this.gridView1.GridControl = this.gcNguoi;
            this.gridView1.Name = "gridView1";
            // 
            // colSOCMND
            // 
            this.colSOCMND.FieldName = "SOCMND";
            this.colSOCMND.MinWidth = 31;
            this.colSOCMND.Name = "colSOCMND";
            this.colSOCMND.Visible = true;
            this.colSOCMND.VisibleIndex = 0;
            this.colSOCMND.Width = 117;
            // 
            // colHOTEN
            // 
            this.colHOTEN.FieldName = "HOTEN";
            this.colHOTEN.MinWidth = 31;
            this.colHOTEN.Name = "colHOTEN";
            this.colHOTEN.Visible = true;
            this.colHOTEN.VisibleIndex = 1;
            this.colHOTEN.Width = 117;
            // 
            // colDIACHI
            // 
            this.colDIACHI.FieldName = "DIACHI";
            this.colDIACHI.MinWidth = 31;
            this.colDIACHI.Name = "colDIACHI";
            this.colDIACHI.Visible = true;
            this.colDIACHI.VisibleIndex = 2;
            this.colDIACHI.Width = 117;
            // 
            // colSODIENTHOAI
            // 
            this.colSODIENTHOAI.FieldName = "SODIENTHOAI";
            this.colSODIENTHOAI.MinWidth = 31;
            this.colSODIENTHOAI.Name = "colSODIENTHOAI";
            this.colSODIENTHOAI.Visible = true;
            this.colSODIENTHOAI.VisibleIndex = 3;
            this.colSODIENTHOAI.Width = 117;
            // 
            // colMACHU
            // 
            this.colMACHU.FieldName = "MACHU";
            this.colMACHU.MinWidth = 31;
            this.colMACHU.Name = "colMACHU";
            this.colMACHU.Visible = true;
            this.colMACHU.VisibleIndex = 4;
            this.colMACHU.Width = 117;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(sODIENTHOAILabel);
            this.panelControl1.Controls.Add(this.txtSDT);
            this.panelControl1.Controls.Add(dIACHILabel);
            this.panelControl1.Controls.Add(this.txtDiaChi);
            this.panelControl1.Controls.Add(hOTENLabel);
            this.panelControl1.Controls.Add(this.txtHoTen);
            this.panelControl1.Controls.Add(sOCMNDLabel);
            this.panelControl1.Controls.Add(this.txtSCMND);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelControl1.Location = new System.Drawing.Point(0, 224);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(301, 187);
            this.panelControl1.TabIndex = 6;
            // 
            // txtSDT
            // 
            this.txtSDT.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsNguoi, "SODIENTHOAI", true));
            this.txtSDT.Location = new System.Drawing.Point(124, 166);
            this.txtSDT.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSDT.MenuManager = this.barManager1;
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(156, 22);
            this.txtSDT.TabIndex = 7;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsNguoi, "DIACHI", true));
            this.txtDiaChi.Location = new System.Drawing.Point(124, 120);
            this.txtDiaChi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDiaChi.MenuManager = this.barManager1;
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(156, 22);
            this.txtDiaChi.TabIndex = 5;
            // 
            // txtHoTen
            // 
            this.txtHoTen.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsNguoi, "HOTEN", true));
            this.txtHoTen.Location = new System.Drawing.Point(124, 72);
            this.txtHoTen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtHoTen.MenuManager = this.barManager1;
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(156, 22);
            this.txtHoTen.TabIndex = 3;
            // 
            // txtSCMND
            // 
            this.txtSCMND.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsNguoi, "SOCMND", true));
            this.txtSCMND.Location = new System.Drawing.Point(124, 25);
            this.txtSCMND.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSCMND.MenuManager = this.barManager1;
            this.txtSCMND.Name = "txtSCMND";
            this.txtSCMND.Size = new System.Drawing.Size(156, 22);
            this.txtSCMND.TabIndex = 1;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(mAPHICONGLabel);
            this.panelControl2.Controls.Add(this.txtMaPC);
            this.panelControl2.Controls.Add(nGAYCAPLabel);
            this.panelControl2.Controls.Add(this.dtpNgay);
            this.panelControl2.Controls.Add(mASOBANGLabel);
            this.panelControl2.Controls.Add(this.txtMaSoBang);
            this.panelControl2.Controls.Add(sOCMNDLabel1);
            this.panelControl2.Controls.Add(this.txtSCMNDPC);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelControl2.Location = new System.Drawing.Point(301, 224);
            this.panelControl2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(358, 187);
            this.panelControl2.TabIndex = 7;
            // 
            // txtMaPC
            // 
            this.txtMaPC.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsPC, "MAPHICONG", true));
            this.txtMaPC.Location = new System.Drawing.Point(160, 166);
            this.txtMaPC.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMaPC.MenuManager = this.barManager1;
            this.txtMaPC.Name = "txtMaPC";
            this.txtMaPC.Size = new System.Drawing.Size(156, 22);
            this.txtMaPC.TabIndex = 7;
            this.txtMaPC.EditValueChanged += new System.EventHandler(this.txtMaPC_EditValueChanged);
            // 
            // bdsPC
            // 
            this.bdsPC.DataMember = "PHICONG";
            this.bdsPC.DataSource = this.DS;
            // 
            // dtpNgay
            // 
            this.dtpNgay.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsPC, "NGAYCAP", true));
            this.dtpNgay.EditValue = null;
            this.dtpNgay.Location = new System.Drawing.Point(160, 119);
            this.dtpNgay.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpNgay.MenuManager = this.barManager1;
            this.dtpNgay.Name = "dtpNgay";
            this.dtpNgay.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpNgay.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpNgay.Size = new System.Drawing.Size(156, 22);
            this.dtpNgay.TabIndex = 5;
            // 
            // txtMaSoBang
            // 
            this.txtMaSoBang.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsPC, "MASOBANG", true));
            this.txtMaSoBang.Location = new System.Drawing.Point(160, 71);
            this.txtMaSoBang.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMaSoBang.MenuManager = this.barManager1;
            this.txtMaSoBang.Name = "txtMaSoBang";
            this.txtMaSoBang.Size = new System.Drawing.Size(156, 22);
            this.txtMaSoBang.TabIndex = 3;
            // 
            // txtSCMNDPC
            // 
            this.txtSCMNDPC.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsPC, "SOCMND", true));
            this.txtSCMNDPC.Enabled = false;
            this.txtSCMNDPC.Location = new System.Drawing.Point(160, 25);
            this.txtSCMNDPC.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSCMNDPC.MenuManager = this.barManager1;
            this.txtSCMNDPC.Name = "txtSCMNDPC";
            this.txtSCMNDPC.Size = new System.Drawing.Size(156, 22);
            this.txtSCMNDPC.TabIndex = 1;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnThemPC,
            this.btnHieuChinhPC,
            this.btnXoaPC,
            this.btnGhiPC,
            this.btnPhucHoiPC});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(149, 124);
            // 
            // btnThemPC
            // 
            this.btnThemPC.Name = "btnThemPC";
            this.btnThemPC.Size = new System.Drawing.Size(148, 24);
            this.btnThemPC.Text = "Thêm";
            this.btnThemPC.Click += new System.EventHandler(this.btnThemPC_Click);
            // 
            // btnHieuChinhPC
            // 
            this.btnHieuChinhPC.Name = "btnHieuChinhPC";
            this.btnHieuChinhPC.Size = new System.Drawing.Size(148, 24);
            this.btnHieuChinhPC.Text = "Hiệu chỉnh";
            this.btnHieuChinhPC.Click += new System.EventHandler(this.btnHieuChinhPC_Click);
            // 
            // btnXoaPC
            // 
            this.btnXoaPC.Name = "btnXoaPC";
            this.btnXoaPC.Size = new System.Drawing.Size(148, 24);
            this.btnXoaPC.Text = "Xóa";
            this.btnXoaPC.Click += new System.EventHandler(this.btnXoaPC_Click);
            // 
            // btnGhiPC
            // 
            this.btnGhiPC.Name = "btnGhiPC";
            this.btnGhiPC.Size = new System.Drawing.Size(148, 24);
            this.btnGhiPC.Text = "Ghi";
            this.btnGhiPC.Click += new System.EventHandler(this.btnGhiPC_Click);
            // 
            // btnPhucHoiPC
            // 
            this.btnPhucHoiPC.Name = "btnPhucHoiPC";
            this.btnPhucHoiPC.Size = new System.Drawing.Size(148, 24);
            this.btnPhucHoiPC.Text = "Phục hồi";
            this.btnPhucHoiPC.Click += new System.EventHandler(this.btnPhucHoiPC_Click);
            // 
            // bdsLai
            // 
            this.bdsLai.DataMember = "FK_LAI_PHICONG";
            this.bdsLai.DataSource = this.bdsPC;
            // 
            // lAITableAdapter
            // 
            this.lAITableAdapter.ClearBeforeFill = true;
            // 
            // pHICONGBindingSource
            // 
            this.pHICONGBindingSource.DataMember = "FK_PHICONG_NGUOI";
            this.pHICONGBindingSource.DataSource = this.bdsNguoi;
            // 
            // gcPC
            // 
            this.gcPC.AutoGenerateColumns = false;
            this.gcPC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gcPC.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.gcPC.ContextMenuStrip = this.contextMenuStrip1;
            this.gcPC.DataSource = this.pHICONGBindingSource;
            this.gcPC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcPC.Location = new System.Drawing.Point(659, 224);
            this.gcPC.Name = "gcPC";
            this.gcPC.RowHeadersWidth = 51;
            this.gcPC.RowTemplate.Height = 24;
            this.gcPC.Size = new System.Drawing.Size(422, 187);
            this.gcPC.TabIndex = 15;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "SOCMND";
            this.dataGridViewTextBoxColumn1.HeaderText = "SOCMND";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "MASOBANG";
            this.dataGridViewTextBoxColumn2.HeaderText = "MASOBANG";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "NGAYCAP";
            this.dataGridViewTextBoxColumn3.HeaderText = "NGAYCAP";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "MAPHICONG";
            this.dataGridViewTextBoxColumn4.HeaderText = "MAPHICONG";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // frmPhiCong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1081, 411);
            this.Controls.Add(this.gcPC);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.gcNguoi);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmPhiCong";
            this.Text = "frmPhiCong";
            this.Load += new System.EventHandler(this.frmPhiCong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsNguoi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcNguoi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSDT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiaChi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHoTen.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSCMND.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaPC.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsPC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpNgay.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpNgay.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaSoBang.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSCMNDPC.Properties)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bdsLai)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHICONGBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcPC)).EndInit();
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
        private System.Windows.Forms.BindingSource bdsNguoi;
        private DS DS;
        private DSTableAdapters.NGUOITableAdapter nGUOITableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.TextEdit txtSDT;
        private DevExpress.XtraEditors.TextEdit txtDiaChi;
        private DevExpress.XtraEditors.TextEdit txtHoTen;
        private DevExpress.XtraEditors.TextEdit txtSCMND;
        private DevExpress.XtraGrid.GridControl gcNguoi;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colSOCMND;
        private DevExpress.XtraGrid.Columns.GridColumn colHOTEN;
        private DevExpress.XtraGrid.Columns.GridColumn colDIACHI;
        private DevExpress.XtraGrid.Columns.GridColumn colSODIENTHOAI;
        private DevExpress.XtraGrid.Columns.GridColumn colMACHU;
        private DSTableAdapters.PHICONGTableAdapter pHICONGTableAdapter;
        private System.Windows.Forms.BindingSource bdsPC;
        private DevExpress.XtraEditors.TextEdit txtMaSoBang;
        private DevExpress.XtraEditors.TextEdit txtSCMNDPC;
        private DevExpress.XtraEditors.DateEdit dtpNgay;
        private System.Windows.Forms.BindingSource bdsLai;
        private DSTableAdapters.LAITableAdapter lAITableAdapter;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btnThemPC;
        private System.Windows.Forms.ToolStripMenuItem btnHieuChinhPC;
        private System.Windows.Forms.ToolStripMenuItem btnXoaPC;
        private System.Windows.Forms.ToolStripMenuItem btnGhiPC;
        private System.Windows.Forms.ToolStripMenuItem btnPhucHoiPC;
        private DevExpress.XtraEditors.TextEdit txtMaPC;
        private System.Windows.Forms.DataGridView gcPC;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.BindingSource pHICONGBindingSource;
    }
}