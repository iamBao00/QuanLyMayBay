using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyMayBay
{
    public partial class frmReportDSDoanhNghiep : Form
    {
        public frmReportDSDoanhNghiep()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            ReportDSDoanhNghiep rpt = new ReportDSDoanhNghiep();

            ReportPrintTool preview = new ReportPrintTool(rpt);
            preview.ShowPreviewDialog();
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            try
            {
                ReportDSDoanhNghiep rpt = new ReportDSDoanhNghiep();

                if (File.Exists(@"C:\TTCS\Report\DanhSachDoanhNghiep.pdf"))
                {
                    DialogResult dr = MessageBox.Show("File DanhSachDoanhNghiep.pdf đã tồn tại!\nBạn có muốn tạo lại?",
                        "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dr == DialogResult.Yes)
                    {
                        rpt.ExportToPdf(@"C:\TTCS\Report\DanhSachDoanhNghiep.pdf");
                        MessageBox.Show("File DanhSachDoanhNghiep.pdf đã được lưu thành công",
                "Xác nhận", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
                else
                {
                    rpt.ExportToPdf(@"C:\TTCS\Report\DanhSachDoanhNghiep.pdf");
                    MessageBox.Show("File DanhSachDoanhNghiep.pdf đã được lưu thành công",
                "Xác nhận", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (IOException ex)
            {
                MessageBox.Show("Vui lòng đóng file DanhSachDoanhNghiep.pdf",
                    "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                return;
            }
        }
    }
}
