namespace Course
{
    partial class Ref_ProceduresForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ref_ProceduresForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxId_Patient = new System.Windows.Forms.TextBox();
            this.dateTimePickerDate = new System.Windows.Forms.DateTimePicker();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.textBoxTherap = new System.Windows.Forms.TextBox();
            this.textBoxProced = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxTherapist = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBoxPatient = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBoxProced = new System.Windows.Forms.ComboBox();
            this.QuantityUpDown = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.QuantityUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AllowDrop = true;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Процедуры:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Количество процедур:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Id Пациента:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Терапевты:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 250);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Дата:";
            // 
            // textBoxId_Patient
            // 
            this.textBoxId_Patient.Location = new System.Drawing.Point(151, 138);
            this.textBoxId_Patient.Name = "textBoxId_Patient";
            this.textBoxId_Patient.Size = new System.Drawing.Size(226, 20);
            this.textBoxId_Patient.TabIndex = 7;
            // 
            // dateTimePickerDate
            // 
            this.dateTimePickerDate.Location = new System.Drawing.Point(151, 243);
            this.dateTimePickerDate.Name = "dateTimePickerDate";
            this.dateTimePickerDate.Size = new System.Drawing.Size(226, 20);
            this.dateTimePickerDate.TabIndex = 21;
            // 
            // btnOk
            // 
            this.btnOk.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnOk.Location = new System.Drawing.Point(151, 285);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 30);
            this.btnOk.TabIndex = 22;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCancel.Location = new System.Drawing.Point(302, 285);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 30);
            this.btnCancel.TabIndex = 23;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // textBoxTherap
            // 
            this.textBoxTherap.Location = new System.Drawing.Point(151, 207);
            this.textBoxTherap.Name = "textBoxTherap";
            this.textBoxTherap.Size = new System.Drawing.Size(226, 20);
            this.textBoxTherap.TabIndex = 24;
            // 
            // textBoxProced
            // 
            this.textBoxProced.Location = new System.Drawing.Point(151, 40);
            this.textBoxProced.Name = "textBoxProced";
            this.textBoxProced.Size = new System.Drawing.Size(226, 20);
            this.textBoxProced.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 214);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "Id Терапевта:";
            // 
            // comboBoxTherapist
            // 
            this.comboBoxTherapist.FormattingEnabled = true;
            this.comboBoxTherapist.Location = new System.Drawing.Point(151, 175);
            this.comboBoxTherapist.Name = "comboBoxTherapist";
            this.comboBoxTherapist.Size = new System.Drawing.Size(226, 21);
            this.comboBoxTherapist.TabIndex = 27;
            this.comboBoxTherapist.SelectedIndexChanged += new System.EventHandler(this.comboBoxTherapist_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 107);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 28;
            this.label7.Text = "Пациенты:";
            // 
            // comboBoxPatient
            // 
            this.comboBoxPatient.FormattingEnabled = true;
            this.comboBoxPatient.Location = new System.Drawing.Point(151, 99);
            this.comboBoxPatient.Name = "comboBoxPatient";
            this.comboBoxPatient.Size = new System.Drawing.Size(226, 21);
            this.comboBoxPatient.TabIndex = 29;
            this.comboBoxPatient.SelectedIndexChanged += new System.EventHandler(this.comboBoxPatient_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AllowDrop = true;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 47);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 13);
            this.label8.TabIndex = 30;
            this.label8.Text = "Id Процедуры:";
            // 
            // comboBoxProced
            // 
            this.comboBoxProced.FormattingEnabled = true;
            this.comboBoxProced.Location = new System.Drawing.Point(151, 9);
            this.comboBoxProced.Name = "comboBoxProced";
            this.comboBoxProced.Size = new System.Drawing.Size(226, 21);
            this.comboBoxProced.TabIndex = 31;
            this.comboBoxProced.SelectedIndexChanged += new System.EventHandler(this.comboBoxProced_SelectedIndexChanged);
            // 
            // QuantityUpDown
            // 
            this.QuantityUpDown.Location = new System.Drawing.Point(151, 66);
            this.QuantityUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.QuantityUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.QuantityUpDown.Name = "QuantityUpDown";
            this.QuantityUpDown.Size = new System.Drawing.Size(51, 20);
            this.QuantityUpDown.TabIndex = 32;
            this.QuantityUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Ref_ProceduresForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(421, 345);
            this.Controls.Add(this.QuantityUpDown);
            this.Controls.Add(this.comboBoxProced);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.comboBoxPatient);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboBoxTherapist);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxProced);
            this.Controls.Add(this.textBoxTherap);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.dateTimePickerDate);
            this.Controls.Add(this.textBoxId_Patient);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Ref_ProceduresForm";
            this.Text = "Направление на процедуры";
            ((System.ComponentModel.ISupportInitialize)(this.QuantityUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxId_Patient;
        private System.Windows.Forms.DateTimePicker dateTimePickerDate;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox textBoxTherap;
        private System.Windows.Forms.TextBox textBoxProced;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxTherapist;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBoxPatient;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBoxProced;
        private System.Windows.Forms.NumericUpDown QuantityUpDown;
    }
}