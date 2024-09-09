namespace Activities
{
    public class Invitation
    {
        public static string getValue(string prompt)
        {
            Console.Write(prompt);
            string? value = Console.ReadLine();
            if (value == null)
            {
                Console.WriteLine("No input provided.");
                value = getValue(prompt);
            }
            return value;
        }

        public static DateOnly getDate(string prompt)
        {
            string value = getValue(prompt);
            DateOnly date = new();
            try
            {
                date = DateOnly.Parse(value);
            }
            catch
            {
                Console.WriteLine("Invalid date provided.");
                date = getDate(prompt);
            }
            return date;
        }

        public static bool getResponse(string prompt)
        {
            string value = getValue(prompt);
            if (value.ToLower() == "y")
            {
                return true;
            }
            else if (value.ToLower() == "n")
            {
                return false;
            }
            else
            {
                Console.WriteLine("Invalid response provided.");
                return getResponse(prompt);
            }
        }
    }
}