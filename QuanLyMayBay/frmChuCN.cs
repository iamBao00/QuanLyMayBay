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
            QuanLyMayBay.DS.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'dS.NGUOI' table. You can move, or remove it, as needed.
            this.nGUOITableAdapter.Fill(this.DS.NGUOI);
            // TODO: This line of code loads data into the 'dS.CHUMAYBAY' table. You can move, or remove it, as needed.
            this.cHUMAYBAYTableAdapter.Fill(this.DS.CHUMAYBAY);

        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }
    }
}
