namespace QuanLyMayBay
{
    partial class frmLoaiMB
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
            System.Windows.Forms.Label kIEUDANGLabel;
            System.Windows.Forms.Label tRONGLUONGLabel;
            System.Windows.Forms.Label sUCCHUALabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLoaiMB));
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
            this.bdsLMB = new System.Windows.Forms.BindingSource(this.components);
            this.lOAIMAYBAYTableAdapter = new QuanLyMayBay.DSTableAdapters.LOAIMAYBAYTableAdapter();
            this.tableAdapterManager = new QuanLyMayBay.DSTableAdapters.TableAdapterManager();
            this.cHUYENVETableAdapter = new QuanLyMayBay.DSTableAdapters.CHUYENVETableAdapter();
            this.lAITableAdapter = new QuanLyMayBay.DSTableAdapters.LAITableAdapter();
            this.mAYBAYTableAdapter = new QuanLyMayBay.DSTableAdapters.MAYBAYTableAdapter();
            this.gcLoaiMB = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMALOAI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKIEUDANG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTRONGLUONG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSUCCHUA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtSucChua = new DevExpress.XtraEditors.TextEdit();
            this.txtTrongLuong = new DevExpress.XtraEditors.TextEdit();
            this.txtKieuDang = new DevExpress.XtraEditors.TextEdit();
            this.txtMaLoai = new DevExpress.XtraEditors.TextEdit();
            this.bdsCV = new System.Windows.Forms.BindingSource(this.components);
            this.bdsL = new System.Windows.Forms.BindingSource(this.components);
            this.bdsMB = new System.Windows.Forms.BindingSource(this.components);
            mALOAILabel = new System.Windows.Forms.Label();
            kIEUDANGLabel = new System.Windows.Forms.Label();
            tRONGLUONGLabel = new System.Windows.Forms.Label();
            sUCCHUALabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLMB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcLoaiMB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSucChua.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTrongLuong.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKieuDang.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaLoai.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsMB)).BeginInit();
            this.SuspendLayout();
            // 
            // mALOAILabel
            // 
            mALOAILabel.AutoSize = true;
            mALOAILabel.Location = new System.Drawing.Point(148, 44);
            mALOAILabel.Name = "mALOAILabel";
            mALOAILabel.Size = new System.Drawing.Size(54, 16);
            mALOAILabel.TabIndex = 0;
            mALOAILabel.Text = "Mã loại:";
            // 
            // kIEUDANGLabel
            // 
            kIEUDANGLabel.AutoSize = true;
            kIEUDANGLabel.Location = new System.Drawing.Point(128, 88);
            kIEUDANGLabel.Name = "kIEUDANGLabel";
            kIEUDANGLabel.Size = new System.Drawing.Size(70, 16);
            kIEUDANGLabel.TabIndex = 2;
            kIEUDANGLabel.Text = "Kiểu dáng:";
            // 
            // tRONGLUONGLabel
            // 
            tRONGLUONGLabel.AutoSize = true;
            tRONGLUONGLabel.Location = new System.Drawing.Point(458, 41);
            tRONGLUONGLabel.Name = "tRONGLUONGLabel";
            tRONGLUONGLabel.Size = new System.Drawing.Size(82, 16);
            tRONGLUONGLabel.TabIndex = 4;
            tRONGLUONGLabel.Text = "Trọng lượng:";
            // 
            // sUCCHUALabel
            // 
            sUCCHUALabel.AutoSize = true;
            sUCCHUALabel.Location = new System.Drawing.Point(488, 85);
            sUCCHUALabel.Name = "sUCCHUALabel";
            sUCCHUALabel.Size = new System.Drawing.Size(65, 16);
            sUCCHUALabel.TabIndex = 6;
            sUCCHUALabel.Text = "Sức chứa:";
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
            this.btnThem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.ImageOptions.Image")));
            this.btnThem.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnThem.ImageOptions.LargeImage")));
            this.btnThem.Name = "btnThem";
            this.btnThem.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnThem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThem_ItemClick_1);
            // 
            // btnHieuChinh
            // 
            this.btnHieuChinh.Caption = "Hiệu chỉnh";
            this.btnHieuChinh.Id = 1;
            this.btnHieuChinh.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnHieuChinh.ImageOptions.Image")));
            this.btnHieuChinh.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnHieuChinh.ImageOptions.LargeImage")));
            this.btnHieuChinh.Name = "btnHieuChinh";
            this.btnHieuChinh.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnHieuChinh.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnHieuChinh_ItemClick_1);
            // 
            // btnXoa
            // 
            this.btnXoa.Caption = "Xóa";
            this.btnXoa.Id = 2;
            this.btnXoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.Image")));
            this.btnXoa.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.LargeImage")));
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnXoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXoa_ItemClick_1);
            // 
            // btnGhi
            // 
            this.btnGhi.Caption = "Ghi";
            this.btnGhi.Id = 3;
            this.btnGhi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGhi.ImageOptions.Image")));
            this.btnGhi.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnGhi.ImageOptions.LargeImage")));
            this.btnGhi.Name = "btnGhi";
            this.btnGhi.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnGhi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnGhi_ItemClick_1);
            // 
            // btnPhucHoi
            // 
            this.btnPhucHoi.Caption = "Phục hồi";
            this.btnPhucHoi.Id = 4;
            this.btnPhucHoi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPhucHoi.ImageOptions.Image")));
            this.btnPhucHoi.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnPhucHoi.ImageOptions.LargeImage")));
            this.btnPhucHoi.Name = "btnPhucHoi";
            this.btnPhucHoi.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnPhucHoi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPhucHoi_ItemClick_1);
            // 
            // btnReload
            // 
            this.btnReload.Caption = "Reload";
            this.btnReload.Id = 5;
            this.btnReload.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnReload.ImageOptions.Image")));
            this.btnReload.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnReload.ImageOptions.LargeImage")));
            this.btnReload.Name = "btnReload";
            this.btnReload.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnReload.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnReload_ItemClick_1);
            // 
            // btnThoat
            // 
            this.btnThoat.Caption = "Thoát";
            this.btnThoat.Id = 6;
            this.btnThoat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.ImageOptions.Image")));
            this.btnThoat.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnThoat.ImageOptions.LargeImage")));
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnThoat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThoat_ItemClick_1);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(985, 30);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 473);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(985, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 30);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 443);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(985, 30);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 443);
            // 
            // DS
            // 
            this.DS.DataSetName = "DS";
            this.DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsLMB
            // 
            this.bdsLMB.DataMember = "LOAIMAYBAY";
            this.bdsLMB.DataSource = this.DS;
            // 
            // lOAIMAYBAYTableAdapter
            // 
            this.lOAIMAYBAYTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CHUMAYBAYTableAdapter = null;
            this.tableAdapterManager.CHUYENVETableAdapter = this.cHUYENVETableAdapter;
            this.tableAdapterManager.DICHVUBAOTRITableAdapter = null;
            this.tableAdapterManager.DOANHNGHIEPTableAdapter = null;
            this.tableAdapterManager.LAITableAdapter = this.lAITableAdapter;
            this.tableAdapterManager.LOAIMAYBAYTableAdapter = this.lOAIMAYBAYTableAdapter;
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
            // cHUYENVETableAdapter
            // 
            this.cHUYENVETableAdapter.ClearBeforeFill = true;
            // 
            // lAITableAdapter
            // 
            this.lAITableAdapter.ClearBeforeFill = true;
            // 
            // mAYBAYTableAdapter
            // 
            this.mAYBAYTableAdapter.ClearBeforeFill = true;
            // 
            // gcLoaiMB
            // 
            this.gcLoaiMB.DataSource = this.bdsLMB;
            this.gcLoaiMB.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcLoaiMB.Location = new System.Drawing.Point(0, 30);
            this.gcLoaiMB.MainView = this.gridView1;
            this.gcLoaiMB.MenuManager = this.barManager1;
            this.gcLoaiMB.Name = "gcLoaiMB";
            this.gcLoaiMB.Size = new System.Drawing.Size(985, 220);
            this.gcLoaiMB.TabIndex = 5;
            this.gcLoaiMB.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMALOAI,
            this.colKIEUDANG,
            this.colTRONGLUONG,
            this.colSUCCHUA});
            this.gridView1.GridControl = this.gcLoaiMB;
            this.gridView1.Name = "gridView1";
            // 
            // colMALOAI
            // 
            this.colMALOAI.FieldName = "MALOAI";
            this.colMALOAI.MinWidth = 25;
            this.colMALOAI.Name = "colMALOAI";
            this.colMALOAI.Visible = true;
            this.colMALOAI.VisibleIndex = 0;
            this.colMALOAI.Width = 94;
            // 
            // colKIEUDANG
            // 
            this.colKIEUDANG.FieldName = "KIEUDANG";
            this.colKIEUDANG.MinWidth = 25;
            this.colKIEUDANG.Name = "colKIEUDANG";
            this.colKIEUDANG.Visible = true;
            this.colKIEUDANG.VisibleIndex = 1;
            this.colKIEUDANG.Width = 94;
            // 
            // colTRONGLUONG
            // 
            this.colTRONGLUONG.FieldName = "TRONGLUONG";
            this.colTRONGLUONG.MinWidth = 25;
            this.colTRONGLUONG.Name = "colTRONGLUONG";
            this.colTRONGLUONG.Visible = true;
            this.colTRONGLUONG.VisibleIndex = 2;
            this.colTRONGLUONG.Width = 94;
            // 
            // colSUCCHUA
            // 
            this.colSUCCHUA.FieldName = "SUCCHUA";
            this.colSUCCHUA.MinWidth = 25;
            this.colSUCCHUA.Name = "colSUCCHUA";
            this.colSUCCHUA.Visible = true;
            this.colSUCCHUA.VisibleIndex = 3;
            this.colSUCCHUA.Width = 94;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(sUCCHUALabel);
            this.groupBox1.Controls.Add(this.txtSucChua);
            this.groupBox1.Controls.Add(tRONGLUONGLabel);
            this.groupBox1.Controls.Add(this.txtTrongLuong);
            this.groupBox1.Controls.Add(kIEUDANGLabel);
            this.groupBox1.Controls.Add(this.txtKieuDang);
            this.groupBox1.Controls.Add(mALOAILabel);
            this.groupBox1.Controls.Add(this.txtMaLoai);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 303);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(985, 170);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin";
            // 
            // txtSucChua
            // 
            this.txtSucChua.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsLMB, "SUCCHUA", true));
            this.txtSucChua.Location = new System.Drawing.Point(570, 82);
            this.txtSucChua.MenuManager = this.barManager1;
            this.txtSucChua.Name = "txtSucChua";
            this.txtSucChua.Size = new System.Drawing.Size(125, 22);
            this.txtSucChua.TabIndex = 7;
            // 
            // txtTrongLuong
            // 
            this.txtTrongLuong.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsLMB, "TRONGLUONG", true));
            this.txtTrongLuong.Location = new System.Drawing.Point(570, 38);
            this.txtTrongLuong.MenuManager = this.barManager1;
            this.txtTrongLuong.Name = "txtTrongLuong";
            this.txtTrongLuong.Size = new System.Drawing.Size(125, 22);
            this.txtTrongLuong.TabIndex = 5;
            // 
            // txtKieuDang
            // 
            this.txtKieuDang.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsLMB, "KIEUDANG", true));
            this.txtKieuDang.Location = new System.Drawing.Point(213, 85);
            this.txtKieuDang.MenuManager = this.barManager1;
            this.txtKieuDang.Name = "txtKieuDang";
            this.txtKieuDang.Size = new System.Drawing.Size(125, 22);
            this.txtKieuDang.TabIndex = 3;
            // 
            // txtMaLoai
            // 
            this.txtMaLoai.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsLMB, "MALOAI", true));
            this.txtMaLoai.Location = new System.Drawing.Point(213, 41);
            this.txtMaLoai.MenuManager = this.barManager1;
            this.txtMaLoai.Name = "txtMaLoai";
            this.txtMaLoai.Size = new System.Drawing.Size(125, 22);
            this.txtMaLoai.TabIndex = 1;
            // 
            // bdsCV
            // 
            this.bdsCV.DataMember = "FK_CHUYENVE_LOAIMAYBAY";
            this.bdsCV.DataSource = this.bdsLMB;
            // 
            // bdsL
            // 
            this.bdsL.DataMember = "FK_LAI_LOAIMAYBAY";
            this.bdsL.DataSource = this.bdsLMB;
            // 
            // bdsMB
            // 
            this.bdsMB.DataMember = "FK_MAYBAY_LOAIMAYBAY";
            this.bdsMB.DataSource = this.bdsLMB;
            this.bdsMB.CurrentChanged += new System.EventHandler(this.mAYBAYBindingSource_CurrentChanged);
            // 
            // frmLoaiMB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(985, 473);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gcLoaiMB);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmLoaiMB";
            this.Text = "frmLoaiMB";
            this.Load += new System.EventHandler(this.frmLoaiMB_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLMB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcLoaiMB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSucChua.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTrongLuong.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKieuDang.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaLoai.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsMB)).EndInit();
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
        private System.Windows.Forms.BindingSource bdsLMB;
        private DS DS;
        private DSTableAdapters.LOAIMAYBAYTableAdapter lOAIMAYBAYTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.TextEdit txtSucChua;
        private DevExpress.XtraEditors.TextEdit txtTrongLuong;
        private DevExpress.XtraEditors.TextEdit txtKieuDang;
        private DevExpress.XtraEditors.TextEdit txtMaLoai;
        private DevExpress.XtraGrid.GridControl gcLoaiMB;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMALOAI;
        private DevExpress.XtraGrid.Columns.GridColumn colKIEUDANG;
        private DevExpress.XtraGrid.Columns.GridColumn colTRONGLUONG;
        private DevExpress.XtraGrid.Columns.GridColumn colSUCCHUA;
        private DSTableAdapters.CHUYENVETableAdapter cHUYENVETableAdapter;
        private System.Windows.Forms.BindingSource bdsCV;
        private DSTableAdapters.LAITableAdapter lAITableAdapter;
        private System.Windows.Forms.BindingSource bdsL;
        private DSTableAdapters.MAYBAYTableAdapter mAYBAYTableAdapter;
        private System.Windows.Forms.BindingSource bdsMB;
    }
}