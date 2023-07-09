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
    public partial class frmReportPhiCong : Form
    {
        public frmReportPhiCong()
        {
            InitializeComponent();
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            Xrpt_reportPC rpt = new Xrpt_reportPC();

            ReportPrintTool preview = new ReportPrintTool(rpt);
            preview.ShowPreviewDialog();
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            try
            {
                Xrpt_reportPC rpt = new Xrpt_reportPC();

                if (File.Exists(@"C:\TTCS\Report\DanhSachPhiCong.pdf"))
                {
                    DialogResult dr = MessageBox.Show("File DanhSachPhiCong.pdf đã tồn tại!\nBạn có muốn tạo lại?",
                        "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dr == DialogResult.Yes)
                    {
                        rpt.ExportToPdf(@"C:\TTCS\Report\DanhSachPhiCong.pdf");
                        MessageBox.Show("File DanhSachPhiCong.pdf đã được lưu thành công",
                "Xác nhận", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
                else
                {
                    rpt.ExportToPdf(@"C:\TTCS\Report\DanhSachPhiCong.pdf");
                    MessageBox.Show("File DanhSachPhiCong.pdf đã được lưu thành công",
                "Xác nhận", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (IOException ex)
            {
                MessageBox.Show("Vui lòng đóng file DanhSachPhiCong.pdf",
                    "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                return;
            }
        }
    }
}
