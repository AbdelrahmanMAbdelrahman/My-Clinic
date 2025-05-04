using ClincData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ClinceBusiness
{
    public class ClsPersonBus
    {public enum enMode { addNew=0,update=1}
        public enMode mode  { get; set; }
        public string Name { get; set; }   
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string Email {  get; set; }
        public int PersonID { get; set; }   
        public DateTime DateOfBirth { get; set; }
        public bool Gender { get; set; }
        public ClsPersonBus()
        {
            this.mode
                = enMode.addNew;
            this.Address = string.Empty;
            this.PhoneNumber = string.Empty;
            this.DateOfBirth = DateTime.MinValue;
                this.Name
                = string.Empty;
            this.Email = string.Empty;
            this.Gender = false;
            this.PersonID = 0;
        }
          ClsPersonBus(int PersonID,string Name,string Address,string Email,bool Gender,DateTime DateOfBirht,string PhoneNumber)
        {
            this.mode = enMode.update;
            this.Name = Name;
            this.Address = Address;
            this.DateOfBirth =DateOfBirht;
            this.Gender = Gender;
            this.Email=Email;
            this.PersonID = PersonID;
            this.PhoneNumber= PhoneNumber;
        }
        private bool _AddNewPerson()
        {
            this.PersonID = ClsPersonData.AddNewPerson(this.Name, this.Email, this.PhoneNumber,
                this.Address, this.Gender, this.DateOfBirth);
            return this.PersonID != 0;
        }
        private bool _UpdatePerson() {
            return ClsPersonData.UpdatePerson(this.PersonID, this.Name, this.Email, this.PhoneNumber,
                this.Gender, this.DateOfBirth, this.Address);
        }
        public bool Save()
        {
            switch (mode)
            {
                case enMode.update:return _UpdatePerson();
                case enMode.addNew:
                    if (_AddNewPerson())
                    {
                        mode = enMode.update;
                        return true;
                    }else { return false; }
            }return false;
        }
        public static bool DeletePerson(int PersonID)
        {
            return ClsPersonData.DeletePerson(PersonID);
        }
        public static ClsPersonBus GetPersonBy(int PersonID)
        { 
            string Name = "";
            string Email = "";
            string Phone= "";
            string Address= "";
            DateTime DateOfBirth = DateTime.Now;
            bool Gender = false;
            if (ClsPersonData.GetPersonBy(PersonID, ref Name, ref Email, ref Address, ref Phone, ref Gender, ref DateOfBirth))
            {
                return new ClsPersonBus(PersonID, Name,Address,Email,Gender,DateOfBirth,Phone);
            }
            else
            {
                return null;
            }
        }
    }
}
