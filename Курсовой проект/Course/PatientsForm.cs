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
using System.IO;
namespace Course
{
    public partial class PatientsForm : Form
    {
        Registration_patientsEntities2 bd = null;
        //Registration_patientsEntities bd = null;
        Card_Patients patient = null;
        public PatientsForm(Card_Patients p)
        {
            InitializeComponent();
            this.patient = p;
            bd = new Registration_patientsEntities2();
            //bd = new Registration_patientsEntities();
            textBoxNumCard.Text = patient.Number_Card.ToString();
            textBoxSurname.Text = patient.Surname;
            textBoxName.Text = patient.Name;
            textBoxPatronymic.Text = patient.Patronymic;
            textBoxPassropt.Text = patient.Passport;
            textBoxAdress.Text = patient.Adress;
            textBoxPhone.Text = patient.Phone_number;
            dateTimePickerBirthday.Value = DateTime.Now.Date;
            comboBoxTherapist.DataSource = null;
            bd.Therapists.Load();
            comboBoxTherapist.DataSource = bd.Therapists.Local.ToList();
            comboBoxTherapist.DisplayMember = "Surname";
            comboBoxTherapist.ValueMember = "Id";            
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            try
            {
                patient.Number_Card = Int32.Parse(textBoxNumCard.Text);
                patient.Surname = textBoxSurname.Text;
                patient.Name = textBoxName.Text;
                patient.Patronymic = textBoxPatronymic.Text;
                patient.Passport = textBoxPassropt.Text;
                patient.Adress = textBoxAdress.Text;
                patient.Phone_number = textBoxPhone.Text;
                patient.Date_birth = dateTimePickerBirthday.Value.Date;
                patient.Id_Therapist = Int32.Parse(textBoxId_Therap.Text);
                if (radioButtonMoved.Checked)
                {
                    patient.IsMoved = true;
                }
                else
                    patient.IsMoved = false;
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

        private void comboBoxTherapist_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxTherapist.SelectedIndex != -1)
            {
                int id = Convert.ToInt32(comboBoxTherapist.SelectedValue);
                patient.Id_Therapist = id;
                textBoxId_Therap.Text = id.ToString();
            }
            else
            {
                MessageBox.Show("Выберите терапевта!");
            }
        }

        private void BTNOpen_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    string fileName = ofd.FileName;
                    Image im = Image.FromFile(fileName);
                    Bitmap btm = new Bitmap(im, pictureBoxPatient.ClientSize);
                    pictureBoxPatient.Image = im;
                    FileInfo fi = new FileInfo(fileName);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
            }
        }
       
    }
}
