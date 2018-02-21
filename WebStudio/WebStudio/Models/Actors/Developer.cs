using System;

namespace WebStudio.Classes
{
    public class Developer : Employee
    {
        //TODO: id
        public Developer(string name, int hourCost)
        {
            base.name = name;
            base.position = "Developer";
            base.hourCost = hourCost;
            //        base.id
        }

        //TODO:
        public void workedOnFeature(int feature_id, int workHours)
        {
            throw new NotImplementedException();
        }
    }
}