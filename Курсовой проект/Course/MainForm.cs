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
    public partial class MainForm : Form
    {

         Registration_patientsEntities2 bd = null;
        //Registration_patientsEntities bd = null;
        Card_Patients patient = null;       
        Sick_leaves sick_leave = null;      
        Ref_Procedures ref_procedure = null;        
        Ref_Analyzes ref_analyze = null;      
       

        public MainForm()
        {
            InitializeComponent();
            //bd = new Registration_patientsEntities();
            bd = new Registration_patientsEntities2();

        }

        

        private void добавитьПациентаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bd.Card_Patients.Load();
            patient = new Card_Patients();
            PatientsForm f = new PatientsForm(patient);
            if (f.ShowDialog() == DialogResult.OK)
            {
                Card_Patients tmp = bd.Card_Patients.Local.Where(x => x.Number_Card == patient.Number_Card && x.Surname == patient.Surname && x.Name == patient.Name &&
                x.Patronymic == patient.Patronymic && x.Passport == patient.Passport && x.Adress == patient.Adress && x.Phone_number == patient.Phone_number &&
                x.Date_birth == patient.Date_birth && x.Id_Therapist == patient.Id_Therapist && x.IsMoved == patient.IsMoved).FirstOrDefault();
                if (tmp == null)
                {
                    bd.Card_Patients.Add(patient);
                    bd.SaveChanges();
                    MessageBox.Show("Данные успешно добавлены!");
                }
                else
                {
                    MessageBox.Show("Не удалось добавить данные!");
                }
            }
        }

        private void редактироватьПациентаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int index = dataGridViewMain.SelectedRows[0].Index;
            int Id = 0;
            bool converted = Int32.TryParse(dataGridViewMain[0, index].Value.ToString(),out Id);
            if (converted == false)
                return;
            patient = bd.Card_Patients.Find(Id);
            PatientsForm f = new PatientsForm(patient);
            if (f.ShowDialog() == DialogResult.OK)
            {
                bd.SaveChanges();
                dataGridViewMain.Update();
                dataGridViewMain.Refresh();
                MessageBox.Show("Данные отредактированные!");
            }
            else
            {
                MessageBox.Show("Не удалось отредактировать данные!");
            }
                                 

        }

        private void удалитьПациентаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridViewMain.SelectedRows.Count == 1)
            {                
                int index = dataGridViewMain.SelectedRows[0].Index;
                int Id = 0;
                bool converted = Int32.TryParse(dataGridViewMain[0, index].Value.ToString(), out Id);
                if (converted == false)
                    return;
                patient = bd.Card_Patients.Find(Id);
                bd.Card_Patients.Remove(patient);
                bd.SaveChanges();
                dataGridViewMain.Update();
                dataGridViewMain.Refresh();
                MessageBox.Show("Обьект успешно удален!");
            }
            else
            {
                MessageBox.Show("Не удалось удалить данные!");
            }
        }

            private void списокВсехПациентовToolStripMenuItem_Click(object sender, EventArgs e)
        {            
            bd.Card_Patients.Load();
            dataGridViewMain.DataSource = bd.Card_Patients.Local.ToBindingList();
            dataGridViewMain.Columns["Therapists"].Visible = false;
        }

        private void списокВыбывшихПациентовToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //bd.Archives.Load();
            bd.Card_Patients.Load();
            var query = bd.Card_Patients.Local.Where(x => x.IsMoved == true).ToList();
            //dataGridViewMain.DataSource = bd.Archives.Local.ToBindingList();
            dataGridViewMain.DataSource = null;
            dataGridViewMain.DataSource = query;
            dataGridViewMain.Columns["Therapists"].Visible = false;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            patient = new Card_Patients();
            sick_leave = new Sick_leaves();
            ref_analyze = new Ref_Analyzes();
            SearchForm f = new SearchForm(patient, sick_leave, ref_analyze);
            f.ShowDialog();
        }

        private void добавитьБольничныйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bd.Sick_leaves.Load();
            sick_leave=new Sick_leaves();
            Sick_LeavesForm l = new Sick_LeavesForm(sick_leave);
            
            if (l.ShowDialog() == DialogResult.OK)
            {
                Sick_leaves tmp = bd.Sick_leaves.Local.Where(x => x.Id_Patient == sick_leave.Id_Patient && x.PlaceOfWork == sick_leave.PlaceOfWork &&
                  x.Diagnosis == sick_leave.Diagnosis && x.IsAmbulatory == sick_leave.IsAmbulatory && x.IsStationary == sick_leave.IsStationary &&
                  x.Id_Therapist == sick_leave.Id_Therapist && x.Opening_date == sick_leave.Opening_date && x.Closing_date == sick_leave.Closing_date).FirstOrDefault();
                if (tmp == null)
                {
                    bd.Sick_leaves.Add(sick_leave);
                    bd.SaveChanges();
                    MessageBox.Show("Больничный успешно добавлен!");
                }
                else
                {
                    MessageBox.Show("Не удалось добавить больничный!");
                }
            }

        }

       

        private void удалитьБольничныйToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (dataGridViewMain.SelectedRows.Count == 1)
            {
                
                int index = dataGridViewMain.SelectedRows[0].Index;
                int Id = 0;
                bool converted = Int32.TryParse(dataGridViewMain[0, index].Value.ToString(), out Id);
                if (converted == false)
                    return;
                sick_leave = bd.Sick_leaves.Find(Id);
                bd.Sick_leaves.Remove(sick_leave);
                bd.SaveChanges();
                dataGridViewMain.Update();
                dataGridViewMain.Refresh();
                MessageBox.Show("Обьект удален!");
            }
            else
            {
                MessageBox.Show("Не удалось удалить данные!");
            }

        }

        private void показатьВсеБольничныеToolStripMenuItem_Click(object sender, EventArgs e)
        {          
            bd.Sick_leaves.Load();
            dataGridViewMain.DataSource = bd.Sick_leaves.Local.ToBindingList();
            dataGridViewMain.Columns["Card_Patients"].Visible = false;
            dataGridViewMain.Columns["Therapists"].Visible = false;
        }

        private void добавитьПроцедуруToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            bd.Ref_Procedures.Load();
            ref_procedure = new Ref_Procedures();
            Ref_ProceduresForm pr = new Ref_ProceduresForm(ref_procedure);
            if (pr.ShowDialog() == DialogResult.OK)
            {
                Ref_Procedures tmp = bd.Ref_Procedures.Local.Where(x => x.Id_proced == ref_procedure.Id_proced &&
                x.Count_proced == ref_procedure.Count_proced &&x.Id_Patient == ref_procedure.Id_Patient && 
                x.Id_Therapist == ref_procedure.Id_Therapist&& x.Date_proc == ref_procedure.Date_proc).FirstOrDefault();
                if (tmp == null)
                {
                    bd.Ref_Procedures.Add(ref_procedure);
                    bd.SaveChanges();
                    MessageBox.Show("Процедура успешно добавлена!");
                }
                else
                {
                    MessageBox.Show("Не удалось добавить процедуру!");
                }
            }
        }

       

        private void удалитьПроцедуруToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (dataGridViewMain.SelectedRows.Count == 1)
            {
                
                int index = dataGridViewMain.SelectedRows[0].Index;
                int Id = 0;
                bool converted = Int32.TryParse(dataGridViewMain[0, index].Value.ToString(), out Id);
                if (converted == false)
                    return;
                ref_procedure = bd.Ref_Procedures.Find(Id);               
                bd.Ref_Procedures.Remove(ref_procedure);
                bd.SaveChanges();
                dataGridViewMain.Update();
                dataGridViewMain.Refresh();
                MessageBox.Show("Обьект удален!");
            }
            else
            {
                MessageBox.Show("Не удалось удалить данные!");
            }
        }

        private void показатьВсеПроцедурыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bd.Ref_Procedures.Load();
            dataGridViewMain.DataSource = bd.Ref_Procedures.Local.ToBindingList();
            dataGridViewMain.Columns["Procedures"].Visible = false;
            dataGridViewMain.Columns["Card_Patients"].Visible = false;
            dataGridViewMain.Columns["Therapists"].Visible = false;
        }

        private void добавитьАнализыToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            bd.Ref_Analyzes.Load();
            ref_analyze = new Ref_Analyzes();
            Ref_AnalyzesForm an = new Ref_AnalyzesForm(ref_analyze);           
            if (an.ShowDialog() == DialogResult.OK)
            {
                Ref_Analyzes tmp = bd.Ref_Analyzes.Local.Where(x => x.Id_Patient == ref_analyze.Id_Patient &&
                x.Id_Therapist == ref_analyze.Id_Therapist&&x.Id_Analyze == ref_analyze.Id_Analyze 
                 &&x.Date_analyze == ref_analyze.Date_analyze).FirstOrDefault();
                if (tmp == null)
                {
                    bd.Ref_Analyzes.Add(ref_analyze);
                    bd.SaveChanges();
                    MessageBox.Show("Анализ успешно добавлен!");
                }
                else
                {
                    MessageBox.Show("Не удалось добавить данные!");
                }
            }
        }

       

        private void удалитАнализыToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (dataGridViewMain.SelectedRows.Count == 1)
            {
                //bd = new Registration_patientsEntities2();
                int index = dataGridViewMain.SelectedRows[0].Index;
                int Id = 0;
                bool converted = Int32.TryParse(dataGridViewMain[0, index].Value.ToString(), out Id);
                if (converted == false)
                    return;
                ref_analyze = bd.Ref_Analyzes.Find(Id);
                bd.Ref_Analyzes.Remove(ref_analyze);
                bd.SaveChanges();
                dataGridViewMain.Update();
                dataGridViewMain.Refresh();
                MessageBox.Show("Обьект удален!");
            }
            else
            {
                MessageBox.Show("Не удалось удалить данные!");
            }

        }

        private void показатьВсеНапрАнализовToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bd.Ref_Analyzes.Load();
            dataGridViewMain.DataSource = bd.Ref_Analyzes.Local.ToBindingList();           
            dataGridViewMain.Columns["Card_Patients"].Visible = false;
            dataGridViewMain.Columns["Therapists"].Visible = false;
            dataGridViewMain.Columns["Analyzes"].Visible = false;
            dataGridViewMain.Columns["Result_Analyzes"].Visible = false;
        }

        private void показатьВсеАнализыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bd.Result_Analyzes.Load();
            dataGridViewMain.DataSource = bd.Result_Analyzes.Local.ToBindingList();
            dataGridViewMain.Columns["Ref_Analyzes"].Visible = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
