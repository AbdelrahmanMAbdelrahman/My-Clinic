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
    public partial class CtrlFindPerson : UserControl
    {
        public CtrlFindPerson()
        {
            InitializeComponent();
        }

        private void CtrlFindPerson_Load(object sender, EventArgs e)
        {

        }
        public void LoadData(int   PersonID)
        {
            ClsPersonBus person = ClsPersonBus.GetPersonBy(PersonID);
            if (person != null) { 
            LblName.Text = person.Name;
                LblAddress.Text = person.Address;
                LblEmail.Text = person.Email;
                LblPersonID.Text = person.PersonID.ToString();
                LblPhone.Text = person.PhoneNumber;
                LblDOB.Text=person.DateOfBirth.ToString();
                LblGender.Text = person.Gender ? "Male" : "Femal";
            }
            else
            {
                MessageBox.Show("Person not found");
                return;
            }
        }
    }
}
