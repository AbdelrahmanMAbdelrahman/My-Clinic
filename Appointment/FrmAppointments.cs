using ClinceBusiness;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clinc.Appointment
{
    public partial class FrmAppointments: Form
    {
        int _PatientID=0;
        int _DoctorID = 0;
        public FrmAppointments(int patientID)
        {
            InitializeComponent();
            _PatientID = patientID;
        }

        private void FrmAppointments_Load(object sender, EventArgs e)
        {
            CBDoctor.DataSource = ClsDoctorBus.GetAllDoctors();
            CBDoctor.DisplayMember = "Name";
            CBDoctor.ValueMember = "DoctorID";

           // CBDoctor.Items=
        }
        private bool AddNewPaymentMethod()
        {
            ClsPaymentBus Payment = new ClsPaymentBus();
            Payment.AmountPaid = Convert.ToInt32( TBAmount.Text);
            Payment.PaymentMethod = TBMethod.Text;
            Payment.AddtionalNotes = TbNotes.Text;
            Payment.PaymentDate = DTPPay.Value;
            return Payment.Save();
        }
        private bool AddNewPrescription()
        {
            ClsPrescriptionBus Prescription = new ClsPrescriptionBus();
            Prescription.Instruction = TBInstruction.Text;
            Prescription.Dosage = TBDosage.Text;
            Prescription.EndDate = DTPEnd.Value;
            Prescription.StartDate = DTPStart.Value;
            Prescription.Frequency = Convert.ToInt32(TBFrequency.Text.Trim());
            Prescription.MedicationName = TBMedication.Text;
            Prescription.MedicalRecordID = 1;
            return Prescription.Save();
        }
        private bool AddNewMedicalRecord()
        {
            ClsMedicalRecordBus MedicalRecord = new ClsMedicalRecordBus();
            MedicalRecord.Diagnosis = TBDiagnosis.Text;
            MedicalRecord.VisiteDescription = TBVisitDescription.Text;
            MedicalRecord.AdditionalNotes = TBNotesMR.Text;
            return MedicalRecord.Save();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            ClsAppoinetmentBus appoinetment = new ClsAppoinetmentBus()
                ;
            appoinetment.PatientID = _PatientID;
            appoinetment.DoctorID = Convert.ToInt16(CBDoctor.SelectedValue);// i want to assign selected doctorid to Doctor ID 
            appoinetment.AppointmentDate = DTPAppointment.Value;
            appoinetment.AppoinmentStatus =(byte) Convert.ToInt16(AppStatusTB.Text);
            appoinetment.Payment.PaymentMethod = TBMethod.Text;
            appoinetment.Payment.PaymentDate = DTPPay.Value;
            appoinetment.Payment.AmountPaid = Convert.ToInt32(TBAmount.Text);
            appoinetment.Payment.AddtionalNotes =TbNotes.Text;
            appoinetment.MedicalRecord.VisiteDescription = TBVisitDescription.Text;
            appoinetment.MedicalRecord.Diagnosis = TBDiagnosis.Text;
            appoinetment.MedicalRecord.AdditionalNotes = TbNotes.Text;

            if (appoinetment.Save())
            {
                MessageBox.Show("Payment has been added succesffully");
            }
            else
            {
                MessageBox.Show("Error");
            }
        }
    }
}
