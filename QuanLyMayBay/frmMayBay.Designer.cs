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
            mADANGKYLabel = new System.Windows.Forms.Label();
            mALOAILabel = new System.Windows.Forms.Label();
            mANHACHUALabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsMB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcMayBay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaDK.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds_cb_NhaChuaMayBay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds_cb_loaiMB)).BeginInit();
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
            mALOAILabel.Location = new System.Drawing.Point(704, 85);
            mALOAILabel.Name = "mALOAILabel";
            mALOAILabel.Size = new System.Drawing.Size(54, 16);
            mALOAILabel.TabIndex = 2;
            mALOAILabel.Text = "Mã loại:";
            // 
            // mANHACHUALabel
            // 
            mANHACHUALabel.AutoSize = true;
            mANHACHUALabel.Location = new System.Drawing.Point(704, 122);
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
            this.barDockControlTop.Size = new System.Drawing.Size(936, 25);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 477);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(936, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 25);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 452);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(936, 25);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 452);
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
            this.gcMayBay.Size = new System.Drawing.Size(936, 220);
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
            this.groupBox1.Controls.Add(mANHACHUALabel);
            this.groupBox1.Controls.Add(mALOAILabel);
            this.groupBox1.Controls.Add(mADANGKYLabel);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 245);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(936, 232);
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
            this.txtMaDK.Size = new System.Drawing.Size(139, 22);
            this.txtMaDK.TabIndex = 13;
            // 
            // txtMaNC
            // 
            this.txtMaNC.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsMB, "MANHACHUA", true));
            this.txtMaNC.Location = new System.Drawing.Point(805, 119);
            this.txtMaNC.Name = "txtMaNC";
            this.txtMaNC.ReadOnly = true;
            this.txtMaNC.Size = new System.Drawing.Size(100, 22);
            this.txtMaNC.TabIndex = 12;
            // 
            // txtMaLoai
            // 
            this.txtMaLoai.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsMB, "MALOAI", true));
            this.txtMaLoai.Location = new System.Drawing.Point(805, 79);
            this.txtMaLoai.Name = "txtMaLoai";
            this.txtMaLoai.ReadOnly = true;
            this.txtMaLoai.Size = new System.Drawing.Size(100, 22);
            this.txtMaLoai.TabIndex = 11;
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
            this.cmb_NhaChuaMB.Size = new System.Drawing.Size(514, 24);
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
            this.cmb_LoaiMB.Size = new System.Drawing.Size(514, 24);
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
            // frmMayBay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(936, 477);
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
    }
}