using Clinc.Appointment;
using Clinc.Patients;
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
    public partial class FrmListPatient : Form
    {
        public FrmListPatient()
        {
            InitializeComponent();
        }

        private void FrmListPatient_Load(object sender, EventArgs e)
        {
            Patients.DataSource=ClsPatientBus.GetAllPatients();
        }

        private void BtnAddPatient_Click(object sender, EventArgs e)
        {
            FrmAddUpdatePatient patient = new FrmAddUpdatePatient();
            patient.ShowDialog();
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
        FrmAddUpdatePatient patient = new 
                FrmAddUpdatePatient(Convert.ToInt32(Patients.CurrentRow.Cells[0].Value),1);
            patient.ShowDialog();
        }

        private void Patients_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            contextMenuStrip1.Show();
        }
       private bool DeletePatient()
        {
            return ClsPatientBus.DeletePatient(Convert.ToInt32(Patients.CurrentRow.Cells[1].Value));
        }
        private bool DeletePerson()
        {
            if (DeletePatient()) {
                return ClsPersonBus.DeletePerson(Convert.ToInt32(Patients.CurrentRow.Cells[0].Value));
            }
            else { return false; }
        }
        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DeletePerson()) {
                MessageBox.Show("Patient has been deleted Successfully");
            }
            else
            {
                MessageBox.Show("error");
            }
        }

        private void allDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmFindPatient Patient = 
                new FrmFindPatient(Convert.ToInt32(Patients.CurrentRow.Cells[0].Value));
            Patient.ShowDialog();
        }

        private void takeAppointmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAppointments frmAppointments = new FrmAppointments(Convert.ToInt16(Patients.CurrentRow.Cells[1].Value));
            frmAppointments.Show();
        }
    }
}
