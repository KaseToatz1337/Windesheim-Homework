namespace Activities
{
    public class Person(string name, string email)
    {
        private string name = name;
        private string email = email;

        public string getName()
        {
            return this.name;
        }

        public string getEmail()
        {
            return this.email;
        }
    }
}
