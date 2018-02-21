using System;

namespace WebStudio.Classes
{
    public class Leader : Employee
    {
        //TODO: id
        public Leader(string name, int hourCost)
        {
            //       this.id = id;
            base.name = name;
            position = "Leader";
            base.hourCost = hourCost;
        }

    }
}