namespace WebStudio.Classes
{
    public class Date
    {
        public int day { get; set; }
        public int month { get; set; }
        public int year { get; set; }

        public Date(int day, int month, int year)
        {
            this.day = day;
            this.month = month;
            this.year = year;
        }

    }
}