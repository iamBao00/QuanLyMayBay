using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace QuanLyMayBay
{
    public partial class ReportDSDVBaoTri : DevExpress.XtraReports.UI.XtraReport
    {
        public ReportDSDVBaoTri()
        {
            InitializeComponent();
            this.sqlDataSource1.Connection.ConnectionString = Program.connstr;
            this.sqlDataSource1.Fill();
        }

    }
}
