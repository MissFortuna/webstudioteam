using System;
using System.Collections.Generic;

namespace WebStudio.Classes
{
    public enum Status { toDo, inWork, finished, beingChecked }

    public class Feature
    {
        public string feature_id { get; set; }
        public int feature_price { get; set; }
        public int feature_hours_need { get; set; }
        public virtual ICollection<Task> tasks { get; set; }
        public Status feature_status { get; set; }

        //TODO: id
        public Feature(int feature_price, int feature_hours_need, Status feature_status)
        {
            this.feature_price = feature_price;
            this.feature_hours_need = feature_hours_need;
            this.feature_status = feature_status;
        }

        //TODO: what is this meth0d for if we have int feature_price?
        public int featurePrice(Feature feature)
        {
            throw new NotImplementedException();
        }

        public void addTask(Task task)
        {
            tasks.Add(task);
        }

    }

    public class Task
    {
        public Developer developer;
        public int time;

        public Task(Developer developer, int time)
        {
            this.developer = developer;
            this.time = time;
        }
    }
}