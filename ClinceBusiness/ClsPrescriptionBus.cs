using ClincData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinceBusiness
{
  public  class ClsPrescriptionBus
    {
        public int PrescriptionID { get; set; }
        public int MedicalRecordID { get; set; }
        public string Dosage { get; set; }
        public int Frequency { get; set; }
        public string Instruction { get; set; }
        public string MedicationName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public enum EnMode { AddNew=0,Update=1}
        public EnMode Mode { get; set; }
        public ClsPrescriptionBus()
        {
            this.StartDate = DateTime.Now;
            this.EndDate = DateTime.Now;
            this.MedicalRecordID = 0;
            this.MedicationName = "";
            this.Frequency = 0;
            this.Dosage = "";
            this.Instruction = "";
            this.Mode = EnMode.AddNew;
            this.PrescriptionID = 0;
        }
        private ClsPrescriptionBus(int PrescriptionID, int MedicalRecordID, int Frequency, string Instruction, string MedicationName, string
            Dosage, DateTime StartDate,DateTime EndDate)
        {
            this.EndDate = EndDate;
            this.StartDate= StartDate;
            this.Instruction = Instruction;
            this.Frequency = Frequency;
            this.MedicalRecordID = MedicalRecordID;
            this.MedicationName = MedicationName;
            this.Dosage = Dosage;
            this.Mode = EnMode.Update;
            
        }
        public static bool DeletePrescription(int PrescriptionID)
        {
            return ClsPrescriptionData.DeletePrescription(PrescriptionID);
        }
        private bool _AddNewPrescription()
        {
            this.PrescriptionID = ClsPrescriptionData.AddNewPrescription(this.MedicalRecordID,
                this.Frequency, this.StartDate, this.EndDate, this.Dosage, this.Instruction, this.MedicationName);
            return this.PrescriptionID > 0;
        }
        private bool _UpdatePrescription()
        {
            return ClsPrescriptionData.UpdatePrescription(this.MedicalRecordID, this.Frequency, this.StartDate, this.EndDate,
                this.Dosage, this.Instruction, this.MedicationName, this.PrescriptionID);
        }
        public bool Save()
        {
            switch (Mode)
            {
                case EnMode.AddNew:
                    if (_AddNewPrescription())
                    {
                        Mode = EnMode.Update;
                        return true;
                    }
                    else { return false; }
                case EnMode.Update:return _UpdatePrescription();
            }return false;
        }
        public static ClsPrescriptionBus GetPrescriptionBy(int PrescriptionID)
        {
            DateTime StartDate = DateTime.Now;
            DateTime EndDate = DateTime.Now;
            string Dosage = "";
            string Instruction = "";
            string MedicationName = "";
            int MedicalRecordID = 0;
            int Frequency = 0;
            if (ClsPrescriptionData.GetPrescriptionBy(ref MedicalRecordID, ref Frequency, ref StartDate, ref EndDate, 
                ref Dosage, ref Instruction
                , ref MedicationName,  PrescriptionID)) {
                return new ClsPrescriptionBus(PrescriptionID, MedicalRecordID, Frequency, Instruction, MedicationName, 
                    Dosage, StartDate, EndDate);
            }
            else
            {
                return null;
            }
        } public static ClsPrescriptionBus GetPrescriptionByMedicalRecord(int MedicalRecordID)
        {
            DateTime StartDate = DateTime.Now;
            DateTime EndDate = DateTime.Now;
            string Dosage = "";
            string Instruction = "";
            string MedicationName = "";
            int PrescriptionID = 0;
            int Frequency = 0;
            if (ClsPrescriptionData.GetPrescriptionBy( MedicalRecordID, ref Frequency, ref StartDate, ref EndDate, 
                ref Dosage, ref Instruction
                , ref MedicationName, ref  PrescriptionID)) {
                return new ClsPrescriptionBus(PrescriptionID, MedicalRecordID, Frequency, Instruction, MedicationName, 
                    Dosage, StartDate, EndDate);
            }
            else
            {
                return null;
            }
        }
    }
}
