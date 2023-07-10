namespace QuanLyMayBay
{
    partial class FormBackUp
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
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnBackup = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnBrow = new System.Windows.Forms.Button();
            this.txtDuongDan = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFile = new DevExpress.XtraEditors.TextEdit();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDuongDan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFile.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.label2);
            this.panelControl1.Controls.Add(this.txtFile);
            this.panelControl1.Controls.Add(this.btnBackup);
            this.panelControl1.Controls.Add(this.btnThoat);
            this.panelControl1.Controls.Add(this.btnBrow);
            this.panelControl1.Controls.Add(this.txtDuongDan);
            this.panelControl1.Controls.Add(this.label1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1207, 621);
            this.panelControl1.TabIndex = 0;
            // 
            // btnBackup
            // 
            this.btnBackup.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBackup.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnBackup.Location = new System.Drawing.Point(580, 449);
            this.btnBackup.Margin = new System.Windows.Forms.Padding(4);
            this.btnBackup.Name = "btnBackup";
            this.btnBackup.Size = new System.Drawing.Size(149, 64);
            this.btnBackup.TabIndex = 11;
            this.btnBackup.Text = "BackUp";
            this.btnBackup.UseVisualStyleBackColor = true;
            this.btnBackup.Click += new System.EventHandler(this.btnBackup_Click_1);
            // 
            // btnThoat
            // 
            this.btnThoat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThoat.Location = new System.Drawing.Point(305, 449);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(149, 64);
            this.btnThoat.TabIndex = 10;
            this.btnThoat.Text = "EXIT";
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // btnBrow
            // 
            this.btnBrow.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBrow.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnBrow.Location = new System.Drawing.Point(765, 176);
            this.btnBrow.Margin = new System.Windows.Forms.Padding(4);
            this.btnBrow.Name = "btnBrow";
            this.btnBrow.Size = new System.Drawing.Size(141, 36);
            this.btnBrow.TabIndex = 9;
            this.btnBrow.Text = "Browser";
            this.btnBrow.UseVisualStyleBackColor = true;
            this.btnBrow.Click += new System.EventHandler(this.btnBrow_Click_1);
            // 
            // txtDuongDan
            // 
            this.txtDuongDan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDuongDan.Location = new System.Drawing.Point(305, 184);
            this.txtDuongDan.Margin = new System.Windows.Forms.Padding(4);
            this.txtDuongDan.Name = "txtDuongDan";
            this.txtDuongDan.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtDuongDan.Properties.Appearance.Options.UseFont = true;
            this.txtDuongDan.Size = new System.Drawing.Size(390, 28);
            this.txtDuongDan.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(301, 141);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 22);
            this.label1.TabIndex = 7;
            this.label1.Text = "File Path";
            // 
            // txtFile
            // 
            this.txtFile.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtFile.Location = new System.Drawing.Point(305, 336);
            this.txtFile.Margin = new System.Windows.Forms.Padding(4);
            this.txtFile.Name = "txtFile";
            this.txtFile.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtFile.Properties.Appearance.Options.UseFont = true;
            this.txtFile.Size = new System.Drawing.Size(390, 28);
            this.txtFile.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(301, 288);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 22);
            this.label2.TabIndex = 14;
            this.label2.Text = "File Name";
            // 
            // FormBackUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1207, 621);
            this.Controls.Add(this.panelControl1);
            this.Name = "FormBackUp";
            this.Text = "FormBackUp";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDuongDan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFile.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.Button btnBackup;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnBrow;
        private DevExpress.XtraEditors.TextEdit txtDuongDan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.TextEdit txtFile;
    }
}