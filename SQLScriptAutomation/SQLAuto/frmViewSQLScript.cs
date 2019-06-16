using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQLAuto
{
    public partial class frmViewSQLScript : Form
    {
        public frmViewSQLScript(string[] ScriptsFound)
        {
            InitializeComponent();

            foreach (var Script in ScriptsFound)
            {
                dgvSQLFiles.Rows.Add(Script.ToString(), true);
            }

        }

        private void btnAbort_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
