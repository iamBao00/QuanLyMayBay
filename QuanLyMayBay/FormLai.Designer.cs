namespace QuanLyMayBay
{
    partial class FormLai
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
            System.Windows.Forms.Label mALOAILabel;
            System.Windows.Forms.Label mAPHICONGLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLai));
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
            this.barDockControl6 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl8 = new DevExpress.XtraBars.BarDockControl();
            this.dS = new QuanLyMayBay.DS();
            this.bdsPC = new System.Windows.Forms.BindingSource(this.components);
            this.pHICONGTableAdapter = new QuanLyMayBay.DSTableAdapters.PHICONGTableAdapter();
            this.tableAdapterManager = new QuanLyMayBay.DSTableAdapters.TableAdapterManager();
            this.lAITableAdapter = new QuanLyMayBay.DSTableAdapters.LAITableAdapter();
            this.lOAIMAYBAYTableAdapter = new QuanLyMayBay.DSTableAdapters.LOAIMAYBAYTableAdapter();
            this.pHICONGGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSOCMND = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMASOBANG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAYCAP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAPHICONG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtMAPC = new DevExpress.XtraEditors.TextEdit();
            this.bdsLAI = new System.Windows.Forms.BindingSource(this.components);
            this.txtMALOAI = new DevExpress.XtraEditors.TextEdit();
            this.cmbLMB = new System.Windows.Forms.ComboBox();
            this.cB_LOAIMAYBAYBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.bdsLOAIMB = new System.Windows.Forms.BindingSource(this.components);
            this.cB_LOAIMAYBAYTableAdapter = new QuanLyMayBay.DSTableAdapters.CB_LOAIMAYBAYTableAdapter();
            this.lAIGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMALOAI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAPHICONG1 = new DevExpress.XtraGrid.Columns.GridColumn();
            mALOAILabel = new System.Windows.Forms.Label();
            mAPHICONGLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsPC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHICONGGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMAPC.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLAI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMALOAI.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cB_LOAIMAYBAYBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLOAIMB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lAIGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // mALOAILabel
            // 
            mALOAILabel.AutoSize = true;
            mALOAILabel.Location = new System.Drawing.Point(26, 127);
            mALOAILabel.Name = "mALOAILabel";
            mALOAILabel.Size = new System.Drawing.Size(59, 16);
            mALOAILabel.TabIndex = 5;
            mALOAILabel.Text = "MALOAI:";
            // 
            // mAPHICONGLabel
            // 
            mAPHICONGLabel.AutoSize = true;
            mAPHICONGLabel.Location = new System.Drawing.Point(23, 33);
            mAPHICONGLabel.Name = "mAPHICONGLabel";
            mAPHICONGLabel.Size = new System.Drawing.Size(91, 16);
            mAPHICONGLabel.TabIndex = 6;
            mAPHICONGLabel.Text = "MAPHICONG:";
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
            this.btnThem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThem_ItemClick);
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
            this.barDockControl4.Size = new System.Drawing.Size(1237, 30);
            // 
            // barDockControl5
            // 
            this.barDockControl5.CausesValidation = false;
            this.barDockControl5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControl5.Location = new System.Drawing.Point(0, 796);
            this.barDockControl5.Manager = this.barManager2;
            this.barDockControl5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControl5.Size = new System.Drawing.Size(1237, 0);
            // 
            // barDockControl6
            // 
            this.barDockControl6.CausesValidation = false;
            this.barDockControl6.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControl6.Location = new System.Drawing.Point(0, 30);
            this.barDockControl6.Manager = this.barManager2;
            this.barDockControl6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControl6.Size = new System.Drawing.Size(0, 766);
            // 
            // barDockControl8
            // 
            this.barDockControl8.CausesValidation = false;
            this.barDockControl8.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControl8.Location = new System.Drawing.Point(1237, 30);
            this.barDockControl8.Manager = this.barManager2;
            this.barDockControl8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControl8.Size = new System.Drawing.Size(0, 766);
            // 
            // dS
            // 
            this.dS.DataSetName = "DS";
            this.dS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsPC
            // 
            this.bdsPC.DataMember = "PHICONG";
            this.bdsPC.DataSource = this.dS;
            // 
            // pHICONGTableAdapter
            // 
            this.pHICONGTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CHUMAYBAYTableAdapter = null;
            this.tableAdapterManager.CHUYENVETableAdapter = null;
            this.tableAdapterManager.DICHVUBAOTRITableAdapter = null;
            this.tableAdapterManager.DOANHNGHIEPTableAdapter = null;
            this.tableAdapterManager.LAITableAdapter = this.lAITableAdapter;
            this.tableAdapterManager.LOAIMAYBAYTableAdapter = this.lOAIMAYBAYTableAdapter;
            this.tableAdapterManager.MAYBAYTableAdapter = null;
            this.tableAdapterManager.NGUOITableAdapter = null;
            this.tableAdapterManager.NHACHUAMAYBAYTableAdapter = null;
            this.tableAdapterManager.NHANVIENTableAdapter = null;
            this.tableAdapterManager.PHICONGTableAdapter = this.pHICONGTableAdapter;
            this.tableAdapterManager.SOHUUTableAdapter = null;
            this.tableAdapterManager.ThongTinNhanVienTableAdapter = null;
            this.tableAdapterManager.ThongTinPhiCongTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QuanLyMayBay.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // lAITableAdapter
            // 
            this.lAITableAdapter.ClearBeforeFill = true;
            // 
            // lOAIMAYBAYTableAdapter
            // 
            this.lOAIMAYBAYTableAdapter.ClearBeforeFill = true;
            // 
            // pHICONGGridControl
            // 
            this.pHICONGGridControl.DataSource = this.bdsPC;
            this.pHICONGGridControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.pHICONGGridControl.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.pHICONGGridControl.Location = new System.Drawing.Point(0, 30);
            this.pHICONGGridControl.MainView = this.gridView1;
            this.pHICONGGridControl.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.pHICONGGridControl.MenuManager = this.barManager2;
            this.pHICONGGridControl.Name = "pHICONGGridControl";
            this.pHICONGGridControl.Size = new System.Drawing.Size(1237, 344);
            this.pHICONGGridControl.TabIndex = 5;
            this.pHICONGGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSOCMND,
            this.colMASOBANG,
            this.colNGAYCAP,
            this.colMAPHICONG});
            this.gridView1.DetailHeight = 546;
            this.gridView1.GridControl = this.pHICONGGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // colSOCMND
            // 
            this.colSOCMND.FieldName = "SOCMND";
            this.colSOCMND.MinWidth = 39;
            this.colSOCMND.Name = "colSOCMND";
            this.colSOCMND.Visible = true;
            this.colSOCMND.VisibleIndex = 0;
            this.colSOCMND.Width = 146;
            // 
            // colMASOBANG
            // 
            this.colMASOBANG.FieldName = "MASOBANG";
            this.colMASOBANG.MinWidth = 39;
            this.colMASOBANG.Name = "colMASOBANG";
            this.colMASOBANG.Visible = true;
            this.colMASOBANG.VisibleIndex = 1;
            this.colMASOBANG.Width = 146;
            // 
            // colNGAYCAP
            // 
            this.colNGAYCAP.FieldName = "NGAYCAP";
            this.colNGAYCAP.MinWidth = 39;
            this.colNGAYCAP.Name = "colNGAYCAP";
            this.colNGAYCAP.Visible = true;
            this.colNGAYCAP.VisibleIndex = 2;
            this.colNGAYCAP.Width = 146;
            // 
            // colMAPHICONG
            // 
            this.colMAPHICONG.FieldName = "MAPHICONG";
            this.colMAPHICONG.MinWidth = 39;
            this.colMAPHICONG.Name = "colMAPHICONG";
            this.colMAPHICONG.Visible = true;
            this.colMAPHICONG.VisibleIndex = 3;
            this.colMAPHICONG.Width = 146;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(mAPHICONGLabel);
            this.groupBox1.Controls.Add(this.txtMAPC);
            this.groupBox1.Controls.Add(mALOAILabel);
            this.groupBox1.Controls.Add(this.txtMALOAI);
            this.groupBox1.Controls.Add(this.cmbLMB);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(0, 374);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(583, 422);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // txtMAPC
            // 
            this.txtMAPC.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsLAI, "MAPHICONG", true));
            this.txtMAPC.Location = new System.Drawing.Point(121, 30);
            this.txtMAPC.Margin = new System.Windows.Forms.Padding(4);
            this.txtMAPC.MenuManager = this.barManager2;
            this.txtMAPC.Name = "txtMAPC";
            this.txtMAPC.Size = new System.Drawing.Size(156, 22);
            this.txtMAPC.TabIndex = 7;
            // 
            // bdsLAI
            // 
            this.bdsLAI.DataMember = "FK_LAI_PHICONG";
            this.bdsLAI.DataSource = this.bdsPC;
            // 
            // txtMALOAI
            // 
            this.txtMALOAI.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsLAI, "MALOAI", true));
            this.txtMALOAI.Location = new System.Drawing.Point(121, 124);
            this.txtMALOAI.Margin = new System.Windows.Forms.Padding(4);
            this.txtMALOAI.MenuManager = this.barManager2;
            this.txtMALOAI.Name = "txtMALOAI";
            this.txtMALOAI.Size = new System.Drawing.Size(156, 22);
            this.txtMALOAI.TabIndex = 6;
            // 
            // cmbLMB
            // 
            this.cmbLMB.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bdsLAI, "MALOAI", true));
            this.cmbLMB.DataSource = this.cB_LOAIMAYBAYBindingSource;
            this.cmbLMB.DisplayMember = "LOAI";
            this.cmbLMB.FormattingEnabled = true;
            this.cmbLMB.Location = new System.Drawing.Point(121, 73);
            this.cmbLMB.Name = "cmbLMB";
            this.cmbLMB.Size = new System.Drawing.Size(446, 24);
            this.cmbLMB.TabIndex = 5;
            this.cmbLMB.ValueMember = "MALOAI";
            this.cmbLMB.SelectedIndexChanged += new System.EventHandler(this.cmbMALOAI_SelectedIndexChanged);
            // 
            // cB_LOAIMAYBAYBindingSource
            // 
            this.cB_LOAIMAYBAYBindingSource.DataMember = "CB_LOAIMAYBAY";
            this.cB_LOAIMAYBAYBindingSource.DataSource = this.dS;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "LOAI MB:";
            // 
            // bdsLOAIMB
            // 
            this.bdsLOAIMB.DataMember = "LOAIMAYBAY";
            this.bdsLOAIMB.DataSource = this.dS;
            // 
            // cB_LOAIMAYBAYTableAdapter
            // 
            this.cB_LOAIMAYBAYTableAdapter.ClearBeforeFill = true;
            // 
            // lAIGridControl
            // 
            this.lAIGridControl.DataSource = this.bdsLAI;
            this.lAIGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lAIGridControl.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.lAIGridControl.Location = new System.Drawing.Point(583, 374);
            this.lAIGridControl.MainView = this.gridView2;
            this.lAIGridControl.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.lAIGridControl.MenuManager = this.barManager2;
            this.lAIGridControl.Name = "lAIGridControl";
            this.lAIGridControl.Size = new System.Drawing.Size(654, 422);
            this.lAIGridControl.TabIndex = 10;
            this.lAIGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMALOAI,
            this.colMAPHICONG1});
            this.gridView2.DetailHeight = 437;
            this.gridView2.GridControl = this.lAIGridControl;
            this.gridView2.Name = "gridView2";
            // 
            // colMALOAI
            // 
            this.colMALOAI.FieldName = "MALOAI";
            this.colMALOAI.MinWidth = 31;
            this.colMALOAI.Name = "colMALOAI";
            this.colMALOAI.Visible = true;
            this.colMALOAI.VisibleIndex = 0;
            this.colMALOAI.Width = 117;
            // 
            // colMAPHICONG1
            // 
            this.colMAPHICONG1.FieldName = "MAPHICONG";
            this.colMAPHICONG1.MinWidth = 31;
            this.colMAPHICONG1.Name = "colMAPHICONG1";
            this.colMAPHICONG1.Visible = true;
            this.colMAPHICONG1.VisibleIndex = 1;
            this.colMAPHICONG1.Width = 117;
            // 
            // FormLai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1237, 796);
            this.Controls.Add(this.lAIGridControl);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pHICONGGridControl);
            this.Controls.Add(this.barDockControl6);
            this.Controls.Add(this.barDockControl8);
            this.Controls.Add(this.barDockControl5);
            this.Controls.Add(this.barDockControl4);
            this.Name = "FormLai";
            this.Text = "FormLai";
            this.Load += new System.EventHandler(this.FormLai_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsPC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHICONGGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMAPC.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLAI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMALOAI.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cB_LOAIMAYBAYBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLOAIMB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lAIGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
        private DevExpress.XtraBars.BarDockControl barDockControl6;
        private DevExpress.XtraBars.BarDockControl barDockControl8;
        private System.Windows.Forms.BindingSource bdsPC;
        private DS dS;
        private DSTableAdapters.PHICONGTableAdapter pHICONGTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraGrid.GridControl pHICONGGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colSOCMND;
        private DevExpress.XtraGrid.Columns.GridColumn colMASOBANG;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAYCAP;
        private DevExpress.XtraGrid.Columns.GridColumn colMAPHICONG;
        private DSTableAdapters.LAITableAdapter lAITableAdapter;
        private System.Windows.Forms.BindingSource bdsLAI;
        private System.Windows.Forms.ComboBox cmbLMB;
        private System.Windows.Forms.Label label1;
        private DSTableAdapters.LOAIMAYBAYTableAdapter lOAIMAYBAYTableAdapter;
        private System.Windows.Forms.BindingSource bdsLOAIMB;
        private System.Windows.Forms.BindingSource cB_LOAIMAYBAYBindingSource;
        private DSTableAdapters.CB_LOAIMAYBAYTableAdapter cB_LOAIMAYBAYTableAdapter;
        private DevExpress.XtraGrid.GridControl lAIGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colMALOAI;
        private DevExpress.XtraGrid.Columns.GridColumn colMAPHICONG1;
        private DevExpress.XtraEditors.TextEdit txtMAPC;
        private DevExpress.XtraEditors.TextEdit txtMALOAI;
    }
}