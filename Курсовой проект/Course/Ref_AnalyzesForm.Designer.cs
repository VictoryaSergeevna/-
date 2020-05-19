namespace Course
{
    partial class Ref_AnalyzesForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ref_AnalyzesForm));
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePickeDay = new System.Windows.Forms.DateTimePicker();
            this.textBoxAnalyz = new System.Windows.Forms.TextBox();
            this.comboBoxAnalyz = new System.Windows.Forms.ComboBox();
            this.textBoxTherap = new System.Windows.Forms.TextBox();
            this.comboBoxTherapist = new System.Windows.Forms.ComboBox();
            this.textBoxId_Patient = new System.Windows.Forms.TextBox();
            this.comboBoxPatient = new System.Windows.Forms.ComboBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 29;
            this.label7.Text = "Пациенты:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 30;
            this.label3.Text = "Id Пациента:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 31;
            this.label4.Text = "Терапевты:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 126);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 32;
            this.label6.Text = "Id Терапевта:";
            // 
            // label1
            // 
            this.label1.AllowDrop = true;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 33;
            this.label1.Text = "Анализы:";
            // 
            // label8
            // 
            this.label8.AllowDrop = true;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(25, 201);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 13);
            this.label8.TabIndex = 34;
            this.label8.Text = "Id Анализа:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 246);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 35;
            this.label5.Text = "Дата:";
            // 
            // dateTimePickeDay
            // 
            this.dateTimePickeDay.Location = new System.Drawing.Point(118, 239);
            this.dateTimePickeDay.Name = "dateTimePickeDay";
            this.dateTimePickeDay.Size = new System.Drawing.Size(226, 20);
            this.dateTimePickeDay.TabIndex = 36;
            // 
            // textBoxAnalyz
            // 
            this.textBoxAnalyz.Location = new System.Drawing.Point(118, 194);
            this.textBoxAnalyz.Name = "textBoxAnalyz";
            this.textBoxAnalyz.Size = new System.Drawing.Size(226, 20);
            this.textBoxAnalyz.TabIndex = 37;
            // 
            // comboBoxAnalyz
            // 
            this.comboBoxAnalyz.FormattingEnabled = true;
            this.comboBoxAnalyz.Location = new System.Drawing.Point(118, 151);
            this.comboBoxAnalyz.Name = "comboBoxAnalyz";
            this.comboBoxAnalyz.Size = new System.Drawing.Size(226, 21);
            this.comboBoxAnalyz.TabIndex = 38;
            this.comboBoxAnalyz.SelectedIndexChanged += new System.EventHandler(this.comboBoxAnalyz_SelectedIndexChanged);
            // 
            // textBoxTherap
            // 
            this.textBoxTherap.Location = new System.Drawing.Point(118, 119);
            this.textBoxTherap.Name = "textBoxTherap";
            this.textBoxTherap.Size = new System.Drawing.Size(226, 20);
            this.textBoxTherap.TabIndex = 39;
            // 
            // comboBoxTherapist
            // 
            this.comboBoxTherapist.FormattingEnabled = true;
            this.comboBoxTherapist.Location = new System.Drawing.Point(118, 84);
            this.comboBoxTherapist.Name = "comboBoxTherapist";
            this.comboBoxTherapist.Size = new System.Drawing.Size(226, 21);
            this.comboBoxTherapist.TabIndex = 40;
            this.comboBoxTherapist.SelectedIndexChanged += new System.EventHandler(this.comboBoxTherapist_SelectedIndexChanged);
            // 
            // textBoxId_Patient
            // 
            this.textBoxId_Patient.Location = new System.Drawing.Point(118, 51);
            this.textBoxId_Patient.Name = "textBoxId_Patient";
            this.textBoxId_Patient.Size = new System.Drawing.Size(226, 20);
            this.textBoxId_Patient.TabIndex = 41;
            // 
            // comboBoxPatient
            // 
            this.comboBoxPatient.FormattingEnabled = true;
            this.comboBoxPatient.Location = new System.Drawing.Point(118, 20);
            this.comboBoxPatient.Name = "comboBoxPatient";
            this.comboBoxPatient.Size = new System.Drawing.Size(226, 21);
            this.comboBoxPatient.TabIndex = 42;
            this.comboBoxPatient.SelectedIndexChanged += new System.EventHandler(this.comboBoxPatient_SelectedIndexChanged);
            // 
            // btnOk
            // 
            this.btnOk.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnOk.Location = new System.Drawing.Point(63, 293);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 30);
            this.btnOk.TabIndex = 43;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCancel.Location = new System.Drawing.Point(269, 293);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 30);
            this.btnCancel.TabIndex = 44;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // Ref_AnalyzesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(370, 351);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.comboBoxPatient);
            this.Controls.Add(this.textBoxId_Patient);
            this.Controls.Add(this.comboBoxTherapist);
            this.Controls.Add(this.textBoxTherap);
            this.Controls.Add(this.comboBoxAnalyz);
            this.Controls.Add(this.textBoxAnalyz);
            this.Controls.Add(this.dateTimePickeDay);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label7);
            this.Name = "Ref_AnalyzesForm";
            this.Text = "Направление на анализы";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePickeDay;
        private System.Windows.Forms.TextBox textBoxAnalyz;
        private System.Windows.Forms.ComboBox comboBoxAnalyz;
        private System.Windows.Forms.TextBox textBoxTherap;
        private System.Windows.Forms.ComboBox comboBoxTherapist;
        private System.Windows.Forms.TextBox textBoxId_Patient;
        private System.Windows.Forms.ComboBox comboBoxPatient;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
    }
}