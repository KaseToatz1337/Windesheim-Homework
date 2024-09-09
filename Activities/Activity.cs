namespace Activities
{
    public class Activity(string title, DateOnly date, string description)
    {
        private string title = title;
        private DateOnly date = date;
        private string description = description;

        public string getTitle()
        {
            return this.title;
        }

        public DateOnly getDate()
        {
            return this.date;
        }

        public string getDescription()
        {
            return this.description;
        }
    }
}
