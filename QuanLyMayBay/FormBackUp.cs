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
    public partial class FormBackUp : Form
    {
        public FormBackUp()
        {
            InitializeComponent();
        }


        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtFile_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void btnBrow_Click_1(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
            {
                // Thiết lập các tùy chọn cho FolderBrowserDialog
                folderBrowserDialog.Description = "Chọn thư mục";
                folderBrowserDialog.RootFolder = Environment.SpecialFolder.MyComputer;
                folderBrowserDialog.ShowNewFolderButton = false;

                // Hiển thị hộp thoại chọn thư mục
                DialogResult result = folderBrowserDialog.ShowDialog();

                // Xử lý kết quả chọn thư mục
                if (result == DialogResult.OK)
                {
                    string selectedPath = folderBrowserDialog.SelectedPath;
                    txtDuongDan.Text = selectedPath;
                }
            }
        }

        private void btnBackup_Click_1(object sender, EventArgs e)
        {
            try
            {
                string backup = txtDuongDan.Text + "\\" + txtFile.Text + ".bak";
                string strLenh = "exec BackupData '" + backup + "'";
                int check = Program.ExecSqlNonQuery(strLenh);
                if (check != 0)
                {
                    MessageBox.Show("Sao lưu thành công!", "", MessageBoxButtons.OK);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error\n" + ex.Message, "", MessageBoxButtons.OK);
            }
        }
    }
}
