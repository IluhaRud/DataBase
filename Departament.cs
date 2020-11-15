using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase
{
    public class Departament
    {
        static Random random = new Random();
        public static int ID;
        public int id { get; }
        public string name { get; }
        public DateTime dateOfCreation { get; }
        public int staffCount { get; set; }
        public List<Worker> workers { get; set; }

        public Departament(string name, DateTime date, int staff, List<Worker> workers)
        {
            id = ID;
            this.name = name;
            dateOfCreation = date;
            staffCount = staff;
            this.workers = workers;
            ID++;
        }
        public Departament(int id, string name, DateTime date, int staff, List<Worker> workers)
        {
            this.id = id;
            this.name = name;
            dateOfCreation = date;
            staffCount = staff;
            this.workers = workers;
        }
    }
}
