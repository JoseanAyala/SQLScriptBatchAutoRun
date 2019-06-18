using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQLAuto
{
    public partial class frmViewSQLScript : Form
    {
        private String _serverName;
        public frmViewSQLScript(string[] ScriptsFound, String txtServer)
        {
            InitializeComponent();

            _serverName = txtServer;
            foreach (var Script in ScriptsFound)
            {
                dgvSQLFiles.Rows.Add(Script.ToString(), true);
            }

        }

        private void btnAbort_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnRunScripts_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("The selected SQL scripts will be executed.\nDo you want to continue?",
                                "Confirm SQL Script Execution",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                 foreach (DataGridViewRow _scriptPath in dgvSQLFiles.Rows)
                 {
                    if (Convert.ToInt32(_scriptPath.Cells["IncludeInBatch"].Value) == 1)
                    {
                        MessageBox.Show(_scriptPath.Cells[0].Value.ToString());
                        ExecuteCommand("sqlcmd -S" + _serverName + " -i " + _scriptPath.Cells["ScriptPath"].Value.ToString() + " & exit");

                    }
                 }

                MessageBox.Show("SQL Scripts have been executed, verify if all of the changes have been applied to the database.");
                this.Close();
            }          
        }
        private void ExecuteCommand(string _command)
        {
            ProcessStartInfo _processInfo;
            Process _process;

            _processInfo = new ProcessStartInfo("cmd.exe", "/K " + _command);
            _processInfo.CreateNoWindow = true;
            _processInfo.UseShellExecute = true;

            _process = Process.Start(_processInfo);
        }
    }
}
