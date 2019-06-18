using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace SQLAuto
{
    public partial class frmSQLAutomation : Form
    {
        string _rootFolderPath = string.Empty;

        public frmSQLAutomation()
        {
            InitializeComponent();

            txtServerAndInstance.Text = "Server\\instanceName";
            txtServerAndInstance.ForeColor = Color.Gray;
        }

        private void BtnSearchPath_Click(object sender, EventArgs e)
        {
              using (FolderBrowserDialog _FolderBrowserDialog = new FolderBrowserDialog())
            {
                if (_FolderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    _rootFolderPath = _FolderBrowserDialog.SelectedPath;
                    this.txtRootPath.Text = _rootFolderPath;
                }
            }
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnExecute_Click(object sender, EventArgs e)
        {
            if (txtRootPath.Text == String.Empty)
            {
                txtRootPath.BackColor = System.Drawing.Color.Red;
            }else if (txtServerAndInstance.Text == "Server\\instanceName")
            {
                txtServerAndInstance.BackColor = System.Drawing.Color.Red;
            }
            else
            {
                try
                {
                    var ScriptsFound = Directory.GetFiles(_rootFolderPath, "*.sql", SearchOption.AllDirectories);
                    frmViewSQLScript frmViewScripts = new frmViewSQLScript(ScriptsFound, txtServerAndInstance.Text);
                    frmViewScripts.ShowDialog();
                }
                catch (Exception)
                {
                    MessageBox.Show("Unable to find Directory.");
                }
               
            }
            
        }
        private void txtServerAndInstance_Enter(object sender, EventArgs e)
        {
            txtServerAndInstance.BackColor = default;
            if (txtServerAndInstance.Text == "Server\\instanceName")
            {
                txtServerAndInstance.Text = "";
                txtServerAndInstance.ForeColor = default;
            }
        }

        private void txtServerAndInstance_Leave(object sender, EventArgs e)
        {
            if (txtServerAndInstance.Text == "")
            {
                txtServerAndInstance.Text = "Server\\instanceName";
                txtServerAndInstance.ForeColor = Color.Gray;
            }
        }
        private void txtRootPath_Enter (object sender, EventArgs e)
        {
            txtRootPath.BackColor = default;
        }
    }
}
