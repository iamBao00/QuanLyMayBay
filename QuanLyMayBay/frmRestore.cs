using DevExpress.Utils.CommonDialogs;
using DevExpress.Xpo.DB;
using QuanLyMayBay;
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
    public partial class frmRestore : Form
    {
        public frmRestore()
        {
            InitializeComponent();
        }

        private void btnBrow_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                string selectedFilePath = openFile.FileName;
                txtDuongDan.Text = selectedFilePath;
            }
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            string database = Program.database;

            string str1 = string.Format($"ALTER DATABASE [{database}] SET SINGLE_USER WITH ROLLBACK IMMEDIATE");
            Program.KetNoi();
            Program.ExecSqlNonQuery(str1);

            string str2 = $"USE MASTER RESTORE DATABASE [{database}] FROM DISK = '{txtDuongDan.Text}' WITH REPLACE;";
            Program.KetNoi();
            int check = Program.ExecSqlNonQuery(str2);

            string str3 = string.Format($"ALTER DATABASE [{database}] SET MULTI_USER;");
            Program.KetNoi();
            Program.ExecSqlNonQuery(str3);
            if (check != 0)
            {
                MessageBox.Show("Phục hồi thành công!\n Chương trình sẽ khởi động lại");
                System.Diagnostics.Process.Start(Application.ExecutablePath);
                Application.Exit();
            }
        }

        private void txtDuongDan_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
