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
        public string RootFolderPath { get => _rootFolderPath;}

        public frmSQLAutomation()
        {
            InitializeComponent();
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
          
            var ScriptsFound = Directory.GetFiles(_rootFolderPath, "*.sql", SearchOption.AllDirectories);

            frmViewSQLScript frmViewScripts = new frmViewSQLScript(ScriptsFound);
            frmViewScripts.ShowDialog();


               
 
        }
    }
}
