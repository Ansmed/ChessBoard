namespace ChessBoard
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Board myBoard = new Board();
            myBoard.ReadSize();
            myBoard.RenderBoard();
        }
    }
}
