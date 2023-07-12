namespace QuanLyMayBay
{
    partial class frmTaoTaiKhoan
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.txtTaiKhoan = new System.Windows.Forms.TextBox();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.txtXacNhanMK = new System.Windows.Forms.TextBox();
            this.btnTaoTK = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnNV = new System.Windows.Forms.Button();
            this.rbAdmin = new System.Windows.Forms.CheckBox();
            this.rbNhanVien = new System.Windows.Forms.CheckBox();
            this.dS = new QuanLyMayBay.DS();
            this.v_DanhSachTaiKhoanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.v_DanhSachTaiKhoanTableAdapter = new QuanLyMayBay.DSTableAdapters.V_DanhSachTaiKhoanTableAdapter();
            this.tableAdapterManager = new QuanLyMayBay.DSTableAdapters.TableAdapterManager();
            this.v_DanhSachTaiKhoanGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colTenDangNhap = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaNhanVien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQuyen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnReload = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.v_DanhSachTaiKhoanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.v_DanhSachTaiKhoanGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã nhân viên:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tài khoản:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mật khẩu:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(67, 253);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Xác nhân mật khẩu:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(67, 301);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Nhóm:";
            // 
            // txtMaNV
            // 
            this.txtMaNV.Location = new System.Drawing.Point(217, 92);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(159, 22);
            this.txtMaNV.TabIndex = 5;
            // 
            // txtTaiKhoan
            // 
            this.txtTaiKhoan.Location = new System.Drawing.Point(217, 144);
            this.txtTaiKhoan.Name = "txtTaiKhoan";
            this.txtTaiKhoan.Size = new System.Drawing.Size(159, 22);
            this.txtTaiKhoan.TabIndex = 6;
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Location = new System.Drawing.Point(217, 198);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Size = new System.Drawing.Size(159, 22);
            this.txtMatKhau.TabIndex = 7;
            // 
            // txtXacNhanMK
            // 
            this.txtXacNhanMK.Location = new System.Drawing.Point(217, 250);
            this.txtXacNhanMK.Name = "txtXacNhanMK";
            this.txtXacNhanMK.Size = new System.Drawing.Size(159, 22);
            this.txtXacNhanMK.TabIndex = 8;
            // 
            // btnTaoTK
            // 
            this.btnTaoTK.Location = new System.Drawing.Point(70, 365);
            this.btnTaoTK.Name = "btnTaoTK";
            this.btnTaoTK.Size = new System.Drawing.Size(119, 23);
            this.btnTaoTK.TabIndex = 9;
            this.btnTaoTK.Text = "Tạo tài khoản";
            this.btnTaoTK.UseVisualStyleBackColor = true;
            this.btnTaoTK.Click += new System.EventHandler(this.btnTaoTK_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(257, 365);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(119, 23);
            this.btnThoat.TabIndex = 10;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnNV
            // 
            this.btnNV.Location = new System.Drawing.Point(400, 92);
            this.btnNV.Name = "btnNV";
            this.btnNV.Size = new System.Drawing.Size(119, 23);
            this.btnNV.TabIndex = 11;
            this.btnNV.Text = "Chọn nhân viên";
            this.btnNV.UseVisualStyleBackColor = true;
            this.btnNV.Click += new System.EventHandler(this.btnNV_Click);
            // 
            // rbAdmin
            // 
            this.rbAdmin.AutoSize = true;
            this.rbAdmin.Location = new System.Drawing.Point(217, 300);
            this.rbAdmin.Name = "rbAdmin";
            this.rbAdmin.Size = new System.Drawing.Size(72, 20);
            this.rbAdmin.TabIndex = 12;
            this.rbAdmin.Text = "ADMIN";
            this.rbAdmin.UseVisualStyleBackColor = true;
            // 
            // rbNhanVien
            // 
            this.rbNhanVien.AutoSize = true;
            this.rbNhanVien.Location = new System.Drawing.Point(315, 300);
            this.rbNhanVien.Name = "rbNhanVien";
            this.rbNhanVien.Size = new System.Drawing.Size(99, 20);
            this.rbNhanVien.TabIndex = 13;
            this.rbNhanVien.Text = "NHANVIEN";
            this.rbNhanVien.UseVisualStyleBackColor = true;
            // 
            // dS
            // 
            this.dS.DataSetName = "DS";
            this.dS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // v_DanhSachTaiKhoanBindingSource
            // 
            this.v_DanhSachTaiKhoanBindingSource.DataMember = "V_DanhSachTaiKhoan";
            this.v_DanhSachTaiKhoanBindingSource.DataSource = this.dS;
            // 
            // v_DanhSachTaiKhoanTableAdapter
            // 
            this.v_DanhSachTaiKhoanTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CHUMAYBAYTableAdapter = null;
            this.tableAdapterManager.CHUYENVETableAdapter = null;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.DICHVUBAOTRITableAdapter = null;
            this.tableAdapterManager.DOANHNGHIEPTableAdapter = null;
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
            // v_DanhSachTaiKhoanGridControl
            // 
            this.v_DanhSachTaiKhoanGridControl.DataSource = this.v_DanhSachTaiKhoanBindingSource;
            this.v_DanhSachTaiKhoanGridControl.Dock = System.Windows.Forms.DockStyle.Right;
            this.v_DanhSachTaiKhoanGridControl.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.v_DanhSachTaiKhoanGridControl.Location = new System.Drawing.Point(613, 0);
            this.v_DanhSachTaiKhoanGridControl.MainView = this.gridView1;
            this.v_DanhSachTaiKhoanGridControl.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.v_DanhSachTaiKhoanGridControl.Name = "v_DanhSachTaiKhoanGridControl";
            this.v_DanhSachTaiKhoanGridControl.Size = new System.Drawing.Size(562, 441);
            this.v_DanhSachTaiKhoanGridControl.TabIndex = 15;
            this.v_DanhSachTaiKhoanGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTenDangNhap,
            this.colMaNhanVien,
            this.colQuyen});
            this.gridView1.DetailHeight = 546;
            this.gridView1.GridControl = this.v_DanhSachTaiKhoanGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // colTenDangNhap
            // 
            this.colTenDangNhap.FieldName = "TenDangNhap";
            this.colTenDangNhap.MinWidth = 39;
            this.colTenDangNhap.Name = "colTenDangNhap";
            this.colTenDangNhap.Visible = true;
            this.colTenDangNhap.VisibleIndex = 0;
            this.colTenDangNhap.Width = 146;
            // 
            // colMaNhanVien
            // 
            this.colMaNhanVien.FieldName = "MaNhanVien";
            this.colMaNhanVien.MinWidth = 39;
            this.colMaNhanVien.Name = "colMaNhanVien";
            this.colMaNhanVien.Visible = true;
            this.colMaNhanVien.VisibleIndex = 1;
            this.colMaNhanVien.Width = 146;
            // 
            // colQuyen
            // 
            this.colQuyen.FieldName = "Quyen";
            this.colQuyen.MinWidth = 39;
            this.colQuyen.Name = "colQuyen";
            this.colQuyen.Visible = true;
            this.colQuyen.VisibleIndex = 2;
            this.colQuyen.Width = 146;
            // 
            // btnReload
            // 
            this.btnReload.Location = new System.Drawing.Point(420, 365);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(119, 23);
            this.btnReload.TabIndex = 16;
            this.btnReload.Text = "Reload";
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // frmTaoTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1175, 441);
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.v_DanhSachTaiKhoanGridControl);
            this.Controls.Add(this.rbNhanVien);
            this.Controls.Add(this.rbAdmin);
            this.Controls.Add(this.btnNV);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnTaoTK);
            this.Controls.Add(this.txtXacNhanMK);
            this.Controls.Add(this.txtMatKhau);
            this.Controls.Add(this.txtTaiKhoan);
            this.Controls.Add(this.txtMaNV);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmTaoTaiKhoan";
            this.Text = "frmTaoTaiKhoan";
            this.Load += new System.EventHandler(this.frmTaoTaiKhoan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.v_DanhSachTaiKhoanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.v_DanhSachTaiKhoanGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.TextBox txtTaiKhoan;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.TextBox txtXacNhanMK;
        private System.Windows.Forms.Button btnTaoTK;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnNV;
        private System.Windows.Forms.CheckBox rbAdmin;
        private System.Windows.Forms.CheckBox rbNhanVien;
        private DS dS;
        private System.Windows.Forms.BindingSource v_DanhSachTaiKhoanBindingSource;
        private DSTableAdapters.V_DanhSachTaiKhoanTableAdapter v_DanhSachTaiKhoanTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl v_DanhSachTaiKhoanGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colTenDangNhap;
        private DevExpress.XtraGrid.Columns.GridColumn colMaNhanVien;
        private DevExpress.XtraGrid.Columns.GridColumn colQuyen;
        private System.Windows.Forms.Button btnReload;
    }
}