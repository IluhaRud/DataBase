namespace DatatBase
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.DataGrid = new System.Windows.Forms.DataGridView();
            this.ColumnID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnAge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDepartament = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSalary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnProjects = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreateNewDB = new System.Windows.Forms.Button();
            this.SaveInXMLButton = new System.Windows.Forms.Button();
            this.SaveInJSONbutton = new System.Windows.Forms.Button();
            this.labelTitle = new System.Windows.Forms.Label();
            this.LoadXMLButton = new System.Windows.Forms.Button();
            this.ClearGridButton = new System.Windows.Forms.Button();
            this.LoadFromJsonButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGrid
            // 
            this.DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnID,
            this.ColumnName,
            this.ColumnLastName,
            this.ColumnAge,
            this.ColumnDepartament,
            this.ColumnSalary,
            this.ColumnProjects});
            this.DataGrid.Location = new System.Drawing.Point(61, 68);
            this.DataGrid.Name = "DataGrid";
            this.DataGrid.RowTemplate.Height = 24;
            this.DataGrid.Size = new System.Drawing.Size(688, 245);
            this.DataGrid.TabIndex = 0;
            // 
            // ColumnID
            // 
            this.ColumnID.HeaderText = "id";
            this.ColumnID.Name = "ColumnID";
            // 
            // ColumnName
            // 
            this.ColumnName.HeaderText = "Имя";
            this.ColumnName.Name = "ColumnName";
            // 
            // ColumnLastName
            // 
            this.ColumnLastName.HeaderText = "Фамилия";
            this.ColumnLastName.Name = "ColumnLastName";
            // 
            // ColumnAge
            // 
            this.ColumnAge.HeaderText = "Возраст";
            this.ColumnAge.Name = "ColumnAge";
            // 
            // ColumnDepartament
            // 
            this.ColumnDepartament.HeaderText = "Департамент";
            this.ColumnDepartament.Name = "ColumnDepartament";
            // 
            // ColumnSalary
            // 
            this.ColumnSalary.HeaderText = "Зарплата";
            this.ColumnSalary.Name = "ColumnSalary";
            // 
            // ColumnProjects
            // 
            this.ColumnProjects.HeaderText = "Проекты";
            this.ColumnProjects.Name = "ColumnProjects";
            // 
            // CreateNewDB
            // 
            this.CreateNewDB.Location = new System.Drawing.Point(61, 340);
            this.CreateNewDB.Name = "CreateNewDB";
            this.CreateNewDB.Size = new System.Drawing.Size(189, 59);
            this.CreateNewDB.TabIndex = 1;
            this.CreateNewDB.Text = "Создать новую базу данных";
            this.CreateNewDB.UseVisualStyleBackColor = true;
            this.CreateNewDB.Click += new System.EventHandler(this.CreateNewDB_Click);
            // 
            // SaveInXMLButton
            // 
            this.SaveInXMLButton.Location = new System.Drawing.Point(286, 340);
            this.SaveInXMLButton.Name = "SaveInXMLButton";
            this.SaveInXMLButton.Size = new System.Drawing.Size(133, 22);
            this.SaveInXMLButton.TabIndex = 2;
            this.SaveInXMLButton.Text = "Сохранить в XML";
            this.SaveInXMLButton.UseVisualStyleBackColor = true;
            this.SaveInXMLButton.Click += new System.EventHandler(this.SaveInXMLButton_Click);
            // 
            // SaveInJSONbutton
            // 
            this.SaveInJSONbutton.Location = new System.Drawing.Point(451, 340);
            this.SaveInJSONbutton.Name = "SaveInJSONbutton";
            this.SaveInJSONbutton.Size = new System.Drawing.Size(129, 22);
            this.SaveInJSONbutton.TabIndex = 3;
            this.SaveInJSONbutton.Text = "Сохранить в JSON";
            this.SaveInJSONbutton.UseVisualStyleBackColor = true;
            this.SaveInJSONbutton.Click += new System.EventHandler(this.SaveInJSONbutton_Click);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTitle.Location = new System.Drawing.Point(227, 25);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(393, 25);
            this.labelTitle.TabIndex = 4;
            this.labelTitle.Text = "База данных сотрудников \"ИмяКомпании\"";
            // 
            // LoadXMLButton
            // 
            this.LoadXMLButton.Location = new System.Drawing.Point(286, 377);
            this.LoadXMLButton.Name = "LoadXMLButton";
            this.LoadXMLButton.Size = new System.Drawing.Size(133, 22);
            this.LoadXMLButton.TabIndex = 5;
            this.LoadXMLButton.Text = "Загрузить XML";
            this.LoadXMLButton.UseVisualStyleBackColor = true;
            this.LoadXMLButton.Click += new System.EventHandler(this.LoadXMLButton_Click);
            // 
            // ClearGridButton
            // 
            this.ClearGridButton.Location = new System.Drawing.Point(620, 340);
            this.ClearGridButton.Name = "ClearGridButton";
            this.ClearGridButton.Size = new System.Drawing.Size(129, 59);
            this.ClearGridButton.TabIndex = 6;
            this.ClearGridButton.Text = "Очистить поля";
            this.ClearGridButton.UseVisualStyleBackColor = true;
            this.ClearGridButton.Click += new System.EventHandler(this.ClearGridButton_Click);
            // 
            // LoadFromJsonButton
            // 
            this.LoadFromJsonButton.Location = new System.Drawing.Point(451, 377);
            this.LoadFromJsonButton.Name = "LoadFromJsonButton";
            this.LoadFromJsonButton.Size = new System.Drawing.Size(129, 22);
            this.LoadFromJsonButton.TabIndex = 7;
            this.LoadFromJsonButton.Text = "Загрузить из JSON";
            this.LoadFromJsonButton.UseVisualStyleBackColor = true;
            this.LoadFromJsonButton.Click += new System.EventHandler(this.LoadFromJsonButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LoadFromJsonButton);
            this.Controls.Add(this.ClearGridButton);
            this.Controls.Add(this.LoadXMLButton);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.SaveInJSONbutton);
            this.Controls.Add(this.SaveInXMLButton);
            this.Controls.Add(this.CreateNewDB);
            this.Controls.Add(this.DataGrid);
            this.Name = "MainForm";
            this.Text = "База данных";
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnLastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAge;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDepartament;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSalary;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnProjects;
        private System.Windows.Forms.Button CreateNewDB;
        private System.Windows.Forms.Button SaveInXMLButton;
        private System.Windows.Forms.Button SaveInJSONbutton;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Button LoadXMLButton;
        private System.Windows.Forms.Button ClearGridButton;
        private System.Windows.Forms.Button LoadFromJsonButton;
    }
}

