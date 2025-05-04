namespace Clinc.Doctors
{
    partial class FrmAddDoctor
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
            this.label1 = new System.Windows.Forms.Label();
            this.TBSpecialization = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.ctrlAddUpdate1 = new Clinc.CtrlAddUpdate();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(467, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Specialization";
            // 
            // TBSpecialization
            // 
            this.TBSpecialization.Location = new System.Drawing.Point(572, 137);
            this.TBSpecialization.Name = "TBSpecialization";
            this.TBSpecialization.Size = new System.Drawing.Size(100, 20);
            this.TBSpecialization.TabIndex = 2;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(441, 682);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(587, 682);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(75, 23);
            this.BtnSave.TabIndex = 4;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // ctrlAddUpdate1
            // 
            this.ctrlAddUpdate1.Location = new System.Drawing.Point(33, 12);
            this.ctrlAddUpdate1.Name = "ctrlAddUpdate1";
            this.ctrlAddUpdate1.Size = new System.Drawing.Size(417, 603);
            this.ctrlAddUpdate1.TabIndex = 0;
            this.ctrlAddUpdate1.Load += new System.EventHandler(this.ctrlAddUpdate1_Load);
            // 
            // FrmAddDoctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 777);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.TBSpecialization);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ctrlAddUpdate1);
            this.Name = "FrmAddDoctor";
            this.Text = "FrmAddDoctor";
            this.Load += new System.EventHandler(this.FrmAddDoctor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CtrlAddUpdate ctrlAddUpdate1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TBSpecialization;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button BtnSave;
    }
}