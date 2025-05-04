using ClincData;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ClinceBusiness
{
  public  class ClsAppoinetmentBus
    {
        public enum EnMode { AddNew=0,Upate=1}
        public EnMode Mode { get; set; }
        public int AppointmentID { get; set; }
        public byte AppoinmentStatus { get; set; }
        public DateTime AppointmentDate { get; set; }
        public int DoctorID { get; set; }
        public int PatientID { get; set; }
        public int MedicalRecordID { get;set; }
        public int PaymentID { get; set; }
        public ClsDoctorBus Doctor { get; set; }
        public ClsPatientBus Patient { get; set; }
        public ClsMedicalRecordBus MedicalRecord { get; set; }
        public ClsPaymentBus Payment { get; set; }
        public ClsAppoinetmentBus()
        {
            this.Mode = EnMode.AddNew;
            this.AppointmentID = 0;
            this.AppoinmentStatus = 0;
            this.AppointmentDate = DateTime.Now;
            this.DoctorID = 0;
            this.PatientID = 0;
            this.MedicalRecordID = 0;
            this.PaymentID = 0;
            Doctor = new ClsDoctorBus();
            Patient = new ClsPatientBus();
            MedicalRecord = new ClsMedicalRecordBus();
            Payment = new ClsPaymentBus();
        }
        private ClsAppoinetmentBus(int AppointmentID,byte AppointmentStatus,DateTime AppointmentDate,
            int DoctorID,int PatientID,int MedicalRecordID,int PaymentID)
            
        {
            this.Mode = EnMode.Upate;
            this.AppointmentID = AppointmentID;
            this.AppoinmentStatus = AppoinmentStatus;
            this.AppointmentDate = AppointmentDate;
            this.DoctorID = DoctorID;
            this.PatientID = PatientID;
            this.MedicalRecordID = MedicalRecordID;
            this.PaymentID = PaymentID;
            this.Doctor = ClsDoctorBus.GetDoctorby(DoctorID);
            this.Payment = ClsPaymentBus.GetPaymentBy(PaymentID);
          //  this.Patient = ClsPatientBus.GetPersonBy() must get Patient by Patient ID


        }
        private bool _AddNewAppointment()
        {
          //  int PatientID = this.PatientID;
          //  int DoctorID = this.DoctorID;
            int MedicalRecordID = ClsMedicalRecordData.AddNewMedicalRecord(this.MedicalRecord.VisiteDescription,
                this.MedicalRecord.AdditionalNotes,this.MedicalRecord.Diagnosis);

            int PaymentID = ClsPaymentData.AddNewPayment(this.Payment.PaymentMethod,this.Payment.AmountPaid,this.Payment.AddtionalNotes,
                this.Payment.PaymentDate);

            int AppointmentID = ClsAppointmentData.AddNewAppointment(this.PatientID, this.DoctorID,
                PaymentID, AppointmentDate, AppoinmentStatus,
                MedicalRecordID);
            return AppointmentID > 0;
        }
        public bool Save()
        {
            switch (Mode)
            {
                case EnMode.AddNew:
                    if (_AddNewAppointment())
                    {
                        Mode = EnMode.Upate;
                        return true;
                    }else
                    {
                        return false;
                    }
            }return false;


        }
    }
}
