using ClinceBusiness;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clinc
{
    public partial class CtrlAddUpdate : UserControl
    {
       ClsPersonBus _Person;
        int _PersonID;
        public enum enMode { AddNew=0,update=1}
        public enMode mode = enMode.AddNew;
        public delegate void OnAddPatient(ClsPersonBus person);
        public event OnAddPatient onAddPatient;
        public void AddPatient(ClsPersonBus person)
        {
            //_Patient = new ClsPatientBus();
            if (person != null&&onAddPatient!=null)
            {
                onAddPatient(person);
            }
        }
        public CtrlAddUpdate()
        {
            InitializeComponent();
        }
public void LoadInfo(int NewMode,int PersonID)
        {
            _PersonID = PersonID;
       mode=(enMode)NewMode;
            _Person=ClsPersonBus.GetPersonBy(PersonID);
            TBName.Text = _Person.Name;
            TBAddress.Text = _Person.Address;
            TbEmail.Text = _Person.Email;
            TBPhone.Text = _Person.PhoneNumber;
            DTP.Value = _Person.DateOfBirth;
            RDFemal.Checked=_Person.Gender?false:true;
            RDMale.Checked=_Person.Gender?true:false;

        }
        private void CtrlAddUpdate_Load(object sender, EventArgs e)
        {
            if ((enMode)mode == enMode.update) {
                LblMain.Text = "Form Update Person";
            }
        }

        private void BtnDone_Click(object sender, EventArgs e)
        {
            if (mode == enMode.update)
            {
                _Person = ClsPersonBus.GetPersonBy(_PersonID);
            }
            else
            {
                _Person = new ClsPatientBus();
            }
            _Person.Name=TBName.Text;
            _Person.Address=TBAddress.Text;
            _Person.Email=TbEmail.Text;
            _Person.PhoneNumber=TBPhone.Text;
            _Person.DateOfBirth = DTP.Value;
            _Person.Gender = RDMale.Checked ? true : false;  
            AddPatient( _Person );
        }
    }
}
