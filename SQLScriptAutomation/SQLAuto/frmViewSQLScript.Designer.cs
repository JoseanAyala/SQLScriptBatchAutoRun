namespace SQLAuto
{
    partial class frmViewSQLScript
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmViewSQLScript));
            this.dgvSQLFiles = new System.Windows.Forms.DataGridView();
            this.btnAbort = new System.Windows.Forms.Button();
            this.btnRunScripts = new System.Windows.Forms.Button();
            this.SQLScripts = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IncludeInBatch = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSQLFiles)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSQLFiles
            // 
            this.dgvSQLFiles.AllowUserToAddRows = false;
            this.dgvSQLFiles.AllowUserToDeleteRows = false;
            this.dgvSQLFiles.AllowUserToOrderColumns = true;
            this.dgvSQLFiles.AllowUserToResizeRows = false;
            this.dgvSQLFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSQLFiles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSQLFiles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SQLScripts,
            this.IncludeInBatch});
            this.dgvSQLFiles.Location = new System.Drawing.Point(12, 12);
            this.dgvSQLFiles.Name = "dgvSQLFiles";
            this.dgvSQLFiles.Size = new System.Drawing.Size(348, 316);
            this.dgvSQLFiles.TabIndex = 0;
            // 
            // btnAbort
            // 
            this.btnAbort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAbort.Location = new System.Drawing.Point(12, 338);
            this.btnAbort.Name = "btnAbort";
            this.btnAbort.Size = new System.Drawing.Size(75, 23);
            this.btnAbort.TabIndex = 1;
            this.btnAbort.Text = "Abort";
            this.btnAbort.UseVisualStyleBackColor = true;
            this.btnAbort.Click += new System.EventHandler(this.btnAbort_Click);
            // 
            // btnRunScripts
            // 
            this.btnRunScripts.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRunScripts.Location = new System.Drawing.Point(285, 338);
            this.btnRunScripts.Name = "btnRunScripts";
            this.btnRunScripts.Size = new System.Drawing.Size(75, 23);
            this.btnRunScripts.TabIndex = 2;
            this.btnRunScripts.Text = "Run Scripts";
            this.btnRunScripts.UseVisualStyleBackColor = true;
            // 
            // SQLScripts
            // 
            this.SQLScripts.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SQLScripts.HeaderText = "Script";
            this.SQLScripts.Name = "SQLScripts";
            this.SQLScripts.ReadOnly = true;
            // 
            // IncludeInBatch
            // 
            this.IncludeInBatch.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.IncludeInBatch.HeaderText = "Include in Batch";
            this.IncludeInBatch.Name = "IncludeInBatch";
            this.IncludeInBatch.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // frmViewSQLScript
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 373);
            this.Controls.Add(this.btnRunScripts);
            this.Controls.Add(this.btnAbort);
            this.Controls.Add(this.dgvSQLFiles);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmViewSQLScript";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SQL Batch Confirmation";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSQLFiles)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSQLFiles;
        private System.Windows.Forms.Button btnAbort;
        private System.Windows.Forms.Button btnRunScripts;
        private System.Windows.Forms.DataGridViewTextBoxColumn SQLScripts;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IncludeInBatch;
    }
}