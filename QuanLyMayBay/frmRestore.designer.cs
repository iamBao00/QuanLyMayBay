namespace QuanLyMayBay
{
    partial class frmRestore
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
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnBackup = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnBrow = new System.Windows.Forms.Button();
            this.txtDuongDan = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDuongDan.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnBackup);
            this.panelControl1.Controls.Add(this.btnThoat);
            this.panelControl1.Controls.Add(this.btnBrow);
            this.panelControl1.Controls.Add(this.txtDuongDan);
            this.panelControl1.Controls.Add(this.label1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(4);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1128, 578);
            this.panelControl1.TabIndex = 1;
            // 
            // btnBackup
            // 
            this.btnBackup.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBackup.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnBackup.Location = new System.Drawing.Point(621, 358);
            this.btnBackup.Margin = new System.Windows.Forms.Padding(4);
            this.btnBackup.Name = "btnBackup";
            this.btnBackup.Size = new System.Drawing.Size(149, 64);
            this.btnBackup.TabIndex = 4;
            this.btnBackup.Text = "RESTORE";
            this.btnBackup.UseVisualStyleBackColor = true;
            this.btnBackup.Click += new System.EventHandler(this.btnBackup_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThoat.Location = new System.Drawing.Point(349, 358);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(149, 64);
            this.btnThoat.TabIndex = 3;
            this.btnThoat.Text = "EXIT";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnBrow
            // 
            this.btnBrow.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBrow.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnBrow.Location = new System.Drawing.Point(718, 250);
            this.btnBrow.Margin = new System.Windows.Forms.Padding(4);
            this.btnBrow.Name = "btnBrow";
            this.btnBrow.Size = new System.Drawing.Size(141, 36);
            this.btnBrow.TabIndex = 2;
            this.btnBrow.Text = "Browser";
            this.btnBrow.UseVisualStyleBackColor = true;
            this.btnBrow.Click += new System.EventHandler(this.btnBrow_Click);
            // 
            // txtDuongDan
            // 
            this.txtDuongDan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDuongDan.Location = new System.Drawing.Point(293, 251);
            this.txtDuongDan.Margin = new System.Windows.Forms.Padding(4);
            this.txtDuongDan.Name = "txtDuongDan";
            this.txtDuongDan.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtDuongDan.Properties.Appearance.Options.UseFont = true;
            this.txtDuongDan.Size = new System.Drawing.Size(390, 28);
            this.txtDuongDan.TabIndex = 1;
            this.txtDuongDan.EditValueChanged += new System.EventHandler(this.txtDuongDan_EditValueChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(289, 209);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "File Path:";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // frmRestore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1128, 578);
            this.Controls.Add(this.panelControl1);
            this.Name = "frmRestore";
            this.Text = "frmRestore";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDuongDan.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.Button btnBackup;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnBrow;
        private DevExpress.XtraEditors.TextEdit txtDuongDan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}