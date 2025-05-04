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

namespace Clinc.Doctors
{
    public partial class FrmListDoctors : Form
    {
        public FrmListDoctors()
        {
            InitializeComponent();
        }

        private void BtnAddPatient_Click(object sender, EventArgs e)
        {
            FrmAddDoctor frmAddDoctor = new FrmAddDoctor();
            frmAddDoctor.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Patients_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            contextMenuStrip1.Show();
        }

        private void FrmListDoctors_Load(object sender, EventArgs e)
        {
            Doctors.DataSource = ClsDoctorBus.GetAllDoctors();

        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAddDoctor frmAddDoctor = new FrmAddDoctor(1,Convert.ToInt16(Doctors.CurrentRow.Cells[1].Value));
            frmAddDoctor.ShowDialog();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ClsDoctorBus.DeleteDoctor(Convert.ToInt32(Doctors.CurrentRow.Cells[0].Value),
                Convert.ToInt32(Doctors.CurrentRow.Cells[1].Value))){
                MessageBox.Show("Doctor has been deleted successfully");

            }else { MessageBox.Show("error"); }
        }

        private void allDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmFindPatient frmFindPatient = new FrmFindPatient(Convert.ToInt32(Doctors.CurrentRow.Cells[1].Value));
            frmFindPatient.ShowDialog();
        }
    }
}
