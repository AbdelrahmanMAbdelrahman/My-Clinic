using ClincData;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinceBusiness
{
    public class ClsPatientBus:ClsPersonBus
    {public enum enMode { addNew=0,update=1}
        public enMode Mode=enMode.addNew;
        public int PersonID {  get; set; }
        public int PatienID {  get; set; }
        public ClsPatientBus()
        {
            this.PersonID
                = 0;
            this.PatienID = 0;
            this.Mode = enMode.addNew;
        }
        private ClsPatientBus(int PersonID,int PatientID,string Name,string Address,string Email,DateTime DateOfBirth,
            bool Gender,string Phone)
        {this.PersonID
                = PersonID;
            this.PatienID = PatientID;
            this.Mode = enMode.update;
            this.Address = Address;
            this.Email = Email;
            this.DateOfBirth = DateOfBirth;
            this.Gender = Gender;
            this.Name = Name;
            this.PhoneNumber = Phone;
            
        }
        public static DataTable GetAllPatients()
        {
           
            return ClsPatientData.GetAllPatients();
        }
        public bool AddNewPatient()
        {
            base.PersonID = ClsPersonData.AddNewPerson(this.Name,this.Email,this.PhoneNumber,
                this.Address,this.Gender,this.DateOfBirth);
            this.PatienID=ClsPatientData.AddNewPatient(base.PersonID);
            return this.PatienID > 0;
        }
        public static ClsPatientBus FindPatientBy(string Name)
        {
            string Address = "";
            string PhoneNumber = "";
            string Email = "";
            int PersonID = 0;
            int PatientID = 0;
            bool Gender = false;
            DateTime DateOfBirth = DateTime.Now;
            if( ClsPatientData.FindPatientBy(ref PatientID, Name, ref Email, ref PhoneNumber, ref Address,
                ref DateOfBirth, ref PersonID, ref Gender))
            {
                return new ClsPatientBus(PersonID, PatientID, Name, Address, Email, DateOfBirth, Gender, PhoneNumber);
            }
            else { return null; }
        }  
        
        public static ClsPatientBus FindPatientBy(int PatientID)
        {
            string Address = "";
            string PhoneNumber = "";
            string Email = "";
            int PersonID = 0;
            string Name = "";
            bool Gender = false;
            DateTime DateOfBirth = DateTime.Now;
            if (ClsPatientData.FindPatientBy( PatientID,ref Name, ref Email, ref PhoneNumber, ref Address,
                ref DateOfBirth, ref PersonID, ref Gender))
            {
                return new ClsPatientBus(PersonID, PatientID, Name, Address, Email, DateOfBirth, Gender, PhoneNumber);
            }
            else { return null; }
        }
      public static bool DeletePatient(int PatientID)
        {
            return ClsPatientData.DeletePatient(PatientID);

        }
    }
}
