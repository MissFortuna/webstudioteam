using System;

namespace WebStudio.Classes
{
    public class Payment
    {
        public int sum { get; set; }
        public DateTime date { get; set; }

        public Payment(int sum, DateTime date)
        {
            this.sum = sum;
            this.date = date;
        }

    }
}