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
    public partial class MainForm : Form
    {
        public DataBase dataBase;

        public MainForm()
        {
            InitializeComponent();
            dataBase = CreateRandomDataBase();
            DataGrid.RowHeadersVisible = false;
            PrintDataBase(dataBase);
        }

        private Departament CreateRandomDepartament()
        {
            List<Worker> workers = new List<Worker>();
            Random random = new Random();

            string[] lastNames = new string[7]
            {
                "Петров",
                "Иванов",
                "Сидоров",
                "Русинов",
                "Лунин",
                "Крюков",
                "Андреев"
            };
            string[] names = new string[7]
            {
                "Илья",
                "Антон",
                "Петр",
                "Иван",
                "Владимир",
                "Андрей",
                "Артём"
            };

            string depName = $"Отдел {Departament.ID}";
            DateTime dateOfCreation = DateTime.Now;
            int staffCount = random.Next(100, 500);

            for (int i = 0; i < staffCount; i++)
            {
                string lastName = lastNames[random.Next(0, lastNames.Length)];
                string name = names[random.Next(0, lastNames.Length)];
                int age = random.Next(20, 51);
                string departament = depName;
                int salary = random.Next(20_000, 150_000);
                int projects = random.Next(1, 5);

                workers.Add(new Worker(lastName, name, age, departament, salary, projects));
            }

            return new Departament(depName, dateOfCreation, staffCount, workers);
        }
        private DataBase CreateRandomDataBase()
        {
            List<Departament> departaments = new List<Departament>();
            Random rand = new Random();
            int depCount = rand.Next(5, 12);

            for (int i = 0; i < depCount; i++)
                departaments.Add(CreateRandomDepartament());

            return new DataBase(departaments);
        }
        private List<Worker> ImportDataBase(string[] values)
        {
            List<Worker> workers = new List<Worker>();

            for (int i = 0; i < dataBase.departaments.Count; i++)
            {
                int id;
                string name;
                string lastName;
                int age;
                string departament;
                int salary;
                int projects;

                for (int j = 0; j < dataBase.departaments[i].workers.Count; j++)
                {
                    if (values[0] == String.Empty)
                        id = dataBase.departaments[i].workers[j].id;
                    else id = Convert.ToInt32(values[0]);

                    if (values[1] == String.Empty)
                        name = dataBase.departaments[i].workers[j].name;
                    else name = values[1];

                    if (values[2] == String.Empty)
                        lastName = dataBase.departaments[i].workers[j].lastName;
                    else lastName = values[2];

                    if (values[3] == String.Empty)
                        age = dataBase.departaments[i].workers[j].age;
                    else age = Convert.ToInt32(values[3]);

                    if (values[4] == String.Empty)
                        departament = dataBase.departaments[i].workers[j].departament;
                    else departament = values[4];

                    if (values[5] == String.Empty)
                        salary = dataBase.departaments[i].workers[j].salary;
                    else salary = Convert.ToInt32(values[5]);

                    if (values[6] == String.Empty)
                        projects = dataBase.departaments[i].workers[j].projects;
                    else projects = Convert.ToInt32(values[6]);

                    Worker worker = new Worker(id, name, lastName, age, departament, salary, projects);

                    if (dataBase.departaments[i].workers[j] == worker)
                        workers.Add(worker);
                }
            }
            return workers;
        }

        private void CreateNewDB_Click(object sender, EventArgs e)
        {
            DataGrid.Rows.Clear();
            Worker.ID = 0;
            Departament.ID = 0;
            dataBase = CreateRandomDataBase();
            PrintDataBase(dataBase);
        }
        private void PrintDataBase(DataBase dataBase)
        {
            for (int i = 0; i < dataBase.departaments.Count; i++)
                for (int j = 0; j < dataBase.departaments[i].staffCount; j++)
                {
                    Worker worker = dataBase.departaments[i].workers[j];
                    DataGrid.Rows.Add(worker.id, worker.lastName, worker.name, worker.age, worker.departament, worker.salary, worker.projects);
                }
        }
        public void PrintImportWorkers(List<Worker> w)
        {
            DataGrid.Rows.Clear();
            for (int i = 0; i < w.Count; i++)
                DataGrid.Rows.Add(w[i].id, w[i].lastName, w[i].name, w[i].age, w[i].departament, w[i].salary, w[i].projects);
        }

        private void LoadXMLButton_Click(object sender, EventArgs e)
        {
            DataGrid.Rows.Clear();
            dataBase = dataBase.DeserializeFromXML("data.xml");
            PrintDataBase(dataBase);
        }
        private void SaveInXMLButton_Click(object sender, EventArgs e)
        {
            dataBase.SerializeToXML("Data.xml");
        }
        private void ClearGridButton_Click(object sender, EventArgs e)
        {
            DataGrid.Rows.Clear();
        }
        private void SaveInJSONbutton_Click(object sender, EventArgs e)
        {
            dataBase.SerializeToJson("data.json");
        }
        private void LoadFromJsonButton_Click(object sender, EventArgs e)
        {
            DataGrid.Rows.Clear();
            dataBase = dataBase.DeserializeFromJson("data.json");
            PrintDataBase(dataBase);
        }
        
        private void buttonImport_Click(object sender, EventArgs e)
        {
            ImportForm importForm = new ImportForm(this);
            importForm.Show();
        }
    }
}
