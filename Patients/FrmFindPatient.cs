using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clinc.Patients
{
    public partial class FrmFindPatient : Form
    { int _PersonID;
        public FrmFindPatient(int personID)
        {
            _PersonID = personID;
            InitializeComponent();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmFindPatient_Load(object sender, EventArgs e)
        {
             
            ctrlFindPerson1.LoadData(_PersonID);

        }
    }
}
