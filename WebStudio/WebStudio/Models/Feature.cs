using System;
using System.Collections.Generic;

namespace WebStudio.Classes
{
    public class Feature
    {
        public int feature_id { get; set; }
        public int feature_price { get; set; }
        public int feature_hours_need { get; set; }
        public virtual ICollection<Developer> total_developers { get; set; }
        public string feature_status { get; set; }

        public Feature(int feature_id, int feature_price, 
            int feature_hours_need, 
            ICollection<Developer> total_developers, 
            string feature_status)
        {
            this.feature_id = feature_id;
            this.feature_price = feature_price;
            this.feature_hours_need = feature_hours_need;
            this.total_developers = total_developers;
            this.feature_status = feature_status;
        }


        //TODO: what is this methid for if we have int feature_price?
        public int featurePrice(Feature feature) {
            throw new NotImplementedException();
        }

    }
}