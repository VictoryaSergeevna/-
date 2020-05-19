using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
namespace Course
{
    public partial class Sick_LeavesForm : Form
    {
        Sick_leaves sick_leave = null;
        Registration_patientsEntities2 bd = null;
        //Registration_patientsEntities bd = null;
        public Sick_LeavesForm(Sick_leaves s)
        {
            InitializeComponent();
            this.sick_leave = s;
            bd = new Registration_patientsEntities2();
            //bd = new Registration_patientsEntities();            
            comboBoxPatient.DataSource = null;
            bd.Card_Patients.Load();
            comboBoxPatient.DataSource = bd.Card_Patients.Local.ToList();
            comboBoxPatient.DisplayMember = "Surname";
            comboBoxPatient.ValueMember = "Id";
          
            textBoxPlace.Text = sick_leave.PlaceOfWork;
            textBoxDiagnos.Text = sick_leave.Diagnosis;
            bd.Therapists.Load();
            comboBoxTherapist.DataSource = bd.Therapists.Local.ToList();
            comboBoxTherapist.DisplayMember = "Surname";
            comboBoxTherapist.ValueMember = "Id";
           
            dateTimePickerOpen.Value = DateTime.Now.Date;           
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            try
            {
                sick_leave.Id_Patient = Int32.Parse(textBoxId_Patient.Text);
                sick_leave.PlaceOfWork = textBoxPlace.Text;
                sick_leave.Diagnosis = textBoxDiagnos.Text;
                sick_leave.Id_Therapist = Int32.Parse(textBoxId_Therapist.Text);
                sick_leave.Opening_date = dateTimePickerOpen.Value.Date;
                sick_leave.Closing_date = dateTimePickerClose.Value.Date;
                if (radioButtonAmbul.Checked)
                {
                    sick_leave.IsAmbulatory = true;
                }
                else
                {

                    sick_leave.IsAmbulatory = false;
                }



                if (radioButtonStac.Checked)
                {
                    sick_leave.IsStationary = true;
                }
                else
                {
                    sick_leave.IsStationary = false;
                }


                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void comboBoxPatient_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxPatient.SelectedIndex != -1)
            {
                int id = Convert.ToInt32(comboBoxPatient.SelectedValue);
                sick_leave.Id_Patient = id;
                textBoxId_Patient.Text = id.ToString();               
            }

            else
            {
                MessageBox.Show("Выберите пациента!");
            }
        }

        private void comboBoxTherapist_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxTherapist.SelectedIndex != -1)
            {
                int id = Convert.ToInt32(comboBoxTherapist.SelectedValue);
                sick_leave.Id_Therapist = id;               
                textBoxId_Therapist.Text = id.ToString();             
            }

            else
            {
                MessageBox.Show("Выберите терапевта!");
            }

        }
    }
}
