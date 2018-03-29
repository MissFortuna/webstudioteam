using System;
using System.Collections.Generic;

namespace WebStudio.Classes
{
    public class Agreement
    {
        int agreementCount { get; set; }

        public string agreeement_id { get; set; }
        public string client_id { get; set; }
        public string tlead_id { get; set; }
        public string project_id { get; set; }
        public string budget_id { get; set; }
        public DateTime date { get; set; }
        public DateTime deadline { get; set; }
        public virtual ICollection<Payment> payments { get; set; }

        //TODO: id
        public Agreement(string client_id, string tlead_id, string project_id, string budget_id,
            DateTime deadline,
            ICollection<Payment> payments)
        {
            this.agreeement_id = "agr_" + this.agreementCount++;

            this.client_id = client_id;
            this.tlead_id = tlead_id;
            this.project_id = project_id;
            this.budget_id = budget_id;
            this.date = DateTime.Today;
            this.deadline = deadline;
            this.payments = payments;
        }

        //TODO:
        public Budget calculateBudget(Agreement agreement, ICollection<Feature> featureToDo)
        {
            throw new NotImplementedException();
        }

        public void makePayment(Payment payment)
        {
            this.payments.Add(payment);
        }

    }
}