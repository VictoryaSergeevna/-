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
    public partial class SearchForm : Form
    {
        Card_Patients patient = null;
        Sick_leaves sick_leave = null;
        Ref_Analyzes analyze = null;
        Registration_patientsEntities2 bd = null;
        //Registration_patientsEntities bd = null;
        public SearchForm(Card_Patients p, Sick_leaves s, Ref_Analyzes a)
        {
            InitializeComponent();
            this.patient = p;
            this.sick_leave = s;
            this.analyze = a;
            bd = new Registration_patientsEntities2();
            comboBoxSurname.DataSource = null;
            comboBoxAdress.DataSource = null;
            comboBoxCard_num.DataSource = null;
            comboBoxAnalyz.DataSource = null;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void checkBoxSurname_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSurname.Checked)
            {
                comboBoxSurname.Enabled = true;
                comboBoxAdress.Enabled = false;
                comboBoxCard_num.Enabled = false;
                comboBoxAnalyz.Enabled = false;
                dateTimePickeSick.Enabled = false;
                bd.Card_Patients.Load();
                comboBoxSurname.DataSource = bd.Card_Patients.Local.ToList();
                comboBoxSurname.DisplayMember = "Surname";
                comboBoxSurname.ValueMember = "Id";
            }
            else
            {
                MessageBox.Show("Выберите поле поиска!");
            }
        }

        private void checkBoxAdress_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxAdress.Checked)
            {
                comboBoxAdress.Enabled = true;
                comboBoxSurname.Enabled = false;                
                comboBoxCard_num.Enabled = false;
                comboBoxAnalyz.Enabled = false;
                dateTimePickeSick.Enabled = false;
                bd.Card_Patients.Load();
                comboBoxAdress.DataSource = bd.Card_Patients.Local.ToList();
                comboBoxAdress.DisplayMember = "Adress";
                comboBoxAdress.ValueMember = "Id";
            }
            else
            {
                MessageBox.Show("Выберите поле поиска!");
            }
        }

        private void checkBoxCard_num_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxCard_num.Checked)
            {
                comboBoxCard_num.Enabled = true;
                comboBoxSurname.Enabled = false;
                comboBoxAdress.Enabled = false;
                comboBoxAnalyz.Enabled = false;
                dateTimePickeSick.Enabled = false;
                bd.Card_Patients.Load();
                comboBoxCard_num.DataSource = bd.Card_Patients.Local.ToList();
                comboBoxCard_num.DisplayMember = "Number_Card";
                comboBoxCard_num.ValueMember = "Id";
            }
            else
            {
                MessageBox.Show("Выберите поле поиска!");
            }
        }

        private void checkBoxAnalyz_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxAnalyz.Checked)
            {
                comboBoxAnalyz.Enabled = true;
                comboBoxSurname.Enabled = false;
                comboBoxAdress.Enabled = false;
                comboBoxCard_num.Enabled = false;               
                dateTimePickeSick.Enabled = false;
                bd.Analyzes.Load();
                comboBoxAnalyz.DataSource = bd.Analyzes.Local.ToList();
                comboBoxAnalyz.DisplayMember = "Name_analyze";
                comboBoxAnalyz.ValueMember = "Id";
            }
            else
            {
                MessageBox.Show("Выберите поле поиска!");
            }
        }

        private void checkBoxSickData_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSickData.Checked)
            {
                dateTimePickeSick.Enabled = true;
                comboBoxSurname.Enabled = false;
                comboBoxAdress.Enabled = false;
                comboBoxCard_num.Enabled = false;
                comboBoxAnalyz.Enabled = false;
                dateTimePickeSick.Value = DateTime.Now.Date; 
            }
            else
            {
                MessageBox.Show("Выберите поле поиска!");
            }
        }
        private void SearchSurname()
        {
            if (comboBoxSurname.SelectedIndex != -1)
            {
                bd = new Registration_patientsEntities2();
                bd.Card_Patients.Load();
                int id = Convert.ToInt32(comboBoxSurname.SelectedValue);
                var query = bd.Card_Patients.Local.Where(x => x.Id == id).ToList();                
                dataGridViewSearch.DataSource = null;
                dataGridViewSearch.DataSource = query;                 
            }
            else
            {
                MessageBox.Show("Выберите фамилию!");
            }

        }

        private void SearchAdress()
        {
            if (comboBoxAdress.SelectedIndex != -1)
            {
                bd = new Registration_patientsEntities2();
                bd.Card_Patients.Load();
                int id = Convert.ToInt32(comboBoxAdress.SelectedValue);
                var query = bd.Card_Patients.Local.Where(x => x.Id == id).ToList();
                dataGridViewSearch.DataSource = null;
                dataGridViewSearch.DataSource = query;
                dataGridViewSearch.Columns["Therapists"].Visible = false;
            }
            else
            {
                MessageBox.Show("Выберите адрес!");
            }

        }

        private void SearchCard_number()
        {
            if (comboBoxCard_num.SelectedIndex != -1)
            {
                bd = new Registration_patientsEntities2();
                bd.Card_Patients.Load();
                int id = Convert.ToInt32(comboBoxCard_num.SelectedValue);
                var query = bd.Card_Patients.Local.Where(x => x.Id == id).ToList();
                dataGridViewSearch.DataSource = null;
                dataGridViewSearch.DataSource = query;
                dataGridViewSearch.Columns["Therapists"].Visible = false;
            }
            else
            {
                MessageBox.Show("Выберите номер карты пациента!");
            }
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            if (checkBoxSurname.Checked)
            {
                SearchSurname();
            }
            if (checkBoxAdress.Checked)
            {
                SearchAdress();
            }
            if (checkBoxCard_num.Checked)
            {
                SearchCard_number();
            }

            if (checkBoxAnalyz.Checked)
            {
                SearchAnalyze();
            }
            if (checkBoxSickData.Checked)
            {
                SearchSickData();
            }

        }
        private void SearchAnalyze()
        {
            if (comboBoxAnalyz.SelectedIndex != -1)
            {
                bd = new Registration_patientsEntities2();
                int id = Convert.ToInt32(comboBoxAnalyz.SelectedValue);               
                var query = (from res_an in bd.Result_Analyzes
                             join ref_an in bd.Ref_Analyzes on res_an.Id_ref_Analyzes equals ref_an.Id
                             join an in bd.Analyzes on ref_an.Id_Analyze equals an.Id
                             join p in bd.Card_Patients on ref_an.Id_Patient equals p.Id
                             join th in bd.Therapists on ref_an.Id_Therapist equals th.Id
                             where ref_an.Id_Analyze == id
                             select new
                             {
                                 FullName_Patient = p.Surname + " " + p.Name + " " + p.Patronymic,
                                 Description_Analyze = res_an.Description,
                                 FullName_Doctor = th.Surname + " " + th.Name + " " + th.Patronymic,
                                 DateOfTest = res_an.Date_res_analyze
                             }).ToList();

                dataGridViewSearch.DataSource = null;
                dataGridViewSearch.Update();               
                dataGridViewSearch.DataSource = query;              
            }
            else
            {
                MessageBox.Show("Выберите анализ!");
            }
        }
        private void SearchSickData()
        {
            try
            {
                bd = new Registration_patientsEntities2();
                bd.Sick_leaves.Load();
                var query = bd.Sick_leaves.Local.Where(x => x.Opening_date == dateTimePickeSick.Value.Date).ToList();
                dataGridViewSearch.DataSource = null;
                dataGridViewSearch.DataSource = query;
                dataGridViewSearch.Columns["Card_Patients"].Visible = false;
                dataGridViewSearch.Columns["Therapists"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
            }

        }

    }
}
