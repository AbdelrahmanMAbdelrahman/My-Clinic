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

namespace Clinc.Doctors
{
    public partial class FrmAddDoctor : Form
    {
        int _mode=0;
        int _personID;
        public FrmAddDoctor()
        {
            InitializeComponent();
        }
        public FrmAddDoctor(int mode,int PersonID)
        {
            _personID = PersonID;
            _mode = mode;

            //  ctrlAddUpdate1.LoadInfo(_mode);
            InitializeComponent();
            ctrlAddUpdate1.LoadInfo(_mode, _personID);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmAddDoctor_Load(object sender, EventArgs e)
        {
            if (_mode == 1)
            {
                ctrlAddUpdate1.LoadInfo(_mode, _personID);
                ClsDoctorBus doctor = ClsDoctorBus.GetDoctorby(_personID);
                TBSpecialization.Text = doctor.Specialization;
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            ctrlAddUpdate1.onAddPatient += Save;
        }

        private bool AddNewDoctor(ClsPersonBus person)
        {
            ClsDoctorBus doctor=    new ClsDoctorBus();
           // doctor.PersonID = person.PersonID;
            doctor.Name=person.Name;
            doctor.Address = person.Address;
            doctor.Email = person.Email;
            doctor.PhoneNumber = person.PhoneNumber;
            doctor.DateOfBirth = person.DateOfBirth;
            doctor.Gender = person.Gender;
            doctor.Specialization=TBSpecialization.Text;
            if (doctor.Save())
            {
                return true;
            }return false;
        }
        private bool UpdateDoctor(ClsPersonBus person)
        {
          //  ClsDoctorBus doctorBus = new ClsDoctorBus();
          //  doctorBus.mode = ClsDoctorBus.enMode.Update ;
          //  doctorBus.Name = person.Name;
          //  doctorBus.Address = person.Address;
          ////  person.mode = ClsPersonBus.enMode.update;
          //  doctorBus.Email = person.Email;
          //  doctorBus.PhoneNumber = person.PhoneNumber;
          //  doctorBus.Gender = person.Gender;
          //  doctorBus.DateOfBirth=person.DateOfBirth;
          //  doctorBus.Specialization = TBSpecialization.Text;
            //doctorBus.PersonID = person.PersonID;
           // ClsDoctorBus doctor=ClsDoctorBus.GetPersonBy(person.PersonID);
            return person.Save();
        }
        private void Save(ClsPersonBus person)
        {
            if (_mode == 0)
            {
                if (AddNewDoctor(person))
                {
                    MessageBox.Show("Doctor has been added successfully");
                    BtnSave.Enabled = false;
                }
                else
                {
                    MessageBox.Show("error");
                }
            }
            else
            {
                if (UpdateDoctor(person))
                {
                    MessageBox.Show("Doctor has been updated successfully");


                }
                else { MessageBox.Show("error"); }
            }
            }

        private void ctrlAddUpdate1_Load(object sender, EventArgs e)
        {

        }
    }
}
