using System;
using System.Collections.Generic;

namespace WebStudio.Classes
{
    public class Budget
    {
        public string budget_id { get; set; }
        public int projectPrice { get; set; }
        public virtual ICollection<Feature> featureToPay { get; set; }

        //TODO: id
        public Budget(int projectPrice, ICollection<Feature> featureToPay)
        {
            this.projectPrice = projectPrice;
            this.featureToPay = featureToPay;
        }

        //TODO:
        public int calculateBudget(ICollection<Feature> features)
        {
            throw new NotImplementedException();
        }

    }
}