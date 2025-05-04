namespace Clinc.Appointment
{
    partial class FrmAppointments
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
            this.Doctor = new System.Windows.Forms.Label();
            this.CBDoctor = new System.Windows.Forms.ComboBox();
            this.GBMedicalRecord = new System.Windows.Forms.GroupBox();
            this.PaymentGB = new System.Windows.Forms.GroupBox();
            this.PrescriptionGB = new System.Windows.Forms.GroupBox();
            this.Appointment = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Frequency = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.TBMedication = new System.Windows.Forms.TextBox();
            this.TBFrequency = new System.Windows.Forms.TextBox();
            this.TBDosage = new System.Windows.Forms.TextBox();
            this.TBInstruction = new System.Windows.Forms.TextBox();
            this.TBDiagnosis = new System.Windows.Forms.TextBox();
            this.TBVisitDescription = new System.Windows.Forms.TextBox();
            this.TBAmount = new System.Windows.Forms.TextBox();
            this.TBMethod = new System.Windows.Forms.TextBox();
            this.TbNotes = new System.Windows.Forms.TextBox();
            this.AppStatusTB = new System.Windows.Forms.TextBox();
            this.DTPAppointment = new System.Windows.Forms.DateTimePicker();
            this.DTPPay = new System.Windows.Forms.DateTimePicker();
            this.TBNotesMR = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.DTPStart = new System.Windows.Forms.DateTimePicker();
            this.DTPEnd = new System.Windows.Forms.DateTimePicker();
            this.GBMedicalRecord.SuspendLayout();
            this.PaymentGB.SuspendLayout();
            this.PrescriptionGB.SuspendLayout();
            this.Appointment.SuspendLayout();
            this.SuspendLayout();
            // 
            // Doctor
            // 
            this.Doctor.AutoSize = true;
            this.Doctor.Location = new System.Drawing.Point(41, 32);
            this.Doctor.Name = "Doctor";
            this.Doctor.Size = new System.Drawing.Size(39, 13);
            this.Doctor.TabIndex = 0;
            this.Doctor.Text = "Doctor";
            // 
            // CBDoctor
            // 
            this.CBDoctor.FormattingEnabled = true;
            this.CBDoctor.Location = new System.Drawing.Point(141, 24);
            this.CBDoctor.Name = "CBDoctor";
            this.CBDoctor.Size = new System.Drawing.Size(121, 21);
            this.CBDoctor.TabIndex = 1;
            // 
            // GBMedicalRecord
            // 
            this.GBMedicalRecord.Controls.Add(this.TBNotesMR);
            this.GBMedicalRecord.Controls.Add(this.label8);
            this.GBMedicalRecord.Controls.Add(this.TBVisitDescription);
            this.GBMedicalRecord.Controls.Add(this.TBDiagnosis);
            this.GBMedicalRecord.Controls.Add(this.label3);
            this.GBMedicalRecord.Controls.Add(this.label2);
            this.GBMedicalRecord.Location = new System.Drawing.Point(44, 66);
            this.GBMedicalRecord.Name = "GBMedicalRecord";
            this.GBMedicalRecord.Size = new System.Drawing.Size(312, 233);
            this.GBMedicalRecord.TabIndex = 2;
            this.GBMedicalRecord.TabStop = false;
            this.GBMedicalRecord.Text = "Medical Record";
            // 
            // PaymentGB
            // 
            this.PaymentGB.Controls.Add(this.DTPPay);
            this.PaymentGB.Controls.Add(this.TbNotes);
            this.PaymentGB.Controls.Add(this.TBMethod);
            this.PaymentGB.Controls.Add(this.TBAmount);
            this.PaymentGB.Controls.Add(this.label13);
            this.PaymentGB.Controls.Add(this.label12);
            this.PaymentGB.Controls.Add(this.label11);
            this.PaymentGB.Controls.Add(this.label10);
            this.PaymentGB.Location = new System.Drawing.Point(627, 243);
            this.PaymentGB.Name = "PaymentGB";
            this.PaymentGB.Size = new System.Drawing.Size(289, 290);
            this.PaymentGB.TabIndex = 3;
            this.PaymentGB.TabStop = false;
            this.PaymentGB.Text = "Payment";
            // 
            // PrescriptionGB
            // 
            this.PrescriptionGB.Controls.Add(this.DTPEnd);
            this.PrescriptionGB.Controls.Add(this.DTPStart);
            this.PrescriptionGB.Controls.Add(this.TBInstruction);
            this.PrescriptionGB.Controls.Add(this.TBDosage);
            this.PrescriptionGB.Controls.Add(this.TBFrequency);
            this.PrescriptionGB.Controls.Add(this.TBMedication);
            this.PrescriptionGB.Controls.Add(this.label21);
            this.PrescriptionGB.Controls.Add(this.label20);
            this.PrescriptionGB.Controls.Add(this.label4);
            this.PrescriptionGB.Controls.Add(this.label7);
            this.PrescriptionGB.Controls.Add(this.Frequency);
            this.PrescriptionGB.Controls.Add(this.label5);
            this.PrescriptionGB.Location = new System.Drawing.Point(43, 327);
            this.PrescriptionGB.Name = "PrescriptionGB";
            this.PrescriptionGB.Size = new System.Drawing.Size(312, 400);
            this.PrescriptionGB.TabIndex = 3;
            this.PrescriptionGB.TabStop = false;
            this.PrescriptionGB.Text = "Medication";
            // 
            // Appointment
            // 
            this.Appointment.Controls.Add(this.DTPAppointment);
            this.Appointment.Controls.Add(this.AppStatusTB);
            this.Appointment.Controls.Add(this.label18);
            this.Appointment.Controls.Add(this.lblDate);
            this.Appointment.Location = new System.Drawing.Point(627, 66);
            this.Appointment.Name = "Appointment";
            this.Appointment.Size = new System.Drawing.Size(289, 120);
            this.Appointment.TabIndex = 3;
            this.Appointment.TabStop = false;
            this.Appointment.Text = "Appointment";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(704, 686);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(858, 686);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Save";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Diagnosis";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Visit Description";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "MedicationName";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Start Date";
            // 
            // Frequency
            // 
            this.Frequency.AutoSize = true;
            this.Frequency.Location = new System.Drawing.Point(27, 126);
            this.Frequency.Name = "Frequency";
            this.Frequency.Size = new System.Drawing.Size(57, 13);
            this.Frequency.TabIndex = 2;
            this.Frequency.Text = "Frequency";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 88);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Dosage";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(15, 27);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(30, 13);
            this.lblDate.TabIndex = 1;
            this.lblDate.Text = "Date";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(33, 43);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 13);
            this.label10.TabIndex = 3;
            this.label10.Text = "method";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(33, 84);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(46, 13);
            this.label11.TabIndex = 4;
            this.label11.Text = "Amount ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(33, 128);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(35, 13);
            this.label12.TabIndex = 5;
            this.label12.Text = "Notes";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(33, 246);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(30, 13);
            this.label13.TabIndex = 6;
            this.label13.Text = "Date";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(15, 76);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(37, 13);
            this.label18.TabIndex = 5;
            this.label18.Text = "Status";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(27, 275);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(94, 13);
            this.label20.TabIndex = 5;
            this.label20.Text = "Speical Instruction";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(27, 223);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(52, 13);
            this.label21.TabIndex = 6;
            this.label21.Text = "End Date";
            // 
            // TBMedication
            // 
            this.TBMedication.Location = new System.Drawing.Point(118, 33);
            this.TBMedication.Name = "TBMedication";
            this.TBMedication.Size = new System.Drawing.Size(100, 20);
            this.TBMedication.TabIndex = 7;
            // 
            // TBFrequency
            // 
            this.TBFrequency.Location = new System.Drawing.Point(118, 123);
            this.TBFrequency.Name = "TBFrequency";
            this.TBFrequency.Size = new System.Drawing.Size(100, 20);
            this.TBFrequency.TabIndex = 10;
            // 
            // TBDosage
            // 
            this.TBDosage.Location = new System.Drawing.Point(118, 81);
            this.TBDosage.Name = "TBDosage";
            this.TBDosage.Size = new System.Drawing.Size(100, 20);
            this.TBDosage.TabIndex = 11;
            // 
            // TBInstruction
            // 
            this.TBInstruction.Location = new System.Drawing.Point(30, 296);
            this.TBInstruction.Multiline = true;
            this.TBInstruction.Name = "TBInstruction";
            this.TBInstruction.Size = new System.Drawing.Size(260, 98);
            this.TBInstruction.TabIndex = 12;
            // 
            // TBDiagnosis
            // 
            this.TBDiagnosis.Location = new System.Drawing.Point(114, 37);
            this.TBDiagnosis.Name = "TBDiagnosis";
            this.TBDiagnosis.Size = new System.Drawing.Size(100, 20);
            this.TBDiagnosis.TabIndex = 8;
            // 
            // TBVisitDescription
            // 
            this.TBVisitDescription.Location = new System.Drawing.Point(114, 77);
            this.TBVisitDescription.Name = "TBVisitDescription";
            this.TBVisitDescription.Size = new System.Drawing.Size(100, 20);
            this.TBVisitDescription.TabIndex = 9;
            // 
            // TBAmount
            // 
            this.TBAmount.Location = new System.Drawing.Point(89, 84);
            this.TBAmount.Name = "TBAmount";
            this.TBAmount.Size = new System.Drawing.Size(100, 20);
            this.TBAmount.TabIndex = 14;
            // 
            // TBMethod
            // 
            this.TBMethod.Location = new System.Drawing.Point(89, 40);
            this.TBMethod.Name = "TBMethod";
            this.TBMethod.Size = new System.Drawing.Size(100, 20);
            this.TBMethod.TabIndex = 15;
            // 
            // TbNotes
            // 
            this.TbNotes.Location = new System.Drawing.Point(89, 125);
            this.TbNotes.Multiline = true;
            this.TbNotes.Name = "TbNotes";
            this.TbNotes.Size = new System.Drawing.Size(194, 97);
            this.TbNotes.TabIndex = 16;
            // 
            // AppStatusTB
            // 
            this.AppStatusTB.Location = new System.Drawing.Point(89, 76);
            this.AppStatusTB.Name = "AppStatusTB";
            this.AppStatusTB.Size = new System.Drawing.Size(100, 20);
            this.AppStatusTB.TabIndex = 15;
            // 
            // DTPAppointment
            // 
            this.DTPAppointment.Location = new System.Drawing.Point(89, 21);
            this.DTPAppointment.Name = "DTPAppointment";
            this.DTPAppointment.Size = new System.Drawing.Size(200, 20);
            this.DTPAppointment.TabIndex = 16;
            // 
            // DTPPay
            // 
            this.DTPPay.Location = new System.Drawing.Point(89, 240);
            this.DTPPay.Name = "DTPPay";
            this.DTPPay.Size = new System.Drawing.Size(200, 20);
            this.DTPPay.TabIndex = 17;
            // 
            // TBNotesMR
            // 
            this.TBNotesMR.Location = new System.Drawing.Point(30, 143);
            this.TBNotesMR.Multiline = true;
            this.TBNotesMR.Name = "TBNotesMR";
            this.TBNotesMR.Size = new System.Drawing.Size(260, 84);
            this.TBNotesMR.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(27, 120);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Notes";
            // 
            // DTPStart
            // 
            this.DTPStart.Location = new System.Drawing.Point(88, 173);
            this.DTPStart.Name = "DTPStart";
            this.DTPStart.Size = new System.Drawing.Size(200, 20);
            this.DTPStart.TabIndex = 18;
            // 
            // DTPEnd
            // 
            this.DTPEnd.Location = new System.Drawing.Point(91, 223);
            this.DTPEnd.Name = "DTPEnd";
            this.DTPEnd.Size = new System.Drawing.Size(200, 20);
            this.DTPEnd.TabIndex = 19;
            // 
            // FrmAppointments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1023, 761);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.PaymentGB);
            this.Controls.Add(this.PrescriptionGB);
            this.Controls.Add(this.Appointment);
            this.Controls.Add(this.GBMedicalRecord);
            this.Controls.Add(this.CBDoctor);
            this.Controls.Add(this.Doctor);
            this.Name = "FrmAppointments";
            this.Text = "FrmAppointments";
            this.Load += new System.EventHandler(this.FrmAppointments_Load);
            this.GBMedicalRecord.ResumeLayout(false);
            this.GBMedicalRecord.PerformLayout();
            this.PaymentGB.ResumeLayout(false);
            this.PaymentGB.PerformLayout();
            this.PrescriptionGB.ResumeLayout(false);
            this.PrescriptionGB.PerformLayout();
            this.Appointment.ResumeLayout(false);
            this.Appointment.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Doctor;
        private System.Windows.Forms.ComboBox CBDoctor;
        private System.Windows.Forms.GroupBox GBMedicalRecord;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox PaymentGB;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.GroupBox PrescriptionGB;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label Frequency;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox Appointment;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox TBVisitDescription;
        private System.Windows.Forms.TextBox TBDiagnosis;
        private System.Windows.Forms.TextBox TbNotes;
        private System.Windows.Forms.TextBox TBMethod;
        private System.Windows.Forms.TextBox TBAmount;
        private System.Windows.Forms.TextBox TBInstruction;
        private System.Windows.Forms.TextBox TBDosage;
        private System.Windows.Forms.TextBox TBFrequency;
        private System.Windows.Forms.TextBox TBMedication;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox AppStatusTB;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.DateTimePicker DTPAppointment;
        private System.Windows.Forms.DateTimePicker DTPPay;
        private System.Windows.Forms.TextBox TBNotesMR;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker DTPEnd;
        private System.Windows.Forms.DateTimePicker DTPStart;
    }
}