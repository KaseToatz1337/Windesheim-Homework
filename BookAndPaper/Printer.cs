namespace BookAndPaper
{
    public class Printer
    {
        public void Print(Paper paper)
        {
            paper.TimesPrinted++;
        }

        public void Print(Book book)
        {
            book.TimesPrinted++;
        }
    }
}
