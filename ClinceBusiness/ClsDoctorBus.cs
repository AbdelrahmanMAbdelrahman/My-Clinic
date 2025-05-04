using ClincData;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinceBusiness
{
    public class ClsDoctorBus:ClsPersonBus
    {
        public int PersonID { get; set; }
        public int DoctorID { get; set; }
        public string Specialization {  get; set; }
        public enum enMode { AddNew=0,Update=1}
        public enMode mode= enMode.AddNew;
        public ClsDoctorBus()
        {
            this.PersonID
                = 0;
            this.DoctorID = 0;
            this.Specialization = "";
            this.mode = enMode.AddNew;
        }
        public static DataTable GetAllDoctors()
        {
            return ClsDoctorData.GetAllDoctors();
        }
       private ClsDoctorBus(int PersonID,int DoctorID,string Specialization)
        {this.PersonID
                = PersonID;
            this.DoctorID = DoctorID;
            this.Specialization = Specialization;
            this.mode = enMode.Update;
            
        }
        private bool _AddNewDoctor( )
        {
            int DoctorID = ClsDoctorData.AddNewDoctor(base.PersonID, this.Specialization);
            return DoctorID != 0;
        }
        private bool Update()
        {
            return ClsDoctorData.UpdateDoctor(this.PersonID, this.Specialization);
        }
        public bool DeleteDoctor()
        {
            if (ClsPersonData.DeletePerson(this.PersonID))
            {
                return ClsDoctorData.DeleteDoctor(this.DoctorID);
            }
            else { return false; }
        }
        //public static ClsDoctorBus GetDoctorBy(int PersonID)
        //{
        //    if(ClsDoctorData.f)
        //}
        public static ClsDoctorBus GetDoctorby(int PersonID)
        {
            string Speicalization = "";
            int DoctorID = 0;
            if(ClsDoctorData.GetDoctorBy(PersonID,ref DoctorID,ref Speicalization))
            {
                return new ClsDoctorBus(PersonID, DoctorID, Speicalization);
            }else { return null; }
        }
        public static bool DeleteDoctor(int DoctorID,int PersonID)
        {
            if (ClsPersonBus.DeletePerson(PersonID))
            {
                return ClsDoctorData.DeleteDoctor(DoctorID);
            }return false;

        }

        public bool Save()
        {
            switch (mode)
            {
                case enMode.AddNew:
                    if (base.Save())
                    {
                        if (_AddNewDoctor())
                        {
                            mode = enMode.Update;
                            return true;
                        }return false;
                    }
                    else { return false; }
                case enMode.Update:
                    if (base.Save())
                    {
                        return this.Update();
                    }
                    return false;
            }return false;
        }
    }
}
