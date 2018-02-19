using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebStudio.Classes
{
    public class Payment
    {
        public int client_id { get; set; }
        public int agreeement_id { get; set; }
        public int sum { get; set; }
        public DateTime date { get; set; }

        public Payment(int client_id, int agreeement_id, int sum, DateTime date)
        {
            this.client_id = client_id;
            this.agreeement_id = agreeement_id;
            this.sum = sum;
            this.date = date;
        }
        
        //TODO:
        public int calculateBudget(Agreement agreement, Project project)
        {
            throw new NotImplementedException();
        }

    }
}