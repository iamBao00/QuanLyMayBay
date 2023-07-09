namespace QuanLyMayBay
{
    partial class FormChuyenVe
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
            System.Windows.Forms.Label lOAILabel;
            System.Windows.Forms.Label mALOAILabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormChuyenVe));
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
            this.bds_NhanVien = new System.Windows.Forms.BindingSource(this.components);
            this.nHANVIENTableAdapter = new QuanLyMayBay.DSTableAdapters.NHANVIENTableAdapter();
            this.tableAdapterManager = new QuanLyMayBay.DSTableAdapters.TableAdapterManager();
            this.GC_NhanVien = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMANV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOCMND = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLUONG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.bds_ChuyenVe = new System.Windows.Forms.BindingSource(this.components);
            this.txtMaLoai = new DevExpress.XtraEditors.TextEdit();
            this.cmb_Loai = new System.Windows.Forms.ComboBox();
            this.bds_LoaiMayBay = new System.Windows.Forms.BindingSource(this.components);
            this.cHUYENVETableAdapter = new QuanLyMayBay.DSTableAdapters.CHUYENVETableAdapter();
            this.GC_ChuyenVe = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMANV1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMALOAI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cB_LOAIMAYBAYTableAdapter = new QuanLyMayBay.DSTableAdapters.CB_LOAIMAYBAYTableAdapter();
            this.txtMaNV = new DevExpress.XtraEditors.TextEdit();
            mANVLabel = new System.Windows.Forms.Label();
            lOAILabel = new System.Windows.Forms.Label();
            mALOAILabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds_NhanVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GC_NhanVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bds_ChuyenVe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaLoai.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds_LoaiMayBay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GC_ChuyenVe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaNV.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // mANVLabel
            // 
            mANVLabel.AutoSize = true;
            mANVLabel.Location = new System.Drawing.Point(67, 64);
            mANVLabel.Name = "mANVLabel";
            mANVLabel.Size = new System.Drawing.Size(49, 16);
            mANVLabel.TabIndex = 0;
            mANVLabel.Text = "Mã NV:";
            // 
            // lOAILabel
            // 
            lOAILabel.AutoSize = true;
            lOAILabel.Location = new System.Drawing.Point(67, 132);
            lOAILabel.Name = "lOAILabel";
            lOAILabel.Size = new System.Drawing.Size(39, 16);
            lOAILabel.TabIndex = 2;
            lOAILabel.Text = "Loại: ";
            // 
            // mALOAILabel
            // 
            mALOAILabel.AutoSize = true;
            mALOAILabel.Location = new System.Drawing.Point(56, 183);
            mALOAILabel.Name = "mALOAILabel";
            mALOAILabel.Size = new System.Drawing.Size(56, 16);
            mALOAILabel.TabIndex = 4;
            mALOAILabel.Text = "Mã Loại:";
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
            this.barDockControl4.Size = new System.Drawing.Size(1004, 30);
            // 
            // barDockControl5
            // 
            this.barDockControl5.CausesValidation = false;
            this.barDockControl5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControl5.Location = new System.Drawing.Point(0, 527);
            this.barDockControl5.Manager = this.barManager2;
            this.barDockControl5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControl5.Size = new System.Drawing.Size(1004, 0);
            // 
            // barDockControl6
            // 
            this.barDockControl6.CausesValidation = false;
            this.barDockControl6.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControl6.Location = new System.Drawing.Point(0, 30);
            this.barDockControl6.Manager = this.barManager2;
            this.barDockControl6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControl6.Size = new System.Drawing.Size(0, 497);
            // 
            // barDockControl8
            // 
            this.barDockControl8.CausesValidation = false;
            this.barDockControl8.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControl8.Location = new System.Drawing.Point(1004, 30);
            this.barDockControl8.Manager = this.barManager2;
            this.barDockControl8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControl8.Size = new System.Drawing.Size(0, 497);
            // 
            // dS
            // 
            this.dS.DataSetName = "DS";
            this.dS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.tableAdapterManager.NGUOITableAdapter = null;
            this.tableAdapterManager.NHACHUAMAYBAYTableAdapter = null;
            this.tableAdapterManager.NHANVIENTableAdapter = this.nHANVIENTableAdapter;
            this.tableAdapterManager.PHICONGTableAdapter = null;
            this.tableAdapterManager.SOHUUTableAdapter = null;
            this.tableAdapterManager.ThongTinNhanVienTableAdapter = null;
            this.tableAdapterManager.ThongTinPhiCongTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QuanLyMayBay.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // GC_NhanVien
            // 
            this.GC_NhanVien.DataSource = this.bds_NhanVien;
            this.GC_NhanVien.Dock = System.Windows.Forms.DockStyle.Top;
            this.GC_NhanVien.Location = new System.Drawing.Point(0, 30);
            this.GC_NhanVien.MainView = this.gridView1;
            this.GC_NhanVien.MenuManager = this.barManager2;
            this.GC_NhanVien.Name = "GC_NhanVien";
            this.GC_NhanVien.Size = new System.Drawing.Size(1004, 220);
            this.GC_NhanVien.TabIndex = 5;
            this.GC_NhanVien.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMANV,
            this.colSOCMND,
            this.colCA,
            this.colLUONG});
            this.gridView1.GridControl = this.GC_NhanVien;
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
            // colSOCMND
            // 
            this.colSOCMND.FieldName = "SOCMND";
            this.colSOCMND.MinWidth = 25;
            this.colSOCMND.Name = "colSOCMND";
            this.colSOCMND.Visible = true;
            this.colSOCMND.VisibleIndex = 1;
            this.colSOCMND.Width = 94;
            // 
            // colCA
            // 
            this.colCA.FieldName = "CA";
            this.colCA.MinWidth = 25;
            this.colCA.Name = "colCA";
            this.colCA.Visible = true;
            this.colCA.VisibleIndex = 2;
            this.colCA.Width = 94;
            // 
            // colLUONG
            // 
            this.colLUONG.FieldName = "LUONG";
            this.colLUONG.MinWidth = 25;
            this.colLUONG.Name = "colLUONG";
            this.colLUONG.Visible = true;
            this.colLUONG.VisibleIndex = 3;
            this.colLUONG.Width = 94;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.txtMaNV);
            this.panelControl1.Controls.Add(mALOAILabel);
            this.panelControl1.Controls.Add(this.txtMaLoai);
            this.panelControl1.Controls.Add(lOAILabel);
            this.panelControl1.Controls.Add(this.cmb_Loai);
            this.panelControl1.Controls.Add(mANVLabel);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelControl1.Location = new System.Drawing.Point(0, 250);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(795, 277);
            this.panelControl1.TabIndex = 10;
            // 
            // bds_ChuyenVe
            // 
            this.bds_ChuyenVe.DataMember = "FK_CHUYENVE_NHANVIEN";
            this.bds_ChuyenVe.DataSource = this.bds_NhanVien;
            // 
            // txtMaLoai
            // 
            this.txtMaLoai.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bds_ChuyenVe, "MALOAI", true));
            this.txtMaLoai.Location = new System.Drawing.Point(119, 180);
            this.txtMaLoai.MenuManager = this.barManager2;
            this.txtMaLoai.Name = "txtMaLoai";
            this.txtMaLoai.Size = new System.Drawing.Size(94, 22);
            this.txtMaLoai.TabIndex = 5;
            this.txtMaLoai.EditValueChanged += new System.EventHandler(this.txtLoai_EditValueChanged);
            // 
            // cmb_Loai
            // 
            this.cmb_Loai.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bds_LoaiMayBay, "LOAI", true));
            this.cmb_Loai.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bds_ChuyenVe, "MALOAI", true));
            this.cmb_Loai.DataSource = this.bds_LoaiMayBay;
            this.cmb_Loai.DisplayMember = "LOAI";
            this.cmb_Loai.FormattingEnabled = true;
            this.cmb_Loai.Location = new System.Drawing.Point(119, 129);
            this.cmb_Loai.Name = "cmb_Loai";
            this.cmb_Loai.Size = new System.Drawing.Size(454, 24);
            this.cmb_Loai.TabIndex = 3;
            this.cmb_Loai.ValueMember = "MALOAI";
            this.cmb_Loai.SelectedIndexChanged += new System.EventHandler(this.cmb_Loai_SelectedIndexChanged);
            // 
            // bds_LoaiMayBay
            // 
            this.bds_LoaiMayBay.DataMember = "CB_LOAIMAYBAY";
            this.bds_LoaiMayBay.DataSource = this.dS;
            // 
            // cHUYENVETableAdapter
            // 
            this.cHUYENVETableAdapter.ClearBeforeFill = true;
            // 
            // GC_ChuyenVe
            // 
            this.GC_ChuyenVe.DataSource = this.bds_ChuyenVe;
            this.GC_ChuyenVe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GC_ChuyenVe.Location = new System.Drawing.Point(795, 250);
            this.GC_ChuyenVe.MainView = this.gridView2;
            this.GC_ChuyenVe.MenuManager = this.barManager2;
            this.GC_ChuyenVe.Name = "GC_ChuyenVe";
            this.GC_ChuyenVe.Size = new System.Drawing.Size(209, 277);
            this.GC_ChuyenVe.TabIndex = 10;
            this.GC_ChuyenVe.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMANV1,
            this.colMALOAI});
            this.gridView2.GridControl = this.GC_ChuyenVe;
            this.gridView2.Name = "gridView2";
            // 
            // colMANV1
            // 
            this.colMANV1.FieldName = "MANV";
            this.colMANV1.MinWidth = 25;
            this.colMANV1.Name = "colMANV1";
            this.colMANV1.Visible = true;
            this.colMANV1.VisibleIndex = 0;
            this.colMANV1.Width = 94;
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
            // cB_LOAIMAYBAYTableAdapter
            // 
            this.cB_LOAIMAYBAYTableAdapter.ClearBeforeFill = true;
            // 
            // txtMaNV
            // 
            this.txtMaNV.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bds_NhanVien, "MANV", true));
            this.txtMaNV.Location = new System.Drawing.Point(119, 61);
            this.txtMaNV.MenuManager = this.barManager2;
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(125, 22);
            this.txtMaNV.TabIndex = 7;
            this.txtMaNV.EditValueChanged += new System.EventHandler(this.txtMaNV_EditValueChanged);
            // 
            // FormChuyenVe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 527);
            this.Controls.Add(this.GC_ChuyenVe);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.GC_NhanVien);
            this.Controls.Add(this.barDockControl6);
            this.Controls.Add(this.barDockControl8);
            this.Controls.Add(this.barDockControl5);
            this.Controls.Add(this.barDockControl4);
            this.Name = "FormChuyenVe";
            this.Text = "FormChuyenVe";
            this.Load += new System.EventHandler(this.FormChuyenVe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds_NhanVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GC_NhanVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bds_ChuyenVe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaLoai.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds_LoaiMayBay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GC_ChuyenVe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaNV.Properties)).EndInit();
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
        private System.Windows.Forms.BindingSource bds_NhanVien;
        private DS dS;
        private DSTableAdapters.NHANVIENTableAdapter nHANVIENTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl GC_NhanVien;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMANV;
        private DevExpress.XtraGrid.Columns.GridColumn colSOCMND;
        private DevExpress.XtraGrid.Columns.GridColumn colCA;
        private DevExpress.XtraGrid.Columns.GridColumn colLUONG;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.BindingSource bds_ChuyenVe;
        private DSTableAdapters.CHUYENVETableAdapter cHUYENVETableAdapter;
        private DevExpress.XtraGrid.GridControl GC_ChuyenVe;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colMANV1;
        private DevExpress.XtraGrid.Columns.GridColumn colMALOAI;
        private System.Windows.Forms.BindingSource bds_LoaiMayBay;
        private DSTableAdapters.CB_LOAIMAYBAYTableAdapter cB_LOAIMAYBAYTableAdapter;
        private DevExpress.XtraEditors.TextEdit txtMaLoai;
        private System.Windows.Forms.ComboBox cmb_Loai;
        private DevExpress.XtraEditors.TextEdit txtMaNV;
    }
}