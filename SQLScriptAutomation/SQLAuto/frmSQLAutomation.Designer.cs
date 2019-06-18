namespace SQLAuto
{
    partial class frmSQLAutomation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSQLAutomation));
            this.btnSearchPath = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtRootPath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnExecute = new System.Windows.Forms.Button();
            this.lblPath = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtServerAndInstance = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSearchPath
            // 
            this.btnSearchPath.Location = new System.Drawing.Point(12, 110);
            this.btnSearchPath.Name = "btnSearchPath";
            this.btnSearchPath.Size = new System.Drawing.Size(52, 23);
            this.btnSearchPath.TabIndex = 0;
            this.btnSearchPath.Text = "Search";
            this.btnSearchPath.UseVisualStyleBackColor = true;
            this.btnSearchPath.Click += new System.EventHandler(this.BtnSearchPath_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(74, 264);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(89, 23);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // txtRootPath
            // 
            this.txtRootPath.Location = new System.Drawing.Point(12, 84);
            this.txtRootPath.Name = "txtRootPath";
            this.txtRootPath.Size = new System.Drawing.Size(249, 20);
            this.txtRootPath.TabIndex = 2;
            this.txtRootPath.Enter += new System.EventHandler(this.txtRootPath_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Executed scripts can\'t be reverted by this application.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(9, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "WARNING:";
            // 
            // btnExecute
            // 
            this.btnExecute.Location = new System.Drawing.Point(169, 264);
            this.btnExecute.Name = "btnExecute";
            this.btnExecute.Size = new System.Drawing.Size(92, 23);
            this.btnExecute.TabIndex = 5;
            this.btnExecute.Text = "Lookup Scripts";
            this.btnExecute.UseVisualStyleBackColor = true;
            this.btnExecute.Click += new System.EventHandler(this.BtnExecute_Click);
            // 
            // lblPath
            // 
            this.lblPath.AutoSize = true;
            this.lblPath.Location = new System.Drawing.Point(9, 68);
            this.lblPath.Name = "lblPath";
            this.lblPath.Size = new System.Drawing.Size(52, 13);
            this.lblPath.TabIndex = 6;
            this.lblPath.Text = "Directory:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Enter a server name:";
            // 
            // txtServerAndInstance
            // 
            this.txtServerAndInstance.Location = new System.Drawing.Point(12, 180);
            this.txtServerAndInstance.Name = "txtServerAndInstance";
            this.txtServerAndInstance.Size = new System.Drawing.Size(249, 20);
            this.txtServerAndInstance.TabIndex = 8;
            this.txtServerAndInstance.Enter += new System.EventHandler(this.txtServerAndInstance_Enter);
            this.txtServerAndInstance.Leave += new System.EventHandler(this.txtServerAndInstance_Leave);
            // 
            // frmSQLAutomation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(273, 299);
            this.Controls.Add(this.txtServerAndInstance);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblPath);
            this.Controls.Add(this.btnExecute);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtRootPath);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSearchPath);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSQLAutomation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SQL Script AutoRun";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSearchPath;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtRootPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnExecute;
        private System.Windows.Forms.Label lblPath;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtServerAndInstance;
    }
}

