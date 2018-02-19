using System;

namespace WebStudio.Classes
{
    public class Developer : Employee
    {
        public int id { get; set; }
        public string name { get; set; }
        public string position { get; }
        public int salary { get; set; }

        public Developer(int id, string name, int salary)
        {
            this.id = id;
            this.name = name;
            this.position = "Developer";
            this.salary = salary;
        }

        //TODO:
        public void workOnFeature(int feature_id, int workHours)
        {
            throw new NotImplementedException();
        }
    }
}