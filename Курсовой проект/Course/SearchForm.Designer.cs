namespace Course
{
    partial class SearchForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchForm));
            this.dataGridViewSearch = new System.Windows.Forms.DataGridView();
            this.checkBoxAnalyz = new System.Windows.Forms.CheckBox();
            this.checkBoxCard_num = new System.Windows.Forms.CheckBox();
            this.checkBoxAdress = new System.Windows.Forms.CheckBox();
            this.checkBoxSurname = new System.Windows.Forms.CheckBox();
            this.checkBoxSickData = new System.Windows.Forms.CheckBox();
            this.comboBoxSurname = new System.Windows.Forms.ComboBox();
            this.comboBoxAdress = new System.Windows.Forms.ComboBox();
            this.comboBoxCard_num = new System.Windows.Forms.ComboBox();
            this.comboBoxAnalyz = new System.Windows.Forms.ComboBox();
            this.dateTimePickeSick = new System.Windows.Forms.DateTimePicker();
            this.btnCancel = new System.Windows.Forms.Button();
            this.buttonOk = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewSearch
            // 
            this.dataGridViewSearch.BackgroundColor = System.Drawing.Color.Lavender;
            this.dataGridViewSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSearch.Location = new System.Drawing.Point(29, 12);
            this.dataGridViewSearch.Name = "dataGridViewSearch";
            this.dataGridViewSearch.Size = new System.Drawing.Size(552, 386);
            this.dataGridViewSearch.TabIndex = 1;
            // 
            // checkBoxAnalyz
            // 
            this.checkBoxAnalyz.AutoSize = true;
            this.checkBoxAnalyz.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxAnalyz.Location = new System.Drawing.Point(608, 257);
            this.checkBoxAnalyz.Name = "checkBoxAnalyz";
            this.checkBoxAnalyz.Size = new System.Drawing.Size(152, 20);
            this.checkBoxAnalyz.TabIndex = 29;
            this.checkBoxAnalyz.Text = "название анализы";
            this.checkBoxAnalyz.UseVisualStyleBackColor = true;
            this.checkBoxAnalyz.CheckedChanged += new System.EventHandler(this.checkBoxAnalyz_CheckedChanged);
            // 
            // checkBoxCard_num
            // 
            this.checkBoxCard_num.AutoSize = true;
            this.checkBoxCard_num.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxCard_num.Location = new System.Drawing.Point(608, 179);
            this.checkBoxCard_num.Name = "checkBoxCard_num";
            this.checkBoxCard_num.Size = new System.Drawing.Size(179, 20);
            this.checkBoxCard_num.TabIndex = 30;
            this.checkBoxCard_num.Text = "Номер карты пациента";
            this.checkBoxCard_num.UseVisualStyleBackColor = true;
            this.checkBoxCard_num.CheckedChanged += new System.EventHandler(this.checkBoxCard_num_CheckedChanged);
            // 
            // checkBoxAdress
            // 
            this.checkBoxAdress.AutoSize = true;
            this.checkBoxAdress.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxAdress.Location = new System.Drawing.Point(608, 104);
            this.checkBoxAdress.Name = "checkBoxAdress";
            this.checkBoxAdress.Size = new System.Drawing.Size(133, 20);
            this.checkBoxAdress.TabIndex = 31;
            this.checkBoxAdress.Text = "Адрес пациента";
            this.checkBoxAdress.UseVisualStyleBackColor = true;
            this.checkBoxAdress.CheckedChanged += new System.EventHandler(this.checkBoxAdress_CheckedChanged);
            // 
            // checkBoxSurname
            // 
            this.checkBoxSurname.AutoSize = true;
            this.checkBoxSurname.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxSurname.Location = new System.Drawing.Point(608, 34);
            this.checkBoxSurname.Name = "checkBoxSurname";
            this.checkBoxSurname.Size = new System.Drawing.Size(154, 20);
            this.checkBoxSurname.TabIndex = 32;
            this.checkBoxSurname.Text = "Фамилия пациента";
            this.checkBoxSurname.UseVisualStyleBackColor = true;
            this.checkBoxSurname.CheckedChanged += new System.EventHandler(this.checkBoxSurname_CheckedChanged);
            // 
            // checkBoxSickData
            // 
            this.checkBoxSickData.AutoSize = true;
            this.checkBoxSickData.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxSickData.Location = new System.Drawing.Point(608, 334);
            this.checkBoxSickData.Name = "checkBoxSickData";
            this.checkBoxSickData.Size = new System.Drawing.Size(147, 20);
            this.checkBoxSickData.TabIndex = 33;
            this.checkBoxSickData.Text = "Дата больничного";
            this.checkBoxSickData.UseVisualStyleBackColor = true;
            this.checkBoxSickData.CheckedChanged += new System.EventHandler(this.checkBoxSickData_CheckedChanged);
            // 
            // comboBoxSurname
            // 
            this.comboBoxSurname.FormattingEnabled = true;
            this.comboBoxSurname.Location = new System.Drawing.Point(608, 66);
            this.comboBoxSurname.Name = "comboBoxSurname";
            this.comboBoxSurname.Size = new System.Drawing.Size(202, 21);
            this.comboBoxSurname.TabIndex = 34;
            // 
            // comboBoxAdress
            // 
            this.comboBoxAdress.FormattingEnabled = true;
            this.comboBoxAdress.Location = new System.Drawing.Point(608, 137);
            this.comboBoxAdress.Name = "comboBoxAdress";
            this.comboBoxAdress.Size = new System.Drawing.Size(202, 21);
            this.comboBoxAdress.TabIndex = 35;
            // 
            // comboBoxCard_num
            // 
            this.comboBoxCard_num.FormattingEnabled = true;
            this.comboBoxCard_num.Location = new System.Drawing.Point(608, 214);
            this.comboBoxCard_num.Name = "comboBoxCard_num";
            this.comboBoxCard_num.Size = new System.Drawing.Size(202, 21);
            this.comboBoxCard_num.TabIndex = 36;
            // 
            // comboBoxAnalyz
            // 
            this.comboBoxAnalyz.FormattingEnabled = true;
            this.comboBoxAnalyz.Location = new System.Drawing.Point(608, 295);
            this.comboBoxAnalyz.Name = "comboBoxAnalyz";
            this.comboBoxAnalyz.Size = new System.Drawing.Size(202, 21);
            this.comboBoxAnalyz.TabIndex = 37;
            // 
            // dateTimePickeSick
            // 
            this.dateTimePickeSick.Location = new System.Drawing.Point(608, 369);
            this.dateTimePickeSick.Name = "dateTimePickeSick";
            this.dateTimePickeSick.Size = new System.Drawing.Size(202, 20);
            this.dateTimePickeSick.TabIndex = 38;
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCancel.Location = new System.Drawing.Point(467, 422);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(114, 30);
            this.btnCancel.TabIndex = 39;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // buttonOk
            // 
            this.buttonOk.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOk.Location = new System.Drawing.Point(38, 422);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(119, 30);
            this.buttonOk.TabIndex = 40;
            this.buttonOk.Text = "OK";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(828, 473);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.dateTimePickeSick);
            this.Controls.Add(this.comboBoxAnalyz);
            this.Controls.Add(this.comboBoxCard_num);
            this.Controls.Add(this.comboBoxAdress);
            this.Controls.Add(this.comboBoxSurname);
            this.Controls.Add(this.checkBoxSickData);
            this.Controls.Add(this.checkBoxSurname);
            this.Controls.Add(this.checkBoxAdress);
            this.Controls.Add(this.checkBoxCard_num);
            this.Controls.Add(this.checkBoxAnalyz);
            this.Controls.Add(this.dataGridViewSearch);
            this.Name = "SearchForm";
            this.Text = "Поиск пациентов";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSearch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewSearch;
        private System.Windows.Forms.CheckBox checkBoxAnalyz;
        private System.Windows.Forms.CheckBox checkBoxCard_num;
        private System.Windows.Forms.CheckBox checkBoxAdress;
        private System.Windows.Forms.CheckBox checkBoxSurname;
        private System.Windows.Forms.CheckBox checkBoxSickData;
        private System.Windows.Forms.ComboBox comboBoxSurname;
        private System.Windows.Forms.ComboBox comboBoxAdress;
        private System.Windows.Forms.ComboBox comboBoxCard_num;
        private System.Windows.Forms.ComboBox comboBoxAnalyz;
        private System.Windows.Forms.DateTimePicker dateTimePickeSick;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button buttonOk;
    }
}