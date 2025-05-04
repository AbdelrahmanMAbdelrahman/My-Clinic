using ClincData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinceBusiness
{
 public   class ClsMedicalRecordBus
    {
        public enum EnMode { AddNew = 0, Update = 1 }
        public EnMode mode { get; set; }
        public string Diagnosis { get; set; }
        public string AdditionalNotes { get; set; }
        public string VisiteDescription { get; set; }
        public int MedicalRecordID { get; set; }
        public ClsMedicalRecordBus()
        {
            this.mode = EnMode.AddNew;
            this.VisiteDescription = AdditionalNotes;
            this.MedicalRecordID = MedicalRecordID;
            this.Diagnosis = Diagnosis;
            this.AdditionalNotes = AdditionalNotes;
        }
        private ClsMedicalRecordBus(int MedicalRecordID, string AdditionalNotes, string Diagnosis, string VisitDescription)

        {
            this.mode = EnMode.Update;
            this.AdditionalNotes = AdditionalNotes;
            this.Diagnosis = Diagnosis;
            this.MedicalRecordID = MedicalRecordID;
            this.VisiteDescription = VisiteDescription;

        }
        private bool _AddNewMedicalRecord()
        {
            this.MedicalRecordID = ClsMedicalRecordData.AddNewMedicalRecord(this.VisiteDescription, this.AdditionalNotes, this.Diagnosis);
            return this.MedicalRecordID > 0;
        }
        private bool _UpdateMedicalRecord()
        {
            return ClsMedicalRecordData.UpdateMedicalRecord(this.VisiteDescription,
                this.Diagnosis, this.AdditionalNotes, this.MedicalRecordID);
        }
        public bool Save()
        {
            switch (mode)
            {
                case EnMode.AddNew:
                    if (_AddNewMedicalRecord())
                    {
                        mode = EnMode.Update;
                        return true;
                    }
                    else { return false; }
                case EnMode.Update:
                    return
                        _UpdateMedicalRecord();

            }
            return false;
        }
        public static ClsMedicalRecordBus GetMedicalRecordBy(int MedicalRecordID)
        {
            string VisitDescription = "";
            string Diagnosis = "";
            string AdditionalNotes = "";
            if (ClsMedicalRecordData.GetMedicalReocrdBy(MedicalRecordID, ref Diagnosis, ref AdditionalNotes, ref VisitDescription))
            {
                return new ClsMedicalRecordBus(MedicalRecordID, AdditionalNotes, Diagnosis, VisitDescription);
            }
            else { return null; }
        }
        public static bool DeleteMedicalRecord(int MedicalRecordID)
        {
            return ClsMedicalRecordData.DeletedMedicalRecord(MedicalRecordID);
        }
    }
}
