using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyMayBay
{
    public partial class frmChuCN : Form
    {

        public frmChuCN()
        {
            InitializeComponent();
        }

        private void cHUMAYBAYBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsCMB.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS);

        }

        private void frmChu_Load(object sender, EventArgs e)
        {
            DS.EnforceConstraints = false;
            this.nGUOITableAdapter.Connection.ConnectionString = Program.connstr;
            this.nGUOITableAdapter.Fill(this.DS.NGUOI);
            this.cHUMAYBAYTableAdapter.Connection.ConnectionString = Program.connstr;
            this.cHUMAYBAYTableAdapter.Fill(this.DS.CHUMAYBAY);

        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }
    }
}
