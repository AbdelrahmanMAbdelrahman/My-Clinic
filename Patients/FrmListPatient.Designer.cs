namespace Clinc
{
    partial class FrmListPatient
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
            this.Patients = new System.Windows.Forms.DataGridView();
            this.BtnAddPatient = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.takeAppointmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.Patients)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Patients
            // 
            this.Patients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Patients.Location = new System.Drawing.Point(1, 203);
            this.Patients.Name = "Patients";
            this.Patients.Size = new System.Drawing.Size(1036, 411);
            this.Patients.TabIndex = 0;
            this.Patients.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Patients_CellContentClick);
            // 
            // BtnAddPatient
            // 
            this.BtnAddPatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.BtnAddPatient.ForeColor = System.Drawing.Color.Green;
            this.BtnAddPatient.Location = new System.Drawing.Point(435, 127);
            this.BtnAddPatient.Name = "BtnAddPatient";
            this.BtnAddPatient.Size = new System.Drawing.Size(156, 49);
            this.BtnAddPatient.TabIndex = 1;
            this.BtnAddPatient.Text = "Add Patient";
            this.BtnAddPatient.UseVisualStyleBackColor = true;
            this.BtnAddPatient.Click += new System.EventHandler(this.BtnAddPatient_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 38.25F);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(409, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 59);
            this.label1.TabIndex = 2;
            this.label1.Text = "Patients ";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.allDetailsToolStripMenuItem,
            this.takeAppointmentToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 114);
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
            // takeAppointmentToolStripMenuItem
            // 
            this.takeAppointmentToolStripMenuItem.Name = "takeAppointmentToolStripMenuItem";
            this.takeAppointmentToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.takeAppointmentToolStripMenuItem.Text = "Take Appointment";
            this.takeAppointmentToolStripMenuItem.Click += new System.EventHandler(this.takeAppointmentToolStripMenuItem_Click);
            // 
            // FrmListPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1035, 616);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnAddPatient);
            this.Controls.Add(this.Patients);
            this.Name = "FrmListPatient";
            this.Text = "FrmListPatient";
            this.Load += new System.EventHandler(this.FrmListPatient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Patients)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Patients;
        private System.Windows.Forms.Button BtnAddPatient;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem takeAppointmentToolStripMenuItem;
    }
}