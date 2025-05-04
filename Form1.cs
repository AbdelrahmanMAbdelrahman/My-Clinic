using Clinc.Doctors;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void PatientBtn_Click(object sender, EventArgs e)
        {
            FrmListPatient frmListPatient = new FrmListPatient();
            frmListPatient.ShowDialog();
        }

        private void BtnDoctor_Click(object sender, EventArgs e)
        {
            FrmListDoctors frmListDoctors = new FrmListDoctors();
            frmListDoctors.ShowDialog();
        }
    }
}
