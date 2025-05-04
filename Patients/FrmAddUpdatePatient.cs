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

namespace Clinc
{
    public partial class FrmAddUpdatePatient : Form
    {
        string Message = "Added";
        int _mode;
        int _PersonID;
        public FrmAddUpdatePatient()
        {
            InitializeComponent();
        }
        public FrmAddUpdatePatient(int PersonID,int mode)
        {
            InitializeComponent();
            _PersonID = PersonID;
            _mode = mode;
            Message = "Updated";
            ctrlAddUpdate1.LoadInfo(_mode, PersonID);

        }

        private void ctrlAddUpdate1_Load(object sender, EventArgs e)
        {
            ctrlAddUpdate1.LoadInfo(_mode, _PersonID);
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            ctrlAddUpdate1.onAddPatient += Save;
        }
        private void AddNewPatient(ClsPersonBus person)
        {
            ClsPatientBus Patient = new ClsPatientBus();
            Patient.PersonID = person.PersonID;
            Patient.Name = person.Name;
            Patient.Address = person.Address;
            Patient.Email = person.Email;
            Patient.PhoneNumber = person.PhoneNumber;
            Patient.mode = person.mode;
            Patient.DateOfBirth = person.DateOfBirth;
            if (Patient.AddNewPatient())
            { 
                MessageBox.Show($"Patient has been Added successfully");
                _mode = 1;
            }
            else
            {
                MessageBox.Show("error");
            }

        }
        public void UpdatePatient(ClsPersonBus person)
        {
            //ClsPatientBus patientBus = ClsPatientBus.FindPatientBy(_patientId);
            person.mode = ClsPersonBus.enMode.update;
            //    ;
            //person.Name = patient.Name;
            //person.Address = patient.Address;
            //person.Email = patient.Email;
            //person.DateOfBirth = patient.DateOfBirth;
            //person.Gender = patient.Gender;
            //person.PhoneNumber = patient.PhoneNumber;
            person.PersonID = _PersonID;
            
            if (person.Save())
            {
                MessageBox.Show($"Patient has been Updated successfully");

            }
            else
            {
                MessageBox.Show("error");
            }
        }
        private void Save(ClsPersonBus person)
        {
            switch (_mode) {
                case 0:AddNewPatient(person); break;
                    case 1:UpdatePatient(person);break;
            }
                
        }

        private void ctrlAddUpdate1_Load_1(object sender, EventArgs e)
        {

        }

        private void FrmAddUpdatePatient_Load(object sender, EventArgs e)
        {

        }
    }
}
