using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBase
{
    public partial class ImportForm : Form
    {
        public MainForm mainForm;
        public ImportForm(MainForm mainForm)
        {
            this.mainForm = mainForm;
            InitializeComponent();
            CheckTextBoxes();
        }

        private void CheckTextBoxes()
        {
            if (!checkBoxId.Checked)
                textBoxId.Enabled = false;
            if (!checkBoxName.Checked)
                textBoxName.Enabled = false;
            if (!checkBoxLastName.Checked)
                textBoxLastName.Enabled = false;
            if (!checkBoxAge.Checked)
                textBoxAge.Enabled = false;
            if (!checkBoxDepName.Checked)
                textBoxDepName.Enabled = false;
            if (!checkBoxProjects.Checked)
                textBoxProjects.Enabled = false;
        }

        public string[] GetValues()
        {
            string[] values = new string[7];

            if (checkBoxId.Enabled)
                values[0] = textBoxId.Text;
            if (checkBoxName.Enabled)
                values[1] = textBoxName.Text;
            if (checkBoxLastName.Enabled)
                values[2] = textBoxLastName.Text;
            if (checkBoxAge.Enabled)
                values[3] = textBoxAge.Text;
            if (checkBoxDepName.Enabled)
                values[4] = textBoxDepName.Text;
            if (checkBoxSalary.Enabled)
                values[5] = textBoxSalary.Text;
            if (checkBoxProjects.Enabled)
                values[6] = textBoxProjects.Text;

            return values;
        }

        private void checkBoxId_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxId.Checked)
                textBoxId.Enabled = true;
            if (!checkBoxId.Checked)
                textBoxId.Enabled = false;
        }
        private void checkBoxName_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxName.Checked)
                textBoxName.Enabled = true;
            if (!checkBoxName.Checked)
                textBoxName.Enabled = false;
        }
        private void checkBoxLastName_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxLastName.Checked)
                textBoxLastName.Enabled = true;
            if (!checkBoxLastName.Checked)
                textBoxLastName.Enabled = false;
        }
        private void checkBoxAge_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxAge.Checked)
                textBoxAge.Enabled = true;
            if (!checkBoxAge.Checked)
                textBoxAge.Enabled = false;
        }
        private void checkBoxDepName_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxDepName.Checked)
                textBoxDepName.Enabled = true;
            if (!checkBoxDepName.Checked)
                textBoxDepName.Enabled = false;
        }
        private void checkBoxSalary_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSalary.Checked)
                textBoxSalary.Enabled = true;
            if (!checkBoxSalary.Checked)
                textBoxSalary.Enabled = false;
        }
        private void checkBoxProjects_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxProjects.Checked)
                textBoxProjects.Enabled = true;
            if (!checkBoxProjects.Checked)
                textBoxProjects.Enabled = false;
        }

        private void buttonImport_Click(object sender, EventArgs e)
        {
            List<Worker> importWorkers = mainForm.dataBase.ImportDataBase(GetValues());
            mainForm.PrintImportWorkers(importWorkers);
            Close();
        }
    }
}
