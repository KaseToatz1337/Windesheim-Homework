namespace Matrix
{
    public class Matrix
    {
        private Random random;
        private List<int> lengths;

        public Matrix()
        {
            random = new();
            SetLengths();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.BackgroundColor = ConsoleColor.Black;
        }

        void SetLengths()
        {
            List<int> newLengths = [];
            for (int i = 0; i < Console.WindowWidth; i++)
            {
                newLengths.Add(random.Next(0, Console.WindowHeight));
            }
            lengths = newLengths;
        }

        string GetRow(int row)
        {
            string curRow = "";
            for (int column = 0; column < lengths.Count; column++)
            {
                if (row < lengths[column])
                {
                    curRow += (char)random.Next(33, 127);
                }
                else
                {
                    curRow += ' ';
                }
            }
            return curRow;
        }

        public void Start()
        {
            while (true)
            {
                for (int row = 0; row < lengths.Max(); row++)
                {
                    Console.WriteLine(GetRow(row));
                    Thread.Sleep(50);
                }
                Console.SetCursorPosition(0, 0);
                SetLengths();
            }
        }
    }
}