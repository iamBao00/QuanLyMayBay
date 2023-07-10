namespace QuanLyMayBay
{
    partial class frmReportChuCaNhan
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
            this.btnIn = new System.Windows.Forms.Button();
            this.btnXem = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnIn
            // 
            this.btnIn.Location = new System.Drawing.Point(429, 263);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(110, 39);
            this.btnIn.TabIndex = 5;
            this.btnIn.Text = "In Danh Sách";
            this.btnIn.UseVisualStyleBackColor = true;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // btnXem
            // 
            this.btnXem.Location = new System.Drawing.Point(229, 263);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(98, 39);
            this.btnXem.TabIndex = 4;
            this.btnXem.Text = "Xem";
            this.btnXem.UseVisualStyleBackColor = true;
            this.btnXem.Click += new System.EventHandler(this.btnXem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(122, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(571, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "DANH SÁCH CÁ NHÂN SỞ HỮU MÁY BAY";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // frmReportChuCaNhan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnIn);
            this.Controls.Add(this.btnXem);
            this.Controls.Add(this.label1);
            this.Name = "frmReportChuCaNhan";
            this.Text = "FormChuCaNhan";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.Button btnXem;
        private System.Windows.Forms.Label label1;
    }
}