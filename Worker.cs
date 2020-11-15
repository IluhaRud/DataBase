using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase
{
    public class Worker
    {
        public static int ID;
        static List<int> deletedId = new List<int>();
        public int id { get; }
        public string lastName { get; set; }
        public string name { get; set; }
        public int age { get; set; }
        public string departament { get; set; }
        public int salary { get; set; }
        public int projects { get; set; }


        public Worker(string lastName, string name, int age, string departament, int salary, int projects)
        {
            this.id = ID;
            this.lastName = lastName;
            this.name = name;
            this.age = age;
            this.departament = departament;
            this.salary = salary;
            this.projects = projects;
            ID++;
        }
        public Worker(int id, string lastName, string name, int age, string departament, int salary, int projects)
        {
            this.id = id;
            this.lastName = lastName;
            this.name = name;
            this.age = age;
            this.departament = departament;
            this.salary = salary;
            this.projects = projects;
        }
    }
}
