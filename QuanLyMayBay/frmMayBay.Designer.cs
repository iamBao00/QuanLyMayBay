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
            System.Windows.Forms.Label mALOAILabel;
            System.Windows.Forms.Label mANHACHUALabel;
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
            this.dICHVUBAOTRITableAdapter = new QuanLyMayBay.DSTableAdapters.DICHVUBAOTRITableAdapter();
            this.sOHUUTableAdapter = new QuanLyMayBay.DSTableAdapters.SOHUUTableAdapter();
            this.gcMayBay = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMADANGKY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMALOAI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMANHACHUA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbNhaChua = new System.Windows.Forms.ComboBox();
            this.bdsMNC = new System.Windows.Forms.BindingSource(this.components);
            this.cmbLoaiMB = new System.Windows.Forms.ComboBox();
            this.bdsLMB = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaNC = new DevExpress.XtraEditors.TextEdit();
            this.txtMaLoai = new DevExpress.XtraEditors.TextEdit();
            this.txtMaDK = new DevExpress.XtraEditors.TextEdit();
            this.bdsDVBT = new System.Windows.Forms.BindingSource(this.components);
            this.bdsSH = new System.Windows.Forms.BindingSource(this.components);
            this.lOAIMAYBAYTableAdapter = new QuanLyMayBay.DSTableAdapters.LOAIMAYBAYTableAdapter();
            this.nHACHUAMAYBAYTableAdapter = new QuanLyMayBay.DSTableAdapters.NHACHUAMAYBAYTableAdapter();
            mADANGKYLabel = new System.Windows.Forms.Label();
            mALOAILabel = new System.Windows.Forms.Label();
            mANHACHUALabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsMB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcMayBay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsMNC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLMB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaNC.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaLoai.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaDK.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDVBT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsSH)).BeginInit();
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
            // mALOAILabel
            // 
            mALOAILabel.AutoSize = true;
            mALOAILabel.Location = new System.Drawing.Point(469, 74);
            mALOAILabel.Name = "mALOAILabel";
            mALOAILabel.Size = new System.Drawing.Size(54, 16);
            mALOAILabel.TabIndex = 2;
            mALOAILabel.Text = "Mã loại:";
            // 
            // mANHACHUALabel
            // 
            mANHACHUALabel.AutoSize = true;
            mANHACHUALabel.Location = new System.Drawing.Point(431, 110);
            mANHACHUALabel.Name = "mANHACHUALabel";
            mANHACHUALabel.Size = new System.Drawing.Size(86, 16);
            mANHACHUALabel.TabIndex = 4;
            mANHACHUALabel.Text = "Mã nhà chứa:";
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
            this.barDockControlTop.Size = new System.Drawing.Size(784, 25);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 476);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(784, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 25);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 451);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(784, 25);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 451);
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
            this.tableAdapterManager.DICHVUBAOTRITableAdapter = this.dICHVUBAOTRITableAdapter;
            this.tableAdapterManager.DOANHNGHIEPTableAdapter = null;
            this.tableAdapterManager.LAITableAdapter = null;
            this.tableAdapterManager.LOAIMAYBAYTableAdapter = null;
            this.tableAdapterManager.MAYBAYTableAdapter = this.mAYBAYTableAdapter;
            this.tableAdapterManager.NGUOITableAdapter = null;
            this.tableAdapterManager.NHACHUAMAYBAYTableAdapter = null;
            this.tableAdapterManager.NHANVIENTableAdapter = null;
            this.tableAdapterManager.PHICONGTableAdapter = null;
            this.tableAdapterManager.SOHUUTableAdapter = this.sOHUUTableAdapter;
            this.tableAdapterManager.UpdateOrder = QuanLyMayBay.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // dICHVUBAOTRITableAdapter
            // 
            this.dICHVUBAOTRITableAdapter.ClearBeforeFill = true;
            // 
            // sOHUUTableAdapter
            // 
            this.sOHUUTableAdapter.ClearBeforeFill = true;
            // 
            // gcMayBay
            // 
            this.gcMayBay.DataSource = this.bdsMB;
            this.gcMayBay.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcMayBay.Location = new System.Drawing.Point(0, 25);
            this.gcMayBay.MainView = this.gridView1;
            this.gcMayBay.MenuManager = this.barManager1;
            this.gcMayBay.Name = "gcMayBay";
            this.gcMayBay.Size = new System.Drawing.Size(784, 220);
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
            this.groupBox1.Controls.Add(this.cmbNhaChua);
            this.groupBox1.Controls.Add(this.cmbLoaiMB);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(mANHACHUALabel);
            this.groupBox1.Controls.Add(this.txtMaNC);
            this.groupBox1.Controls.Add(mALOAILabel);
            this.groupBox1.Controls.Add(this.txtMaLoai);
            this.groupBox1.Controls.Add(mADANGKYLabel);
            this.groupBox1.Controls.Add(this.txtMaDK);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 318);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(784, 158);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin";
            // 
            // cmbNhaChua
            // 
            this.cmbNhaChua.DataSource = this.bdsMNC;
            this.cmbNhaChua.DisplayMember = "MANHACHUA";
            this.cmbNhaChua.FormattingEnabled = true;
            this.cmbNhaChua.Location = new System.Drawing.Point(184, 114);
            this.cmbNhaChua.Name = "cmbNhaChua";
            this.cmbNhaChua.Size = new System.Drawing.Size(125, 24);
            this.cmbNhaChua.TabIndex = 9;
            this.cmbNhaChua.ValueMember = "MANHACHUA";
            this.cmbNhaChua.SelectedIndexChanged += new System.EventHandler(this.cmbNhaChua_SelectedIndexChanged);
            // 
            // bdsMNC
            // 
            this.bdsMNC.DataMember = "NHACHUAMAYBAY";
            this.bdsMNC.DataSource = this.DS;
            // 
            // cmbLoaiMB
            // 
            this.cmbLoaiMB.DataSource = this.bdsLMB;
            this.cmbLoaiMB.FormattingEnabled = true;
            this.cmbLoaiMB.Location = new System.Drawing.Point(184, 74);
            this.cmbLoaiMB.Name = "cmbLoaiMB";
            this.cmbLoaiMB.Size = new System.Drawing.Size(125, 24);
            this.cmbLoaiMB.TabIndex = 8;
            this.cmbLoaiMB.ValueMember = "MALOAI";
            this.cmbLoaiMB.SelectedIndexChanged += new System.EventHandler(this.cmbLoaiMB_SelectedIndexChanged);
            // 
            // bdsLMB
            // 
            this.bdsLMB.DataMember = "LOAIMAYBAY";
            this.bdsLMB.DataSource = this.DS;
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
            // txtMaNC
            // 
            this.txtMaNC.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsMB, "MANHACHUA", true));
            this.txtMaNC.Enabled = false;
            this.txtMaNC.Location = new System.Drawing.Point(534, 107);
            this.txtMaNC.MenuManager = this.barManager1;
            this.txtMaNC.Name = "txtMaNC";
            this.txtMaNC.Size = new System.Drawing.Size(125, 22);
            this.txtMaNC.TabIndex = 5;
            // 
            // txtMaLoai
            // 
            this.txtMaLoai.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsMB, "MALOAI", true));
            this.txtMaLoai.Enabled = false;
            this.txtMaLoai.Location = new System.Drawing.Point(534, 71);
            this.txtMaLoai.MenuManager = this.barManager1;
            this.txtMaLoai.Name = "txtMaLoai";
            this.txtMaLoai.Size = new System.Drawing.Size(125, 22);
            this.txtMaLoai.TabIndex = 3;
            // 
            // txtMaDK
            // 
            this.txtMaDK.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsMB, "MADANGKY", true));
            this.txtMaDK.Location = new System.Drawing.Point(184, 34);
            this.txtMaDK.MenuManager = this.barManager1;
            this.txtMaDK.Name = "txtMaDK";
            this.txtMaDK.Size = new System.Drawing.Size(125, 22);
            this.txtMaDK.TabIndex = 1;
            // 
            // bdsDVBT
            // 
            this.bdsDVBT.DataMember = "FK_DICHVUBAOTRI_MAYBAY";
            this.bdsDVBT.DataSource = this.bdsMB;
            // 
            // bdsSH
            // 
            this.bdsSH.DataMember = "FK_SOHUU_MAYBAY";
            this.bdsSH.DataSource = this.bdsMB;
            // 
            // lOAIMAYBAYTableAdapter
            // 
            this.lOAIMAYBAYTableAdapter.ClearBeforeFill = true;
            // 
            // nHACHUAMAYBAYTableAdapter
            // 
            this.nHACHUAMAYBAYTableAdapter.ClearBeforeFill = true;
            // 
            // frmMayBay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(784, 476);
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
            ((System.ComponentModel.ISupportInitialize)(this.bdsMNC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLMB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaNC.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaLoai.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaDK.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDVBT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsSH)).EndInit();
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
        private DevExpress.XtraEditors.TextEdit txtMaNC;
        private DevExpress.XtraEditors.TextEdit txtMaLoai;
        private DevExpress.XtraEditors.TextEdit txtMaDK;
        private DevExpress.XtraGrid.GridControl gcMayBay;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMADANGKY;
        private DevExpress.XtraGrid.Columns.GridColumn colMALOAI;
        private DevExpress.XtraGrid.Columns.GridColumn colMANHACHUA;
        private DSTableAdapters.DICHVUBAOTRITableAdapter dICHVUBAOTRITableAdapter;
        private System.Windows.Forms.BindingSource bdsDVBT;
        private DSTableAdapters.SOHUUTableAdapter sOHUUTableAdapter;
        private System.Windows.Forms.BindingSource bdsSH;
        private System.Windows.Forms.BindingSource bdsLMB;
        private DSTableAdapters.LOAIMAYBAYTableAdapter lOAIMAYBAYTableAdapter;
        private System.Windows.Forms.BindingSource bdsMNC;
        private DSTableAdapters.NHACHUAMAYBAYTableAdapter nHACHUAMAYBAYTableAdapter;
        private System.Windows.Forms.ComboBox cmbNhaChua;
        private System.Windows.Forms.ComboBox cmbLoaiMB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}