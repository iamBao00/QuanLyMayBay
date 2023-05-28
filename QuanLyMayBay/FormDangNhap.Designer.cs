namespace QuanLyMayBay
{
    partial class FormDangNhap
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
            this.btnDangNhap = new System.Windows.Forms.Button();
            this.tePassword = new DevExpress.XtraEditors.TextEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.teUserName = new DevExpress.XtraEditors.TextEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.lbDangNhap = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tePassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teUserName.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnDangNhap.FlatAppearance.BorderSize = 0;
            this.btnDangNhap.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnDangNhap.ForeColor = System.Drawing.Color.White;
            this.btnDangNhap.Location = new System.Drawing.Point(389, 427);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(247, 44);
            this.btnDangNhap.TabIndex = 15;
            this.btnDangNhap.Text = "ĐĂNG NHẬP";
            this.btnDangNhap.UseVisualStyleBackColor = false;
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
            // 
            // tePassword
            // 
            this.tePassword.Location = new System.Drawing.Point(204, 304);
            this.tePassword.Name = "tePassword";
            this.tePassword.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 13F);
            this.tePassword.Properties.Appearance.Options.UseFont = true;
            this.tePassword.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.tePassword.Properties.PasswordChar = '*';
            this.tePassword.Size = new System.Drawing.Size(597, 34);
            this.tePassword.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 13F);
            this.label3.Location = new System.Drawing.Point(199, 274);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 27);
            this.label3.TabIndex = 13;
            this.label3.Text = "Password";
            // 
            // teUserName
            // 
            this.teUserName.Location = new System.Drawing.Point(204, 237);
            this.teUserName.Name = "teUserName";
            this.teUserName.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 13F);
            this.teUserName.Properties.Appearance.Options.UseFont = true;
            this.teUserName.Size = new System.Drawing.Size(597, 34);
            this.teUserName.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 13F);
            this.label2.Location = new System.Drawing.Point(199, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 27);
            this.label2.TabIndex = 11;
            this.label2.Text = "Username";
            // 
            // lbDangNhap
            // 
            this.lbDangNhap.AutoSize = true;
            this.lbDangNhap.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold);
            this.lbDangNhap.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lbDangNhap.Location = new System.Drawing.Point(412, 112);
            this.lbDangNhap.Name = "lbDangNhap";
            this.lbDangNhap.Size = new System.Drawing.Size(200, 36);
            this.lbDangNhap.TabIndex = 9;
            this.lbDangNhap.Text = "ĐĂNG NHẬP";
            this.lbDangNhap.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 562);
            this.Controls.Add(this.btnDangNhap);
            this.Controls.Add(this.tePassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.teUserName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbDangNhap);
            this.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormDangNhap";
            this.Text = "FormDangNhap";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.tePassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teUserName.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDangNhap;
        private DevExpress.XtraEditors.TextEdit tePassword;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.TextEdit teUserName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbDangNhap;
    }
}