namespace Clinc.Doctors
{
    partial class FrmListDoctors
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnAddDoctors = new System.Windows.Forms.Button();
            this.Doctors = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.Doctors)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 38.25F);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(408, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 59);
            this.label1.TabIndex = 5;
            this.label1.Text = "Doctors";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // BtnAddDoctors
            // 
            this.BtnAddDoctors.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.BtnAddDoctors.ForeColor = System.Drawing.Color.Green;
            this.BtnAddDoctors.Location = new System.Drawing.Point(418, 139);
            this.BtnAddDoctors.Name = "BtnAddDoctors";
            this.BtnAddDoctors.Size = new System.Drawing.Size(171, 79);
            this.BtnAddDoctors.TabIndex = 4;
            this.BtnAddDoctors.Text = "Add Doctors";
            this.BtnAddDoctors.UseVisualStyleBackColor = true;
            this.BtnAddDoctors.Click += new System.EventHandler(this.BtnAddPatient_Click);
            // 
            // Doctors
            // 
            this.Doctors.AllowUserToAddRows = false;
            this.Doctors.AllowUserToDeleteRows = false;
            this.Doctors.AllowUserToOrderColumns = true;
            this.Doctors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Doctors.Location = new System.Drawing.Point(-12, 224);
            this.Doctors.Name = "Doctors";
            this.Doctors.ReadOnly = true;
            this.Doctors.Size = new System.Drawing.Size(1056, 451);
            this.Doctors.TabIndex = 3;
            this.Doctors.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Patients_CellContentClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.allDetailsToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 92);
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.updateToolStripMenuItem.Text = "Update";
            this.updateToolStripMenuItem.Click += new System.EventHandler(this.updateToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // allDetailsToolStripMenuItem
            // 
            this.allDetailsToolStripMenuItem.Name = "allDetailsToolStripMenuItem";
            this.allDetailsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.allDetailsToolStripMenuItem.Text = "All Details";
            this.allDetailsToolStripMenuItem.Click += new System.EventHandler(this.allDetailsToolStripMenuItem_Click);
            // 
            // FrmListDoctors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 675);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnAddDoctors);
            this.Controls.Add(this.Doctors);
            this.Name = "FrmListDoctors";
            this.Text = "FrmListDoctors";
            this.Load += new System.EventHandler(this.FrmListDoctors_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Doctors)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnAddDoctors;
        private System.Windows.Forms.DataGridView Doctors;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allDetailsToolStripMenuItem;
    }
}