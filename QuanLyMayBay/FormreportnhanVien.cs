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
    public partial class FormreportnhanVien : Form
    {
        public FormreportnhanVien()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Xrpt_reportnhanvien rpt = new Xrpt_reportnhanvien();

            ReportPrintTool preview = new ReportPrintTool(rpt);
            preview.ShowPreviewDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Xrpt_reportnhanvien rpt = new Xrpt_reportnhanvien();

                if (File.Exists(@"C:\TTCS\Report\DanhSachNhanVien.pdf"))
                {
                    DialogResult dr = MessageBox.Show("File DanhSachNhanVien.pdf đã tồn tại!\nBạn có muốn tạo lại?",
                        "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dr == DialogResult.Yes)
                    {
                        rpt.ExportToPdf(@"C:\TTCS\Report\DanhSachNhanVien.pdf");
                        MessageBox.Show("File DanhSachNhanVien.pdf đã được lưu thành công",
                "Xác nhận", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
                else
                {
                    rpt.ExportToPdf(@"C:\TTCS\Report\DanhSachNhanVien.pdf");
                    MessageBox.Show("File DanhSachNhanVien.pdf đã được lưu thành công",
                "Xác nhận", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (IOException ex)
            {
                MessageBox.Show("Vui lòng đóng file DanhSachNhanVien.pdf",
                    "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                return;
            }
        }
    }
}
