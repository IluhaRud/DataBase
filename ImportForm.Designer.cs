namespace DataBase
{
    partial class ImportForm
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
            this.checkBoxId = new System.Windows.Forms.CheckBox();
            this.checkBoxName = new System.Windows.Forms.CheckBox();
            this.checkBoxLastName = new System.Windows.Forms.CheckBox();
            this.checkBoxAge = new System.Windows.Forms.CheckBox();
            this.checkBoxDepName = new System.Windows.Forms.CheckBox();
            this.checkBoxProjects = new System.Windows.Forms.CheckBox();
            this.buttonImport = new System.Windows.Forms.Button();
            this.textBoxDepName = new System.Windows.Forms.TextBox();
            this.textBoxProjects = new System.Windows.Forms.TextBox();
            this.textBoxAge = new System.Windows.Forms.TextBox();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.textBoxSalary = new System.Windows.Forms.TextBox();
            this.checkBoxSalary = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // checkBoxId
            // 
            this.checkBoxId.AutoSize = true;
            this.checkBoxId.Location = new System.Drawing.Point(12, 25);
            this.checkBoxId.Name = "checkBoxId";
            this.checkBoxId.Size = new System.Drawing.Size(36, 17);
            this.checkBoxId.TabIndex = 0;
            this.checkBoxId.Text = "id";
            this.checkBoxId.UseVisualStyleBackColor = true;
            this.checkBoxId.CheckedChanged += new System.EventHandler(this.checkBoxId_CheckedChanged);
            // 
            // checkBoxName
            // 
            this.checkBoxName.AutoSize = true;
            this.checkBoxName.Location = new System.Drawing.Point(12, 54);
            this.checkBoxName.Name = "checkBoxName";
            this.checkBoxName.Size = new System.Drawing.Size(48, 17);
            this.checkBoxName.TabIndex = 1;
            this.checkBoxName.Text = "Имя";
            this.checkBoxName.UseVisualStyleBackColor = true;
            this.checkBoxName.CheckedChanged += new System.EventHandler(this.checkBoxName_CheckedChanged);
            // 
            // checkBoxLastName
            // 
            this.checkBoxLastName.AutoSize = true;
            this.checkBoxLastName.Location = new System.Drawing.Point(12, 82);
            this.checkBoxLastName.Name = "checkBoxLastName";
            this.checkBoxLastName.Size = new System.Drawing.Size(75, 17);
            this.checkBoxLastName.TabIndex = 2;
            this.checkBoxLastName.Text = "Фамилия";
            this.checkBoxLastName.UseVisualStyleBackColor = true;
            this.checkBoxLastName.CheckedChanged += new System.EventHandler(this.checkBoxLastName_CheckedChanged);
            // 
            // checkBoxAge
            // 
            this.checkBoxAge.AutoSize = true;
            this.checkBoxAge.Location = new System.Drawing.Point(12, 109);
            this.checkBoxAge.Name = "checkBoxAge";
            this.checkBoxAge.Size = new System.Drawing.Size(68, 17);
            this.checkBoxAge.TabIndex = 3;
            this.checkBoxAge.Text = "Возраст";
            this.checkBoxAge.UseVisualStyleBackColor = true;
            this.checkBoxAge.CheckedChanged += new System.EventHandler(this.checkBoxAge_CheckedChanged);
            // 
            // checkBoxDepName
            // 
            this.checkBoxDepName.AutoSize = true;
            this.checkBoxDepName.Location = new System.Drawing.Point(12, 137);
            this.checkBoxDepName.Name = "checkBoxDepName";
            this.checkBoxDepName.Size = new System.Drawing.Size(97, 17);
            this.checkBoxDepName.TabIndex = 4;
            this.checkBoxDepName.Text = "Департамент";
            this.checkBoxDepName.UseVisualStyleBackColor = true;
            this.checkBoxDepName.CheckedChanged += new System.EventHandler(this.checkBoxDepName_CheckedChanged);
            // 
            // checkBoxProjects
            // 
            this.checkBoxProjects.AutoSize = true;
            this.checkBoxProjects.Location = new System.Drawing.Point(12, 190);
            this.checkBoxProjects.Name = "checkBoxProjects";
            this.checkBoxProjects.Size = new System.Drawing.Size(73, 17);
            this.checkBoxProjects.TabIndex = 5;
            this.checkBoxProjects.Text = "Проекты";
            this.checkBoxProjects.UseVisualStyleBackColor = true;
            this.checkBoxProjects.CheckedChanged += new System.EventHandler(this.checkBoxProjects_CheckedChanged);
            // 
            // buttonImport
            // 
            this.buttonImport.Location = new System.Drawing.Point(115, 218);
            this.buttonImport.Name = "buttonImport";
            this.buttonImport.Size = new System.Drawing.Size(111, 34);
            this.buttonImport.TabIndex = 6;
            this.buttonImport.Text = "Импортировать";
            this.buttonImport.UseVisualStyleBackColor = true;
            this.buttonImport.Click += new System.EventHandler(this.buttonImport_Click);
            // 
            // textBoxDepName
            // 
            this.textBoxDepName.Location = new System.Drawing.Point(115, 134);
            this.textBoxDepName.Multiline = true;
            this.textBoxDepName.Name = "textBoxDepName";
            this.textBoxDepName.Size = new System.Drawing.Size(196, 22);
            this.textBoxDepName.TabIndex = 7;
            // 
            // textBoxProjects
            // 
            this.textBoxProjects.Location = new System.Drawing.Point(115, 189);
            this.textBoxProjects.Multiline = true;
            this.textBoxProjects.Name = "textBoxProjects";
            this.textBoxProjects.Size = new System.Drawing.Size(196, 22);
            this.textBoxProjects.TabIndex = 8;
            // 
            // textBoxAge
            // 
            this.textBoxAge.Location = new System.Drawing.Point(115, 106);
            this.textBoxAge.Multiline = true;
            this.textBoxAge.Name = "textBoxAge";
            this.textBoxAge.Size = new System.Drawing.Size(196, 22);
            this.textBoxAge.TabIndex = 9;
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(115, 78);
            this.textBoxLastName.Multiline = true;
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(196, 22);
            this.textBoxLastName.TabIndex = 10;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(115, 50);
            this.textBoxName.Multiline = true;
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(196, 22);
            this.textBoxName.TabIndex = 11;
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(115, 22);
            this.textBoxId.Multiline = true;
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(196, 22);
            this.textBoxId.TabIndex = 12;
            // 
            // textBoxSalary
            // 
            this.textBoxSalary.Location = new System.Drawing.Point(115, 162);
            this.textBoxSalary.Multiline = true;
            this.textBoxSalary.Name = "textBoxSalary";
            this.textBoxSalary.Size = new System.Drawing.Size(196, 22);
            this.textBoxSalary.TabIndex = 14;
            // 
            // checkBoxSalary
            // 
            this.checkBoxSalary.AutoSize = true;
            this.checkBoxSalary.Location = new System.Drawing.Point(12, 165);
            this.checkBoxSalary.Name = "checkBoxSalary";
            this.checkBoxSalary.Size = new System.Drawing.Size(75, 17);
            this.checkBoxSalary.TabIndex = 13;
            this.checkBoxSalary.Text = "Зарплата";
            this.checkBoxSalary.UseVisualStyleBackColor = true;
            this.checkBoxSalary.CheckedChanged += new System.EventHandler(this.checkBoxSalary_CheckedChanged);
            // 
            // ImportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 260);
            this.Controls.Add(this.textBoxSalary);
            this.Controls.Add(this.checkBoxSalary);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.textBoxLastName);
            this.Controls.Add(this.textBoxAge);
            this.Controls.Add(this.textBoxProjects);
            this.Controls.Add(this.textBoxDepName);
            this.Controls.Add(this.buttonImport);
            this.Controls.Add(this.checkBoxProjects);
            this.Controls.Add(this.checkBoxDepName);
            this.Controls.Add(this.checkBoxAge);
            this.Controls.Add(this.checkBoxLastName);
            this.Controls.Add(this.checkBoxName);
            this.Controls.Add(this.checkBoxId);
            this.Name = "ImportForm";
            this.Text = "Импорт данных";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBoxId;
        private System.Windows.Forms.CheckBox checkBoxName;
        private System.Windows.Forms.CheckBox checkBoxLastName;
        private System.Windows.Forms.CheckBox checkBoxAge;
        private System.Windows.Forms.CheckBox checkBoxDepName;
        private System.Windows.Forms.CheckBox checkBoxProjects;
        private System.Windows.Forms.Button buttonImport;
        private System.Windows.Forms.TextBox textBoxDepName;
        private System.Windows.Forms.TextBox textBoxProjects;
        private System.Windows.Forms.TextBox textBoxAge;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.TextBox textBoxSalary;
        private System.Windows.Forms.CheckBox checkBoxSalary;
    }
}