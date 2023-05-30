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
    public partial class frmPhiCong : Form
    {
        int vitri = 0;
        bool dangThemMoi = false;
        public frmPhiCong()
        {
            InitializeComponent();
        }

        private void nGUOIBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsNguoi.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS);

        }

        private void frmPhiCong_Load(object sender, EventArgs e)
        {
            DS.EnforceConstraints = false;
            this.nGUOITableAdapter.Connection.ConnectionString = Program.connstr;
            this.nGUOITableAdapter.Fill(this.DS.NGUOI);
            this.pHICONGTableAdapter.Connection.ConnectionString = Program.connstr;
            this.pHICONGTableAdapter.Fill(this.DS.PHICONG);
            this.lAITableAdapter.Connection.ConnectionString = Program.connstr;
            this.lAITableAdapter.Fill(this.DS.LAI);  
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = bdsNguoi.Position;
            dangThemMoi = true;
            panelControl2.Enabled = false;
            bdsNguoi.AddNew();
            btnThem.Enabled = btnHieuChinh.Enabled = btnXoa.Enabled = btnReload.Enabled = btnThoat.Enabled = false;
            btnGhi.Enabled = btnPhucHoi.Enabled = true;
        }

        private void btnHieuChinh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = bdsNguoi.Position;
            panelControl2.Enabled = false;
            btnThem.Enabled = btnHieuChinh.Enabled = btnXoa.Enabled = btnReload.Enabled = btnThoat.Enabled = false;
            btnGhi.Enabled = btnPhucHoi.Enabled = true;
            gcNguoi.Enabled = false;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa người này?", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                String socmnd = ((DataRowView)bdsNguoi[bdsNguoi.Position])["SOCMND"].ToString();
                try
                {

                    bdsNguoi.RemoveCurrent();
                    this.nGUOITableAdapter.Connection.ConnectionString = Program.connstr;
                    this.nGUOITableAdapter.Update(this.DS.NGUOI);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa. Bạn hãy xóa lại\n" + ex.Message, "", MessageBoxButtons.OK);
                    this.nGUOITableAdapter.Fill(this.DS.NGUOI);
                    bdsNguoi.Position = bdsNguoi.Find("SOCMND", socmnd);
                    return;
                }

            }
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (dangThemMoi)
                {
                    dangThemMoi = false;
                    string strLenh = "declare @result int exec @result = sp_KiemTraMaDonDatHang '" + txtSCMND.Text + "' select @result";

                    Program.myReader = Program.ExecSqlDataReader(strLenh);
                    Program.myReader.Read();
                    int result = int.Parse(Program.myReader.GetValue(0).ToString());
                    Program.myReader.Close();

                    if (result == 1)
                    {
                        throw new Exception("Số CMND đã được sử dụng! Vui lòng nhập lại Số CMND khác");
                    }


                }

                bdsNguoi.EndEdit();
                bdsNguoi.ResetCurrentItem();
                this.nGUOITableAdapter.Connection.ConnectionString = Program.connstr;
                this.nGUOITableAdapter.Update(this.DS.NGUOI);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Ghi\n" + ex.Message, "", MessageBoxButtons.OK);
                this.nGUOITableAdapter.Fill(this.DS.NGUOI);
                bdsNguoi.Position = vitri;
            }
            gcNguoi.Enabled = true;
            btnThem.Enabled = btnXoa.Enabled = btnHieuChinh.Enabled = btnReload.Enabled = btnThoat.Enabled = true;
            btnPhucHoi.Enabled = btnGhi.Enabled = false;
        }
        private void reload()
        {

            try
            {
                vitri = bdsNguoi.Position;
                this.nGUOITableAdapter.Fill(this.DS.NGUOI);
                this.pHICONGTableAdapter.Fill(this.DS.PHICONG);
                bdsNguoi.Position = vitri;


            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi reload: " + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
        }
        private void btnPhucHoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (dangThemMoi)
            {
                dangThemMoi = false;
            }
            bdsNguoi.CancelEdit();
            if (btnThem.Enabled == false)
            {
                reload();
            }
            gcNguoi.Enabled = true;

            btnThem.Enabled = btnXoa.Enabled = btnHieuChinh.Enabled = btnReload.Enabled = btnThoat.Enabled = true;
            btnPhucHoi.Enabled = btnGhi.Enabled = false;

        }

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            reload();
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Dispose();
        }

        private void btnThemPC_Click(object sender, EventArgs e)
        {
            btnThem.Enabled = btnXoa.Enabled = btnHieuChinh.Enabled = btnReload.Enabled = btnThoat.Enabled = true;
            btnPhucHoi.Enabled = btnGhi.Enabled = false;

            bdsPC.AddNew();
            txtSCMNDPC.Text = txtSCMND.Text;

            btnThemPC.Enabled = btnXoaPC.Enabled = btnHieuChinhPC.Enabled = false;
            btnGhiPC.Enabled = btnPhucHoiPC.Enabled = true;

        }

        private void btnHieuChinhPC_Click(object sender, EventArgs e)
        {
            panelControl2.Enabled = true;
            btnReload.Enabled = btnThem.Enabled = btnXoa.Enabled = btnHieuChinh.Enabled = false;

            btnThemPC.Enabled = btnXoaPC.Enabled = btnHieuChinhPC.Enabled = false;
            btnGhiPC.Enabled = btnPhucHoiPC.Enabled = true;
        }

        private void btnXoaPC_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa phi công này không ?", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    bdsPC.RemoveCurrent();
                    this.pHICONGTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.pHICONGTableAdapter.Update(this.DS.PHICONG);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa nhân viên. Bạn hãy xóa lại\n" + ex.Message, "", MessageBoxButtons.OK);
                    this.pHICONGTableAdapter.Fill(this.DS.PHICONG);
                    return;
                }

            }
        }

        private void btnGhiPC_Click(object sender, EventArgs e)
        {
            try
            {
                bdsPC.EndEdit();
                bdsPC.ResetCurrentItem();
                this.pHICONGTableAdapter.Connection.ConnectionString = Program.connstr;
                this.pHICONGTableAdapter.Update(this.DS.PHICONG);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Ghi nhân viên\n" + ex.Message, "", MessageBoxButtons.OK);
                this.pHICONGTableAdapter.Fill(this.DS.PHICONG);
            }

            btnThemPC.Enabled = btnXoaPC.Enabled = btnHieuChinhPC.Enabled = true;
            btnGhiPC.Enabled = btnPhucHoiPC.Enabled = false;
            btnReload.Enabled = btnThem.Enabled = btnXoa.Enabled = btnHieuChinh.Enabled = true;
        }

        private void btnPhucHoiPC_Click(object sender, EventArgs e)
        {
            bdsPC.CancelEdit();
            reload();
            gcPC.Enabled = true;
            btnThemPC.Enabled = btnXoaPC.Enabled = btnHieuChinhPC.Enabled = true;
            btnGhiPC.Enabled = btnPhucHoiPC.Enabled = false;
            btnReload.Enabled = btnThem.Enabled = btnXoa.Enabled = btnHieuChinh.Enabled = true;
        }
    }
}
