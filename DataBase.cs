using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace DatatBase
{
    public class DataBase
    {
        public List<Departament> departaments { get; set; }

        public DataBase(List<Departament> departaments)
        {
            this.departaments = departaments;
        }

        public void SerializeToXML(string path)
        {
            XElement dataBase = new XElement("DATA_BASE");

            XAttribute id = new XAttribute("id", String.Empty);
            XAttribute name = new XAttribute("name", String.Empty);
            XAttribute lastNmae = new XAttribute("last_name", String.Empty);
            XAttribute age = new XAttribute("age", String.Empty);
            XAttribute salary = new XAttribute("salary", String.Empty);
            XAttribute projects = new XAttribute("projects", String.Empty);

            XAttribute depID = new XAttribute("id", String.Empty);
            XAttribute depName = new XAttribute("name", String.Empty);
            XAttribute depDate = new XAttribute("date_of_creation", String.Empty);
            XAttribute depStaff = new XAttribute("staff", String.Empty);

            for (int i = 0; i < departaments.Count; i++)
            {
                XElement departament = new XElement($"DEPARTAMENT_{departaments[i].id}");

                for (int j = 0; j < departaments[i].workers.Count; j++)
                {
                    id = new XAttribute("id", departaments[i].workers[j].id);
                    name = new XAttribute("name", departaments[i].workers[j].name);
                    lastNmae = new XAttribute("last_name", departaments[i].workers[j].lastName);
                    age = new XAttribute("age", departaments[i].workers[j].age);
                    salary = new XAttribute("salary", departaments[i].workers[j].salary);
                    projects = new XAttribute("projects", departaments[i].workers[j].projects);

                    XElement worker = new XElement($"WORKER_ID_{departaments[i].workers[j].id}");

                    worker.Add(id, name, lastNmae, age, salary, projects);
                    departament.Add(worker);
                }

                depID = new XAttribute("id", departaments[i].id);
                depName = new XAttribute("name", departaments[i].name);
                depDate = new XAttribute("date_of_creation", departaments[i].dateOfCreation.ToString());
                depStaff = new XAttribute("staff", departaments[i].staffCount);

                departament.Add(depID, depName, depDate, depStaff);
                dataBase.Add(departament);
            }
            dataBase.Save("data.xml");
        }
        public DataBase DeserializeFromXML(string path)
        {
            StreamReader stream = new StreamReader(path);
            List<Departament> dep = new List<Departament>();

            string doc = stream.ReadToEnd();

            List<XElement> departaments = XDocument.Parse(doc).Root.Elements().ToList();

            for (int i = 0; i < departaments.Count; i++)
            {
                List<XElement> workers = new List<XElement>();
                workers = departaments[i].Elements().ToList();
                List<Worker> _workers = new List<Worker>();

                for (int j = 0; j < workers.Count; j++)
                {

                    int id = Convert.ToInt32(workers[j].Attribute("id").Value);
                    string name = workers[j].Attribute("name").Value;
                    string lastName = workers[j].Attribute("last_name").Value;
                    int age = Convert.ToInt32(workers[j].Attribute("age").Value);
                    string departament = $"Отдел_{departaments[i].Attribute("id").Value}";
                    int salary = Convert.ToInt32(workers[j].Attribute("salary").Value);
                    int projects = Convert.ToInt32(workers[j].Attribute("projects").Value);

                    _workers.Add(new Worker(id, lastName, name, age, departament, salary, projects));
                }

                int depID = Convert.ToInt32(departaments[i].Attribute("id").Value);
                string depName = departaments[i].Attribute("name").Value;
                DateTime dateOfCreation = Convert.ToDateTime(departaments[i].Attribute("date_of_creation").Value);
                int staffCount = Convert.ToInt32(departaments[i].Attribute("staff").Value);

                dep.Add(new Departament(depID, depName, dateOfCreation, staffCount, _workers));
            }


            return new DataBase(dep);
        }
        public void SerializeToJson(string path)
        {
            JObject dataBase = new JObject();
            JObject deps = new JObject();
            
            for (int i = 0; i < departaments.Count; i++)
            {
                JArray workers = new JArray();
                
                for (int j = 0; j < departaments[i].workers.Count; j++)
                {
                    JObject worker = new JObject();
                    worker["id"] = departaments[i].workers[j].id;
                    worker["last_name"] = departaments[i].workers[j].lastName;
                    worker["name"] = departaments[i].workers[j].name;
                    worker["age"] = departaments[i].workers[j].age;
                    worker["departament"] = departaments[i].name;
                    worker["salary"] = departaments[i].workers[j].salary;
                    worker["projects"] = departaments[i].workers[j].projects;

                    workers.Add(worker);
                }
                JObject dep = new JObject();
                dep["id"] = departaments[i].id;
                dep["name"] = departaments[i].name;
                dep["date_of_creation"] = departaments[i].dateOfCreation.ToString();
                dep["staff"] = departaments[i].staffCount;
                dep[departaments[i].name] = workers;

                deps[$"DEPARTAMENT {departaments[i].id}"] = dep; 
            }
            dataBase["DATA_BASE"] = deps;

            File.WriteAllText(path, dataBase.ToString());
        }
        public DataBase DeserializeFromJson(string path)
        {
            string jsonDoc = File.ReadAllText(path);
            List<Departament> departaments = new List<Departament>();

            JObject dataBase = new JObject();

            dataBase = JObject.Parse(jsonDoc);
            var deps = dataBase["DATA_BASE"].ToArray();
            
            for (int i = 0; i < deps.Length; i++)
            {
                var dep = deps[i].Children().ToArray();
                var workers = dep[0][$"Отдел {dep[0]["id"]}"];
                List<Worker> w = new List<Worker>();

                for (int j = 0; j < workers.Count(); j++)
                {
                    int id = Convert.ToInt32(workers[j]["id"]);
                    string lastName = workers[j]["last_name"].ToString();
                    string name = workers[j]["name"].ToString();
                    int age = Convert.ToInt32(workers[j]["age"]);
                    string departament = workers[j]["departament"].ToString();
                    int salary = Convert.ToInt32(workers[j]["salary"]);
                    int projects = Convert.ToInt32(workers[j]["projects"]);
                    w.Add(new Worker(id, lastName, name, age, departament, salary, projects));
                }

                int dep_id = Convert.ToInt32(dep[0]["id"]);
                string dep_name = dep[0]["name"].ToString();
                DateTime date = Convert.ToDateTime(dep[0]["date_of_creation"].ToString());
                int dep_staffCount = Convert.ToInt32(dep[0]["staff"]);

                departaments.Add(new Departament(dep_id, dep_name, date, dep_staffCount, w));
            }

            return  new DataBase(departaments);
        }
    }
}
