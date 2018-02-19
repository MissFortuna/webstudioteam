using System;

namespace WebStudio.Classes
{
    public class Agreement
    {
        public int agreeement_id { get; set; }
        public int client_id { get; set; }
        public int tlead_id { get; set; }
        public int project_id { get; set; }
        public int budget { get; set; }
        public Date date { get; set; }
        public Date deadline { get; set; }

        public Agreement(int agreeement_id, int client_id, int tlead_id, int project_id, int budget, Date date, Date deadline)
        {
            this.agreeement_id = agreeement_id;
            this.client_id = client_id;
            this.tlead_id = tlead_id;
            this.project_id = project_id;
            this.budget = budget;
            this.date = date;
            this.deadline = deadline;
        }
        
        //TODO:
        public int calculateBudget(Agreement agreement, Project project)
        {
            throw new NotImplementedException();
        }

    }
}