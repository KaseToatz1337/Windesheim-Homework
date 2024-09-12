namespace BookAndPaper
{
    public class Program
    {
        static void Main()
        {
            Paper paper = new();
            Book book = new();
            Printer printer = new();

            Console.WriteLine(paper.TimesPrinted);
            printer.Print(paper);
            Console.WriteLine(paper.TimesPrinted);

            Console.WriteLine(book.TimesPrinted);
            printer.Print(book);
            Console.WriteLine(book.TimesPrinted);
        }
    }
}
