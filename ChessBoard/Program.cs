namespace ChessBoard
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8; // Works on both Windows & Linux
            Board myBoard = new Board();
            myBoard.ReadSize();
            myBoard.RenderBoard();
            
        }
    }
}
