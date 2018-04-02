using System;

namespace WebStudio.Classes
{
    public class Vacation
    {
        public string id { get; set; }
        public DateTime start_date { get; set; }
        public DateTime end_date { get; set; }
        public virtual ICollection<Employee> employee { get; set; }
        
        public Vacation(string id, DateTime start_date, 
            DateTime end_date, ICollection<Employee> employee)
        {
            this.id = id;
            this.start_date = start_date;
            this.end_date = end_date;
            this.employee = employee;

        }
    }
}