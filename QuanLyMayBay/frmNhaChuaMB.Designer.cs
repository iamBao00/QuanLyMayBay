namespace QuanLyMayBay
{
    partial class frmNhaChuaMB
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
            System.Windows.Forms.Label mANHACHUALabel;
            System.Windows.Forms.Label sUCCHUALabel;
            System.Windows.Forms.Label vITRILabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNhaChuaMB));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btnThem = new DevExpress.XtraBars.BarButtonItem();
            this.btnHieuChinh = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoa = new DevExpress.XtraBars.BarButtonItem();
            this.btnGhi = new DevExpress.XtraBars.BarButtonItem();
            this.btnHuyThaoTac = new DevExpress.XtraBars.BarButtonItem();
            this.btnReload = new DevExpress.XtraBars.BarButtonItem();
            this.btnThoat = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.DS = new QuanLyMayBay.DS();
            this.bdsNC = new System.Windows.Forms.BindingSource(this.components);
            this.nHACHUAMAYBAYTableAdapter = new QuanLyMayBay.DSTableAdapters.NHACHUAMAYBAYTableAdapter();
            this.tableAdapterManager = new QuanLyMayBay.DSTableAdapters.TableAdapterManager();
            this.mAYBAYTableAdapter = new QuanLyMayBay.DSTableAdapters.MAYBAYTableAdapter();
            this.gcNhaChuaMB = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMANHACHUA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSUCCHUA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVITRI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.controlPanel = new System.Windows.Forms.GroupBox();
            this.txtViTri = new DevExpress.XtraEditors.TextEdit();
            this.txtSucChua = new DevExpress.XtraEditors.TextEdit();
            this.txtMaNC = new DevExpress.XtraEditors.TextEdit();
            this.bdsMB = new System.Windows.Forms.BindingSource(this.components);
            this.btnThemPX = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            mANHACHUALabel = new System.Windows.Forms.Label();
            sUCCHUALabel = new System.Windows.Forms.Label();
            vITRILabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsNC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcNhaChuaMB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.controlPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtViTri.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSucChua.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaNC.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsMB)).BeginInit();
            this.SuspendLayout();
            // 
            // mANHACHUALabel
            // 
            mANHACHUALabel.AutoSize = true;
            mANHACHUALabel.Location = new System.Drawing.Point(114, 43);
            mANHACHUALabel.Name = "mANHACHUALabel";
            mANHACHUALabel.Size = new System.Drawing.Size(86, 16);
            mANHACHUALabel.TabIndex = 0;
            mANHACHUALabel.Text = "Mã nhà chứa:";
            // 
            // sUCCHUALabel
            // 
            sUCCHUALabel.AutoSize = true;
            sUCCHUALabel.Location = new System.Drawing.Point(135, 80);
            sUCCHUALabel.Name = "sUCCHUALabel";
            sUCCHUALabel.Size = new System.Drawing.Size(65, 16);
            sUCCHUALabel.TabIndex = 2;
            sUCCHUALabel.Text = "Sức chứa:";
            // 
            // vITRILabel
            // 
            vITRILabel.AutoSize = true;
            vITRILabel.Location = new System.Drawing.Point(167, 118);
            vITRILabel.Name = "vITRILabel";
            vITRILabel.Size = new System.Drawing.Size(35, 16);
            vITRILabel.TabIndex = 4;
            vITRILabel.Text = "Vị trí:";
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
            this.btnHuyThaoTac,
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
            new DevExpress.XtraBars.LinkPersistInfo(this.btnHuyThaoTac),
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
            // btnHieuChinh
            // 
            this.btnHieuChinh.Caption = "Hiệu chỉnh";
            this.btnHieuChinh.Id = 1;
            this.btnHieuChinh.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnHieuChinh.ImageOptions.Image")));
            this.btnHieuChinh.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnHieuChinh.ImageOptions.LargeImage")));
            this.btnHieuChinh.Name = "btnHieuChinh";
            this.btnHieuChinh.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnHieuChinh.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnHieuChinh_ItemClick);
            // 
            // btnXoa
            // 
            this.btnXoa.Caption = "Xóa";
            this.btnXoa.Id = 2;
            this.btnXoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.Image")));
            this.btnXoa.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.LargeImage")));
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnXoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXoa_ItemClick);
            // 
            // btnGhi
            // 
            this.btnGhi.Caption = "Ghi";
            this.btnGhi.Id = 3;
            this.btnGhi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGhi.ImageOptions.Image")));
            this.btnGhi.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnGhi.ImageOptions.LargeImage")));
            this.btnGhi.Name = "btnGhi";
            this.btnGhi.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnGhi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnGhi_ItemClick);
            // 
            // btnHuyThaoTac
            // 
            this.btnHuyThaoTac.Caption = "Hủy Thao Tác";
            this.btnHuyThaoTac.Id = 4;
            this.btnHuyThaoTac.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnHuyThaoTac.ImageOptions.Image")));
            this.btnHuyThaoTac.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnHuyThaoTac.ImageOptions.LargeImage")));
            this.btnHuyThaoTac.Name = "btnHuyThaoTac";
            this.btnHuyThaoTac.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnHuyThaoTac.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPhucHoi_ItemClick);
            // 
            // btnReload
            // 
            this.btnReload.Caption = "Reload";
            this.btnReload.Id = 5;
            this.btnReload.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnReload.ImageOptions.Image")));
            this.btnReload.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnReload.ImageOptions.LargeImage")));
            this.btnReload.Name = "btnReload";
            this.btnReload.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnReload.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnReload_ItemClick);
            // 
            // btnThoat
            // 
            this.btnThoat.Caption = "Thoát";
            this.btnThoat.Id = 6;
            this.btnThoat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.ImageOptions.Image")));
            this.btnThoat.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnThoat.ImageOptions.LargeImage")));
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnThoat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThoat_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(856, 30);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 461);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(856, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 30);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 431);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(856, 30);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 431);
            // 
            // DS
            // 
            this.DS.DataSetName = "DS";
            this.DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsNC
            // 
            this.bdsNC.DataMember = "NHACHUAMAYBAY";
            this.bdsNC.DataSource = this.DS;
            // 
            // nHACHUAMAYBAYTableAdapter
            // 
            this.nHACHUAMAYBAYTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.NHACHUAMAYBAYTableAdapter = this.nHACHUAMAYBAYTableAdapter;
            this.tableAdapterManager.NHANVIENTableAdapter = null;
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
            // gcNhaChuaMB
            // 
            this.gcNhaChuaMB.DataSource = this.bdsNC;
            this.gcNhaChuaMB.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcNhaChuaMB.Location = new System.Drawing.Point(0, 30);
            this.gcNhaChuaMB.MainView = this.gridView1;
            this.gcNhaChuaMB.MenuManager = this.barManager1;
            this.gcNhaChuaMB.Name = "gcNhaChuaMB";
            this.gcNhaChuaMB.Size = new System.Drawing.Size(856, 264);
            this.gcNhaChuaMB.TabIndex = 5;
            this.gcNhaChuaMB.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMANHACHUA,
            this.colSUCCHUA,
            this.colVITRI});
            this.gridView1.GridControl = this.gcNhaChuaMB;
            this.gridView1.Name = "gridView1";
            // 
            // colMANHACHUA
            // 
            this.colMANHACHUA.FieldName = "MANHACHUA";
            this.colMANHACHUA.MinWidth = 25;
            this.colMANHACHUA.Name = "colMANHACHUA";
            this.colMANHACHUA.Visible = true;
            this.colMANHACHUA.VisibleIndex = 0;
            this.colMANHACHUA.Width = 94;
            // 
            // colSUCCHUA
            // 
            this.colSUCCHUA.FieldName = "SUCCHUA";
            this.colSUCCHUA.MinWidth = 25;
            this.colSUCCHUA.Name = "colSUCCHUA";
            this.colSUCCHUA.Visible = true;
            this.colSUCCHUA.VisibleIndex = 1;
            this.colSUCCHUA.Width = 94;
            // 
            // colVITRI
            // 
            this.colVITRI.FieldName = "VITRI";
            this.colVITRI.MinWidth = 25;
            this.colVITRI.Name = "colVITRI";
            this.colVITRI.Visible = true;
            this.colVITRI.VisibleIndex = 2;
            this.colVITRI.Width = 94;
            // 
            // controlPanel
            // 
            this.controlPanel.Controls.Add(vITRILabel);
            this.controlPanel.Controls.Add(this.txtViTri);
            this.controlPanel.Controls.Add(sUCCHUALabel);
            this.controlPanel.Controls.Add(this.txtSucChua);
            this.controlPanel.Controls.Add(mANHACHUALabel);
            this.controlPanel.Controls.Add(this.txtMaNC);
            this.controlPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.controlPanel.Location = new System.Drawing.Point(0, 294);
            this.controlPanel.Name = "controlPanel";
            this.controlPanel.Size = new System.Drawing.Size(856, 167);
            this.controlPanel.TabIndex = 6;
            this.controlPanel.TabStop = false;
            this.controlPanel.Text = "Thông tin";
            // 
            // txtViTri
            // 
            this.txtViTri.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsNC, "VITRI", true));
            this.txtViTri.Location = new System.Drawing.Point(217, 115);
            this.txtViTri.MenuManager = this.barManager1;
            this.txtViTri.Name = "txtViTri";
            this.txtViTri.Size = new System.Drawing.Size(198, 22);
            this.txtViTri.TabIndex = 5;
            // 
            // txtSucChua
            // 
            this.txtSucChua.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsNC, "SUCCHUA", true));
            this.txtSucChua.Location = new System.Drawing.Point(217, 77);
            this.txtSucChua.MenuManager = this.barManager1;
            this.txtSucChua.Name = "txtSucChua";
            this.txtSucChua.Size = new System.Drawing.Size(198, 22);
            this.txtSucChua.TabIndex = 3;
            // 
            // txtMaNC
            // 
            this.txtMaNC.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsNC, "MANHACHUA", true));
            this.txtMaNC.Location = new System.Drawing.Point(217, 40);
            this.txtMaNC.MenuManager = this.barManager1;
            this.txtMaNC.Name = "txtMaNC";
            this.txtMaNC.Size = new System.Drawing.Size(198, 22);
            this.txtMaNC.TabIndex = 1;
            // 
            // bdsMB
            // 
            this.bdsMB.DataMember = "FK_MAYBAY_NHACHUAMAYBAY";
            this.bdsMB.DataSource = this.bdsNC;
            // 
            // btnThemPX
            // 
            this.btnThemPX.Caption = "Thêm";
            this.btnThemPX.Id = 0;
            this.btnThemPX.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnThemPX.ImageOptions.SvgImage")));
            this.btnThemPX.Name = "btnThemPX";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Thêm";
            this.barButtonItem1.Id = 0;
            this.barButtonItem1.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem1.ImageOptions.SvgImage")));
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Thêm";
            this.barButtonItem2.Id = 0;
            this.barButtonItem2.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem2.ImageOptions.SvgImage")));
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // frmNhaChuaMB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(856, 461);
            this.Controls.Add(this.controlPanel);
            this.Controls.Add(this.gcNhaChuaMB);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmNhaChuaMB";
            this.Text = "frmNhaChuaMB";
            this.Load += new System.EventHandler(this.frmNhaChuaMB_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsNC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcNhaChuaMB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.controlPanel.ResumeLayout(false);
            this.controlPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtViTri.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSucChua.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaNC.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsMB)).EndInit();
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
        private DevExpress.XtraBars.BarButtonItem btnHuyThaoTac;
        private DevExpress.XtraBars.BarButtonItem btnReload;
        private DevExpress.XtraBars.BarButtonItem btnThoat;
        private System.Windows.Forms.BindingSource bdsNC;
        private DS DS;
        private DSTableAdapters.NHACHUAMAYBAYTableAdapter nHACHUAMAYBAYTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.GroupBox controlPanel;
        private DevExpress.XtraEditors.TextEdit txtViTri;
        private DevExpress.XtraEditors.TextEdit txtSucChua;
        private DevExpress.XtraEditors.TextEdit txtMaNC;
        private DevExpress.XtraGrid.GridControl gcNhaChuaMB;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMANHACHUA;
        private DevExpress.XtraGrid.Columns.GridColumn colSUCCHUA;
        private DevExpress.XtraGrid.Columns.GridColumn colVITRI;
        private DSTableAdapters.MAYBAYTableAdapter mAYBAYTableAdapter;
        private System.Windows.Forms.BindingSource bdsMB;
        private DevExpress.XtraBars.BarButtonItem btnThemPX;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
    }
}