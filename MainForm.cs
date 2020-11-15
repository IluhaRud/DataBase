using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatatBase
{
    public partial class MainForm : Form
    {
        DataBase dataBase;
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
    }
}
