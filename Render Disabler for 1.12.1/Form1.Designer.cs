namespace Render_Disabler_for_1._12._1
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gridActive = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.gridPid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridChar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bScanForProcess = new System.Windows.Forms.Button();
            this.bUpdateRenderState = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gridActive,
            this.gridPid,
            this.gridChar});
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(351, 234);
            this.dataGridView1.TabIndex = 0;
            // 
            // gridActive
            // 
            this.gridActive.HeaderText = "Active";
            this.gridActive.Name = "gridActive";
            // 
            // gridPid
            // 
            this.gridPid.HeaderText = "Pid";
            this.gridPid.Name = "gridPid";
            this.gridPid.ReadOnly = true;
            // 
            // gridChar
            // 
            this.gridChar.HeaderText = "Toon Name";
            this.gridChar.Name = "gridChar";
            this.gridChar.ReadOnly = true;
            // 
            // bScanForProcess
            // 
            this.bScanForProcess.Location = new System.Drawing.Point(25, 252);
            this.bScanForProcess.Name = "bScanForProcess";
            this.bScanForProcess.Size = new System.Drawing.Size(154, 24);
            this.bScanForProcess.TabIndex = 1;
            this.bScanForProcess.Text = "Scan for WoW";
            this.bScanForProcess.UseVisualStyleBackColor = true;
            this.bScanForProcess.Click += new System.EventHandler(this.bScanForProcess_Click);
            // 
            // bUpdateRenderState
            // 
            this.bUpdateRenderState.Location = new System.Drawing.Point(199, 252);
            this.bUpdateRenderState.Name = "bUpdateRenderState";
            this.bUpdateRenderState.Size = new System.Drawing.Size(141, 24);
            this.bUpdateRenderState.TabIndex = 2;
            this.bUpdateRenderState.Text = "Update Render State";
            this.bUpdateRenderState.UseVisualStyleBackColor = true;
            this.bUpdateRenderState.Click += new System.EventHandler(this.bUpdateRenderState_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 291);
            this.Controls.Add(this.bUpdateRenderState);
            this.Controls.Add(this.bScanForProcess);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Render Disabler 1.12.1 - zzuks.blogspot.com";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button bScanForProcess;
        private System.Windows.Forms.Button bUpdateRenderState;
        private System.Windows.Forms.DataGridViewCheckBoxColumn gridActive;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridPid;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridChar;
    }
}

