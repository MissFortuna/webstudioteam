using System;

namespace WebStudio.Classes
{
    public class Leader : Employee
    {
        public int id { get; set; }
        public string name { get; set; }
        public string position { get; }
        public int salary { get; set; }

        public Leader(int id, string name, int salary)
        {
            this.id = id;
            this.name = name;
            position = "Leader";
            this.salary = salary;
        }

    }
}