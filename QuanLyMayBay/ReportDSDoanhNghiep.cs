using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace QuanLyMayBay
{
    public partial class ReportDSDoanhNghiep : DevExpress.XtraReports.UI.XtraReport
    {
        public ReportDSDoanhNghiep()
        {
            InitializeComponent();
            this.sqlDataSource1.Connection.ConnectionString = Program.connstr;
            this.sqlDataSource1.Fill();
        }

    }
}
