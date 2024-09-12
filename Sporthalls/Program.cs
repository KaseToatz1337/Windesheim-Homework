namespace Sporthalls
{
    public class Program
    {
        static readonly List<string> sportHalls = ["Mercurius", "Jupiter", "Mars"];
        static readonly List<List<int>> occupation = [[1, 2, 14], [5, 3, 44], [1, 1, 18]];

        static void Main()
        {
            for (int i = 0; i < sportHalls.Count; i++)
            {
                Console.WriteLine($"In {sportHalls[i]} zijn {occupation[i][0]} scheidsrechter(s), {occupation[i][1]} sportartsen en {occupation[i][2]} sporters.");
            }
        }
    }
}
