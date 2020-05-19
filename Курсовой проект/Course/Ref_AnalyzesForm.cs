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
    public partial class Ref_AnalyzesForm : Form
    {
        Registration_patientsEntities2 bd = null;
        //Registration_patientsEntities bd=null;
        Ref_Analyzes ref_analyze = null;
        public Ref_AnalyzesForm(Ref_Analyzes an)
        {
            InitializeComponent();
            this.ref_analyze = an;
            bd = new Registration_patientsEntities2();
            //bd = new Registration_patientsEntities();
            comboBoxPatient.DataSource = null;
            bd.Card_Patients.Load();
            comboBoxPatient.DataSource = bd.Card_Patients.Local.ToList();
            comboBoxPatient.DisplayMember = "Surname";
            comboBoxPatient.ValueMember = "Id";
            
            comboBoxTherapist.DataSource = null;
            bd.Therapists.Load();
            comboBoxTherapist.DataSource = bd.Therapists.Local.ToList();
            comboBoxTherapist.DisplayMember = "Surname";
            comboBoxTherapist.ValueMember = "Id";

            comboBoxAnalyz.DataSource = null;
            bd.Analyzes.Load();
            comboBoxAnalyz.DataSource = bd.Analyzes.Local.ToList();
            comboBoxAnalyz.DisplayMember = "Name_analyze";
            comboBoxAnalyz.ValueMember = "Id";          

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            try
            {
                ref_analyze.Id_Patient = Int32.Parse(textBoxId_Patient.Text);
                ref_analyze.Id_Therapist = Int32.Parse(textBoxTherap.Text);
                ref_analyze.Id_Analyze = Int32.Parse(textBoxAnalyz.Text);
                ref_analyze.Date_analyze = dateTimePickeDay.Value.Date;
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
            if (comboBoxPatient.SelectedIndex !=-1)
            {
                int id = Convert.ToInt32(comboBoxPatient.SelectedValue);
                ref_analyze.Id_Patient = id;
                textBoxId_Patient.Text = id.ToString();               
            }
            else
            {
                MessageBox.Show("Выберите пациента!");
            }
        }

        private void comboBoxTherapist_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxTherapist.SelectedIndex !=-1)
            {
                int id = Convert.ToInt32(comboBoxTherapist.SelectedValue);
                ref_analyze.Id_Therapist = id;
                textBoxTherap.Text = id.ToString();               
            }
            else
            {
                MessageBox.Show("Выберите терапевта!");
            }
        }

        private void comboBoxAnalyz_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxAnalyz.SelectedIndex != -1)
            {
                int id = Convert.ToInt32(comboBoxAnalyz.SelectedValue);
                ref_analyze.Id_Analyze = id;
                textBoxAnalyz.Text = id.ToString();       
                
            }
            else
            {
                MessageBox.Show("Выберите анализ!");
            }
        }
    }
}
