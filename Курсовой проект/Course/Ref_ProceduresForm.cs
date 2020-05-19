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
    public partial class Ref_ProceduresForm : Form
    {

        Ref_Procedures ref_proc = null;
        //Registration_patientsEntities bd = null;
        Registration_patientsEntities2 bd = null;
        public Ref_ProceduresForm(Ref_Procedures p)
        {
            InitializeComponent();
            this.ref_proc = p;
            bd = new Registration_patientsEntities2();
            //bd = new Registration_patientsEntities();
            comboBoxProced.DataSource = null;
            bd.Procedures.Load();
            comboBoxProced.DataSource = bd.Procedures.Local.ToList();
            comboBoxProced.DisplayMember = "Name_proced";
            comboBoxProced.ValueMember = "Id";            
            
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
            
            dateTimePickerDate.Value = DateTime.Now.Date;           
           
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            try
            {
                ref_proc.Id_proced = Int32.Parse(textBoxProced.Text);
                ref_proc.Count_proced = (int)QuantityUpDown.Value;
                ref_proc.Id_Patient = Int32.Parse(textBoxId_Patient.Text);
                ref_proc.Id_Therapist = Int32.Parse(textBoxTherap.Text);
                ref_proc.Date_proc = dateTimePickerDate.Value.Date;
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

        private void comboBoxProced_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxProced.SelectedIndex != -1)
            {
                int id = Convert.ToInt32(comboBoxProced.SelectedValue);
                ref_proc.Id_proced = id;
                textBoxProced.Text = id.ToString();               
            }
            else
            {
                MessageBox.Show("Выберите процедуру!");
            }

        }

        private void comboBoxPatient_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxPatient.SelectedIndex != -1)
            {
                int id = Convert.ToInt32(comboBoxPatient.SelectedValue);
                ref_proc.Id_Patient = id;
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
                ref_proc.Id_Therapist = id;
                textBoxTherap.Text = id.ToString();
            }
            else
            {
                MessageBox.Show("Выберите терапевта!");
            }
        }
    }
}
