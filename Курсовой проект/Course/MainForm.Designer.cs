namespace Course
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.dataGridViewMain = new System.Windows.Forms.DataGridView();
            this.CMPatients = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.пациентыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьПациентаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.редактироватьПациентаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьПациентаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.списокВсехПациентовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.списокВыбывшихПациентовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.больничныеЛистыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.показатьВсеБольничныеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.направленияНаПроцедурыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.показатьВсеПроцедурыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.анализыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.показатьВсеРезультатыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.показатьВсеАнализыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMain)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewMain
            // 
            this.dataGridViewMain.BackgroundColor = System.Drawing.Color.LightBlue;
            this.dataGridViewMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMain.Location = new System.Drawing.Point(0, 27);
            this.dataGridViewMain.Name = "dataGridViewMain";
            this.dataGridViewMain.Size = new System.Drawing.Size(439, 420);
            this.dataGridViewMain.TabIndex = 0;
            // 
            // CMPatients
            // 
            this.CMPatients.Name = "CMPatients";
            this.CMPatients.Size = new System.Drawing.Size(61, 4);
            this.CMPatients.Text = "Пациенты";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.LightBlue;
            this.menuStrip1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.пациентыToolStripMenuItem,
            this.больничныеЛистыToolStripMenuItem,
            this.направленияНаПроцедурыToolStripMenuItem,
            this.анализыToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(760, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // пациентыToolStripMenuItem
            // 
            this.пациентыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьПациентаToolStripMenuItem,
            this.редактироватьПациентаToolStripMenuItem,
            this.удалитьПациентаToolStripMenuItem,
            this.списокВсехПациентовToolStripMenuItem,
            this.списокВыбывшихПациентовToolStripMenuItem});
            this.пациентыToolStripMenuItem.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.пациентыToolStripMenuItem.Name = "пациентыToolStripMenuItem";
            this.пациентыToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.пациентыToolStripMenuItem.Text = "Пациенты";
            // 
            // добавитьПациентаToolStripMenuItem
            // 
            this.добавитьПациентаToolStripMenuItem.Name = "добавитьПациентаToolStripMenuItem";
            this.добавитьПациентаToolStripMenuItem.Size = new System.Drawing.Size(273, 22);
            this.добавитьПациентаToolStripMenuItem.Text = "Добавить пациента";
            this.добавитьПациентаToolStripMenuItem.Click += new System.EventHandler(this.добавитьПациентаToolStripMenuItem_Click);
            // 
            // редактироватьПациентаToolStripMenuItem
            // 
            this.редактироватьПациентаToolStripMenuItem.Name = "редактироватьПациентаToolStripMenuItem";
            this.редактироватьПациентаToolStripMenuItem.Size = new System.Drawing.Size(273, 22);
            this.редактироватьПациентаToolStripMenuItem.Text = "Редактировать пациента";
            this.редактироватьПациентаToolStripMenuItem.Click += new System.EventHandler(this.редактироватьПациентаToolStripMenuItem_Click);
            // 
            // удалитьПациентаToolStripMenuItem
            // 
            this.удалитьПациентаToolStripMenuItem.Name = "удалитьПациентаToolStripMenuItem";
            this.удалитьПациентаToolStripMenuItem.Size = new System.Drawing.Size(273, 22);
            this.удалитьПациентаToolStripMenuItem.Text = "Удалить пациента";
            this.удалитьПациентаToolStripMenuItem.Click += new System.EventHandler(this.удалитьПациентаToolStripMenuItem_Click);
            // 
            // списокВсехПациентовToolStripMenuItem
            // 
            this.списокВсехПациентовToolStripMenuItem.Name = "списокВсехПациентовToolStripMenuItem";
            this.списокВсехПациентовToolStripMenuItem.Size = new System.Drawing.Size(273, 22);
            this.списокВсехПациентовToolStripMenuItem.Text = "Список всех пациентов";
            this.списокВсехПациентовToolStripMenuItem.Click += new System.EventHandler(this.списокВсехПациентовToolStripMenuItem_Click);
            // 
            // списокВыбывшихПациентовToolStripMenuItem
            // 
            this.списокВыбывшихПациентовToolStripMenuItem.Name = "списокВыбывшихПациентовToolStripMenuItem";
            this.списокВыбывшихПациентовToolStripMenuItem.Size = new System.Drawing.Size(273, 22);
            this.списокВыбывшихПациентовToolStripMenuItem.Text = "Список выбывших пациентов";
            this.списокВыбывшихПациентовToolStripMenuItem.Click += new System.EventHandler(this.списокВыбывшихПациентовToolStripMenuItem_Click);
            // 
            // больничныеЛистыToolStripMenuItem
            // 
            this.больничныеЛистыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьToolStripMenuItem,
            this.удалитьToolStripMenuItem,
            this.показатьВсеБольничныеToolStripMenuItem});
            this.больничныеЛистыToolStripMenuItem.Name = "больничныеЛистыToolStripMenuItem";
            this.больничныеЛистыToolStripMenuItem.Size = new System.Drawing.Size(148, 20);
            this.больничныеЛистыToolStripMenuItem.Text = "Больничные листы";
            // 
            // добавитьToolStripMenuItem
            // 
            this.добавитьToolStripMenuItem.Name = "добавитьToolStripMenuItem";
            this.добавитьToolStripMenuItem.Size = new System.Drawing.Size(251, 22);
            this.добавитьToolStripMenuItem.Text = "Добавить больничный";
            this.добавитьToolStripMenuItem.Click += new System.EventHandler(this.добавитьБольничныйToolStripMenuItem_Click);
            // 
            // удалитьToolStripMenuItem
            // 
            this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(251, 22);
            this.удалитьToolStripMenuItem.Text = "Удалить больничный";
            this.удалитьToolStripMenuItem.Click += new System.EventHandler(this.удалитьБольничныйToolStripMenuItem_Click);
            // 
            // показатьВсеБольничныеToolStripMenuItem
            // 
            this.показатьВсеБольничныеToolStripMenuItem.Name = "показатьВсеБольничныеToolStripMenuItem";
            this.показатьВсеБольничныеToolStripMenuItem.Size = new System.Drawing.Size(251, 22);
            this.показатьВсеБольничныеToolStripMenuItem.Text = "Показать все больничные";
            this.показатьВсеБольничныеToolStripMenuItem.Click += new System.EventHandler(this.показатьВсеБольничныеToolStripMenuItem_Click);
            // 
            // направленияНаПроцедурыToolStripMenuItem
            // 
            this.направленияНаПроцедурыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьToolStripMenuItem1,
            this.удалитьToolStripMenuItem1,
            this.показатьВсеПроцедурыToolStripMenuItem});
            this.направленияНаПроцедурыToolStripMenuItem.Name = "направленияНаПроцедурыToolStripMenuItem";
            this.направленияНаПроцедурыToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.направленияНаПроцедурыToolStripMenuItem.Text = "Процедуры";
            // 
            // добавитьToolStripMenuItem1
            // 
            this.добавитьToolStripMenuItem1.Name = "добавитьToolStripMenuItem1";
            this.добавитьToolStripMenuItem1.Size = new System.Drawing.Size(242, 22);
            this.добавитьToolStripMenuItem1.Text = "Добавить процедуры";
            this.добавитьToolStripMenuItem1.Click += new System.EventHandler(this.добавитьПроцедуруToolStripMenuItem1_Click);
            // 
            // удалитьToolStripMenuItem1
            // 
            this.удалитьToolStripMenuItem1.Name = "удалитьToolStripMenuItem1";
            this.удалитьToolStripMenuItem1.Size = new System.Drawing.Size(242, 22);
            this.удалитьToolStripMenuItem1.Text = "Удалить процедуры";
            this.удалитьToolStripMenuItem1.Click += new System.EventHandler(this.удалитьПроцедуруToolStripMenuItem1_Click);
            // 
            // показатьВсеПроцедурыToolStripMenuItem
            // 
            this.показатьВсеПроцедурыToolStripMenuItem.Name = "показатьВсеПроцедурыToolStripMenuItem";
            this.показатьВсеПроцедурыToolStripMenuItem.Size = new System.Drawing.Size(242, 22);
            this.показатьВсеПроцедурыToolStripMenuItem.Text = "Показать все процедуры";
            this.показатьВсеПроцедурыToolStripMenuItem.Click += new System.EventHandler(this.показатьВсеПроцедурыToolStripMenuItem_Click);
            // 
            // анализыToolStripMenuItem
            // 
            this.анализыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьToolStripMenuItem2,
            this.удалитьToolStripMenuItem2,
            this.показатьВсеРезультатыToolStripMenuItem,
            this.показатьВсеАнализыToolStripMenuItem});
            this.анализыToolStripMenuItem.Name = "анализыToolStripMenuItem";
            this.анализыToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.анализыToolStripMenuItem.Text = "Анализы";
            // 
            // добавитьToolStripMenuItem2
            // 
            this.добавитьToolStripMenuItem2.Name = "добавитьToolStripMenuItem2";
            this.добавитьToolStripMenuItem2.Size = new System.Drawing.Size(256, 22);
            this.добавитьToolStripMenuItem2.Text = "Добавить анализы";
            this.добавитьToolStripMenuItem2.Click += new System.EventHandler(this.добавитьАнализыToolStripMenuItem2_Click);
            // 
            // удалитьToolStripMenuItem2
            // 
            this.удалитьToolStripMenuItem2.Name = "удалитьToolStripMenuItem2";
            this.удалитьToolStripMenuItem2.Size = new System.Drawing.Size(256, 22);
            this.удалитьToolStripMenuItem2.Text = "Удалить анализы";
            this.удалитьToolStripMenuItem2.Click += new System.EventHandler(this.удалитАнализыToolStripMenuItem2_Click);
            // 
            // показатьВсеРезультатыToolStripMenuItem
            // 
            this.показатьВсеРезультатыToolStripMenuItem.Name = "показатьВсеРезультатыToolStripMenuItem";
            this.показатьВсеРезультатыToolStripMenuItem.Size = new System.Drawing.Size(256, 22);
            this.показатьВсеРезультатыToolStripMenuItem.Text = "Показать все направления";
            this.показатьВсеРезультатыToolStripMenuItem.Click += new System.EventHandler(this.показатьВсеНапрАнализовToolStripMenuItem_Click);
            // 
            // показатьВсеАнализыToolStripMenuItem
            // 
            this.показатьВсеАнализыToolStripMenuItem.Name = "показатьВсеАнализыToolStripMenuItem";
            this.показатьВсеАнализыToolStripMenuItem.Size = new System.Drawing.Size(256, 22);
            this.показатьВсеАнализыToolStripMenuItem.Text = "Показать все результаты";
            this.показатьВсеАнализыToolStripMenuItem.Click += new System.EventHandler(this.показатьВсеАнализыToolStripMenuItem_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnSearch.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSearch.ForeColor = System.Drawing.Color.Black;
            this.btnSearch.Location = new System.Drawing.Point(22, 463);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(117, 30);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Поиск";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnCancel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCancel.ForeColor = System.Drawing.Color.Black;
            this.btnCancel.Location = new System.Drawing.Point(562, 463);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(107, 30);
            this.btnCancel.TabIndex = 40;
            this.btnCancel.Text = "Выход";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(760, 519);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.dataGridViewMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Учета пациентов ";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMain)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewMain;
        private System.Windows.Forms.ContextMenuStrip CMPatients;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem пациентыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьПациентаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem редактироватьПациентаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьПациентаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem списокВсехПациентовToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem списокВыбывшихПациентовToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem больничныеЛистыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem направленияНаПроцедурыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem анализыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem2;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ToolStripMenuItem показатьВсеБольничныеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem показатьВсеПроцедурыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem показатьВсеРезультатыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem показатьВсеАнализыToolStripMenuItem;
        private System.Windows.Forms.Button btnCancel;
    }
}